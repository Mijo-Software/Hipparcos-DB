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

		private void LabelCatalogueDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelCatalogueData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelIdentifierDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelIdentifierData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelProximityFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelProximityData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelMagnitudeJohnsonDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelMagnitudeJohnsonData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelCoarseVariabilityFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelCoarseVariabilityFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelSourceOfMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelSourceOfMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelAlphaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelAlphaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelDeltaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelDeltaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelReferenceFlagForAstrometryDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelReferenceFlagForAstrometryData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelProperMotionAlphaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: label.AccessibleDescription);
		}

		private void LabelProperMotionAlphaData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionDeltaDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionDeltaData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRightAscensionDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRightAscensionData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorDeclinationDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorDeclinationData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionRightAscensionData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionDeclinationDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionDeclinationData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationDeclinationByRightAscensionData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelPercentageOfRejectedDataDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelPercentageOfRejectedDataData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMeanBtMagnitudeDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMeanBtMagnitudeData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanBtMagnitudeData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMeanVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMeanVtMagnitudeData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanVtMagnitudeData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColourDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColourData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColourDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColourData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfBvColourDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfBvColourData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelColourIndexInCousinsSystemDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelColourIndexInCousinsSystemData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorViDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorViData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfViDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfViData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelFlagForCombinedMagnitudesDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelFlagForCombinedMagnitudesData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityPeriodDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityPeriodData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityTypeDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityTypeData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAdditionalDataAboutVariabilityDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAdditionalDataAboutVariabilityData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelLightCurveAnnexDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelLightCurveAnnexData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCcdmIdentifierDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCcdmIdentifierData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelHistoricalStatusFlagDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelHistoricalStatusFlagData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNumberEntriesWithSameCcdmDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNumberEntriesWithSameCcdmData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNumberComponentsInThisEntryDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNumberComponentsInThisEntryData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMultipleSystemsFlagDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMultipleSystemsFlagData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricSourceFlagDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricSourceFlagData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSolutionQualityDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSolutionQualityData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelComponentIdentifiersDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelComponentIdentifiersData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelPositionAngleBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelPositionAngleBetweenComponentsData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAngularSeparationBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAngularSeparationBetweenComponentsData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRhoDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRhoData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelFlagIndicatingSurveyStarDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelFlagIndicatingSurveyStarData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelIdentificationChartDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelIdentificationChartData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelExistenceOfNotesDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelExistenceOfNotesData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelHdNumberDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelHdNumberData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelBonnerDmDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelBonnerDmData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCordobaDmDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCordobaDmData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCapePhotographicDmDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCapePhotographicDmData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelViUsedForReductionsDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelViUsedForReductionsData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSpectraTypeDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSpectraTypeData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfSpectraTypeDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfSpectraTypeData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCatalogueDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCatalogueData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelIdentifierData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelProximityFlagDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelProximityData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelRightAscensionData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelDeclinationData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeJohnsonDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeJohnsonData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCoarseVariabilityFlagDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCoarseVariabilityFlagData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfMagnitudeData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAlphaDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAlphaData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelDeltaDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelDeltaData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForAstrometryDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForAstrometryData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionAlphaDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionAlphaData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionDeltaDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionDeltaData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRightAscensionData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorDeclinationData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionDeclinationData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelPercentageOfRejectedDataDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelPercentageOfRejectedDataData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColourDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColourData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColourDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColourData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfBvColourData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelColourIndexInCousinsSystemDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelColourIndexInCousinsSystemData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorViDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorViData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfViDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfViData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelFlagForCombinedMagnitudesDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelFlagForCombinedMagnitudesData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfBvColourDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityPeriodDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityPeriodData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityTypeDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityTypeData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAdditionalDataAboutVariabilityDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAdditionalDataAboutVariabilityData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelLightCurveAnnexDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelLightCurveAnnexData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCcdmIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCcdmIdentifierData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelHistoricalStatusFlagDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelHistoricalStatusFlagData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNumberEntriesWithSameCcdmDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNumberEntriesWithSameCcdmData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNumberComponentsInThisEntryDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNumberComponentsInThisEntryData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMultipleSystemsFlagDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMultipleSystemsFlagData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricSourceFlagDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricSourceFlagData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSolutionQualityDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSolutionQualityData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelComponentIdentifiersDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelComponentIdentifiersData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelPositionAngleBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelPositionAngleBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAngularSeparationBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAngularSeparationBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRhoDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRhoData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelFlagIndicatingSurveyStarDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelFlagIndicatingSurveyStarData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelIdentificationChartDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelIdentificationChartData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelExistenceOfNotesDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelExistenceOfNotesData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelHdNumberDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelHdNumberData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelBonnerDmDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelBonnerDmData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCordobaDmDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCordobaDmData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCapePhotographicDmDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCapePhotographicDmData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelViUsedForReductionsDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelViUsedForReductionsData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSpectraTypeDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSpectraTypeData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfSpectraTypeDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfSpectraTypeData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCatalogueDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCatalogueData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelIdentifierDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelIdentifierData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProximityFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProximityData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMagnitudeJohnsonDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMagnitudeJohnsonData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCoarseVariabilityFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCoarseVariabilityFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAlphaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAlphaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDeltaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDeltaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForAstrometryDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForAstrometryData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelTrigonomicParallaxData_Click(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProperMotionAlphaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProperMotionAlphaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProperMotionDeltaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProperMotionDeltaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorProperMotionRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorProperMotionDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationDeclinationByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelPercentageOfRejectedDataDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelPercentageOfRejectedDataData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelGoodnessOfFitParameterDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelGoodnessOfFitParameterData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMeanBtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMeanBtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMeanBtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMeanVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMeanVtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMeanVtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelJohnsonBvColourDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelJohnsonBvColourData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorJohnsonBvColourDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorJohnsonBvColourData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfBvColourDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfBvColourData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelColourIndexInCousinsSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelColourIndexInCousinsSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorViDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorViData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfViDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfViData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFlagForCombinedMagnitudesDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFlagForCombinedMagnitudesData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVariabilityPeriodDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVariabilityPeriodData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVariabilityTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVariabilityTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAdditionalDataAboutVariabilityDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAdditionalDataAboutVariabilityData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelLightCurveAnnexDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelLightCurveAnnexData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCcdmIdentifierDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCcdmIdentifierData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHistoricalStatusFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHistoricalStatusFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberEntriesWithSameCcdmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberEntriesWithSameCcdmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberComponentsInThisEntryDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberComponentsInThisEntryData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMultipleSystemsFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMultipleSystemsFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAstrometricSourceFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAstrometricSourceFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSolutionQualityDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSolutionQualityData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelComponentIdentifiersDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelComponentIdentifiersData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelPositionAngleBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelPositionAngleBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAngularSeparationBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAngularSeparationBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorRhoDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorRhoData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFlagIndicatingSurveyStarDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFlagIndicatingSurveyStarData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelIdentificationChartDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelIdentificationChartData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelExistenceOfNotesDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelExistenceOfNotesData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHdNumberDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHdNumberData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelBonnerDmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelBonnerDmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCordobaDmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCordobaDmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCapePhotographicDmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCapePhotographicDmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelViUsedForReductionsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelViUsedForReductionsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSpectraTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSpectraTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfSpectraTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfSpectraTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCatalogueDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCatalogueData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelIdentifierDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelIdentifierData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProximityFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProximityData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMagnitudeJohnsonDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMagnitudeJohnsonData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCoarseVariabilityFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCoarseVariabilityFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAlphaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAlphaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDeltaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelDeltaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForAstrometryDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForAstrometryData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProperMotionAlphaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProperMotionAlphaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProperMotionDeltaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelProperMotionDeltaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorProperMotionDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelPercentageOfRejectedDataDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelPercentageOfRejectedDataData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelGoodnessOfFitParameterDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelGoodnessOfFitParameterData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelJohnsonBvColourDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelJohnsonBvColourData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorJohnsonBvColourDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorJohnsonBvColourData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfBvColourData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelColourIndexInCousinsSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelColourIndexInCousinsSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorViDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorViData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfViDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfViData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFlagForCombinedMagnitudesDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFlagForCombinedMagnitudesData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVariabilityPeriodDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVariabilityPeriodData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVariabilityTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelVariabilityTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAdditionalDataAboutVariabilityDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAdditionalDataAboutVariabilityData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelLightCurveAnnexDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelLightCurveAnnexData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCcdmIdentifierDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCcdmIdentifierData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHistoricalStatusFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHistoricalStatusFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberEntriesWithSameCcdmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberEntriesWithSameCcdmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberComponentsInThisEntryDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelNumberComponentsInThisEntryData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMultipleSystemsFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMultipleSystemsFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAstrometricSourceFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAstrometricSourceFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSolutionQualityDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSolutionQualityData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelComponentIdentifiersDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelComponentIdentifiersData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelPositionAngleBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelPositionAngleBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAngularSeparationBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelAngularSeparationBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorRhoDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorRhoData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFlagIndicatingSurveyStarDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelFlagIndicatingSurveyStarData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelIdentificationChartDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelIdentificationChartData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelExistenceOfNotesDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelExistenceOfNotesData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHdNumberDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelHdNumberData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelBonnerDmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelBonnerDmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCordobaDmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCordobaDmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCapePhotographicDmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCapePhotographicDmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelViUsedForReductionsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelViUsedForReductionsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSpectraTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSpectraTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfSpectraTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfSpectraTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}
	}
}
