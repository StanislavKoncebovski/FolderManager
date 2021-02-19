using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PikkaTech.Fundus.FolderManager.WinForms
{
	public partial class OpenSvgFileControl : UserControl
	{
		public OpenSvgFileControl()
		{
			InitializeComponent();
		}

		private void OnSelectClicked(object sender, EventArgs e)
		{
			SaveFileDialog dlg	= new SaveFileDialog();
			dlg.Filter			= "ICO Files (*.ico)|*.ico";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				this.m_txTargetFileName.Text	= dlg.FileName;
			}
		}

		public SvgToPngData SvgToPngData
		{
			get
			{
				try
				{
					SvgToPngData stpd	= new SvgToPngData();

					stpd.SourceFileName	= this.m_pbPreview.ImageLocation;
					stpd.TargetFileName	= this.m_txTargetFileName.Text;
					stpd.Width			= Int32.Parse(this.m_txWidth.Text);
					stpd.Height			= Int32.Parse(this.m_txHeight.Text);

					return stpd;
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
					SvgDocument svg					= SvgDocument.Open(value.SourceFileName);
					Image png						= SvgConverter.Convert(svg, 256, 256);
					this.m_pbPreview.Image			= png;

					this.m_txTargetFileName.Text	= value.TargetFileName;
					this.m_txWidth.Text				= value.Width.ToString();
					this.m_txHeight.Text			= value.Height.ToString();
				}
				catch (Exception)	{}
			}
		}
	}
}
