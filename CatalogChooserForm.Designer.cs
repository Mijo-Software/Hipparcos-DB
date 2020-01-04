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
			this.buttonViewTychoCatalog = new System.Windows.Forms.Button();
			this.buttonViewHipparcosCatalog = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonOpenTychoDirectory = new System.Windows.Forms.Button();
			this.buttonDownloadTychoCatalog = new System.Windows.Forms.Button();
			this.buttonDownloadHipparcosCatalog = new System.Windows.Forms.Button();
			this.labelApplicationName = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.statusStripText = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBoxChooseCatalog = new System.Windows.Forms.GroupBox();
			this.labelTychoCatalog = new System.Windows.Forms.Label();
			this.labelHipparcosCatalog = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.statusStripText.SuspendLayout();
			this.groupBoxChooseCatalog.SuspendLayout();
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
			this.buttonOpenHipparcosDirectory.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpenHipparcosDirectory.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOpenHipparcosDirectory.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpenHipparcosDirectory.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.buttonOptions.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOptions.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOptions.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOptions.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.buttonInfo.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInfo.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonInfo.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInfo.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonViewTychoCatalog
			// 
			resources.ApplyResources(this.buttonViewTychoCatalog, "buttonViewTychoCatalog");
			this.buttonViewTychoCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonViewTychoCatalog.Image = global::Hipparcos_DB.Properties.Resources.fugue_application_16px_shadowless;
			this.buttonViewTychoCatalog.Name = "buttonViewTychoCatalog";
			this.toolTip.SetToolTip(this.buttonViewTychoCatalog, resources.GetString("buttonViewTychoCatalog.ToolTip"));
			this.buttonViewTychoCatalog.UseVisualStyleBackColor = true;
			this.buttonViewTychoCatalog.Click += new System.EventHandler(this.ButtonViewTychoCatalog_Click);
			this.buttonViewTychoCatalog.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonViewTychoCatalog.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonViewTychoCatalog.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonViewTychoCatalog.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonViewHipparcosCatalog
			// 
			resources.ApplyResources(this.buttonViewHipparcosCatalog, "buttonViewHipparcosCatalog");
			this.buttonViewHipparcosCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonViewHipparcosCatalog.Image = global::Hipparcos_DB.Properties.Resources.fugue_application_16px_shadowless;
			this.buttonViewHipparcosCatalog.Name = "buttonViewHipparcosCatalog";
			this.toolTip.SetToolTip(this.buttonViewHipparcosCatalog, resources.GetString("buttonViewHipparcosCatalog.ToolTip"));
			this.buttonViewHipparcosCatalog.UseVisualStyleBackColor = true;
			this.buttonViewHipparcosCatalog.Click += new System.EventHandler(this.ButtonViewHipparcosCatalog_Click);
			this.buttonViewHipparcosCatalog.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonViewHipparcosCatalog.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonViewHipparcosCatalog.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonViewHipparcosCatalog.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.buttonExit.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonExit.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonExit.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonExit.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.buttonOpenTychoDirectory.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpenTychoDirectory.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonOpenTychoDirectory.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonOpenTychoDirectory.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonDownloadTychoCatalog
			// 
			resources.ApplyResources(this.buttonDownloadTychoCatalog, "buttonDownloadTychoCatalog");
			this.buttonDownloadTychoCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDownloadTychoCatalog.Image = global::Hipparcos_DB.Properties.Resources.fugue_drive_download_16px_shadowless;
			this.buttonDownloadTychoCatalog.Name = "buttonDownloadTychoCatalog";
			this.toolTip.SetToolTip(this.buttonDownloadTychoCatalog, resources.GetString("buttonDownloadTychoCatalog.ToolTip"));
			this.buttonDownloadTychoCatalog.UseVisualStyleBackColor = true;
			this.buttonDownloadTychoCatalog.Click += new System.EventHandler(this.ButtonDownloadTychoCatalog_Click);
			this.buttonDownloadTychoCatalog.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDownloadTychoCatalog.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonDownloadTychoCatalog.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDownloadTychoCatalog.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonDownloadHipparcosCatalog
			// 
			resources.ApplyResources(this.buttonDownloadHipparcosCatalog, "buttonDownloadHipparcosCatalog");
			this.buttonDownloadHipparcosCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDownloadHipparcosCatalog.Image = global::Hipparcos_DB.Properties.Resources.fugue_drive_download_16px_shadowless;
			this.buttonDownloadHipparcosCatalog.Name = "buttonDownloadHipparcosCatalog";
			this.toolTip.SetToolTip(this.buttonDownloadHipparcosCatalog, resources.GetString("buttonDownloadHipparcosCatalog.ToolTip"));
			this.buttonDownloadHipparcosCatalog.UseVisualStyleBackColor = true;
			this.buttonDownloadHipparcosCatalog.Click += new System.EventHandler(this.ButtonDownloadHipparcosCatalog_Click);
			this.buttonDownloadHipparcosCatalog.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDownloadHipparcosCatalog.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonDownloadHipparcosCatalog.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDownloadHipparcosCatalog.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelApplicationName
			// 
			resources.ApplyResources(this.labelApplicationName, "labelApplicationName");
			this.labelApplicationName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelApplicationName.Name = "labelApplicationName";
			this.toolTip.SetToolTip(this.labelApplicationName, resources.GetString("labelApplicationName.ToolTip"));
			this.labelApplicationName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelApplicationName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelApplicationName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelApplicationName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// pictureBox
			// 
			resources.ApplyResources(this.pictureBox, "pictureBox");
			this.pictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.pictureBox.Image = global::Hipparcos_DB.Properties.Resources.hipparcos1;
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.TabStop = false;
			this.toolTip.SetToolTip(this.pictureBox, resources.GetString("pictureBox.ToolTip"));
			this.pictureBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.pictureBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.toolStripStatusLabelInfo.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripStatusLabelInfo.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			this.groupBoxChooseCatalog.Controls.Add(this.buttonViewTychoCatalog);
			this.groupBoxChooseCatalog.Controls.Add(this.buttonViewHipparcosCatalog);
			this.groupBoxChooseCatalog.Controls.Add(this.labelHipparcosCatalog);
			this.groupBoxChooseCatalog.Name = "groupBoxChooseCatalog";
			this.groupBoxChooseCatalog.TabStop = false;
			// 
			// labelTychoCatalog
			// 
			this.labelTychoCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelTychoCatalog, "labelTychoCatalog");
			this.labelTychoCatalog.Name = "labelTychoCatalog";
			// 
			// labelHipparcosCatalog
			// 
			this.labelHipparcosCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			resources.ApplyResources(this.labelHipparcosCatalog, "labelHipparcosCatalog");
			this.labelHipparcosCatalog.Name = "labelHipparcosCatalog";
			// 
			// CatalogChooserForm
			// 
			resources.ApplyResources(this, "$this");
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonOptions);
			this.Controls.Add(this.labelApplicationName);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.buttonInfo);
			this.Controls.Add(this.groupBoxChooseCatalog);
			this.Controls.Add(this.statusStripText);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CatalogChooserForm";
			this.Load += new System.EventHandler(this.CatalogChooserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.statusStripText.ResumeLayout(false);
			this.statusStripText.PerformLayout();
			this.groupBoxChooseCatalog.ResumeLayout(false);
			this.groupBoxChooseCatalog.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStripText;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
		private System.Windows.Forms.Button buttonViewTychoCatalog;
		private System.Windows.Forms.Button buttonViewHipparcosCatalog;
		private System.Windows.Forms.GroupBox groupBoxChooseCatalog;
		private System.Windows.Forms.Button buttonInfo;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button buttonDownloadTychoCatalog;
		private System.Windows.Forms.Button buttonDownloadHipparcosCatalog;
		private System.Windows.Forms.Label labelTychoCatalog;
		private System.Windows.Forms.Label labelHipparcosCatalog;
		private System.Windows.Forms.Label labelApplicationName;
		private System.Windows.Forms.Button buttonOptions;
		private System.Windows.Forms.Button buttonOpenHipparcosDirectory;
		private System.Windows.Forms.Button buttonOpenTychoDirectory;
	}
}

