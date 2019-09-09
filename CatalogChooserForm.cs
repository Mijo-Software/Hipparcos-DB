using System;
using System.IO;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class CatalogChooserForm : Form
	{
		public CatalogChooserForm()
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

		private void CatalogChooserForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenHipparcosCatalog_Click(object sender, EventArgs e)
		{
			string dataFile = @"hip_main.dat";
			if (File.Exists(path: dataFile))
			{
				new HipparcosCatalogViewerForm().ShowDialog();
			}
			else
			{
				MessageBox.Show(
					text: "The file HIP_MAIN.DAT is missing. Make sure that the file exists in the folder of the application. You can download the file from the URL http://cdsarc.u-strasbg.fr/viz-bin/nph-Cat/txt.gz?I/239/hip_main.dat.gz.",
					caption: "Missing file",
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error);
			}
		}

		private void ButtonOpenTychoCatalog_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonOpenHipparcosCatalog_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonOpenHipparcosCatalog.AccessibleDescription);
		}

		private void ButtonOpenTychoCatalog_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonOpenTychoCatalog.AccessibleDescription);
		}

		private void ButtonExit_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonExit.AccessibleDescription);
		}

		private void ButtonOpenHipparcosCatalog_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonOpenHipparcosCatalog.AccessibleDescription);
		}

		private void ButtonOpenTychoCatalog_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonOpenTychoCatalog.AccessibleDescription);
		}

		private void ButtonExit_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: buttonExit.AccessibleDescription);
		}

		private void ButtonOpenHipparcosCatalog_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenTychoCatalog_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonExit_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenHipparcosCatalog_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenTychoCatalog_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonExit_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}
	}
}
