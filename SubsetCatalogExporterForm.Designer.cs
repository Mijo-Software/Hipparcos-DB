namespace Hipparcos_DB.Properties
{
	/// <summary>
	/// SubsetCatalogExporterForm
	/// </summary>
	partial class SubsetCatalogExporterForm
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
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Mobility", "CA1601:DoNotUseTimersThatPreventPowerStateChanges")]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubsetCatalogExporterForm));
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonMoveItemToBottom = new System.Windows.Forms.Button();
			this.buttonMoveitemOnTop = new System.Windows.Forms.Button();
			this.buttonMoveitemDown = new System.Windows.Forms.Button();
			this.buttonMoveItemUp = new System.Windows.Forms.Button();
			this.buttonBringitemAllOver = new System.Windows.Forms.Button();
			this.buttonTakeItemsAllBack = new System.Windows.Forms.Button();
			this.buttonBringItemOver = new System.Windows.Forms.Button();
			this.buttonTakeItemBack = new System.Windows.Forms.Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelSeparator = new System.Windows.Forms.ToolStripStatusLabel();
			this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabelPercent = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelList2 = new System.Windows.Forms.Label();
			this.labelList1 = new System.Windows.Forms.Label();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonExportAsCsv = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.timerProcessAnimation = new System.Windows.Forms.Timer(this.components);
			this.statusStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.HorizontalScrollbar = true;
			this.listBox1.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "..."});
			this.listBox1.Location = new System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(211, 329);
			this.listBox1.TabIndex = 0;
			this.listBox1.Enter += new System.EventHandler(this.ListBox1_Enter);
			this.listBox1.Leave += new System.EventHandler(this.ListBox1_Leave);
			this.listBox1.MouseEnter += new System.EventHandler(this.ListBox1_MouseEnter);
			this.listBox1.MouseLeave += new System.EventHandler(this.ListBox1_MouseLeave);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.HorizontalScrollbar = true;
			this.listBox2.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "..."});
			this.listBox2.Location = new System.Drawing.Point(277, 12);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(211, 329);
			this.listBox2.TabIndex = 5;
			this.listBox2.Enter += new System.EventHandler(this.ListBox2_Enter);
			this.listBox2.Leave += new System.EventHandler(this.ListBox2_Leave);
			this.listBox2.MouseEnter += new System.EventHandler(this.ListBox2_MouseEnter);
			this.listBox2.MouseLeave += new System.EventHandler(this.ListBox2_MouseLeave);
			// 
			// buttonMoveItemToBottom
			// 
			this.buttonMoveItemToBottom.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_stop_270_16px_shadowless;
			this.buttonMoveItemToBottom.Location = new System.Drawing.Point(494, 178);
			this.buttonMoveItemToBottom.Name = "buttonMoveItemToBottom";
			this.buttonMoveItemToBottom.Size = new System.Drawing.Size(42, 23);
			this.buttonMoveItemToBottom.TabIndex = 9;
			this.buttonMoveItemToBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMoveItemToBottom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonMoveItemToBottom, "Move to bottom");
			this.buttonMoveItemToBottom.UseVisualStyleBackColor = true;
			this.buttonMoveItemToBottom.Click += new System.EventHandler(this.ButtonMoveItemToBottom_Click);
			this.buttonMoveItemToBottom.Enter += new System.EventHandler(this.ButtonMoveItemToBottom_Enter);
			this.buttonMoveItemToBottom.Leave += new System.EventHandler(this.ButtonMoveItemToBottom_Leave);
			this.buttonMoveItemToBottom.MouseEnter += new System.EventHandler(this.ButtonMoveItemToBottom_MouseEnter);
			this.buttonMoveItemToBottom.MouseLeave += new System.EventHandler(this.ButtonMoveItemToBottom_MouseLeave);
			// 
			// buttonMoveitemOnTop
			// 
			this.buttonMoveitemOnTop.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_stop_090_16px_shadowless;
			this.buttonMoveitemOnTop.Location = new System.Drawing.Point(494, 91);
			this.buttonMoveitemOnTop.Name = "buttonMoveitemOnTop";
			this.buttonMoveitemOnTop.Size = new System.Drawing.Size(42, 23);
			this.buttonMoveitemOnTop.TabIndex = 6;
			this.buttonMoveitemOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMoveitemOnTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonMoveitemOnTop, "Move on top");
			this.buttonMoveitemOnTop.UseVisualStyleBackColor = true;
			this.buttonMoveitemOnTop.Click += new System.EventHandler(this.ButtonMoveitemOnTop_Click);
			this.buttonMoveitemOnTop.Enter += new System.EventHandler(this.ButtonMoveitemOnTop_Enter);
			this.buttonMoveitemOnTop.Leave += new System.EventHandler(this.ButtonMoveitemOnTop_Leave);
			this.buttonMoveitemOnTop.MouseEnter += new System.EventHandler(this.ButtonMoveitemOnTop_MouseEnter);
			this.buttonMoveitemOnTop.MouseLeave += new System.EventHandler(this.ButtonMoveitemOnTop_MouseLeave);
			// 
			// buttonMoveitemDown
			// 
			this.buttonMoveitemDown.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_270_16px_shadowless;
			this.buttonMoveitemDown.Location = new System.Drawing.Point(494, 149);
			this.buttonMoveitemDown.Name = "buttonMoveitemDown";
			this.buttonMoveitemDown.Size = new System.Drawing.Size(42, 23);
			this.buttonMoveitemDown.TabIndex = 8;
			this.buttonMoveitemDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMoveitemDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonMoveitemDown, "Move down");
			this.buttonMoveitemDown.UseVisualStyleBackColor = true;
			this.buttonMoveitemDown.Click += new System.EventHandler(this.ButtonMoveitemDown_Click);
			this.buttonMoveitemDown.Enter += new System.EventHandler(this.ButtonMoveitemDown_Enter);
			this.buttonMoveitemDown.Leave += new System.EventHandler(this.ButtonMoveitemDown_Leave);
			this.buttonMoveitemDown.MouseEnter += new System.EventHandler(this.ButtonMoveitemDown_MouseEnter);
			this.buttonMoveitemDown.MouseLeave += new System.EventHandler(this.ButtonMoveitemDown_MouseLeave);
			// 
			// buttonMoveItemUp
			// 
			this.buttonMoveItemUp.Image = global::Hipparcos_DB.Properties.Resources.fugue_arrow_090_16px_shadowless;
			this.buttonMoveItemUp.Location = new System.Drawing.Point(494, 120);
			this.buttonMoveItemUp.Name = "buttonMoveItemUp";
			this.buttonMoveItemUp.Size = new System.Drawing.Size(42, 23);
			this.buttonMoveItemUp.TabIndex = 7;
			this.buttonMoveItemUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMoveItemUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonMoveItemUp, "Move up");
			this.buttonMoveItemUp.UseVisualStyleBackColor = true;
			this.buttonMoveItemUp.Click += new System.EventHandler(this.ButtonMoveItemUp_Click);
			this.buttonMoveItemUp.Enter += new System.EventHandler(this.ButtonMoveItemUp_Enter);
			this.buttonMoveItemUp.Leave += new System.EventHandler(this.ButtonMoveItemUp_Leave);
			this.buttonMoveItemUp.MouseEnter += new System.EventHandler(this.ButtonMoveItemUp_MouseEnter);
			this.buttonMoveItemUp.MouseLeave += new System.EventHandler(this.ButtonMoveItemUp_MouseLeave);
			// 
			// buttonBringitemAllOver
			// 
			this.buttonBringitemAllOver.Image = global::Hipparcos_DB.Properties.Resources.fugue_control_double_16px_shadowless;
			this.buttonBringitemAllOver.Location = new System.Drawing.Point(229, 178);
			this.buttonBringitemAllOver.Name = "buttonBringitemAllOver";
			this.buttonBringitemAllOver.Size = new System.Drawing.Size(42, 23);
			this.buttonBringitemAllOver.TabIndex = 4;
			this.buttonBringitemAllOver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonBringitemAllOver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonBringitemAllOver, "Bring all over");
			this.buttonBringitemAllOver.UseVisualStyleBackColor = true;
			this.buttonBringitemAllOver.Click += new System.EventHandler(this.ButtonBringitemAllOver_Click);
			this.buttonBringitemAllOver.Enter += new System.EventHandler(this.ButtonBringitemAllOver_Enter);
			this.buttonBringitemAllOver.Leave += new System.EventHandler(this.ButtonBringitemAllOver_Leave);
			this.buttonBringitemAllOver.MouseEnter += new System.EventHandler(this.ButtonBringitemAllOver_MouseEnter);
			this.buttonBringitemAllOver.MouseLeave += new System.EventHandler(this.ButtonBringitemAllOver_MouseLeave);
			// 
			// buttonTakeItemsAllBack
			// 
			this.buttonTakeItemsAllBack.Image = global::Hipparcos_DB.Properties.Resources.fugue_control_double_180_16px_shadowless;
			this.buttonTakeItemsAllBack.Location = new System.Drawing.Point(229, 91);
			this.buttonTakeItemsAllBack.Name = "buttonTakeItemsAllBack";
			this.buttonTakeItemsAllBack.Size = new System.Drawing.Size(42, 23);
			this.buttonTakeItemsAllBack.TabIndex = 1;
			this.buttonTakeItemsAllBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonTakeItemsAllBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonTakeItemsAllBack, "Take all back");
			this.buttonTakeItemsAllBack.UseVisualStyleBackColor = true;
			this.buttonTakeItemsAllBack.Click += new System.EventHandler(this.ButtonTakeItemsAllBack_Click);
			this.buttonTakeItemsAllBack.Enter += new System.EventHandler(this.ButtonTakeItemsAllBack_Enter);
			this.buttonTakeItemsAllBack.Leave += new System.EventHandler(this.ButtonTakeItemsAllBack_Leave);
			this.buttonTakeItemsAllBack.MouseEnter += new System.EventHandler(this.ButtonTakeItemsAllBack_MouseEnter);
			this.buttonTakeItemsAllBack.MouseLeave += new System.EventHandler(this.ButtonTakeItemsAllBack_MouseLeave);
			// 
			// buttonBringItemOver
			// 
			this.buttonBringItemOver.Image = global::Hipparcos_DB.Properties.Resources.fugue_control_16px_shadowless;
			this.buttonBringItemOver.Location = new System.Drawing.Point(229, 149);
			this.buttonBringItemOver.Name = "buttonBringItemOver";
			this.buttonBringItemOver.Size = new System.Drawing.Size(42, 23);
			this.buttonBringItemOver.TabIndex = 3;
			this.buttonBringItemOver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonBringItemOver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonBringItemOver, "Bring over");
			this.buttonBringItemOver.UseVisualStyleBackColor = true;
			this.buttonBringItemOver.Click += new System.EventHandler(this.ButtonBringItemOver_Click);
			this.buttonBringItemOver.Enter += new System.EventHandler(this.ButtonBringItemOver_Enter);
			this.buttonBringItemOver.Leave += new System.EventHandler(this.ButtonBringItemOver_Leave);
			this.buttonBringItemOver.MouseEnter += new System.EventHandler(this.ButtonBringItemOver_MouseEnter);
			this.buttonBringItemOver.MouseLeave += new System.EventHandler(this.ButtonBringItemOver_MouseLeave);
			// 
			// buttonTakeItemBack
			// 
			this.buttonTakeItemBack.Image = global::Hipparcos_DB.Properties.Resources.fugue_control_180_16px_shadowless;
			this.buttonTakeItemBack.Location = new System.Drawing.Point(229, 120);
			this.buttonTakeItemBack.Name = "buttonTakeItemBack";
			this.buttonTakeItemBack.Size = new System.Drawing.Size(42, 23);
			this.buttonTakeItemBack.TabIndex = 2;
			this.buttonTakeItemBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonTakeItemBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonTakeItemBack, "Take back");
			this.buttonTakeItemBack.UseVisualStyleBackColor = true;
			this.buttonTakeItemBack.Click += new System.EventHandler(this.ButtonTakeItemBack_Click);
			this.buttonTakeItemBack.Enter += new System.EventHandler(this.ButtonTakeItemBack_Enter);
			this.buttonTakeItemBack.Leave += new System.EventHandler(this.ButtonTakeItemBack_Leave);
			this.buttonTakeItemBack.MouseEnter += new System.EventHandler(this.ButtonTakeItemBack_MouseEnter);
			this.buttonTakeItemBack.MouseLeave += new System.EventHandler(this.ButtonTakeItemBack_MouseLeave);
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "status bar with some information";
			this.statusStrip.AccessibleName = "information status bar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo,
            this.toolStripStatusLabelSeparator,
            this.progressBar,
            this.toolStripStatusLabelPercent});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(549, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
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
			// 
			// toolStripStatusLabelSeparator
			// 
			this.toolStripStatusLabelSeparator.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.toolStripStatusLabelSeparator.Name = "toolStripStatusLabelSeparator";
			this.toolStripStatusLabelSeparator.Size = new System.Drawing.Size(315, 17);
			this.toolStripStatusLabelSeparator.Spring = true;
			// 
			// progressBar
			// 
			this.progressBar.AccessibleDescription = "Show the loading process of the Hipparcos Catalogue";
			this.progressBar.AccessibleName = "Loading progress";
			this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.progressBar.AutoToolTip = true;
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(100, 16);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar.ToolTipText = "Loading file...";
			this.progressBar.Enter += new System.EventHandler(this.ProgressBar_Enter);
			this.progressBar.Leave += new System.EventHandler(this.ProgressBar_Leave);
			this.progressBar.MouseEnter += new System.EventHandler(this.ProgressBar_MouseEnter);
			this.progressBar.MouseLeave += new System.EventHandler(this.ProgressBar_MouseLeave);
			// 
			// toolStripStatusLabelPercent
			// 
			this.toolStripStatusLabelPercent.AutoToolTip = true;
			this.toolStripStatusLabelPercent.Image = global::Hipparcos_DB.Properties.Resources.fugue_disk_16px_shadowless;
			this.toolStripStatusLabelPercent.Name = "toolStripStatusLabelPercent";
			this.toolStripStatusLabelPercent.Size = new System.Drawing.Size(51, 17);
			this.toolStripStatusLabelPercent.Text = "100%";
			this.toolStripStatusLabelPercent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.toolStripStatusLabelPercent.MouseEnter += new System.EventHandler(this.ToolStripStatusLabelPercent_MouseEnter);
			this.toolStripStatusLabelPercent.MouseLeave += new System.EventHandler(this.ToolStripStatusLabelPercent_MouseLeave);
			// 
			// labelList2
			// 
			this.labelList2.Image = global::Hipparcos_DB.Properties.Resources.fugue_exclamation_16px_shadowless;
			this.labelList2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelList2.Location = new System.Drawing.Point(274, 344);
			this.labelList2.Name = "labelList2";
			this.labelList2.Size = new System.Drawing.Size(88, 21);
			this.labelList2.TabIndex = 11;
			this.labelList2.Text = "List is empty!";
			this.labelList2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelList2.Enter += new System.EventHandler(this.LabelList2_Enter);
			this.labelList2.Leave += new System.EventHandler(this.LabelList2_Leave);
			this.labelList2.MouseEnter += new System.EventHandler(this.LabelList2_MouseEnter);
			// 
			// labelList1
			// 
			this.labelList1.Image = global::Hipparcos_DB.Properties.Resources.fugue_exclamation_16px_shadowless;
			this.labelList1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelList1.Location = new System.Drawing.Point(12, 344);
			this.labelList1.Name = "labelList1";
			this.labelList1.Size = new System.Drawing.Size(88, 21);
			this.labelList1.TabIndex = 10;
			this.labelList1.Text = "List is empty!";
			this.labelList1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.labelList1.Enter += new System.EventHandler(this.LabelList1_Enter);
			this.labelList1.Leave += new System.EventHandler(this.LabelList1_Leave);
			this.labelList1.MouseEnter += new System.EventHandler(this.LabelList1_MouseEnter);
			// 
			// toolStrip
			// 
			this.toolStrip.AccessibleDescription = "Contents some download options";
			this.toolStrip.AccessibleName = "Download bar";
			this.toolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonExportAsCsv});
			this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(549, 25);
			this.toolStrip.Stretch = true;
			this.toolStrip.TabIndex = 0;
			// 
			// toolStripButtonExportAsCsv
			// 
			this.toolStripButtonExportAsCsv.AccessibleDescription = "";
			this.toolStripButtonExportAsCsv.AccessibleName = "";
			this.toolStripButtonExportAsCsv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.toolStripButtonExportAsCsv.Image = global::Hipparcos_DB.Properties.Resources.fugue_disk_16px_shadowless;
			this.toolStripButtonExportAsCsv.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonExportAsCsv.Name = "toolStripButtonExportAsCsv";
			this.toolStripButtonExportAsCsv.Size = new System.Drawing.Size(98, 22);
			this.toolStripButtonExportAsCsv.Text = "E&xport as CSV";
			this.toolStripButtonExportAsCsv.Click += new System.EventHandler(this.ToolStripButtonExportAsCsv_Click);
			this.toolStripButtonExportAsCsv.MouseEnter += new System.EventHandler(this.ToolStripButtonExportAsCsv_MouseEnter);
			this.toolStripButtonExportAsCsv.MouseLeave += new System.EventHandler(this.ToolStripButtonExportAsCsv_MouseLeave);
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
			this.toolStripContainer.ContentPanel.AutoScroll = true;
			this.toolStripContainer.ContentPanel.Controls.Add(this.labelList2);
			this.toolStripContainer.ContentPanel.Controls.Add(this.labelList1);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonMoveItemToBottom);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonMoveitemOnTop);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonMoveitemDown);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonMoveItemUp);
			this.toolStripContainer.ContentPanel.Controls.Add(this.listBox2);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonBringitemAllOver);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonTakeItemsAllBack);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonBringItemOver);
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonTakeItemBack);
			this.toolStripContainer.ContentPanel.Controls.Add(this.listBox1);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(549, 370);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(549, 417);
			this.toolStripContainer.TabIndex = 15;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.CreatePrompt = true;
			this.saveFileDialog.DefaultExt = "txt";
			this.saveFileDialog.FileName = "catalog.csv";
			this.saveFileDialog.Filter = "comma-separated files|*.csv|all files|*.*";
			this.saveFileDialog.RestoreDirectory = true;
			this.saveFileDialog.SupportMultiDottedExtensions = true;
			this.saveFileDialog.Title = "Save file";
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			// 
			// timerProcessAnimation
			// 
			this.timerProcessAnimation.Interval = 250;
			// 
			// SubsetCatalogExporterForm
			// 
			this.AccessibleName = "Subset Catalog Exporter";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 417);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SubsetCatalogExporterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Subset Catalog Exporter";
			this.Load += new System.EventHandler(this.SubsetCatalogExporterForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button buttonTakeItemBack;
		private System.Windows.Forms.Button buttonBringItemOver;
		private System.Windows.Forms.Button buttonTakeItemsAllBack;
		private System.Windows.Forms.Button buttonBringitemAllOver;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button buttonMoveItemUp;
		private System.Windows.Forms.Button buttonMoveitemDown;
		private System.Windows.Forms.Button buttonMoveitemOnTop;
		private System.Windows.Forms.Button buttonMoveItemToBottom;
		private System.Windows.Forms.Label labelList1;
		private System.Windows.Forms.Label labelList2;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
		private System.Windows.Forms.ToolStripProgressBar progressBar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSeparator;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPercent;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton toolStripButtonExportAsCsv;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.Timer timerProcessAnimation;
	}
}