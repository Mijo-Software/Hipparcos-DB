using Hipparcos_DB.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class HipparcosCatalogViewerForm : Form
	{
		enum AstrophysicalElement
		{
			None = 0,
			CatalogData,
			IdentifierData,
			ProximityFlagData,
			RightAscensionData,
			DeclinationData,
			MagnitudeJohnsonData,
			CoarseVariabilityFlagData,
			SourceOfMagnitudeData,
			AlphaData,
			DeltaData,
			ReferenceFlagForAstrometryData,
			TrigonomicParallaxData,
			ProperMotionAlphaData,
			ProperMotionDeltaData,
			StandardErrorRightAscensionData,
			StandardErrorDeclinationData,
			StandardErrorTrigonomicParallaxData,
			StandardErrorProperMotionRightAscensionData,
			StandardErrorProperMotionDeclinationData,
			CorrelationDeclinationByRightAscensionData,
			CorrelationTrigonomicParallaxByRightAscensionData,
			CorrelationTrigonomicParallaxByDeclinationData,
			CorrelationProperMotionRightAscensionByRightAscensionData,
			CorrelationProperMotionRightAscensionByDeclinationData,
			CorrelationProperMotionRightAscensionByTrigonomicParallaxData,
			CorrelationProperMotionDeclinationByRightAscensionData,
			CorrelationProperMotionDeclinationByDeclinationData,
			CorrelationProperMotionDeclinationByTrigonomicParallaxData,
			CorrelationProperMotionDeclinationByProperMotionRightAscensionData,
			PercentageOfRejectedDataData,
			GoodnessOfFitParameterData,
			MeanBtMagnitudeData,
			StandardErrorMeanBtMagnitudeData,
			MeanVtMagnitudeData,
			StandardErrorMeanVtMagnitudeData,
			JohnsonBvColorData,
			StandardErrorJohnsonBvColorData,
			ReferenceFlagForBtAndVtMagnitudeData,
			SourceOfBvColorData,
			ColorIndexInCousinsSystemData,
			StandardErrorViData,
			SourceOfViData,
			FlagForCombinedMagnitudesData,
			MedianMagnitudeInHipparcosSystemData,
			StandardErrorMedianMagnitudeInHipparcosSystemData,
			ScatterMedianMagnitudeInHipparcosSystemData,
			NumberObservationsForMedianMagnitudeInHipparcosSystemData,
			ReferenceFlagForMedianMagnitudeInHipparcosSystemData,
			MedianMagnitudeInHipparcosSystemAtMaximumData,
			MedianMagnitudeInHipparcosSystemAtMinimumData,
			VariabilityPeriodData,
			VariabilityTypeData,
			AdditionalDataAboutVariabilityData,
			LightCurveAnnexData,
			CcdmIdentifierData,
			HistoricalStatusFlagData,
			NumberEntriesWithSameCcdmData,
			NumberComponentsInThisEntryData,
			MultipleSystemsFlagData,
			AstrometricSourceFlagData,
			SolutionQualityData,
			ComponentIdentifiersData,
			PositionAngleBetweenComponentsData,
			AngularSeparationBetweenComponentsData,
			StandardErrorRhoData,
			MagnitudeDifferenceBetweenComponentsData,
			StandardErrorMagnitudeDifferenceBetweenComponentsData,
			FlagIndicatingSurveyStarData,
			IdentificationChartData,
			ExistenceOfNotesData,
			HdNumberData,
			BonnerDmData,
			CordobaDmData,
			CapePhotographicDmData,
			ViUsedForReductionsData,
			SpectralTypeData,
			SourceOfSpectralTypeData,
			CatalogDesc,
			IdentifierDesc,
			ProximityFlagDesc,
			RightAscensionDesc,
			DeclinationDesc,
			MagnitudeJohnsonDesc,
			CoarseVariabilityFlagDesc,
			SourceOfMagnitudeDesc,
			AlphaDesc,
			DeltaDesc,
			ReferenceFlagForAstrometryDesc,
			TrigonomicParallaxDesc,
			ProperMotionAlphaDesc,
			ProperMotionDeltaDesc,
			StandardErrorRightAscensionDesc,
			StandardErrorDeclinationDesc,
			StandardErrorTrigonomicParallaxDesc,
			StandardErrorProperMotionRightAscensionDesc,
			StandardErrorProperMotionDeclinationDesc,
			CorrelationDeclinationByRightAscensionDesc,
			CorrelationTrigonomicParallaxByRightAscensionDesc,
			CorrelationTrigonomicParallaxByDeclinationDesc,
			CorrelationProperMotionRightAscensionByRightAscensionDesc,
			CorrelationProperMotionRightAscensionByDeclinationDesc,
			CorrelationProperMotionRightAscensionByTrigonomicParallaxDesc,
			CorrelationProperMotionDeclinationByRightAscensionDesc,
			CorrelationProperMotionDeclinationByDeclinationDesc,
			CorrelationProperMotionDeclinationByTrigonomicParallaxDesc,
			CorrelationProperMotionDeclinationByProperMotionRightAscensionDesc,
			PercentageOfRejectedDataDesc,
			GoodnessOfFitParameterDesc,
			MeanBtMagnitudeDesc,
			StandardErrorMeanBtMagnitudeDesc,
			MeanVtMagnitudeDesc,
			StandardErrorMeanVtMagnitudeDesc,
			JohnsonBvColorDesc,
			StandardErrorJohnsonBvColorDesc,
			ReferenceFlagForBtAndVtMagnitudeDesc,
			SourceOfBvColorDesc,
			ColorIndexInCousinsSystemDesc,
			StandardErrorViDesc,
			SourceOfViDesc,
			FlagForCombinedMagnitudesDesc,
			MedianMagnitudeInHipparcosSystemDesc,
			StandardErrorMedianMagnitudeInHipparcosSystemDesc,
			ScatterMedianMagnitudeInHipparcosSystemDesc,
			NumberObservationsForMedianMagnitudeInHipparcosSystemDesc,
			ReferenceFlagForMedianMagnitudeInHipparcosSystemDesc,
			MedianMagnitudeInHipparcosSystemAtMaximumDesc,
			MedianMagnitudeInHipparcosSystemAtMinimumDesc,
			VariabilityPeriodDesc,
			VariabilityTypeDesc,
			AdditionalDataAboutVariabilityDesc,
			LightCurveAnnexDesc,
			CcdmIdentifierDesc,
			HistoricalStatusFlagDesc,
			NumberEntriesWithSameCcdmDesc,
			NumberComponentsInThisEntryDesc,
			MultipleSystemsFlagDesc,
			AstrometricSourceFlagDesc,
			SolutionQualityDesc,
			ComponentIdentifiersDesc,
			PositionAngleBetweenComponentsDesc,
			AngularSeparationBetweenComponentsDesc,
			StandardErrorRhoDesc,
			MagnitudeDifferenceBetweenComponentsDesc,
			StandardErrorMagnitudeDifferenceBetweenComponentsDesc,
			FlagIndicatingSurveyStarDesc,
			IdentificationChartDesc,
			ExistenceOfNotesDesc,
			HdNumberDesc,
			BonnerDmDesc,
			CordobaDmDesc,
			CapePhotographicDmDesc,
			ViUsedForReductionsDesc,
			SpectralTypeDesc,
			SourceOfSpectralTypeDesc
		}

		private readonly Settings settings = new Settings();

		private readonly string[] filesHipparcosCatalog =
			{
				"h_dm_com.dat.gz",
				"h_dm_cor.dat.gz",
				"hd_notes.doc.gz",
				"hg_notes.doc.gz",
				"h_dm_cor.dat.gz",
				"hip_dm_g.dat.gz",
				"hip_dm_o.dat.gz",
				"hip_dm_v.dat.gz",
				"hip_dm_x.dat.gz",
				"hip_main.dat.gz",
				"hip_va_1.dat.gz",
				"hip_va_2.dat.gz",
				"hp_auth.doc.gz",
				"hp_notes.doc.gz",
				"hp_refs.doc.gz",
				"solar_ha.dat.gz",
				"solar_hp.dat.gz",
				"solar_t.dat.gz"
			};

		private string[] catalogEntries;

		private uint
			astrophysicalElement = 0,
			index = 0,
			maxIndex = 0;

		private string RemoveFileExtension(string filename)
		{
			return filename.Substring(startIndex: 0, length: filename.LastIndexOf(value: "."));
		}

		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(
				owner: this,
				text: "Copied to clipboard",
				caption: "The text was copied to the clipboard!",
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information);
		}

		private void CopyToClipboard(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				CopyToClipboard(text: ((TextBox)sender).Text);
			}
			else if (sender is Button)
			{
				CopyToClipboard(text: ((Button)sender).Text);
			}
			else if (sender is RadioButton)
			{
				CopyToClipboard(text: ((RadioButton)sender).Text);
			}
			else if (sender is CheckBox)
			{
				SetStatusbar(text: ((CheckBox)sender).Text);
			}
			else if (sender is DateTimePicker)
			{
				CopyToClipboard(text: ((DateTimePicker)sender).Text);
			}
			else if (sender is Label)
			{
				CopyToClipboard(text: ((Label)sender).Text);
			}
			else if (sender is ToolStripButton)
			{
				CopyToClipboard(text: ((ToolStripButton)sender).Text);
			}
			else if (sender is ToolStripMenuItem)
			{
				CopyToClipboard(text: ((ToolStripMenuItem)sender).Text);
			}
			else if (sender is ToolStripLabel)
			{
				CopyToClipboard(text: ((ToolStripLabel)sender).Text);
			}
			else if (sender is ToolStripComboBox)
			{
				CopyToClipboard(text: ((ToolStripComboBox)sender).Text);
			}
			else if (sender is ToolStripDropDown)
			{
				CopyToClipboard(text: ((ToolStripDropDown)sender).Text);
			}
			else if (sender is ToolStripDropDownButton)
			{
				CopyToClipboard(text: ((ToolStripDropDownButton)sender).Text);
			}
			else if (sender is ToolStripDropDownItem)
			{
				CopyToClipboard(text: ((ToolStripDropDownItem)sender).Text);
			}
			else if (sender is ToolStripDropDownMenu)
			{
				CopyToClipboard(text: ((ToolStripDropDownMenu)sender).Text);
			}
			else if (sender is ToolStripProgressBar)
			{
				CopyToClipboard(text: ((ToolStripProgressBar)sender).Text);
			}
			else if (sender is ToolStripSplitButton)
			{
				CopyToClipboard(text: ((ToolStripSplitButton)sender).Text);
			}
			else if (sender is ToolStripSeparator)
			{
				CopyToClipboard(text: ((ToolStripSeparator)sender).Text);
			}
			else if (sender is ToolStripStatusLabel)
			{
				CopyToClipboard(text: ((ToolStripStatusLabel)sender).Text);
			}
			else if (sender is ToolStripTextBox)
			{
				CopyToClipboard(text: ((ToolStripTextBox)sender).Text);
			}
		}

		private void SetStatusbar(string text)
		{
			toolStripStatusLabelInfo.Visible = true;
			toolStripStatusLabelInfo.Text = text;
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
			else if (sender is CheckBox)
			{
				SetStatusbar(text: ((CheckBox)sender).AccessibleDescription);
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
			if (int.TryParse(s: toolStripTextBoxGoToIndex.Text, result: out int tempIndex))
			{
				if (tempIndex < 1 || tempIndex > maxIndex)
				{
					MessageBox.Show(
						owner: this,
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
					owner: this,
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
			switch (settings.UserDataTableStyle)
			{
				case 0: tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble; break;
				case 1: tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble; break;
				default: tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble; break;
			}
			switch (settings.UserStartPosition)
			{
				case 0: StartPosition = FormStartPosition.CenterParent; break;
				case 1: StartPosition = FormStartPosition.CenterScreen; break;
				default: StartPosition = FormStartPosition.CenterParent; break;
			}
		}

		private void HipparcosCatalogViewerForm_Load(object sender, EventArgs e)
		{
			ClearStatusbar();
			string dataFile = settings.UserHipparcosCatalogDirectory + "hip_main.dat";
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
			else
			{
				MessageBox.Show(
					owner: this,
					text: "Some files are missing. Please download all files in the main window.",
					caption: "Missing files",
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error);
				Close();
			}
			SetDoubleBuffered(control: tableLayoutPanel);
		}

		#region Click event handlers

		private void MenuitemClose_Click(object sender, EventArgs e)
		{
			Array.Clear(array: catalogEntries, index: 0, length: catalogEntries.Length);
			GC.Collect();
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
			using (AboutBoxForm formAboutBox = new AboutBoxForm())
			{
				formAboutBox.ShowDialog();
			}
		}

		private void ToolStripMenuItemCopyData_Click(object sender, EventArgs e)
		{
			switch (astrophysicalElement)
			{
				case (uint)AstrophysicalElement.None: break;
				case (uint)AstrophysicalElement.CatalogData: CopyToClipboard(text: labelCatalogData.Text); break;
				case (uint)AstrophysicalElement.IdentifierData: CopyToClipboard(text: labelIdentifierData.Text); break;
				case (uint)AstrophysicalElement.ProximityFlagData: CopyToClipboard(text: labelProximityFlagData.Text); break;
				case (uint)AstrophysicalElement.RightAscensionData: CopyToClipboard(text: labelRightAscensionData.Text); break;
				case (uint)AstrophysicalElement.DeclinationData: CopyToClipboard(text: labelDeclinationData.Text); break;
				case (uint)AstrophysicalElement.MagnitudeJohnsonData: CopyToClipboard(text: labelMagnitudeJohnsonData.Text); break;
				case (uint)AstrophysicalElement.CoarseVariabilityFlagData: CopyToClipboard(text: labelCoarseVariabilityFlagData.Text); break;
				case (uint)AstrophysicalElement.SourceOfMagnitudeData: CopyToClipboard(text: labelSourceOfMagnitudeData.Text); break;
				case (uint)AstrophysicalElement.AlphaData: CopyToClipboard(text: labelAlphaData.Text); break;
				case (uint)AstrophysicalElement.DeltaData: CopyToClipboard(text: labelDeltaData.Text); break;
				case (uint)AstrophysicalElement.ReferenceFlagForAstrometryData: CopyToClipboard(text: labelReferenceFlagForAstrometryData.Text); break;
				case (uint)AstrophysicalElement.TrigonomicParallaxData: CopyToClipboard(text: labelTrigonomicParallaxData.Text); break;
				case (uint)AstrophysicalElement.ProperMotionAlphaData: CopyToClipboard(text: labelProperMotionAlphaData.Text); break;
				case (uint)AstrophysicalElement.ProperMotionDeltaData: CopyToClipboard(text: labelProperMotionDeltaData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorRightAscensionData: CopyToClipboard(text: labelStandardErrorRightAscensionData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorDeclinationData: CopyToClipboard(text: labelStandardErrorDeclinationData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorTrigonomicParallaxData: CopyToClipboard(text: labelStandardErrorTrigonomicParallaxData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorProperMotionRightAscensionData: CopyToClipboard(text: labelStandardErrorProperMotionRightAscensionData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorProperMotionDeclinationData: CopyToClipboard(text: labelStandardErrorProperMotionDeclinationData.Text); break;
				case (uint)AstrophysicalElement.CorrelationDeclinationByRightAscensionData: CopyToClipboard(text: labelCorrelationDeclinationByRightAscensionData.Text); break;
				case (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByRightAscensionData: CopyToClipboard(text: labelCorrelationTrigonomicParallaxByRightAscensionData.Text); break;
				case (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByDeclinationData: CopyToClipboard(text: labelCorrelationTrigonomicParallaxByDeclinationData.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByRightAscensionData: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByRightAscensionData.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByDeclinationData: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByDeclinationData.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxData: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByRightAscensionData.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByDeclinationData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByDeclinationData.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByTrigonomicParallaxData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByProperMotionRightAscensionData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.Text); break;
				case (uint)AstrophysicalElement.PercentageOfRejectedDataData: CopyToClipboard(text: labelPercentageOfRejectedDataData.Text); break;
				case (uint)AstrophysicalElement.GoodnessOfFitParameterData: CopyToClipboard(text: labelGoodnessOfFitParameterData.Text); break;
				case (uint)AstrophysicalElement.MeanBtMagnitudeData: CopyToClipboard(text: labelMeanBtMagnitudeData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorMeanBtMagnitudeData: CopyToClipboard(text: labelStandardErrorMeanBtMagnitudeData.Text); break;
				case (uint)AstrophysicalElement.MeanVtMagnitudeData: CopyToClipboard(text: labelMeanVtMagnitudeData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorMeanVtMagnitudeData: CopyToClipboard(text: labelStandardErrorMeanVtMagnitudeData.Text); break;
				case (uint)AstrophysicalElement.JohnsonBvColorData: CopyToClipboard(text: labelJohnsonBvColorData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorJohnsonBvColorData: CopyToClipboard(text: labelStandardErrorJohnsonBvColorData.Text); break;
				case (uint)AstrophysicalElement.ReferenceFlagForBtAndVtMagnitudeData: CopyToClipboard(text: labelReferenceFlagForBtAndVtMagnitudeData.Text); break;
				case (uint)AstrophysicalElement.SourceOfBvColorData: CopyToClipboard(text: labelSourceOfBvColorData.Text); break;
				case (uint)AstrophysicalElement.ColorIndexInCousinsSystemData: CopyToClipboard(text: labelColorIndexInCousinsSystemData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorViData: CopyToClipboard(text: labelStandardErrorViData.Text); break;
				case (uint)AstrophysicalElement.SourceOfViData: CopyToClipboard(text: labelSourceOfViData.Text); break;
				case (uint)AstrophysicalElement.FlagForCombinedMagnitudesData: CopyToClipboard(text: labelFlagForCombinedMagnitudesData.Text); break;
				case (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorMedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelStandardErrorMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstrophysicalElement.ScatterMedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelScatterMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstrophysicalElement.NumberObservationsForMedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstrophysicalElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMaximumData: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemAtMaximumData.Text); break;
				case (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMinimumData: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemAtMinimumData.Text); break;
				case (uint)AstrophysicalElement.VariabilityPeriodData: CopyToClipboard(text: labelVariabilityPeriodData.Text); break;
				case (uint)AstrophysicalElement.VariabilityTypeData: CopyToClipboard(text: labelVariabilityTypeData.Text); break;
				case (uint)AstrophysicalElement.AdditionalDataAboutVariabilityData: CopyToClipboard(text: labelAdditionalDataAboutVariabilityData.Text); break;
				case (uint)AstrophysicalElement.LightCurveAnnexData: CopyToClipboard(text: labelLightCurveAnnexData.Text); break;
				case (uint)AstrophysicalElement.CcdmIdentifierData: CopyToClipboard(text: labelCcdmIdentifierData.Text); break;
				case (uint)AstrophysicalElement.HistoricalStatusFlagData: CopyToClipboard(text: labelHistoricalStatusFlagData.Text); break;
				case (uint)AstrophysicalElement.NumberEntriesWithSameCcdmData: CopyToClipboard(text: labelNumberEntriesWithSameCcdmData.Text); break;
				case (uint)AstrophysicalElement.NumberComponentsInThisEntryData: CopyToClipboard(text: labelNumberComponentsInThisEntryData.Text); break;
				case (uint)AstrophysicalElement.MultipleSystemsFlagData: CopyToClipboard(text: labelMultipleSystemsFlagData.Text); break;
				case (uint)AstrophysicalElement.AstrometricSourceFlagData: CopyToClipboard(text: labelAstrometricSourceFlagData.Text); break;
				case (uint)AstrophysicalElement.SolutionQualityData: CopyToClipboard(text: labelSolutionQualityData.Text); break;
				case (uint)AstrophysicalElement.ComponentIdentifiersData: CopyToClipboard(text: labelComponentIdentifiersData.Text); break;
				case (uint)AstrophysicalElement.PositionAngleBetweenComponentsData: CopyToClipboard(text: labelPositionAngleBetweenComponentsData.Text); break;
				case (uint)AstrophysicalElement.AngularSeparationBetweenComponentsData: CopyToClipboard(text: labelAngularSeparationBetweenComponentsData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorRhoData: CopyToClipboard(text: labelStandardErrorRhoData.Text); break;
				case (uint)AstrophysicalElement.MagnitudeDifferenceBetweenComponentsData: CopyToClipboard(text: labelMagnitudeDifferenceBetweenComponentsData.Text); break;
				case (uint)AstrophysicalElement.StandardErrorMagnitudeDifferenceBetweenComponentsData: CopyToClipboard(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsData.Text); break;
				case (uint)AstrophysicalElement.FlagIndicatingSurveyStarData: CopyToClipboard(text: labelFlagIndicatingSurveyStarData.Text); break;
				case (uint)AstrophysicalElement.IdentificationChartData: CopyToClipboard(text: labelIdentificationChartData.Text); break;
				case (uint)AstrophysicalElement.ExistenceOfNotesData: CopyToClipboard(text: labelExistenceOfNotesData.Text); break;
				case (uint)AstrophysicalElement.HdNumberData: CopyToClipboard(text: labelHdNumberData.Text); break;
				case (uint)AstrophysicalElement.BonnerDmData: CopyToClipboard(text: labelBonnerDmData.Text); break;
				case (uint)AstrophysicalElement.CordobaDmData: CopyToClipboard(text: labelCordobaDmData.Text); break;
				case (uint)AstrophysicalElement.CapePhotographicDmData: CopyToClipboard(text: labelCapePhotographicDmData.Text); break;
				case (uint)AstrophysicalElement.ViUsedForReductionsData: CopyToClipboard(text: labelViUsedForReductionsData.Text); break;
				case (uint)AstrophysicalElement.SpectralTypeData: CopyToClipboard(text: labelSpectralTypeData.Text); break;
				case (uint)AstrophysicalElement.SourceOfSpectralTypeData: CopyToClipboard(text: labelSourceOfSpectralTypeData.Text); break;
				case (uint)AstrophysicalElement.CatalogDesc: CopyToClipboard(text: labelCatalogDesc.Text); break;
				case (uint)AstrophysicalElement.IdentifierDesc: CopyToClipboard(text: labelIdentifierDesc.Text); break; ;
				case (uint)AstrophysicalElement.ProximityFlagDesc: CopyToClipboard(text: labelProximityFlagDesc.Text); break;
				case (uint)AstrophysicalElement.RightAscensionDesc: CopyToClipboard(text: labelRightAscensionDesc.Text); break;
				case (uint)AstrophysicalElement.DeclinationDesc: CopyToClipboard(text: labelDeclinationDesc.Text); break;
				case (uint)AstrophysicalElement.MagnitudeJohnsonDesc: CopyToClipboard(text: labelMagnitudeJohnsonDesc.Text); break;
				case (uint)AstrophysicalElement.CoarseVariabilityFlagDesc: CopyToClipboard(text: labelCoarseVariabilityFlagDesc.Text); break;
				case (uint)AstrophysicalElement.SourceOfMagnitudeDesc: CopyToClipboard(text: labelSourceOfMagnitudeDesc.Text); break;
				case (uint)AstrophysicalElement.AlphaDesc: CopyToClipboard(text: labelAlphaDesc.Text); break;
				case (uint)AstrophysicalElement.DeltaDesc: CopyToClipboard(text: labelDeltaDesc.Text); break;
				case (uint)AstrophysicalElement.ReferenceFlagForAstrometryDesc: CopyToClipboard(text: labelReferenceFlagForAstrometryDesc.Text); break;
				case (uint)AstrophysicalElement.TrigonomicParallaxDesc: CopyToClipboard(text: labelTrigonomicParallaxDesc.Text); break;
				case (uint)AstrophysicalElement.ProperMotionAlphaDesc: CopyToClipboard(text: labelProperMotionAlphaDesc.Text); break;
				case (uint)AstrophysicalElement.ProperMotionDeltaDesc: CopyToClipboard(text: labelProperMotionDeltaDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorRightAscensionDesc: CopyToClipboard(text: labelStandardErrorRightAscensionDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorDeclinationDesc: CopyToClipboard(text: labelStandardErrorDeclinationDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorTrigonomicParallaxDesc: CopyToClipboard(text: labelStandardErrorTrigonomicParallaxDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorProperMotionRightAscensionDesc: CopyToClipboard(text: labelStandardErrorProperMotionRightAscensionDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorProperMotionDeclinationDesc: CopyToClipboard(text: labelStandardErrorProperMotionDeclinationDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationDeclinationByRightAscensionDesc: CopyToClipboard(text: labelCorrelationDeclinationByRightAscensionDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByRightAscensionDesc: CopyToClipboard(text: labelCorrelationTrigonomicParallaxByRightAscensionDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByDeclinationDesc: CopyToClipboard(text: labelCorrelationTrigonomicParallaxByDeclinationDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByRightAscensionDesc: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByRightAscensionDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByDeclinationDesc: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByDeclinationDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxDesc: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionDesc: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByRightAscensionDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByDeclinationDesc: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByDeclinationDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByTrigonomicParallaxDesc: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.Text); break;
				case (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByProperMotionRightAscensionDesc: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.Text); break;
				case (uint)AstrophysicalElement.PercentageOfRejectedDataDesc: CopyToClipboard(text: labelPercentageOfRejectedDataDesc.Text); break;
				case (uint)AstrophysicalElement.GoodnessOfFitParameterDesc: CopyToClipboard(text: labelGoodnessOfFitParameterDesc.Text); break;
				case (uint)AstrophysicalElement.MeanBtMagnitudeDesc: CopyToClipboard(text: labelMeanBtMagnitudeDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorMeanBtMagnitudeDesc: CopyToClipboard(text: labelStandardErrorMeanBtMagnitudeDesc.Text); break;
				case (uint)AstrophysicalElement.MeanVtMagnitudeDesc: CopyToClipboard(text: labelMeanVtMagnitudeDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorMeanVtMagnitudeDesc: CopyToClipboard(text: labelStandardErrorMeanVtMagnitudeDesc.Text); break;
				case (uint)AstrophysicalElement.JohnsonBvColorDesc: CopyToClipboard(text: labelJohnsonBvColorDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorJohnsonBvColorDesc: CopyToClipboard(text: labelStandardErrorJohnsonBvColorDesc.Text); break;
				case (uint)AstrophysicalElement.ReferenceFlagForBtAndVtMagnitudeDesc: CopyToClipboard(text: labelReferenceFlagForBtAndVtMagnitudeDesc.Text); break;
				case (uint)AstrophysicalElement.SourceOfBvColorDesc: CopyToClipboard(text: labelSourceOfBvColorDesc.Text); break;
				case (uint)AstrophysicalElement.ColorIndexInCousinsSystemDesc: CopyToClipboard(text: labelColorIndexInCousinsSystemDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorViDesc: CopyToClipboard(text: labelStandardErrorViDesc.Text); break;
				case (uint)AstrophysicalElement.SourceOfViDesc: CopyToClipboard(text: labelSourceOfViDesc.Text); break;
				case (uint)AstrophysicalElement.FlagForCombinedMagnitudesDesc: CopyToClipboard(text: labelFlagForCombinedMagnitudesDesc.Text); break;
				case (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorMedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstrophysicalElement.ScatterMedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelScatterMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstrophysicalElement.NumberObservationsForMedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstrophysicalElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMaximumDesc: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.Text); break;
				case (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMinimumDesc: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.Text); break;
				case (uint)AstrophysicalElement.VariabilityPeriodDesc: CopyToClipboard(text: labelVariabilityPeriodDesc.Text); break;
				case (uint)AstrophysicalElement.VariabilityTypeDesc: CopyToClipboard(text: labelVariabilityTypeDesc.Text); break;
				case (uint)AstrophysicalElement.AdditionalDataAboutVariabilityDesc: CopyToClipboard(text: labelAdditionalDataAboutVariabilityDesc.Text); break;
				case (uint)AstrophysicalElement.LightCurveAnnexDesc: CopyToClipboard(text: labelLightCurveAnnexDesc.Text); break;
				case (uint)AstrophysicalElement.CcdmIdentifierDesc: CopyToClipboard(text: labelCcdmIdentifierDesc.Text); break;
				case (uint)AstrophysicalElement.HistoricalStatusFlagDesc: CopyToClipboard(text: labelHistoricalStatusFlagDesc.Text); break;
				case (uint)AstrophysicalElement.NumberEntriesWithSameCcdmDesc: CopyToClipboard(text: labelNumberEntriesWithSameCcdmDesc.Text); break;
				case (uint)AstrophysicalElement.NumberComponentsInThisEntryDesc: CopyToClipboard(text: labelNumberComponentsInThisEntryDesc.Text); break;
				case (uint)AstrophysicalElement.MultipleSystemsFlagDesc: CopyToClipboard(text: labelMultipleSystemsFlagDesc.Text); break;
				case (uint)AstrophysicalElement.AstrometricSourceFlagDesc: CopyToClipboard(text: labelAstrometricSourceFlagDesc.Text); break;
				case (uint)AstrophysicalElement.SolutionQualityDesc: CopyToClipboard(text: labelSolutionQualityDesc.Text); break;
				case (uint)AstrophysicalElement.ComponentIdentifiersDesc: CopyToClipboard(text: labelComponentIdentifiersDesc.Text); break;
				case (uint)AstrophysicalElement.PositionAngleBetweenComponentsDesc: CopyToClipboard(text: labelPositionAngleBetweenComponentsDesc.Text); break;
				case (uint)AstrophysicalElement.AngularSeparationBetweenComponentsDesc: CopyToClipboard(text: labelAngularSeparationBetweenComponentsDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorRhoDesc: CopyToClipboard(text: labelStandardErrorRhoDesc.Text); break;
				case (uint)AstrophysicalElement.MagnitudeDifferenceBetweenComponentsDesc: CopyToClipboard(text: labelMagnitudeDifferenceBetweenComponentsDesc.Text); break;
				case (uint)AstrophysicalElement.StandardErrorMagnitudeDifferenceBetweenComponentsDesc: CopyToClipboard(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.Text); break;
				case (uint)AstrophysicalElement.FlagIndicatingSurveyStarDesc: CopyToClipboard(text: labelFlagIndicatingSurveyStarDesc.Text); break;
				case (uint)AstrophysicalElement.IdentificationChartDesc: CopyToClipboard(text: labelIdentificationChartDesc.Text); break;
				case (uint)AstrophysicalElement.ExistenceOfNotesDesc: CopyToClipboard(text: labelExistenceOfNotesDesc.Text); break;
				case (uint)AstrophysicalElement.HdNumberDesc: CopyToClipboard(text: labelHdNumberDesc.Text); break;
				case (uint)AstrophysicalElement.BonnerDmDesc: CopyToClipboard(text: labelBonnerDmDesc.Text); break;
				case (uint)AstrophysicalElement.CordobaDmDesc: CopyToClipboard(text: labelCordobaDmDesc.Text); break;
				case (uint)AstrophysicalElement.CapePhotographicDmDesc: CopyToClipboard(text: labelCapePhotographicDmDesc.Text); break;
				case (uint)AstrophysicalElement.ViUsedForReductionsDesc: CopyToClipboard(text: labelViUsedForReductionsDesc.Text); break;
				case (uint)AstrophysicalElement.SpectralTypeDesc: CopyToClipboard(text: labelSpectralTypeDesc.Text); break;
				case (uint)AstrophysicalElement.SourceOfSpectralTypeDesc: CopyToClipboard(text: labelSourceOfSpectralTypeDesc.Text); break;
				default: break;
			}
		}

		#endregion

		#region DoubleClick event handlers

		private void LabelCatalogData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelIdentifierData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelProximityFlagData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelDeclinationData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMagnitudeJohnsonData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCoarseVariabilityFlagData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSourceOfMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelAlphaData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelDeltaData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelTrigonomicParallaxData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelProperMotionAlphaData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelProperMotionDeltaData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorDeclinationData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorTrigonomicParallaxData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorProperMotionDeclinationData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelPercentageOfRejectedDataData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelGoodnessOfFitParameterData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMeanBtMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMeanVtMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelJohnsonBvColorData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorJohnsonBvColorData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSourceOfBvColorData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelColorIndexInCousinsSystemData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorViData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSourceOfViData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelFlagForCombinedMagnitudesData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelVariabilityPeriodData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelVariabilityTypeData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelAdditionalDataAboutVariabilityData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelLightCurveAnnexData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCcdmIdentifierData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelHistoricalStatusFlagData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelNumberEntriesWithSameCcdmData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelNumberComponentsInThisEntryData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMultipleSystemsFlagData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelAstrometricSourceFlagData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSolutionQualityData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelComponentIdentifiersData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelPositionAngleBetweenComponentsData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelAngularSeparationBetweenComponentsData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorRhoData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelFlagIndicatingSurveyStarData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelIdentificationChartData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelExistenceOfNotesData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelHdNumberData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelBonnerDmData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCordobaDmData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCapePhotographicDmData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelViUsedForReductionsData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSpectralTypeData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSourceOfSpectralTypeData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelReferenceFlagForAstrometryData_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCatalogDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelIdentifierDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelProximityFlagDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMagnitudeJohnsonDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCoarseVariabilityFlagDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSourceOfMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelAlphaDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelDeltaDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelReferenceFlagForAstrometryDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelTrigonomicParallaxDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelProperMotionAlphaDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelProperMotionDeltaDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelPercentageOfRejectedDataDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelGoodnessOfFitParameterDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMeanBtMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMeanVtMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelJohnsonBvColorDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorJohnsonBvColorDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSourceOfBvColorDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelColorIndexInCousinsSystemDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorViDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSourceOfViDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelFlagForCombinedMagnitudesDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelVariabilityPeriodDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelVariabilityTypeDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelAdditionalDataAboutVariabilityDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelLightCurveAnnexDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCcdmIdentifierDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelHistoricalStatusFlagDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelNumberEntriesWithSameCcdmDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelNumberComponentsInThisEntryDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMultipleSystemsFlagDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelAstrometricSourceFlagDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSolutionQualityDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelComponentIdentifiersDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelPositionAngleBetweenComponentsDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelAngularSeparationBetweenComponentsDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorRhoDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelFlagIndicatingSurveyStarDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelIdentificationChartDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelExistenceOfNotesDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelHdNumberDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelBonnerDmDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCordobaDmDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelCapePhotographicDmDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelViUsedForReductionsDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSpectralTypeDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		private void LabelSourceOfSpectralTypeDesc_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		#endregion

		#region Enter event handlers

		private void LabelCatalogDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CatalogDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCatalogData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CatalogData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelIdentifierDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.IdentifierDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelIdentifierDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelIdentifierData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.IdentifierData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelIdentifierData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelProximityFlagDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProximityFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProximityFlagDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelProximityFlagData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProximityFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProximityFlagData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.RightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelRightAscensionData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.RightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelRightAscensionData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelDeclinationDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.DeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelDeclinationDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelDeclinationData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.DeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelDeclinationData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMagnitudeJohnsonDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MagnitudeJohnsonDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeJohnsonDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMagnitudeJohnsonData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MagnitudeJohnsonData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeJohnsonData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCoarseVariabilityFlagDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CoarseVariabilityFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCoarseVariabilityFlagDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCoarseVariabilityFlagData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CoarseVariabilityFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCoarseVariabilityFlagData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSourceOfMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSourceOfMagnitudeData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfMagnitudeData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelAlphaDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AlphaDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAlphaDesc.BackColor = SystemColors.ControlLightLight;
			}			
		}

		private void LabelAlphaData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AlphaData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAlphaData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelDeltaDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.DeltaDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelDeltaData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.DeltaData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelDeltaData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelReferenceFlagForAstrometryDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForAstrometryDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForAstrometryDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelReferenceFlagForAstrometryData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForAstrometryData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForAstrometryData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.TrigonomicParallaxDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelTrigonomicParallaxDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.TrigonomicParallaxData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelTrigonomicParallaxData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelProperMotionAlphaDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProperMotionAlphaDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionAlphaDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelProperMotionAlphaData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProperMotionAlphaData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionAlphaData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelProperMotionDeltaDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProperMotionDeltaDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionDeltaDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelProperMotionDeltaData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProperMotionDeltaData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionDeltaData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorRightAscensionData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRightAscensionData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorDeclinationDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorDeclinationDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorDeclinationData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorDeclinationData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorTrigonomicParallaxDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorTrigonomicParallaxDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorTrigonomicParallaxData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorProperMotionRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorProperMotionRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorProperMotionDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionDeclinationDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorProperMotionDeclinationData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorProperMotionDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationDeclinationByRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByTrigonomicParallaxDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByTrigonomicParallaxData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelPercentageOfRejectedDataDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.PercentageOfRejectedDataDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelPercentageOfRejectedDataDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelPercentageOfRejectedDataData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.PercentageOfRejectedDataData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelPercentageOfRejectedDataData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelGoodnessOfFitParameterDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.GoodnessOfFitParameterDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelGoodnessOfFitParameterDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelGoodnessOfFitParameterData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.GoodnessOfFitParameterData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelGoodnessOfFitParameterData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMeanBtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MeanBtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMeanBtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMeanBtMagnitudeData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MeanBtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMeanBtMagnitudeData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanBtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanBtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanBtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMeanVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MeanVtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMeanVtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMeanVtMagnitudeData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MeanVtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMeanVtMagnitudeData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanVtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanVtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanVtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelJohnsonBvColorDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.JohnsonBvColorDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelJohnsonBvColorDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelJohnsonBvColorData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.JohnsonBvColorData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelJohnsonBvColorData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorJohnsonBvColorDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorJohnsonBvColorDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorJohnsonBvColorDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorJohnsonBvColorData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorJohnsonBvColorData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForBtAndVtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForBtAndVtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSourceOfBvColorDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfBvColorDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfBvColorDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSourceOfBvColorData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfBvColorData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfBvColorData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelColorIndexInCousinsSystemDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ColorIndexInCousinsSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelColorIndexInCousinsSystemDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelColorIndexInCousinsSystemData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ColorIndexInCousinsSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelColorIndexInCousinsSystemData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorViDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorViDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorViDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorViData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorViData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorViData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSourceOfViDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfViDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfViDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSourceOfViData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfViData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfViData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelFlagForCombinedMagnitudesDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.FlagForCombinedMagnitudesDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelFlagForCombinedMagnitudesDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelFlagForCombinedMagnitudesData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.FlagForCombinedMagnitudesData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelFlagForCombinedMagnitudesData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ScatterMedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ScatterMedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberObservationsForMedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberObservationsForMedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMaximumDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMaximumData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMinimumDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMinimumData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelVariabilityPeriodDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.VariabilityPeriodDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityPeriodDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelVariabilityPeriodData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.VariabilityPeriodData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityPeriodData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelVariabilityTypeDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.VariabilityTypeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityTypeDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelVariabilityTypeData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.VariabilityTypeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityTypeData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelAdditionalDataAboutVariabilityDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AdditionalDataAboutVariabilityDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAdditionalDataAboutVariabilityDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelAdditionalDataAboutVariabilityData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AdditionalDataAboutVariabilityData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelLightCurveAnnexDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.LightCurveAnnexDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelLightCurveAnnexDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelLightCurveAnnexData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.LightCurveAnnexData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelLightCurveAnnexData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCcdmIdentifierDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CcdmIdentifierDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCcdmIdentifierDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCcdmIdentifierData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CcdmIdentifierData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCcdmIdentifierData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelHistoricalStatusFlagDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.HistoricalStatusFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelHistoricalStatusFlagDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelHistoricalStatusFlagData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.HistoricalStatusFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelHistoricalStatusFlagData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelNumberEntriesWithSameCcdmDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberEntriesWithSameCcdmDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberEntriesWithSameCcdmDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelNumberEntriesWithSameCcdmData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberEntriesWithSameCcdmData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelNumberComponentsInThisEntryDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberComponentsInThisEntryDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberComponentsInThisEntryDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelNumberComponentsInThisEntryData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberComponentsInThisEntryData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberComponentsInThisEntryData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMultipleSystemsFlagDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MultipleSystemsFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMultipleSystemsFlagDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMultipleSystemsFlagData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MultipleSystemsFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMultipleSystemsFlagData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelAstrometricSourceFlagDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AstrometricSourceFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAstrometricSourceFlagDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelAstrometricSourceFlagData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AstrometricSourceFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAstrometricSourceFlagData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSolutionQualityDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SolutionQualityDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSolutionQualityDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSolutionQualityData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SolutionQualityData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSolutionQualityData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelComponentIdentifiersDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ComponentIdentifiersDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelComponentIdentifiersDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelComponentIdentifiersData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ComponentIdentifiersData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelComponentIdentifiersData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelPositionAngleBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.PositionAngleBetweenComponentsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelPositionAngleBetweenComponentsDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelPositionAngleBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.PositionAngleBetweenComponentsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelPositionAngleBetweenComponentsData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelAngularSeparationBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AngularSeparationBetweenComponentsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAngularSeparationBetweenComponentsDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelAngularSeparationBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AngularSeparationBetweenComponentsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorRhoDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorRhoDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRhoDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorRhoData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorRhoData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRhoData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MagnitudeDifferenceBetweenComponentsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MagnitudeDifferenceBetweenComponentsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMagnitudeDifferenceBetweenComponentsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMagnitudeDifferenceBetweenComponentsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelFlagIndicatingSurveyStarDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.FlagIndicatingSurveyStarDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelFlagIndicatingSurveyStarDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelFlagIndicatingSurveyStarData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.FlagIndicatingSurveyStarData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelFlagIndicatingSurveyStarData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelIdentificationChartDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.IdentificationChartDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelIdentificationChartDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelIdentificationChartData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.IdentificationChartData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelIdentificationChartData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelExistenceOfNotesDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ExistenceOfNotesDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelExistenceOfNotesDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelExistenceOfNotesData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ExistenceOfNotesData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelExistenceOfNotesData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelHdNumberDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.HdNumberDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelHdNumberDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelHdNumberData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.HdNumberData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelHdNumberData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelBonnerDmDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.BonnerDmDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelBonnerDmDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelBonnerDmData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.BonnerDmData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelBonnerDmData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCordobaDmDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CordobaDmDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCordobaDmDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCordobaDmData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CordobaDmData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCordobaDmData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCapePhotographicDmDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CapePhotographicDmDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCapePhotographicDmDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelCapePhotographicDmData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CapePhotographicDmData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCapePhotographicDmData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelViUsedForReductionsDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ViUsedForReductionsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelViUsedForReductionsDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelViUsedForReductionsData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ViUsedForReductionsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelViUsedForReductionsData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSpectralTypeDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SpectralTypeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSpectralTypeDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSpectralTypeData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SpectralTypeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSpectralTypeData.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSourceOfSpectralTypeDesc_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfSpectralTypeDesc;
			SetStatusbar(sender: sender, e: e); SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfSpectralTypeDesc.BackColor = SystemColors.ControlLightLight;
			}
		}

		private void LabelSourceOfSpectralTypeData_Enter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfSpectralTypeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfSpectralTypeData.BackColor = SystemColors.ControlLightLight;
			}
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

		private void ToolStripMenuItemInfo_MouseEnter(object sender, EventArgs e)
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
			astrophysicalElement = (uint)AstrophysicalElement.CatalogDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogDesc.BackColor = labelCatalogData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCatalogData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CatalogData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogDesc.BackColor = labelCatalogData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.IdentifierDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelIdentifierData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.IdentifierData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelProximityFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProximityFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelProximityFlagData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProximityFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.RightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.RightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.DeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.DeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMagnitudeJohnsonDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MagnitudeJohnsonDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMagnitudeJohnsonData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MagnitudeJohnsonData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCoarseVariabilityFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CoarseVariabilityFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCoarseVariabilityFlagData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CoarseVariabilityFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSourceOfMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSourceOfMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelAlphaDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AlphaDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelAlphaData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AlphaData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelDeltaDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.DeltaDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelDeltaData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.DeltaData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelReferenceFlagForAstrometryDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForAstrometryDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelReferenceFlagForAstrometryData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForAstrometryData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.TrigonomicParallaxDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.TrigonomicParallaxData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelProperMotionAlphaDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProperMotionAlphaDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelProperMotionAlphaData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProperMotionAlphaData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelProperMotionDeltaDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProperMotionDeltaDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelProperMotionDeltaData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ProperMotionDeltaData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorTrigonomicParallaxDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorTrigonomicParallaxData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorProperMotionRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorProperMotionRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorProperMotionDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorProperMotionDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorProperMotionDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationDeclinationByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationDeclinationByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationTrigonomicParallaxByDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByDeclinationDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByDeclinationData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByTrigonomicParallaxDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByTrigonomicParallaxData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CorrelationProperMotionDeclinationByRightAscensionData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelPercentageOfRejectedDataDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.PercentageOfRejectedDataDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelPercentageOfRejectedDataData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.PercentageOfRejectedDataData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelGoodnessOfFitParameterDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.GoodnessOfFitParameterDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelGoodnessOfFitParameterData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.GoodnessOfFitParameterData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MeanBtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MeanBtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanBtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanBtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanVtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanVtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanVtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMeanVtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.JohnsonBvColorDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelJohnsonBvColorDesc.BackColor = labelJohnsonBvColorData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelJohnsonBvColorData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.JohnsonBvColorData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelJohnsonBvColorDesc.BackColor = labelJohnsonBvColorData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorJohnsonBvColorDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorJohnsonBvColorDesc.BackColor = labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorJohnsonBvColorData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorJohnsonBvColorData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorJohnsonBvColorDesc.BackColor = labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForBtAndVtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSourceOfBvColorData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForBtAndVtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfBvColorDesc.BackColor = labelSourceOfBvColorData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelColorIndexInCousinsSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ColorIndexInCousinsSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelColorIndexInCousinsSystemDesc.BackColor = labelColorIndexInCousinsSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelColorIndexInCousinsSystemData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ColorIndexInCousinsSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelColorIndexInCousinsSystemDesc.BackColor = labelColorIndexInCousinsSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorViDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorViDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorViData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorViData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSourceOfViDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfViDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSourceOfViData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfSpectralTypeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelFlagForCombinedMagnitudesDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.FlagForCombinedMagnitudesDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelFlagForCombinedMagnitudesData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.FlagForCombinedMagnitudesData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ScatterMedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ScatterMedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberObservationsForMedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberObservationsForMedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForBtAndVtMagnitudeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSourceOfBvColorDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ReferenceFlagForBtAndVtMagnitudeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfBvColorDesc.BackColor = labelSourceOfBvColorData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMaximumDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMaximumData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMinimumDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MedianMagnitudeInHipparcosSystemAtMinimumData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelVariabilityPeriodDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.VariabilityTypeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelVariabilityPeriodData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.VariabilityPeriodData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelVariabilityTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.VariabilityTypeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelVariabilityTypeData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.VariabilityTypeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelAdditionalDataAboutVariabilityDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AdditionalDataAboutVariabilityDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelAdditionalDataAboutVariabilityData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AdditionalDataAboutVariabilityData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelLightCurveAnnexDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.LightCurveAnnexDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelLightCurveAnnexData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.LightCurveAnnexData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCcdmIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CcdmIdentifierDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCcdmIdentifierData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CcdmIdentifierData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelHistoricalStatusFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.HistoricalStatusFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelHistoricalStatusFlagData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.HistoricalStatusFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelNumberEntriesWithSameCcdmDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberEntriesWithSameCcdmDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelNumberEntriesWithSameCcdmData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberEntriesWithSameCcdmData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelNumberComponentsInThisEntryDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberComponentsInThisEntryDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelNumberComponentsInThisEntryData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.NumberComponentsInThisEntryData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMultipleSystemsFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MultipleSystemsFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMultipleSystemsFlagData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MultipleSystemsFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelAstrometricSourceFlagDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AstrometricSourceFlagDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelAstrometricSourceFlagData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AstrometricSourceFlagData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSolutionQualityDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SolutionQualityDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSolutionQualityData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SolutionQualityData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelComponentIdentifiersDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ComponentIdentifiersDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelComponentIdentifiersData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ComponentIdentifiersData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelPositionAngleBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.PositionAngleBetweenComponentsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelPositionAngleBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.PositionAngleBetweenComponentsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelAngularSeparationBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AngularSeparationBetweenComponentsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelAngularSeparationBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.AngularSeparationBetweenComponentsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorRhoDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorRhoDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorRhoData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorRhoData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MagnitudeDifferenceBetweenComponentsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.MagnitudeDifferenceBetweenComponentsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMagnitudeDifferenceBetweenComponentsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.StandardErrorMagnitudeDifferenceBetweenComponentsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelFlagIndicatingSurveyStarDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.FlagIndicatingSurveyStarDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelFlagIndicatingSurveyStarData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.FlagIndicatingSurveyStarData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelIdentificationChartDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.IdentificationChartDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelIdentificationChartData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.IdentificationChartData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelExistenceOfNotesDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ExistenceOfNotesDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelExistenceOfNotesData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ExistenceOfNotesData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelHdNumberDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.HdNumberDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelHdNumberData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.HdNumberData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelBonnerDmDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.BonnerDmDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelBonnerDmData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.BonnerDmData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCordobaDmDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CordobaDmDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCordobaDmData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CordobaDmData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCapePhotographicDmDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CapePhotographicDmDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelCapePhotographicDmData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.CapePhotographicDmData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelViUsedForReductionsDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ViUsedForReductionsDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelViUsedForReductionsData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.ViUsedForReductionsData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSpectralTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SpectralTypeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSpectralTypeData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SpectralTypeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSourceOfSpectralTypeDesc_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfSpectralTypeDesc;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.ControlLight;
			}
		}

		private void LabelSourceOfSpectralTypeData_MouseEnter(object sender, EventArgs e)
		{
			astrophysicalElement = (uint)AstrophysicalElement.SourceOfSpectralTypeData;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.ControlLight;
			}
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
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCatalogData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogData.BackColor = SystemColors.Control;
			}
		}

		private void LabelIdentifierDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelIdentifierDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelIdentifierData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelIdentifierData.BackColor = SystemColors.Control;
			}
		}

		private void LabelProximityFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProximityFlagDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelProximityFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProximityFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelRightAscensionDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelDeclinationDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMagnitudeJohnsonDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeJohnsonDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelMagnitudeJohnsonData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeJohnsonData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCoarseVariabilityFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCoarseVariabilityFlagDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCoarseVariabilityFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCoarseVariabilityFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfMagnitudeDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAlphaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAlphaDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelAlphaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAlphaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelDeltaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelDeltaDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelDeltaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelDeltaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForAstrometryDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForAstrometryDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForAstrometryData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForAstrometryData.BackColor = SystemColors.Control;
			}
		}

		private void LabelTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelTrigonomicParallaxDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelProperMotionAlphaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionAlphaDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelProperMotionAlphaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionAlphaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelProperMotionDeltaDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionDeltaDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelProperMotionDeltaData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionDeltaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRightAscensionDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorDeclinationDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionRightAscensionDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionDeclinationDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorProperMotionDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationDeclinationByRightAscensionDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelPercentageOfRejectedDataDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelPercentageOfRejectedDataDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelPercentageOfRejectedDataData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelPercentageOfRejectedDataData.BackColor = SystemColors.Control;
			}
		}

		private void LabelGoodnessOfFitParameterDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelGoodnessOfFitParameterDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelGoodnessOfFitParameterData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelGoodnessOfFitParameterData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMeanBtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMeanBtMagnitudeDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelMeanBtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMeanBtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanBtMagnitudeDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMeanVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMeanVtMagnitudeDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelMeanVtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMeanVtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanVtMagnitudeDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelJohnsonBvColorDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelJohnsonBvColorDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelJohnsonBvColorData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelJohnsonBvColorData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorJohnsonBvColorDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorJohnsonBvColorDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorJohnsonBvColorData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfBvColorDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfBvColorDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfBvColorData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfBvColorData.BackColor = SystemColors.Control;
			}
		}

		private void LabelColorIndexInCousinsSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelColorIndexInCousinsSystemDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelColorIndexInCousinsSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelColorIndexInCousinsSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorViDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorViDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorViData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorViData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfViDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfViDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfViData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfViData.BackColor = SystemColors.Control;
			}
		}

		private void LabelFlagForCombinedMagnitudesDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelFlagForCombinedMagnitudesDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelFlagForCombinedMagnitudesData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelFlagForCombinedMagnitudesData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.Control;
			}
		}

		private void LabelVariabilityPeriodDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityPeriodDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelVariabilityPeriodData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityPeriodData.BackColor = SystemColors.Control;
			}
		}

		private void LabelVariabilityTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityTypeDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelVariabilityTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityTypeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAdditionalDataAboutVariabilityDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAdditionalDataAboutVariabilityDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelAdditionalDataAboutVariabilityData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.Control;
			}
		}

		private void LabelLightCurveAnnexDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelLightCurveAnnexDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelLightCurveAnnexData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelLightCurveAnnexData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCcdmIdentifierDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCcdmIdentifierDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCcdmIdentifierData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCcdmIdentifierData.BackColor = SystemColors.Control;
			}
		}

		private void LabelHistoricalStatusFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelHistoricalStatusFlagDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelHistoricalStatusFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelHistoricalStatusFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberEntriesWithSameCcdmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberEntriesWithSameCcdmDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberEntriesWithSameCcdmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberComponentsInThisEntryDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberComponentsInThisEntryDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberComponentsInThisEntryData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberComponentsInThisEntryData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMultipleSystemsFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMultipleSystemsFlagDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelMultipleSystemsFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMultipleSystemsFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAstrometricSourceFlagDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAstrometricSourceFlagDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelAstrometricSourceFlagData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAstrometricSourceFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSolutionQualityDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSolutionQualityDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelSolutionQualityData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSolutionQualityData.BackColor = SystemColors.Control;
			}
		}

		private void LabelComponentIdentifiersDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelComponentIdentifiersDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelComponentIdentifiersData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelComponentIdentifiersData.BackColor = SystemColors.Control;
			}
		}

		private void LabelPositionAngleBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelPositionAngleBetweenComponentsDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelPositionAngleBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelPositionAngleBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAngularSeparationBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAngularSeparationBetweenComponentsDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelAngularSeparationBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorRhoDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRhoDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorRhoData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRhoData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelFlagIndicatingSurveyStarDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelFlagIndicatingSurveyStarDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelFlagIndicatingSurveyStarData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelFlagIndicatingSurveyStarData.BackColor = SystemColors.Control;
			}
		}

		private void LabelIdentificationChartDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelIdentificationChartDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelIdentificationChartData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelIdentificationChartData.BackColor = SystemColors.Control;
			}
		}

		private void LabelExistenceOfNotesDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelExistenceOfNotesDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelExistenceOfNotesData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelExistenceOfNotesData.BackColor = SystemColors.Control;
			}
		}

		private void LabelHdNumberDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelHdNumberDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelHdNumberData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelHdNumberData.BackColor = SystemColors.Control;
			}
		}

		private void LabelBonnerDmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelBonnerDmDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelBonnerDmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelBonnerDmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCordobaDmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCordobaDmDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCordobaDmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCordobaDmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCapePhotographicDmDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCapePhotographicDmDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelCapePhotographicDmData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCapePhotographicDmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelViUsedForReductionsDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelViUsedForReductionsDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelViUsedForReductionsData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelViUsedForReductionsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSpectralTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSpectralTypeDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelSpectralTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSpectralTypeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfSpectralTypeDesc_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfSpectralTypeDesc.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfSpectralTypeData_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfSpectralTypeData.BackColor = SystemColors.Control;
			}
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

		private void ToolStripMenuItemInfo_MouseLeave(object sender, EventArgs e)
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
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogDesc.BackColor = labelCatalogData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCatalogData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCatalogDesc.BackColor = labelCatalogData.BackColor = SystemColors.Control;
			}
		}

		private void LabelIdentifierDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.Control;
			}
		}

		private void LabelIdentifierData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelIdentifierDesc.BackColor = labelIdentifierData.BackColor = SystemColors.Control;
			}
		}

		private void LabelProximityFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelProximityFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProximityFlagDesc.BackColor = labelProximityFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelRightAscensionDesc.BackColor = labelRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelDeclinationDesc.BackColor = labelDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMagnitudeJohnsonDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMagnitudeJohnsonData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeJohnsonDesc.BackColor = labelMagnitudeJohnsonData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCoarseVariabilityFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCoarseVariabilityFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCoarseVariabilityFlagDesc.BackColor = labelCoarseVariabilityFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfMagnitudeDesc.BackColor = labelSourceOfMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAlphaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAlphaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAlphaDesc.BackColor = labelAlphaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelDeltaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelDeltaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelDeltaDesc.BackColor = labelDeltaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForAstrometryDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForAstrometryData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForAstrometryDesc.BackColor = labelReferenceFlagForAstrometryData.BackColor = SystemColors.Control;
			}
		}

		private void LabelTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelTrigonomicParallaxDesc.BackColor = labelTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelProperMotionAlphaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelProperMotionAlphaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionAlphaDesc.BackColor = labelProperMotionAlphaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelProperMotionDeltaDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelProperMotionDeltaData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelProperMotionDeltaDesc.BackColor = labelProperMotionDeltaData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRightAscensionDesc.BackColor = labelStandardErrorRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorDeclinationDesc.BackColor = labelStandardErrorDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorTrigonomicParallaxDesc.BackColor = labelStandardErrorTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionRightAscensionDesc.BackColor = labelStandardErrorProperMotionRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorProperMotionDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorProperMotionDeclinationDesc.BackColor = labelStandardErrorProperMotionDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationDeclinationByRightAscensionDesc.BackColor = labelCorrelationDeclinationByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByRightAscensionDesc.BackColor = labelCorrelationTrigonomicParallaxByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationTrigonomicParallaxByDeclinationDesc.BackColor = labelCorrelationTrigonomicParallaxByDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByRightAscensionDesc.BackColor = labelCorrelationProperMotionRightAscensionByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByDeclinationDesc.BackColor = labelCorrelationProperMotionRightAscensionByDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByDeclinationDesc.BackColor = labelCorrelationProperMotionDeclinationByDeclinationData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.BackColor = labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.BackColor = labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.BackColor = SystemColors.Control;
			}
		}

		private void LabelPercentageOfRejectedDataDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.Control;
			}
		}

		private void LabelPercentageOfRejectedDataData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelPercentageOfRejectedDataDesc.BackColor = labelPercentageOfRejectedDataData.BackColor = SystemColors.Control;
			}
		}

		private void LabelGoodnessOfFitParameterDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.Control;
			}
		}

		private void LabelGoodnessOfFitParameterData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelGoodnessOfFitParameterDesc.BackColor = labelGoodnessOfFitParameterData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMeanBtMagnitudeDesc.BackColor = labelMeanBtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanBtMagnitudeDesc.BackColor = labelStandardErrorMeanBtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMeanVtMagnitudeDesc.BackColor = labelMeanVtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMeanVtMagnitudeDesc.BackColor = labelStandardErrorMeanVtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelJohnsonBvColorDesc.BackColor = labelJohnsonBvColorData.BackColor = SystemColors.Control;
			}
		}

		private void LabelJohnsonBvColorData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelJohnsonBvColorDesc.BackColor = labelJohnsonBvColorData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorJohnsonBvColorDesc.BackColor = labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorJohnsonBvColorData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorJohnsonBvColorDesc.BackColor = labelStandardErrorJohnsonBvColorData.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForBtAndVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForBtAndVtMagnitudeDesc.BackColor = labelReferenceFlagForBtAndVtMagnitudeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfBvColorDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfBvColorDesc.BackColor = labelSourceOfBvColorData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfBvColorData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfBvColorDesc.BackColor = labelSourceOfBvColorData.BackColor = SystemColors.Control;
			}
		}

		private void LabelColorIndexInCousinsSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelColorIndexInCousinsSystemDesc.BackColor = labelColorIndexInCousinsSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelColorIndexInCousinsSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelColorIndexInCousinsSystemDesc.BackColor = labelColorIndexInCousinsSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorViDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorViData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorViDesc.BackColor = labelStandardErrorViData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfViDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfViData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfViDesc.BackColor = labelSourceOfViData.BackColor = SystemColors.Control;
			}
		}

		private void LabelFlagForCombinedMagnitudesDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.Control;
			}
		}

		private void LabelFlagForCombinedMagnitudesData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelFlagForCombinedMagnitudesDesc.BackColor = labelFlagForCombinedMagnitudesData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemDesc.BackColor = labelMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.BackColor = labelStandardErrorMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelScatterMedianMagnitudeInHipparcosSystemDesc.BackColor = labelScatterMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.BackColor = labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMaximumData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.BackColor = labelMedianMagnitudeInHipparcosSystemAtMinimumData.BackColor = SystemColors.Control;
			}
		}

		private void LabelVariabilityPeriodDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.Control;
			}
		}

		private void LabelVariabilityPeriodData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityPeriodDesc.BackColor = labelVariabilityPeriodData.BackColor = SystemColors.Control;
			}
		}

		private void LabelVariabilityTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelVariabilityTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelVariabilityTypeDesc.BackColor = labelVariabilityTypeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAdditionalDataAboutVariabilityDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAdditionalDataAboutVariabilityData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAdditionalDataAboutVariabilityDesc.BackColor = labelAdditionalDataAboutVariabilityData.BackColor = SystemColors.Control;
			}
		}

		private void LabelLightCurveAnnexDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.Control;
			}
		}

		private void LabelLightCurveAnnexData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelLightCurveAnnexDesc.BackColor = labelLightCurveAnnexData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCcdmIdentifierDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCcdmIdentifierData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCcdmIdentifierDesc.BackColor = labelCcdmIdentifierData.BackColor = SystemColors.Control;
			}
		}

		private void LabelHistoricalStatusFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelHistoricalStatusFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelHistoricalStatusFlagDesc.BackColor = labelHistoricalStatusFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberEntriesWithSameCcdmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberEntriesWithSameCcdmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberEntriesWithSameCcdmDesc.BackColor = labelNumberEntriesWithSameCcdmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberComponentsInThisEntryDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.Control;
			}
		}

		private void LabelNumberComponentsInThisEntryData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelNumberComponentsInThisEntryDesc.BackColor = labelNumberComponentsInThisEntryData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMultipleSystemsFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMultipleSystemsFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMultipleSystemsFlagDesc.BackColor = labelMultipleSystemsFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAstrometricSourceFlagDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAstrometricSourceFlagData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAstrometricSourceFlagDesc.BackColor = labelAstrometricSourceFlagData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSolutionQualityDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSolutionQualityData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSolutionQualityDesc.BackColor = labelSolutionQualityData.BackColor = SystemColors.Control;
			}
		}

		private void LabelComponentIdentifiersDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.Control;
			}
		}

		private void LabelComponentIdentifiersData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelComponentIdentifiersDesc.BackColor = labelComponentIdentifiersData.BackColor = SystemColors.Control;
			}
		}

		private void LabelPositionAngleBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelPositionAngleBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelPositionAngleBetweenComponentsDesc.BackColor = labelPositionAngleBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAngularSeparationBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelAngularSeparationBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelAngularSeparationBetweenComponentsDesc.BackColor = labelAngularSeparationBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorRhoDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorRhoData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorRhoDesc.BackColor = labelStandardErrorRhoData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.BackColor = labelStandardErrorMagnitudeDifferenceBetweenComponentsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelFlagIndicatingSurveyStarDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.Control;
			}
		}

		private void LabelFlagIndicatingSurveyStarData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelFlagIndicatingSurveyStarDesc.BackColor = labelFlagIndicatingSurveyStarData.BackColor = SystemColors.Control;
			}
		}

		private void LabelIdentificationChartDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.Control;
			}
		}

		private void LabelIdentificationChartData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelIdentificationChartDesc.BackColor = labelIdentificationChartData.BackColor = SystemColors.Control;
			}
		}

		private void LabelExistenceOfNotesDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.Control;
			}
		}

		private void LabelExistenceOfNotesData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelExistenceOfNotesDesc.BackColor = labelExistenceOfNotesData.BackColor = SystemColors.Control;
			}
		}

		private void LabelHdNumberDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.Control;
			}
		}

		private void LabelHdNumberData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelHdNumberDesc.BackColor = labelHdNumberData.BackColor = SystemColors.Control;
			}
		}

		private void LabelBonnerDmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelBonnerDmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelBonnerDmDesc.BackColor = labelBonnerDmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCordobaDmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCordobaDmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCordobaDmDesc.BackColor = labelCordobaDmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCapePhotographicDmDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelCapePhotographicDmData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelCapePhotographicDmDesc.BackColor = labelCapePhotographicDmData.BackColor = SystemColors.Control;
			}
		}

		private void LabelViUsedForReductionsDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelViUsedForReductionsData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelViUsedForReductionsDesc.BackColor = labelViUsedForReductionsData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSpectralTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSpectralTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSpectralTypeDesc.BackColor = labelSpectralTypeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfSpectralTypeDesc_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.Control;
			}
		}

		private void LabelSourceOfSpectralTypeData_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				labelSourceOfSpectralTypeDesc.BackColor = labelSourceOfSpectralTypeData.BackColor = SystemColors.Control;
			}
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