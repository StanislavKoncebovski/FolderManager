namespace PikkaTech.Fundus.FolderManager.WinForms
{
	partial class SolutionNameDialog
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
			this.m_txSolutionName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// m_btOk
			// 
			this.m_btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.m_btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btOk.Location = new System.Drawing.Point(13, 74);
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
			this.m_btCancel.Location = new System.Drawing.Point(124, 73);
			this.m_btCancel.Name = "m_btCancel";
			this.m_btCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btCancel.TabIndex = 2;
			this.m_btCancel.Text = "Cancel";
			this.m_btCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Solution Name:";
			// 
			// m_txSolutionName
			// 
			this.m_txSolutionName.Location = new System.Drawing.Point(13, 29);
			this.m_txSolutionName.Name = "m_txSolutionName";
			this.m_txSolutionName.Size = new System.Drawing.Size(400, 23);
			this.m_txSolutionName.TabIndex = 0;
			// 
			// SolutionNameDialog
			// 
			this.AcceptButton = this.m_btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btCancel;
			this.ClientSize = new System.Drawing.Size(425, 109);
			this.Controls.Add(this.m_txSolutionName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_btCancel);
			this.Controls.Add(this.m_btOk);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SolutionNameDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Solution Name";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btOk;
		private System.Windows.Forms.Button m_btCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_txSolutionName;
	}
}