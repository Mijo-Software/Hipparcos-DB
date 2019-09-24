using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class DownloaderForm : Form
	{
		private string host, hostToRestore, catalogDirectory;

		private string[] hostFiles;

		public void SetHostUrls(string[] files)
		{
			hostFiles = files ?? throw new ArgumentNullException(paramName: nameof(files), message: "The name of the host files are null.");
		}

		public void SetHost(string host)
		{
			if (host is null || string.IsNullOrEmpty(value: host) || string.IsNullOrWhiteSpace(value: host))
			{
				throw new ArgumentException(message: "The name of the host are null, emtpy or a space.", paramName: nameof(host));
			}
			this.host = host;
			toolStripTextBoxHost.Text = host;
		}

		private string GetHost()
		{
			return host;
		}

		public void SetCatalogDirectory(string directory)
		{
			catalogDirectory = directory;
		}

		private string GetCatalogDirectory()
		{
			return catalogDirectory;
		}


		private string RemoveFileExtension(string filename)
		{
			return filename.Substring(startIndex: 0, length: filename.LastIndexOf(value: "."));
		}

		static byte[] Decompress(byte[] gzip)
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

		public DownloaderForm()
		{
			InitializeComponent();
		}

		private void SetStatusbar(string text)
		{
			toolStripStatusLabel.Text = text;
			toolStripStatusLabel.Visible = true;
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
			toolStripStatusLabel.Text = string.Empty;
			toolStripStatusLabel.Visible = false;
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

		private void DownloaderForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			toolStripButtonEditHost.Checked = toolStripTextBoxHost.Enabled = !toolStripTextBoxHost.Enabled;
			toolStripButtonRestoreHost.Enabled = false;
			hostToRestore = host;
		}

		private void ToolStripButtonEditHost_Click(object sender, EventArgs e)
		{
			toolStripButtonEditHost.Checked = toolStripTextBoxHost.Enabled = !toolStripTextBoxHost.Enabled;
			if (toolStripButtonEditHost.Checked)
			{
				toolStripButtonEditHost.Image = Properties.Resources.fugue_tick_button_16px_shadowless;
				toolStripButtonEditHost.Text = "&Apply";
				toolStripButtonRestoreHost.Enabled = true;				
			}
			else
			{
				toolStripButtonEditHost.Image = Properties.Resources.fugue_pencil_16px_shadowless;
				toolStripButtonEditHost.Text = "&Edit host";
			}
		}

		private void ToolStripButtonStartDownload_Click(object sender, EventArgs e)
		{
			toolStripButtonStartDownload.Enabled = toolStripTextBoxHost.Enabled = toolStripButtonEditHost.Enabled = toolStripButtonRestoreHost.Enabled = false;
			labelFilesDownload.Text = string.Empty;
			if (!Directory.Exists(path: GetCatalogDirectory()))
			{
				Directory.CreateDirectory(path: GetCatalogDirectory());
			}
			progressBarDownloadFiles.Maximum = hostFiles.Length;
			SetHost(host: toolStripTextBoxHost.Text);
			backgroundWorker.RunWorkerAsync();
		}

		private void ToolStripButtonRestoreHost_Click(object sender, EventArgs e)
		{
			SetHost(host: hostToRestore);
			toolStripTextBoxHost.Text = GetHost();
		}

		private void ToolStripTextBoxHost_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelDownlaodStatus_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelDownloadPercent_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelFilesDownload_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripLabelHost_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripTextBoxHost_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonEditHost_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonStartDownload_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelDownlaodStatus_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ProgressBarDownloadFile_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelDownloadPercent_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ProgressBarDownloadFiles_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelFilesDownload_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBox_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripStatusLabel_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonRestoreHost_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripTextBoxHost_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDownlaodStatus_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDownloadPercent_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFilesDownload_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBox_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripLabelHost_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripTextBoxHost_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonEditHost_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStartDownload_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDownlaodStatus_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ProgressBarDownloadFile_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDownloadPercent_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ProgressBarDownloadFiles_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFilesDownload_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBox_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripStatusLabel_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonRestoreHost_MouseMove(object sender, MouseEventArgs e)
		{
			ClearStatusbar();
		}

		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
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
						decompressedFile = GetCatalogDirectory() + RemoveFileExtension(hostFiles[index]);
						url = GetHost() + hostFiles[index];
						uri = new Uri(uriString: url);
						webClient.Proxy = null;
						labelDownloadStatus.Text = "Downloading: " + url;
						textBox.AppendText(text: labelDownloadStatus.Text + Environment.NewLine);
						//progressBarDownloadFile.Value = 0;
						progressBarDownloadFiles.PerformStep();
						labelFilesDownload.Text = (index + 1).ToString() + "/" + hostFiles.Length.ToString();
						//webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
						//webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
						webClient.DownloadFile(address: uri, fileName: downloadedFile);
						if (File.Exists(downloadedFile))
						{
							fileArray = File.ReadAllBytes(path: downloadedFile);
							labelDownloadStatus.Text = "Decompress: " + downloadedFile + " -> " + decompressedFile;
							textBox.AppendText(text: labelDownloadStatus.Text + Environment.NewLine);
							File.WriteAllBytes(path: decompressedFile, bytes: Decompress(gzip: fileArray));
							labelDownloadStatus.Text = "Delete: " + downloadedFile;
							textBox.AppendText(text: labelDownloadStatus.Text + Environment.NewLine + Environment.NewLine);
							File.Delete(path: downloadedFile);
						}
						else
						{
							textBox.AppendText(text: "ERROR!!! " + downloadedFile + "couldn't decompressed." + Environment.NewLine + Environment.NewLine);
						}
					}
					catch (Exception exception)
					{
						downloadWasSuccessful = false;
						textBox.AppendText(text: "ERROR!!! " + exception.Message + Environment.NewLine + Environment.NewLine);
					}
				}
				if (downloadWasSuccessful)
				{
					MessageBox.Show(
						text: "All files were downloaded and decompressed.",
						caption: "Successful",
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show(
						text: "Some files couldn't downloaded and decompressed. Read the logged error messages!",
						caption: "Error",
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Error);
				}
			}
		}
	}
}