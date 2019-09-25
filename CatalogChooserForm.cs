using System;
using System.IO;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class CatalogChooserForm : Form
	{
		private readonly string[] filesHipparcosCatalog =
			{
				"h_dm_com.dat.gz",
				"h_dm_cor.dat.gz",
				"hd_notes.doc.gz",
				"hg_notes.doc.gz",
				"h_dm_cor.dat.gz",
				"hip_dm_g.dat.gz",
				"hip_dm_o.dat.gz",
				"hip_dm_v.dat.gz",
				"hip_dm_x.dat.gz",
				"hip_main.dat.gz",
				"hip_va_1.dat.gz",
				"hip_va_2.dat.gz",
				"hp_auth.doc.gz",
				"hp_notes.doc.gz",
				"hp_refs.doc.gz",
				"solar_ha.dat.gz",
				"solar_hp.dat.gz",
				"solar_t.dat.gz"
			};

		private string RemoveFileExtension(string filename)
		{
			return filename.Substring(startIndex: 0, length: filename.LastIndexOf(value: "."));
		}

		public CatalogChooserForm()
		{
			InitializeComponent();
		}

		private void SetStatusbar(string text)
		{
			toolStripStatusLabelInfo.Text = text;
			toolStripStatusLabelInfo.Visible = true;
		}

		private void SetStatusbar(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				SetStatusbar(text: ((TextBox)sender).AccessibleDescription);
			}
			else if (sender is Button)
			{
				SetStatusbar(text: ((Button)sender).AccessibleDescription);
			}
			else if (sender is RadioButton)
			{
				SetStatusbar(text: ((RadioButton)sender).AccessibleDescription);
			}
			else if (sender is DateTimePicker)
			{
				SetStatusbar(text: ((DateTimePicker)sender).AccessibleDescription);
			}
			else if (sender is Label)
			{
				SetStatusbar(text: ((Label)sender).AccessibleDescription);
			}
			else if (sender is PictureBox)
			{
				SetStatusbar(text: ((PictureBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripButton)
			{
				SetStatusbar(text: ((ToolStripButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem)
			{
				SetStatusbar(text: ((ToolStripMenuItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripLabel)
			{
				SetStatusbar(text: ((ToolStripLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripComboBox)
			{
				SetStatusbar(text: ((ToolStripComboBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDown)
			{
				SetStatusbar(text: ((ToolStripDropDown)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownButton)
			{
				SetStatusbar(text: ((ToolStripDropDownButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownItem)
			{
				SetStatusbar(text: ((ToolStripDropDownItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownMenu)
			{
				SetStatusbar(text: ((ToolStripDropDownMenu)sender).AccessibleDescription);
			}
			else if (sender is ToolStripProgressBar)
			{
				SetStatusbar(text: ((ToolStripProgressBar)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSplitButton)
			{
				SetStatusbar(text: ((ToolStripSplitButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSeparator)
			{
				SetStatusbar(text: ((ToolStripSeparator)sender).AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel)
			{
				SetStatusbar(text: ((ToolStripStatusLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripTextBox)
			{
				SetStatusbar(text: ((ToolStripTextBox)sender).AccessibleDescription);
			}
		}

		private void ClearStatusbar()
		{
			toolStripStatusLabelInfo.Text = string.Empty;
			toolStripStatusLabelInfo.Visible = false;
		}

		private void CatalogChooserForm_Load(object sender, EventArgs e)
		{
			buttonDownloadTychoCatalog.Enabled = buttonOpenTychoCatalog.Enabled = false;
			/*
			if (!Directory.Exists(path: "catalogs/i239"))
			{
				buttonOpenHipparcosCatalog.Enabled = false;
				buttonOpenTychoCatalog.Enabled = false;
			}
			*/
			ClearStatusbar();
		}
				
		#region Click event handlers

		private void ButtonOpenTychoCatalog_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			using (AboutBoxForm formAboutBox = new AboutBoxForm())
			{
				formAboutBox.ShowDialog();
			}
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonDownloadHipparcosCatalog_Click(object sender, EventArgs e)
		{
			using (DownloaderForm downloaderForm = new DownloaderForm())
			{
				downloaderForm.SetHost(host: "http://cdsarc.u-strasbg.fr/ftp/I/239/");
				//downloaderForm.SetHost(host: "http://cdsarc.u-strasbg.fr/viz-bin/nph-Cat/txt.gz?I/239/");
				downloaderForm.SetHostUrls(files: filesHipparcosCatalog);
				downloaderForm.SetCatalogDirectory(directory: "catalogs/i239/");
				downloaderForm.ShowDialog();
			}
		}

		private void ButtonDownloadTychoCatalog_Click(object sender, EventArgs e)
		{
			using (DownloaderForm downloaderForm = new DownloaderForm())
			{
				downloaderForm.ShowDialog();
			}
		}

		private void ButtonOpenHipparcosCatalog_Click(object sender, EventArgs e)
		{
			bool allFilesFound = true;
			foreach (string file in filesHipparcosCatalog)
			{
				if (allFilesFound)
				{
					if (File.Exists(path: "catalogs/i239/" + RemoveFileExtension(filename: file)))
					{
						allFilesFound = true;
					}
					else
					{
						allFilesFound = false;
					}
				}
			}
			if (allFilesFound)
			{
				using (HipparcosCatalogViewerForm formHipparcosCatalogViewer = new HipparcosCatalogViewerForm())
				{
					formHipparcosCatalogViewer.ShowDialog();
				}
			}
			else
			{
				MessageBox.Show(
					text: "Some files are missing. Please use the download button to download all files.",
					caption: "Missing files",
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error);
			}
		}

		#endregion

		#region Enter event handlers

		private void ButtonOpenHipparcosCatalog_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonOpenTychoCatalog_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonInfo_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonExit_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region MouseEnter event handlers

		private void ButtonOpenHipparcosCatalog_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonOpenTychoCatalog_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}
		private void ButtonInfo_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonExit_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region Leave event handlers

		private void ButtonOpenHipparcosCatalog_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenTychoCatalog_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}
		private void ButtonInfo_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonExit_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion

		#region MouseLeave event handlers

		private void ButtonOpenHipparcosCatalog_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonOpenTychoCatalog_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonInfo_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonExit_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion		
	}
}
