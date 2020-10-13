namespace PikkaTech.Fundus.FolderManager.WinForms
{
	partial class SvgToPngDataDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			PikkaTech.Fundus.FolderManager.WinForms.SvgToPngData svgToPngData1 = new PikkaTech.Fundus.FolderManager.WinForms.SvgToPngData();
			this.m_btOk = new System.Windows.Forms.Button();
			this.m_btCancel = new System.Windows.Forms.Button();
			this.m_ctrlOpenSvg = new PikkaTech.Fundus.FolderManager.WinForms.OpenSvgFileControl();
			this.SuspendLayout();
			// 
			// m_btOk
			// 
			this.m_btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.m_btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btOk.Location = new System.Drawing.Point(13, 374);
			this.m_btOk.Name = "m_btOk";
			this.m_btOk.Size = new System.Drawing.Size(75, 23);
			this.m_btOk.TabIndex = 1;
			this.m_btOk.Text = "OK";
			this.m_btOk.UseVisualStyleBackColor = true;
			// 
			// m_btCancel
			// 
			this.m_btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.m_btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btCancel.Location = new System.Drawing.Point(124, 373);
			this.m_btCancel.Name = "m_btCancel";
			this.m_btCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btCancel.TabIndex = 2;
			this.m_btCancel.Text = "Cancel";
			this.m_btCancel.UseVisualStyleBackColor = true;
			// 
			// m_ctrlOpenSvg
			// 
			this.m_ctrlOpenSvg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_ctrlOpenSvg.Location = new System.Drawing.Point(0, 0);
			this.m_ctrlOpenSvg.Margin = new System.Windows.Forms.Padding(0);
			this.m_ctrlOpenSvg.Name = "m_ctrlOpenSvg";
			this.m_ctrlOpenSvg.Size = new System.Drawing.Size(256, 354);
			svgToPngData1.Height = 256;
			svgToPngData1.SourceFileName = null;
			svgToPngData1.TargetFileName = "";
			svgToPngData1.Width = 256;
			this.m_ctrlOpenSvg.SvgToPngData = svgToPngData1;
			this.m_ctrlOpenSvg.TabIndex = 0;
			// 
			// SvgToPngDataDialog
			// 
			this.AcceptButton = this.m_btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btCancel;
			this.ClientSize = new System.Drawing.Size(258, 409);
			this.Controls.Add(this.m_ctrlOpenSvg);
			this.Controls.Add(this.m_btCancel);
			this.Controls.Add(this.m_btOk);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SvgToPngDataDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SvgToPngDataDialog";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button m_btOk;
		private System.Windows.Forms.Button m_btCancel;
		private OpenSvgFileControl m_ctrlOpenSvg;
	}
}