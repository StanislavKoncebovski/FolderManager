namespace PikkaTech.Fundus.FolderManager.WinForms
{
	partial class FolderInfoDialog
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
			this.m_btOk = new System.Windows.Forms.Button();
			this.m_btCancel = new System.Windows.Forms.Button();
			this.m_pgFolderInfo = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// m_btOk
			// 
			this.m_btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.m_btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btOk.Location = new System.Drawing.Point(13, 231);
			this.m_btOk.Name = "m_btOk";
			this.m_btOk.Size = new System.Drawing.Size(75, 23);
			this.m_btOk.TabIndex = 0;
			this.m_btOk.Text = "OK";
			this.m_btOk.UseVisualStyleBackColor = true;
			// 
			// m_btCancel
			// 
			this.m_btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.m_btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btCancel.Location = new System.Drawing.Point(124, 230);
			this.m_btCancel.Name = "m_btCancel";
			this.m_btCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btCancel.TabIndex = 1;
			this.m_btCancel.Text = "Cancel";
			this.m_btCancel.UseVisualStyleBackColor = true;
			// 
			// m_pgFolderInfo
			// 
			this.m_pgFolderInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_pgFolderInfo.Location = new System.Drawing.Point(0, 0);
			this.m_pgFolderInfo.Margin = new System.Windows.Forms.Padding(0);
			this.m_pgFolderInfo.Name = "m_pgFolderInfo";
			this.m_pgFolderInfo.Size = new System.Drawing.Size(473, 227);
			this.m_pgFolderInfo.TabIndex = 2;
			// 
			// FolderInfoDialog
			// 
			this.AcceptButton = this.m_btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btCancel;
			this.ClientSize = new System.Drawing.Size(473, 261);
			this.Controls.Add(this.m_pgFolderInfo);
			this.Controls.Add(this.m_btCancel);
			this.Controls.Add(this.m_btOk);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FolderInfoDialog";
			this.Text = "Folder Info Properties";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button m_btOk;
		private System.Windows.Forms.Button m_btCancel;
		private System.Windows.Forms.PropertyGrid m_pgFolderInfo;
	}
}