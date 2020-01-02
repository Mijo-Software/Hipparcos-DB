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

		private void OptionsForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#region Enter event handlers

		private void ButtonApply_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonCancel_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void CheckBoxEnableHoverEffect_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelDataTableStyle_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ComboBoxDataTableStyle_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void CheckBoxEnableQuickDownload_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelHost_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBoxHost_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelHipparcosDirectory_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBoxHipparcosDirectory_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelTychoDirectory_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBoxTychoDirectory_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelStartPosition_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ComboBoxStartPosition_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonRestoreHost_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonRestoreHipparcosDirectory_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonRestoreTychoDirectory_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonDefaultSettings_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void CheckBoxEnableDoubleClickCopy_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region MouseEnter event handlers

		private void ButtonApply_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonCancel_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void CheckBoxEnableHoverEffect_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ComboBoxCopyDataMethod_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelDataTableStyle_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ComboBoxDataTableStyle_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void CheckBoxEnableQuickDownload_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelDefaultHost_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBoxDefaultHost_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelHipparcosDirectory_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBoxHipparcosDirectory_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelTychoDirectory_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void TextBoxTychoDirectory_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripStatusLabelInfo_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelStartPosition_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ComboBoxStartPosition_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonRestoreHost_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonRestoreHipparcosDirectory_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonRestoreTychoDirectory_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ButtonDefaultSettings_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void CheckBoxEnableDoubleClickCopy_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region Leave event handlers

		private void ButtonApply_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonCancel_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void CheckBoxEnableHoverEffect_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDataTableStyle_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ComboBoxDataTableStyle_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void CheckBoxEnableQuickDownload_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHost_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBoxHost_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHipparcosDirectory_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBoxHipparcosDirectory_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelTychoDirectory_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBoxTychoDirectory_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStartPosition_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ComboBoxStartPosition_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonApply_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonCancel_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonRestoreHost_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonRestoreHipparcosDirectory_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonRestoreTychoDirectory_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonDefaultSettings_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void CheckBoxEnableDoubleClickCopy_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion

		#region MouseLeave event handlers

		private void CheckBoxEnableHoverEffect_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDataTableStyle_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ComboBoxDataTableStyle_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void CheckBoxEnableQuickDownload_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDefaultHost_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBoxDefaultHost_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHipparcosDirectory_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBoxHipparcosDirectory_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelTychoDirectory_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void TextBoxTychoDirectory_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripStatusLabelInfo_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStartPosition_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ComboBoxStartPosition_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonRestoreHost_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonRestoreHipparcosDirectory_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonRestoreTychoDirectory_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ButtonDefaultSettings_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void CheckBoxEnableDoubleClickCopy_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion

		#region Click event handlers

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

		private void ButtonRestoreHost_Click(object sender, EventArgs e)
		{
			textBoxHost.Text = settings.DefaultHostName;
		}

		private void ButtonRestoreHipparcosDirectory_Click(object sender, EventArgs e)
		{
			textBoxHipparcosDirectory.Text = settings.DefaultHipparcosCatalogDirectory;
		}

		private void ButtonRestoreTychoDirectory_Click(object sender, EventArgs e)
		{
			textBoxTychoDirectory.Text = settings.DefaultTychoCatalogDirectory;
		}

		#endregion
	}
}