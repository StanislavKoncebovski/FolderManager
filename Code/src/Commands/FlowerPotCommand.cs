/***********************************************************************************
* File:         FlowerPotCommand.cs                                                *
* Contents:     Class FlowerPotCommand                                             *
* Author:       Stanislav Koncebovski (Stanislav.Koncebovski@dktech.de)            *
* Date:         2019-03-02 18:55                                                   *
* Version:      1.0                                                                *
* Copyright:    D&K Technologies GmbH, Barum, Germany (www.dktech.de)              *
***********************************************************************************/
using System;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using EnvDTE;
using EnvDTE80;
using FlowerPot.Domain;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace FlowerPot
{
	internal sealed class FlowerPotCommand
    {
		public static string RegistryKey {get;set;}	= "";

		static FlowerPotCommand()
		{
			RegistryKey	= $"Software\\{UserData.GlobalCompanyName}\\{UserData.GlobalProductName}";
		}

		public  async Task InitializeAsync(AsyncPackage package)
        {
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
           
            var commandService = await package.GetServiceAsync((typeof(IMenuCommandService))) as OleMenuCommandService;

            // must match the button GUID and ID specified in the .vsct file
            var cmdId = new CommandID(Guid.Parse("26f0044c-03d1-489b-b523-22aa63b51d32"), 0x0100); 
            var cmd = new MenuCommand((s, e) => Execute(package), cmdId);
            commandService.AddCommand(cmd);
        }

        private void Execute(AsyncPackage package)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

			UserData userData	= UserData.FromRegistry(RegistryKey);

			if (userData != null)
			{
				this.CreateFlowerPot(userData);
			}
        }

		private void CreateFlowerPot(UserData userData)
		{
			DTE2 applicationObject = (DTE2)ServiceProvider.GlobalProvider.GetService(typeof(DTE));

			try
			{
				TextDocument textDoc	= (TextDocument)applicationObject.ActiveDocument.Object("TextDocument");
				EditPoint editPoint		= (EditPoint)textDoc.StartPoint.CreateEditPoint();

				string fileName			= applicationObject.ItemOperations.DTE.ActiveDocument.Name;
				string version			= "1.0";

				TextSelection selection = textDoc.Selection;
				selection.SelectAll();
				string text				= selection.Text;
				selection.StartOfDocument(false);

				string entity			= "Code file";
				string entityName		= "";

				string[] lines			= text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

				foreach (string line in lines)
				{
					if (line.Contains("class "))
					{
						entity				= "Class";
						Regex rxClass		= new Regex("^.*class (?'Class'\\w*)");
						entityName			= rxClass.Match(line).Groups["Class"].Value;
						break;
					}
					else if (line.Contains("interface "))
					{
						entity				= "Interface";
						Regex rxInterface	= new Regex("^.*interface (?'Interface'\\w*)");
						entityName			= rxInterface.Match(line).Groups["Interface"].Value;
						break;
					}
					else if (line.Contains("enum "))
					{
						entity				= "Enum";
						Regex rxEnum		= new Regex("^.*enum (?'Enum'\\w*)");
						entityName			= rxEnum.Match(line).Groups["Enum"].Value;
						break;
					}
					else if (line.Contains("delegate "))
					{
						entity				= "Delegate";
						Regex rxDelegate	= new Regex("^.*delegate (?'Delegate'\\w*)");
						entityName			= rxDelegate.Match(line).Groups["Delegate"].Value;
						break;
					}
				}

				string[] fileHeader			= new string[8];
				fileHeader[0]				= $"/{new string('*', userData.HeaderWidth - 1)}";
				fileHeader[1]				= $"* File:         {fileName}";
				fileHeader[2]				= $"* Contents:     {entity} {entityName}";
				fileHeader[3]				= $"* Author:       {userData.AuthorName} ({userData.AuthorEmail})";
				fileHeader[4]				= $"* Date:         {DateTime.Now.ToString("yyyy-MM-dd HH:mm")}";
				fileHeader[5]				= $"* Version:      {version}";
				fileHeader[6]				= $"* Copyright:    {userData.CompanyName} ({userData.CompanyWebsite})";
				fileHeader[7]				= $"{new string('*', userData.HeaderWidth - 1)}/";

				for (int i = 1; i <= 6; i++)
				{
					fileHeader[i]			+= new string(' ', userData.HeaderWidth - 1 - fileHeader[i].Length) + "*";
				}

				string strResult			= string.Join("\n", fileHeader) + "\n";

				editPoint.Insert(strResult);
			}
			catch	{}
		}
    }
}
