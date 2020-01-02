using System;
using System.Globalization;
using System.Windows.Forms;
using Hipparcos_DB.Properties;
using MijoSoftware.AssemblyInformation;

namespace Hipparcos_DB
{
	/// <summary>
	/// AboutBoxForm : Form
	/// </summary>
	internal partial class AboutBoxForm : Form
	{
		/// <summary>
		/// Settings
		/// </summary>
		private readonly Settings settings = new Settings();

		/// <summary>
		/// Culture info
		/// </summary>
		private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Constructor
		/// </summary>
		public AboutBoxForm()
		{
			InitializeComponent();
			Text = string.Format(provider: culture, format: "info about {0}", args: AssemblyInfo.AssemblyTitle);
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = AssemblyInfo.AssemblyVersion;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;

			switch (settings.UserStartPosition)
			{
				case 0: StartPosition = FormStartPosition.CenterParent; break;
				case 1: StartPosition = FormStartPosition.CenterScreen; break;
				default: StartPosition = FormStartPosition.CenterParent; break;
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

		private void AboutBoxForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#region Enter event handlers

		private void LabelProductName_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelVersion_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelCopyright_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelCompanyName_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBoxDescription_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void OkButton_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region MouseEnter event handlers

		private void LogoPictureBox_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelProductName_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelVersion_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelCopyright_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelCompanyName_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBoxDescription_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void OkButton_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripStatusLabel_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region Leave event handlers

		private void LabelProductName_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVersion_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCopyright_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCompanyName_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBoxDescription_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion

		#region MouseLeave event handlers

		private void OkButton_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripStatusLabel_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProductName_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVersion_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCopyright_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCompanyName_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBoxDescription_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion
	}
}
