using System;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class DownloaderForm : Form
	{
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

		private void DownloaderForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonEditHost_Click(object sender, EventArgs e)
		{
			toolStripButtonEditHost.Checked = toolStripTextBoxHost.Enabled = !toolStripTextBoxHost.Enabled;
		}

		private void ToolStripButtonStartDownload_Click(object sender, EventArgs e)
		{
			toolStripButtonStartDownload.Enabled = false;
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

		private void LabelDownlaodStatus_MouseHover(object sender, EventArgs e)
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
	}
}