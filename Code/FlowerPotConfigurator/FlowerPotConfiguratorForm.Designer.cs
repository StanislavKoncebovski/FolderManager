namespace FlowerPotConfigurator
{
	partial class FlowerPotConfiguratorForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowerPotConfiguratorForm));
			this._msFlowerPotConfigurator = new System.Windows.Forms.MenuStrip();
			this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._tsFlowerPotConfigurator = new System.Windows.Forms.ToolStrip();
			this._ssFlowerPotConfigurator = new System.Windows.Forms.StatusStrip();
			this._lvAuthors = new System.Windows.Forms.ListView();
			this.AuthorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AuthorEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AuthorCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CompanyWebsite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._cmsFlowerPot = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this._msFlowerPotConfigurator.SuspendLayout();
			this._cmsFlowerPot.SuspendLayout();
			this.SuspendLayout();
			// 
			// _msFlowerPotConfigurator
			// 
			this._msFlowerPotConfigurator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this._msFlowerPotConfigurator.Location = new System.Drawing.Point(0, 0);
			this._msFlowerPotConfigurator.Name = "_msFlowerPotConfigurator";
			this._msFlowerPotConfigurator.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this._msFlowerPotConfigurator.Size = new System.Drawing.Size(787, 25);
			this._msFlowerPotConfigurator.TabIndex = 0;
			this._msFlowerPotConfigurator.Text = "menuStrip1";
			// 
			// authorsToolStripMenuItem
			// 
			this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.setActiveToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
			this.authorsToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 10F);
			this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
			this.authorsToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
			this.authorsToolStripMenuItem.Text = "&Authors";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.addToolStripMenuItem.Text = "&Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.OnAuthorsAdd);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.OnAuthorsEdit);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.OnAuthorsDelete);
			// 
			// setActiveToolStripMenuItem
			// 
			this.setActiveToolStripMenuItem.Name = "setActiveToolStripMenuItem";
			this.setActiveToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.setActiveToolStripMenuItem.Text = "Set &Active";
			this.setActiveToolStripMenuItem.Click += new System.EventHandler(this.OnAuthorsSetActive);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.quitToolStripMenuItem.Text = "&Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.OnAuthorsQuit);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
			this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 10F);
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OnToolsSettings);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.usageToolStripMenuItem});
			this.helpToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 10F);
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnHelpAbout);
			// 
			// usageToolStripMenuItem
			// 
			this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
			this.usageToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.usageToolStripMenuItem.Text = "&Usage";
			this.usageToolStripMenuItem.Click += new System.EventHandler(this.OnHelpUsage);
			// 
			// _tsFlowerPotConfigurator
			// 
			this._tsFlowerPotConfigurator.Location = new System.Drawing.Point(0, 25);
			this._tsFlowerPotConfigurator.Name = "_tsFlowerPotConfigurator";
			this._tsFlowerPotConfigurator.Size = new System.Drawing.Size(787, 25);
			this._tsFlowerPotConfigurator.TabIndex = 1;
			this._tsFlowerPotConfigurator.Text = "toolStrip1";
			// 
			// _ssFlowerPotConfigurator
			// 
			this._ssFlowerPotConfigurator.Location = new System.Drawing.Point(0, 365);
			this._ssFlowerPotConfigurator.Name = "_ssFlowerPotConfigurator";
			this._ssFlowerPotConfigurator.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			this._ssFlowerPotConfigurator.Size = new System.Drawing.Size(787, 22);
			this._ssFlowerPotConfigurator.TabIndex = 2;
			this._ssFlowerPotConfigurator.Text = "statusStrip1";
			// 
			// _lvAuthors
			// 
			this._lvAuthors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AuthorName,
            this.AuthorEmail,
            this.AuthorCompanyName,
            this.CompanyWebsite,
            this.HeaderWidth});
			this._lvAuthors.ContextMenuStrip = this._cmsFlowerPot;
			this._lvAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lvAuthors.FullRowSelect = true;
			this._lvAuthors.HideSelection = false;
			this._lvAuthors.Location = new System.Drawing.Point(0, 50);
			this._lvAuthors.Margin = new System.Windows.Forms.Padding(0);
			this._lvAuthors.Name = "_lvAuthors";
			this._lvAuthors.Size = new System.Drawing.Size(787, 315);
			this._lvAuthors.TabIndex = 3;
			this._lvAuthors.UseCompatibleStateImageBehavior = false;
			this._lvAuthors.View = System.Windows.Forms.View.Details;
			// 
			// AuthorName
			// 
			this.AuthorName.Text = "Name";
			// 
			// AuthorEmail
			// 
			this.AuthorEmail.Text = "Mail";
			// 
			// AuthorCompanyName
			// 
			this.AuthorCompanyName.Text = "Company";
			// 
			// CompanyWebsite
			// 
			this.CompanyWebsite.Text = "Website";
			// 
			// HeaderWidth
			// 
			this.HeaderWidth.Text = "Header Width";
			// 
			// _cmsFlowerPot
			// 
			this._cmsFlowerPot.Font = new System.Drawing.Font("Consolas", 10F);
			this._cmsFlowerPot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
			this._cmsFlowerPot.Name = "_cmsFlowerPot";
			this._cmsFlowerPot.Size = new System.Drawing.Size(157, 92);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
			this.toolStripMenuItem1.Text = "&Add";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.OnAuthorsAdd);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
			this.toolStripMenuItem2.Text = "&Edit";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.OnAuthorsEdit);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(156, 22);
			this.toolStripMenuItem3.Text = "&Delete";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.OnAuthorsDelete);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(156, 22);
			this.toolStripMenuItem4.Text = "Set &Active";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.OnAuthorsSetActive);
			// 
			// FlowerPotConfiguratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(787, 387);
			this.Controls.Add(this._lvAuthors);
			this.Controls.Add(this._ssFlowerPotConfigurator);
			this.Controls.Add(this._tsFlowerPotConfigurator);
			this.Controls.Add(this._msFlowerPotConfigurator);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this._msFlowerPotConfigurator;
			this.Name = "FlowerPotConfiguratorForm";
			this.Text = "FlowerPot Configurator";
			this._msFlowerPotConfigurator.ResumeLayout(false);
			this._msFlowerPotConfigurator.PerformLayout();
			this._cmsFlowerPot.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip _msFlowerPotConfigurator;
		private System.Windows.Forms.ToolStrip _tsFlowerPotConfigurator;
		private System.Windows.Forms.StatusStrip _ssFlowerPotConfigurator;
		private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setActiveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
		private System.Windows.Forms.ListView _lvAuthors;
		private System.Windows.Forms.ColumnHeader AuthorName;
		private System.Windows.Forms.ColumnHeader AuthorEmail;
		private System.Windows.Forms.ColumnHeader AuthorCompanyName;
		private System.Windows.Forms.ColumnHeader CompanyWebsite;
		private System.Windows.Forms.ColumnHeader HeaderWidth;
		private System.Windows.Forms.ContextMenuStrip _cmsFlowerPot;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
	}
}

