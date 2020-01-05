using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Hipparcos_DB.Properties;

namespace Hipparcos_DB
{
	/// <summary>
	/// DownloaderForm : Form
	/// </summary>
	public partial class DownloaderForm : Form
	{
		/// <summary>
		/// Settings
		/// </summary>
		private readonly Settings settings = new Settings();

		/// <summary>
		/// Host
		/// </summary>
		private string host;

		/// <summary>
		/// Catalog directory
		/// </summary>
		private string catalogDirectory;

		/// <summary>
		/// Host files
		/// </summary>
		private string[] hostFiles;

		/// <summary>
		/// Ticks
		/// </summary>
		private long ticks;

		/// <summary>
		/// Culture info
		/// </summary>
		private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		#region Local methods

		/// <summary>
		/// Set the host urls
		/// </summary>
		/// <param name="files">host urls</param>
		public void SetHostUrls(string[] files) => hostFiles = files ?? throw new ArgumentNullException(paramName: nameof(files), message: Resources.invalidHostnameText);

		/// <summary>
		/// Set the host
		/// </summary>
		/// <param name="host">url to host</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1500:VariableNamesShouldNotMatchFieldNames", MessageId = "host")]
		public void SetHost(string host)
		{
			if (host is null || string.IsNullOrEmpty(value: host) || string.IsNullOrWhiteSpace(value: host))
			{
				throw new ArgumentException(message: Resources.invalidHostnameText, paramName: nameof(host));
			}
			this.host = host;
			toolStripTextBoxHost.Text = host;
		}

		/// <summary>
		/// Get the host
		/// </summary>
		private string GetHost() => host;

		/// <summary>
		/// Set the catalog directory
		/// </summary>
		/// <param name="directory">path to catalog</param>
		public void SetCatalogDirectory(string directory) => catalogDirectory = directory;

		/// <summary>
		/// Get the catalog directory
		/// </summary>
		private string GetCatalogDirectory() => catalogDirectory;

		/// <summary>
		/// Remove the file extension of a file name
		/// </summary>
		/// <param name="filename">file name</param>
		/// <returns>file name without extension</returns>
		private static string RemoveFileExtension(string filename) => filename.Substring(startIndex: 0, length: filename.LastIndexOf(value: ".", comparisonType: StringComparison.CurrentCulture));

		/// <summary>
		/// Decomprees a GZ compressed file
		/// </summary>
		/// <param name="gzip">GZ compressed file as byte array</param>
		/// <returns>decompressed file</returns>
		private static byte[] Decompress(byte[] gzip)
		{
			// Create a GZIP stream with decompression mode.
			// ... Then create a buffer and write into while reading from the GZIP stream.
			using (GZipStream stream = new GZipStream(stream: new MemoryStream(buffer: gzip), mode: CompressionMode.Decompress))
			{
				const int size = 4096;
				byte[] buffer = new byte[size];
				using (MemoryStream memory = new MemoryStream())
				{
					int count = 0;
					do
					{
						count = stream.Read(array: buffer, offset: 0, count: size);
						if (count > 0)
						{
							memory.Write(buffer, 0, count);
						}
					}
					while (count > 0);
					return memory.ToArray();
				}
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
		/// Show a specified error message
		/// </summary>
		/// <param name="message">error message</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
		private void ShowFileErrorMessage(string message)
		{
			MessageBox.Show(
				owner: this,
				text: "Logging file couldn't saved." + Environment.NewLine + Environment.NewLine + "Reason: " + message,
				caption: Resources.errorTitle,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Error,
				defaultButton: MessageBoxDefaultButton.Button1);
		}

		/*
		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			progressBarDownloadFile.Value = e.ProgressPercentage;
			labelDownloadPercent.Text = e.ProgressPercentage.ToString() + "%";
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: e.ProgressPercentage, progressMax: 100);
		}
		*/

		/*
		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
			TaskbarProgress.SetValue(windowHandle: Handle, progressValue: 0, progressMax: 100);
			if (e.Error == null)
			{
			}
			else
			{
				if (e.Cancelled)
				{
				}
				else
				{
				}
			}
		}
		*/

		#endregion

		#region Don-/Destructor

		/// <summary>
		/// Constructor
		/// </summary>
		public DownloaderForm()
		{
			InitializeComponent();
			switch (settings.UserStartPosition)
			{
				case 0: StartPosition = FormStartPosition.CenterParent; break;
				case 1: StartPosition = FormStartPosition.CenterScreen; break;
				default: StartPosition = FormStartPosition.CenterParent; break;
			}
			toolStripButtonEditHost.Checked = toolStripTextBoxHost.Enabled = !toolStripTextBoxHost.Enabled;
			toolStripButtonRestoreHost.Enabled = toolStripStatusLabelDownloadAnimation.Visible = toolStripButtonSaveLogging.Enabled = false;
		}

		#endregion

		#region Form* event handler

		/// <summary>
		/// Load the main window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void DownloaderForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			textBox.BackColor = Color.White;
			labelFilesDownload.Text = string.Empty;
			if (settings.UserEnableQuickDownload)
			{
				ToolStripButtonStartDownload_Click(sender: sender, e: e);
			}
		}

		#endregion

		#region Click event handlers

		/// <summary>
		/// Enable to edit the host
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripButtonEditHost_Click(object sender, EventArgs e)
		{
			toolStripButtonEditHost.Checked = toolStripTextBoxHost.Enabled = !toolStripTextBoxHost.Enabled;
			if (toolStripButtonEditHost.Checked)
			{
				toolStripButtonEditHost.Image = Resources.fugue_tick_button_16px_shadowless;
				toolStripButtonEditHost.Text = Resources.applyLabel;
				toolStripButtonRestoreHost.Enabled = true;
			}
			else
			{
				toolStripButtonEditHost.Image = Resources.fugue_pencil_16px_shadowless;
				toolStripButtonEditHost.Text = Resources.editHostLabel;
				settings.UserHostName = toolStripTextBoxHost.Text;
				settings.Save();
			}
		}

		/// <summary>
		/// Start the download
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripButtonStartDownload_Click(object sender, EventArgs e)
		{
			toolStripStatusLabelDownloadAnimation.Visible = true;
			timerDownloadAnimation.Enabled = true;
			toolStripButtonStartDownload.Enabled = toolStripTextBoxHost.Enabled = toolStripButtonEditHost.Enabled = toolStripButtonRestoreHost.Enabled = false;
			labelFilesDownload.Text = string.Empty;
			if (!Directory.Exists(path: GetCatalogDirectory()))
			{
				Directory.CreateDirectory(path: GetCatalogDirectory());
			}
			progressBarDownloadFiles.Maximum = hostFiles.Length * 3;
			SetHost(host: toolStripTextBoxHost.Text);
			backgroundWorker.RunWorkerAsync();
		}

		/// <summary>
		/// Restore the default host
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripButtonRestoreHost_Click(object sender, EventArgs e)
		{
			SetHost(host: settings.DefaultHostName);
			toolStripTextBoxHost.Text = GetHost();
		}

		/// <summary>
		/// Save the settings
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ToolStripButtonSaveLogging_Click(object sender, EventArgs e) => saveFileDialog.ShowDialog();

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

		#region File* event handler

		/// <summary>
		/// Save the logging file
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
		private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				File.WriteAllText(path: saveFileDialog.FileName, contents: textBox.Text);
			}
			catch (ArgumentException exception)
			{
				ShowFileErrorMessage(exception.Message);
			}
			catch (PathTooLongException exception)
			{
				ShowFileErrorMessage(exception.Message);
			}
			catch (DirectoryNotFoundException exception)
			{
				ShowFileErrorMessage(exception.Message);
			}
			finally
			{
				MessageBox.Show(
					owner: this,
					text: Resources.loggingFileSavedText,
					caption: Resources.loggingFileSavedTitle,
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error,
					defaultButton: MessageBoxDefaultButton.Button1);
			}
		}

		#endregion

		#region BackgroundWorker event handler

		/// <summary>
		/// Download the files
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			progressBarDownloadFile.MarqueeAnimationSpeed = 10;
			bool downloadWasSuccessful = true;
			using (WebClient webClient = new WebClient())
			{
				Uri uri;
				string downloadedFile, decompressedFile, url;
				byte[] fileArray;
				for (int index = 0; index < hostFiles.Length; index++)
				{
					try
					{
						downloadedFile = GetCatalogDirectory() + hostFiles[index];
						decompressedFile = GetCatalogDirectory() + RemoveFileExtension(filename: hostFiles[index]);
						url = GetHost() + hostFiles[index];
						uri = new Uri(uriString: url);
						webClient.Proxy = null;
						labelDownloadStatus.Text = $"[{DateTime.Now.ToString(provider: culture)}] Downloading: {url}";
						textBox.AppendText(text: labelDownloadStatus.Text + Environment.NewLine);
						//progressBarDownloadFile.Value = 0;
						progressBarDownloadFiles.PerformStep();
						labelFilesDownload.Text = $"{(index + 1).ToString(provider: culture)}/{hostFiles.Length.ToString(provider: culture)}";
						//webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
						//webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
						webClient.DownloadFile(address: uri, fileName: downloadedFile);
						if (File.Exists(downloadedFile))
						{
							fileArray = File.ReadAllBytes(path: downloadedFile);
							labelDownloadStatus.Text = $"[{DateTime.Now.ToString(provider: culture)}] Decompress: {downloadedFile} -> {decompressedFile}";
							textBox.AppendText(text: labelDownloadStatus.Text + Environment.NewLine);
							progressBarDownloadFiles.PerformStep();
							File.WriteAllBytes(path: decompressedFile, bytes: Decompress(gzip: fileArray));
							labelDownloadStatus.Text = $"[{DateTime.Now.ToString(provider: culture)}] Delete: {downloadedFile}";
							textBox.AppendText(text: labelDownloadStatus.Text + Environment.NewLine + Environment.NewLine);
							File.Delete(path: downloadedFile);
							progressBarDownloadFiles.PerformStep();
						}
						else
						{
							textBox.AppendText(text: $"[{DateTime.Now.ToString(provider: culture)}] ERROR!!! {downloadedFile} couldn't decompressed.{Environment.NewLine}{Environment.NewLine}");
						}
					}
					catch (WebException exception)
					{
						downloadWasSuccessful = false;
						textBox.AppendText(text: $"[{DateTime.Now.ToString(provider: culture)}] ERROR!!! {exception.Message}{Environment.NewLine}{Environment.NewLine}");
					}
				}
				toolStripStatusLabelDownloadAnimation.Visible = timerDownloadAnimation.Enabled = false;
				progressBarDownloadFile.MarqueeAnimationSpeed = 0;
				if (downloadWasSuccessful)
				{
					if (!settings.UserEnableQuickDownload)
					{
						MessageBox.Show(
							owner: this,
							text: Resources.allFilesDownloadedText,
							caption: Resources.allFilesDownloadedTitle,
							buttons: MessageBoxButtons.OK,
							icon: MessageBoxIcon.Information,
							defaultButton: MessageBoxDefaultButton.Button1);
					}
					Close();
				}
				else
				{
					toolStripButtonSaveLogging.Enabled = true;
					MessageBox.Show(
						owner: this,
						text: Resources.someFilesNotDowloadedText,
						caption: Resources.errorTitle,
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Error,
						defaultButton: MessageBoxDefaultButton.Button1);
				}
			}
		}

		/// <summary>
		/// Hide the text cursor
		/// </summary>
		/// <param name="hWnd">window handler</param>
		/// <returns>true if hided</returns>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1414:MarkBooleanPInvokeArgumentsWithMarshalAs")]
		[DllImport("user32.dll")]
		private static extern bool HideCaret(IntPtr hWnd);

		/// <summary>
		/// Hide the text cursor while changed the text in the text box
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void TextBox_TextChanged(object sender, EventArgs e) => HideCaret(hWnd: textBox.Handle);

		#endregion

		#region Tick event handler

		/// <summary>
		/// Animate the download icon
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void TimerDownloadAnimation_Tick(object sender, EventArgs e)
		{
			ticks++;
			toolStripStatusLabelDownloadAnimation.Image = ticks % 2 == 0 ? Resources.fugue_arrow_270_16px_shadowless : Resources.fugue_arrow_270_small_16px_shadowless;
		}

		#endregion
	}
}