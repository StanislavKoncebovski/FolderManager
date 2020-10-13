namespace PikkaTech.Fundus.FolderManager.WinForms
{
	partial class IconAssignmentDialog
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
			this.label1 = new System.Windows.Forms.Label();
			this.m_txFolderName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.m_txIconName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// m_btOk
			// 
			this.m_btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.m_btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btOk.Location = new System.Drawing.Point(13, 76);
			this.m_btOk.Name = "m_btOk";
			this.m_btOk.Size = new System.Drawing.Size(75, 23);
			this.m_btOk.TabIndex = 2;
			this.m_btOk.Text = "OK";
			this.m_btOk.UseVisualStyleBackColor = true;
			// 
			// m_btCancel
			// 
			this.m_btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.m_btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btCancel.Location = new System.Drawing.Point(124, 75);
			this.m_btCancel.Name = "m_btCancel";
			this.m_btCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btCancel.TabIndex = 3;
			this.m_btCancel.Text = "Cancel";
			this.m_btCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Folder Name";
			// 
			// m_txFolderName
			// 
			this.m_txFolderName.Location = new System.Drawing.Point(86, 9);
			this.m_txFolderName.Name = "m_txFolderName";
			this.m_txFolderName.Size = new System.Drawing.Size(369, 23);
			this.m_txFolderName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Icon Name";
			// 
			// m_txIconName
			// 
			this.m_txIconName.Location = new System.Drawing.Point(86, 38);
			this.m_txIconName.Name = "m_txIconName";
			this.m_txIconName.Size = new System.Drawing.Size(369, 23);
			this.m_txIconName.TabIndex = 1;
			// 
			// IconAssignmentDialog
			// 
			this.AcceptButton = this.m_btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btCancel;
			this.ClientSize = new System.Drawing.Size(467, 111);
			this.Controls.Add(this.m_txIconName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.m_txFolderName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_btCancel);
			this.Controls.Add(this.m_btOk);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "IconAssignmentDialog";
			this.Text = "Icon Assignment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btOk;
		private System.Windows.Forms.Button m_btCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_txFolderName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox m_txIconName;
	}
}