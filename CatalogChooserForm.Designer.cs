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
			this.buttonExit = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStripText = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttonOpenTychoCatalog = new System.Windows.Forms.Button();
			this.buttonOpenHipparcosCatalog = new System.Windows.Forms.Button();
			this.groupBoxChooseCatalog = new System.Windows.Forms.GroupBox();
			this.statusStripText.SuspendLayout();
			this.groupBoxChooseCatalog.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			resources.ApplyResources(this.buttonExit, "buttonExit");
			this.buttonExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonExit.BackColor = System.Drawing.Color.Transparent;
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Name = "buttonExit";
			this.toolTip.SetToolTip(this.buttonExit, resources.GetString("buttonExit.ToolTip"));
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			this.buttonExit.Enter += new System.EventHandler(this.ButtonExit_Enter);
			this.buttonExit.Leave += new System.EventHandler(this.ButtonExit_Leave);
			this.buttonExit.MouseEnter += new System.EventHandler(this.ButtonExit_MouseEnter);
			this.buttonExit.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
			// 
			// statusStripText
			// 
			resources.ApplyResources(this.statusStripText, "statusStripText");
			this.statusStripText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.statusStripText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStripText.Name = "statusStripText";
			this.statusStripText.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStripText.SizingGrip = false;
			// 
			// toolStripStatusLabel
			// 
			resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
			this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			// 
			// buttonOpenTychoCatalog
			// 
			resources.ApplyResources(this.buttonOpenTychoCatalog, "buttonOpenTychoCatalog");
			this.buttonOpenTychoCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
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
			this.buttonOpenHipparcosCatalog.Name = "buttonOpenHipparcosCatalog";
			this.toolTip.SetToolTip(this.buttonOpenHipparcosCatalog, resources.GetString("buttonOpenHipparcosCatalog.ToolTip"));
			this.buttonOpenHipparcosCatalog.UseVisualStyleBackColor = true;
			this.buttonOpenHipparcosCatalog.Click += new System.EventHandler(this.ButtonOpenHipparcosCatalog_Click);
			this.buttonOpenHipparcosCatalog.Enter += new System.EventHandler(this.ButtonOpenHipparcosCatalog_Enter);
			this.buttonOpenHipparcosCatalog.Leave += new System.EventHandler(this.ButtonOpenHipparcosCatalog_Leave);
			this.buttonOpenHipparcosCatalog.MouseEnter += new System.EventHandler(this.ButtonOpenHipparcosCatalog_MouseEnter);
			this.buttonOpenHipparcosCatalog.MouseLeave += new System.EventHandler(this.ButtonOpenHipparcosCatalog_MouseLeave);
			// 
			// groupBoxChooseCatalog
			// 
			resources.ApplyResources(this.groupBoxChooseCatalog, "groupBoxChooseCatalog");
			this.groupBoxChooseCatalog.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxChooseCatalog.Controls.Add(this.buttonOpenHipparcosCatalog);
			this.groupBoxChooseCatalog.Controls.Add(this.buttonOpenTychoCatalog);
			this.groupBoxChooseCatalog.Name = "groupBoxChooseCatalog";
			this.groupBoxChooseCatalog.TabStop = false;
			// 
			// CatalogueChooserForm
			// 
			resources.ApplyResources(this, "$this");
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxChooseCatalog);
			this.Controls.Add(this.statusStripText);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "CatalogueChooserForm";
			this.Load += new System.EventHandler(this.CatalogChooserForm_Load);
			this.statusStripText.ResumeLayout(false);
			this.statusStripText.PerformLayout();
			this.groupBoxChooseCatalog.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStripText;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.Button buttonOpenTychoCatalog;
		private System.Windows.Forms.Button buttonOpenHipparcosCatalog;
		private System.Windows.Forms.GroupBox groupBoxChooseCatalog;
	}
}

