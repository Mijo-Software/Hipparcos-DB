namespace Hipparcos_DB
{
	partial class CatalogueChooserForm
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
			this.buttonOpenHipparcosCatalogue = new System.Windows.Forms.Button();
			this.buttonOpenTychoCatalogue = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.panel = new System.Windows.Forms.Panel();
			this.statusStripText = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel.SuspendLayout();
			this.statusStripText.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOpenHipparcosCatalogue
			// 
			this.buttonOpenHipparcosCatalogue.AccessibleDescription = "Open the Hipparcos Catalogue";
			this.buttonOpenHipparcosCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOpenHipparcosCatalogue.Location = new System.Drawing.Point(3, 3);
			this.buttonOpenHipparcosCatalogue.Name = "buttonOpenHipparcosCatalogue";
			this.buttonOpenHipparcosCatalogue.Size = new System.Drawing.Size(160, 23);
			this.buttonOpenHipparcosCatalogue.TabIndex = 0;
			this.buttonOpenHipparcosCatalogue.Text = "&Hipparcos Catalogue";
			this.toolTip.SetToolTip(this.buttonOpenHipparcosCatalogue, "Open the Hipparcos Catalogue");
			this.buttonOpenHipparcosCatalogue.UseVisualStyleBackColor = true;
			this.buttonOpenHipparcosCatalogue.Click += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_Click);
			this.buttonOpenHipparcosCatalogue.Enter += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_Enter);
			this.buttonOpenHipparcosCatalogue.Leave += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_Leave);
			this.buttonOpenHipparcosCatalogue.MouseEnter += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_MouseEnter);
			this.buttonOpenHipparcosCatalogue.MouseLeave += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_MouseLeave);
			// 
			// buttonOpenTychoCatalogue
			// 
			this.buttonOpenTychoCatalogue.AccessibleDescription = "Open the Tycho Catalogue";
			this.buttonOpenTychoCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOpenTychoCatalogue.Enabled = false;
			this.buttonOpenTychoCatalogue.Location = new System.Drawing.Point(3, 32);
			this.buttonOpenTychoCatalogue.Name = "buttonOpenTychoCatalogue";
			this.buttonOpenTychoCatalogue.Size = new System.Drawing.Size(160, 23);
			this.buttonOpenTychoCatalogue.TabIndex = 1;
			this.buttonOpenTychoCatalogue.Text = "&Tycho Catalogue";
			this.toolTip.SetToolTip(this.buttonOpenTychoCatalogue, "Open the Tycho Catalogue");
			this.buttonOpenTychoCatalogue.UseVisualStyleBackColor = true;
			this.buttonOpenTychoCatalogue.Click += new System.EventHandler(this.ButtonOpenTychoCatalogue_Click);
			this.buttonOpenTychoCatalogue.Enter += new System.EventHandler(this.ButtonOpenTychoCatalogue_Enter);
			this.buttonOpenTychoCatalogue.Leave += new System.EventHandler(this.ButtonOpenTychoCatalogue_Leave);
			this.buttonOpenTychoCatalogue.MouseEnter += new System.EventHandler(this.ButtonOpenTychoCatalogue_MouseEnter);
			this.buttonOpenTychoCatalogue.MouseLeave += new System.EventHandler(this.ButtonOpenTychoCatalogue_MouseLeave);
			// 
			// buttonExit
			// 
			this.buttonExit.AccessibleDescription = "Exit the application";
			this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExit.BackColor = System.Drawing.Color.Transparent;
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(12, 92);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(168, 23);
			this.buttonExit.TabIndex = 1;
			this.buttonExit.Text = "E&xit";
			this.toolTip.SetToolTip(this.buttonExit, "Exit the application");
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			this.buttonExit.Enter += new System.EventHandler(this.ButtonExit_Enter);
			this.buttonExit.Leave += new System.EventHandler(this.ButtonExit_Leave);
			this.buttonExit.MouseEnter += new System.EventHandler(this.ButtonExit_MouseEnter);
			this.buttonExit.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel.Controls.Add(this.buttonOpenHipparcosCatalogue);
			this.panel.Controls.Add(this.buttonOpenTychoCatalogue);
			this.panel.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel.Location = new System.Drawing.Point(12, 12);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(168, 63);
			this.panel.TabIndex = 0;
			// 
			// statusStripText
			// 
			this.statusStripText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStripText.Location = new System.Drawing.Point(0, 128);
			this.statusStripText.Name = "statusStripText";
			this.statusStripText.Size = new System.Drawing.Size(192, 22);
			this.statusStripText.SizingGrip = false;
			this.statusStripText.TabIndex = 4;
			this.statusStripText.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(50, 17);
			this.toolStripStatusLabel.Text = "info text";
			// 
			// CatalogueChooserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(192, 150);
			this.Controls.Add(this.statusStripText);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "CatalogueChooserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Catalogue Chooser";
			this.Load += new System.EventHandler(this.CatalogueChooserForm_Load);
			this.panel.ResumeLayout(false);
			this.statusStripText.ResumeLayout(false);
			this.statusStripText.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOpenHipparcosCatalogue;
		private System.Windows.Forms.Button buttonOpenTychoCatalogue;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.StatusStrip statusStripText;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	}
}

