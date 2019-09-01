using System;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class HipparcosCatalogueViewerForm : Form
	{
		public HipparcosCatalogueViewerForm()
		{
			InitializeComponent();
		}

		private void SetStatusbar(string text)
		{
			toolStripStatusLabel.Text = text;
		}

		private void ClearStatusbar()
		{
			toolStripStatusLabel.Text = string.Empty;
		}

		private void HipparcosCatalogueViewerForm_Load(object sender, System.EventArgs e)
		{
			ClearStatusbar();
		}

		private void MenuitemClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void ToolStripButtonStepToBegin_Click(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ToolStripButtonStepFastBackward_Click(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ToolStripButtonStepBackward_Click(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ToolStripButtonStepForward_Click(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ToolStripButtonStepFastForward_Click(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ToolStripButtonStepToEnd_Click(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void MenuitemClose_MouseEnter(object sender, System.EventArgs e)
		{
			SetStatusbar(text: menuitemClose.AccessibleDescription);
		}

		private void ToolStripButtonStepToBegin_MouseEnter(object sender, System.EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepToBegin.AccessibleDescription);
		}

		private void ToolStripButtonStepFastBackward_MouseEnter(object sender, System.EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepFastBackward.AccessibleDescription);
		}

		private void ToolStripButtonStepBackward_MouseEnter(object sender, System.EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepBackward.AccessibleDescription);
		}

		private void ToolStripButtonStepForward_MouseEnter(object sender, System.EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepForward.AccessibleDescription);
		}

		private void ToolStripButtonStepFastForward_MouseEnter(object sender, System.EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepFastForward.AccessibleDescription);
		}

		private void ToolStripButtonStepToEnd_MouseEnter(object sender, System.EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepToEnd.AccessibleDescription);
		}

		private void MenuitemClose_MouseLeave(object sender, System.EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepToBegin_MouseLeave(object sender, System.EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepFastBackward_MouseLeave(object sender, System.EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepBackward_MouseLeave(object sender, System.EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepForward_MouseLeave(object sender, System.EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepFastForward_MouseLeave(object sender, System.EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepToEnd_MouseLeave(object sender, System.EventArgs e)
		{
			ClearStatusbar();
		}
	}
}
