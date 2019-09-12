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

		#region Click event handlers

		private void ButtonOpenTychoCatalog_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			new AboutBoxForm().ShowDialog();
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Close();
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
