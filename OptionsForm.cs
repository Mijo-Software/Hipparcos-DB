using System;
using System.Windows.Forms;
using Hipparcos_DB.Properties;

namespace Hipparcos_DB
{
	/// <summary>
	/// OptionsForm
	/// </summary>
	public partial class OptionsForm : Form
	{
		/// <summary>
		/// Settings
		/// </summary>
		private readonly Settings settings = new Settings();

		/// <summary>
		/// Constructor
		/// </summary>
		public OptionsForm()
		{
			InitializeComponent();
			checkBoxEnableHoverEffect.Checked = settings.UserEnableHoverEffect;
			checkBoxEnableQuickDownload.Checked = settings.UserEnableQuickDownload;
			checkBoxEnableDoubleClickCopy.Checked = settings.UserEnableCopyMethod;
			comboBoxDataTableStyle.SelectedIndex = settings.UserDataTableStyle;
			comboBoxStartPosition.SelectedIndex = settings.UserStartPosition;
			textBoxHost.Text = settings.UserHostName;
			textBoxHipparcosDirectory.Text = settings.UserHipparcosCatalogDirectory;
			textBoxTychoDirectory.Text = settings.UserTychoCatalogDirectory;
			switch (settings.UserStartPosition)
			{
				case 0: StartPosition = FormStartPosition.CenterParent; break;
				case 1: StartPosition = FormStartPosition.CenterScreen; break;
				default: StartPosition = FormStartPosition.CenterParent; break;
			}
		}

		/// <summary>
		/// Set the information text in the status bar
		/// </summary>
		/// <param name="text">text to show</param>
		private void SetStatusbar(string text)
		{
			toolStripStatusLabelInfo.Text = text;
		}

		/// <summary>
		/// Clear the information text in the status bar 
		/// </summary>
		private void ClearStatusbar() => toolStripStatusLabelInfo.Text = string.Empty;

		/// <summary>
		/// Load the window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void OptionsForm_Load(object sender, EventArgs e) => ClearStatusbar();

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

		#region Click event handlers

		/// <summary>
		/// Apply the settings
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonApply_Click(object sender, EventArgs e)
		{
			settings.UserEnableHoverEffect = checkBoxEnableHoverEffect.Checked;
			settings.UserEnableCopyMethod = checkBoxEnableDoubleClickCopy.Checked;
			settings.UserDataTableStyle = (byte)comboBoxDataTableStyle.SelectedIndex;
			settings.UserEnableQuickDownload = checkBoxEnableQuickDownload.Checked;
			settings.UserHostName = textBoxHost.Text;
			settings.UserHipparcosCatalogDirectory = textBoxHipparcosDirectory.Text;
			settings.UserTychoCatalogDirectory = textBoxTychoDirectory.Text;
			settings.UserStartPosition = (byte)comboBoxStartPosition.SelectedIndex;
			settings.Save();
		}

		/// <summary>
		/// Load the default settings
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonDefaultSettings_Click(object sender, EventArgs e)
		{
			checkBoxEnableHoverEffect.Checked = settings.DefaultEnableHoverEffect;
			comboBoxStartPosition.SelectedIndex = settings.DefaultStartPosition;
			checkBoxEnableDoubleClickCopy.Checked = settings.DefaultEnableCopyMethod;
			comboBoxDataTableStyle.SelectedIndex = settings.DefaultDataTableStyle;
			checkBoxEnableQuickDownload.Checked = settings.DefaultEnableQuickDownload;
			textBoxHost.Text = settings.DefaultHostName;
			textBoxHipparcosDirectory.Text = settings.DefaultHipparcosCatalogDirectory;
			textBoxTychoDirectory.Text = settings.DefaultTychoCatalogDirectory;
		}

		/// <summary>
		/// Restore the default host
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonRestoreHost_Click(object sender, EventArgs e) => textBoxHost.Text = settings.DefaultHostName;

		/// <summary>
		/// Restore the default Hipparcos directory
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonRestoreHipparcosDirectory_Click(object sender, EventArgs e) => textBoxHipparcosDirectory.Text = settings.DefaultHipparcosCatalogDirectory;

		/// <summary>
		/// Restore the default Tycho directory
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void ButtonRestoreTychoDirectory_Click(object sender, EventArgs e) => textBoxTychoDirectory.Text = settings.DefaultTychoCatalogDirectory;

		#endregion
	}
}