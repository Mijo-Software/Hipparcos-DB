using System;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			InitializeComponent();
		}

		private void OptionsForm_Load(object sender, EventArgs e)
		{
			labelDefaultHost.Enabled = textBoxDefaultHost.Enabled = buttonRestoreHost.Enabled = checkBoxEnableQuickDownload.Checked;
			comboBoxCopyDataMethod.SelectedItem = 0;
			comboBoxDataTableStyle.SelectedItem = 0;
			textBoxDefaultHost.Text = "http://cdsarc.u-strasbg.fr/ftp/I/239/";
			textBoxHipparcosDirectory.Text = "catalog/i239/";
			textBoxTychoDirectory.Text = "catalog/i239/";
		}

		private void ButtonApply_Enter(object sender, EventArgs e)
		{

		}

		private void ButtonCancel_Enter(object sender, EventArgs e)
		{

		}

		private void CheckBoxEnableHoverEffect_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCopyDataMethod_Enter(object sender, EventArgs e)
		{

		}

		private void ComboBoxCopyDataMethod_Enter(object sender, EventArgs e)
		{

		}

		private void LabelDataTableStyle_Enter(object sender, EventArgs e)
		{

		}

		private void ComboBoxDataTableStyle_Enter(object sender, EventArgs e)
		{

		}

		private void CheckBoxEnableQuickDownload_Enter(object sender, EventArgs e)
		{

		}

		private void LabelDefaultHost_Enter(object sender, EventArgs e)
		{

		}

		private void TextBoxDefaultHost_Enter(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosDirectory_Enter(object sender, EventArgs e)
		{

		}

		private void TextBoxHipparcosDirectory_Enter(object sender, EventArgs e)
		{

		}

		private void LabelTychoDirectory_Enter(object sender, EventArgs e)
		{

		}

		private void TextBoxTychoDirectory_Enter(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHost_Enter(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHipparcosDirectory_Enter(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreTychoDirectory_Enter(object sender, EventArgs e)
		{

		}

		private void ButtonApply_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ButtonCancel_MouseEnter(object sender, EventArgs e)
		{

		}

		private void CheckBoxEnableHoverEffect_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCopyDataMethod_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ComboBoxCopyDataMethod_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelDataTableStyle_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ComboBoxDataTableStyle_MouseEnter(object sender, EventArgs e)
		{

		}

		private void CheckBoxEnableQuickDownload_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelDefaultHost_MouseEnter(object sender, EventArgs e)
		{

		}

		private void TextBoxDefaultHost_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosDirectory_MouseEnter(object sender, EventArgs e)
		{

		}

		private void TextBoxHipparcosDirectory_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelTychoDirectory_MouseEnter(object sender, EventArgs e)
		{

		}

		private void TextBoxTychoDirectory_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripStatusLabelInfo_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHost_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHipparcosDirectory_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreTychoDirectory_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ButtonApply_Leave(object sender, EventArgs e)
		{

		}

		private void ButtonCancel_Leave(object sender, EventArgs e)
		{

		}

		private void CheckBoxEnableHoverEffect_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCopyDataMethod_Leave(object sender, EventArgs e)
		{

		}

		private void ComboBoxCopyDataMethod_Leave(object sender, EventArgs e)
		{

		}

		private void LabelDataTableStyle_Leave(object sender, EventArgs e)
		{

		}

		private void ComboBoxDataTableStyle_Leave(object sender, EventArgs e)
		{

		}

		private void CheckBoxEnableQuickDownload_Leave(object sender, EventArgs e)
		{

		}

		private void LabelDefaultHost_Leave(object sender, EventArgs e)
		{

		}

		private void TextBoxDefaultHost_Leave(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosDirectory_Leave(object sender, EventArgs e)
		{

		}

		private void TextBoxHipparcosDirectory_Leave(object sender, EventArgs e)
		{

		}

		private void LabelTychoDirectory_Leave(object sender, EventArgs e)
		{

		}

		private void TextBoxTychoDirectory_Leave(object sender, EventArgs e)
		{

		}

		private void ButtonApply_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ButtonCancel_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHost_Leave(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHipparcosDirectory_Leave(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreTychoDirectory_Leave(object sender, EventArgs e)
		{

		}

		private void CheckBoxEnableHoverEffect_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCopyDataMethod_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ComboBoxCopyDataMethod_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelDataTableStyle_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ComboBoxDataTableStyle_MouseLeave(object sender, EventArgs e)
		{

		}

		private void CheckBoxEnableQuickDownload_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelDefaultHost_MouseLeave(object sender, EventArgs e)
		{

		}

		private void TextBoxDefaultHost_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosDirectory_MouseLeave(object sender, EventArgs e)
		{

		}

		private void TextBoxHipparcosDirectory_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelTychoDirectory_MouseLeave(object sender, EventArgs e)
		{

		}

		private void TextBoxTychoDirectory_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripStatusLabelInfo_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHost_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHipparcosDirectory_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreTychoDirectory_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ButtonApply_Click(object sender, EventArgs e)
		{

		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHost_Click(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreHipparcosDirectory_Click(object sender, EventArgs e)
		{

		}

		private void ButtonRestoreTychoDirectory_Click(object sender, EventArgs e)
		{

		}

		private void CheckBoxEnableQuickDownload_CheckedChanged(object sender, EventArgs e)
		{
			labelDefaultHost.Enabled = textBoxDefaultHost.Enabled = buttonRestoreHost.Enabled = checkBoxEnableQuickDownload.Checked;
		}
	}
}
