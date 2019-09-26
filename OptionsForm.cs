using Hipparcos_DB.Properties;
using System;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class OptionsForm : Form
	{
		private readonly Settings setting = new Settings();

		public OptionsForm()
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

		private void OptionsForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			checkBoxEnableHoverEffect.Checked = setting.UserEnableHoverEffect;
			checkBoxEnableQuickDownload.Checked = setting.UserEnableQuickDownload;
			labelHost.Enabled = textBoxHost.Enabled = buttonRestoreHost.Enabled = checkBoxEnableQuickDownload.Checked;
			comboBoxCopyDataMethod.SelectedIndex = setting.UserCopyDataMethod;
			comboBoxDataTableStyle.SelectedIndex = setting.UserDataTableStyle;
			comboBoxStartPosition.SelectedIndex = setting.UserStartPosition;
			textBoxHost.Text = setting.UserHostName;
			textBoxHipparcosDirectory.Text = setting.UserHipparcosCatalogDirectory;
			textBoxTychoDirectory.Text = setting.UserTychoCatalogDirectory;
			switch (setting.UserStartPosition)
			{
				case 0: StartPosition = FormStartPosition.CenterScreen; break;
				case 1: StartPosition = FormStartPosition.CenterParent; break;
				default: StartPosition = FormStartPosition.CenterScreen; break;
			}
		}

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

		private void LabelCopyDataMethod_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ComboBoxCopyDataMethod_Enter(object sender, EventArgs e)
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

		private void LabelCopyDataMethod_MouseEnter(object sender, EventArgs e)
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

		private void LabelCopyDataMethod_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ComboBoxCopyDataMethod_Leave(object sender, EventArgs e)
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

		private void CheckBoxEnableHoverEffect_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCopyDataMethod_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ComboBoxCopyDataMethod_MouseLeave(object sender, EventArgs e)
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

		private void ButtonApply_Click(object sender, EventArgs e)
		{
			setting.UserEnableHoverEffect = checkBoxEnableHoverEffect.Checked;
			setting.UserCopyDataMethod = (byte)comboBoxCopyDataMethod.SelectedIndex;
			setting.UserDataTableStyle = (byte)comboBoxDataTableStyle.SelectedIndex;
			setting.UserEnableQuickDownload = checkBoxEnableQuickDownload.Checked;
			setting.UserHostName = textBoxHost.Text;
			setting.UserHipparcosCatalogDirectory = textBoxHipparcosDirectory.Text;
			setting.UserTychoCatalogDirectory = textBoxTychoDirectory.Text;
			setting.UserStartPosition = (byte)comboBoxStartPosition.SelectedIndex;
			setting.Save();
		}

		private void ButtonDefaultSettings_Click(object sender, EventArgs e)
		{
			checkBoxEnableHoverEffect.Checked = setting.DefaultEnableHoverEffect;
			comboBoxStartPosition.SelectedIndex = setting.DefaultStartPosition;
			comboBoxCopyDataMethod.SelectedIndex = setting.DefaultCopyDataMethod;
			comboBoxDataTableStyle.SelectedIndex = setting.DefaultDataTableStyle;
			checkBoxEnableQuickDownload.Checked = setting.DefaultEnableQuickDownload;
			textBoxHost.Text = setting.DefaultHostName;
			textBoxHipparcosDirectory.Text = setting.DefaultHipparcosCatalogDirectory;
			textBoxTychoDirectory.Text = setting.DefaultTychoCatalogDirectory;
		}

		private void ButtonRestoreHost_Click(object sender, EventArgs e)
		{
			textBoxHost.Text = setting.DefaultHostName;
		}

		private void ButtonRestoreHipparcosDirectory_Click(object sender, EventArgs e)
		{
			textBoxHipparcosDirectory.Text = setting.DefaultHipparcosCatalogDirectory;
		}

		private void ButtonRestoreTychoDirectory_Click(object sender, EventArgs e)
		{
			textBoxTychoDirectory.Text = setting.DefaultTychoCatalogDirectory;
		}

		private void CheckBoxEnableQuickDownload_CheckedChanged(object sender, EventArgs e)
		{
			labelHost.Enabled = textBoxHost.Enabled = buttonRestoreHost.Enabled = checkBoxEnableQuickDownload.Checked;
		}
	}
}