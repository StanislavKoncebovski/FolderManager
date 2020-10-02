/***********************************************************************************
* File:         FlowerPotConfiguratorForm.cs                                       *
* Contents:     Class FlowerPotConfiguratorForm                                    *
* Author:       Stanislav Koncebovski (Stanislav.Koncebovski@dktech.de)            *
* Date:         2019-03-02 18:54                                                   *
* Version:      1.0                                                                *
* Copyright:    D&K Technologies GmbH, Barum, Germany (www.dktech.de)              *
***********************************************************************************/
using FlowerPot.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlowerPotConfigurator
{
	public partial class FlowerPotConfiguratorForm : Form
	{
		private List<UserData>	_users			= new List<UserData>();
		private static string	_xmlFileName	= "";

		#region Construction
		static FlowerPotConfiguratorForm()
		{
			_xmlFileName						= $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\" +
												  $"{UserData.GlobalCompanyName}\\" +
												  $"{UserData.GlobalProductName}\\userData.xml";
		}

		public FlowerPotConfiguratorForm()
		{
			InitializeComponent();
			this.Text	= this.SetTitle();

			this.LoadUsersFromXml();

			this.UpdateListView();
		}
		#endregion

		#region Private Auxiliary
		private void UpdateListView()
		{
			this._lvAuthors.Items.Clear();

			foreach (UserData userData in this._users)
			{
				ListViewItem lvi = new ListViewItem
													(
														new string[]
																	{
																		userData.AuthorName, 
																		userData.AuthorEmail, 
																		userData.CompanyName, 
																		userData.CompanyWebsite, 
																		userData.HeaderWidth.ToString() 
																	}
													);
				lvi.Tag			= userData;
				this._lvAuthors.Items.Add(lvi);
			}

			this._lvAuthors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._lvAuthors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void LoadUsersFromXml()
		{
			XElement x	= null;

			try
			{
				x		= XElement.Load(_xmlFileName);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Loading XML failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this._users.Clear();

			foreach (XElement xUser in x.Elements("User"))
			{
				UserData userData	= UserData.FromXElement(xUser);
				this._users.Add(userData);
			}
		}

		private void StoreUsersToXml()
		{
			FileInfo fi	= new FileInfo(_xmlFileName);
			string folder	= fi.DirectoryName;

			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}

			XElement x	= new XElement("Users");

			foreach (UserData userData in this._users)
			{
				x.Add(userData.ToXElement());
			}

			x.Save(_xmlFileName);
		}

		private string SetTitle()
		{
			Assembly asm		= Assembly.GetAssembly(this.GetType());
			string strProduct	= asm.GetName().Name;
			string strVersion	= asm.GetName().Version.ToString();

			return $"{strProduct} ({strVersion})";
		}
		#endregion

		#region Menu Events
		private void OnAuthorsAdd(object sender, EventArgs e)
		{
			UserDataDialog udd	= new UserDataDialog();

			if (udd.ShowDialog() == DialogResult.OK)
			{
				this._users.Add(udd.UserData);
				this.UpdateListView();
				this.StoreUsersToXml();
			}
		}

		private void OnAuthorsEdit(object sender, EventArgs e)
		{
			if (this._lvAuthors.SelectedItems.Count == 1)
			{
				UserDataDialog udd	= new UserDataDialog();
				udd.UserData		= this._lvAuthors.SelectedItems[0].Tag as UserData;

				int index			= this._users.FindIndex((UserData ud) =>{return ud.AuthorName == udd.UserData.AuthorName;});

				if (udd.ShowDialog() == DialogResult.OK)
				{
					this._users[index]	= udd.UserData;
					this.UpdateListView();
					this.StoreUsersToXml();
				}
			}
		}

		private void OnAuthorsDelete(object sender, EventArgs e)
		{
			if (this._lvAuthors.SelectedItems.Count == 1)
			{
				UserData userData	= this._lvAuthors.SelectedItems[0].Tag as UserData;

				if (MessageBox.Show(userData.ToString(), "Delete user?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					this._users.Remove(userData);
					this.UpdateListView();
					this.StoreUsersToXml();
				}
			}
		}

		private void OnAuthorsSetActive(object sender, EventArgs e)
		{
			if (this._lvAuthors.SelectedItems.Count == 1)
			{
				UserData userData	= this._lvAuthors.SelectedItems[0].Tag as UserData;

				string registryKey	= $"Software\\{UserData.GlobalCompanyName}\\{UserData.GlobalProductName}";
				userData.ToRegistry(registryKey);
			}
		}

		private void OnAuthorsQuit(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnToolsSettings(object sender, EventArgs e)
		{

		}

		private void OnHelpAbout(object sender, EventArgs e)
		{
			FlowerBoxAboutBox flowerBoxAboutBox	= new FlowerBoxAboutBox();
			flowerBoxAboutBox.ShowDialog();
		}

		private void OnHelpUsage(object sender, EventArgs e)
		{
			MessageBox.Show
							(
								"FlowerPotConfigurator manages data for the FlowerPot Visual Studio extension.\n\n" + 
								"The user data are stored in an XML file under\n" +
								"C:\\Users\\UserName\\AppData\\Local\\Pikkatech\\FlowerPotConfigurator\\userData.xml.\n\n" + 
								"The currently active user is stored on registry:\n" +
								"Computer\\HKEY_CURRENT_USER\\Software\\Pikkatech\\FlowerPotConfigurator.\n\n" + 
								"The Visual Studio extension FlowerPot takes the current author's data from the registry."
							);
		}
		#endregion
	}
}
