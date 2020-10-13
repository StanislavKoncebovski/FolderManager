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
	public partial class SvgToPngDataDialog : Form
	{
		public SvgToPngDataDialog()
		{
			InitializeComponent();
		}

		public SvgToPngData SvgToPngData
		{
			get
			{
				return this.m_ctrlOpenSvg.SvgToPngData;
			}

			set
			{
				this.m_ctrlOpenSvg.SvgToPngData = value;
			}
		}
	}
}
