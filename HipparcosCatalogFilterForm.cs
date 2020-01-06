using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	/// <summary>
	/// HipparcosCatalogFilterForm : Form
	/// </summary>
	public partial class HipparcosCatalogFilterForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public HipparcosCatalogFilterForm() => InitializeComponent();

		private void HipparcosCatalogFilterForm_Load(object sender, EventArgs e)
		{
		}

		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
		}

		private void SetCatalogHoverColor_Enter(object sender, EventArgs e)
		{
			SetStatusbar_Enter(sender: sender, e: e);
			labelCatalogDesc.BackColor = labelCatalogMin.BackColor = labelCatalogMax.BackColor = SystemColors.ControlLight;
		}

		private void SetIdentifierHoverColor_Enter(object sender, EventArgs e)
		{
			SetStatusbar_Enter(sender: sender, e: e);
			labelIdentifierDesc.BackColor = labelIdentifierMin.BackColor = labelIdentifierMax.BackColor = SystemColors.ControlLight;
		}

		private void ClearStatusbar_Leave(object sender, EventArgs e)
		{
		}

		private void ClearCatalogHoverColor_Leave(object sender, EventArgs e)
		{
			ClearStatusbar_Leave(sender: sender, e: e);
			labelCatalogDesc.BackColor = labelCatalogMin.BackColor = labelCatalogMax.BackColor = SystemColors.Control;
		}

		private void ClearIdentifierHoverColor_Leave(object sender, EventArgs e)
		{
			SetStatusbar_Enter(sender: sender, e: e);
			labelIdentifierDesc.BackColor = labelIdentifierMin.BackColor = labelIdentifierMax.BackColor = SystemColors.Control;
		}

		private void ToolStripButtonApplyFilterSettings_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripButtonCancel_Click(object sender, EventArgs e) => Close();

		private void ToolStripButtonRestoreToDefault_Click(object sender, EventArgs e)
		{
		}

		private void SetlProximityFlagHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetRightAscensionHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetDeclinationHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetMagnitudeJohnsonHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCoarseVariabilityFlagHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetSourceOfMagnitudeHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetAlphaHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetDeltaHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetReferenceFlagForAstrometryHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetTrigonomicParallaxHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetProperMotionAlphaHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetProperMotionDeltaHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetStandardErrorRightAscensionHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetStandardErrorDeclinationHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetStandardErrorTrigonomicParallaxHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetStandardErrorProperMotionRightAscensionHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetStandardErrorProperMotionDeclinationHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationDeclinationByRightAscensionHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationTrigonomicParallaxByRightAscensionHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationTrigonomicParallaxByDeclinationHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationProperMotionRightAscensionByRightAscensionHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationProperMotionRightAscensionByDeclinationHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationProperMotionRightAscensionByTrigonomicParallaxHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationProperMotionDeclinationByRightAscensionHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationProperMotionDeclinationByDeclinationHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationProperMotionDeclinationByTrigonomicParallaxHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetCorrelationProperMotionDeclinationByProperMotionRightAscensionHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetPercentageOfRejectedDataHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetGoodnessOfFitParameterHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetMeanBtMagnitudeHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetStandardErrorMeanBtMagnitudeHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetMeanVtMagnitudeHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetStandardErrorMeanVtMagnitudeHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetJohnsonBvColorHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetStandardErrorJohnsonBvColorHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetReferenceFlagForBtAndVtMagnitudeHoverColor_Enter(object sender, EventArgs e)
		{
		}

		private void SetSourceOfBvColorHoverColor_Enter(object sender, EventArgs e)
		{
		}
	}
}
