using System;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class CatalogueChooserForm : Form
	{
		public CatalogueChooserForm()
		{
			InitializeComponent();
		}

		private void SetStatusbar(string text)
		{
			toolStripStatusLabel.Text = text;
		}

		private void ClearStatusbar()
		{
			toolStripStatusLabel.Text = string.Empty;
		}

		private void CatalogueChooserForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenHipparcosCatalogue_Click(object sender, EventArgs e)
		{
			new HipparcosCatalogueViewerForm().Show();
		}

		private void ButtonOpenTychoCatalogue_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonOpenHipparcosCatalogue_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonOpenHipparcosCatalogue.AccessibleDescription);
		}

		private void ButtonOpenTychoCatalogue_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonOpenTychoCatalogue.AccessibleDescription);
		}

		private void ButtonExit_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonExit.AccessibleDescription);
		}

		private void ButtonOpenHipparcosCatalogue_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonOpenHipparcosCatalogue.AccessibleDescription);
		}

		private void ButtonOpenTychoCatalogue_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonOpenTychoCatalogue.AccessibleDescription);
		}

		private void ButtonExit_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonExit.AccessibleDescription);
		}

		private void ButtonOpenHipparcosCatalogue_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenTychoCatalogue_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonExit_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenHipparcosCatalogue_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenTychoCatalogue_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonExit_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}
	}
}
