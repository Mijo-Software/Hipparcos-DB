namespace Hipparcos_DB
{
	partial class OptionsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.groupBoxQuickDownload = new System.Windows.Forms.GroupBox();
			this.checkBoxEnableQuickDownload = new System.Windows.Forms.CheckBox();
			this.labelDefaultHost = new System.Windows.Forms.Label();
			this.textBoxDefaultHost = new System.Windows.Forms.TextBox();
			this.groupBoxDataTableStyle = new System.Windows.Forms.GroupBox();
			this.labelDataTableStyle = new System.Windows.Forms.Label();
			this.comboBoxDataTableStyle = new System.Windows.Forms.ComboBox();
			this.groupBoxCopyDataMethod = new System.Windows.Forms.GroupBox();
			this.comboBoxCopyDataMethod = new System.Windows.Forms.ComboBox();
			this.labelCopyDataMethod = new System.Windows.Forms.Label();
			this.groupBoxHoverEffect = new System.Windows.Forms.GroupBox();
			this.checkBoxEnableHoverEffect = new System.Windows.Forms.CheckBox();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBoxCatalogDirectories = new System.Windows.Forms.GroupBox();
			this.textBoxHipparcosDirectory = new System.Windows.Forms.TextBox();
			this.labelHipparcosDirectory = new System.Windows.Forms.Label();
			this.textBoxTychoDirectory = new System.Windows.Forms.TextBox();
			this.labelTychoDirectory = new System.Windows.Forms.Label();
			this.buttonRestoreHost = new System.Windows.Forms.Button();
			this.buttonRestoreHipparcosDirectory = new System.Windows.Forms.Button();
			this.buttonRestoreTychoDirectory = new System.Windows.Forms.Button();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.groupBoxQuickDownload.SuspendLayout();
			this.groupBoxDataTableStyle.SuspendLayout();
			this.groupBoxCopyDataMethod.SuspendLayout();
			this.groupBoxHoverEffect.SuspendLayout();
			this.groupBoxCatalogDirectories.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Status bar with some information";
			this.statusStrip.AccessibleName = "Information status bar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(396, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxCatalogDirectories);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxHoverEffect);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxCopyDataMethod);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxDataTableStyle);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxQuickDownload);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonCancel);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonApply);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(396, 278);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(396, 300);
			this.toolStripContainer.TabIndex = 0;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// groupBoxQuickDownload
			// 
			this.groupBoxQuickDownload.Controls.Add(this.buttonRestoreHost);
			this.groupBoxQuickDownload.Controls.Add(this.textBoxDefaultHost);
			this.groupBoxQuickDownload.Controls.Add(this.labelDefaultHost);
			this.groupBoxQuickDownload.Controls.Add(this.checkBoxEnableQuickDownload);
			this.groupBoxQuickDownload.Location = new System.Drawing.Point(12, 122);
			this.groupBoxQuickDownload.Name = "groupBoxQuickDownload";
			this.groupBoxQuickDownload.Size = new System.Drawing.Size(371, 69);
			this.groupBoxQuickDownload.TabIndex = 5;
			this.groupBoxQuickDownload.TabStop = false;
			this.groupBoxQuickDownload.Text = "Quick download";
			// 
			// checkBoxEnableQuickDownload
			// 
			this.checkBoxEnableQuickDownload.AutoSize = true;
			this.checkBoxEnableQuickDownload.Location = new System.Drawing.Point(7, 20);
			this.checkBoxEnableQuickDownload.Name = "checkBoxEnableQuickDownload";
			this.checkBoxEnableQuickDownload.Size = new System.Drawing.Size(208, 17);
			this.checkBoxEnableQuickDownload.TabIndex = 0;
			this.checkBoxEnableQuickDownload.Text = "Enable quick download of catalog files";
			this.checkBoxEnableQuickDownload.UseVisualStyleBackColor = true;
			this.checkBoxEnableQuickDownload.CheckedChanged += new System.EventHandler(this.CheckBoxEnableQuickDownload_CheckedChanged);
			this.checkBoxEnableQuickDownload.Enter += new System.EventHandler(this.CheckBoxEnableQuickDownload_Enter);
			this.checkBoxEnableQuickDownload.Leave += new System.EventHandler(this.CheckBoxEnableQuickDownload_Leave);
			this.checkBoxEnableQuickDownload.MouseEnter += new System.EventHandler(this.CheckBoxEnableQuickDownload_MouseEnter);
			this.checkBoxEnableQuickDownload.MouseLeave += new System.EventHandler(this.CheckBoxEnableQuickDownload_MouseLeave);
			// 
			// labelDefaultHost
			// 
			this.labelDefaultHost.AutoSize = true;
			this.labelDefaultHost.Location = new System.Drawing.Point(7, 44);
			this.labelDefaultHost.Name = "labelDefaultHost";
			this.labelDefaultHost.Size = new System.Drawing.Size(67, 13);
			this.labelDefaultHost.TabIndex = 1;
			this.labelDefaultHost.Text = "Default host:";
			this.labelDefaultHost.Enter += new System.EventHandler(this.LabelDefaultHost_Enter);
			this.labelDefaultHost.Leave += new System.EventHandler(this.LabelDefaultHost_Leave);
			this.labelDefaultHost.MouseEnter += new System.EventHandler(this.LabelDefaultHost_MouseEnter);
			this.labelDefaultHost.MouseLeave += new System.EventHandler(this.LabelDefaultHost_MouseLeave);
			// 
			// textBoxDefaultHost
			// 
			this.textBoxDefaultHost.Location = new System.Drawing.Point(80, 41);
			this.textBoxDefaultHost.Name = "textBoxDefaultHost";
			this.textBoxDefaultHost.Size = new System.Drawing.Size(250, 20);
			this.textBoxDefaultHost.TabIndex = 2;
			this.textBoxDefaultHost.Text = "http://cdsarc.u-strasbg.fr/ftp/I/239/";
			this.textBoxDefaultHost.Enter += new System.EventHandler(this.TextBoxDefaultHost_Enter);
			this.textBoxDefaultHost.Leave += new System.EventHandler(this.TextBoxDefaultHost_Leave);
			this.textBoxDefaultHost.MouseEnter += new System.EventHandler(this.TextBoxDefaultHost_MouseEnter);
			this.textBoxDefaultHost.MouseLeave += new System.EventHandler(this.TextBoxDefaultHost_MouseLeave);
			// 
			// groupBoxDataTableStyle
			// 
			this.groupBoxDataTableStyle.Controls.Add(this.comboBoxDataTableStyle);
			this.groupBoxDataTableStyle.Controls.Add(this.labelDataTableStyle);
			this.groupBoxDataTableStyle.Location = new System.Drawing.Point(201, 63);
			this.groupBoxDataTableStyle.Name = "groupBoxDataTableStyle";
			this.groupBoxDataTableStyle.Size = new System.Drawing.Size(182, 53);
			this.groupBoxDataTableStyle.TabIndex = 4;
			this.groupBoxDataTableStyle.TabStop = false;
			this.groupBoxDataTableStyle.Text = "Data table style";
			// 
			// labelDataTableStyle
			// 
			this.labelDataTableStyle.AutoSize = true;
			this.labelDataTableStyle.Location = new System.Drawing.Point(6, 22);
			this.labelDataTableStyle.Name = "labelDataTableStyle";
			this.labelDataTableStyle.Size = new System.Drawing.Size(33, 13);
			this.labelDataTableStyle.TabIndex = 0;
			this.labelDataTableStyle.Text = "Style:";
			this.labelDataTableStyle.Enter += new System.EventHandler(this.LabelDataTableStyle_Enter);
			this.labelDataTableStyle.Leave += new System.EventHandler(this.LabelDataTableStyle_Leave);
			this.labelDataTableStyle.MouseEnter += new System.EventHandler(this.LabelDataTableStyle_MouseEnter);
			this.labelDataTableStyle.MouseLeave += new System.EventHandler(this.LabelDataTableStyle_MouseLeave);
			// 
			// comboBoxDataTableStyle
			// 
			this.comboBoxDataTableStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDataTableStyle.FormattingEnabled = true;
			this.comboBoxDataTableStyle.Items.AddRange(new object[] {
            "Outset double",
            "Inset double"});
			this.comboBoxDataTableStyle.Location = new System.Drawing.Point(45, 19);
			this.comboBoxDataTableStyle.Name = "comboBoxDataTableStyle";
			this.comboBoxDataTableStyle.Size = new System.Drawing.Size(131, 21);
			this.comboBoxDataTableStyle.TabIndex = 1;
			this.comboBoxDataTableStyle.Enter += new System.EventHandler(this.ComboBoxDataTableStyle_Enter);
			this.comboBoxDataTableStyle.Leave += new System.EventHandler(this.ComboBoxDataTableStyle_Leave);
			this.comboBoxDataTableStyle.MouseEnter += new System.EventHandler(this.ComboBoxDataTableStyle_MouseEnter);
			this.comboBoxDataTableStyle.MouseLeave += new System.EventHandler(this.ComboBoxDataTableStyle_MouseLeave);
			// 
			// groupBoxCopyDataMethod
			// 
			this.groupBoxCopyDataMethod.Controls.Add(this.comboBoxCopyDataMethod);
			this.groupBoxCopyDataMethod.Controls.Add(this.labelCopyDataMethod);
			this.groupBoxCopyDataMethod.Location = new System.Drawing.Point(12, 63);
			this.groupBoxCopyDataMethod.Name = "groupBoxCopyDataMethod";
			this.groupBoxCopyDataMethod.Size = new System.Drawing.Size(182, 53);
			this.groupBoxCopyDataMethod.TabIndex = 3;
			this.groupBoxCopyDataMethod.TabStop = false;
			this.groupBoxCopyDataMethod.Text = "Copy data method";
			// 
			// comboBoxCopyDataMethod
			// 
			this.comboBoxCopyDataMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCopyDataMethod.FormattingEnabled = true;
			this.comboBoxCopyDataMethod.Items.AddRange(new object[] {
            "Double click",
            "Right mouse click"});
			this.comboBoxCopyDataMethod.Location = new System.Drawing.Point(58, 19);
			this.comboBoxCopyDataMethod.Name = "comboBoxCopyDataMethod";
			this.comboBoxCopyDataMethod.Size = new System.Drawing.Size(118, 21);
			this.comboBoxCopyDataMethod.TabIndex = 1;
			this.comboBoxCopyDataMethod.Enter += new System.EventHandler(this.ComboBoxCopyDataMethod_Enter);
			this.comboBoxCopyDataMethod.Leave += new System.EventHandler(this.ComboBoxCopyDataMethod_Leave);
			this.comboBoxCopyDataMethod.MouseEnter += new System.EventHandler(this.ComboBoxCopyDataMethod_MouseEnter);
			this.comboBoxCopyDataMethod.MouseLeave += new System.EventHandler(this.ComboBoxCopyDataMethod_MouseLeave);
			// 
			// labelCopyDataMethod
			// 
			this.labelCopyDataMethod.AutoSize = true;
			this.labelCopyDataMethod.Location = new System.Drawing.Point(6, 22);
			this.labelCopyDataMethod.Name = "labelCopyDataMethod";
			this.labelCopyDataMethod.Size = new System.Drawing.Size(46, 13);
			this.labelCopyDataMethod.TabIndex = 0;
			this.labelCopyDataMethod.Text = "Method:";
			this.labelCopyDataMethod.Enter += new System.EventHandler(this.LabelCopyDataMethod_Enter);
			this.labelCopyDataMethod.Leave += new System.EventHandler(this.LabelCopyDataMethod_Leave);
			this.labelCopyDataMethod.MouseEnter += new System.EventHandler(this.LabelCopyDataMethod_MouseEnter);
			this.labelCopyDataMethod.MouseLeave += new System.EventHandler(this.LabelCopyDataMethod_MouseLeave);
			// 
			// groupBoxHoverEffect
			// 
			this.groupBoxHoverEffect.Controls.Add(this.checkBoxEnableHoverEffect);
			this.groupBoxHoverEffect.Location = new System.Drawing.Point(12, 12);
			this.groupBoxHoverEffect.Name = "groupBoxHoverEffect";
			this.groupBoxHoverEffect.Size = new System.Drawing.Size(182, 45);
			this.groupBoxHoverEffect.TabIndex = 2;
			this.groupBoxHoverEffect.TabStop = false;
			this.groupBoxHoverEffect.Text = "Hover effect";
			// 
			// checkBoxEnableHoverEffect
			// 
			this.checkBoxEnableHoverEffect.AutoSize = true;
			this.checkBoxEnableHoverEffect.Checked = true;
			this.checkBoxEnableHoverEffect.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxEnableHoverEffect.Location = new System.Drawing.Point(9, 19);
			this.checkBoxEnableHoverEffect.Name = "checkBoxEnableHoverEffect";
			this.checkBoxEnableHoverEffect.Size = new System.Drawing.Size(119, 17);
			this.checkBoxEnableHoverEffect.TabIndex = 0;
			this.checkBoxEnableHoverEffect.Text = "Enable hover effect";
			this.checkBoxEnableHoverEffect.UseVisualStyleBackColor = true;
			this.checkBoxEnableHoverEffect.Enter += new System.EventHandler(this.CheckBoxEnableHoverEffect_Enter);
			this.checkBoxEnableHoverEffect.Leave += new System.EventHandler(this.CheckBoxEnableHoverEffect_Leave);
			this.checkBoxEnableHoverEffect.MouseEnter += new System.EventHandler(this.CheckBoxEnableHoverEffect_MouseEnter);
			this.checkBoxEnableHoverEffect.MouseLeave += new System.EventHandler(this.CheckBoxEnableHoverEffect_MouseLeave);
			// 
			// buttonApply
			// 
			this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonApply.Image = global::Hipparcos_DB.Properties.Resources.fugue_tick_button_16px_shadowless;
			this.buttonApply.Location = new System.Drawing.Point(210, 25);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 0;
			this.buttonApply.Text = "&Apply";
			this.buttonApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
			this.buttonApply.Enter += new System.EventHandler(this.ButtonApply_Enter);
			this.buttonApply.Leave += new System.EventHandler(this.ButtonApply_Leave);
			this.buttonApply.MouseEnter += new System.EventHandler(this.ButtonApply_MouseEnter);
			this.buttonApply.MouseLeave += new System.EventHandler(this.ButtonApply_MouseLeave);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Image = global::Hipparcos_DB.Properties.Resources.fugue_cross_16px_shadowless;
			this.buttonCancel.Location = new System.Drawing.Point(302, 25);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			this.buttonCancel.Enter += new System.EventHandler(this.ButtonCancel_Enter);
			this.buttonCancel.Leave += new System.EventHandler(this.ButtonCancel_Leave);
			this.buttonCancel.MouseEnter += new System.EventHandler(this.ButtonCancel_MouseEnter);
			this.buttonCancel.MouseLeave += new System.EventHandler(this.ButtonCancel_MouseLeave);
			// 
			// toolStripStatusLabelInfo
			// 
			this.toolStripStatusLabelInfo.AccessibleDescription = "text with some information";
			this.toolStripStatusLabelInfo.AccessibleName = "information text";
			this.toolStripStatusLabelInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabelInfo.AutoToolTip = true;
			this.toolStripStatusLabelInfo.DoubleClickEnabled = true;
			this.toolStripStatusLabelInfo.Image = global::Hipparcos_DB.Properties.Resources.fugue_information_white_16px_shadowless;
			this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
			this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(66, 17);
			this.toolStripStatusLabelInfo.Text = "info text";
			this.toolStripStatusLabelInfo.MouseEnter += new System.EventHandler(this.ToolStripStatusLabelInfo_MouseEnter);
			this.toolStripStatusLabelInfo.MouseLeave += new System.EventHandler(this.ToolStripStatusLabelInfo_MouseLeave);
			// 
			// groupBoxCatalogDirectories
			// 
			this.groupBoxCatalogDirectories.Controls.Add(this.buttonRestoreTychoDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.buttonRestoreHipparcosDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.textBoxTychoDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.labelTychoDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.textBoxHipparcosDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.labelHipparcosDirectory);
			this.groupBoxCatalogDirectories.Location = new System.Drawing.Point(12, 197);
			this.groupBoxCatalogDirectories.Name = "groupBoxCatalogDirectories";
			this.groupBoxCatalogDirectories.Size = new System.Drawing.Size(371, 69);
			this.groupBoxCatalogDirectories.TabIndex = 6;
			this.groupBoxCatalogDirectories.TabStop = false;
			this.groupBoxCatalogDirectories.Text = "Catalog directories";
			// 
			// textBoxHipparcosDirectory
			// 
			this.textBoxHipparcosDirectory.Location = new System.Drawing.Point(114, 13);
			this.textBoxHipparcosDirectory.Name = "textBoxHipparcosDirectory";
			this.textBoxHipparcosDirectory.Size = new System.Drawing.Size(216, 20);
			this.textBoxHipparcosDirectory.TabIndex = 1;
			this.textBoxHipparcosDirectory.Text = "catalog/i239/";
			this.textBoxHipparcosDirectory.Enter += new System.EventHandler(this.TextBoxHipparcosDirectory_Enter);
			this.textBoxHipparcosDirectory.Leave += new System.EventHandler(this.TextBoxHipparcosDirectory_Leave);
			this.textBoxHipparcosDirectory.MouseEnter += new System.EventHandler(this.TextBoxHipparcosDirectory_MouseEnter);
			this.textBoxHipparcosDirectory.MouseLeave += new System.EventHandler(this.TextBoxHipparcosDirectory_MouseLeave);
			// 
			// labelHipparcosDirectory
			// 
			this.labelHipparcosDirectory.AutoSize = true;
			this.labelHipparcosDirectory.Location = new System.Drawing.Point(6, 16);
			this.labelHipparcosDirectory.Name = "labelHipparcosDirectory";
			this.labelHipparcosDirectory.Size = new System.Drawing.Size(102, 13);
			this.labelHipparcosDirectory.TabIndex = 0;
			this.labelHipparcosDirectory.Text = "Hippparcos catalog:";
			this.labelHipparcosDirectory.Enter += new System.EventHandler(this.LabelHipparcosDirectory_Enter);
			this.labelHipparcosDirectory.Leave += new System.EventHandler(this.LabelHipparcosDirectory_Leave);
			this.labelHipparcosDirectory.MouseEnter += new System.EventHandler(this.LabelHipparcosDirectory_MouseEnter);
			this.labelHipparcosDirectory.MouseLeave += new System.EventHandler(this.LabelHipparcosDirectory_MouseLeave);
			// 
			// textBoxTychoDirectory
			// 
			this.textBoxTychoDirectory.Location = new System.Drawing.Point(114, 39);
			this.textBoxTychoDirectory.Name = "textBoxTychoDirectory";
			this.textBoxTychoDirectory.Size = new System.Drawing.Size(216, 20);
			this.textBoxTychoDirectory.TabIndex = 4;
			this.textBoxTychoDirectory.Text = "catalog/i239/";
			this.textBoxTychoDirectory.Enter += new System.EventHandler(this.TextBoxTychoDirectory_Enter);
			this.textBoxTychoDirectory.Leave += new System.EventHandler(this.TextBoxTychoDirectory_Leave);
			this.textBoxTychoDirectory.MouseEnter += new System.EventHandler(this.TextBoxTychoDirectory_MouseEnter);
			this.textBoxTychoDirectory.MouseLeave += new System.EventHandler(this.TextBoxTychoDirectory_MouseLeave);
			// 
			// labelTychoDirectory
			// 
			this.labelTychoDirectory.AutoSize = true;
			this.labelTychoDirectory.Location = new System.Drawing.Point(6, 42);
			this.labelTychoDirectory.Name = "labelTychoDirectory";
			this.labelTychoDirectory.Size = new System.Drawing.Size(78, 13);
			this.labelTychoDirectory.TabIndex = 3;
			this.labelTychoDirectory.Text = "Tycho catalog:";
			this.labelTychoDirectory.Enter += new System.EventHandler(this.LabelTychoDirectory_Enter);
			this.labelTychoDirectory.Leave += new System.EventHandler(this.LabelTychoDirectory_Leave);
			this.labelTychoDirectory.MouseEnter += new System.EventHandler(this.LabelTychoDirectory_MouseEnter);
			this.labelTychoDirectory.MouseLeave += new System.EventHandler(this.LabelTychoDirectory_MouseLeave);
			// 
			// buttonRestoreHost
			// 
			this.buttonRestoreHost.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_curve_180_left_shadowless;
			this.buttonRestoreHost.Location = new System.Drawing.Point(336, 40);
			this.buttonRestoreHost.Name = "buttonRestoreHost";
			this.buttonRestoreHost.Size = new System.Drawing.Size(29, 23);
			this.buttonRestoreHost.TabIndex = 3;
			this.buttonRestoreHost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonRestoreHost, "Restore host");
			this.buttonRestoreHost.UseVisualStyleBackColor = true;
			this.buttonRestoreHost.Click += new System.EventHandler(this.ButtonRestoreHost_Click);
			this.buttonRestoreHost.Enter += new System.EventHandler(this.ButtonRestoreHost_Enter);
			this.buttonRestoreHost.Leave += new System.EventHandler(this.ButtonRestoreHost_Leave);
			this.buttonRestoreHost.MouseEnter += new System.EventHandler(this.ButtonRestoreHost_MouseEnter);
			this.buttonRestoreHost.MouseLeave += new System.EventHandler(this.ButtonRestoreHost_MouseLeave);
			// 
			// buttonRestoreHipparcosDirectory
			// 
			this.buttonRestoreHipparcosDirectory.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_curve_180_left_shadowless;
			this.buttonRestoreHipparcosDirectory.Location = new System.Drawing.Point(336, 11);
			this.buttonRestoreHipparcosDirectory.Name = "buttonRestoreHipparcosDirectory";
			this.buttonRestoreHipparcosDirectory.Size = new System.Drawing.Size(29, 23);
			this.buttonRestoreHipparcosDirectory.TabIndex = 2;
			this.buttonRestoreHipparcosDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonRestoreHipparcosDirectory, "Restore Hipparcos catalog directory");
			this.buttonRestoreHipparcosDirectory.UseVisualStyleBackColor = true;
			this.buttonRestoreHipparcosDirectory.Click += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_Click);
			this.buttonRestoreHipparcosDirectory.Enter += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_Enter);
			this.buttonRestoreHipparcosDirectory.Leave += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_Leave);
			this.buttonRestoreHipparcosDirectory.MouseEnter += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_MouseEnter);
			this.buttonRestoreHipparcosDirectory.MouseLeave += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_MouseLeave);
			// 
			// buttonRestoreTychoDirectory
			// 
			this.buttonRestoreTychoDirectory.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_curve_180_left_shadowless;
			this.buttonRestoreTychoDirectory.Location = new System.Drawing.Point(336, 37);
			this.buttonRestoreTychoDirectory.Name = "buttonRestoreTychoDirectory";
			this.buttonRestoreTychoDirectory.Size = new System.Drawing.Size(29, 23);
			this.buttonRestoreTychoDirectory.TabIndex = 5;
			this.buttonRestoreTychoDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonRestoreTychoDirectory, "Restore Tycho catalog directory");
			this.buttonRestoreTychoDirectory.UseVisualStyleBackColor = true;
			this.buttonRestoreTychoDirectory.Click += new System.EventHandler(this.ButtonRestoreTychoDirectory_Click);
			this.buttonRestoreTychoDirectory.Enter += new System.EventHandler(this.ButtonRestoreTychoDirectory_Enter);
			this.buttonRestoreTychoDirectory.Leave += new System.EventHandler(this.ButtonRestoreTychoDirectory_Leave);
			this.buttonRestoreTychoDirectory.MouseEnter += new System.EventHandler(this.ButtonRestoreTychoDirectory_MouseEnter);
			this.buttonRestoreTychoDirectory.MouseLeave += new System.EventHandler(this.ButtonRestoreTychoDirectory_MouseLeave);
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.buttonApply;
			this.AccessibleDescription = "Show some options";
			this.AccessibleName = "Options";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(396, 300);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "OptionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.OptionsForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.groupBoxQuickDownload.ResumeLayout(false);
			this.groupBoxQuickDownload.PerformLayout();
			this.groupBoxDataTableStyle.ResumeLayout(false);
			this.groupBoxDataTableStyle.PerformLayout();
			this.groupBoxCopyDataMethod.ResumeLayout(false);
			this.groupBoxCopyDataMethod.PerformLayout();
			this.groupBoxHoverEffect.ResumeLayout(false);
			this.groupBoxHoverEffect.PerformLayout();
			this.groupBoxCatalogDirectories.ResumeLayout(false);
			this.groupBoxCatalogDirectories.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.GroupBox groupBoxQuickDownload;
		private System.Windows.Forms.CheckBox checkBoxEnableQuickDownload;
		private System.Windows.Forms.GroupBox groupBoxDataTableStyle;
		private System.Windows.Forms.ComboBox comboBoxDataTableStyle;
		private System.Windows.Forms.Label labelDataTableStyle;
		private System.Windows.Forms.TextBox textBoxDefaultHost;
		private System.Windows.Forms.Label labelDefaultHost;
		private System.Windows.Forms.GroupBox groupBoxHoverEffect;
		private System.Windows.Forms.CheckBox checkBoxEnableHoverEffect;
		private System.Windows.Forms.GroupBox groupBoxCopyDataMethod;
		private System.Windows.Forms.ComboBox comboBoxCopyDataMethod;
		private System.Windows.Forms.Label labelCopyDataMethod;
		private System.Windows.Forms.GroupBox groupBoxCatalogDirectories;
		private System.Windows.Forms.TextBox textBoxTychoDirectory;
		private System.Windows.Forms.Label labelTychoDirectory;
		private System.Windows.Forms.TextBox textBoxHipparcosDirectory;
		private System.Windows.Forms.Label labelHipparcosDirectory;
		private System.Windows.Forms.Button buttonRestoreTychoDirectory;
		private System.Windows.Forms.Button buttonRestoreHipparcosDirectory;
		private System.Windows.Forms.Button buttonRestoreHost;
	}
}