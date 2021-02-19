using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PikkaTech.Fundus.FolderManager.WinForms
{
	public partial class FolderInfoDialog : Form
	{
		public FolderInfoDialog()
		{
			InitializeComponent();
		}

		public FolderInfo FolderInfo
		{
			get
			{
				try
				{
					return (FolderInfo)this.m_pgFolderInfo.SelectedObject;
				}
				catch (Exception)
				{
					return null;
				}
			}

			set
			{
				try
				{
					this.m_pgFolderInfo.SelectedObject	= value;
				}
				catch (Exception)	{}
			}
		}
	}
}
