namespace PikkaTech.Fundus.FolderManager.WinForms
{
	partial class OpenSvgFileControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_pbPreview = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_txTargetFileName = new System.Windows.Forms.TextBox();
			this.m_btTargetFileName = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.m_txWidth = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.m_txHeight = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.m_pbPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.m_pbPreview.Location = new System.Drawing.Point(0, 0);
			this.m_pbPreview.Name = "pictureBox1";
			this.m_pbPreview.Size = new System.Drawing.Size(256, 256);
			this.m_pbPreview.TabIndex = 0;
			this.m_pbPreview.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 263);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Target File Name:";
			// 
			// m_txTargetFileName
			// 
			this.m_txTargetFileName.Location = new System.Drawing.Point(3, 293);
			this.m_txTargetFileName.Margin = new System.Windows.Forms.Padding(0);
			this.m_txTargetFileName.Name = "m_txTargetFileName";
			this.m_txTargetFileName.Size = new System.Drawing.Size(250, 26);
			this.m_txTargetFileName.TabIndex = 1;
			// 
			// m_btTargetFileName
			// 
			this.m_btTargetFileName.Location = new System.Drawing.Point(126, 261);
			this.m_btTargetFileName.Name = "m_btTargetFileName";
			this.m_btTargetFileName.Size = new System.Drawing.Size(115, 26);
			this.m_btTargetFileName.TabIndex = 0;
			this.m_btTargetFileName.Text = "Select";
			this.m_btTargetFileName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.m_btTargetFileName.UseVisualStyleBackColor = true;
			this.m_btTargetFileName.Click += new System.EventHandler(this.OnSelectClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 328);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Width";
			// 
			// m_txWidth
			// 
			this.m_txWidth.Location = new System.Drawing.Point(55, 324);
			this.m_txWidth.Name = "m_txWidth";
			this.m_txWidth.Size = new System.Drawing.Size(46, 26);
			this.m_txWidth.TabIndex = 2;
			this.m_txWidth.Text = "256";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(155, 328);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Height";
			// 
			// m_txHeight
			// 
			this.m_txHeight.Location = new System.Drawing.Point(207, 324);
			this.m_txHeight.Name = "m_txHeight";
			this.m_txHeight.Size = new System.Drawing.Size(46, 26);
			this.m_txHeight.TabIndex = 3;
			this.m_txHeight.Text = "256";
			// 
			// OpenSvgFileControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_txHeight);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.m_txWidth);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.m_btTargetFileName);
			this.Controls.Add(this.m_txTargetFileName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_pbPreview);
			this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "OpenSvgFileControl";
			this.Size = new System.Drawing.Size(256, 354);
			((System.ComponentModel.ISupportInitialize)(this.m_pbPreview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox m_pbPreview;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_txTargetFileName;
		private System.Windows.Forms.Button m_btTargetFileName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox m_txWidth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox m_txHeight;
	}
}
