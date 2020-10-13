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
	public partial class IconAssignmentDialog : Form
	{
		public IconAssignmentDialog()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			this.m_txFolderName.Focus();
		}

		public string FolderName
		{
			get
			{
				try
				{
					return this.m_txFolderName.Text;
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
					this.m_txFolderName.Text	= value;
				}
				catch (Exception)	{}
			}
		}

		public string IconName
		{
			get
			{
				try
				{
					return this.m_txIconName.Text;
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
					this.m_txIconName.Text	= value;
				}
				catch (Exception)	{}
			}
		}
	}
}
