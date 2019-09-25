namespace Hipparcos_DB
{
    partial class AboutBoxForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBoxForm));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelProductName = new System.Windows.Forms.Label();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.okButton = new System.Windows.Forms.Button();
			this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.statusStrip.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.AccessibleDescription = "description of the application";
			this.textBoxDescription.AccessibleName = "description";
			this.textBoxDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDescription.Location = new System.Drawing.Point(112, 55);
			this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxDescription.Size = new System.Drawing.Size(209, 47);
			this.textBoxDescription.TabIndex = 4;
			this.textBoxDescription.Text = "description";
			this.toolTip.SetToolTip(this.textBoxDescription, "description of the application");
			this.textBoxDescription.Enter += new System.EventHandler(this.TextBoxDescription_Enter);
			this.textBoxDescription.Leave += new System.EventHandler(this.TextBoxDescription_Leave);
			this.textBoxDescription.MouseEnter += new System.EventHandler(this.TextBoxDescription_MouseEnter);
			this.textBoxDescription.MouseLeave += new System.EventHandler(this.TextBoxDescription_MouseLeave);
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.AccessibleDescription = "company name of the application";
			this.labelCompanyName.AccessibleName = "company name";
			this.labelCompanyName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCompanyName.Location = new System.Drawing.Point(112, 39);
			this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(209, 13);
			this.labelCompanyName.TabIndex = 3;
			this.labelCompanyName.Text = "company name";
			this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelCompanyName, "company name of the application");
			this.labelCompanyName.Enter += new System.EventHandler(this.LabelCompanyName_Enter);
			this.labelCompanyName.Leave += new System.EventHandler(this.LabelCompanyName_Leave);
			this.labelCompanyName.MouseEnter += new System.EventHandler(this.LabelCompanyName_MouseEnter);
			this.labelCompanyName.MouseLeave += new System.EventHandler(this.LabelCompanyName_MouseLeave);
			// 
			// labelCopyright
			// 
			this.labelCopyright.AccessibleDescription = "copyright of the application";
			this.labelCopyright.AccessibleName = "copyright";
			this.labelCopyright.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCopyright.Location = new System.Drawing.Point(112, 26);
			this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(209, 13);
			this.labelCopyright.TabIndex = 2;
			this.labelCopyright.Text = "copyright";
			this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelCopyright, "copyright of the application");
			this.labelCopyright.Enter += new System.EventHandler(this.LabelCopyright_Enter);
			this.labelCopyright.Leave += new System.EventHandler(this.LabelCopyright_Leave);
			this.labelCopyright.MouseEnter += new System.EventHandler(this.LabelCopyright_MouseEnter);
			this.labelCopyright.MouseLeave += new System.EventHandler(this.LabelCopyright_MouseLeave);
			// 
			// labelVersion
			// 
			this.labelVersion.AccessibleDescription = "version of the application";
			this.labelVersion.AccessibleName = "version";
			this.labelVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Location = new System.Drawing.Point(112, 13);
			this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(209, 13);
			this.labelVersion.TabIndex = 1;
			this.labelVersion.Text = "version";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelVersion, "version of the application");
			this.labelVersion.Enter += new System.EventHandler(this.LabelVersion_Enter);
			this.labelVersion.Leave += new System.EventHandler(this.LabelVersion_Leave);
			this.labelVersion.MouseEnter += new System.EventHandler(this.LabelVersion_MouseEnter);
			this.labelVersion.MouseLeave += new System.EventHandler(this.LabelVersion_MouseLeave);
			// 
			// labelProductName
			// 
			this.labelProductName.AccessibleDescription = "product name of the application";
			this.labelProductName.AccessibleName = "product name";
			this.labelProductName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Location = new System.Drawing.Point(112, 0);
			this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(209, 13);
			this.labelProductName.TabIndex = 0;
			this.labelProductName.Text = "product name";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelProductName, "product name of the application");
			this.labelProductName.Enter += new System.EventHandler(this.LabelProductName_Enter);
			this.labelProductName.Leave += new System.EventHandler(this.LabelProductName_Leave);
			this.labelProductName.MouseEnter += new System.EventHandler(this.LabelProductName_MouseEnter);
			this.labelProductName.MouseLeave += new System.EventHandler(this.LabelProductName_MouseLeave);
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.AccessibleDescription = "lower part of the container";
			this.BottomToolStripPanel.AccessibleName = "lower part of the container";
			this.BottomToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 153);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(150, 22);
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
			this.statusStrip.Size = new System.Drawing.Size(324, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.AccessibleDescription = "upper part of the container";
			this.TopToolStripPanel.AccessibleName = "upper part of the container";
			this.TopToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(150, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.AccessibleDescription = "right part of the container";
			this.RightToolStripPanel.AccessibleName = "right part of the container";
			this.RightToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.RightToolStripPanel.Location = new System.Drawing.Point(150, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 153);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.AccessibleDescription = "left part of the container";
			this.LeftToolStripPanel.AccessibleName = "left part of the container";
			this.LeftToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 153);
			// 
			// ContentPanel
			// 
			this.ContentPanel.AccessibleDescription = "content panel of the container";
			this.ContentPanel.AccessibleName = "content panel of the container";
			this.ContentPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.ContentPanel.Size = new System.Drawing.Size(150, 153);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "pane with some information of the application";
			this.tableLayoutPanel.AccessibleName = "information panel";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.14598F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.89781F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(324, 137);
			this.tableLayoutPanel.TabIndex = 0;
			this.tableLayoutPanel.TabStop = true;
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
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel);
			this.toolStripContainer.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(324, 137);
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
			this.toolStripContainer.Size = new System.Drawing.Size(324, 159);
			this.toolStripContainer.TabIndex = 3;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.AccessibleDescription = "upper part of the container";
			this.toolStripContainer.TopToolStripPanel.AccessibleName = "upper part of the container";
			this.toolStripContainer.TopToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			// 
			// okButton
			// 
			this.okButton.AccessibleDescription = "Clock to close the dialog";
			this.okButton.AccessibleName = "okay button";
			this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Image = global::Hipparcos_DB.Properties.Resources.fugue_tick_button_16px_shadowless;
			this.okButton.Location = new System.Drawing.Point(246, 111);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 5;
			this.okButton.Text = "&OK";
			this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.okButton, "OK");
			this.okButton.Enter += new System.EventHandler(this.OkButton_Enter);
			this.okButton.MouseEnter += new System.EventHandler(this.OkButton_MouseEnter);
			this.okButton.MouseLeave += new System.EventHandler(this.OkButton_MouseLeave);
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
			this.toolStripStatusLabelInfo.MouseEnter += new System.EventHandler(this.ToolStripStatusLabel_MouseEnter);
			this.toolStripStatusLabelInfo.MouseLeave += new System.EventHandler(this.ToolStripStatusLabel_MouseLeave);
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.AccessibleDescription = "image with hipparcos";
			this.logoPictureBox.AccessibleName = "image with hipparcos";
			this.logoPictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logoPictureBox.Image = global::Hipparcos_DB.Properties.Resources.hipparcos1;
			this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.Size = new System.Drawing.Size(100, 131);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			this.logoPictureBox.MouseEnter += new System.EventHandler(this.LogoPictureBox_MouseEnter);
			// 
			// AboutBoxForm
			// 
			this.AcceptButton = this.okButton;
			this.AccessibleDescription = "Show some information about the application";
			this.AccessibleName = "Information about the application";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 159);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AboutBoxForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Info about ...";
			this.Load += new System.EventHandler(this.AboutBoxForm_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelCompanyName;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
	}
}
