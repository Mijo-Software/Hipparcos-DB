using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class HipparcosCatalogViewerForm : Form
	{

		private string[] catalogEntries;

		private uint
			index = 0,
			maxIndex = 0;

		private void SetStatusbar(string text)
		{
			toolStripStatusLabel.Visible = true;
			toolStripStatusLabel.Text = text;
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
			toolStripStatusLabel.Text = string.Empty;
			toolStripStatusLabel.Visible = false;
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
			labelCatalogData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1);//.Trim();
			labelIdentifierData.Text = catalogEntries[index - 1].Substring(startIndex: 2, length: 12);//.Trim();
			labelProximityFlagData.Text = catalogEntries[index - 1].Substring(startIndex: 15, length: 1);//.Trim();
			labelRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 17, length: 11);//.Trim();
			labelDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 29, length: 11);//.Trim();
			labelMagnitudeJohnsonData.Text = catalogEntries[index - 1].Substring(startIndex: 41, length: 5);//.Trim();
			labelCoarseVariabilityFlagData.Text = catalogEntries[index - 1].Substring(startIndex: 47, length: 1);//.Trim();
			labelSourceOfMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 49, length: 1);//.Trim();
			labelAlphaData.Text = catalogEntries[index - 1].Substring(startIndex: 51, length: 12);//.Trim();
			labelDeltaData.Text = catalogEntries[index - 1].Substring(startIndex: 64, length: 12);//.Trim();
			labelReferenceFlagForAstrometryData.Text = catalogEntries[index - 1].Substring(startIndex: 77, length: 1);//.Trim();
			labelTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 79, length: 7);//.Trim();
			labelProperMotionAlphaData.Text = catalogEntries[index - 1].Substring(startIndex: 87, length: 8);//.Trim();
			labelProperMotionDeltaData.Text = catalogEntries[index - 1].Substring(startIndex: 96, length: 8);//.Trim();
			labelStandardErrorRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 105, length: 6);//.Trim();
			labelStandardErrorDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 119, length: 6);//.Trim();
			labelStandardErrorTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 126, length: 6);//.Trim();
			labelStandardErrorProperMotionRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 133, length: 6);//.Trim();
			labelStandardErrorProperMotionDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 140, length: 5);//.Trim();
			labelCorrelationDeclinationByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 146, length: 5);//.Trim();
			labelCorrelationTrigonomicParallaxByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 152, length: 5);//.Trim();
			labelCorrelationTrigonomicParallaxByDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 158, length: 5);//.Trim();
			labelCorrelationProperMotionRightAscensionByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 164, length: 5);//.Trim();
			labelCorrelationProperMotionRightAscensionByDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 170, length: 5);//.Trim();
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 176, length: 5);//.Trim();
			labelCorrelationProperMotionDeclinationByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 182, length: 5);//.Trim();
			labelCorrelationProperMotionDeclinationByDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 188, length: 5);//.Trim();
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 194, length: 5);//.Trim();
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 200, length: 3);//.Trim();
			labelPercentageOfRejectedDataData.Text = catalogEntries[index - 1].Substring(startIndex: 204, length: 5);//.Trim();
			labelGoodnessOfFitParameterData.Text = catalogEntries[index - 1].Substring(startIndex: 224, length: 5);//.Trim();
			labelMeanBtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 217, length: 6);//.Trim();
			labelStandardErrorMeanBtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 224, length: 5);//.Trim();
			labelMeanVtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 230, length: 6);//.Trim();
			labelStandardErrorMeanVtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 237, length: 5);//.Trim();
			labelJohnsonBvColorData.Text = catalogEntries[index - 1].Substring(startIndex: 243, length: 1);//.Trim();
			labelStandardErrorJohnsonBvColorData.Text = catalogEntries[index - 1].Substring(startIndex: 245, length: 6);//.Trim();
			labelReferenceFlagForBtAndVtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 252, length: 5);//.Trim();
			labelSourceOfBvColorData.Text = catalogEntries[index - 1].Substring(startIndex: 258, length: 1);//.Trim();
			labelColorIndexInCousinsSystemData.Text = catalogEntries[index - 1].Substring(startIndex: 260, length: 4);//.Trim();
			labelStandardErrorViData.Text = catalogEntries[index - 1].Substring(startIndex: 265, length: 4);//.Trim();
			labelSourceOfViData.Text = catalogEntries[index - 1].Substring(startIndex: 270, length: 1);//.Trim();
			labelFlagForCombinedMagnitudesData.Text = catalogEntries[index - 1].Substring(startIndex: 272, length: 1);//.Trim();
			labelMedianMagnitudeInHipparcosSystemData.Text = catalogEntries[index - 1].Substring(startIndex: 274, length: 7);//.Trim();
			labelStandardErrorMedianMagnitudeInHipparcosSystemData.Text = catalogEntries[index - 1].Substring(startIndex: 282, length: 6);//.Trim();
			labelScatterMedianMagnitudeInHipparcosSystemData.Text = catalogEntries[index - 1].Substring(startIndex: 289, length: 5);//.Trim();
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.Text = catalogEntries[index - 1].Substring(startIndex: 295, length: 3);//.Trim();
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.Text = catalogEntries[index - 1].Substring(startIndex: 299, length: 1);//.Trim();
			labelMedianMagnitudeInHipparcosSystemAtMaximumData.Text = catalogEntries[index - 1].Substring(startIndex: 301, length: 5);//.Trim();
			labelMedianMagnitudeInHipparcosSystemAtMinimumData.Text = catalogEntries[index - 1].Substring(startIndex: 307, length: 5);//.Trim();
			labelVariabilityPeriodData.Text = catalogEntries[index - 1].Substring(startIndex: 313, length: 7);//.Trim();
			labelVariabilityTypeData.Text = catalogEntries[index - 1].Substring(startIndex: 321, length: 1);//.Trim();
			labelAdditionalDataAboutVariabilityData.Text = catalogEntries[index - 1].Substring(startIndex: 323, length: 1);//.Trim();
			labelLightCurveAnnexData.Text = catalogEntries[index - 1].Substring(startIndex: 325, length: 1);//.Trim();
			labelCcdmIdentifierData.Text = catalogEntries[index - 1].Substring(startIndex: 327, length: 10);//.Trim();
			labelHistoricalStatusFlagData.Text = catalogEntries[index - 1].Substring(startIndex: 338, length: 1);//.Trim();
			labelNumberEntriesWithSameCcdmData.Text = catalogEntries[index - 1].Substring(startIndex: 340, length: 2);//.Trim();
			labelNumberComponentsInThisEntryData.Text = catalogEntries[index - 1].Substring(startIndex: 343, length: 2);//.Trim();
			labelMultipleSystemsFlagData.Text = catalogEntries[index - 1].Substring(startIndex: 346, length: 1);//.Trim();
			labelAstrometricSourceFlagData.Text = catalogEntries[index - 1].Substring(startIndex: 348, length: 1);//.Trim();
			labelSolutionQualityData.Text = catalogEntries[index - 1].Substring(startIndex: 350, length: 1);//.Trim();
			labelComponentIdentifiersData.Text = catalogEntries[index - 1].Substring(startIndex: 352, length: 2);//.Trim();
			labelPositionAngleBetweenComponentsData.Text = catalogEntries[index - 1].Substring(startIndex: 355, length: 3);//.Trim();
			labelAngularSeparationBetweenComponentsData.Text = catalogEntries[index - 1].Substring(startIndex: 359, length: 7);//.Trim();
			labelStandardErrorRhoData.Text = catalogEntries[index - 1].Substring(startIndex: 367, length: 5);//.Trim();
			labelMagnitudeDifferenceBetweenComponentsData.Text = catalogEntries[index - 1].Substring(startIndex: 373, length: 5);//.Trim();
			labelStandardErrorMagnitudeDifferenceBetweenComponentsData.Text = catalogEntries[index - 1].Substring(startIndex: 379, length: 4);//.Trim();
			labelFlagIndicatingSurveyStarData.Text = catalogEntries[index - 1].Substring(startIndex: 384, length: 1);//.Trim();
			labelIdentificationChartData.Text = catalogEntries[index - 1].Substring(startIndex: 386, length: 1);//.Trim();
			labelExistenceOfNotesData.Text = catalogEntries[index - 1].Substring(startIndex: 388, length: 1);//.Trim();
			labelHdNumberData.Text = catalogEntries[index - 1].Substring(startIndex: 390, length: 6);//.Trim();
			labelBonnerDmData.Text = catalogEntries[index - 1].Substring(startIndex: 397, length: 10).Trim();
			labelCordobaDmData.Text = catalogEntries[index - 1].Substring(startIndex: 408, length: 10);//.Trim();
			labelCapePhotographicDmData.Text = catalogEntries[index - 1].Substring(startIndex: 419, length: 10);//.Trim();
			labelViUsedForReductionsData.Text = catalogEntries[index - 1].Substring(startIndex: 430, length: 4);//.Trim();
			labelSpectralTypeData.Text = catalogEntries[index - 1].Substring(startIndex: 435, length: 12).Trim();
			labelSourceOfSpectralTypeData.Text = catalogEntries[index - 1].Substring(startIndex: 448, length: 1);//.Trim();
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

		public HipparcosCatalogViewerForm()
		{
			InitializeComponent();
		}

		private void HipparcosCatalogViewerForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			string dataFile = @"hip_main.dat";
			if (File.Exists(path: dataFile))
			{
				catalogEntries = File.ReadAllLines(path: dataFile);
				index = 1;
				maxIndex = Convert.ToUInt32(value: catalogEntries.Length);
				toolStripLabelMaxIndex.Text = "/" + maxIndex.ToString();
				progressBar.Visible = false;
				UpdateIndexLabel();
				ShowEntriesOnIndex();
			}
			SetDoubleBuffered(control: tableLayoutPanel);
		}

		#region Click event handlers

		private void MenuitemClose_Click(object sender, EventArgs e)
		{
			Dispose();
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

		private void ToolStripMenuItemInfo_Click(object sender, EventArgs e)
		{
			new AboutBoxForm().ShowDialog();
		}


		#endregion

		#region Enter event handlers

		private void LabelCatalogDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCatalogDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCatalogData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCatalogData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelIdentifierDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelIdentifierDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelIdentifierData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelIdentifierData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelProximityFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProximityFlagDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelProximityFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProximityFlagData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelRightAscensionData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelDeclinationDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelDeclinationData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMagnitudeJohnsonDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMagnitudeJohnsonDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMagnitudeJohnsonData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMagnitudeJohnsonData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCoarseVariabilityFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCoarseVariabilityFlagDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCoarseVariabilityFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCoarseVariabilityFlagData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSourceOfMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSourceOfMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfMagnitudeData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelAlphaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAlphaDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelAlphaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAlphaData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelDeltaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCatalogDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelDeltaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelDeltaData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelReferenceFlagForAstrometryDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForAstrometryDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelReferenceFlagForAstrometryData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForAstrometryData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelTrigonomicParallaxDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelTrigonomicParallaxData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelProperMotionAlphaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProperMotionAlphaDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelProperMotionAlphaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProperMotionAlphaData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelProperMotionDeltaDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProperMotionDeltaDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelProperMotionDeltaData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProperMotionDeltaData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorRightAscensionData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorDeclinationDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorDeclinationData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorTrigonomicParallaxDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorProperMotionRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorProperMotionRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorProperMotionDeclinationDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorProperMotionDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationDeclinationByRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationDeclinationByRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelPercentageOfRejectedDataDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelPercentageOfRejectedDataDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelPercentageOfRejectedDataData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelPercentageOfRejectedDataData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelGoodnessOfFitParameterDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelGoodnessOfFitParameterDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelGoodnessOfFitParameterData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelGoodnessOfFitParameterData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMeanBtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMeanBtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMeanBtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMeanBtMagnitudeData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMeanBtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorMeanBtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMeanVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMeanVtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMeanVtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMeanVtMagnitudeData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMeanVtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorMeanVtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelJohnsonBvColorDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelJohnsonBvColorDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelJohnsonBvColorData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelJohnsonBvColorData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorJohnsonBvColorDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorJohnsonBvColorDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorJohnsonBvColorData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSourceOfBvColorDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfBvColorDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSourceOfBvColorData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfBvColorData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelColorIndexInCousinsSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelColorIndexInCousinsSystemDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelColorIndexInCousinsSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelColorIndexInCousinsSystemData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorViDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorViDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorViData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorViData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSourceOfViDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfViDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSourceOfViData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfViData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelFlagForCombinedMagnitudesDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelFlagForCombinedMagnitudesDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelFlagForCombinedMagnitudesData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelFlagForCombinedMagnitudesData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelVariabilityPeriodDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelVariabilityPeriodDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelVariabilityPeriodData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelVariabilityPeriodData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelVariabilityTypeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelVariabilityTypeDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelVariabilityTypeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelVariabilityTypeData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelAdditionalDataAboutVariabilityDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAdditionalDataAboutVariabilityDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelAdditionalDataAboutVariabilityData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelLightCurveAnnexDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelLightCurveAnnexDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelLightCurveAnnexData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelLightCurveAnnexData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCcdmIdentifierDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCcdmIdentifierDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCcdmIdentifierData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCcdmIdentifierData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelHistoricalStatusFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelHistoricalStatusFlagDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelHistoricalStatusFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelHistoricalStatusFlagData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelNumberEntriesWithSameCcdmDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberEntriesWithSameCcdmDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelNumberEntriesWithSameCcdmData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelNumberComponentsInThisEntryDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberComponentsInThisEntryDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelNumberComponentsInThisEntryData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberComponentsInThisEntryData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMultipleSystemsFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMultipleSystemsFlagDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMultipleSystemsFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMultipleSystemsFlagData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelAstrometricSourceFlagDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAstrometricSourceFlagDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelAstrometricSourceFlagData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAstrometricSourceFlagData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSolutionQualityDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSolutionQualityDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSolutionQualityData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSolutionQualityData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelComponentIdentifiersDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelComponentIdentifiersDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelComponentIdentifiersData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelComponentIdentifiersData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelPositionAngleBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelPositionAngleBetweenComponentsDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelPositionAngleBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelPositionAngleBetweenComponentsData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelAngularSeparationBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAngularSeparationBetweenComponentsDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelAngularSeparationBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorRhoDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorRhoDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorRhoData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorRhoData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelFlagIndicatingSurveyStarDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelFlagIndicatingSurveyStarDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelFlagIndicatingSurveyStarData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelFlagIndicatingSurveyStarData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelIdentificationChartDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelIdentificationChartDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelIdentificationChartData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelIdentificationChartData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelExistenceOfNotesDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelExistenceOfNotesDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelExistenceOfNotesData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelExistenceOfNotesData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelHdNumberDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelHdNumberDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelHdNumberData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelHdNumberData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelBonnerDmDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelBonnerDmDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelBonnerDmData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelBonnerDmData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCordobaDmDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCordobaDmDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCordobaDmData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCordobaDmData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCapePhotographicDmDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCapePhotographicDmDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelCapePhotographicDmData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCapePhotographicDmData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelViUsedForReductionsDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelViUsedForReductionsDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelViUsedForReductionsData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelViUsedForReductionsData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSpectralTypeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSpectralTypeDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSpectralTypeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSpectralTypeData.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSourceOfSpectralTypeDesc_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e); SetStatusbar(sender: sender, e: e);
			labelSourceOfSpectralTypeDesc.BackColor = SystemColors.ControlLightLight;
		}

		private void LabelSourceOfSpectralTypeData_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfSpectralTypeData.BackColor = SystemColors.ControlLightLight;
		}

		private void ToolStripTextBoxGoToIndex_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region MouseEnter event handlers

		private void MenuitemClose_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonStepToBegin_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonStepFastBackward_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonStepBackward_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonStepForward_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonStepFastForward_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void ToolStripButtonStepToEnd_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void LabelCatalogDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCatalogDesc.BackColor = labelCatalogData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCatalogData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCatalogDesc.BackColor = labelCatalogData.BackColor = SystemColors.ControlLight;
		}

		private void LabelIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.ControlLight;
		}

		private void LabelIdentifierData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProximityFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProximityFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMagnitudeJohnsonDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMagnitudeJohnsonData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCoarseVariabilityFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCoarseVariabilityFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAlphaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAlphaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelDeltaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelDeltaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForAstrometryDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForAstrometryData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.ControlLight;
		}

		private void LabelTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProperMotionAlphaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProperMotionAlphaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProperMotionDeltaDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelProperMotionDeltaData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorProperMotionDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
		}

		private void LabelPercentageOfRejectedDataDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.ControlLight;
		}

		private void LabelPercentageOfRejectedDataData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.ControlLight;
		}

		private void LabelGoodnessOfFitParameterDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.ControlLight;
		}

		private void LabelGoodnessOfFitParameterData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelJohnsonBvColorDesc.BackColor = labelJohnsonBvColorData.BackColor = SystemColors.ControlLight;
		}

		private void LabelJohnsonBvColorData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelJohnsonBvColorDesc.BackColor = labelJohnsonBvColorData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorJohnsonBvColorDesc.BackColor = labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorJohnsonBvColorData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorJohnsonBvColorDesc.BackColor = labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfBvColorData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfBvColorDesc.BackColor = labelSourceOfBvColorData.BackColor = SystemColors.ControlLight;
		}

		private void LabelColorIndexInCousinsSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelColorIndexInCousinsSystemDesc.BackColor = labelColorIndexInCousinsSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelColorIndexInCousinsSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelColorIndexInCousinsSystemDesc.BackColor = labelColorIndexInCousinsSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorViDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorViData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfViDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfViData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.ControlLight;
		}

		private void LabelFlagForCombinedMagnitudesDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.ControlLight;
		}

		private void LabelFlagForCombinedMagnitudesData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfBvColorDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfBvColorDesc.BackColor = labelSourceOfBvColorData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.ControlLight;
		}

		private void LabelVariabilityPeriodDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.ControlLight;
		}

		private void LabelVariabilityPeriodData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.ControlLight;
		}

		private void LabelVariabilityTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelVariabilityTypeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAdditionalDataAboutVariabilityDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAdditionalDataAboutVariabilityData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.ControlLight;
		}

		private void LabelLightCurveAnnexDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.ControlLight;
		}

		private void LabelLightCurveAnnexData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCcdmIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCcdmIdentifierData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.ControlLight;
		}

		private void LabelHistoricalStatusFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelHistoricalStatusFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberEntriesWithSameCcdmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberEntriesWithSameCcdmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberComponentsInThisEntryDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.ControlLight;
		}

		private void LabelNumberComponentsInThisEntryData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMultipleSystemsFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMultipleSystemsFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAstrometricSourceFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAstrometricSourceFlagData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSolutionQualityDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSolutionQualityData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.ControlLight;
		}

		private void LabelComponentIdentifiersDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.ControlLight;
		}

		private void LabelComponentIdentifiersData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.ControlLight;
		}

		private void LabelPositionAngleBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelPositionAngleBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAngularSeparationBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelAngularSeparationBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorRhoDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorRhoData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelFlagIndicatingSurveyStarDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.ControlLight;
		}

		private void LabelFlagIndicatingSurveyStarData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.ControlLight;
		}

		private void LabelIdentificationChartDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.ControlLight;
		}

		private void LabelIdentificationChartData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.ControlLight;
		}

		private void LabelExistenceOfNotesDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.ControlLight;
		}

		private void LabelExistenceOfNotesData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.ControlLight;
		}

		private void LabelHdNumberDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.ControlLight;
		}

		private void LabelHdNumberData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.ControlLight;
		}

		private void LabelBonnerDmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelBonnerDmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCordobaDmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCordobaDmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCapePhotographicDmDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelCapePhotographicDmData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.ControlLight;
		}

		private void LabelViUsedForReductionsDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelViUsedForReductionsData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSpectralTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSpectralTypeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfSpectralTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.ControlLight;
		}

		private void LabelSourceOfSpectralTypeData_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
			labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.ControlLight;
		}

		private void ToolStripButtonGoToIndex_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region Leave event handlers

		private void LabelCatalogDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCatalogDesc.BackColor = SystemColors.Control;
		}

		private void LabelCatalogData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCatalogData.BackColor = SystemColors.Control;
		}

		private void LabelIdentifierDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelIdentifierDesc.BackColor = SystemColors.Control;
		}

		private void LabelIdentifierData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelIdentifierData.BackColor = SystemColors.Control;
		}

		private void LabelProximityFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProximityFlagDesc.BackColor = SystemColors.Control;
		}

		private void LabelProximityFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProximityFlagData.BackColor = SystemColors.Control;
		}

		private void LabelRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelRightAscensionDesc.BackColor = SystemColors.Control;
		}

		private void LabelRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelDeclinationDesc.BackColor = SystemColors.Control;
		}

		private void LabelDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelMagnitudeJohnsonDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMagnitudeJohnsonDesc.BackColor = SystemColors.Control;
		}

		private void LabelMagnitudeJohnsonData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMagnitudeJohnsonData.BackColor = SystemColors.Control;
		}

		private void LabelCoarseVariabilityFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCoarseVariabilityFlagDesc.BackColor = SystemColors.Control;
		}

		private void LabelCoarseVariabilityFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCoarseVariabilityFlagData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfMagnitudeDesc.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelAlphaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAlphaDesc.BackColor = SystemColors.Control;
		}

		private void LabelAlphaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAlphaData.BackColor = SystemColors.Control;
		}

		private void LabelDeltaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelDeltaDesc.BackColor = SystemColors.Control;
		}

		private void LabelDeltaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelDeltaData.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForAstrometryDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForAstrometryDesc.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForAstrometryData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForAstrometryData.BackColor = SystemColors.Control;
		}

		private void LabelTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelTrigonomicParallaxDesc.BackColor = SystemColors.Control;
		}

		private void LabelTrigonomicParallaxData_Click(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelProperMotionAlphaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProperMotionAlphaDesc.BackColor = SystemColors.Control;
		}

		private void LabelProperMotionAlphaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProperMotionAlphaData.BackColor = SystemColors.Control;
		}

		private void LabelProperMotionDeltaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProperMotionDeltaDesc.BackColor = SystemColors.Control;
		}

		private void LabelProperMotionDeltaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelProperMotionDeltaData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorRightAscensionDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorDeclinationDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCatalogDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorProperMotionRightAscensionDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorProperMotionRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorProperMotionDeclinationDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorProperMotionDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationDeclinationByRightAscensionDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationDeclinationByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = SystemColors.Control;
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.Control;
		}

		private void LabelPercentageOfRejectedDataDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelPercentageOfRejectedDataDesc.BackColor = SystemColors.Control;
		}

		private void LabelPercentageOfRejectedDataData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelPercentageOfRejectedDataData.BackColor = SystemColors.Control;
		}

		private void LabelGoodnessOfFitParameterDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelGoodnessOfFitParameterDesc.BackColor = SystemColors.Control;
		}

		private void LabelGoodnessOfFitParameterData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelGoodnessOfFitParameterData.BackColor = SystemColors.Control;
		}

		private void LabelMeanBtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMeanBtMagnitudeDesc.BackColor = SystemColors.Control;
		}

		private void LabelMeanBtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMeanBtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMeanBtMagnitudeDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMeanBtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelMeanVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMeanVtMagnitudeDesc.BackColor = SystemColors.Control;
		}

		private void LabelMeanVtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMeanVtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMeanVtMagnitudeDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMeanVtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelJohnsonBvColorDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelJohnsonBvColorDesc.BackColor = SystemColors.Control;
		}

		private void LabelJohnsonBvColorData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelJohnsonBvColorData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorJohnsonBvColorDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorJohnsonBvColorDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorJohnsonBvColorData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfBvColorDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfBvColorDesc.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfBvColorData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfBvColorData.BackColor = SystemColors.Control;
		}

		private void LabelColorIndexInCousinsSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelColorIndexInCousinsSystemDesc.BackColor = SystemColors.Control;
		}

		private void LabelColorIndexInCousinsSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelColorIndexInCousinsSystemData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorViDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorViDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorViData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorViData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfViDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfViDesc.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfViData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfViData.BackColor = SystemColors.Control;
		}

		private void LabelFlagForCombinedMagnitudesDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelFlagForCombinedMagnitudesDesc.BackColor = SystemColors.Control;
		}

		private void LabelFlagForCombinedMagnitudesData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelFlagForCombinedMagnitudesData.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = SystemColors.Control;
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.Control;
		}

		private void LabelVariabilityPeriodDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelVariabilityPeriodDesc.BackColor = SystemColors.Control;
		}

		private void LabelVariabilityPeriodData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelVariabilityPeriodData.BackColor = SystemColors.Control;
		}

		private void LabelVariabilityTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelVariabilityTypeDesc.BackColor = SystemColors.Control;
		}

		private void LabelVariabilityTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelVariabilityTypeData.BackColor = SystemColors.Control;
		}

		private void LabelAdditionalDataAboutVariabilityDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAdditionalDataAboutVariabilityDesc.BackColor = SystemColors.Control;
		}

		private void LabelAdditionalDataAboutVariabilityData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.Control;
		}

		private void LabelLightCurveAnnexDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelLightCurveAnnexDesc.BackColor = SystemColors.Control;
		}

		private void LabelLightCurveAnnexData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelLightCurveAnnexData.BackColor = SystemColors.Control;
		}

		private void LabelCcdmIdentifierDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCcdmIdentifierDesc.BackColor = SystemColors.Control;
		}

		private void LabelCcdmIdentifierData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCcdmIdentifierData.BackColor = SystemColors.Control;
		}

		private void LabelHistoricalStatusFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelHistoricalStatusFlagDesc.BackColor = SystemColors.Control;
		}

		private void LabelHistoricalStatusFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelHistoricalStatusFlagData.BackColor = SystemColors.Control;
		}

		private void LabelNumberEntriesWithSameCcdmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberEntriesWithSameCcdmDesc.BackColor = SystemColors.Control;
		}

		private void LabelNumberEntriesWithSameCcdmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.Control;
		}

		private void LabelNumberComponentsInThisEntryDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberComponentsInThisEntryDesc.BackColor = SystemColors.Control;
		}

		private void LabelNumberComponentsInThisEntryData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelNumberComponentsInThisEntryData.BackColor = SystemColors.Control;
		}

		private void LabelMultipleSystemsFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMultipleSystemsFlagDesc.BackColor = SystemColors.Control;
		}

		private void LabelMultipleSystemsFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMultipleSystemsFlagData.BackColor = SystemColors.Control;
		}

		private void LabelAstrometricSourceFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAstrometricSourceFlagDesc.BackColor = SystemColors.Control;
		}

		private void LabelAstrometricSourceFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAstrometricSourceFlagData.BackColor = SystemColors.Control;
		}

		private void LabelSolutionQualityDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSolutionQualityDesc.BackColor = SystemColors.Control;
		}

		private void LabelSolutionQualityData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSolutionQualityData.BackColor = SystemColors.Control;
		}

		private void LabelComponentIdentifiersDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelComponentIdentifiersDesc.BackColor = SystemColors.Control;
		}

		private void LabelComponentIdentifiersData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelComponentIdentifiersData.BackColor = SystemColors.Control;
		}

		private void LabelPositionAngleBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelPositionAngleBetweenComponentsDesc.BackColor = SystemColors.Control;
		}

		private void LabelPositionAngleBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelPositionAngleBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelAngularSeparationBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAngularSeparationBetweenComponentsDesc.BackColor = SystemColors.Control;
		}

		private void LabelAngularSeparationBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorRhoDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorRhoDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorRhoData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorRhoData.BackColor = SystemColors.Control;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = SystemColors.Control;
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
		}

		private void LabelFlagIndicatingSurveyStarDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelFlagIndicatingSurveyStarDesc.BackColor = SystemColors.Control;
		}

		private void LabelFlagIndicatingSurveyStarData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelFlagIndicatingSurveyStarData.BackColor = SystemColors.Control;
		}

		private void LabelIdentificationChartDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelIdentificationChartDesc.BackColor = SystemColors.Control;
		}

		private void LabelIdentificationChartData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelIdentificationChartData.BackColor = SystemColors.Control;
		}

		private void LabelExistenceOfNotesDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelExistenceOfNotesDesc.BackColor = SystemColors.Control;
		}

		private void LabelExistenceOfNotesData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelExistenceOfNotesData.BackColor = SystemColors.Control;
		}

		private void LabelHdNumberDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelHdNumberDesc.BackColor = SystemColors.Control;
		}

		private void LabelHdNumberData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelHdNumberData.BackColor = SystemColors.Control;
		}

		private void LabelBonnerDmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelBonnerDmDesc.BackColor = SystemColors.Control;
		}

		private void LabelBonnerDmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelBonnerDmData.BackColor = SystemColors.Control;
		}

		private void LabelCordobaDmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCordobaDmDesc.BackColor = SystemColors.Control;
		}

		private void LabelCordobaDmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCordobaDmData.BackColor = SystemColors.Control;
		}

		private void LabelCapePhotographicDmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCapePhotographicDmDesc.BackColor = SystemColors.Control;
		}

		private void LabelCapePhotographicDmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCapePhotographicDmData.BackColor = SystemColors.Control;
		}

		private void LabelViUsedForReductionsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelViUsedForReductionsDesc.BackColor = SystemColors.Control;
		}

		private void LabelViUsedForReductionsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelViUsedForReductionsData.BackColor = SystemColors.Control;
		}

		private void LabelSpectralTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSpectralTypeDesc.BackColor = SystemColors.Control;
		}

		private void LabelSpectralTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSpectralTypeData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfSpectralTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfSpectralTypeDesc.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfSpectralTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfSpectralTypeData.BackColor = SystemColors.Control;
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

		private void LabelCatalogDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCatalogDesc.BackColor = labelCatalogData.BackColor = SystemColors.Control;
		}

		private void LabelCatalogData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelCatalogDesc.BackColor = labelCatalogData.BackColor = SystemColors.Control;
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

		private void LabelProximityFlagData_MouseLeave(object sender, EventArgs e)
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

		private void LabelJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelJohnsonBvColorDesc.BackColor = labelJohnsonBvColorData.BackColor = SystemColors.Control;
		}

		private void LabelJohnsonBvColorData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelJohnsonBvColorDesc.BackColor = labelJohnsonBvColorData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorJohnsonBvColorDesc.BackColor = labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.Control;
		}

		private void LabelStandardErrorJohnsonBvColorData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelStandardErrorJohnsonBvColorDesc.BackColor = labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.Control;
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

		private void LabelSourceOfBvColorDesc_MouseLeave(object sender, EventArgs e)
		{
			labelSourceOfBvColorDesc.BackColor = labelSourceOfBvColorData.BackColor = SystemColors.Control;
		}

		private void LabelSourceOfBvColorData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelSourceOfBvColorDesc.BackColor = labelSourceOfBvColorData.BackColor = SystemColors.Control;
		}

		private void LabelColorIndexInCousinsSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelColorIndexInCousinsSystemDesc.BackColor = labelColorIndexInCousinsSystemData.BackColor = SystemColors.Control;
		}

		private void LabelColorIndexInCousinsSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			labelColorIndexInCousinsSystemDesc.BackColor = labelColorIndexInCousinsSystemData.BackColor = SystemColors.Control;
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

		private void HipparcosCatalogViewerForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Left:
					index--;
					CheckIndexMinimum();
					UpdateIndexLabel();
					ShowEntriesOnIndex();
					break;
				case Keys.Right:
					index++;
					CheckIndexMaximum();
					UpdateIndexLabel();
					ShowEntriesOnIndex();
					break;
				case Keys.PageUp:
					index -= 1000;
					CheckIndexMinimum();
					UpdateIndexLabel();
					ShowEntriesOnIndex();
					break;
				case Keys.PageDown:
					index += 1000;
					CheckIndexMinimum();
					UpdateIndexLabel();
					ShowEntriesOnIndex();
					break;
				case Keys.Home:
					index = 1;
					UpdateIndexLabel();
					ShowEntriesOnIndex();
					break;
				case Keys.End:
					index = maxIndex;
					UpdateIndexLabel();
					ShowEntriesOnIndex();
					break;
			}
		}

		#endregion
	}
}