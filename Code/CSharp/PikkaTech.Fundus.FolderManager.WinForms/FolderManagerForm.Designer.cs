namespace PikkaTech.Fundus.FolderManager.WinForms
{
	partial class FolderManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderManagerForm));
            this.m_msFolderManagerForm = new System.Windows.Forms.MenuStrip();
            this.templateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAssignmentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAssignmentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAssignmentListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sVGIcoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tsFolderManagerForm = new System.Windows.Forms.ToolStrip();
            this.m_btCreateFolder = new System.Windows.Forms.ToolStripButton();
            this.m_btAssignIcons = new System.Windows.Forms.ToolStripButton();
            this.m_ssFolderManagerForm = new System.Windows.Forms.StatusStrip();
            this.m_lblCurrentTemplateName = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_lblTemplateChanged = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_scFolderManager = new System.Windows.Forms.SplitContainer();
            this.m_tvFolders = new System.Windows.Forms.TreeView();
            this.m_cmsFolders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.m_lvIconAssignment = new System.Windows.Forms.ListView();
            this.FolderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FolderIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_cmsIconAssignments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_msFolderManagerForm.SuspendLayout();
            this.m_tsFolderManagerForm.SuspendLayout();
            this.m_ssFolderManagerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_scFolderManager)).BeginInit();
            this.m_scFolderManager.Panel1.SuspendLayout();
            this.m_scFolderManager.Panel2.SuspendLayout();
            this.m_scFolderManager.SuspendLayout();
            this.m_cmsFolders.SuspendLayout();
            this.m_cmsIconAssignments.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_msFolderManagerForm
            // 
            this.m_msFolderManagerForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templateToolStripMenuItem,
            this.folderToolStripMenuItem,
            this.iconsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.m_msFolderManagerForm.Location = new System.Drawing.Point(0, 0);
            this.m_msFolderManagerForm.Name = "m_msFolderManagerForm";
            this.m_msFolderManagerForm.Size = new System.Drawing.Size(791, 24);
            this.m_msFolderManagerForm.TabIndex = 0;
            this.m_msFolderManagerForm.Text = "menuStrip1";
            // 
            // templateToolStripMenuItem
            // 
            this.templateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.templateToolStripMenuItem.Name = "templateToolStripMenuItem";
            this.templateToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.templateToolStripMenuItem.Text = "&Template";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.OnTemplateLoad);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnTemplateSave);
            // 
            // saveasToolStripMenuItem
            // 
            this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            this.saveasToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveasToolStripMenuItem.Text = "Save &as";
            this.saveasToolStripMenuItem.Click += new System.EventHandler(this.OnTemplateSaveAs);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnFolderExit);
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.assignIconsToolStripMenuItem});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.folderToolStripMenuItem.Text = "&Folder";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.createToolStripMenuItem.Text = "&Create";
            this.createToolStripMenuItem.ToolTipText = "Creates a new PikkaTech Solution Folder with subfolders and icons";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.OnFolderCreate);
            // 
            // assignIconsToolStripMenuItem
            // 
            this.assignIconsToolStripMenuItem.Name = "assignIconsToolStripMenuItem";
            this.assignIconsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.assignIconsToolStripMenuItem.Text = "&Assign Icons";
            this.assignIconsToolStripMenuItem.ToolTipText = "Assigns icons by subfolder names in an existing PikkaTecg solution folder";
            this.assignIconsToolStripMenuItem.Click += new System.EventHandler(this.OnFolderAssignIcons);
            // 
            // iconsToolStripMenuItem
            // 
            this.iconsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAssignmentListToolStripMenuItem,
            this.saveAssignmentListToolStripMenuItem,
            this.saveAssignmentListasToolStripMenuItem});
            this.iconsToolStripMenuItem.Name = "iconsToolStripMenuItem";
            this.iconsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.iconsToolStripMenuItem.Text = "&Icons";
            // 
            // loadAssignmentListToolStripMenuItem
            // 
            this.loadAssignmentListToolStripMenuItem.Name = "loadAssignmentListToolStripMenuItem";
            this.loadAssignmentListToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.loadAssignmentListToolStripMenuItem.Text = "&Load Assignment List";
            this.loadAssignmentListToolStripMenuItem.Click += new System.EventHandler(this.OnIconsLoadAssignmentList);
            // 
            // saveAssignmentListToolStripMenuItem
            // 
            this.saveAssignmentListToolStripMenuItem.Name = "saveAssignmentListToolStripMenuItem";
            this.saveAssignmentListToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveAssignmentListToolStripMenuItem.Text = "&Save Assignment List";
            this.saveAssignmentListToolStripMenuItem.Click += new System.EventHandler(this.OnIconsSaveAssignmentList);
            // 
            // saveAssignmentListasToolStripMenuItem
            // 
            this.saveAssignmentListasToolStripMenuItem.Name = "saveAssignmentListasToolStripMenuItem";
            this.saveAssignmentListasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveAssignmentListasToolStripMenuItem.Text = "Save Assignment List &as";
            this.saveAssignmentListasToolStripMenuItem.Click += new System.EventHandler(this.OnIconsSaveAssignmentListAs);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sVGIcoToolStripMenuItem,
            this.extractIconToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // sVGIcoToolStripMenuItem
            // 
            this.sVGIcoToolStripMenuItem.Name = "sVGIcoToolStripMenuItem";
            this.sVGIcoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sVGIcoToolStripMenuItem.Text = "&SVG -> Ico";
            this.sVGIcoToolStripMenuItem.ToolTipText = "Converts an SVG filei nto a multi-size ICO file";
            this.sVGIcoToolStripMenuItem.Click += new System.EventHandler(this.OnToolsConvertSvgToIco);
            // 
            // extractIconToolStripMenuItem
            // 
            this.extractIconToolStripMenuItem.Name = "extractIconToolStripMenuItem";
            this.extractIconToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extractIconToolStripMenuItem.Text = "E&xtract Icon";
            this.extractIconToolStripMenuItem.Click += new System.EventHandler(this.OnToolsExtractIcon);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "About PikkaTech Folder Manager";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.onHelpAbout);
            // 
            // m_tsFolderManagerForm
            // 
            this.m_tsFolderManagerForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_btCreateFolder,
            this.m_btAssignIcons});
            this.m_tsFolderManagerForm.Location = new System.Drawing.Point(0, 24);
            this.m_tsFolderManagerForm.Name = "m_tsFolderManagerForm";
            this.m_tsFolderManagerForm.Size = new System.Drawing.Size(791, 25);
            this.m_tsFolderManagerForm.TabIndex = 1;
            this.m_tsFolderManagerForm.Text = "toolStrip1";
            // 
            // m_btCreateFolder
            // 
            this.m_btCreateFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_btCreateFolder.Image = global::PikkaTech.Fundus.FolderManager.WinForms.Properties.Resources.FolderNew;
            this.m_btCreateFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_btCreateFolder.Name = "m_btCreateFolder";
            this.m_btCreateFolder.Size = new System.Drawing.Size(23, 22);
            this.m_btCreateFolder.Text = "Creates a new file accordint to current template";
            this.m_btCreateFolder.Click += new System.EventHandler(this.OnFolderCreate);
            // 
            // m_btAssignIcons
            // 
            this.m_btAssignIcons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_btAssignIcons.Image = global::PikkaTech.Fundus.FolderManager.WinForms.Properties.Resources.FolderPicture;
            this.m_btAssignIcons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_btAssignIcons.Name = "m_btAssignIcons";
            this.m_btAssignIcons.Size = new System.Drawing.Size(23, 22);
            this.m_btAssignIcons.Text = "Assign icons to folders according to current icon  assignment file";
            this.m_btAssignIcons.Click += new System.EventHandler(this.OnFolderAssignIcons);
            // 
            // m_ssFolderManagerForm
            // 
            this.m_ssFolderManagerForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_lblCurrentTemplateName,
            this.m_lblTemplateChanged});
            this.m_ssFolderManagerForm.Location = new System.Drawing.Point(0, 552);
            this.m_ssFolderManagerForm.Name = "m_ssFolderManagerForm";
            this.m_ssFolderManagerForm.Size = new System.Drawing.Size(791, 24);
            this.m_ssFolderManagerForm.TabIndex = 2;
            this.m_ssFolderManagerForm.Text = "statusStrip1";
            // 
            // m_lblCurrentTemplateName
            // 
            this.m_lblCurrentTemplateName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_lblCurrentTemplateName.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.m_lblCurrentTemplateName.Name = "m_lblCurrentTemplateName";
            this.m_lblCurrentTemplateName.Size = new System.Drawing.Size(96, 19);
            this.m_lblCurrentTemplateName.Text = "Default Template";
            // 
            // m_lblTemplateChanged
            // 
            this.m_lblTemplateChanged.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_lblTemplateChanged.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.m_lblTemplateChanged.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblTemplateChanged.Name = "m_lblTemplateChanged";
            this.m_lblTemplateChanged.Size = new System.Drawing.Size(13, 19);
            this.m_lblTemplateChanged.Text = " ";
            // 
            // m_scFolderManager
            // 
            this.m_scFolderManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_scFolderManager.Location = new System.Drawing.Point(0, 49);
            this.m_scFolderManager.Margin = new System.Windows.Forms.Padding(0);
            this.m_scFolderManager.Name = "m_scFolderManager";
            // 
            // m_scFolderManager.Panel1
            // 
            this.m_scFolderManager.Panel1.Controls.Add(this.m_tvFolders);
            // 
            // m_scFolderManager.Panel2
            // 
            this.m_scFolderManager.Panel2.Controls.Add(this.m_lvIconAssignment);
            this.m_scFolderManager.Size = new System.Drawing.Size(791, 503);
            this.m_scFolderManager.SplitterDistance = 263;
            this.m_scFolderManager.TabIndex = 3;
            // 
            // m_tvFolders
            // 
            this.m_tvFolders.ContextMenuStrip = this.m_cmsFolders;
            this.m_tvFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tvFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tvFolders.ImageIndex = 0;
            this.m_tvFolders.ImageList = this.m_ilIcons;
            this.m_tvFolders.Location = new System.Drawing.Point(0, 0);
            this.m_tvFolders.Margin = new System.Windows.Forms.Padding(0);
            this.m_tvFolders.Name = "m_tvFolders";
            this.m_tvFolders.SelectedImageIndex = 0;
            this.m_tvFolders.Size = new System.Drawing.Size(263, 503);
            this.m_tvFolders.TabIndex = 0;
            // 
            // m_cmsFolders
            // 
            this.m_cmsFolders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.m_cmsFolders.Name = "m_cmsFolders";
            this.m_cmsFolders.Size = new System.Drawing.Size(108, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.OnFolderAdd);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.OnFolderEdit);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.OnFolderDelete);
            // 
            // m_ilIcons
            // 
            this.m_ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_ilIcons.ImageStream")));
            this.m_ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.m_ilIcons.Images.SetKeyName(0, "Folder");
            // 
            // m_lvIconAssignment
            // 
            this.m_lvIconAssignment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FolderName,
            this.FolderIcon});
            this.m_lvIconAssignment.ContextMenuStrip = this.m_cmsIconAssignments;
            this.m_lvIconAssignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_lvIconAssignment.FullRowSelect = true;
            this.m_lvIconAssignment.GridLines = true;
            this.m_lvIconAssignment.HideSelection = false;
            this.m_lvIconAssignment.Location = new System.Drawing.Point(0, 0);
            this.m_lvIconAssignment.Margin = new System.Windows.Forms.Padding(0);
            this.m_lvIconAssignment.Name = "m_lvIconAssignment";
            this.m_lvIconAssignment.Size = new System.Drawing.Size(524, 503);
            this.m_lvIconAssignment.TabIndex = 0;
            this.m_lvIconAssignment.UseCompatibleStateImageBehavior = false;
            this.m_lvIconAssignment.View = System.Windows.Forms.View.Details;
            // 
            // FolderName
            // 
            this.FolderName.Text = "Folder Name";
            this.FolderName.Width = 90;
            // 
            // FolderIcon
            // 
            this.FolderIcon.Text = "Folder Icon";
            this.FolderIcon.Width = 92;
            // 
            // m_cmsIconAssignments
            // 
            this.m_cmsIconAssignments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.m_cmsIconAssignments.Name = "m_cmsIconAssignments";
            this.m_cmsIconAssignments.Size = new System.Drawing.Size(108, 70);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem1.Text = "&Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.OnIconAssignmentAdd);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem1.Text = "&Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.OnIconAssignmentEdit);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "&Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.OnIconAssignmentDelete);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OnToolsSettings);
            // 
            // FolderManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(791, 576);
            this.Controls.Add(this.m_scFolderManager);
            this.Controls.Add(this.m_ssFolderManagerForm);
            this.Controls.Add(this.m_tsFolderManagerForm);
            this.Controls.Add(this.m_msFolderManagerForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_msFolderManagerForm;
            this.Name = "FolderManagerForm";
            this.Text = "PikkaTech Folder Manager";
            this.m_msFolderManagerForm.ResumeLayout(false);
            this.m_msFolderManagerForm.PerformLayout();
            this.m_tsFolderManagerForm.ResumeLayout(false);
            this.m_tsFolderManagerForm.PerformLayout();
            this.m_ssFolderManagerForm.ResumeLayout(false);
            this.m_ssFolderManagerForm.PerformLayout();
            this.m_scFolderManager.Panel1.ResumeLayout(false);
            this.m_scFolderManager.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_scFolderManager)).EndInit();
            this.m_scFolderManager.ResumeLayout(false);
            this.m_cmsFolders.ResumeLayout(false);
            this.m_cmsIconAssignments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip m_msFolderManagerForm;
		private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem assignIconsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sVGIcoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStrip m_tsFolderManagerForm;
		private System.Windows.Forms.StatusStrip m_ssFolderManagerForm;
		private System.Windows.Forms.ToolStripMenuItem extractIconToolStripMenuItem;
		private System.Windows.Forms.SplitContainer m_scFolderManager;
		private System.Windows.Forms.TreeView m_tvFolders;
		private System.Windows.Forms.ListView m_lvIconAssignment;
		private System.Windows.Forms.ImageList m_ilIcons;
		private System.Windows.Forms.ContextMenuStrip m_cmsFolders;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem templateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripStatusLabel m_lblCurrentTemplateName;
		private System.Windows.Forms.ToolStripStatusLabel m_lblTemplateChanged;
		private System.Windows.Forms.ToolStripMenuItem iconsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadAssignmentListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAssignmentListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAssignmentListasToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader FolderName;
		private System.Windows.Forms.ColumnHeader FolderIcon;
		private System.Windows.Forms.ContextMenuStrip m_cmsIconAssignments;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.Windows.Forms.ToolStripButton m_btCreateFolder;
		private System.Windows.Forms.ToolStripButton m_btAssignIcons;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

