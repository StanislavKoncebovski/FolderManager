namespace FlowerPot.Domain
{
	partial class UserDataDialog
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
			FlowerPot.Domain.UserData userData1 = new FlowerPot.Domain.UserData();
			this.m_btOk = new System.Windows.Forms.Button();
			this.m_btCancel = new System.Windows.Forms.Button();
			this._ctrlUserData = new FlowerPot.Domain.UserDataControl();
			this.SuspendLayout();
			// 
			// m_btOk
			// 
			this.m_btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.m_btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btOk.Location = new System.Drawing.Point(337, 154);
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
			this.m_btCancel.Location = new System.Drawing.Point(448, 153);
			this.m_btCancel.Name = "m_btCancel";
			this.m_btCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btCancel.TabIndex = 1;
			this.m_btCancel.Text = "Cancel";
			this.m_btCancel.UseVisualStyleBackColor = true;
			// 
			// _ctrlUserData
			// 
			this._ctrlUserData.Dock = System.Windows.Forms.DockStyle.Top;
			this._ctrlUserData.Font = new System.Drawing.Font("Consolas", 10F);
			this._ctrlUserData.Location = new System.Drawing.Point(0, 0);
			this._ctrlUserData.Margin = new System.Windows.Forms.Padding(0);
			this._ctrlUserData.Name = "_ctrlUserData";
			this._ctrlUserData.Size = new System.Drawing.Size(535, 151);
			this._ctrlUserData.TabIndex = 2;
			userData1.AuthorEmail = "";
			userData1.AuthorName = "";
			userData1.CompanyName = "";
			userData1.CompanyWebsite = "";
			userData1.HeaderWidth = 84;
			this._ctrlUserData.UserData = userData1;
			// 
			// UserDataDialog
			// 
			this.AcceptButton = this.m_btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btCancel;
			this.ClientSize = new System.Drawing.Size(535, 189);
			this.Controls.Add(this._ctrlUserData);
			this.Controls.Add(this.m_btCancel);
			this.Controls.Add(this.m_btOk);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserDataDialog";
			this.Text = "User Data";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button m_btOk;
		private System.Windows.Forms.Button m_btCancel;
		private UserDataControl _ctrlUserData;
	}
}