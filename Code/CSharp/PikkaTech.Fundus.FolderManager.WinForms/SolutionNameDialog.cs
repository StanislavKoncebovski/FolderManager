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
	public partial class SolutionNameDialog : Form
	{
		public SolutionNameDialog()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			this.m_txSolutionName.Focus();
		}

		public string SolutionName
		{
			get	{return this.m_txSolutionName.Text;}
			set	{this.m_txSolutionName.Text = value;}
		}
	}
}
