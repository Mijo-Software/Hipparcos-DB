namespace Hipparcos_DB
{
	partial class DownloaderForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloaderForm));
			this.progressBarDownloadFile = new System.Windows.Forms.ProgressBar();
			this.progressBarDownloadFiles = new System.Windows.Forms.ProgressBar();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.textBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelFilesDownload = new System.Windows.Forms.Label();
			this.labelDownloadPercent = new System.Windows.Forms.Label();
			this.labelDownlaodStatus = new System.Windows.Forms.Label();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripLabelHost = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBoxHost = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonEditHost = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorDownload = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonStartDownload = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// progressBarDownloadFile
			// 
			this.progressBarDownloadFile.Dock = System.Windows.Forms.DockStyle.Top;
			this.progressBarDownloadFile.Location = new System.Drawing.Point(3, 16);
			this.progressBarDownloadFile.Name = "progressBarDownloadFile";
			this.progressBarDownloadFile.Size = new System.Drawing.Size(736, 13);
			this.progressBarDownloadFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarDownloadFile.TabIndex = 1;
			this.progressBarDownloadFile.MouseEnter += new System.EventHandler(this.ProgressBarDownloadFile_MouseEnter);
			this.progressBarDownloadFile.MouseLeave += new System.EventHandler(this.ProgressBarDownloadFile_MouseLeave);
			// 
			// progressBarDownloadFiles
			// 
			this.progressBarDownloadFiles.Dock = System.Windows.Forms.DockStyle.Top;
			this.progressBarDownloadFiles.Location = new System.Drawing.Point(3, 35);
			this.progressBarDownloadFiles.Name = "progressBarDownloadFiles";
			this.progressBarDownloadFiles.Size = new System.Drawing.Size(736, 13);
			this.progressBarDownloadFiles.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarDownloadFiles.TabIndex = 3;
			this.progressBarDownloadFiles.MouseEnter += new System.EventHandler(this.ProgressBarDownloadFiles_MouseEnter);
			this.progressBarDownloadFiles.MouseLeave += new System.EventHandler(this.ProgressBarDownloadFiles_MouseLeave);
			// 
			// textBox
			// 
			this.textBox.AcceptsReturn = true;
			this.textBox.AcceptsTab = true;
			this.tableLayoutPanel.SetColumnSpan(this.textBox, 2);
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Enabled = false;
			this.textBox.Location = new System.Drawing.Point(3, 54);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox.Size = new System.Drawing.Size(794, 319);
			this.textBox.TabIndex = 5;
			this.textBox.Enter += new System.EventHandler(this.TextBox_Enter);
			this.textBox.Leave += new System.EventHandler(this.TextBox_Leave);
			this.textBox.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
			this.textBox.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
			this.tableLayoutPanel.Controls.Add(this.labelFilesDownload, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.textBox, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.labelDownloadPercent, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.progressBarDownloadFile, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.progressBarDownloadFiles, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelDownlaodStatus, 0, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 5;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(800, 403);
			this.tableLayoutPanel.TabIndex = 4;
			// 
			// labelFilesDownload
			// 
			this.labelFilesDownload.AutoSize = true;
			this.labelFilesDownload.Location = new System.Drawing.Point(745, 32);
			this.labelFilesDownload.Name = "labelFilesDownload";
			this.labelFilesDownload.Size = new System.Drawing.Size(42, 13);
			this.labelFilesDownload.TabIndex = 4;
			this.labelFilesDownload.Text = "00 / 99";
			this.labelFilesDownload.Enter += new System.EventHandler(this.LabelFilesDownload_Enter);
			this.labelFilesDownload.Leave += new System.EventHandler(this.LabelFilesDownload_Leave);
			this.labelFilesDownload.MouseEnter += new System.EventHandler(this.LabelFilesDownload_MouseEnter);
			this.labelFilesDownload.MouseLeave += new System.EventHandler(this.LabelFilesDownload_MouseLeave);
			// 
			// labelDownloadPercent
			// 
			this.labelDownloadPercent.AutoSize = true;
			this.labelDownloadPercent.Location = new System.Drawing.Point(745, 13);
			this.labelDownloadPercent.Name = "labelDownloadPercent";
			this.labelDownloadPercent.Size = new System.Drawing.Size(36, 13);
			this.labelDownloadPercent.TabIndex = 2;
			this.labelDownloadPercent.Text = "100 %";
			this.labelDownloadPercent.Enter += new System.EventHandler(this.LabelDownloadPercent_Enter);
			this.labelDownloadPercent.Leave += new System.EventHandler(this.LabelDownloadPercent_Leave);
			this.labelDownloadPercent.MouseEnter += new System.EventHandler(this.LabelDownloadPercent_MouseEnter);
			this.labelDownloadPercent.MouseLeave += new System.EventHandler(this.LabelDownloadPercent_MouseLeave);
			// 
			// labelDownlaodStatus
			// 
			this.labelDownlaodStatus.AutoSize = true;
			this.tableLayoutPanel.SetColumnSpan(this.labelDownlaodStatus, 2);
			this.labelDownlaodStatus.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelDownlaodStatus.Location = new System.Drawing.Point(3, 0);
			this.labelDownlaodStatus.Name = "labelDownlaodStatus";
			this.labelDownlaodStatus.Size = new System.Drawing.Size(794, 13);
			this.labelDownlaodStatus.TabIndex = 0;
			this.labelDownlaodStatus.Text = "Downloading: http://............................................................." +
    "...........................";
			this.labelDownlaodStatus.Enter += new System.EventHandler(this.LabelDownlaodStatus_Enter);
			this.labelDownlaodStatus.Leave += new System.EventHandler(this.LabelDownlaodStatus_Leave);
			this.labelDownlaodStatus.MouseEnter += new System.EventHandler(this.LabelDownlaodStatus_MouseEnter);
			this.labelDownlaodStatus.MouseHover += new System.EventHandler(this.LabelDownlaodStatus_MouseHover);
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
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(800, 403);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(800, 450);
			this.toolStripContainer.TabIndex = 6;
			this.toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.AccessibleDescription = "text with some information";
			this.toolStripStatusLabel.AccessibleName = "information text";
			this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabel.AutoToolTip = true;
			this.toolStripStatusLabel.DoubleClickEnabled = true;
			this.toolStripStatusLabel.Image = global::Hipparcos_DB.Properties.Resources.fugue_information_white_16px_shadowless;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
			this.toolStripStatusLabel.Text = "info text";
			this.toolStripStatusLabel.ToolTipText = "info text";
			this.toolStripStatusLabel.MouseEnter += new System.EventHandler(this.ToolStripStatusLabel_MouseEnter);
			this.toolStripStatusLabel.MouseLeave += new System.EventHandler(this.ToolStripStatusLabel_MouseLeave);
			// 
			// toolStrip
			// 
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelHost,
            this.toolStripTextBoxHost,
            this.toolStripButtonEditHost,
            this.toolStripSeparatorDownload,
            this.toolStripButtonStartDownload});
			this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(800, 25);
			this.toolStrip.Stretch = true;
			this.toolStrip.TabIndex = 0;
			// 
			// toolStripLabelHost
			// 
			this.toolStripLabelHost.Name = "toolStripLabelHost";
			this.toolStripLabelHost.Size = new System.Drawing.Size(35, 22);
			this.toolStripLabelHost.Text = "&Host:";
			this.toolStripLabelHost.MouseEnter += new System.EventHandler(this.ToolStripLabelHost_MouseEnter);
			this.toolStripLabelHost.MouseLeave += new System.EventHandler(this.ToolStripLabelHost_MouseLeave);
			// 
			// toolStripTextBoxHost
			// 
			this.toolStripTextBoxHost.AutoToolTip = true;
			this.toolStripTextBoxHost.BackColor = System.Drawing.SystemColors.Window;
			this.toolStripTextBoxHost.Name = "toolStripTextBoxHost";
			this.toolStripTextBoxHost.Size = new System.Drawing.Size(200, 25);
			this.toolStripTextBoxHost.Enter += new System.EventHandler(this.ToolStripTextBoxHost_Enter);
			this.toolStripTextBoxHost.Leave += new System.EventHandler(this.ToolStripTextBoxHost_Leave);
			this.toolStripTextBoxHost.MouseEnter += new System.EventHandler(this.ToolStripTextBoxHost_MouseEnter);
			this.toolStripTextBoxHost.MouseLeave += new System.EventHandler(this.ToolStripTextBoxHost_MouseLeave);
			// 
			// toolStripButtonEditHost
			// 
			this.toolStripButtonEditHost.Image = global::Hipparcos_DB.Properties.Resources.fugue_pencil_16px_shadowless;
			this.toolStripButtonEditHost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEditHost.Name = "toolStripButtonEditHost";
			this.toolStripButtonEditHost.Size = new System.Drawing.Size(73, 22);
			this.toolStripButtonEditHost.Text = "&Edit host";
			this.toolStripButtonEditHost.Click += new System.EventHandler(this.ToolStripButtonEditHost_Click);
			this.toolStripButtonEditHost.MouseEnter += new System.EventHandler(this.ToolStripButtonEditHost_MouseEnter);
			this.toolStripButtonEditHost.MouseLeave += new System.EventHandler(this.ToolStripButtonEditHost_MouseLeave);
			// 
			// toolStripSeparatorDownload
			// 
			this.toolStripSeparatorDownload.Name = "toolStripSeparatorDownload";
			this.toolStripSeparatorDownload.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonStartDownload
			// 
			this.toolStripButtonStartDownload.Image = global::Hipparcos_DB.Properties.Resources.fugue_drive_download_16px_shadowless;
			this.toolStripButtonStartDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStartDownload.Name = "toolStripButtonStartDownload";
			this.toolStripButtonStartDownload.Size = new System.Drawing.Size(107, 22);
			this.toolStripButtonStartDownload.Text = "&Start download";
			this.toolStripButtonStartDownload.Click += new System.EventHandler(this.ToolStripButtonStartDownload_Click);
			this.toolStripButtonStartDownload.MouseEnter += new System.EventHandler(this.ToolStripButtonStartDownload_MouseEnter);
			this.toolStripButtonStartDownload.MouseLeave += new System.EventHandler(this.ToolStripButtonStartDownload_MouseLeave);
			// 
			// DownloaderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DownloaderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DownloaderForm";
			this.Load += new System.EventHandler(this.DownloaderForm_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBarDownloadFile;
		private System.Windows.Forms.ProgressBar progressBarDownloadFiles;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelFilesDownload;
		private System.Windows.Forms.Label labelDownloadPercent;
		private System.Windows.Forms.Label labelDownlaodStatus;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripLabel toolStripLabelHost;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxHost;
		private System.Windows.Forms.ToolStripButton toolStripButtonEditHost;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorDownload;
		private System.Windows.Forms.ToolStripButton toolStripButtonStartDownload;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	}
}