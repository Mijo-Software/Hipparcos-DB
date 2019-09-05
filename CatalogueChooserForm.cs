using System;
using System.IO;
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
			string dataFile = @"hip_main.dat";
			if (File.Exists(path: dataFile))
			{
				new HipparcosCatalogueViewerForm().Show();
			}
			else
			{
				MessageBox.Show(
					text: "Die Datei HIP_MAIN.DAT fehlt. Stellen Sie sicher, dass die Datei im Ordner der Anwendung vorhanden ist. Sie können die Datei unter der URL http://cdsarc.u-strasbg.fr/viz-bin/nph-Cat/txt.gz?I/239/hip_main.dat.gz downloaden.",
					caption: "Datei fehlt",
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error);
			}
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
