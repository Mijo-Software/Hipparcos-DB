using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Hipparcos_DB.Properties;

namespace Hipparcos_DB
{
	/// <summary>
	/// CatalogChooserForm : Form
	/// </summary>
	public partial class CatalogChooserForm : Form
	{
		private readonly Settings settings = new Settings();

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

		private readonly string[] filesTychoCatalog =
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
				"solar_t.dat.gz",
				"tyc_main.dat"
			};

		/// <summary>
		/// Culture info
		/// </summary>
		private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		#region Local methods

		private string RemoveFileExtension(string filename) => filename.Substring(startIndex: 0, length: filename.LastIndexOf(value: ".", comparisonType: StringComparison.CurrentCulture));

		private bool HasFileExtension(string filename, string extension) => Path.GetExtension(path: filename).ToLower(culture: culture) == extension.ToLower(culture: culture);

		private static void OpenExplorer(string path)
		{
			if (Directory.Exists(path: path))
			{
				Process.Start(fileName: @path);
			}
		}

		private void SetStatusbar(string text)
		{
			toolStripStatusLabelInfo.Text = text;
			toolStripStatusLabelInfo.Visible = true;
		}

		private void SetStatusbar(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				SetStatusbar(text: (control).AccessibleDescription);
			}
			else if (sender is ToolStripButton toolStripButton)
			{
				SetStatusbar(text: (toolStripButton).AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem toolStripMenuItem)
			{
				SetStatusbar(text: (toolStripMenuItem).AccessibleDescription);
			}
			else if (sender is ToolStripLabel toolStripLabel)
			{
				SetStatusbar(text: (toolStripLabel).AccessibleDescription);
			}
			else if (sender is ToolStripComboBox toolStripComboBox)
			{
				SetStatusbar(text: (toolStripComboBox).AccessibleDescription);
			}
			else if (sender is ToolStripDropDown toolStripDropDown)
			{
				SetStatusbar(text: (toolStripDropDown).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownButton toolStripDropDownButton)
			{
				SetStatusbar(text: (toolStripDropDownButton).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownItem toolStripDropDownItem)
			{
				SetStatusbar(text: (toolStripDropDownItem).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownMenu toolStripDropDownMenu)
			{
				SetStatusbar(text: (toolStripDropDownMenu).AccessibleDescription);
			}
			else if (sender is ToolStripProgressBar toolStripProgressBar)
			{
				SetStatusbar(text: (toolStripProgressBar).AccessibleDescription);
			}
			else if (sender is ToolStripSplitButton toolStripSplitButton)
			{
				SetStatusbar(text: (toolStripSplitButton).AccessibleDescription);
			}
			else if (sender is ToolStripSeparator toolStripSeparator)
			{
				SetStatusbar(text: (toolStripSeparator).AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel toolStripStatusLabel)
			{
				SetStatusbar(text: (toolStripStatusLabel).AccessibleDescription);
			}
			else if (sender is ToolStripTextBox toolStripTextBox)
			{
				SetStatusbar(text: (toolStripTextBox).AccessibleDescription);
			}
		}

		private void ClearStatusbar()
		{
			toolStripStatusLabelInfo.Text = string.Empty;
			toolStripStatusLabelInfo.Visible = false;
		}

		#endregion

		#region Con- and Destructor

		/// <summary>
		/// Constructor
		/// </summary>
		public CatalogChooserForm()
		{
			InitializeComponent();
			/*switch (settings.UserStartPosition)
			{
				case 0: StartPosition = FormStartPosition.CenterParent; break;
				case 1: StartPosition = FormStartPosition.CenterScreen; break;
				default: StartPosition = FormStartPosition.CenterParent; break;
			}
			*/
		}

		#endregion

		#region Form* event handlers

		private void CatalogChooserForm_Load(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Click event handlers

		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			settings.Reload();
			using (AboutBoxForm formAboutBox = new AboutBoxForm())
			{
				formAboutBox.ShowDialog();
			}
		}

		private void ButtonOptions_Click(object sender, EventArgs e)
		{
			settings.Reload();
			using (OptionsForm formOptions = new OptionsForm())
			{
				formOptions.ShowDialog();
			}
		}

		private void ButtonExit_Click(object sender, EventArgs e) => Close();

		private void ButtonDownloadHipparcosCatalog_Click(object sender, EventArgs e)
		{
			settings.Reload();
			using (DownloaderForm downloaderForm = new DownloaderForm())
			{
				downloaderForm.SetHost(host: settings.UserHostName);
				downloaderForm.SetHostUrls(files: filesHipparcosCatalog);
				downloaderForm.SetCatalogDirectory(directory: settings.UserHipparcosCatalogDirectory);
				downloaderForm.ShowDialog();
			}
		}

		private void ButtonDownloadTychoCatalog_Click(object sender, EventArgs e)
		{
			settings.Reload();
			using (DownloaderForm downloaderForm = new DownloaderForm())
			{
				downloaderForm.SetHost(host: settings.UserHostName);
				downloaderForm.SetHostUrls(files: filesTychoCatalog);
				downloaderForm.SetCatalogDirectory(directory: settings.UserTychoCatalogDirectory);
				downloaderForm.ShowDialog();
			}
		}

		private void ButtonOpenHipparcosCatalog_Click(object sender, EventArgs e)
		{
			settings.Reload();
			bool allFilesFound = true;
			foreach (string file in filesHipparcosCatalog)
			{
				if (allFilesFound)
				{
					allFilesFound = File.Exists(path: settings.UserHipparcosCatalogDirectory + RemoveFileExtension(filename: file));
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
					owner: this,
					text: Resources.missingDownloadFilesText2,
					caption: Resources.missingDownloadFilesTitle,
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error,
					defaultButton: MessageBoxDefaultButton.Button1,
					options: MessageBoxOptions.DefaultDesktopOnly);
			}
		}

		private void ButtonOpenTychoCatalog_Click(object sender, EventArgs e)
		{
			settings.Reload();
			bool allFilesFound = true;
			foreach (string file in filesTychoCatalog)
			{
				if (allFilesFound)
				{
					if (HasFileExtension(filename: file, extension: ".gz"))
					{
						allFilesFound = File.Exists(path: settings.UserTychoCatalogDirectory + RemoveFileExtension(filename: file));
					}
					else
					{
						allFilesFound = File.Exists(path: settings.UserTychoCatalogDirectory + file);
					}
				}
			}
			if (allFilesFound)
			{
				using (TychoCatalogViewerForm formTychoCatalogViewer = new TychoCatalogViewerForm())
				{
					formTychoCatalogViewer.ShowDialog();
				}
			}
			else
			{
				MessageBox.Show(
					owner: this,
					text: Resources.missingDownloadFilesText2,
					caption: Resources.missingDownloadFilesTitle,
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error,
					defaultButton: MessageBoxDefaultButton.Button1,
					options: MessageBoxOptions.DefaultDesktopOnly);
			}
		}

		private void ButtonOpenHipparcosDirectory_Click(object sender, EventArgs e) => OpenExplorer(path: Environment.CurrentDirectory + Path.DirectorySeparatorChar + settings.UserHipparcosCatalogDirectory);

		private void ButtonOpenTychoDirectory_Click(object sender, EventArgs e) => OpenExplorer(path: Environment.CurrentDirectory + Path.DirectorySeparatorChar + settings.UserTychoCatalogDirectory);

		#endregion

		#region Enter event handlers

		private void ButtonOpenHipparcosCatalog_Enter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonOpenTychoCatalog_Enter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonInfo_Enter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonOptions_Enter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonExit_Enter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonOpenHipparcosDirectory_Enter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonOpenTychoDirectory_Enter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		#endregion

		#region MouseEnter event handlers

		private void ButtonOpenHipparcosCatalog_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonOpenTychoCatalog_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonInfo_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonOptions_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonExit_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonOpenHipparcosDirectory_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ButtonOpenTychoDirectory_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		#endregion

		#region Leave event handlers

		private void ButtonOpenHipparcosCatalog_Leave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonOpenTychoCatalog_Leave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonInfo_Leave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonOptions_Leave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonExit_Leave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonOpenHipparcosDirectory_Leave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonOpenTychoDirectory_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region MouseLeave event handlers

		private void ButtonOpenHipparcosCatalog_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonOpenTychoCatalog_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonInfo_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonOptions_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonExit_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonOpenHipparcosDirectory_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ButtonOpenTychoDirectory_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		#endregion
	}
}
