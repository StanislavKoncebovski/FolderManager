/**********************************************************************************************
* File:         FolderManagerForm.cs                                                          *
* Contents:     Class FolderManagerForm                                                       *
* Author:       Alex Konnen (alex@esquisse-studio.eu)                                         *
* Date:         2014-11-07 11:05                                                              *
* Version:      1.0                                                                           *
* Copyright:    Esquisse Software Laboratories (http://www.esquisse-studio.eu/)               *
**********************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;
using PikkaTech.Fundus.PikkaBase.FileSystem;
using Microsoft.WindowsAPICodePack.Dialogs;
// using PikkaTech.Fundus.PikkaBase.FileSystem;

namespace PikkaTech.Fundus.FolderManager.WinForms
{
    public partial class FolderManagerForm : Form
	{
		#region Varialbles
		private static string		_configurationFileName =			 "Configuration.xml";

		private string				m_strCurrentTemplateFileName		= null;
		private bool				m_bIsTemplateChanged				= false;
		private bool				m_bIsIconAssignmentChanged			= false;

		private string				m_strCurrentIconAssignmentFileName	= null;

		private static Configuration Configuration						{get;set;} = new Configuration();

		internal static string		s_strThisAppDataFolder;
		internal static string		s_strTempImageFileName;

		private XElement			m_xTemplate							= null;

		private static	XElement	s_xDefaultTemplate;
		private static	XElement	s_xDefaultIconAssignmentFile;

		private Dictionary<string, string>	m_dctIconAssignments		= new Dictionary<string, string>();
		#region Default Template
		private static string	s_strDefaultTemplate			=
@"
<Folder Title=""Solution"" Icon=""Solution.ico"" EmptyFile=""True"">
  <Folder Title=""Code"" Icon=""Development.ico"">
    <Folder Title=""Binary"" Icon="""">
      <Folder Title=""Debug"" Icon="""" />
      <Folder Title=""Release"" Icon="""" />
    </Folder>
	<Folder Title = ""CSharp"" Icon=""CSharp.ico"">
	</Folder>
	<Folder Title = ""Python"" Icon=""Python.ico"">
	</Folder>
  </Folder>

  <Folder Title=""Correspondence"" Icon=""Correspondence.ico"">
    <Folder Title=""In"" Icon="""" EmptyFile=""True"" />
    <Folder Title=""Out"" Icon=""""  EmptyFile=""True"" />
  </Folder>

  <Folder Title=""Data"" Icon=""Data_Green.ico"" EmptyFile=""True"" />

  <Folder Title=""Design"" Icon=""Design.ico"" >
    <Folder Title=""Images"" Icon=""Image.ico"">
      <Folder Title=""SVG"" Icon="""" EmptyFile=""True"" />
      <Folder Title=""PNG"" Icon="""" />
      <Folder Title=""ICO"" Icon="""" />
      <Folder Title=""XCF"" Icon="""" />
    </Folder>

    <Folder Title=""UML"" Icon=""UML.ico"" EmptyFile=""True"" />

	<Folder Title=""TeX"" Icon=""TeX.ico"" EmptyFile=""True"" />
  </Folder>

  <Folder Title=""Documents"" Icon=""Document.ico"" >
    <Folder Title=""Images"" Icon=""Image.ico"">
      <Folder Title=""SVG"" Icon="""" EmptyFile=""True"" />
      <Folder Title=""PNG"" Icon="""" />
      <Folder Title=""ICO"" Icon="""" />
      <Folder Title=""XCF"" Icon="""" />
    </Folder>

    <Folder Title=""TEX"" Icon=""TEX.ico"" EmptyFile=""True"" />
    <Folder Title=""PDF"" Icon=""PDF.ico"" />
    <Folder Title=""DOC"" Icon=""DOC.ico"" />
    <!--GnuPlot-->
    <Folder Title=""PLT"" Icon=""PLT.ico"" EmptyFile=""True"" />
  </Folder>
  
  <Folder Title=""Releases"" Icon=""Release.ico"" />
  <Folder Title=""Support"" Icon=""Support.ico"" />

  <Folder Title=""Management"" Icon=""Management.ico"">
    <Folder Title=""TDL"" Icon=""TDL.ico"" EmptyFile=""True"" />
    <Folder Title=""MM"" Icon=""MM.ico"" EmptyFile=""True"" />
    <Folder Title=""MPP"" Icon=""Gantt.ico"" EmptyFile=""True"" />
  </Folder>
</Folder>
";
		#endregion

		#region Default Icon Assignment File
		private static string		s_strDefaultIconAssignmentFile =
@"
<FolderIcons>
  <Folder Name=""Data"" Icon=""Data_Green.ico"" />
  <Folder Name=""Code"" Icon=""Development.ico"" />
  <Folder Name=""Correspondence"" Icon=""Correspondence.ico"" />
  <Folder Name=""Design"" Icon=""Design.ico"" />
  <Folder Name=""DOC"" Icon=""doc.ico"" />
  <Folder Name=""doc"" Icon=""doc.ico"" />
  <Folder Name=""Documents"" Icon=""Document.ico"" />
  <Folder Name=""Document"" Icon=""Document.ico"" />
  <Folder Name=""Images"" Icon=""Image.ico"" />
  <Folder Name=""Management"" Icon=""Management.ico"" />
  <Folder Name=""MM"" Icon=""MM.ico"" />
  <Folder Name=""mm"" Icon=""MM.ico"" />
  <Folder Name=""PDF"" Icon=""pdf.ico"" />
  <Folder Name=""pdf"" Icon=""pdf.ico"" />
  <Folder Name=""PLT"" Icon=""plt.ico"" />
  <Folder Name=""plt"" Icon=""plt.ico"" />
  <Folder Name=""Release"" Icon=""Release.ico"" />
  <Folder Name=""Solution"" Icon=""Solution.ico"" />
  <Folder Name=""Solutions"" Icon=""Solution.ico"" />
  <Folder Name=""Support"" Icon=""Support.ico"" />
  <Folder Name=""TDL"" Icon=""TDL.ico"" />
  <Folder Name=""tdl"" Icon=""TDL.ico"" />
  <Folder Name=""TEX"" Icon=""tex.ico"" />
  <Folder Name=""TeX"" Icon=""TEX.ico"" />
  <Folder Name=""tex"" Icon=""tex.ico"" />
  <Folder Name=""UML"" Icon=""UML.ico"" />
  <Folder Name=""uml"" Icon=""UML.ico"" />
  <Folder Name=""Releases"" Icon=""Release.ico"" />
  <Folder Name=""Scilab"" Icon=""scilab.ico"" />
  <Folder Name=""Julia"" Icon=""julia.ico"" />
  <Folder Name=""JavaScript"" Icon=""javascript.ico"" />
  <Folder Name=""Java"" Icon=""java.ico"" />
  <Folder Name=""PHP"" Icon=""php.ico"" />
  <Folder Name=""CSharp"" Icon=""csharp.ico"" />
  <Folder Name=""CPP"" Icon=""cpp.ico"" />
  <Folder Name=""Python"" Icon=""python.ico"" />
</FolderIcons>
";
		#endregion
		#endregion

		#region Construction
		static FolderManagerForm()
		{
			s_xDefaultTemplate				= XElement.Parse(s_strDefaultTemplate);
			s_xDefaultIconAssignmentFile	= XElement.Parse(s_strDefaultIconAssignmentFile);

			if (File.Exists(_configurationFileName))
            {
				XElement x = XElement.Load(_configurationFileName);
				Configuration = Configuration.FromXElement(x);
            }
		}

		public FolderManagerForm()
		{
			InitializeComponent();

			s_strThisAppDataFolder	= Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)	+ "\\" + 
									  Configuration.PikkaTechAppDataFolder + "\\" +
									  Configuration.FundusDataFolder + "\\" +
									  Configuration.PikkaTechAppDataFolder;

			if (!Directory.Exists(s_strThisAppDataFolder))
			{
				Directory.CreateDirectory(s_strThisAppDataFolder);
			}

			s_strTempImageFileName	= s_strThisAppDataFolder + "\\temp.png";

			this.m_xTemplate		= s_xDefaultTemplate;
			UpdateFolderTreeView();

			m_dctIconAssignments.Clear();
			foreach (XElement xSub in s_xDefaultIconAssignmentFile.Elements("Folder"))
			{
				m_dctIconAssignments.Add(xSub.Attribute("Name").Value, xSub.Attribute("Icon").Value);
			}
			UpdateIconAssignmentListView();
			
		}
		#endregion

		#region Menu Events
		private void OnTemplateLoad(object sender, EventArgs e)
		{
			OpenFileDialog dlg		= new OpenFileDialog();
			dlg.Filter				= "XML Files (*.xml)|*.xml";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				this.m_xTemplate	= XElement.Load(dlg.FileName);

				UpdateFolderTreeView();

				m_bIsTemplateChanged				= false;
				this.m_lblCurrentTemplateName.Text	= dlg.FileName;
				this.m_lblTemplateChanged.Text		= " ";
			}
		}

		private void OnTemplateSave(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(this.m_strCurrentTemplateFileName))
			{
				this.m_xTemplate.Save(m_strCurrentTemplateFileName);

				m_bIsTemplateChanged			= false;
				this.m_lblTemplateChanged.Text		= " ";
			}
			else
			{
				this.OnTemplateSaveAs(sender, e);
			}
		}

		private void OnTemplateSaveAs(object sender, EventArgs e)
		{
			SaveFileDialog dlg		= new SaveFileDialog();
			dlg.Filter				= "XML Files (*.xml)|*.xml";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				this.m_xTemplate.Save(dlg.FileName);

				m_bIsTemplateChanged			= false;
				this.m_lblTemplateChanged.Text		= " ";
			}
		}

		private void OnFolderCreate(object sender, EventArgs e)
		{
			if (this.m_xTemplate == null)
			{
				MessageBox.Show
								(
									"No template is loaded", 
									"Folder structure creation not possible", 
									MessageBoxButtons.OK, 
									MessageBoxIcon.Error
								);

				return;
			}

			// Select "Solutions" Folder, in which to create a solution folder system
			CommonOpenFileDialog dlg	= new CommonOpenFileDialog();
			dlg.IsFolderPicker			= true;
			string folder				= null;

			if (dlg.ShowDialog()		== CommonFileDialogResult.Ok)
			{
				folder					= dlg.FileName;
				FileInfo fi				= new FileInfo(folder);

				if (fi.Name.ToUpper() != Configuration.DefaultSolutionsFolderName.ToUpper())
				{
					if (MessageBox.Show
										(
											String.Format("Selected folder name is not the default solutions folder name which is: \"{0}\".\nContinue?", Configuration.DefaultSolutionsFolderName), 
											"Deviating folder name", 
											MessageBoxButtons.OKCancel, 
											MessageBoxIcon.Question
										) != DialogResult.OK)
					{
						return;
					}
				}

				SolutionNameDialog snd	= new SolutionNameDialog();

				if (snd.ShowDialog() == DialogResult.OK)
				{
					string solutionName	= snd.SolutionName;

					XElement xFolder	= new XElement(this.m_xTemplate);
					xFolder.SetAttributeValue("Title", solutionName);

					this.CreateSolutionDirectory(folder, xFolder);

					MessageBox.Show(String.Format("Folder {0} has been successfully created in {1}", solutionName, folder), "Folder created", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void OnFolderAssignIcons(object sender, EventArgs e)
		{
			CommonOpenFileDialog dlg	= new CommonOpenFileDialog();
			dlg.IsFolderPicker			= true;
			string folder				= null;

			if (dlg.ShowDialog()		== CommonFileDialogResult.Ok)
			{
				folder					= dlg.FileName;

				AssignIconsRecursively(folder);

				MessageBox.Show(String.Format("Icons have been successfully assigned to subfolders of folder {0}", folder), "Icon Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void AssignIconsRecursively(string folder)
		{
			DirectoryInfo di	= new DirectoryInfo(folder);

			if (this.m_dctIconAssignments.ContainsKey(di.Name))
			{
				this.AssignIcon(folder, this.m_dctIconAssignments[di.Name]);
			}

			foreach (DirectoryInfo dj in di.GetDirectories())
			{
				AssignIconsRecursively(dj.FullName);
			}
		}

		private void OnFolderExit(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnToolsConvertSvgToIco(object sender, EventArgs e)
		{
			OpenFileDialog dlg		= new OpenFileDialog();
			dlg.Filter				= "SVG Files (*.svg)|*.svg";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				CreatePngFile(dlg.FileName);

				CreateIcoFile("temp.png", "temp.ico", new int[]{64,48,32,16});
			}
		}

		private void OnToolsExtractIcon(object sender, EventArgs e)
		{
			OpenFileDialog dlg		= new OpenFileDialog();
			dlg.Filter				= "EXE Files (*.exe)|*.exe|DLL files (*.dll)|*.dll";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					System.Drawing.Icon icon	= System.Drawing.Icon.ExtractAssociatedIcon(dlg.FileName);

					if (MessageBox.Show("Icon extracted successfully.\nChoose a file name to save it under") == DialogResult.OK)
					{
						SaveFileDialog svd	= new SaveFileDialog();
						svd.Filter			= "ICO files (*.ico)|*.ico";

						if (svd.ShowDialog() == DialogResult.OK)
						{
							FileStream fs	= new FileStream(svd.FileName, FileMode.Create, FileAccess.Write);
							icon.Save(fs);
							fs.Close();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void onHelpAbout(object sender, EventArgs e)
		{

		}

		private void OnFolderAdd(object sender, EventArgs e)
		{
			if (this.m_tvFolders.SelectedNode != null)
			{
				XElement x				= (XElement)this.m_tvFolders.SelectedNode.Tag;

				FolderInfoDialog dlg	= new FolderInfoDialog();
				dlg.FolderInfo			= new FolderInfo();

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					XElement xSub		= new XElement
														(
															"Folder", 
															new XAttribute("Title", dlg.FolderInfo.Name), 
															new XAttribute("Icon", dlg.FolderInfo.IconName), 
															new XAttribute("EmptyFile", dlg.FolderInfo.HasEmptyFile)
														);

					x.Add(xSub);

					UpdateFolderTreeView();

					if (this.m_tvFolders.Nodes.Find(xSub.Attribute("Title").Value, true).Count() == 1)
					{
						this.m_tvFolders.Nodes.Find(xSub.Attribute("Title").Value, true)[0].EnsureVisible();
					}

					m_bIsTemplateChanged			= true;
					this.m_lblTemplateChanged.Text	= "*";
				}
			}
		}

		private void OnFolderEdit(object sender, EventArgs e)
		{
			if (this.m_tvFolders.SelectedNode != null)
			{
				XElement x				= (XElement)this.m_tvFolders.SelectedNode.Tag;

				FolderInfoDialog dlg	= new FolderInfoDialog();
				dlg.FolderInfo			= new FolderInfo
														{
															Name			= x.Attribute("Title")		!= null ? x.Attribute("Title").Value : "", 
															IconName		= x.Attribute("Icon")		!= null ? x.Attribute("Icon").Value : "", 
															HasEmptyFile	= x.Attribute("EmptyFile")	!= null ? Boolean.Parse(x.Attribute("EmptyFile").Value) : false
														};

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					XElement xSub		= new XElement
														(
															"Folder", 
															new XAttribute("Title", dlg.FolderInfo.Name), 
															new XAttribute("Icon", dlg.FolderInfo.IconName), 
															new XAttribute("EmptyFile", dlg.FolderInfo.HasEmptyFile)
														);

					x.ReplaceWith(xSub);

					UpdateFolderTreeView();

					if (this.m_tvFolders.Nodes.Find(xSub.Attribute("Title").Value, true).Count() == 1)
					{
						this.m_tvFolders.Nodes.Find(xSub.Attribute("Title").Value, true)[0].EnsureVisible();
					}

					m_bIsTemplateChanged			= true;
					this.m_lblTemplateChanged.Text	= "*";
				}
			}
		}

		private void OnFolderDelete(object sender, EventArgs e)
		{
			if (this.m_tvFolders.SelectedNode != null)
			{
				XElement x				= (XElement)this.m_tvFolders.SelectedNode.Tag;
				XElement xParent		= x.Parent;

				if (xParent == null)
				{
					MessageBox.Show("Root element cannot be deleted");
					return;
				}

				if (
						MessageBox.Show
										(
											String.Format
															(
																"Replace selected folder with the following data?\nName = {0}\nIcon = {1}\nCreate Empty File = {2}", 
																x.Attribute("Title")		!= null ? x.Attribute("Title").Value : "", 
																x.Attribute("Icon")			!= null ? x.Attribute("Icon").Value : "", 
																x.Attribute("EmptyFile")	!= null ? x.Attribute("EmptyFile").Value : ""
															),
											"Folder Info Replacement",
											MessageBoxButtons.YesNo,
											MessageBoxIcon.Question
										) == DialogResult.Yes
					)
				{
					x.Remove();

					UpdateFolderTreeView();

					if (xParent != null && this.m_tvFolders.Nodes.Find(xParent.Attribute("Title").Value, true).Count() == 1)
					{
						this.m_tvFolders.Nodes.Find(xParent.Attribute("Title").Value, true)[0].EnsureVisible();
					}

					m_bIsTemplateChanged			= true;
					this.m_lblTemplateChanged.Text	= "*";
				}
			}
		}

		private void OnIconsLoadAssignmentList(object sender, EventArgs e)
		{
			OpenFileDialog dlg		= new OpenFileDialog();
			dlg.Filter				= "XML Files (*.xml)|*.xml";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				XElement x			= XElement.Load(dlg.FileName);

				foreach (XElement xSub in x.Elements("Folder"))
				{
					m_dctIconAssignments.Add(xSub.Attribute("Name").Value, xSub.Attribute("Icon").Value);
				}
			}

			UpdateIconAssignmentListView();

			m_bIsIconAssignmentChanged	= false;
		}

		private void OnIconsSaveAssignmentList(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(this.m_strCurrentIconAssignmentFileName))
			{
				XElement x				= new XElement("FolderIcons");

				foreach (string name in this.m_dctIconAssignments.Keys)
				{
					x.Add(new XElement("Folder", new XAttribute("Name", name), new XAttribute("Icon", this.m_dctIconAssignments[name])));
				}

				x.Save(m_strCurrentIconAssignmentFileName);
				m_bIsIconAssignmentChanged	= false;
			}
			else
			{
				this.OnIconsSaveAssignmentListAs(sender, e);
			}
		}

		private void OnIconsSaveAssignmentListAs(object sender, EventArgs e)
		{
			SaveFileDialog dlg	= new SaveFileDialog();
			dlg.Filter			= "XML Files (*.xml)|*.xml";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				m_strCurrentIconAssignmentFileName	= dlg.FileName;
				this.OnIconsSaveAssignmentList(sender, e);
			}
		}

		private void OnIconAssignmentAdd(object sender, EventArgs e)
		{
			IconAssignmentDialog dlg	= new IconAssignmentDialog();

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.m_dctIconAssignments.Add(dlg.FolderName, dlg.IconName);
					this.UpdateIconAssignmentListView();
					m_bIsIconAssignmentChanged	= true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void OnIconAssignmentEdit(object sender, EventArgs e)
		{
			if (this.m_lvIconAssignment.SelectedItems.Count == 1)
			{
				//this.m_dctIconAssignments.Keys.FirstOrDefault(k=>k == this.m_lvIconAssignment.SelectedItems[0].Text);
				//int index					= this.m_dctIconAssignments.Keys.OfType<string>().ToList().IndexOf(this.m_lvIconAssignment.SelectedItems[0].Text);

				IconAssignmentDialog dlg	= new IconAssignmentDialog();
				dlg.FolderName				= this.m_lvIconAssignment.SelectedItems[0].Text;
				dlg.IconName				= this.m_lvIconAssignment.SelectedItems[0].SubItems[1].Text;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					if (dlg.FolderName == this.m_lvIconAssignment.SelectedItems[0].Text)
					{
						this.m_dctIconAssignments[dlg.FolderName]	= dlg.IconName;
					}
					else
					{
						this.m_dctIconAssignments.Remove(this.m_lvIconAssignment.SelectedItems[0].Text);
						this.m_dctIconAssignments.Add(dlg.FolderName, dlg.IconName);
					}

					this.UpdateIconAssignmentListView();
					m_bIsIconAssignmentChanged	= true;
				}
			}
		}

		private void OnIconAssignmentDelete(object sender, EventArgs e)
		{
			if (this.m_lvIconAssignment.SelectedItems.Count == 1)
			{
				if (MessageBox.Show
									(
										String.Format
														(
															"Delete icon assignment {0} => {1}", 
															this.m_lvIconAssignment.SelectedItems[0].Text, 
															this.m_lvIconAssignment.SelectedItems[0].SubItems[1].Text
														), 
										"Icon Assignment deletion", 
										MessageBoxButtons.YesNo, 
										MessageBoxIcon.Question
									) == DialogResult.Yes)
				{
					this.m_dctIconAssignments.Remove(this.m_lvIconAssignment.SelectedItems[0].Text);
					this.UpdateIconAssignmentListView();
					m_bIsIconAssignmentChanged	= true;
				}
			}
		}
		#endregion

		#region Private Auxiliary
		private void CreateSolutionDirectory(string parentFolder, XElement x)
		{
			string folderName		= x.Attribute("Title").Value;
			string iconName			= x.Attribute("Icon")		!= null ? x.Attribute("Icon").Value : "";
			bool createEmptyFile	= x.Attribute("EmptyFile")	!= null ? Boolean.Parse(x.Attribute("EmptyFile").Value) : false;

			string path				= parentFolder + "\\" + folderName;

			Directory.CreateDirectory(path);

			if (!String.IsNullOrEmpty(iconName))
			{
				AssignIcon(path, iconName);
			}

			if (createEmptyFile)
			{
				StreamWriter w	= new StreamWriter(path + "\\empty.txt");
				w.WriteLine();
				w.Close();
			}

			if (folderName.ToUpper().Trim() == "TEX")
            {
				try
				{
					File.Copy($"Data\\{Configuration.RemoveJunkFileName}", $"{path}\\{Configuration.RemoveJunkFileName}");
				}
				catch {}
            }

			foreach (XElement xSubfolder in x.Elements("Folder"))
			{
				CreateSolutionDirectory(path, xSubfolder);
			}
		}

		private void AssignIcon(string path, string iconFileName)
		{
			try
			{
				FolderIconManager.AssignIcon(path, Configuration.IconFolder + "\\" + iconFileName);
			}
			catch (Exception ex)	{}
		}

		private void UpdateFolderTreeView()
		{
			this.m_tvFolders.Nodes.Clear();

			TreeNode root	= CreateNodes(this.m_xTemplate);

			this.m_tvFolders.Nodes.Add(root);

			this.m_tvFolders.ExpandAll();
		}

		private void UpdateIconAssignmentListView()
		{
			this.m_lvIconAssignment.Items.Clear();

			foreach (string folderName in this.m_dctIconAssignments.Keys)
			{
				ListViewItem lvi	= new ListViewItem(folderName);
				lvi.SubItems.Add(this.m_dctIconAssignments[folderName]);
				lvi.Tag				= folderName;

				this.m_lvIconAssignment.Items.Add(lvi);
			}

			this.m_lvIconAssignment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this.m_lvIconAssignment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private TreeNode CreateNodes(XElement x)
		{
			try
			{
				TreeNode tn	= new TreeNode(x.Attribute("Title").Value.ToString(), 0, 0);
				tn.Tag		= x;
				tn.Name		= x.Attribute("Title").Value.ToString();

				foreach (XElement xSub in x.Elements("Folder"))
				{
					TreeNode tnSub	= CreateNodes(xSub);
					tn.Nodes.Add(tnSub);
				}

				return tn;
			}
			catch (Exception)
			{
				return null;
			}
		}

		private void CreatePngFile(string fileNameSvg)
		{
			string arguments		= String.Format("-z -e {0} -w 1024 -h 1024 {1}", "temp.png", fileNameSvg);

			ProcessStartInfo psi	= new ProcessStartInfo();
			psi.FileName			= "inkscape";
			psi.Arguments			= arguments;

			Process p				= new Process();
			p.StartInfo				= psi;

			try
			{
				p.Start();
				p.WaitForExit();
				p.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void CreateIcoFile(string sourcePng, string targetIco, int[] sizes)
		{
			// convert Release.png -define icon:auto-resize=64,48,32,16 Release.ico
			string arguments		= String.Format("{0} -define icon:auto-resize=", sourcePng);

			foreach (int size in sizes)
			{
				arguments			+= String.Format("{0},", size);
			}

			arguments				= arguments.Substring(0, arguments.Length - 1);

			arguments				+= String.Format(" {0}", targetIco);

			ProcessStartInfo psi	= new ProcessStartInfo();
			psi.FileName			= @"C:\Program Files\ImageMagick-6.9.0-Q16\convert";
			psi.Arguments			= arguments;
			psi.UseShellExecute		= true;

			Process p				= new Process();
			p.StartInfo				= psi;
			
			try
			{
				p.Start();
				p.WaitForExit();
				p.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion

		#region Overridden
		protected override void OnClosing(CancelEventArgs e)
		{
			if (m_bIsTemplateChanged)
			{
				if (MessageBox.Show("Do you want to save now?", "Template file was changed and not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.OnTemplateSave(null, null);
				}
			}

			if (m_bIsIconAssignmentChanged)
			{
				if (MessageBox.Show("Do you want to save now?", "Icon assignment file was changed and not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.OnIconsSaveAssignmentList(null, null);
				}
			}

			base.OnClosing(e);
		}
        #endregion

        private void OnToolsSettings(object sender, EventArgs e)
        {
			ConfigurationDialog dialog = new ConfigurationDialog();
			dialog.Configuration = Configuration;

			if (dialog.ShowDialog() == DialogResult.OK)
            {
				Configuration = dialog.Configuration;

				XElement x	= Configuration.ToXElement();

				x.Save(_configurationFileName);
            }
        }
    }
}
