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

		#region Click event handlers

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

		#endregion

		#region Enter evenat handlers

		private void LabelCatalogueDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCatalogueDesc.AccessibleDescription);
		}

		private void LabelCatalogueData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCatalogueData.AccessibleDescription);
		}

		private void LabelIdentifierDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentifierDesc.AccessibleDescription);
		}

		private void LabelIdentifierData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentifierData.AccessibleDescription);
		}

		private void LabelProximityFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProximityFlagDesc.AccessibleDescription);
		}

		private void LabelProximityData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProximityData.AccessibleDescription);
		}

		private void LabelRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelRightAscensionDesc.AccessibleDescription);
		}

		private void LabelRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelRightAscensionData.AccessibleDescription);
		}

		private void LabelDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeclinationDesc.AccessibleDescription);
		}

		private void LabelDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeclinationData.AccessibleDescription);
		}

		private void LabelMagnitudeJohnsonDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeJohnsonDesc.AccessibleDescription);
		}

		private void LabelMagnitudeJohnsonData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeJohnsonData.AccessibleDescription);
		}

		private void LabelCoarseVariabilityFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCoarseVariabilityFlagDesc.AccessibleDescription);
		}

		private void LabelCoarseVariabilityFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCoarseVariabilityFlagData.AccessibleDescription);
		}

		private void LabelSourceOfMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfMagnitudeDesc.AccessibleDescription);
		}

		private void LabelSourceOfMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfMagnitudeData.AccessibleDescription);
		}

		private void LabelAlphaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAlphaDesc.AccessibleDescription);
		}

		private void LabelAlphaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAlphaData.AccessibleDescription);
		}

		private void LabelDeltaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeltaDesc.AccessibleDescription);
		}

		private void LabelDeltaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeltaData.AccessibleDescription);
		}

		private void LabelReferenceFlagForAstrometryDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForAstrometryDesc.AccessibleDescription);
		}

		private void LabelReferenceFlagForAstrometryData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForAstrometryData.AccessibleDescription);
		}

		private void LabelTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelTrigonomicParallaxDesc.AccessibleDescription);
		}

		private void LabelTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelTrigonomicParallaxData.AccessibleDescription);
		}

		private void LabelProperMotionAlphaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionAlphaDesc.AccessibleDescription);
		}

		private void LabelProperMotionAlphaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionAlphaData.AccessibleDescription);
		}

		private void LabelProperMotionDeltaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionDeltaDesc.AccessibleDescription);
		}

		private void LabelProperMotionDeltaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionDeltaData.AccessibleDescription);
		}

		private void LabelStandardErrorRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRightAscensionDesc.AccessibleDescription);
		}

		private void LabelStandardErrorRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRightAscensionData.AccessibleDescription);
		}

		private void LabelStandardErrorDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorDeclinationDesc.AccessibleDescription);
		}

		private void LabelStandardErrorDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorDeclinationData.AccessibleDescription);
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorTrigonomicParallaxDesc.AccessibleDescription);
		}

		private void LabelStandardErrorTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorTrigonomicParallaxData.AccessibleDescription);
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionRightAscensionDesc.AccessibleDescription);
		}

		private void LabelStandardErrorProperMotionRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionRightAscensionData.AccessibleDescription);
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionDeclinationDesc.AccessibleDescription);
		}

		private void LabelStandardErrorProperMotionDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionDeclinationData.AccessibleDescription);
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationDeclinationByRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationDeclinationByRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationDeclinationByRightAscensionData.AccessibleDescription);
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByRightAscensionData.AccessibleDescription);
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByDeclinationDesc.AccessibleDescription);
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByDeclinationData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByRightAscensionData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByDeclinationDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByDeclinationData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByRightAscensionData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByDeclinationDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByDeclinationData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.AccessibleDescription);
		}

		private void LabelPercentageOfRejectedDataDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPercentageOfRejectedDataDesc.AccessibleDescription);
		}

		private void LabelPercentageOfRejectedDataData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPercentageOfRejectedDataData.AccessibleDescription);
		}

		private void LabelGoodnessOfFitParameterDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelGoodnessOfFitParameterDesc.AccessibleDescription);
		}

		private void LabelGoodnessOfFitParameterData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelGoodnessOfFitParameterData.AccessibleDescription);
		}

		private void LabelMeanBtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanBtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelMeanBtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanBtMagnitudeData.AccessibleDescription);
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanBtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelStandardErrorMeanBtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanBtMagnitudeData.AccessibleDescription);
		}

		private void LabelMeanVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanVtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelMeanVtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanVtMagnitudeData.AccessibleDescription);
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanVtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelStandardErrorMeanVtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanVtMagnitudeData.AccessibleDescription);
		}

		private void LabelJohnsonBvColourDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelJohnsonBvColourDesc.AccessibleDescription);
		}

		private void LabelJohnsonBvColourData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelJohnsonBvColourData.AccessibleDescription);
		}

		private void LabelStandardErrorJohnsonBvColourDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorJohnsonBvColourDesc.AccessibleDescription);
		}

		private void LabelStandardErrorJohnsonBvColourData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorJohnsonBvColourData.AccessibleDescription);
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForBtAndVtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForBtAndVtMagnitudeData.AccessibleDescription);
		}

		private void LabelSourceOfBvColourDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfBvColourDesc.AccessibleDescription);
		}

		private void LabelSourceOfBvColourData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfBvColourData.AccessibleDescription);
		}

		private void LabelColourIndexInCousinsSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelColourIndexInCousinsSystemDesc.AccessibleDescription);
		}

		private void LabelColourIndexInCousinsSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelColourIndexInCousinsSystemData.AccessibleDescription);
		}

		private void LabelStandardErrorViDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorViDesc.AccessibleDescription);
		}

		private void LabelStandardErrorViData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorViData.AccessibleDescription);
		}

		private void LabelSourceOfViDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfViDesc.AccessibleDescription);
		}

		private void LabelSourceOfViData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfViData.AccessibleDescription);
		}

		private void LabelFlagForCombinedMagnitudesDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagForCombinedMagnitudesDesc.AccessibleDescription);
		}

		private void LabelFlagForCombinedMagnitudesData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagForCombinedMagnitudesData.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelScatterMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelScatterMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMaximumData.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMinimumData.AccessibleDescription);
		}

		private void LabelVariabilityPeriodDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityPeriodDesc.AccessibleDescription);
		}

		private void LabelVariabilityPeriodData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityPeriodData.AccessibleDescription);
		}

		private void LabelVariabilityTypeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityTypeDesc.AccessibleDescription);
		}

		private void LabelVariabilityTypeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityTypeData.AccessibleDescription);
		}

		private void LabelAdditionalDataAboutVariabilityDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAdditionalDataAboutVariabilityDesc.AccessibleDescription);
		}

		private void LabelAdditionalDataAboutVariabilityData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAdditionalDataAboutVariabilityData.AccessibleDescription);
		}

		private void LabelLightCurveAnnexDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelLightCurveAnnexDesc.AccessibleDescription);
		}

		private void LabelLightCurveAnnexData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelLightCurveAnnexData.AccessibleDescription);
		}

		private void LabelCcdmIdentifierDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCcdmIdentifierDesc.AccessibleDescription);
		}

		private void LabelCcdmIdentifierData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCcdmIdentifierData.AccessibleDescription);
		}

		private void LabelHistoricalStatusFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHistoricalStatusFlagDesc.AccessibleDescription);
		}

		private void LabelHistoricalStatusFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHistoricalStatusFlagData.AccessibleDescription);
		}

		private void LabelNumberEntriesWithSameCcdmDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberEntriesWithSameCcdmDesc.AccessibleDescription);
		}

		private void LabelNumberEntriesWithSameCcdmData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberEntriesWithSameCcdmData.AccessibleDescription);
		}

		private void LabelNumberComponentsInThisEntryDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberComponentsInThisEntryDesc.AccessibleDescription);
		}

		private void LabelNumberComponentsInThisEntryData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberComponentsInThisEntryData.AccessibleDescription);
		}

		private void LabelMultipleSystemsFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMultipleSystemsFlagDesc.AccessibleDescription);
		}

		private void LabelMultipleSystemsFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMultipleSystemsFlagData.AccessibleDescription);
		}

		private void LabelAstrometricSourceFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAstrometricSourceFlagDesc.AccessibleDescription);
		}

		private void LabelAstrometricSourceFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAstrometricSourceFlagData.AccessibleDescription);
		}

		private void LabelSolutionQualityDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSolutionQualityDesc.AccessibleDescription);
		}

		private void LabelSolutionQualityData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSolutionQualityData.AccessibleDescription);
		}

		private void LabelComponentIdentifiersDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelComponentIdentifiersDesc.AccessibleDescription);
		}

		private void LabelComponentIdentifiersData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelComponentIdentifiersData.AccessibleDescription);
		}

		private void LabelPositionAngleBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPositionAngleBetweenComponentsDesc.AccessibleDescription);
		}

		private void LabelPositionAngleBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPositionAngleBetweenComponentsData.AccessibleDescription);
		}

		private void LabelAngularSeparationBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAngularSeparationBetweenComponentsDesc.AccessibleDescription);
		}

		private void LabelAngularSeparationBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAngularSeparationBetweenComponentsData.AccessibleDescription);
		}

		private void LabelStandardErrorRhoDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRhoDesc.AccessibleDescription);
		}

		private void LabelStandardErrorRhoData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRhoData.AccessibleDescription);
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeDifferenceBetweenComponentsDesc.AccessibleDescription);
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeDifferenceBetweenComponentsData.AccessibleDescription);
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.AccessibleDescription);
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsData.AccessibleDescription);
		}

		private void LabelFlagIndicatingSurveyStarDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagIndicatingSurveyStarDesc.AccessibleDescription);
		}

		private void LabelFlagIndicatingSurveyStarData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagIndicatingSurveyStarData.AccessibleDescription);
		}

		private void LabelIdentificationChartDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentificationChartDesc.AccessibleDescription);
		}

		private void LabelIdentificationChartData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentificationChartData.AccessibleDescription);
		}

		private void LabelExistenceOfNotesDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelExistenceOfNotesDesc.AccessibleDescription);
		}

		private void LabelExistenceOfNotesData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelExistenceOfNotesData.AccessibleDescription);
		}

		private void LabelHdNumberDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHdNumberDesc.AccessibleDescription);
		}

		private void LabelHdNumberData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHdNumberData.AccessibleDescription);
		}

		private void LabelBonnerDmDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelBonnerDmDesc.AccessibleDescription);
		}

		private void LabelBonnerDmData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelBonnerDmData.AccessibleDescription);
		}

		private void LabelCordobaDmDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCordobaDmDesc.AccessibleDescription);
		}

		private void LabelCordobaDmData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCordobaDmData.AccessibleDescription);
		}

		private void LabelCapePhotographicDmDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCapePhotographicDmDesc.AccessibleDescription);
		}

		private void LabelCapePhotographicDmData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCapePhotographicDmData.AccessibleDescription);
		}

		private void LabelViUsedForReductionsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelViUsedForReductionsDesc.AccessibleDescription);
		}

		private void LabelViUsedForReductionsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelViUsedForReductionsData.AccessibleDescription);
		}

		private void LabelSpectralTypeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSpectralTypeDesc.AccessibleDescription);
		}

		private void LabelSpectralTypeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSpectralTypeData.AccessibleDescription);
		}

		private void LabelSourceOfSpectralTypeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfSpectralTypeDesc.AccessibleDescription);
		}

		private void LabelSourceOfSpectralTypeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfSpectralTypeData.AccessibleDescription);
		}

		#endregion

		#region MouseEnter event handlers

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

		private void LabelCatalogueDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCatalogueDesc.AccessibleDescription);
		}

		private void LabelCatalogueData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCatalogueData.AccessibleDescription);
		}

		private void LabelIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentifierDesc.AccessibleDescription);
		}

		private void LabelIdentifierData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentifierData.AccessibleDescription);
		}

		private void LabelProximityFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProximityFlagDesc.AccessibleDescription);
		}

		private void LabelProximityData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProximityData.AccessibleDescription);
		}

		private void LabelRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelRightAscensionDesc.AccessibleDescription);
		}

		private void LabelRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelRightAscensionData.AccessibleDescription);
		}

		private void LabelDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeclinationDesc.AccessibleDescription);
		}

		private void LabelDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeclinationData.AccessibleDescription);
		}

		private void LabelMagnitudeJohnsonDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeJohnsonDesc.AccessibleDescription);
		}

		private void LabelMagnitudeJohnsonData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeJohnsonData.AccessibleDescription);
		}

		private void LabelCoarseVariabilityFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCoarseVariabilityFlagDesc.AccessibleDescription);
		}

		private void LabelCoarseVariabilityFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCoarseVariabilityFlagData.AccessibleDescription);
		}

		private void LabelSourceOfMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfMagnitudeDesc.AccessibleDescription);
		}

		private void LabelSourceOfMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfMagnitudeData.AccessibleDescription);
		}

		private void LabelAlphaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAlphaDesc.AccessibleDescription);
		}

		private void LabelAlphaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAlphaData.AccessibleDescription);
		}

		private void LabelDeltaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeltaDesc.AccessibleDescription);
		}

		private void LabelDeltaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeltaData.AccessibleDescription);
		}

		private void LabelReferenceFlagForAstrometryDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForAstrometryDesc.AccessibleDescription);
		}

		private void LabelReferenceFlagForAstrometryData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForAstrometryData.AccessibleDescription);
		}

		private void LabelTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelTrigonomicParallaxDesc.AccessibleDescription);
		}

		private void LabelTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelTrigonomicParallaxData.AccessibleDescription);
		}

		private void LabelProperMotionAlphaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionAlphaDesc.AccessibleDescription);
		}

		private void LabelProperMotionAlphaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionAlphaData.AccessibleDescription);
		}

		private void LabelProperMotionDeltaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionDeltaDesc.AccessibleDescription);
		}

		private void LabelProperMotionDeltaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionDeltaData.AccessibleDescription);
		}

		private void LabelStandardErrorRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRightAscensionDesc.AccessibleDescription);
		}

		private void LabelStandardErrorRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRightAscensionData.AccessibleDescription);
		}

		private void LabelStandardErrorDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorDeclinationDesc.AccessibleDescription);
		}

		private void LabelStandardErrorDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorDeclinationData.AccessibleDescription);
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorTrigonomicParallaxDesc.AccessibleDescription);
		}

		private void LabelStandardErrorTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorTrigonomicParallaxData.AccessibleDescription);
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionRightAscensionDesc.AccessibleDescription);
		}

		private void LabelStandardErrorProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionRightAscensionData.AccessibleDescription);
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionDeclinationDesc.AccessibleDescription);
		}

		private void LabelStandardErrorProperMotionDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionDeclinationData.AccessibleDescription);
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationDeclinationByRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationDeclinationByRightAscensionData.AccessibleDescription);
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByRightAscensionData.AccessibleDescription);
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByDeclinationDesc.AccessibleDescription);
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByDeclinationData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByRightAscensionData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByDeclinationDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByDeclinationData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByRightAscensionData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByDeclinationDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByDeclinationData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.AccessibleDescription);
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.AccessibleDescription);
		}

		private void LabelPercentageOfRejectedDataDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPercentageOfRejectedDataDesc.AccessibleDescription);
		}

		private void LabelPercentageOfRejectedDataData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPercentageOfRejectedDataData.AccessibleDescription);
		}

		private void LabelGoodnessOfFitParameterDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelGoodnessOfFitParameterDesc.AccessibleDescription);
		}

		private void LabelGoodnessOfFitParameterData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelGoodnessOfFitParameterData.AccessibleDescription);
		}

		private void LabelMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanBtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanBtMagnitudeData.AccessibleDescription);
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanBtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelStandardErrorMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanBtMagnitudeData.AccessibleDescription);
		}

		private void LabelMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanVtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanVtMagnitudeData.AccessibleDescription);
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanVtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelStandardErrorMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanVtMagnitudeData.AccessibleDescription);
		}

		private void LabelJohnsonBvColourDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelJohnsonBvColourDesc.AccessibleDescription);
		}

		private void LabelJohnsonBvColourData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelJohnsonBvColourData.AccessibleDescription);
		}

		private void LabelStandardErrorJohnsonBvColourDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorJohnsonBvColourDesc.AccessibleDescription);
		}

		private void LabelStandardErrorJohnsonBvColourData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorJohnsonBvColourData.AccessibleDescription);
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForBtAndVtMagnitudeDesc.AccessibleDescription);
		}

		private void LabelSourceOfBvColourData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfBvColourData.AccessibleDescription);
		}

		private void LabelColourIndexInCousinsSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelColourIndexInCousinsSystemDesc.AccessibleDescription);
		}

		private void LabelColourIndexInCousinsSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelColourIndexInCousinsSystemData.AccessibleDescription);
		}

		private void LabelStandardErrorViDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorViDesc.AccessibleDescription);
		}

		private void LabelStandardErrorViData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorViData.AccessibleDescription);
		}

		private void LabelSourceOfViDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfViDesc.AccessibleDescription);
		}

		private void LabelSourceOfViData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfViData.AccessibleDescription);
		}

		private void LabelFlagForCombinedMagnitudesDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagForCombinedMagnitudesDesc.AccessibleDescription);
		}

		private void LabelFlagForCombinedMagnitudesData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagForCombinedMagnitudesData.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelScatterMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelScatterMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForBtAndVtMagnitudeData.AccessibleDescription);
		}

		private void LabelSourceOfBvColourDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfBvColourDesc.AccessibleDescription);
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMaximumData.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.AccessibleDescription);
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMinimumData.AccessibleDescription);
		}

		private void LabelVariabilityPeriodDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityPeriodDesc.AccessibleDescription);
		}

		private void LabelVariabilityPeriodData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityPeriodData.AccessibleDescription);
		}

		private void LabelVariabilityTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityTypeDesc.AccessibleDescription);
		}

		private void LabelVariabilityTypeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityTypeData.AccessibleDescription);
		}

		private void LabelAdditionalDataAboutVariabilityDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAdditionalDataAboutVariabilityDesc.AccessibleDescription);
		}

		private void LabelAdditionalDataAboutVariabilityData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAdditionalDataAboutVariabilityData.AccessibleDescription);
		}

		private void LabelLightCurveAnnexDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelLightCurveAnnexDesc.AccessibleDescription);
		}

		private void LabelLightCurveAnnexData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelLightCurveAnnexData.AccessibleDescription);
		}

		private void LabelCcdmIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCcdmIdentifierDesc.AccessibleDescription);
		}

		private void LabelCcdmIdentifierData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCcdmIdentifierData.AccessibleDescription);
		}

		private void LabelHistoricalStatusFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHistoricalStatusFlagDesc.AccessibleDescription);
		}

		private void LabelHistoricalStatusFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHistoricalStatusFlagData.AccessibleDescription);
		}

		private void LabelNumberEntriesWithSameCcdmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberEntriesWithSameCcdmDesc.AccessibleDescription);
		}

		private void LabelNumberEntriesWithSameCcdmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberEntriesWithSameCcdmData.AccessibleDescription);
		}

		private void LabelNumberComponentsInThisEntryDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberComponentsInThisEntryDesc.AccessibleDescription);
		}

		private void LabelNumberComponentsInThisEntryData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberComponentsInThisEntryData.AccessibleDescription);
		}

		private void LabelMultipleSystemsFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMultipleSystemsFlagDesc.AccessibleDescription);
		}

		private void LabelMultipleSystemsFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMultipleSystemsFlagData.AccessibleDescription);
		}

		private void LabelAstrometricSourceFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAstrometricSourceFlagDesc.AccessibleDescription);
		}

		private void LabelAstrometricSourceFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAstrometricSourceFlagData.AccessibleDescription);
		}

		private void LabelSolutionQualityDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSolutionQualityDesc.AccessibleDescription);
		}

		private void LabelSolutionQualityData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSolutionQualityData.AccessibleDescription);
		}

		private void LabelComponentIdentifiersDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelComponentIdentifiersDesc.AccessibleDescription);
		}

		private void LabelComponentIdentifiersData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelComponentIdentifiersData.AccessibleDescription);
		}

		private void LabelPositionAngleBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPositionAngleBetweenComponentsDesc.AccessibleDescription);
		}

		private void LabelPositionAngleBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPositionAngleBetweenComponentsData.AccessibleDescription);
		}

		private void LabelAngularSeparationBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAngularSeparationBetweenComponentsDesc.AccessibleDescription);
		}

		private void LabelAngularSeparationBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAngularSeparationBetweenComponentsData.AccessibleDescription);
		}

		private void LabelStandardErrorRhoDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRhoDesc.AccessibleDescription);
		}

		private void LabelStandardErrorRhoData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRhoData.AccessibleDescription);
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeDifferenceBetweenComponentsDesc.AccessibleDescription);
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeDifferenceBetweenComponentsData.AccessibleDescription);
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.AccessibleDescription);
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsData.AccessibleDescription);
		}

		private void LabelFlagIndicatingSurveyStarDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagIndicatingSurveyStarDesc.AccessibleDescription);
		}

		private void LabelFlagIndicatingSurveyStarData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagIndicatingSurveyStarData.AccessibleDescription);
		}

		private void LabelIdentificationChartDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentificationChartDesc.AccessibleDescription);
		}

		private void LabelIdentificationChartData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentificationChartData.AccessibleDescription);
		}

		private void LabelExistenceOfNotesDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelExistenceOfNotesDesc.AccessibleDescription);
		}

		private void LabelExistenceOfNotesData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelExistenceOfNotesData.AccessibleDescription);
		}

		private void LabelHdNumberDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHdNumberDesc.AccessibleDescription);
		}

		private void LabelHdNumberData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHdNumberData.AccessibleDescription);
		}

		private void LabelBonnerDmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelBonnerDmDesc.AccessibleDescription);
		}

		private void LabelBonnerDmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelBonnerDmData.AccessibleDescription);
		}

		private void LabelCordobaDmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCordobaDmDesc.AccessibleDescription);
		}

		private void LabelCordobaDmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCordobaDmData.AccessibleDescription);
		}

		private void LabelCapePhotographicDmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCapePhotographicDmDesc.AccessibleDescription);
		}

		private void LabelCapePhotographicDmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCapePhotographicDmData.AccessibleDescription);
		}

		private void LabelViUsedForReductionsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelViUsedForReductionsDesc.AccessibleDescription);
		}

		private void LabelViUsedForReductionsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelViUsedForReductionsData.AccessibleDescription);
		}

		private void LabelSpectralTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSpectralTypeDesc.AccessibleDescription);
		}

		private void LabelSpectralTypeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSpectralTypeData.AccessibleDescription);
		}

		private void LabelSourceOfSpectralTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfSpectralTypeDesc.AccessibleDescription);
		}

		private void LabelSourceOfSpectralTypeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfSpectralTypeData.AccessibleDescription);
		}

		#endregion

		#region Leave event handlers

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

		private void LabelSpectralTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSpectralTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfSpectralTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfSpectralTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion

		#region MouseLeave event handlers

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

		private void LabelSpectralTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSpectralTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfSpectralTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelSourceOfSpectralTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion
	}
}
