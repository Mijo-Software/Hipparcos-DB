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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogueChooserForm));
			this.buttonExit = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStripText = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttonOpenTychoCatalogue = new System.Windows.Forms.Button();
			this.buttonOpenHipparcosCatalogue = new System.Windows.Forms.Button();
			this.groupBoxChooseCatalogue = new System.Windows.Forms.GroupBox();
			this.statusStripText.SuspendLayout();
			this.groupBoxChooseCatalogue.SuspendLayout();
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
			// buttonOpenTychoCatalogue
			// 
			resources.ApplyResources(this.buttonOpenTychoCatalogue, "buttonOpenTychoCatalogue");
			this.buttonOpenTychoCatalogue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpenTychoCatalogue.Name = "buttonOpenTychoCatalogue";
			this.toolTip.SetToolTip(this.buttonOpenTychoCatalogue, resources.GetString("buttonOpenTychoCatalogue.ToolTip"));
			this.buttonOpenTychoCatalogue.UseVisualStyleBackColor = true;
			this.buttonOpenTychoCatalogue.Click += new System.EventHandler(this.ButtonOpenTychoCatalogue_Click);
			this.buttonOpenTychoCatalogue.Enter += new System.EventHandler(this.ButtonOpenTychoCatalogue_Enter);
			this.buttonOpenTychoCatalogue.Leave += new System.EventHandler(this.ButtonOpenTychoCatalogue_Leave);
			this.buttonOpenTychoCatalogue.MouseEnter += new System.EventHandler(this.ButtonOpenTychoCatalogue_MouseEnter);
			this.buttonOpenTychoCatalogue.MouseLeave += new System.EventHandler(this.ButtonOpenTychoCatalogue_MouseLeave);
			// 
			// buttonOpenHipparcosCatalogue
			// 
			resources.ApplyResources(this.buttonOpenHipparcosCatalogue, "buttonOpenHipparcosCatalogue");
			this.buttonOpenHipparcosCatalogue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonOpenHipparcosCatalogue.Name = "buttonOpenHipparcosCatalogue";
			this.toolTip.SetToolTip(this.buttonOpenHipparcosCatalogue, resources.GetString("buttonOpenHipparcosCatalogue.ToolTip"));
			this.buttonOpenHipparcosCatalogue.UseVisualStyleBackColor = true;
			this.buttonOpenHipparcosCatalogue.Click += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_Click);
			this.buttonOpenHipparcosCatalogue.Enter += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_Enter);
			this.buttonOpenHipparcosCatalogue.Leave += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_Leave);
			this.buttonOpenHipparcosCatalogue.MouseEnter += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_MouseEnter);
			this.buttonOpenHipparcosCatalogue.MouseLeave += new System.EventHandler(this.ButtonOpenHipparcosCatalogue_MouseLeave);
			// 
			// groupBoxChooseCatalogue
			// 
			resources.ApplyResources(this.groupBoxChooseCatalogue, "groupBoxChooseCatalogue");
			this.groupBoxChooseCatalogue.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxChooseCatalogue.Controls.Add(this.buttonOpenHipparcosCatalogue);
			this.groupBoxChooseCatalogue.Controls.Add(this.buttonOpenTychoCatalogue);
			this.groupBoxChooseCatalogue.Name = "groupBoxChooseCatalogue";
			this.groupBoxChooseCatalogue.TabStop = false;
			// 
			// CatalogueChooserForm
			// 
			resources.ApplyResources(this, "$this");
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxChooseCatalogue);
			this.Controls.Add(this.statusStripText);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "CatalogueChooserForm";
			this.Load += new System.EventHandler(this.CatalogueChooserForm_Load);
			this.statusStripText.ResumeLayout(false);
			this.statusStripText.PerformLayout();
			this.groupBoxChooseCatalogue.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStripText;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.Button buttonOpenTychoCatalogue;
		private System.Windows.Forms.Button buttonOpenHipparcosCatalogue;
		private System.Windows.Forms.GroupBox groupBoxChooseCatalogue;
	}
}

