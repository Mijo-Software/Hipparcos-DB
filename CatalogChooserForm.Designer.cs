namespace Hipparcos_DB
{
	partial class CatalogChooserForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogChooserForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonOpenHipparcosDirectory = new System.Windows.Forms.Button();
			this.buttonOptions = new System.Windows.Forms.Button();
			this.buttonInfo = new System.Windows.Forms.Button();
			this.buttonOpenTychoCatalog = new System.Windows.Forms.Button();
			this.buttonOpenHipparcosCatalog = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonOpenTychoDirectory = new System.Windows.Forms.Button();
			this.statusStripText = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBoxChooseCatalog = new System.Windows.Forms.GroupBox();
			this.buttonDownloadTychoCatalog = new System.Windows.Forms.Button();
			this.buttonDownloadHipparcosCatalog = new System.Windows.Forms.Button();
			this.labelTychoCatalog = new System.Windows.Forms.Label();
			this.labelHipparcosCatalog = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStripText.SuspendLayout();
			this.groupBoxChooseCatalog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOpenHipparcosDirectory
			// 
			resources.ApplyResources(this.buttonOpenHipparcosDirectory, "buttonOpenHipparcosDirectory");
			this.buttonOpenHipparcosDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpenHipparcosDirectory.Image = global::Hipparcos_DB.Properties.Resources.fugue_folder_open_16px_shadowless;
			this.buttonOpenHipparcosDirectory.Name = "buttonOpenHipparcosDirectory";
			this.toolTip.SetToolTip(this.buttonOpenHipparcosDirectory, resources.GetString("buttonOpenHipparcosDirectory.ToolTip"));
			this.buttonOpenHipparcosDirectory.UseVisualStyleBackColor = true;
			this.buttonOpenHipparcosDirectory.Click += new System.EventHandler(this.ButtonOpenHipparcosDirectory_Click);
			this.buttonOpenHipparcosDirectory.Enter += new System.EventHandler(this.ButtonOpenHipparcosDirectory_Enter);
			this.buttonOpenHipparcosDirectory.Leave += new System.EventHandler(this.ButtonOpenHipparcosDirectory_Leave);
			this.buttonOpenHipparcosDirectory.MouseEnter += new System.EventHandler(this.ButtonOpenHipparcosDirectory_MouseEnter);
			this.buttonOpenHipparcosDirectory.MouseLeave += new System.EventHandler(this.ButtonOpenHipparcosDirectory_MouseLeave);
			// 
			// buttonOptions
			// 
			resources.ApplyResources(this.buttonOptions, "buttonOptions");
			this.buttonOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOptions.Image = global::Hipparcos_DB.Properties.Resources.fugue_gear_16px_shadowless;
			this.buttonOptions.Name = "buttonOptions";
			this.toolTip.SetToolTip(this.buttonOptions, resources.GetString("buttonOptions.ToolTip"));
			this.buttonOptions.UseVisualStyleBackColor = true;
			this.buttonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
			this.buttonOptions.Enter += new System.EventHandler(this.ButtonOptions_Enter);
			this.buttonOptions.Leave += new System.EventHandler(this.ButtonOptions_Leave);
			this.buttonOptions.MouseEnter += new System.EventHandler(this.ButtonOptions_MouseEnter);
			this.buttonOptions.MouseLeave += new System.EventHandler(this.ButtonOptions_MouseLeave);
			// 
			// buttonInfo
			// 
			resources.ApplyResources(this.buttonInfo, "buttonInfo");
			this.buttonInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonInfo.Image = global::Hipparcos_DB.Properties.Resources.fugue_information_button_16px_shadowless;
			this.buttonInfo.Name = "buttonInfo";
			this.toolTip.SetToolTip(this.buttonInfo, resources.GetString("buttonInfo.ToolTip"));
			this.buttonInfo.UseVisualStyleBackColor = true;
			this.buttonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
			this.buttonInfo.Enter += new System.EventHandler(this.ButtonInfo_Enter);
			this.buttonInfo.Leave += new System.EventHandler(this.ButtonInfo_Leave);
			this.buttonInfo.MouseEnter += new System.EventHandler(this.ButtonInfo_MouseEnter);
			this.buttonInfo.MouseLeave += new System.EventHandler(this.ButtonInfo_MouseLeave);
			// 
			// buttonOpenTychoCatalog
			// 
			resources.ApplyResources(this.buttonOpenTychoCatalog, "buttonOpenTychoCatalog");
			this.buttonOpenTychoCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpenTychoCatalog.Image = global::Hipparcos_DB.Properties.Resources.fugue_application_16px_shadowless;
			this.buttonOpenTychoCatalog.Name = "buttonOpenTychoCatalog";
			this.toolTip.SetToolTip(this.buttonOpenTychoCatalog, resources.GetString("buttonOpenTychoCatalog.ToolTip"));
			this.buttonOpenTychoCatalog.UseVisualStyleBackColor = true;
			this.buttonOpenTychoCatalog.Click += new System.EventHandler(this.ButtonOpenTychoCatalog_Click);
			this.buttonOpenTychoCatalog.Enter += new System.EventHandler(this.ButtonOpenTychoCatalog_Enter);
			this.buttonOpenTychoCatalog.Leave += new System.EventHandler(this.ButtonOpenTychoCatalog_Leave);
			this.buttonOpenTychoCatalog.MouseEnter += new System.EventHandler(this.ButtonOpenTychoCatalog_MouseEnter);
			this.buttonOpenTychoCatalog.MouseLeave += new System.EventHandler(this.ButtonOpenTychoCatalog_MouseLeave);
			// 
			// buttonOpenHipparcosCatalog
			// 
			resources.ApplyResources(this.buttonOpenHipparcosCatalog, "buttonOpenHipparcosCatalog");
			this.buttonOpenHipparcosCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpenHipparcosCatalog.Image = global::Hipparcos_DB.Properties.Resources.fugue_application_16px_shadowless;
			this.buttonOpenHipparcosCatalog.Name = "buttonOpenHipparcosCatalog";
			this.toolTip.SetToolTip(this.buttonOpenHipparcosCatalog, resources.GetString("buttonOpenHipparcosCatalog.ToolTip"));
			this.buttonOpenHipparcosCatalog.UseVisualStyleBackColor = true;
			this.buttonOpenHipparcosCatalog.Click += new System.EventHandler(this.ButtonOpenHipparcosCatalog_Click);
			this.buttonOpenHipparcosCatalog.Enter += new System.EventHandler(this.ButtonOpenHipparcosCatalog_Enter);
			this.buttonOpenHipparcosCatalog.Leave += new System.EventHandler(this.ButtonOpenHipparcosCatalog_Leave);
			this.buttonOpenHipparcosCatalog.MouseEnter += new System.EventHandler(this.ButtonOpenHipparcosCatalog_MouseEnter);
			this.buttonOpenHipparcosCatalog.MouseLeave += new System.EventHandler(this.ButtonOpenHipparcosCatalog_MouseLeave);
			// 
			// buttonExit
			// 
			resources.ApplyResources(this.buttonExit, "buttonExit");
			this.buttonExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonExit.BackColor = System.Drawing.Color.Transparent;
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Image = global::Hipparcos_DB.Properties.Resources.fugue_door_16px_shadowless;
			this.buttonExit.Name = "buttonExit";
			this.toolTip.SetToolTip(this.buttonExit, resources.GetString("buttonExit.ToolTip"));
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			this.buttonExit.Enter += new System.EventHandler(this.ButtonExit_Enter);
			this.buttonExit.Leave += new System.EventHandler(this.ButtonExit_Leave);
			this.buttonExit.MouseEnter += new System.EventHandler(this.ButtonExit_MouseEnter);
			this.buttonExit.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
			// 
			// buttonOpenTychoDirectory
			// 
			resources.ApplyResources(this.buttonOpenTychoDirectory, "buttonOpenTychoDirectory");
			this.buttonOpenTychoDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpenTychoDirectory.Image = global::Hipparcos_DB.Properties.Resources.fugue_folder_open_16px_shadowless;
			this.buttonOpenTychoDirectory.Name = "buttonOpenTychoDirectory";
			this.toolTip.SetToolTip(this.buttonOpenTychoDirectory, resources.GetString("buttonOpenTychoDirectory.ToolTip"));
			this.buttonOpenTychoDirectory.UseVisualStyleBackColor = true;
			this.buttonOpenTychoDirectory.Click += new System.EventHandler(this.ButtonOpenTychoDirectory_Click);
			this.buttonOpenTychoDirectory.Enter += new System.EventHandler(this.ButtonOpenTychoDirectory_Enter);
			this.buttonOpenTychoDirectory.Leave += new System.EventHandler(this.ButtonOpenTychoDirectory_Leave);
			this.buttonOpenTychoDirectory.MouseEnter += new System.EventHandler(this.ButtonOpenTychoDirectory_MouseEnter);
			this.buttonOpenTychoDirectory.MouseLeave += new System.EventHandler(this.ButtonOpenTychoDirectory_MouseLeave);
			// 
			// statusStripText
			// 
			resources.ApplyResources(this.statusStripText, "statusStripText");
			this.statusStripText.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStripText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
			this.statusStripText.Name = "statusStripText";
			this.statusStripText.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStripText.ShowItemToolTips = true;
			this.statusStripText.SizingGrip = false;
			// 
			// toolStripStatusLabelInfo
			// 
			resources.ApplyResources(this.toolStripStatusLabelInfo, "toolStripStatusLabelInfo");
			this.toolStripStatusLabelInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabelInfo.AutoToolTip = true;
			this.toolStripStatusLabelInfo.DoubleClickEnabled = true;
			this.toolStripStatusLabelInfo.Image = global::Hipparcos_DB.Properties.Resources.fugue_information_white_16px_shadowless;
			this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
			// 
			// groupBoxChooseCatalog
			// 
			resources.ApplyResources(this.groupBoxChooseCatalog, "groupBoxChooseCatalog");
			this.groupBoxChooseCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxChooseCatalog.Controls.Add(this.buttonOpenTychoDirectory);
			this.groupBoxChooseCatalog.Controls.Add(this.buttonOpenHipparcosDirectory);
			this.groupBoxChooseCatalog.Controls.Add(this.buttonDownloadTychoCatalog);
			this.groupBoxChooseCatalog.Controls.Add(this.buttonDownloadHipparcosCatalog);
			this.groupBoxChooseCatalog.Controls.Add(this.labelTychoCatalog);
			this.groupBoxChooseCatalog.Controls.Add(this.buttonOpenTychoCatalog);
			this.groupBoxChooseCatalog.Controls.Add(this.buttonOpenHipparcosCatalog);
			this.groupBoxChooseCatalog.Controls.Add(this.labelHipparcosCatalog);
			this.groupBoxChooseCatalog.Name = "groupBoxChooseCatalog";
			this.groupBoxChooseCatalog.TabStop = false;
			// 
			// buttonDownloadTychoCatalog
			// 
			resources.ApplyResources(this.buttonDownloadTychoCatalog, "buttonDownloadTychoCatalog");
			this.buttonDownloadTychoCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDownloadTychoCatalog.Image = global::Hipparcos_DB.Properties.Resources.fugue_drive_download_16px_shadowless;
			this.buttonDownloadTychoCatalog.Name = "buttonDownloadTychoCatalog";
			this.buttonDownloadTychoCatalog.UseVisualStyleBackColor = true;
			this.buttonDownloadTychoCatalog.Click += new System.EventHandler(this.ButtonDownloadTychoCatalog_Click);
			// 
			// buttonDownloadHipparcosCatalog
			// 
			resources.ApplyResources(this.buttonDownloadHipparcosCatalog, "buttonDownloadHipparcosCatalog");
			this.buttonDownloadHipparcosCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDownloadHipparcosCatalog.Image = global::Hipparcos_DB.Properties.Resources.fugue_drive_download_16px_shadowless;
			this.buttonDownloadHipparcosCatalog.Name = "buttonDownloadHipparcosCatalog";
			this.buttonDownloadHipparcosCatalog.UseVisualStyleBackColor = true;
			this.buttonDownloadHipparcosCatalog.Click += new System.EventHandler(this.ButtonDownloadHipparcosCatalog_Click);
			// 
			// labelTychoCatalog
			// 
			resources.ApplyResources(this.labelTychoCatalog, "labelTychoCatalog");
			this.labelTychoCatalog.Name = "labelTychoCatalog";
			// 
			// labelHipparcosCatalog
			// 
			resources.ApplyResources(this.labelHipparcosCatalog, "labelHipparcosCatalog");
			this.labelHipparcosCatalog.Name = "labelHipparcosCatalog";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Hipparcos_DB.Properties.Resources.hipparcos1;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// CatalogChooserForm
			// 
			resources.ApplyResources(this, "$this");
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonOptions);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonInfo);
			this.Controls.Add(this.groupBoxChooseCatalog);
			this.Controls.Add(this.statusStripText);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CatalogChooserForm";
			this.Load += new System.EventHandler(this.CatalogChooserForm_Load);
			this.statusStripText.ResumeLayout(false);
			this.statusStripText.PerformLayout();
			this.groupBoxChooseCatalog.ResumeLayout(false);
			this.groupBoxChooseCatalog.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStripText;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
		private System.Windows.Forms.Button buttonOpenTychoCatalog;
		private System.Windows.Forms.Button buttonOpenHipparcosCatalog;
		private System.Windows.Forms.GroupBox groupBoxChooseCatalog;
		private System.Windows.Forms.Button buttonInfo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonDownloadTychoCatalog;
		private System.Windows.Forms.Button buttonDownloadHipparcosCatalog;
		private System.Windows.Forms.Label labelTychoCatalog;
		private System.Windows.Forms.Label labelHipparcosCatalog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOptions;
		private System.Windows.Forms.Button buttonOpenHipparcosDirectory;
		private System.Windows.Forms.Button buttonOpenTychoDirectory;
	}
}

