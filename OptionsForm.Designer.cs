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
			this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonRestoreHost = new System.Windows.Forms.Button();
			this.buttonRestoreHipparcosDirectory = new System.Windows.Forms.Button();
			this.buttonRestoreTychoDirectory = new System.Windows.Forms.Button();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.groupBoxCatalogDirectories = new System.Windows.Forms.GroupBox();
			this.textBoxTychoDirectory = new System.Windows.Forms.TextBox();
			this.labelTychoDirectory = new System.Windows.Forms.Label();
			this.textBoxHipparcosDirectory = new System.Windows.Forms.TextBox();
			this.labelHipparcosDirectory = new System.Windows.Forms.Label();
			this.groupBoxHoverEffect = new System.Windows.Forms.GroupBox();
			this.checkBoxEnableHoverEffect = new System.Windows.Forms.CheckBox();
			this.groupBoxCopyDataMethod = new System.Windows.Forms.GroupBox();
			this.comboBoxCopyDataMethod = new System.Windows.Forms.ComboBox();
			this.labelCopyDataMethod = new System.Windows.Forms.Label();
			this.groupBoxDataTableStyle = new System.Windows.Forms.GroupBox();
			this.comboBoxDataTableStyle = new System.Windows.Forms.ComboBox();
			this.labelDataTableStyle = new System.Windows.Forms.Label();
			this.groupBoxQuickDownload = new System.Windows.Forms.GroupBox();
			this.textBoxHost = new System.Windows.Forms.TextBox();
			this.labelHost = new System.Windows.Forms.Label();
			this.checkBoxEnableQuickDownload = new System.Windows.Forms.CheckBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.comboBoxStartPosition = new System.Windows.Forms.ComboBox();
			this.labelStartPosition = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonDefaultSettings = new System.Windows.Forms.Button();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.groupBoxCatalogDirectories.SuspendLayout();
			this.groupBoxHoverEffect.SuspendLayout();
			this.groupBoxCopyDataMethod.SuspendLayout();
			this.groupBoxDataTableStyle.SuspendLayout();
			this.groupBoxQuickDownload.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			// toolStripStatusLabelInfo
			// 
			this.toolStripStatusLabelInfo.AccessibleDescription = "Text with some information";
			this.toolStripStatusLabelInfo.AccessibleName = "Information text";
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
			// buttonRestoreHost
			// 
			this.buttonRestoreHost.AccessibleDescription = "Restore the host url";
			this.buttonRestoreHost.AccessibleName = "Restore the host url";
			this.buttonRestoreHost.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonRestoreHost.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_curve_180_left_shadowless;
			this.buttonRestoreHost.Location = new System.Drawing.Point(336, 39);
			this.buttonRestoreHost.Name = "buttonRestoreHost";
			this.buttonRestoreHost.Size = new System.Drawing.Size(29, 23);
			this.buttonRestoreHost.TabIndex = 3;
			this.buttonRestoreHost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonRestoreHost, "Restore the host url");
			this.buttonRestoreHost.UseVisualStyleBackColor = true;
			this.buttonRestoreHost.Click += new System.EventHandler(this.ButtonRestoreHost_Click);
			this.buttonRestoreHost.Enter += new System.EventHandler(this.ButtonRestoreHost_Enter);
			this.buttonRestoreHost.Leave += new System.EventHandler(this.ButtonRestoreHost_Leave);
			this.buttonRestoreHost.MouseEnter += new System.EventHandler(this.ButtonRestoreHost_MouseEnter);
			this.buttonRestoreHost.MouseLeave += new System.EventHandler(this.ButtonRestoreHost_MouseLeave);
			// 
			// buttonRestoreHipparcosDirectory
			// 
			this.buttonRestoreHipparcosDirectory.AccessibleDescription = "Restore the Hipparcos catalog directory";
			this.buttonRestoreHipparcosDirectory.AccessibleName = "Restore the Hipparcos catalog directory";
			this.buttonRestoreHipparcosDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonRestoreHipparcosDirectory.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_curve_180_left_shadowless;
			this.buttonRestoreHipparcosDirectory.Location = new System.Drawing.Point(336, 11);
			this.buttonRestoreHipparcosDirectory.Name = "buttonRestoreHipparcosDirectory";
			this.buttonRestoreHipparcosDirectory.Size = new System.Drawing.Size(29, 23);
			this.buttonRestoreHipparcosDirectory.TabIndex = 2;
			this.buttonRestoreHipparcosDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonRestoreHipparcosDirectory, "Restore the Hipparcos catalog directory");
			this.buttonRestoreHipparcosDirectory.UseVisualStyleBackColor = true;
			this.buttonRestoreHipparcosDirectory.Click += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_Click);
			this.buttonRestoreHipparcosDirectory.Enter += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_Enter);
			this.buttonRestoreHipparcosDirectory.Leave += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_Leave);
			this.buttonRestoreHipparcosDirectory.MouseEnter += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_MouseEnter);
			this.buttonRestoreHipparcosDirectory.MouseLeave += new System.EventHandler(this.ButtonRestoreHipparcosDirectory_MouseLeave);
			// 
			// buttonRestoreTychoDirectory
			// 
			this.buttonRestoreTychoDirectory.AccessibleDescription = "Restore the Tycho catalog directory";
			this.buttonRestoreTychoDirectory.AccessibleName = "Restore the Tycho catalog directory";
			this.buttonRestoreTychoDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
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
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleDescription = "Group the toolstrip container";
			this.toolStripContainer.AccessibleName = "container grouping";
			this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.AccessibleDescription = "lower part of the container";
			this.toolStripContainer.BottomToolStripPanel.AccessibleName = "lower part of the container";
			this.toolStripContainer.BottomToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.AccessibleDescription = "content panel of the container";
			this.toolStripContainer.ContentPanel.AccessibleName = "content panel of the container";
			this.toolStripContainer.ContentPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonDefaultSettings);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonCancel);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonApply);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBox1);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxCatalogDirectories);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxHoverEffect);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxCopyDataMethod);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxDataTableStyle);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxQuickDownload);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(396, 311);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			this.toolStripContainer.LeftToolStripPanel.AccessibleDescription = "left part of the container";
			this.toolStripContainer.LeftToolStripPanel.AccessibleName = "left part of the container";
			this.toolStripContainer.LeftToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			this.toolStripContainer.RightToolStripPanel.AccessibleDescription = "right part of the container";
			this.toolStripContainer.RightToolStripPanel.AccessibleName = "right part of the container";
			this.toolStripContainer.RightToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.Size = new System.Drawing.Size(396, 333);
			this.toolStripContainer.TabIndex = 0;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.AccessibleDescription = "upper part of the container";
			this.toolStripContainer.TopToolStripPanel.AccessibleName = "upper part of the container";
			this.toolStripContainer.TopToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			// 
			// groupBoxCatalogDirectories
			// 
			this.groupBoxCatalogDirectories.AccessibleDescription = "Group the catalog directories setting";
			this.groupBoxCatalogDirectories.AccessibleName = "Group the catalog directories setting";
			this.groupBoxCatalogDirectories.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxCatalogDirectories.Controls.Add(this.buttonRestoreTychoDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.buttonRestoreHipparcosDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.textBoxTychoDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.labelTychoDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.textBoxHipparcosDirectory);
			this.groupBoxCatalogDirectories.Controls.Add(this.labelHipparcosDirectory);
			this.groupBoxCatalogDirectories.Location = new System.Drawing.Point(12, 205);
			this.groupBoxCatalogDirectories.Name = "groupBoxCatalogDirectories";
			this.groupBoxCatalogDirectories.Size = new System.Drawing.Size(371, 69);
			this.groupBoxCatalogDirectories.TabIndex = 5;
			this.groupBoxCatalogDirectories.TabStop = false;
			this.groupBoxCatalogDirectories.Text = "Catalog directories";
			// 
			// textBoxTychoDirectory
			// 
			this.textBoxTychoDirectory.AccessibleDescription = "Contents the Tycho catalog directory";
			this.textBoxTychoDirectory.AccessibleName = "Tycho catalog directory";
			this.textBoxTychoDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textBoxTychoDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxTychoDirectory.Location = new System.Drawing.Point(114, 39);
			this.textBoxTychoDirectory.Name = "textBoxTychoDirectory";
			this.textBoxTychoDirectory.Size = new System.Drawing.Size(216, 20);
			this.textBoxTychoDirectory.TabIndex = 4;
			this.textBoxTychoDirectory.Text = "catalog/i239/";
			this.toolTip.SetToolTip(this.textBoxTychoDirectory, "Tycho catalog directory");
			this.textBoxTychoDirectory.Enter += new System.EventHandler(this.TextBoxTychoDirectory_Enter);
			this.textBoxTychoDirectory.Leave += new System.EventHandler(this.TextBoxTychoDirectory_Leave);
			this.textBoxTychoDirectory.MouseEnter += new System.EventHandler(this.TextBoxTychoDirectory_MouseEnter);
			this.textBoxTychoDirectory.MouseLeave += new System.EventHandler(this.TextBoxTychoDirectory_MouseLeave);
			// 
			// labelTychoDirectory
			// 
			this.labelTychoDirectory.AccessibleDescription = "Short description of the Tycho catalog directory";
			this.labelTychoDirectory.AccessibleName = "Tycho catalog";
			this.labelTychoDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelTychoDirectory.AutoSize = true;
			this.labelTychoDirectory.Location = new System.Drawing.Point(6, 42);
			this.labelTychoDirectory.Name = "labelTychoDirectory";
			this.labelTychoDirectory.Size = new System.Drawing.Size(78, 13);
			this.labelTychoDirectory.TabIndex = 3;
			this.labelTychoDirectory.Text = "&Tycho catalog:";
			this.toolTip.SetToolTip(this.labelTychoDirectory, "Tycho catalog directory");
			this.labelTychoDirectory.Enter += new System.EventHandler(this.LabelTychoDirectory_Enter);
			this.labelTychoDirectory.Leave += new System.EventHandler(this.LabelTychoDirectory_Leave);
			this.labelTychoDirectory.MouseEnter += new System.EventHandler(this.LabelTychoDirectory_MouseEnter);
			this.labelTychoDirectory.MouseLeave += new System.EventHandler(this.LabelTychoDirectory_MouseLeave);
			// 
			// textBoxHipparcosDirectory
			// 
			this.textBoxHipparcosDirectory.AccessibleDescription = "Contents the Hipparcos catalog directory";
			this.textBoxHipparcosDirectory.AccessibleName = "Hipparcos catalog directory";
			this.textBoxHipparcosDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textBoxHipparcosDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxHipparcosDirectory.Location = new System.Drawing.Point(114, 13);
			this.textBoxHipparcosDirectory.Name = "textBoxHipparcosDirectory";
			this.textBoxHipparcosDirectory.Size = new System.Drawing.Size(216, 20);
			this.textBoxHipparcosDirectory.TabIndex = 1;
			this.textBoxHipparcosDirectory.Text = "catalog/i239/";
			this.toolTip.SetToolTip(this.textBoxHipparcosDirectory, "Hipparcos catalog directory");
			this.textBoxHipparcosDirectory.Enter += new System.EventHandler(this.TextBoxHipparcosDirectory_Enter);
			this.textBoxHipparcosDirectory.Leave += new System.EventHandler(this.TextBoxHipparcosDirectory_Leave);
			this.textBoxHipparcosDirectory.MouseEnter += new System.EventHandler(this.TextBoxHipparcosDirectory_MouseEnter);
			this.textBoxHipparcosDirectory.MouseLeave += new System.EventHandler(this.TextBoxHipparcosDirectory_MouseLeave);
			// 
			// labelHipparcosDirectory
			// 
			this.labelHipparcosDirectory.AccessibleDescription = "Short description of the Hipparcos catalog directory";
			this.labelHipparcosDirectory.AccessibleName = "Hipparcos catalog directory";
			this.labelHipparcosDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelHipparcosDirectory.AutoSize = true;
			this.labelHipparcosDirectory.Location = new System.Drawing.Point(6, 16);
			this.labelHipparcosDirectory.Name = "labelHipparcosDirectory";
			this.labelHipparcosDirectory.Size = new System.Drawing.Size(102, 13);
			this.labelHipparcosDirectory.TabIndex = 0;
			this.labelHipparcosDirectory.Text = "&Hippparcos catalog:";
			this.toolTip.SetToolTip(this.labelHipparcosDirectory, "Hipparcos catalog directory");
			this.labelHipparcosDirectory.Enter += new System.EventHandler(this.LabelHipparcosDirectory_Enter);
			this.labelHipparcosDirectory.Leave += new System.EventHandler(this.LabelHipparcosDirectory_Leave);
			this.labelHipparcosDirectory.MouseEnter += new System.EventHandler(this.LabelHipparcosDirectory_MouseEnter);
			this.labelHipparcosDirectory.MouseLeave += new System.EventHandler(this.LabelHipparcosDirectory_MouseLeave);
			// 
			// groupBoxHoverEffect
			// 
			this.groupBoxHoverEffect.AccessibleDescription = "Group the hover effect setting";
			this.groupBoxHoverEffect.AccessibleName = "Hover effect grouping";
			this.groupBoxHoverEffect.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxHoverEffect.Controls.Add(this.checkBoxEnableHoverEffect);
			this.groupBoxHoverEffect.Location = new System.Drawing.Point(12, 12);
			this.groupBoxHoverEffect.Name = "groupBoxHoverEffect";
			this.groupBoxHoverEffect.Size = new System.Drawing.Size(182, 53);
			this.groupBoxHoverEffect.TabIndex = 0;
			this.groupBoxHoverEffect.TabStop = false;
			this.groupBoxHoverEffect.Text = "Hover effect";
			// 
			// checkBoxEnableHoverEffect
			// 
			this.checkBoxEnableHoverEffect.AccessibleDescription = "Check to enable the hover effect on data tables";
			this.checkBoxEnableHoverEffect.AccessibleName = "Enable hover effect";
			this.checkBoxEnableHoverEffect.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkBoxEnableHoverEffect.AutoSize = true;
			this.checkBoxEnableHoverEffect.Checked = true;
			this.checkBoxEnableHoverEffect.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxEnableHoverEffect.Location = new System.Drawing.Point(9, 23);
			this.checkBoxEnableHoverEffect.Name = "checkBoxEnableHoverEffect";
			this.checkBoxEnableHoverEffect.Size = new System.Drawing.Size(119, 17);
			this.checkBoxEnableHoverEffect.TabIndex = 0;
			this.checkBoxEnableHoverEffect.Text = "&Enable hover effect";
			this.toolTip.SetToolTip(this.checkBoxEnableHoverEffect, "Check to enable hover effect");
			this.checkBoxEnableHoverEffect.UseVisualStyleBackColor = true;
			this.checkBoxEnableHoverEffect.Enter += new System.EventHandler(this.CheckBoxEnableHoverEffect_Enter);
			this.checkBoxEnableHoverEffect.Leave += new System.EventHandler(this.CheckBoxEnableHoverEffect_Leave);
			this.checkBoxEnableHoverEffect.MouseEnter += new System.EventHandler(this.CheckBoxEnableHoverEffect_MouseEnter);
			this.checkBoxEnableHoverEffect.MouseLeave += new System.EventHandler(this.CheckBoxEnableHoverEffect_MouseLeave);
			// 
			// groupBoxCopyDataMethod
			// 
			this.groupBoxCopyDataMethod.AccessibleDescription = "Group the copy data method setting";
			this.groupBoxCopyDataMethod.AccessibleName = "Copy data method grouping";
			this.groupBoxCopyDataMethod.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxCopyDataMethod.Controls.Add(this.comboBoxCopyDataMethod);
			this.groupBoxCopyDataMethod.Controls.Add(this.labelCopyDataMethod);
			this.groupBoxCopyDataMethod.Location = new System.Drawing.Point(12, 71);
			this.groupBoxCopyDataMethod.Name = "groupBoxCopyDataMethod";
			this.groupBoxCopyDataMethod.Size = new System.Drawing.Size(182, 53);
			this.groupBoxCopyDataMethod.TabIndex = 2;
			this.groupBoxCopyDataMethod.TabStop = false;
			this.groupBoxCopyDataMethod.Text = "Copy data method";
			// 
			// comboBoxCopyDataMethod
			// 
			this.comboBoxCopyDataMethod.AccessibleDescription = "list of the copy data method";
			this.comboBoxCopyDataMethod.AccessibleName = "Copy data method";
			this.comboBoxCopyDataMethod.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
			this.comboBoxCopyDataMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCopyDataMethod.FormattingEnabled = true;
			this.comboBoxCopyDataMethod.Items.AddRange(new object[] {
            "Double click",
            "Right mouse click"});
			this.comboBoxCopyDataMethod.Location = new System.Drawing.Point(58, 19);
			this.comboBoxCopyDataMethod.Name = "comboBoxCopyDataMethod";
			this.comboBoxCopyDataMethod.Size = new System.Drawing.Size(118, 21);
			this.comboBoxCopyDataMethod.TabIndex = 1;
			this.toolTip.SetToolTip(this.comboBoxCopyDataMethod, "Copy data method");
			this.comboBoxCopyDataMethod.Enter += new System.EventHandler(this.ComboBoxCopyDataMethod_Enter);
			this.comboBoxCopyDataMethod.Leave += new System.EventHandler(this.ComboBoxCopyDataMethod_Leave);
			this.comboBoxCopyDataMethod.MouseEnter += new System.EventHandler(this.ComboBoxCopyDataMethod_MouseEnter);
			this.comboBoxCopyDataMethod.MouseLeave += new System.EventHandler(this.ComboBoxCopyDataMethod_MouseLeave);
			// 
			// labelCopyDataMethod
			// 
			this.labelCopyDataMethod.AccessibleDescription = "Short description of the copy data method";
			this.labelCopyDataMethod.AccessibleName = "Copy data method";
			this.labelCopyDataMethod.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelCopyDataMethod.AutoSize = true;
			this.labelCopyDataMethod.Location = new System.Drawing.Point(6, 22);
			this.labelCopyDataMethod.Name = "labelCopyDataMethod";
			this.labelCopyDataMethod.Size = new System.Drawing.Size(46, 13);
			this.labelCopyDataMethod.TabIndex = 0;
			this.labelCopyDataMethod.Text = "&Method:";
			this.toolTip.SetToolTip(this.labelCopyDataMethod, "Copy data method");
			this.labelCopyDataMethod.Enter += new System.EventHandler(this.LabelCopyDataMethod_Enter);
			this.labelCopyDataMethod.Leave += new System.EventHandler(this.LabelCopyDataMethod_Leave);
			this.labelCopyDataMethod.MouseEnter += new System.EventHandler(this.LabelCopyDataMethod_MouseEnter);
			this.labelCopyDataMethod.MouseLeave += new System.EventHandler(this.LabelCopyDataMethod_MouseLeave);
			// 
			// groupBoxDataTableStyle
			// 
			this.groupBoxDataTableStyle.AccessibleDescription = "Group the data table style setting";
			this.groupBoxDataTableStyle.AccessibleName = "Data table style grouping";
			this.groupBoxDataTableStyle.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxDataTableStyle.Controls.Add(this.comboBoxDataTableStyle);
			this.groupBoxDataTableStyle.Controls.Add(this.labelDataTableStyle);
			this.groupBoxDataTableStyle.Location = new System.Drawing.Point(201, 71);
			this.groupBoxDataTableStyle.Name = "groupBoxDataTableStyle";
			this.groupBoxDataTableStyle.Size = new System.Drawing.Size(182, 53);
			this.groupBoxDataTableStyle.TabIndex = 3;
			this.groupBoxDataTableStyle.TabStop = false;
			this.groupBoxDataTableStyle.Text = "Data table style";
			// 
			// comboBoxDataTableStyle
			// 
			this.comboBoxDataTableStyle.AccessibleDescription = "list of the data table style";
			this.comboBoxDataTableStyle.AccessibleName = "Data table style";
			this.comboBoxDataTableStyle.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
			this.comboBoxDataTableStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDataTableStyle.FormattingEnabled = true;
			this.comboBoxDataTableStyle.Items.AddRange(new object[] {
            "Outset double",
            "Inset double"});
			this.comboBoxDataTableStyle.Location = new System.Drawing.Point(45, 19);
			this.comboBoxDataTableStyle.Name = "comboBoxDataTableStyle";
			this.comboBoxDataTableStyle.Size = new System.Drawing.Size(131, 21);
			this.comboBoxDataTableStyle.TabIndex = 1;
			this.toolTip.SetToolTip(this.comboBoxDataTableStyle, "Data table style");
			this.comboBoxDataTableStyle.Enter += new System.EventHandler(this.ComboBoxDataTableStyle_Enter);
			this.comboBoxDataTableStyle.Leave += new System.EventHandler(this.ComboBoxDataTableStyle_Leave);
			this.comboBoxDataTableStyle.MouseEnter += new System.EventHandler(this.ComboBoxDataTableStyle_MouseEnter);
			this.comboBoxDataTableStyle.MouseLeave += new System.EventHandler(this.ComboBoxDataTableStyle_MouseLeave);
			// 
			// labelDataTableStyle
			// 
			this.labelDataTableStyle.AccessibleDescription = "Short description of the data table style";
			this.labelDataTableStyle.AccessibleName = "Data table style";
			this.labelDataTableStyle.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelDataTableStyle.AutoSize = true;
			this.labelDataTableStyle.Location = new System.Drawing.Point(6, 22);
			this.labelDataTableStyle.Name = "labelDataTableStyle";
			this.labelDataTableStyle.Size = new System.Drawing.Size(33, 13);
			this.labelDataTableStyle.TabIndex = 0;
			this.labelDataTableStyle.Text = "&Style:";
			this.toolTip.SetToolTip(this.labelDataTableStyle, "Data table style");
			this.labelDataTableStyle.Enter += new System.EventHandler(this.LabelDataTableStyle_Enter);
			this.labelDataTableStyle.Leave += new System.EventHandler(this.LabelDataTableStyle_Leave);
			this.labelDataTableStyle.MouseEnter += new System.EventHandler(this.LabelDataTableStyle_MouseEnter);
			this.labelDataTableStyle.MouseLeave += new System.EventHandler(this.LabelDataTableStyle_MouseLeave);
			// 
			// groupBoxQuickDownload
			// 
			this.groupBoxQuickDownload.AccessibleDescription = "Group the Quick download setting";
			this.groupBoxQuickDownload.AccessibleName = "Group the quick download setting";
			this.groupBoxQuickDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxQuickDownload.Controls.Add(this.buttonRestoreHost);
			this.groupBoxQuickDownload.Controls.Add(this.textBoxHost);
			this.groupBoxQuickDownload.Controls.Add(this.labelHost);
			this.groupBoxQuickDownload.Controls.Add(this.checkBoxEnableQuickDownload);
			this.groupBoxQuickDownload.Location = new System.Drawing.Point(12, 130);
			this.groupBoxQuickDownload.Name = "groupBoxQuickDownload";
			this.groupBoxQuickDownload.Size = new System.Drawing.Size(371, 69);
			this.groupBoxQuickDownload.TabIndex = 4;
			this.groupBoxQuickDownload.TabStop = false;
			this.groupBoxQuickDownload.Text = "Quick download";
			// 
			// textBoxHost
			// 
			this.textBoxHost.AccessibleDescription = "Contents the url of the host";
			this.textBoxHost.AccessibleName = "Host url";
			this.textBoxHost.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textBoxHost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxHost.Location = new System.Drawing.Point(58, 41);
			this.textBoxHost.Name = "textBoxHost";
			this.textBoxHost.Size = new System.Drawing.Size(272, 20);
			this.textBoxHost.TabIndex = 2;
			this.textBoxHost.Text = "http://cdsarc.u-strasbg.fr/ftp/I/239/";
			this.toolTip.SetToolTip(this.textBoxHost, "URL of the host");
			this.textBoxHost.Enter += new System.EventHandler(this.TextBoxHost_Enter);
			this.textBoxHost.Leave += new System.EventHandler(this.TextBoxHost_Leave);
			this.textBoxHost.MouseEnter += new System.EventHandler(this.TextBoxDefaultHost_MouseEnter);
			this.textBoxHost.MouseLeave += new System.EventHandler(this.TextBoxDefaultHost_MouseLeave);
			// 
			// labelHost
			// 
			this.labelHost.AccessibleDescription = "Short description of the host url";
			this.labelHost.AccessibleName = "Host url";
			this.labelHost.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelHost.AutoSize = true;
			this.labelHost.Location = new System.Drawing.Point(22, 44);
			this.labelHost.Name = "labelHost";
			this.labelHost.Size = new System.Drawing.Size(32, 13);
			this.labelHost.TabIndex = 1;
			this.labelHost.Text = "H&ost:";
			this.toolTip.SetToolTip(this.labelHost, "URL of the host");
			this.labelHost.Enter += new System.EventHandler(this.LabelHost_Enter);
			this.labelHost.Leave += new System.EventHandler(this.LabelHost_Leave);
			this.labelHost.MouseEnter += new System.EventHandler(this.LabelDefaultHost_MouseEnter);
			this.labelHost.MouseLeave += new System.EventHandler(this.LabelDefaultHost_MouseLeave);
			// 
			// checkBoxEnableQuickDownload
			// 
			this.checkBoxEnableQuickDownload.AccessibleDescription = "Check to enable quick download of catalog files";
			this.checkBoxEnableQuickDownload.AccessibleName = "Enable quick download";
			this.checkBoxEnableQuickDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkBoxEnableQuickDownload.AutoSize = true;
			this.checkBoxEnableQuickDownload.Location = new System.Drawing.Point(7, 20);
			this.checkBoxEnableQuickDownload.Name = "checkBoxEnableQuickDownload";
			this.checkBoxEnableQuickDownload.Size = new System.Drawing.Size(208, 17);
			this.checkBoxEnableQuickDownload.TabIndex = 0;
			this.checkBoxEnableQuickDownload.Text = "Enable &quick download of catalog files";
			this.toolTip.SetToolTip(this.checkBoxEnableQuickDownload, "Check to enable quick download of catalog files");
			this.checkBoxEnableQuickDownload.UseVisualStyleBackColor = true;
			this.checkBoxEnableQuickDownload.CheckedChanged += new System.EventHandler(this.CheckBoxEnableQuickDownload_CheckedChanged);
			this.checkBoxEnableQuickDownload.Enter += new System.EventHandler(this.CheckBoxEnableQuickDownload_Enter);
			this.checkBoxEnableQuickDownload.Leave += new System.EventHandler(this.CheckBoxEnableQuickDownload_Leave);
			this.checkBoxEnableQuickDownload.MouseEnter += new System.EventHandler(this.CheckBoxEnableQuickDownload_MouseEnter);
			this.checkBoxEnableQuickDownload.MouseLeave += new System.EventHandler(this.CheckBoxEnableQuickDownload_MouseLeave);
			// 
			// buttonCancel
			// 
			this.buttonCancel.AccessibleDescription = "Cancel the settings";
			this.buttonCancel.AccessibleName = "Cancel the settings";
			this.buttonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Image = global::Hipparcos_DB.Properties.Resources.fugue_cross_16px_shadowless;
			this.buttonCancel.Location = new System.Drawing.Point(143, 280);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCancel, "Cancel");
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Enter += new System.EventHandler(this.ButtonCancel_Enter);
			this.buttonCancel.Leave += new System.EventHandler(this.ButtonCancel_Leave);
			this.buttonCancel.MouseEnter += new System.EventHandler(this.ButtonCancel_MouseEnter);
			this.buttonCancel.MouseLeave += new System.EventHandler(this.ButtonCancel_MouseLeave);
			// 
			// buttonApply
			// 
			this.buttonApply.AccessibleDescription = "Apply the settings";
			this.buttonApply.AccessibleName = "Apply the settings";
			this.buttonApply.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonApply.Image = global::Hipparcos_DB.Properties.Resources.fugue_tick_button_16px_shadowless;
			this.buttonApply.Location = new System.Drawing.Point(63, 280);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 6;
			this.buttonApply.Text = "&Apply";
			this.buttonApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonApply, "Apply");
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
			this.buttonApply.Enter += new System.EventHandler(this.ButtonApply_Enter);
			this.buttonApply.Leave += new System.EventHandler(this.ButtonApply_Leave);
			this.buttonApply.MouseEnter += new System.EventHandler(this.ButtonApply_MouseEnter);
			this.buttonApply.MouseLeave += new System.EventHandler(this.ButtonApply_MouseLeave);
			// 
			// comboBoxStartPosition
			// 
			this.comboBoxStartPosition.AccessibleDescription = "list of the start position";
			this.comboBoxStartPosition.AccessibleName = "Start position";
			this.comboBoxStartPosition.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
			this.comboBoxStartPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStartPosition.FormattingEnabled = true;
			this.comboBoxStartPosition.Items.AddRange(new object[] {
            "Center on screen",
            "Center on parent window"});
			this.comboBoxStartPosition.Location = new System.Drawing.Point(58, 19);
			this.comboBoxStartPosition.Name = "comboBoxStartPosition";
			this.comboBoxStartPosition.Size = new System.Drawing.Size(118, 21);
			this.comboBoxStartPosition.TabIndex = 1;
			this.toolTip.SetToolTip(this.comboBoxStartPosition, "Start position");
			this.comboBoxStartPosition.Enter += new System.EventHandler(this.ComboBoxStartPosition_Enter);
			this.comboBoxStartPosition.Leave += new System.EventHandler(this.ComboBoxStartPosition_Leave);
			this.comboBoxStartPosition.MouseEnter += new System.EventHandler(this.ComboBoxStartPosition_MouseEnter);
			this.comboBoxStartPosition.MouseLeave += new System.EventHandler(this.ComboBoxStartPosition_MouseLeave);
			// 
			// labelStartPosition
			// 
			this.labelStartPosition.AccessibleDescription = "Short description of the start position";
			this.labelStartPosition.AccessibleName = "Start position";
			this.labelStartPosition.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.labelStartPosition.AutoSize = true;
			this.labelStartPosition.Location = new System.Drawing.Point(6, 22);
			this.labelStartPosition.Name = "labelStartPosition";
			this.labelStartPosition.Size = new System.Drawing.Size(47, 13);
			this.labelStartPosition.TabIndex = 0;
			this.labelStartPosition.Text = "&Position:";
			this.toolTip.SetToolTip(this.labelStartPosition, "Start position");
			this.labelStartPosition.Enter += new System.EventHandler(this.LabelStartPosition_Enter);
			this.labelStartPosition.Leave += new System.EventHandler(this.LabelStartPosition_Leave);
			this.labelStartPosition.MouseEnter += new System.EventHandler(this.LabelStartPosition_MouseEnter);
			this.labelStartPosition.MouseLeave += new System.EventHandler(this.LabelStartPosition_MouseLeave);
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = "Group the start position setting";
			this.groupBox1.AccessibleName = "Copy start position grouping";
			this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBox1.Controls.Add(this.comboBoxStartPosition);
			this.groupBox1.Controls.Add(this.labelStartPosition);
			this.groupBox1.Location = new System.Drawing.Point(202, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(182, 53);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Start position";
			// 
			// buttonDefaultSettings
			// 
			this.buttonDefaultSettings.AccessibleDescription = "Restore the settings to default";
			this.buttonDefaultSettings.AccessibleName = "Restore the settings to default";
			this.buttonDefaultSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDefaultSettings.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_curve_180_left_shadowless;
			this.buttonDefaultSettings.Location = new System.Drawing.Point(223, 280);
			this.buttonDefaultSettings.Name = "buttonDefaultSettings";
			this.buttonDefaultSettings.Size = new System.Drawing.Size(111, 23);
			this.buttonDefaultSettings.TabIndex = 8;
			this.buttonDefaultSettings.Text = "&Default settings";
			this.buttonDefaultSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonDefaultSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonDefaultSettings, "Default settings");
			this.buttonDefaultSettings.UseVisualStyleBackColor = true;
			this.buttonDefaultSettings.Click += new System.EventHandler(this.ButtonDefaultSettings_Click);
			this.buttonDefaultSettings.Enter += new System.EventHandler(this.ButtonDefaultSettings_Enter);
			this.buttonDefaultSettings.Leave += new System.EventHandler(this.ButtonDefaultSettings_Leave);
			this.buttonDefaultSettings.MouseEnter += new System.EventHandler(this.ButtonDefaultSettings_MouseEnter);
			this.buttonDefaultSettings.MouseLeave += new System.EventHandler(this.ButtonDefaultSettings_MouseLeave);
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
			this.ClientSize = new System.Drawing.Size(396, 333);
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
			this.groupBoxCatalogDirectories.ResumeLayout(false);
			this.groupBoxCatalogDirectories.PerformLayout();
			this.groupBoxHoverEffect.ResumeLayout(false);
			this.groupBoxHoverEffect.PerformLayout();
			this.groupBoxCopyDataMethod.ResumeLayout(false);
			this.groupBoxCopyDataMethod.PerformLayout();
			this.groupBoxDataTableStyle.ResumeLayout(false);
			this.groupBoxDataTableStyle.PerformLayout();
			this.groupBoxQuickDownload.ResumeLayout(false);
			this.groupBoxQuickDownload.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.TextBox textBoxHost;
		private System.Windows.Forms.Label labelHost;
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxStartPosition;
		private System.Windows.Forms.Label labelStartPosition;
		private System.Windows.Forms.Button buttonDefaultSettings;
	}
}