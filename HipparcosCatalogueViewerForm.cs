using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class HipparcosCatalogueViewerForm : Form
	{
		private string[] catalogueEntries;

		private uint
			index = 0,
			maxIndex = 0;

		private void SetStatusbar(string text)
		{
			toolStripStatusLabel.Text = text;
		}

		private void ClearStatusbar()
		{
			toolStripStatusLabel.Text = string.Empty;
		}

		private void UpdateIndexLabel()
		{
			toolStripTextBoxGoToIndex.Text = index.ToString();
		}

		private void CheckIndexMinimum()
		{
			if (index < 1 || index > maxIndex)
			{
				index = 1;
			}
		}

		private void CheckIndexMaximum()
		{
			if (index > maxIndex)
			{
				index = maxIndex;
			}
		}

		private void ShowEntriesOnIndex()
		{
			labelCatalogueData.Text = catalogueEntries[index - 1].Substring(startIndex: 0, length: 1);//.Trim();
			labelIdentifierData.Text = catalogueEntries[index - 1].Substring(startIndex: 2, length: 12);//.Trim();
			labelProximityFlagData.Text = catalogueEntries[index - 1].Substring(startIndex: 15, length: 1);//.Trim();
			labelRightAscensionData.Text = catalogueEntries[index - 1].Substring(startIndex: 17, length: 11);//.Trim();
			labelDeclinationData.Text = catalogueEntries[index - 1].Substring(startIndex: 29, length: 11);//.Trim();
			labelMagnitudeJohnsonData.Text = catalogueEntries[index - 1].Substring(startIndex: 41, length: 5);//.Trim();
			labelCoarseVariabilityFlagData.Text = catalogueEntries[index - 1].Substring(startIndex: 47, length: 1);//.Trim();
			labelSourceOfMagnitudeData.Text = catalogueEntries[index - 1].Substring(startIndex: 49, length: 1);//.Trim();
			labelAlphaData.Text = catalogueEntries[index - 1].Substring(startIndex: 51, length: 12);//.Trim();
			labelDeltaData.Text = catalogueEntries[index - 1].Substring(startIndex: 64, length: 12);//.Trim();
			labelReferenceFlagForAstrometryData.Text = catalogueEntries[index - 1].Substring(startIndex: 77, length: 1);//.Trim();
			labelTrigonomicParallaxData.Text = catalogueEntries[index - 1].Substring(startIndex: 79, length: 7);//.Trim();
			labelProperMotionAlphaData.Text = catalogueEntries[index - 1].Substring(startIndex: 87, length: 8);//.Trim();
			labelProperMotionDeltaData.Text = catalogueEntries[index - 1].Substring(startIndex: 96, length: 8);//.Trim();
			labelStandardErrorRightAscensionData.Text = catalogueEntries[index - 1].Substring(startIndex: 105, length: 6);//.Trim();
			labelStandardErrorDeclinationData.Text = catalogueEntries[index - 1].Substring(startIndex: 119, length: 6);//.Trim();
			labelStandardErrorTrigonomicParallaxData.Text = catalogueEntries[index - 1].Substring(startIndex: 126, length: 6);//.Trim();
			labelStandardErrorProperMotionRightAscensionData.Text = catalogueEntries[index - 1].Substring(startIndex: 133, length: 6);//.Trim();
			labelStandardErrorProperMotionDeclinationData.Text = catalogueEntries[index - 1].Substring(startIndex: 140, length: 5);//.Trim();
			labelCorrelationDeclinationByRightAscensionData.Text = catalogueEntries[index - 1].Substring(startIndex: 146, length: 5);//.Trim();
			labelCorrelationTrigonomicParallaxByRightAscensionData.Text = catalogueEntries[index - 1].Substring(startIndex: 152, length: 5);//.Trim();
			labelCorrelationTrigonomicParallaxByDeclinationData.Text = catalogueEntries[index - 1].Substring(startIndex: 158, length: 5);//.Trim();
			labelCorrelationProperMotionRightAscensionByRightAscensionData.Text = catalogueEntries[index - 1].Substring(startIndex: 164, length: 5);//.Trim();
			labelCorrelationProperMotionRightAscensionByDeclinationData.Text = catalogueEntries[index - 1].Substring(startIndex: 170, length: 5);//.Trim();
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.Text = catalogueEntries[index - 1].Substring(startIndex: 176, length: 5);//.Trim();
			labelCorrelationProperMotionDeclinationByRightAscensionData.Text = catalogueEntries[index - 1].Substring(startIndex: 182, length: 5);//.Trim();
			labelCorrelationProperMotionDeclinationByDeclinationData.Text = catalogueEntries[index - 1].Substring(startIndex: 188, length: 5);//.Trim();
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.Text = catalogueEntries[index - 1].Substring(startIndex: 194, length: 5);//.Trim();
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.Text = catalogueEntries[index - 1].Substring(startIndex: 200, length: 3);//.Trim();
			labelPercentageOfRejectedDataData.Text = catalogueEntries[index - 1].Substring(startIndex: 204, length: 5);//.Trim();
			labelGoodnessOfFitParameterData.Text = catalogueEntries[index - 1].Substring(startIndex: 224, length: 5);//.Trim();
			labelMeanBtMagnitudeData.Text = catalogueEntries[index - 1].Substring(startIndex: 217, length: 6);//.Trim();
			labelStandardErrorMeanBtMagnitudeData.Text = catalogueEntries[index - 1].Substring(startIndex: 224, length: 5);//.Trim();
			labelMeanVtMagnitudeData.Text = catalogueEntries[index - 1].Substring(startIndex: 230, length: 6);//.Trim();
			labelStandardErrorMeanVtMagnitudeData.Text = catalogueEntries[index - 1].Substring(startIndex: 237, length: 5);//.Trim();
			labelJohnsonBvColourData.Text = catalogueEntries[index - 1].Substring(startIndex: 243, length: 1);//.Trim();
			labelStandardErrorJohnsonBvColourData.Text = catalogueEntries[index - 1].Substring(startIndex: 245, length: 6);//.Trim();
			labelReferenceFlagForBtAndVtMagnitudeData.Text = catalogueEntries[index - 1].Substring(startIndex: 252, length: 5);//.Trim();
			labelSourceOfBvColourData.Text = catalogueEntries[index - 1].Substring(startIndex: 258, length: 1);//.Trim();
			labelColourIndexInCousinsSystemData.Text = catalogueEntries[index - 1].Substring(startIndex: 260, length: 4);//.Trim();
			labelStandardErrorViData.Text = catalogueEntries[index - 1].Substring(startIndex: 265, length: 4);//.Trim();
			labelSourceOfViData.Text = catalogueEntries[index - 1].Substring(startIndex: 270, length: 1);//.Trim();
			labelFlagForCombinedMagnitudesData.Text = catalogueEntries[index - 1].Substring(startIndex: 272, length: 1);//.Trim();
			labelMedianMagnitudeInHipparcosSystemData.Text = catalogueEntries[index - 1].Substring(startIndex: 274, length: 7);//.Trim();
			labelStandardErrorMedianMagnitudeInHipparcosSystemData.Text = catalogueEntries[index - 1].Substring(startIndex: 282, length: 6);//.Trim();
			labelScatterMedianMagnitudeInHipparcosSystemData.Text = catalogueEntries[index - 1].Substring(startIndex: 289, length: 5);//.Trim();
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.Text = catalogueEntries[index - 1].Substring(startIndex: 295, length: 3);//.Trim();
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.Text = catalogueEntries[index - 1].Substring(startIndex: 299, length: 1);//.Trim();
			labelMedianMagnitudeInHipparcosSystemAtMaximumData.Text = catalogueEntries[index - 1].Substring(startIndex: 301, length: 5);//.Trim();
			labelMedianMagnitudeInHipparcosSystemAtMinimumData.Text = catalogueEntries[index - 1].Substring(startIndex: 307, length: 5);//.Trim();
			labelVariabilityPeriodData.Text = catalogueEntries[index - 1].Substring(startIndex: 313, length: 7);//.Trim();
			labelVariabilityTypeData.Text = catalogueEntries[index - 1].Substring(startIndex: 321, length: 1);//.Trim();
			labelAdditionalDataAboutVariabilityData.Text = catalogueEntries[index - 1].Substring(startIndex: 323, length: 1);//.Trim();
			labelLightCurveAnnexData.Text = catalogueEntries[index - 1].Substring(startIndex: 325, length: 1);//.Trim();
			labelCcdmIdentifierData.Text = catalogueEntries[index - 1].Substring(startIndex: 327, length: 10);//.Trim();
			labelHistoricalStatusFlagData.Text = catalogueEntries[index - 1].Substring(startIndex: 338, length: 1);//.Trim();
			labelNumberEntriesWithSameCcdmData.Text = catalogueEntries[index - 1].Substring(startIndex: 340, length: 2);//.Trim();
			labelNumberComponentsInThisEntryData.Text = catalogueEntries[index - 1].Substring(startIndex: 343, length: 2);//.Trim();
			labelMultipleSystemsFlagData.Text = catalogueEntries[index - 1].Substring(startIndex: 346, length: 1);//.Trim();
			labelAstrometricSourceFlagData.Text = catalogueEntries[index - 1].Substring(startIndex: 348, length: 1);//.Trim();
			labelSolutionQualityData.Text = catalogueEntries[index - 1].Substring(startIndex: 350, length: 1);//.Trim();
			labelComponentIdentifiersData.Text = catalogueEntries[index - 1].Substring(startIndex: 352, length: 2);//.Trim();
			labelPositionAngleBetweenComponentsData.Text = catalogueEntries[index - 1].Substring(startIndex: 355, length: 3);//.Trim();
			labelAngularSeparationBetweenComponentsData.Text = catalogueEntries[index - 1].Substring(startIndex: 359, length: 7);//.Trim();
			labelStandardErrorRhoData.Text = catalogueEntries[index - 1].Substring(startIndex: 367, length: 5);//.Trim();
			labelMagnitudeDifferenceBetweenComponentsData.Text = catalogueEntries[index - 1].Substring(startIndex: 373, length: 5);//.Trim();
			labelStandardErrorMagnitudeDifferenceBetweenComponentsData.Text = catalogueEntries[index - 1].Substring(startIndex: 379, length: 4);//.Trim();
			labelFlagIndicatingSurveyStarData.Text = catalogueEntries[index - 1].Substring(startIndex: 384, length: 1);//.Trim();
			labelIdentificationChartData.Text = catalogueEntries[index - 1].Substring(startIndex: 386, length: 1);//.Trim();
			labelExistenceOfNotesData.Text = catalogueEntries[index - 1].Substring(startIndex: 388, length: 1);//.Trim();
			labelHdNumberData.Text = catalogueEntries[index - 1].Substring(startIndex: 390, length: 6);//.Trim();
			labelBonnerDmData.Text = catalogueEntries[index - 1].Substring(startIndex: 397, length: 10).Trim();
			labelCordobaDmData.Text = catalogueEntries[index - 1].Substring(startIndex: 408, length: 10);//.Trim();
			labelCapePhotographicDmData.Text = catalogueEntries[index - 1].Substring(startIndex: 419, length: 10);//.Trim();
			labelViUsedForReductionsData.Text = catalogueEntries[index - 1].Substring(startIndex: 430, length: 4);//.Trim();
			labelSpectralTypeData.Text = catalogueEntries[index - 1].Substring(startIndex: 435, length: 12).Trim();
			labelSourceOfSpectralTypeData.Text = catalogueEntries[index - 1].Substring(startIndex: 448, length: 1);//.Trim();
		}

		private void GoToIndex()
		{
			if (int.TryParse(toolStripTextBoxGoToIndex.Text, out int tempIndex))
			{
				if ((tempIndex < 1) || (tempIndex > maxIndex))
				{
					MessageBox.Show(
						text: "The number is out of range. The number to be entered must be greater than zero and less than the maximum value.",
						caption: "Number out of range",
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Error);
				}
				else
				{
					index = Convert.ToUInt32(tempIndex);
					UpdateIndexLabel();
					ShowEntriesOnIndex();
				}
			}
			else
			{
				MessageBox.Show(
					text: "The input is not a natural number. Make sure the input is a natural number, for example: 1, 2, 3, ...",
					caption: "Wrong number format",
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error);
			}
		}

		private static void SetDoubleBuffered(Control control)
		{
			if (SystemInformation.TerminalServerSession)
			{
				return;
			}
			PropertyInfo aProp = typeof(Control).GetProperty(name: "DoubleBuffered", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance);
			aProp.SetValue(obj: control, value: true, index: null);
		}

		public HipparcosCatalogueViewerForm()
		{
			InitializeComponent();
		}

		private void HipparcosCatalogueViewerForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			string dataFile = @"hip_main.dat";
			if (File.Exists(path: dataFile))
			{
				catalogueEntries = File.ReadAllLines(path: dataFile);
				index = 1;
				maxIndex = Convert.ToUInt32(value: catalogueEntries.Length);
				toolStripLabelMaxIndex.Text = "/" + maxIndex.ToString();
				UpdateIndexLabel();
				ShowEntriesOnIndex();
				progressBar.Visible = false;
			}
			SetDoubleBuffered(control: tableLayoutPanel);
		}

		#region Click event handlers

		private void MenuitemClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ToolStripButtonStepToBegin_Click(object sender, EventArgs e)
		{
			index = 1;
			UpdateIndexLabel();
			ShowEntriesOnIndex();
		}

		private void ToolStripButtonStepFastBackward_Click(object sender, EventArgs e)
		{
			index -= 1000;
			CheckIndexMinimum();
			UpdateIndexLabel();
			ShowEntriesOnIndex();
		}

		private void ToolStripButtonStepBackward_Click(object sender, EventArgs e)
		{
			index--;
			CheckIndexMinimum();
			UpdateIndexLabel();
			ShowEntriesOnIndex();
		}

		private void ToolStripButtonStepForward_Click(object sender, EventArgs e)
		{
			index++;
			CheckIndexMaximum();
			UpdateIndexLabel();
			ShowEntriesOnIndex();
		}

		private void ToolStripButtonStepFastForward_Click(object sender, EventArgs e)
		{
			index += 1000;
			CheckIndexMaximum();
			UpdateIndexLabel();
			ShowEntriesOnIndex();
		}

		private void ToolStripButtonStepToEnd_Click(object sender, EventArgs e)
		{
			index = maxIndex;
			UpdateIndexLabel();
			ShowEntriesOnIndex();
		}

		private void ToolStripButtonGotoIndex_Click(object sender, EventArgs e)
		{
			GoToIndex();
		}

		#endregion

		#region Enter event handlers

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
			SetStatusbar(text: labelProximityFlagData.AccessibleDescription);
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

		private void ToolStripTextBoxGoToIndex_Enter(object sender, EventArgs e)
		{
			SetStatusbar(text: toolStripTextBoxGoToIndex.AccessibleDescription);
		}

		#endregion

		#region MouseEnter event handlers

		private void MenuitemClose_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: menuitemClose.AccessibleDescription);
		}

		private void ToolStripButtonStepToBegin_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepToBegin.AccessibleDescription);
		}

		private void ToolStripButtonStepFastBackward_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepFastBackward.AccessibleDescription);
		}

		private void ToolStripButtonStepBackward_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepBackward.AccessibleDescription);
		}

		private void ToolStripButtonStepForward_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepForward.AccessibleDescription);
		}

		private void ToolStripButtonStepFastForward_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepFastForward.AccessibleDescription);
		}

		private void ToolStripButtonStepToEnd_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: toolStripButtonStepToEnd.AccessibleDescription);
		}

		private void LabelCatalogueDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCatalogueDesc.AccessibleDescription);
			labelCatalogueDesc.BackColor = labelCatalogueData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCatalogueData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCatalogueData.AccessibleDescription);
			labelCatalogueDesc.BackColor = labelCatalogueData.BackColor = SystemColors.ControlLight;
		}

		private void LabelIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentifierDesc.AccessibleDescription);
			labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.ControlLight;
		}

		private void LabelIdentifierData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentifierData.AccessibleDescription);
			labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProximityFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProximityFlagDesc.AccessibleDescription);
			labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProximityData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProximityFlagData.AccessibleDescription);
			labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelRightAscensionDesc.AccessibleDescription);
			labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelRightAscensionData.AccessibleDescription);
			labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeclinationDesc.AccessibleDescription);
			labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeclinationData.AccessibleDescription);
			labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMagnitudeJohnsonDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeJohnsonDesc.AccessibleDescription);
			labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMagnitudeJohnsonData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeJohnsonData.AccessibleDescription);
			labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCoarseVariabilityFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCoarseVariabilityFlagDesc.AccessibleDescription);
			labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCoarseVariabilityFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCoarseVariabilityFlagData.AccessibleDescription);
			labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfMagnitudeDesc.AccessibleDescription);
			labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfMagnitudeData.AccessibleDescription);
			labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAlphaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAlphaDesc.AccessibleDescription);
			labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAlphaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAlphaData.AccessibleDescription);
			labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelDeltaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeltaDesc.AccessibleDescription);
			labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelDeltaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelDeltaData.AccessibleDescription);
			labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForAstrometryDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForAstrometryDesc.AccessibleDescription);
			labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForAstrometryData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForAstrometryData.AccessibleDescription);
			labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.ControlLight;
		}

		private void LabelTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelTrigonomicParallaxDesc.AccessibleDescription);
			labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelTrigonomicParallaxData.AccessibleDescription);
			labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProperMotionAlphaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionAlphaDesc.AccessibleDescription);
			labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProperMotionAlphaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionAlphaData.AccessibleDescription);
			labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProperMotionDeltaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionDeltaDesc.AccessibleDescription);
			labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProperMotionDeltaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelProperMotionDeltaData.AccessibleDescription);
			labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRightAscensionDesc.AccessibleDescription);
			labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRightAscensionData.AccessibleDescription);
			labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorDeclinationDesc.AccessibleDescription);
			labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorDeclinationData.AccessibleDescription);
			labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorTrigonomicParallaxDesc.AccessibleDescription);
			labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorTrigonomicParallaxData.AccessibleDescription);
			labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionRightAscensionDesc.AccessibleDescription);
			labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionRightAscensionData.AccessibleDescription);
			labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionDeclinationDesc.AccessibleDescription);
			labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorProperMotionDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorProperMotionDeclinationData.AccessibleDescription);
			labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationDeclinationByRightAscensionDesc.AccessibleDescription);
			labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationDeclinationByRightAscensionData.AccessibleDescription);
			labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByRightAscensionDesc.AccessibleDescription);
			labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByRightAscensionData.AccessibleDescription);
			labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByDeclinationDesc.AccessibleDescription);
			labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationTrigonomicParallaxByDeclinationData.AccessibleDescription);
			labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByRightAscensionDesc.AccessibleDescription);
			labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByRightAscensionData.AccessibleDescription);
			labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByDeclinationDesc.AccessibleDescription);
			labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByDeclinationData.AccessibleDescription);
			labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.AccessibleDescription);
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.AccessibleDescription);
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByRightAscensionDesc.AccessibleDescription);
			labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByRightAscensionData.AccessibleDescription);
			labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByDeclinationDesc.AccessibleDescription);
			labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByDeclinationData.AccessibleDescription);
			labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.AccessibleDescription);
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.AccessibleDescription);
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.AccessibleDescription);
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.AccessibleDescription);
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelPercentageOfRejectedDataDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPercentageOfRejectedDataDesc.AccessibleDescription);
			labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.ControlLight;
		}

		private void LabelPercentageOfRejectedDataData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPercentageOfRejectedDataData.AccessibleDescription);
			labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.ControlLight;
		}

		private void LabelGoodnessOfFitParameterDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelGoodnessOfFitParameterDesc.AccessibleDescription);
			labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.ControlLight;
		}

		private void LabelGoodnessOfFitParameterData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelGoodnessOfFitParameterData.AccessibleDescription);
			labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanBtMagnitudeDesc.AccessibleDescription);
			labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanBtMagnitudeData.AccessibleDescription);
			labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanBtMagnitudeDesc.AccessibleDescription);
			labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanBtMagnitudeData.AccessibleDescription);
			labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanVtMagnitudeDesc.AccessibleDescription);
			labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMeanVtMagnitudeData.AccessibleDescription);
			labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanVtMagnitudeDesc.AccessibleDescription);
			labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMeanVtMagnitudeData.AccessibleDescription);
			labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelJohnsonBvColourDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelJohnsonBvColourDesc.AccessibleDescription);
			labelJohnsonBvColourDesc.BackColor = labelJohnsonBvColourData.BackColor = SystemColors.ControlLight;
		}

		private void LabelJohnsonBvColourData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelJohnsonBvColourData.AccessibleDescription);
			labelJohnsonBvColourDesc.BackColor = labelJohnsonBvColourData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorJohnsonBvColourDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorJohnsonBvColourDesc.AccessibleDescription);
			labelStandardErrorJohnsonBvColourDesc.BackColor = labelStandardErrorJohnsonBvColourData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorJohnsonBvColourData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorJohnsonBvColourData.AccessibleDescription);
			labelStandardErrorJohnsonBvColourDesc.BackColor = labelStandardErrorJohnsonBvColourData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForBtAndVtMagnitudeDesc.AccessibleDescription);
			labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfBvColourData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfBvColourData.AccessibleDescription);
			labelSourceOfBvColourDesc.BackColor = labelSourceOfBvColourData.BackColor = SystemColors.ControlLight;
		}

		private void LabelColourIndexInCousinsSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelColourIndexInCousinsSystemDesc.AccessibleDescription);
			labelColourIndexInCousinsSystemDesc.BackColor = labelColourIndexInCousinsSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelColourIndexInCousinsSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelColourIndexInCousinsSystemData.AccessibleDescription);
			labelColourIndexInCousinsSystemDesc.BackColor = labelColourIndexInCousinsSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorViDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorViDesc.AccessibleDescription);
			labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorViData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorViData.AccessibleDescription);
			labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfViDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfViDesc.AccessibleDescription);
			labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfViData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfViData.AccessibleDescription);
			labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.ControlLight;
		}

		private void LabelFlagForCombinedMagnitudesDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagForCombinedMagnitudesDesc.AccessibleDescription);
			labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.ControlLight;
		}

		private void LabelFlagForCombinedMagnitudesData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagForCombinedMagnitudesData.AccessibleDescription);
			labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
			labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
			labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
			labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
			labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelScatterMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
			labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelScatterMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
			labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.AccessibleDescription);
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.AccessibleDescription);
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelReferenceFlagForBtAndVtMagnitudeData.AccessibleDescription);
			labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfBvColourDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfBvColourDesc.AccessibleDescription);
			labelSourceOfBvColourDesc.BackColor = labelSourceOfBvColourData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.AccessibleDescription);
			labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMaximumData.AccessibleDescription);
			labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.AccessibleDescription);
			labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMedianMagnitudeInHipparcosSystemAtMinimumData.AccessibleDescription);
			labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.ControlLight;
		}

		private void LabelVariabilityPeriodDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityPeriodDesc.AccessibleDescription);
			labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.ControlLight;
		}

		private void LabelVariabilityPeriodData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityPeriodData.AccessibleDescription);
			labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.ControlLight;
		}

		private void LabelVariabilityTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityTypeDesc.AccessibleDescription);
			labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelVariabilityTypeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelVariabilityTypeData.AccessibleDescription);
			labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAdditionalDataAboutVariabilityDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAdditionalDataAboutVariabilityDesc.AccessibleDescription);
			labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAdditionalDataAboutVariabilityData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAdditionalDataAboutVariabilityData.AccessibleDescription);
			labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.ControlLight;
		}

		private void LabelLightCurveAnnexDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelLightCurveAnnexDesc.AccessibleDescription);
			labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.ControlLight;
		}

		private void LabelLightCurveAnnexData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelLightCurveAnnexData.AccessibleDescription);
			labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCcdmIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCcdmIdentifierDesc.AccessibleDescription);
			labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCcdmIdentifierData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCcdmIdentifierData.AccessibleDescription);
			labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.ControlLight;
		}

		private void LabelHistoricalStatusFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHistoricalStatusFlagDesc.AccessibleDescription);
			labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelHistoricalStatusFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHistoricalStatusFlagData.AccessibleDescription);
			labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberEntriesWithSameCcdmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberEntriesWithSameCcdmDesc.AccessibleDescription);
			labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberEntriesWithSameCcdmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberEntriesWithSameCcdmData.AccessibleDescription);
			labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberComponentsInThisEntryDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberComponentsInThisEntryDesc.AccessibleDescription);
			labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberComponentsInThisEntryData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelNumberComponentsInThisEntryData.AccessibleDescription);
			labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMultipleSystemsFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMultipleSystemsFlagDesc.AccessibleDescription);
			labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMultipleSystemsFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMultipleSystemsFlagData.AccessibleDescription);
			labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAstrometricSourceFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAstrometricSourceFlagDesc.AccessibleDescription);
			labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAstrometricSourceFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAstrometricSourceFlagData.AccessibleDescription);
			labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSolutionQualityDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSolutionQualityDesc.AccessibleDescription);
			labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSolutionQualityData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSolutionQualityData.AccessibleDescription);
			labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.ControlLight;
		}

		private void LabelComponentIdentifiersDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelComponentIdentifiersDesc.AccessibleDescription);
			labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.ControlLight;
		}

		private void LabelComponentIdentifiersData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelComponentIdentifiersData.AccessibleDescription);
			labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.ControlLight;
		}

		private void LabelPositionAngleBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPositionAngleBetweenComponentsDesc.AccessibleDescription);
			labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelPositionAngleBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelPositionAngleBetweenComponentsData.AccessibleDescription);
			labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAngularSeparationBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAngularSeparationBetweenComponentsDesc.AccessibleDescription);
			labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAngularSeparationBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelAngularSeparationBetweenComponentsData.AccessibleDescription);
			labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorRhoDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRhoDesc.AccessibleDescription);
			labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorRhoData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorRhoData.AccessibleDescription);
			labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeDifferenceBetweenComponentsDesc.AccessibleDescription);
			labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelMagnitudeDifferenceBetweenComponentsData.AccessibleDescription);
			labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.AccessibleDescription);
			labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsData.AccessibleDescription);
			labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelFlagIndicatingSurveyStarDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagIndicatingSurveyStarDesc.AccessibleDescription);
			labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.ControlLight;
		}

		private void LabelFlagIndicatingSurveyStarData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelFlagIndicatingSurveyStarData.AccessibleDescription);
			labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.ControlLight;
		}

		private void LabelIdentificationChartDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentificationChartDesc.AccessibleDescription);
			labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.ControlLight;
		}

		private void LabelIdentificationChartData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelIdentificationChartData.AccessibleDescription);
			labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.ControlLight;
		}

		private void LabelExistenceOfNotesDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelExistenceOfNotesDesc.AccessibleDescription);
			labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.ControlLight;
		}

		private void LabelExistenceOfNotesData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelExistenceOfNotesData.AccessibleDescription);
			labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.ControlLight;
		}

		private void LabelHdNumberDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHdNumberDesc.AccessibleDescription);
			labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.ControlLight;
		}

		private void LabelHdNumberData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelHdNumberData.AccessibleDescription);
			labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.ControlLight;
		}

		private void LabelBonnerDmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelBonnerDmDesc.AccessibleDescription);
			labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelBonnerDmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelBonnerDmData.AccessibleDescription);
			labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCordobaDmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCordobaDmDesc.AccessibleDescription);
			labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCordobaDmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCordobaDmData.AccessibleDescription);
			labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCapePhotographicDmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCapePhotographicDmDesc.AccessibleDescription);
			labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCapePhotographicDmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelCapePhotographicDmData.AccessibleDescription);
			labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelViUsedForReductionsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelViUsedForReductionsDesc.AccessibleDescription);
			labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelViUsedForReductionsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelViUsedForReductionsData.AccessibleDescription);
			labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSpectralTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSpectralTypeDesc.AccessibleDescription);
			labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSpectralTypeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSpectralTypeData.AccessibleDescription);
			labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfSpectralTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfSpectralTypeDesc.AccessibleDescription);
			labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfSpectralTypeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: labelSourceOfSpectralTypeData.AccessibleDescription);
			labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.ControlLight;
		}

		private void ToolStripButtonGoToIndex_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(text: toolStripTextBoxGoToIndex.AccessibleDescription);
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

		private void ToolStripTextBoxGoToIndex_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion

		#region MouseLeave event handlers

		private void MenuitemClose_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepToBegin_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepFastBackward_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepBackward_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepForward_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepFastForward_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void ToolStripButtonStepToEnd_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void LabelCatalogueDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCatalogueDesc.BackColor = labelCatalogueData.BackColor = SystemColors.Control;
		}

		private void LabelCatalogueData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCatalogueDesc.BackColor = labelCatalogueData.BackColor = SystemColors.Control;
		}

		private void LabelIdentifierDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.Control;
		}

		private void LabelIdentifierData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.Control;
		}

		private void LabelProximityFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.Control;
		}

		private void LabelProximityData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.Control;
		}

		private void LabelRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelMagnitudeJohnsonDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.Control;
		}

		private void LabelMagnitudeJohnsonData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.Control;
		}

		private void LabelCoarseVariabilityFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.Control;
		}

		private void LabelCoarseVariabilityFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelAlphaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.Control;
		}

		private void LabelAlphaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.Control;
		}

		private void LabelDeltaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.Control;
		}

		private void LabelDeltaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForAstrometryDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForAstrometryData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.Control;
		}

		private void LabelTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelProperMotionAlphaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.Control;
		}

		private void LabelProperMotionAlphaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.Control;
		}

		private void LabelProperMotionDeltaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.Control;
		}

		private void LabelProperMotionDeltaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorProperMotionDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelPercentageOfRejectedDataDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.Control;
		}

		private void LabelPercentageOfRejectedDataData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.Control;
		}

		private void LabelGoodnessOfFitParameterDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.Control;
		}

		private void LabelGoodnessOfFitParameterData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.Control;
		}

		private void LabelMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelJohnsonBvColourDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelJohnsonBvColourDesc.BackColor = labelJohnsonBvColourData.BackColor = SystemColors.Control;
		}

		private void LabelJohnsonBvColourData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelJohnsonBvColourDesc.BackColor = labelJohnsonBvColourData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorJohnsonBvColourDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorJohnsonBvColourDesc.BackColor = labelStandardErrorJohnsonBvColourData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorJohnsonBvColourData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorJohnsonBvColourDesc.BackColor = labelStandardErrorJohnsonBvColourData.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfBvColourDesc_MouseLeave(object sender, EventArgs e)
		{
			labelSourceOfBvColourDesc.BackColor = labelSourceOfBvColourData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfBvColourData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfBvColourDesc.BackColor = labelSourceOfBvColourData.BackColor = SystemColors.Control;
		}

		private void LabelColourIndexInCousinsSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelColourIndexInCousinsSystemDesc.BackColor = labelColourIndexInCousinsSystemData.BackColor = SystemColors.Control;
		}

		private void LabelColourIndexInCousinsSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelColourIndexInCousinsSystemDesc.BackColor = labelColourIndexInCousinsSystemData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorViDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorViData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfViDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfViData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.Control;
		}

		private void LabelFlagForCombinedMagnitudesDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.Control;
		}

		private void LabelFlagForCombinedMagnitudesData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.Control;
		}

		private void LabelVariabilityPeriodDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.Control;
		}

		private void LabelVariabilityPeriodData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.Control;
		}

		private void LabelVariabilityTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.Control;
		}

		private void LabelVariabilityTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.Control;
		}

		private void LabelAdditionalDataAboutVariabilityDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.Control;
		}

		private void LabelAdditionalDataAboutVariabilityData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.Control;
		}

		private void LabelLightCurveAnnexDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.Control;
		}

		private void LabelLightCurveAnnexData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.Control;
		}

		private void LabelCcdmIdentifierDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.Control;
		}

		private void LabelCcdmIdentifierData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.Control;
		}

		private void LabelHistoricalStatusFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.Control;
		}

		private void LabelHistoricalStatusFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.Control;
		}

		private void LabelNumberEntriesWithSameCcdmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.Control;
		}

		private void LabelNumberEntriesWithSameCcdmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.Control;
		}

		private void LabelNumberComponentsInThisEntryDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.Control;
		}

		private void LabelNumberComponentsInThisEntryData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.Control;
		}

		private void LabelMultipleSystemsFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.Control;
		}

		private void LabelMultipleSystemsFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.Control;
		}

		private void LabelAstrometricSourceFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.Control;
		}

		private void LabelAstrometricSourceFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.Control;
		}

		private void LabelSolutionQualityDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.Control;
		}

		private void LabelSolutionQualityData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.Control;
		}

		private void LabelComponentIdentifiersDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.Control;
		}

		private void LabelComponentIdentifiersData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.Control;
		}

		private void LabelPositionAngleBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelPositionAngleBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelAngularSeparationBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelAngularSeparationBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorRhoDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorRhoData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.Control;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelFlagIndicatingSurveyStarDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.Control;
		}

		private void LabelFlagIndicatingSurveyStarData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.Control;
		}

		private void LabelIdentificationChartDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.Control;
		}

		private void LabelIdentificationChartData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.Control;
		}

		private void LabelExistenceOfNotesDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.Control;
		}

		private void LabelExistenceOfNotesData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.Control;
		}

		private void LabelHdNumberDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.Control;
		}

		private void LabelHdNumberData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.Control;
		}

		private void LabelBonnerDmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.Control;
		}

		private void LabelBonnerDmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.Control;
		}

		private void LabelCordobaDmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.Control;
		}

		private void LabelCordobaDmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.Control;
		}

		private void LabelCapePhotographicDmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.Control;
		}

		private void LabelCapePhotographicDmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.Control;
		}

		private void LabelViUsedForReductionsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.Control;
		}

		private void LabelViUsedForReductionsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.Control;
		}

		private void LabelSpectralTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.Control;
		}

		private void LabelSpectralTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfSpectralTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfSpectralTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.Control;
		}

		private void ToolStripButtonGoToIndex_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion

		#region KeyPress event handlers

		private void ToolStripTextBoxGotoIndex_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Return)
			{
				GoToIndex();
				e.Handled = true;
			}
		}

		#endregion
	}
}