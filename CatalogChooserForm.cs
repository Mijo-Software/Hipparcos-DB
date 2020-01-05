using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Hipparcos_DB.Properties;
using Office2007Rendering;

namespace Hipparcos_DB
{
	/// <summary>
	/// CatalogChooserForm : Form
	/// </summary>
	public partial class CatalogChooserForm : Form
	{
		/// <summary>
		/// Settings
		/// </summary>
		private readonly Settings settings = new Settings();

		/// <summary>
		/// File names of the Hipparcos catalog
		/// </summary>
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

		/// <summary>
		/// File names of the tycho catalog
		/// </summary>
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

		/// <summary>
		/// Remove the file extension of a file name
		/// </summary>
		/// <param name="filename">file name</param>
		/// <returns>file name without extension</returns>
		private static string RemoveFileExtension(string filename) => filename.Substring(startIndex: 0, length: filename.LastIndexOf(value: ".", comparisonType: StringComparison.CurrentCulture));

		/// <summary>
		/// Check if a file has a specified extension
		/// </summary>
		/// <param name="filename">file name</param>
		/// <param name="extension">file extension</param>
		/// <returns>true if the file has a specified extension otherwise false</returns>
		private static bool HasFileExtension(string filename, string extension) => Path.GetExtension(path: filename).ToLower(culture: culture) == extension.ToLower(culture: culture);

		/// <summary>
		/// Open a directory
		/// </summary>
		/// <param name="path">path of the directory</param>
		private static void OpenDirectory(string path)
		{
			if (Directory.Exists(path: path))
			{
				Process.Start(fileName: @path);
			}
		}

		/// <summary>
		/// Set the information text in the status bar
		/// </summary>
		/// <param name="text">information text</param>
		private void SetStatusbar(string text) => toolStripStatusLabelInfo.Text = text;

		/// <summary>
		/// Remove the information text in the status bar
		/// </summary>
		private void ClearStatusbar() => toolStripStatusLabelInfo.Text = string.Empty;

		/// <summary>
		/// Check if all downloadad files exist
		/// </summary>
		/// <param name="path">path of the files</param>
		/// <param name="files">file names</param>
		/// <returns>true if all files exist otherwise false</returns>
		private bool CheckIfAllDownloadFilesExist(string path, string[] files)
		{
			bool checker = true;

			foreach (string file in files)
			{
				if (checker)
				{
					if (HasFileExtension(filename: file, extension: ".gz"))
					{
						checker = File.Exists(path: path + RemoveFileExtension(filename: file));
					}
					else
					{
						checker = File.Exists(path: path + file);
					}
				}
			}
			return checker;
		}

		/// <summary>
		/// Put out a error message about missing downloaded files
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
		private void MissingDownloadFiles()
		{
			MessageBox.Show(
				owner: this,
				text: Resources.missingDownloadFilesText2,
				caption: Resources.missingDownloadFilesTitle,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Error,
				defaultButton: MessageBoxDefaultButton.Button1);
		}

		#endregion

		#region Con- and Destructor

		/// <summary>
		/// Constructor
		/// </summary>
		public CatalogChooserForm() => InitializeComponent();

		#endregion

		#region Form* event handlers

		/// <summary>
		/// Load the main window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void CatalogChooserForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			ToolStripManager.Renderer = new Office2007Renderer();
		}

		#endregion

		#region Click event handlers

		/// <summary>
		/// Open the information window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			settings.Reload();
			using (AboutBoxForm formAboutBox = new AboutBoxForm())
			{
				formAboutBox.ShowDialog();
			}
		}

		/// <summary>
		/// Open the option window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonOptions_Click(object sender, EventArgs e)
		{
			settings.Reload();
			using (OptionsForm formOptions = new OptionsForm())
			{
				formOptions.ShowDialog();
			}
		}

		/// <summary>
		/// Close the main window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonExit_Click(object sender, EventArgs e) => Close();

		/// <summary>
		/// Open the download window and download the Hipparcos catalog
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
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

		/// <summary>
		/// Open the download window and download the Tycho catalog
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
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

		/// <summary>
		/// View the Hipparcos catalog
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonViewHipparcosCatalog_Click(object sender, EventArgs e)
		{
			settings.Reload();
			bool allFilesFound = CheckIfAllDownloadFilesExist(settings.UserHipparcosCatalogDirectory, filesHipparcosCatalog);
			if (allFilesFound)
			{
				using (HipparcosCatalogViewerForm formHipparcosCatalogViewer = new HipparcosCatalogViewerForm())
				{
					formHipparcosCatalogViewer.ShowDialog();
				}
			}
			else
			{
				MissingDownloadFiles();
			}
		}

		/// <summary>
		/// View the Tycho catalog
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonViewTychoCatalog_Click(object sender, EventArgs e)
		{
			settings.Reload();
			bool allFilesFound = CheckIfAllDownloadFilesExist(settings.UserTychoCatalogDirectory, filesTychoCatalog);
			if (allFilesFound)
			{
				using (TychoCatalogViewerForm formTychoCatalogViewer = new TychoCatalogViewerForm())
				{
					formTychoCatalogViewer.ShowDialog();
				}
			}
			else
			{
				MissingDownloadFiles();
			}
		}

		/// <summary>
		/// Open the local directory of the Hipparcos catalog
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonOpenHipparcosDirectory_Click(object sender, EventArgs e) => OpenDirectory(path: Environment.CurrentDirectory + Path.DirectorySeparatorChar + settings.UserHipparcosCatalogDirectory);

		/// <summary>
		/// Open the local directory of the Tycho catalog
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonOpenTychoDirectory_Click(object sender, EventArgs e) => OpenDirectory(path: Environment.CurrentDirectory + Path.DirectorySeparatorChar + settings.UserTychoCatalogDirectory);

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Set the information text in the status bar while entering a control
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				SetStatusbar(text: control.AccessibleDescription);
			}
			else if (sender is ToolStripButton toolStripButton)
			{
				SetStatusbar(text: toolStripButton.AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem toolStripMenuItem)
			{
				SetStatusbar(text: toolStripMenuItem.AccessibleDescription);
			}
			else if (sender is ToolStripLabel toolStripLabel)
			{
				SetStatusbar(text: toolStripLabel.AccessibleDescription);
			}
			else if (sender is ToolStripComboBox toolStripComboBox)
			{
				SetStatusbar(text: toolStripComboBox.AccessibleDescription);
			}
			else if (sender is ToolStripDropDown toolStripDropDown)
			{
				SetStatusbar(text: toolStripDropDown.AccessibleDescription);
			}
			else if (sender is ToolStripDropDownButton toolStripDropDownButton)
			{
				SetStatusbar(text: toolStripDropDownButton.AccessibleDescription);
			}
			else if (sender is ToolStripDropDownItem toolStripDropDownItem)
			{
				SetStatusbar(text: toolStripDropDownItem.AccessibleDescription);
			}
			else if (sender is ToolStripDropDownMenu toolStripDropDownMenu)
			{
				SetStatusbar(text: toolStripDropDownMenu.AccessibleDescription);
			}
			else if (sender is ToolStripProgressBar toolStripProgressBar)
			{
				SetStatusbar(text: toolStripProgressBar.AccessibleDescription);
			}
			else if (sender is ToolStripSplitButton toolStripSplitButton)
			{
				SetStatusbar(text: toolStripSplitButton.AccessibleDescription);
			}
			else if (sender is ToolStripSeparator toolStripSeparator)
			{
				SetStatusbar(text: toolStripSeparator.AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel toolStripStatusLabel)
			{
				SetStatusbar(text: toolStripStatusLabel.AccessibleDescription);
			}
			else if (sender is ToolStripTextBox toolStripTextBox)
			{
				SetStatusbar(text: toolStripTextBox.AccessibleDescription);
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clear the information text in the status bar while leaving a control
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion
	}
}
