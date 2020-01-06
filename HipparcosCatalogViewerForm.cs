using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Hipparcos_DB.Properties;

namespace Hipparcos_DB
{
	/// <summary>
	/// HipparcosCatalogViewerForm : Form
	/// </summary>
	public partial class HipparcosCatalogViewerForm : Form
	{
		/// <summary>
		/// AstroElement
		/// </summary>
		private enum AstroElement
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

		/// <summary>
		/// Settings
		/// </summary>
		private readonly Settings settings = new Settings();

		/// <summary>
		/// True if database is loading
		/// </summary>
		private bool isDatabaseLoading = true;

		/// <summary>
		/// Catalog entries
		/// </summary>
		private string[] catalogEntries;

		/// <summary>
		/// Value of the enum of the astrophysical elements
		/// </summary>
		private uint astrophysicalElement = 0;

		/// <summary>
		/// Index variable
		/// </summary>
		private uint index = 0;

		/// <summary>
		/// Maximal value of the index variable
		/// </summary>
		private uint maxIndex = 0;

		/// <summary>
		/// Culture info
		/// </summary>
		private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		#region Local methods

		/// <summary>
		/// Copy a text to the clipbpard
		/// </summary>
		/// <param name="text">text to copy</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(
				owner: this,
				text: Resources.copiedToClipboardText,
				caption: Resources.copiedToClipboardTitle,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information,
				defaultButton: MessageBoxDefaultButton.Button1);
		}

		/// <summary>
		/// Copy a text to the clipboard while entering a control
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void CopyToClipboard(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				CopyToClipboard(text: control.Text);
			}
			else if (sender is ToolStripButton toolStripButton)
			{
				CopyToClipboard(text: toolStripButton.Text);
			}
			else if (sender is ToolStripMenuItem toolStripMenuItem)
			{
				CopyToClipboard(text: toolStripMenuItem.Text);
			}
			else if (sender is ToolStripLabel toolStripLabel)
			{
				CopyToClipboard(text: toolStripLabel.Text);
			}
			else if (sender is ToolStripComboBox toolStripComboBox)
			{
				CopyToClipboard(text: toolStripComboBox.Text);
			}
			else if (sender is ToolStripDropDown toolStripDropDown)
			{
				CopyToClipboard(text: toolStripDropDown.Text);
			}
			else if (sender is ToolStripDropDownButton toolStripDropDownButton)
			{
				CopyToClipboard(text: toolStripDropDownButton.Text);
			}
			else if (sender is ToolStripDropDownItem toolStripDropDownItem)
			{
				CopyToClipboard(text: toolStripDropDownItem.Text);
			}
			else if (sender is ToolStripDropDownMenu toolStripDropDownMenu)
			{
				CopyToClipboard(text: toolStripDropDownMenu.Text);
			}
			else if (sender is ToolStripProgressBar toolStripProgressBar)
			{
				CopyToClipboard(text: toolStripProgressBar.Text);
			}
			else if (sender is ToolStripSplitButton toolStripSplitButton)
			{
				CopyToClipboard(text: toolStripSplitButton.Text);
			}
			else if (sender is ToolStripSeparator toolStripSeparator)
			{
				CopyToClipboard(text: toolStripSeparator.Text);
			}
			else if (sender is ToolStripStatusLabel toolStripStatusLabel)
			{
				CopyToClipboard(text: toolStripStatusLabel.Text);
			}
			else if (sender is ToolStripTextBox toolStripTextBox)
			{
				CopyToClipboard(text: toolStripTextBox.Text);
			}
		}

		/// <summary>
		/// Set the information text in the status bar
		/// </summary>
		/// <param name="text">text to show</param>
		private void SetStatusbar(string text) => toolStripStatusLabelInfo.Text = text;

		/// <summary>
		/// Set the information text in the status bar while entering a control
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbar(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				SetStatusbar(text: control.AccessibleDescription);
			}
			else if (sender is ToolStripButton toolStripButton)
			{
				SetStatusbar(text: toolStripButton.AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem toolStripMenuItem)
			{
				SetStatusbar(text: toolStripMenuItem.AccessibleDescription);
			}
			else if (sender is ToolStripLabel toolStripLabel)
			{
				SetStatusbar(text: toolStripLabel.AccessibleDescription);
			}
			else if (sender is ToolStripComboBox toolStripComboBox)
			{
				SetStatusbar(text: toolStripComboBox.AccessibleDescription);
			}
			else if (sender is ToolStripDropDown toolStripDropDown)
			{
				SetStatusbar(text: toolStripDropDown.AccessibleDescription);
			}
			else if (sender is ToolStripDropDownButton toolStripDropDownButton)
			{
				SetStatusbar(text: toolStripDropDownButton.AccessibleDescription);
			}
			else if (sender is ToolStripDropDownItem toolStripDropDownItem)
			{
				SetStatusbar(text: toolStripDropDownItem.AccessibleDescription);
			}
			else if (sender is ToolStripDropDownMenu toolStripDropDownMenu)
			{
				SetStatusbar(text: toolStripDropDownMenu.AccessibleDescription);
			}
			else if (sender is ToolStripProgressBar toolStripProgressBar)
			{
				SetStatusbar(text: toolStripProgressBar.AccessibleDescription);
			}
			else if (sender is ToolStripSplitButton toolStripSplitButton)
			{
				SetStatusbar(text: toolStripSplitButton.AccessibleDescription);
			}
			else if (sender is ToolStripSeparator toolStripSeparator)
			{
				SetStatusbar(text: toolStripSeparator.AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel toolStripStatusLabel)
			{
				SetStatusbar(text: toolStripStatusLabel.AccessibleDescription);
			}
			else if (sender is ToolStripTextBox toolStripTextBox)
			{
				SetStatusbar(text: toolStripTextBox.AccessibleDescription);
			}
		}

		/// <summary>
		/// Clear the information text in the status bar
		/// </summary>
		private void ClearStatusbar() => toolStripStatusLabelInfo.Text = string.Empty;

		/// <summary>
		/// Set the highlight color to itself and set the information text in the status bar while entering the control
		/// </summary>
		/// <param name="astroElemId">id of the astrophysical element</param>
		/// <param name="labelSelf">label of the astrophysical element</param>
		/// <param name="color">highlight color</param>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		private void SetColorSelfAndSetStatusbar(uint astroElemId, ref Label labelSelf, Color color, object sender, EventArgs e)
		{
			if (!isDatabaseLoading)
			{
				astrophysicalElement = astroElemId;
				SetStatusbar(sender: sender, e: e);
				if (settings.UserEnableHoverEffect)
				{
					SetColorSelf(labelSelf: ref labelSelf, color: color);
				}
			}
		}

		/// <summary>
		/// Set the color to itself and clear the information text in the status bar while leaving the control
		/// </summary>
		/// <param name="labelSelf">label of the astrophysical element</param>
		/// <param name="color">color</param>
		private void SetColorSelfAndClearStatusbar(ref Label labelSelf, Color color)
		{
			if (!isDatabaseLoading)
			{
				ClearStatusbar();
				if (settings.UserEnableHoverEffect)
				{
					SetColorSelf(labelSelf: ref labelSelf, color: color);
				}
			}
		}

		/// <summary>
		/// Set the highlight color to itself and the neighbor field and set the information text in the status bar while entering the control
		/// </summary>
		/// <param name="astroElemId">id of the astrophysical element</param>
		/// <param name="labelSelf">label of the astrophysical element</param>
		/// <param name="labelNeighbor">label of the astrophysical element in the neighbor field</param>
		/// <param name="color">highlight color</param>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		private void SetColorSelfAndNeighborAndSetStatusbar(uint astroElemId, ref Label labelSelf, ref Label labelNeighbor, Color color, object sender, EventArgs e)
		{
			if (!isDatabaseLoading)
			{
				astrophysicalElement = astroElemId;
				SetStatusbar(sender: sender, e: e);
				if (settings.UserEnableHoverEffect)
				{
					SetColorSelfAndNeighbor(labelSelf: ref labelSelf, labelNeighbor: ref labelNeighbor, color: color);
				}
			}
		}

		/// <summary>
		/// Set the color to itself and the neighbor field and clear the information text in the status bar while leaving the control
		/// </summary>
		/// <param name="labelSelf">label of the astrophysical element</param>
		/// <param name="labelNeighbor">label of the astrophysical element in the neighbor field</param>
		/// <param name="color">color</param>
		private void SetColorSelfAndNeighborAndClearStatusbar(ref Label labelSelf, ref Label labelNeighbor, Color color)
		{
			if (!isDatabaseLoading)
			{
				ClearStatusbar();
				if (settings.UserEnableHoverEffect)
				{
					SetColorSelfAndNeighbor(labelSelf: ref labelSelf, labelNeighbor: ref labelNeighbor, color: color);
				}
			}
		}

		/// <summary>
		/// Set the color to itself
		/// </summary>
		/// <param name="labelSelf">label of the astrophysical element</param>
		/// <param name="color">color</param>
		private static void SetColorSelf(ref Label labelSelf, Color color) => labelSelf.BackColor = color;

		/// <summary>
		/// Set the color to itself and the neighbor field
		/// </summary>
		/// <param name="labelSelf">label of the astrophysical element</param>
		/// <param name="labelNeighbor">label of the astrophysical element in the neighbor field</param>
		/// <param name="color">color</param>
		private static void SetColorSelfAndNeighbor(ref Label labelSelf, ref Label labelNeighbor, Color color) => labelSelf.BackColor = labelNeighbor.BackColor = color;

		/// <summary>
		/// Update the index label
		/// </summary>
		private void UpdateIndexLabel() => toolStripTextBoxGoToIndex.Text = index.ToString(provider: culture);

		/// <summary>
		/// Check if the index is the minimum
		/// </summary>
		private void CheckIndexMinimum()
		{
			if (index < 1 || index > maxIndex)
			{
				index = 1;
			}
		}

		/// <summary>
		/// Check if the index is the maximum
		/// </summary>
		private void CheckIndexMaximum()
		{
			if (index > maxIndex)
			{
				index = maxIndex;
			}
		}

		/// <summary>
		/// Show all astrophysical elements of the index
		/// </summary>
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

		/// <summary>
		/// Go the a specified index number
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
		private void GoToIndex()
		{
			if (int.TryParse(s: toolStripTextBoxGoToIndex.Text, result: out int tempIndex))
			{
				if (tempIndex < 1 || tempIndex > maxIndex)
				{
					MessageBox.Show(
						owner: this,
						text: Resources.numberOutOfRangeText,
						caption: Resources.numberOutOfRangeTitle,
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Error,
						defaultButton: MessageBoxDefaultButton.Button1);
				}
				else
				{
					index = Convert.ToUInt32(value: tempIndex);
					UpdateIndexLabel();
					ShowEntriesOnIndex();
				}
			}
			else
			{
				MessageBox.Show(
					owner: this,
					text: Resources.wrongNumberFormatText,
					caption: Resources.wrongNumberFormatTitle,
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error,
					defaultButton: MessageBoxDefaultButton.Button1);
			}
		}

		/// <summary>
		/// Set a double buffer to a specified control
		/// </summary>
		/// <param name="control">double buffered control</param>
		private static void SetDoubleBuffered(Control control)
		{
			if (SystemInformation.TerminalServerSession)
			{
				return;
			}
			PropertyInfo aProp = typeof(Control).GetProperty(name: "DoubleBuffered", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance);
			aProp.SetValue(obj: control, value: true, index: null);
		}

		#endregion

		#region Con- and destructor

		/// <summary>
		/// Constructor
		/// </summary>
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

		#endregion

		#region Form* event handlers

		/// <summary>
		/// Load the window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void HipparcosCatalogViewerForm_Load(object sender, EventArgs e)
		{
			switch (settings.UserEnableHoverEffect)
			{
				default:
					toolStripButtonChangeHoverEffect.Checked = true;
					toolStripButtonChangeHoverEffect.Image = Resources.fugue_table_select_row_16px_shadowless;
					break;
				case false:
					toolStripButtonChangeHoverEffect.Checked = false;
					toolStripButtonChangeHoverEffect.Image = Resources.fugue_table_16px_shadowless;
					break;
			}
			switch (settings.UserDataTableStyle)
			{
				default:
					tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
					break;
				case 1:
					tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
					break;
			}
			SetDoubleBuffered(control: tableLayoutPanel);
			backgroundWorker.RunWorkerAsync();
		}

		/// <summary>
		/// Save the settings while closing the window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		private void HipparcosCatalogViewerForm_FormClosing(object sender, FormClosingEventArgs e) => settings.Save();

		#endregion

		#region BackgroundWorker event handler

		/// <summary>
		/// Load the Hipparcos-DB in background
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="sender"/> and <paramref name="e"/> are not needed, but must be indicated.</remarks>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
		private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			string dataFile = settings.UserHipparcosCatalogDirectory + "hip_main.dat";
			if (File.Exists(path: dataFile))
			{
				menuStrip.Enabled = toolStrip.Visible = false;
				toolStripStatusLabelInfo.Text = Resources.loadingFile;
				catalogEntries = File.ReadAllLines(path: dataFile);
				index = 1;
				maxIndex = Convert.ToUInt32(value: catalogEntries.Length);
				toolStripLabelMaxIndex.Text = "of " + maxIndex.ToString(provider: culture);
				progressBar.Visible = false;
				isDatabaseLoading = false;
				menuStrip.Enabled = toolStrip.Visible = true;
				ClearStatusbar();
				UpdateIndexLabel();
				ShowEntriesOnIndex();
			}
			else
			{
				MessageBox.Show(
					owner: this,
					text: Resources.missingDownloadFilesText1,
					caption: Resources.missingDownloadFilesTitle,
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error,
					defaultButton: MessageBoxDefaultButton.Button1);
				Close();
			}
		}

		#endregion

		#region Click event handlers

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.GC.Collect")]
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

		private void ToolStripButtonGotoIndex_Click(object sender, EventArgs e) => GoToIndex();

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
				default: break;
				case (uint)AstroElement.CatalogData: CopyToClipboard(text: labelCatalogData.Text); break;
				case (uint)AstroElement.IdentifierData: CopyToClipboard(text: labelIdentifierData.Text); break;
				case (uint)AstroElement.ProximityFlagData: CopyToClipboard(text: labelProximityFlagData.Text); break;
				case (uint)AstroElement.RightAscensionData: CopyToClipboard(text: labelRightAscensionData.Text); break;
				case (uint)AstroElement.DeclinationData: CopyToClipboard(text: labelDeclinationData.Text); break;
				case (uint)AstroElement.MagnitudeJohnsonData: CopyToClipboard(text: labelMagnitudeJohnsonData.Text); break;
				case (uint)AstroElement.CoarseVariabilityFlagData: CopyToClipboard(text: labelCoarseVariabilityFlagData.Text); break;
				case (uint)AstroElement.SourceOfMagnitudeData: CopyToClipboard(text: labelSourceOfMagnitudeData.Text); break;
				case (uint)AstroElement.AlphaData: CopyToClipboard(text: labelAlphaData.Text); break;
				case (uint)AstroElement.DeltaData: CopyToClipboard(text: labelDeltaData.Text); break;
				case (uint)AstroElement.ReferenceFlagForAstrometryData: CopyToClipboard(text: labelReferenceFlagForAstrometryData.Text); break;
				case (uint)AstroElement.TrigonomicParallaxData: CopyToClipboard(text: labelTrigonomicParallaxData.Text); break;
				case (uint)AstroElement.ProperMotionAlphaData: CopyToClipboard(text: labelProperMotionAlphaData.Text); break;
				case (uint)AstroElement.ProperMotionDeltaData: CopyToClipboard(text: labelProperMotionDeltaData.Text); break;
				case (uint)AstroElement.StandardErrorRightAscensionData: CopyToClipboard(text: labelStandardErrorRightAscensionData.Text); break;
				case (uint)AstroElement.StandardErrorDeclinationData: CopyToClipboard(text: labelStandardErrorDeclinationData.Text); break;
				case (uint)AstroElement.StandardErrorTrigonomicParallaxData: CopyToClipboard(text: labelStandardErrorTrigonomicParallaxData.Text); break;
				case (uint)AstroElement.StandardErrorProperMotionRightAscensionData: CopyToClipboard(text: labelStandardErrorProperMotionRightAscensionData.Text); break;
				case (uint)AstroElement.StandardErrorProperMotionDeclinationData: CopyToClipboard(text: labelStandardErrorProperMotionDeclinationData.Text); break;
				case (uint)AstroElement.CorrelationDeclinationByRightAscensionData: CopyToClipboard(text: labelCorrelationDeclinationByRightAscensionData.Text); break;
				case (uint)AstroElement.CorrelationTrigonomicParallaxByRightAscensionData: CopyToClipboard(text: labelCorrelationTrigonomicParallaxByRightAscensionData.Text); break;
				case (uint)AstroElement.CorrelationTrigonomicParallaxByDeclinationData: CopyToClipboard(text: labelCorrelationTrigonomicParallaxByDeclinationData.Text); break;
				case (uint)AstroElement.CorrelationProperMotionRightAscensionByRightAscensionData: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByRightAscensionData.Text); break;
				case (uint)AstroElement.CorrelationProperMotionRightAscensionByDeclinationData: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByDeclinationData.Text); break;
				case (uint)AstroElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxData: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByRightAscensionData.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByDeclinationData.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByProperMotionRightAscensionData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.Text); break;
				case (uint)AstroElement.PercentageOfRejectedDataData: CopyToClipboard(text: labelPercentageOfRejectedDataData.Text); break;
				case (uint)AstroElement.GoodnessOfFitParameterData: CopyToClipboard(text: labelGoodnessOfFitParameterData.Text); break;
				case (uint)AstroElement.MeanBtMagnitudeData: CopyToClipboard(text: labelMeanBtMagnitudeData.Text); break;
				case (uint)AstroElement.StandardErrorMeanBtMagnitudeData: CopyToClipboard(text: labelStandardErrorMeanBtMagnitudeData.Text); break;
				case (uint)AstroElement.MeanVtMagnitudeData: CopyToClipboard(text: labelMeanVtMagnitudeData.Text); break;
				case (uint)AstroElement.StandardErrorMeanVtMagnitudeData: CopyToClipboard(text: labelStandardErrorMeanVtMagnitudeData.Text); break;
				case (uint)AstroElement.JohnsonBvColorData: CopyToClipboard(text: labelJohnsonBvColorData.Text); break;
				case (uint)AstroElement.StandardErrorJohnsonBvColorData: CopyToClipboard(text: labelStandardErrorJohnsonBvColorData.Text); break;
				case (uint)AstroElement.ReferenceFlagForBtAndVtMagnitudeData: CopyToClipboard(text: labelReferenceFlagForBtAndVtMagnitudeData.Text); break;
				case (uint)AstroElement.SourceOfBvColorData: CopyToClipboard(text: labelSourceOfBvColorData.Text); break;
				case (uint)AstroElement.ColorIndexInCousinsSystemData: CopyToClipboard(text: labelColorIndexInCousinsSystemData.Text); break;
				case (uint)AstroElement.StandardErrorViData: CopyToClipboard(text: labelStandardErrorViData.Text); break;
				case (uint)AstroElement.SourceOfViData: CopyToClipboard(text: labelSourceOfViData.Text); break;
				case (uint)AstroElement.FlagForCombinedMagnitudesData: CopyToClipboard(text: labelFlagForCombinedMagnitudesData.Text); break;
				case (uint)AstroElement.MedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstroElement.StandardErrorMedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelStandardErrorMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstroElement.ScatterMedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelScatterMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstroElement.NumberObservationsForMedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstroElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemData: CopyToClipboard(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemData.Text); break;
				case (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMaximumData: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemAtMaximumData.Text); break;
				case (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMinimumData: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemAtMinimumData.Text); break;
				case (uint)AstroElement.VariabilityPeriodData: CopyToClipboard(text: labelVariabilityPeriodData.Text); break;
				case (uint)AstroElement.VariabilityTypeData: CopyToClipboard(text: labelVariabilityTypeData.Text); break;
				case (uint)AstroElement.AdditionalDataAboutVariabilityData: CopyToClipboard(text: labelAdditionalDataAboutVariabilityData.Text); break;
				case (uint)AstroElement.LightCurveAnnexData: CopyToClipboard(text: labelLightCurveAnnexData.Text); break;
				case (uint)AstroElement.CcdmIdentifierData: CopyToClipboard(text: labelCcdmIdentifierData.Text); break;
				case (uint)AstroElement.HistoricalStatusFlagData: CopyToClipboard(text: labelHistoricalStatusFlagData.Text); break;
				case (uint)AstroElement.NumberEntriesWithSameCcdmData: CopyToClipboard(text: labelNumberEntriesWithSameCcdmData.Text); break;
				case (uint)AstroElement.NumberComponentsInThisEntryData: CopyToClipboard(text: labelNumberComponentsInThisEntryData.Text); break;
				case (uint)AstroElement.MultipleSystemsFlagData: CopyToClipboard(text: labelMultipleSystemsFlagData.Text); break;
				case (uint)AstroElement.AstrometricSourceFlagData: CopyToClipboard(text: labelAstrometricSourceFlagData.Text); break;
				case (uint)AstroElement.SolutionQualityData: CopyToClipboard(text: labelSolutionQualityData.Text); break;
				case (uint)AstroElement.ComponentIdentifiersData: CopyToClipboard(text: labelComponentIdentifiersData.Text); break;
				case (uint)AstroElement.PositionAngleBetweenComponentsData: CopyToClipboard(text: labelPositionAngleBetweenComponentsData.Text); break;
				case (uint)AstroElement.AngularSeparationBetweenComponentsData: CopyToClipboard(text: labelAngularSeparationBetweenComponentsData.Text); break;
				case (uint)AstroElement.StandardErrorRhoData: CopyToClipboard(text: labelStandardErrorRhoData.Text); break;
				case (uint)AstroElement.MagnitudeDifferenceBetweenComponentsData: CopyToClipboard(text: labelMagnitudeDifferenceBetweenComponentsData.Text); break;
				case (uint)AstroElement.StandardErrorMagnitudeDifferenceBetweenComponentsData: CopyToClipboard(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsData.Text); break;
				case (uint)AstroElement.FlagIndicatingSurveyStarData: CopyToClipboard(text: labelFlagIndicatingSurveyStarData.Text); break;
				case (uint)AstroElement.IdentificationChartData: CopyToClipboard(text: labelIdentificationChartData.Text); break;
				case (uint)AstroElement.ExistenceOfNotesData: CopyToClipboard(text: labelExistenceOfNotesData.Text); break;
				case (uint)AstroElement.HdNumberData: CopyToClipboard(text: labelHdNumberData.Text); break;
				case (uint)AstroElement.BonnerDmData: CopyToClipboard(text: labelBonnerDmData.Text); break;
				case (uint)AstroElement.CordobaDmData: CopyToClipboard(text: labelCordobaDmData.Text); break;
				case (uint)AstroElement.CapePhotographicDmData: CopyToClipboard(text: labelCapePhotographicDmData.Text); break;
				case (uint)AstroElement.ViUsedForReductionsData: CopyToClipboard(text: labelViUsedForReductionsData.Text); break;
				case (uint)AstroElement.SpectralTypeData: CopyToClipboard(text: labelSpectralTypeData.Text); break;
				case (uint)AstroElement.SourceOfSpectralTypeData: CopyToClipboard(text: labelSourceOfSpectralTypeData.Text); break;
				case (uint)AstroElement.CatalogDesc: CopyToClipboard(text: labelCatalogDesc.Text); break;
				case (uint)AstroElement.IdentifierDesc: CopyToClipboard(text: labelIdentifierDesc.Text); break;
				case (uint)AstroElement.ProximityFlagDesc: CopyToClipboard(text: labelProximityFlagDesc.Text); break;
				case (uint)AstroElement.RightAscensionDesc: CopyToClipboard(text: labelRightAscensionDesc.Text); break;
				case (uint)AstroElement.DeclinationDesc: CopyToClipboard(text: labelDeclinationDesc.Text); break;
				case (uint)AstroElement.MagnitudeJohnsonDesc: CopyToClipboard(text: labelMagnitudeJohnsonDesc.Text); break;
				case (uint)AstroElement.CoarseVariabilityFlagDesc: CopyToClipboard(text: labelCoarseVariabilityFlagDesc.Text); break;
				case (uint)AstroElement.SourceOfMagnitudeDesc: CopyToClipboard(text: labelSourceOfMagnitudeDesc.Text); break;
				case (uint)AstroElement.AlphaDesc: CopyToClipboard(text: labelAlphaDesc.Text); break;
				case (uint)AstroElement.DeltaDesc: CopyToClipboard(text: labelDeltaDesc.Text); break;
				case (uint)AstroElement.ReferenceFlagForAstrometryDesc: CopyToClipboard(text: labelReferenceFlagForAstrometryDesc.Text); break;
				case (uint)AstroElement.TrigonomicParallaxDesc: CopyToClipboard(text: labelTrigonomicParallaxDesc.Text); break;
				case (uint)AstroElement.ProperMotionAlphaDesc: CopyToClipboard(text: labelProperMotionAlphaDesc.Text); break;
				case (uint)AstroElement.ProperMotionDeltaDesc: CopyToClipboard(text: labelProperMotionDeltaDesc.Text); break;
				case (uint)AstroElement.StandardErrorRightAscensionDesc: CopyToClipboard(text: labelStandardErrorRightAscensionDesc.Text); break;
				case (uint)AstroElement.StandardErrorDeclinationDesc: CopyToClipboard(text: labelStandardErrorDeclinationDesc.Text); break;
				case (uint)AstroElement.StandardErrorTrigonomicParallaxDesc: CopyToClipboard(text: labelStandardErrorTrigonomicParallaxDesc.Text); break;
				case (uint)AstroElement.StandardErrorProperMotionRightAscensionDesc: CopyToClipboard(text: labelStandardErrorProperMotionRightAscensionDesc.Text); break;
				case (uint)AstroElement.StandardErrorProperMotionDeclinationDesc: CopyToClipboard(text: labelStandardErrorProperMotionDeclinationDesc.Text); break;
				case (uint)AstroElement.CorrelationDeclinationByRightAscensionDesc: CopyToClipboard(text: labelCorrelationDeclinationByRightAscensionDesc.Text); break;
				case (uint)AstroElement.CorrelationTrigonomicParallaxByRightAscensionDesc: CopyToClipboard(text: labelCorrelationTrigonomicParallaxByRightAscensionDesc.Text); break;
				case (uint)AstroElement.CorrelationTrigonomicParallaxByDeclinationDesc: CopyToClipboard(text: labelCorrelationTrigonomicParallaxByDeclinationDesc.Text); break;
				case (uint)AstroElement.CorrelationProperMotionRightAscensionByRightAscensionDesc: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByRightAscensionDesc.Text); break;
				case (uint)AstroElement.CorrelationProperMotionRightAscensionByDeclinationDesc: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByDeclinationDesc.Text); break;
				case (uint)AstroElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxDesc: CopyToClipboard(text: labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionDesc: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByRightAscensionDesc.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationDesc: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByDeclinationDesc.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxDesc: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByProperMotionRightAscensionDesc: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc.Text); break;
				case (uint)AstroElement.PercentageOfRejectedDataDesc: CopyToClipboard(text: labelPercentageOfRejectedDataDesc.Text); break;
				case (uint)AstroElement.GoodnessOfFitParameterDesc: CopyToClipboard(text: labelGoodnessOfFitParameterDesc.Text); break;
				case (uint)AstroElement.MeanBtMagnitudeDesc: CopyToClipboard(text: labelMeanBtMagnitudeDesc.Text); break;
				case (uint)AstroElement.StandardErrorMeanBtMagnitudeDesc: CopyToClipboard(text: labelStandardErrorMeanBtMagnitudeDesc.Text); break;
				case (uint)AstroElement.MeanVtMagnitudeDesc: CopyToClipboard(text: labelMeanVtMagnitudeDesc.Text); break;
				case (uint)AstroElement.StandardErrorMeanVtMagnitudeDesc: CopyToClipboard(text: labelStandardErrorMeanVtMagnitudeDesc.Text); break;
				case (uint)AstroElement.JohnsonBvColorDesc: CopyToClipboard(text: labelJohnsonBvColorDesc.Text); break;
				case (uint)AstroElement.StandardErrorJohnsonBvColorDesc: CopyToClipboard(text: labelStandardErrorJohnsonBvColorDesc.Text); break;
				case (uint)AstroElement.ReferenceFlagForBtAndVtMagnitudeDesc: CopyToClipboard(text: labelReferenceFlagForBtAndVtMagnitudeDesc.Text); break;
				case (uint)AstroElement.SourceOfBvColorDesc: CopyToClipboard(text: labelSourceOfBvColorDesc.Text); break;
				case (uint)AstroElement.ColorIndexInCousinsSystemDesc: CopyToClipboard(text: labelColorIndexInCousinsSystemDesc.Text); break;
				case (uint)AstroElement.StandardErrorViDesc: CopyToClipboard(text: labelStandardErrorViDesc.Text); break;
				case (uint)AstroElement.SourceOfViDesc: CopyToClipboard(text: labelSourceOfViDesc.Text); break;
				case (uint)AstroElement.FlagForCombinedMagnitudesDesc: CopyToClipboard(text: labelFlagForCombinedMagnitudesDesc.Text); break;
				case (uint)AstroElement.MedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstroElement.StandardErrorMedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelStandardErrorMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstroElement.ScatterMedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelScatterMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstroElement.NumberObservationsForMedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstroElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemDesc: CopyToClipboard(text: labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc.Text); break;
				case (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMaximumDesc: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemAtMaximumDesc.Text); break;
				case (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMinimumDesc: CopyToClipboard(text: labelMedianMagnitudeInHipparcosSystemAtMinimumDesc.Text); break;
				case (uint)AstroElement.VariabilityPeriodDesc: CopyToClipboard(text: labelVariabilityPeriodDesc.Text); break;
				case (uint)AstroElement.VariabilityTypeDesc: CopyToClipboard(text: labelVariabilityTypeDesc.Text); break;
				case (uint)AstroElement.AdditionalDataAboutVariabilityDesc: CopyToClipboard(text: labelAdditionalDataAboutVariabilityDesc.Text); break;
				case (uint)AstroElement.LightCurveAnnexDesc: CopyToClipboard(text: labelLightCurveAnnexDesc.Text); break;
				case (uint)AstroElement.CcdmIdentifierDesc: CopyToClipboard(text: labelCcdmIdentifierDesc.Text); break;
				case (uint)AstroElement.HistoricalStatusFlagDesc: CopyToClipboard(text: labelHistoricalStatusFlagDesc.Text); break;
				case (uint)AstroElement.NumberEntriesWithSameCcdmDesc: CopyToClipboard(text: labelNumberEntriesWithSameCcdmDesc.Text); break;
				case (uint)AstroElement.NumberComponentsInThisEntryDesc: CopyToClipboard(text: labelNumberComponentsInThisEntryDesc.Text); break;
				case (uint)AstroElement.MultipleSystemsFlagDesc: CopyToClipboard(text: labelMultipleSystemsFlagDesc.Text); break;
				case (uint)AstroElement.AstrometricSourceFlagDesc: CopyToClipboard(text: labelAstrometricSourceFlagDesc.Text); break;
				case (uint)AstroElement.SolutionQualityDesc: CopyToClipboard(text: labelSolutionQualityDesc.Text); break;
				case (uint)AstroElement.ComponentIdentifiersDesc: CopyToClipboard(text: labelComponentIdentifiersDesc.Text); break;
				case (uint)AstroElement.PositionAngleBetweenComponentsDesc: CopyToClipboard(text: labelPositionAngleBetweenComponentsDesc.Text); break;
				case (uint)AstroElement.AngularSeparationBetweenComponentsDesc: CopyToClipboard(text: labelAngularSeparationBetweenComponentsDesc.Text); break;
				case (uint)AstroElement.StandardErrorRhoDesc: CopyToClipboard(text: labelStandardErrorRhoDesc.Text); break;
				case (uint)AstroElement.MagnitudeDifferenceBetweenComponentsDesc: CopyToClipboard(text: labelMagnitudeDifferenceBetweenComponentsDesc.Text); break;
				case (uint)AstroElement.StandardErrorMagnitudeDifferenceBetweenComponentsDesc: CopyToClipboard(text: labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc.Text); break;
				case (uint)AstroElement.FlagIndicatingSurveyStarDesc: CopyToClipboard(text: labelFlagIndicatingSurveyStarDesc.Text); break;
				case (uint)AstroElement.IdentificationChartDesc: CopyToClipboard(text: labelIdentificationChartDesc.Text); break;
				case (uint)AstroElement.ExistenceOfNotesDesc: CopyToClipboard(text: labelExistenceOfNotesDesc.Text); break;
				case (uint)AstroElement.HdNumberDesc: CopyToClipboard(text: labelHdNumberDesc.Text); break;
				case (uint)AstroElement.BonnerDmDesc: CopyToClipboard(text: labelBonnerDmDesc.Text); break;
				case (uint)AstroElement.CordobaDmDesc: CopyToClipboard(text: labelCordobaDmDesc.Text); break;
				case (uint)AstroElement.CapePhotographicDmDesc: CopyToClipboard(text: labelCapePhotographicDmDesc.Text); break;
				case (uint)AstroElement.ViUsedForReductionsDesc: CopyToClipboard(text: labelViUsedForReductionsDesc.Text); break;
				case (uint)AstroElement.SpectralTypeDesc: CopyToClipboard(text: labelSpectralTypeDesc.Text); break;
				case (uint)AstroElement.SourceOfSpectralTypeDesc: CopyToClipboard(text: labelSourceOfSpectralTypeDesc.Text); break;
			}
		}

		private void ToolStripButtonChangeDataTableStyle_Click(object sender, EventArgs e)
		{
			switch (tableLayoutPanel.CellBorderStyle)
			{
				case TableLayoutPanelCellBorderStyle.InsetDouble:
					tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
					settings.UserDataTableStyle = 0;
					break;
				case TableLayoutPanelCellBorderStyle.OutsetDouble:
					tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
					settings.UserDataTableStyle = 1;
					break;
			}
		}

		private void ToolStripButtonChangeHoverEffect_Click(object sender, EventArgs e)
		{
			toolStripButtonChangeHoverEffect.Checked = !toolStripButtonChangeHoverEffect.Checked;
			settings.UserEnableHoverEffect = !settings.UserEnableHoverEffect;
			toolStripButtonChangeHoverEffect.Image = toolStripButtonChangeHoverEffect.Checked
				? Resources.fugue_table_select_row_16px_shadowless
				: Resources.fugue_table_16px_shadowless;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
		private void ProgressBar_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				owner: this,
				text: Resources.jokeLoadingText,
				caption: Resources.jokeLoadingTitle,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Exclamation,
				defaultButton: MessageBoxDefaultButton.Button1);
		}

		#endregion

		#region DoubleClick event handlers

		private void CopyToClipboard_DoubleClick(object sender, EventArgs e)
		{
			if (settings.UserEnableCopyMethod)
			{
				CopyToClipboard(sender: sender, e: e);
			}
		}

		#endregion

		#region Enter event handlers

		private void LabelCatalogDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CatalogDesc, labelSelf: ref labelCatalogDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCatalogData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CatalogData, labelSelf: ref labelCatalogData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelIdentifierDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.IdentifierDesc, labelSelf: ref labelIdentifierDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelIdentifierData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.IdentifierData, labelSelf: ref labelIdentifierData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelProximityFlagDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ProximityFlagDesc, labelSelf: ref labelProximityFlagDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelProximityFlagData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ProximityFlagData, labelSelf: ref labelProximityFlagData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ProximityFlagData, labelSelf: ref labelRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.RightAscensionData, labelSelf: ref labelRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelDeclinationDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.DeclinationDesc, labelSelf: ref labelDeclinationDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelDeclinationData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.DeclinationData, labelSelf: ref labelDeclinationData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMagnitudeJohnsonDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeJohnsonDesc, labelSelf: ref labelMagnitudeJohnsonDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMagnitudeJohnsonData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeJohnsonData, labelSelf: ref labelMagnitudeJohnsonData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCoarseVariabilityFlagDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CoarseVariabilityFlagDesc, labelSelf: ref labelCoarseVariabilityFlagDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCoarseVariabilityFlagData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CoarseVariabilityFlagData, labelSelf: ref labelCoarseVariabilityFlagData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfMagnitudeDesc, labelSelf: ref labelSourceOfMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfMagnitudeData, labelSelf: ref labelSourceOfMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAlphaDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AlphaDesc, labelSelf: ref labelAlphaDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAlphaData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AlphaData, labelSelf: ref labelAlphaData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelDeltaDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.DeltaDesc, labelSelf: ref labelCatalogDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelDeltaData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.DeltaData, labelSelf: ref labelDeltaData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelReferenceFlagForAstrometryDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForAstrometryDesc, labelSelf: ref labelReferenceFlagForAstrometryDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelReferenceFlagForAstrometryData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForAstrometryData, labelSelf: ref labelReferenceFlagForAstrometryData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelTrigonomicParallaxDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.TrigonomicParallaxDesc, labelSelf: ref labelTrigonomicParallaxDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelTrigonomicParallaxData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.TrigonomicParallaxData, labelSelf: ref labelTrigonomicParallaxData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelProperMotionAlphaDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ProperMotionAlphaDesc, labelSelf: ref labelProperMotionAlphaDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelProperMotionAlphaData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ProperMotionAlphaData, labelSelf: ref labelProperMotionAlphaData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelProperMotionDeltaDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ProperMotionDeltaDesc, labelSelf: ref labelProperMotionDeltaDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelProperMotionDeltaData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ProperMotionDeltaData, labelSelf: ref labelProperMotionDeltaData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorRightAscensionDesc, labelSelf: ref labelStandardErrorRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorRightAscensionData, labelSelf: ref labelStandardErrorRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorDeclinationDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorDeclinationDesc, labelSelf: ref labelStandardErrorDeclinationDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorDeclinationData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorDeclinationData, labelSelf: ref labelStandardErrorDeclinationData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorTrigonomicParallaxDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorTrigonomicParallaxDesc, labelSelf: ref labelStandardErrorTrigonomicParallaxDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorTrigonomicParallaxData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorTrigonomicParallaxData, labelSelf: ref labelStandardErrorTrigonomicParallaxData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorProperMotionRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorProperMotionRightAscensionDesc, labelSelf: ref labelStandardErrorProperMotionRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorProperMotionRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorProperMotionRightAscensionData, labelSelf: ref labelStandardErrorProperMotionRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorProperMotionDeclinationDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorProperMotionDeclinationDesc, labelSelf: ref labelStandardErrorProperMotionDeclinationDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorProperMotionDeclinationData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorProperMotionDeclinationData, labelSelf: ref labelStandardErrorProperMotionDeclinationData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionDesc, labelSelf: ref labelCorrelationDeclinationByRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationDeclinationByRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionData, labelSelf: ref labelCorrelationDeclinationByRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationTrigonomicParallaxByRightAscensionDesc, labelSelf: ref labelCorrelationTrigonomicParallaxByRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationTrigonomicParallaxByRightAscensionData, labelSelf: ref labelCorrelationTrigonomicParallaxByRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationTrigonomicParallaxByDeclinationDesc, labelSelf: ref labelCorrelationTrigonomicParallaxByDeclinationDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationTrigonomicParallaxByDeclinationData, labelSelf: ref labelCorrelationTrigonomicParallaxByDeclinationData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByRightAscensionDesc, labelSelf: ref labelCorrelationProperMotionRightAscensionByRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByRightAscensionData, labelSelf: ref labelCorrelationProperMotionRightAscensionByRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByDeclinationDesc, labelSelf: ref labelCorrelationProperMotionRightAscensionByDeclinationDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByDeclinationData, labelSelf: ref labelCorrelationProperMotionRightAscensionByDeclinationData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxDesc, labelSelf: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxData, labelSelf: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionData, labelSelf: ref labelCorrelationProperMotionDeclinationByRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationData, labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxData, labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionData, labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelPercentageOfRejectedDataDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.PercentageOfRejectedDataDesc, labelSelf: ref labelPercentageOfRejectedDataDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelPercentageOfRejectedDataData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.PercentageOfRejectedDataData, labelSelf: ref labelPercentageOfRejectedDataData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelGoodnessOfFitParameterDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.GoodnessOfFitParameterDesc, labelSelf: ref labelGoodnessOfFitParameterDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelGoodnessOfFitParameterData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.GoodnessOfFitParameterData, labelSelf: ref labelGoodnessOfFitParameterData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMeanBtMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MeanBtMagnitudeDesc, labelSelf: ref labelMeanBtMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMeanBtMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MeanBtMagnitudeData, labelSelf: ref labelMeanBtMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMeanBtMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanBtMagnitudeDesc, labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMeanBtMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanBtMagnitudeData, labelSelf: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMeanVtMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MeanVtMagnitudeDesc, labelSelf: ref labelMeanVtMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMeanVtMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MeanVtMagnitudeData, labelSelf: ref labelMeanVtMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMeanVtMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeDesc, labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMeanVtMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeData, labelSelf: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelJohnsonBvColorDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.JohnsonBvColorDesc, labelSelf: ref labelJohnsonBvColorDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelJohnsonBvColorData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.JohnsonBvColorData, labelSelf: ref labelJohnsonBvColorData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorJohnsonBvColorDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorJohnsonBvColorDesc, labelSelf: ref labelStandardErrorJohnsonBvColorDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorJohnsonBvColorData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorJohnsonBvColorData, labelSelf: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForBtAndVtMagnitudeDesc, labelSelf: ref labelReferenceFlagForBtAndVtMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelReferenceFlagForBtAndVtMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForBtAndVtMagnitudeData, labelSelf: ref labelReferenceFlagForBtAndVtMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfBvColorDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfBvColorDesc, labelSelf: ref labelSourceOfBvColorDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfBvColorData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfBvColorData, labelSelf: ref labelSourceOfBvColorData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelColorIndexInCousinsSystemDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ColorIndexInCousinsSystemDesc, labelSelf: ref labelColorIndexInCousinsSystemDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelColorIndexInCousinsSystemData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ColorIndexInCousinsSystemData, labelSelf: ref labelColorIndexInCousinsSystemData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorViDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorViDesc, labelSelf: ref labelStandardErrorViDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorViData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorViData, labelSelf: ref labelStandardErrorViData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfViDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfViDesc, labelSelf: ref labelSourceOfViDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfViData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfViData, labelSelf: ref labelSourceOfViData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelFlagForCombinedMagnitudesDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.FlagForCombinedMagnitudesDesc, labelSelf: ref labelFlagForCombinedMagnitudesDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelFlagForCombinedMagnitudesData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.FlagForCombinedMagnitudesData, labelSelf: ref labelFlagForCombinedMagnitudesData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelMedianMagnitudeInHipparcosSystemDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemData, labelSelf: ref labelMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelStandardErrorMedianMagnitudeInHipparcosSystemDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMedianMagnitudeInHipparcosSystemData, labelSelf: ref labelStandardErrorMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ScatterMedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelScatterMedianMagnitudeInHipparcosSystemDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ScatterMedianMagnitudeInHipparcosSystemData, labelSelf: ref labelScatterMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberObservationsForMedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberObservationsForMedianMagnitudeInHipparcosSystemData, labelSelf: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemData, labelSelf: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMaximumDesc, labelSelf: ref labelCatalogDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMaximumData, labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMaximumData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMinimumDesc, labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMinimumDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMinimumData, labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMinimumData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVariabilityPeriodDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityPeriodDesc, labelSelf: ref labelVariabilityPeriodDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVariabilityPeriodData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityPeriodData, labelSelf: ref labelVariabilityPeriodData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVariabilityTypeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityTypeDesc, labelSelf: ref labelVariabilityTypeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVariabilityTypeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityTypeData, labelSelf: ref labelVariabilityTypeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAdditionalDataAboutVariabilityDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AdditionalDataAboutVariabilityDesc, labelSelf: ref labelAdditionalDataAboutVariabilityDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAdditionalDataAboutVariabilityData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AdditionalDataAboutVariabilityData, labelSelf: ref labelAdditionalDataAboutVariabilityData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelLightCurveAnnexDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.LightCurveAnnexDesc, labelSelf: ref labelLightCurveAnnexDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelLightCurveAnnexData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.LightCurveAnnexData, labelSelf: ref labelLightCurveAnnexData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCcdmIdentifierDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CcdmIdentifierDesc, labelSelf: ref labelCcdmIdentifierDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCcdmIdentifierData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CcdmIdentifierData, labelSelf: ref labelCatalogDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelHistoricalStatusFlagDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.HistoricalStatusFlagDesc, labelSelf: ref labelHistoricalStatusFlagDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelHistoricalStatusFlagData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.HistoricalStatusFlagData, labelSelf: ref labelHistoricalStatusFlagData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberEntriesWithSameCcdmDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberEntriesWithSameCcdmDesc, labelSelf: ref labelNumberEntriesWithSameCcdmDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberEntriesWithSameCcdmData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberEntriesWithSameCcdmData, labelSelf: ref labelNumberEntriesWithSameCcdmData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberComponentsInThisEntryDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberComponentsInThisEntryDesc, labelSelf: ref labelNumberComponentsInThisEntryDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberComponentsInThisEntryData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberComponentsInThisEntryData, labelSelf: ref labelNumberComponentsInThisEntryData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMultipleSystemsFlagDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MultipleSystemsFlagDesc, labelSelf: ref labelMultipleSystemsFlagDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMultipleSystemsFlagData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MultipleSystemsFlagData, labelSelf: ref labelMultipleSystemsFlagData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAstrometricSourceFlagDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AstrometricSourceFlagDesc, labelSelf: ref labelAstrometricSourceFlagDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAstrometricSourceFlagData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AstrometricSourceFlagData, labelSelf: ref labelAstrometricSourceFlagData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSolutionQualityDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SolutionQualityDesc, labelSelf: ref labelSolutionQualityDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSolutionQualityData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SolutionQualityData, labelSelf: ref labelSolutionQualityData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelComponentIdentifiersDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ComponentIdentifiersDesc, labelSelf: ref labelComponentIdentifiersDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelComponentIdentifiersData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ComponentIdentifiersData, labelSelf: ref labelComponentIdentifiersData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelPositionAngleBetweenComponentsDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.PositionAngleBetweenComponentsDesc, labelSelf: ref labelPositionAngleBetweenComponentsDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelPositionAngleBetweenComponentsData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.PositionAngleBetweenComponentsData, labelSelf: ref labelPositionAngleBetweenComponentsData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAngularSeparationBetweenComponentsDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AngularSeparationBetweenComponentsDesc, labelSelf: ref labelAngularSeparationBetweenComponentsDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAngularSeparationBetweenComponentsData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AngularSeparationBetweenComponentsData, labelSelf: ref labelAngularSeparationBetweenComponentsData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorRhoDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorRhoDesc, labelSelf: ref labelStandardErrorRhoDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorRhoData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorRhoData, labelSelf: ref labelStandardErrorRhoData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeDifferenceBetweenComponentsDesc, labelSelf: ref labelMagnitudeDifferenceBetweenComponentsDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeDifferenceBetweenComponentsData, labelSelf: ref labelMagnitudeDifferenceBetweenComponentsData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMagnitudeDifferenceBetweenComponentsDesc, labelSelf: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMagnitudeDifferenceBetweenComponentsData, labelSelf: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelFlagIndicatingSurveyStarDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.FlagIndicatingSurveyStarDesc, labelSelf: ref labelFlagIndicatingSurveyStarDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelFlagIndicatingSurveyStarData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.FlagIndicatingSurveyStarData, labelSelf: ref labelFlagIndicatingSurveyStarData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelIdentificationChartDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.IdentificationChartDesc, labelSelf: ref labelIdentificationChartDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelIdentificationChartData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.IdentificationChartData, labelSelf: ref labelIdentificationChartData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelExistenceOfNotesDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ExistenceOfNotesDesc, labelSelf: ref labelExistenceOfNotesDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelExistenceOfNotesData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ExistenceOfNotesData, labelSelf: ref labelExistenceOfNotesData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelHdNumberDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.HdNumberDesc, labelSelf: ref labelHdNumberDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelHdNumberData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.HdNumberData, labelSelf: ref labelHdNumberData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelBonnerDmDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.BonnerDmDesc, labelSelf: ref labelBonnerDmDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelBonnerDmData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.BonnerDmData, labelSelf: ref labelBonnerDmData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCordobaDmDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CordobaDmDesc, labelSelf: ref labelCordobaDmDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCordobaDmData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CordobaDmData, labelSelf: ref labelCordobaDmData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCapePhotographicDmDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CapePhotographicDmDesc, labelSelf: ref labelCapePhotographicDmDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCapePhotographicDmData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CapePhotographicDmData, labelSelf: ref labelCapePhotographicDmData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelViUsedForReductionsDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ViUsedForReductionsDesc, labelSelf: ref labelViUsedForReductionsDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelViUsedForReductionsData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.ViUsedForReductionsData, labelSelf: ref labelViUsedForReductionsData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSpectralTypeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SpectralTypeDesc, labelSelf: ref labelSpectralTypeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSpectralTypeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SpectralTypeData, labelSelf: ref labelSpectralTypeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfSpectralTypeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfSpectralTypeDesc, labelSelf: ref labelSourceOfSpectralTypeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfSpectralTypeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfSpectralTypeData, labelSelf: ref labelSourceOfSpectralTypeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void ToolStripTextBoxGoToIndex_Enter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		#endregion

		#region MouseEnter event handlers

		private void MenuitemClose_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripMenuItemInfo_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonStepToBegin_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonStepFastBackward_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonStepBackward_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonStepForward_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonStepFastForward_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonStepToEnd_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void LabelCatalogDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CatalogDesc, labelSelf: ref labelCatalogDesc, labelNeighbor: ref labelCatalogData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCatalogData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CatalogData, labelSelf: ref labelCatalogDesc, labelNeighbor: ref labelCatalogData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelIdentifierDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.IdentifierDesc, labelSelf: ref labelIdentifierDesc, labelNeighbor: ref labelIdentifierData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelIdentifierData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.IdentifierData, labelSelf: ref labelIdentifierDesc, labelNeighbor: ref labelIdentifierData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelProximityFlagDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ProximityFlagDesc, labelSelf: ref labelProximityFlagDesc, labelNeighbor: ref labelProximityFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelProximityFlagData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ProximityFlagData, labelSelf: ref labelProximityFlagDesc, labelNeighbor: ref labelProximityFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelRightAscensionDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.RightAscensionDesc, labelSelf: ref labelRightAscensionDesc, labelNeighbor: ref labelRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelRightAscensionData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.RightAscensionData, labelSelf: ref labelRightAscensionDesc, labelNeighbor: ref labelRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelDeclinationDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.DeclinationDesc, labelSelf: ref labelDeclinationDesc, labelNeighbor: ref labelDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelDeclinationData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.DeclinationData, labelSelf: ref labelDeclinationDesc, labelNeighbor: ref labelDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMagnitudeJohnsonDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeJohnsonDesc, labelSelf: ref labelMagnitudeJohnsonDesc, labelNeighbor: ref labelMagnitudeJohnsonData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMagnitudeJohnsonData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeJohnsonData, labelSelf: ref labelMagnitudeJohnsonDesc, labelNeighbor: ref labelMagnitudeJohnsonData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCoarseVariabilityFlagDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CoarseVariabilityFlagDesc, labelSelf: ref labelCoarseVariabilityFlagDesc, labelNeighbor: ref labelCoarseVariabilityFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCoarseVariabilityFlagData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CoarseVariabilityFlagData, labelSelf: ref labelCoarseVariabilityFlagDesc, labelNeighbor: ref labelCoarseVariabilityFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfMagnitudeDesc, labelSelf: ref labelSourceOfMagnitudeDesc, labelNeighbor: ref labelSourceOfMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfMagnitudeData, labelSelf: ref labelSourceOfMagnitudeDesc, labelNeighbor: ref labelSourceOfMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAlphaDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AlphaDesc, labelSelf: ref labelAlphaDesc, labelNeighbor: ref labelAlphaData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAlphaData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AlphaData, labelSelf: ref labelAlphaDesc, labelNeighbor: ref labelAlphaData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelDeltaDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.DeltaDesc, labelSelf: ref labelDeltaDesc, labelNeighbor: ref labelDeltaData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelDeltaData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.DeltaData, labelSelf: ref labelDeltaDesc, labelNeighbor: ref labelDeltaData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelReferenceFlagForAstrometryDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForAstrometryDesc, labelSelf: ref labelReferenceFlagForAstrometryDesc, labelNeighbor: ref labelReferenceFlagForAstrometryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelReferenceFlagForAstrometryData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForAstrometryData, labelSelf: ref labelReferenceFlagForAstrometryDesc, labelNeighbor: ref labelReferenceFlagForAstrometryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.TrigonomicParallaxDesc, labelSelf: ref labelTrigonomicParallaxDesc, labelNeighbor: ref labelTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelTrigonomicParallaxData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.TrigonomicParallaxData, labelSelf: ref labelTrigonomicParallaxDesc, labelNeighbor: ref labelTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelProperMotionAlphaDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ProperMotionAlphaDesc, labelSelf: ref labelProperMotionAlphaDesc, labelNeighbor: ref labelProperMotionAlphaData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelProperMotionAlphaData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ProperMotionAlphaData, labelSelf: ref labelProperMotionAlphaDesc, labelNeighbor: ref labelProperMotionAlphaData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelProperMotionDeltaDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ProperMotionDeltaDesc, labelSelf: ref labelProperMotionDeltaDesc, labelNeighbor: ref labelProperMotionDeltaData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelProperMotionDeltaData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ProperMotionDeltaData, labelSelf: ref labelProperMotionDeltaDesc, labelNeighbor: ref labelProperMotionDeltaData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorRightAscensionDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorRightAscensionDesc, labelSelf: ref labelStandardErrorRightAscensionDesc, labelNeighbor: ref labelStandardErrorRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorRightAscensionData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorRightAscensionData, labelSelf: ref labelStandardErrorRightAscensionDesc, labelNeighbor: ref labelStandardErrorRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorDeclinationDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorDeclinationDesc, labelSelf: ref labelStandardErrorDeclinationDesc, labelNeighbor: ref labelStandardErrorDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorDeclinationData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorDeclinationData, labelSelf: ref labelStandardErrorDeclinationDesc, labelNeighbor: ref labelStandardErrorDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorTrigonomicParallaxDesc, labelSelf: ref labelStandardErrorTrigonomicParallaxDesc, labelNeighbor: ref labelStandardErrorTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorTrigonomicParallaxData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorTrigonomicParallaxData, labelSelf: ref labelStandardErrorTrigonomicParallaxDesc, labelNeighbor: ref labelStandardErrorTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorProperMotionRightAscensionDesc, labelSelf: ref labelStandardErrorProperMotionRightAscensionDesc, labelNeighbor: ref labelStandardErrorProperMotionRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorProperMotionRightAscensionData, labelSelf: ref labelStandardErrorProperMotionRightAscensionDesc, labelNeighbor: ref labelStandardErrorProperMotionRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorProperMotionDeclinationDesc, labelSelf: ref labelStandardErrorProperMotionDeclinationDesc, labelNeighbor: ref labelStandardErrorProperMotionDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorProperMotionDeclinationData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorProperMotionDeclinationData, labelSelf: ref labelStandardErrorProperMotionDeclinationDesc, labelNeighbor: ref labelStandardErrorProperMotionDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationDeclinationByRightAscensionDesc, labelSelf: ref labelCorrelationDeclinationByRightAscensionDesc, labelNeighbor: ref labelCorrelationDeclinationByRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationDeclinationByRightAscensionData, labelSelf: ref labelCorrelationDeclinationByRightAscensionDesc, labelNeighbor: ref labelCorrelationDeclinationByRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationTrigonomicParallaxByRightAscensionDesc, labelSelf: ref labelCorrelationTrigonomicParallaxByRightAscensionDesc, labelNeighbor: ref labelCorrelationTrigonomicParallaxByRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationTrigonomicParallaxByRightAscensionData, labelSelf: ref labelCorrelationTrigonomicParallaxByRightAscensionDesc, labelNeighbor: ref labelCorrelationTrigonomicParallaxByRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationTrigonomicParallaxByDeclinationDesc, labelSelf: ref labelCorrelationTrigonomicParallaxByDeclinationDesc, labelNeighbor: ref labelCorrelationTrigonomicParallaxByDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationTrigonomicParallaxByDeclinationData, labelSelf: ref labelCorrelationTrigonomicParallaxByDeclinationDesc, labelNeighbor: ref labelCorrelationTrigonomicParallaxByDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByRightAscensionDesc, labelSelf: ref labelCorrelationProperMotionRightAscensionByRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByRightAscensionData, labelSelf: ref labelCorrelationProperMotionRightAscensionByRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByDeclinationDesc, labelSelf: ref labelCorrelationProperMotionRightAscensionByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByDeclinationData, labelSelf: ref labelCorrelationProperMotionRightAscensionByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxDesc, labelSelf: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionRightAscensionByTrigonomicParallaxData, labelSelf: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionData, labelSelf: ref labelCorrelationProperMotionDeclinationByRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationData, labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxData, labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByRightAscensionData, labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelPercentageOfRejectedDataDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.PercentageOfRejectedDataDesc, labelSelf: ref labelPercentageOfRejectedDataDesc, labelNeighbor: ref labelPercentageOfRejectedDataData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelPercentageOfRejectedDataData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.PercentageOfRejectedDataData, labelSelf: ref labelPercentageOfRejectedDataDesc, labelNeighbor: ref labelPercentageOfRejectedDataData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelGoodnessOfFitParameterDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.GoodnessOfFitParameterDesc, labelSelf: ref labelGoodnessOfFitParameterDesc, labelNeighbor: ref labelGoodnessOfFitParameterData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelGoodnessOfFitParameterData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.GoodnessOfFitParameterData, labelSelf: ref labelGoodnessOfFitParameterDesc, labelNeighbor: ref labelGoodnessOfFitParameterData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MeanBtMagnitudeDesc, labelSelf: ref labelMeanBtMagnitudeDesc, labelNeighbor: ref labelMeanBtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MeanBtMagnitudeData, labelSelf: ref labelMeanBtMagnitudeDesc, labelNeighbor: ref labelMeanBtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanBtMagnitudeDesc, labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanBtMagnitudeData, labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeDesc, labelSelf: ref labelMeanVtMagnitudeDesc, labelNeighbor: ref labelMeanVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeData, labelSelf: ref labelMeanVtMagnitudeDesc, labelNeighbor: ref labelMeanVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeDesc, labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeData, labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.JohnsonBvColorDesc, labelSelf: ref labelJohnsonBvColorDesc, labelNeighbor: ref labelJohnsonBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelJohnsonBvColorData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.JohnsonBvColorData, labelSelf: ref labelJohnsonBvColorDesc, labelNeighbor: ref labelJohnsonBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorJohnsonBvColorDesc, labelSelf: ref labelStandardErrorJohnsonBvColorDesc, labelNeighbor: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorJohnsonBvColorData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorJohnsonBvColorData, labelSelf: ref labelStandardErrorJohnsonBvColorDesc, labelNeighbor: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelColorIndexInCousinsSystemDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ColorIndexInCousinsSystemDesc, labelSelf: ref labelColorIndexInCousinsSystemDesc, labelNeighbor: ref labelColorIndexInCousinsSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelColorIndexInCousinsSystemData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ColorIndexInCousinsSystemData, labelSelf: ref labelColorIndexInCousinsSystemDesc, labelNeighbor: ref labelColorIndexInCousinsSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorViDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorViDesc, labelSelf: ref labelStandardErrorViDesc, labelNeighbor: ref labelStandardErrorViData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorViData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorViData, labelSelf: ref labelStandardErrorViDesc, labelNeighbor: ref labelStandardErrorViData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfViDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfViDesc, labelSelf: ref labelSourceOfViDesc, labelNeighbor: ref labelSourceOfViData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfViData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfViData, labelSelf: ref labelSourceOfViDesc, labelNeighbor: ref labelSourceOfViData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelFlagForCombinedMagnitudesDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.FlagForCombinedMagnitudesDesc, labelSelf: ref labelFlagForCombinedMagnitudesDesc, labelNeighbor: ref labelFlagForCombinedMagnitudesData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelFlagForCombinedMagnitudesData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.FlagForCombinedMagnitudesData, labelSelf: ref labelFlagForCombinedMagnitudesDesc, labelNeighbor: ref labelFlagForCombinedMagnitudesData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemData, labelSelf: ref labelMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelStandardErrorMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelStandardErrorMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMedianMagnitudeInHipparcosSystemData, labelSelf: ref labelStandardErrorMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelStandardErrorMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ScatterMedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelScatterMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelScatterMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ScatterMedianMagnitudeInHipparcosSystemData, labelSelf: ref labelScatterMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelScatterMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberObservationsForMedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberObservationsForMedianMagnitudeInHipparcosSystemData, labelSelf: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemDesc, labelSelf: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForMedianMagnitudeInHipparcosSystemData, labelSelf: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForBtAndVtMagnitudeData, labelSelf: ref labelReferenceFlagForBtAndVtMagnitudeDesc, labelNeighbor: ref labelReferenceFlagForBtAndVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelReferenceFlagForBtAndVtMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForBtAndVtMagnitudeDesc, labelSelf: ref labelReferenceFlagForBtAndVtMagnitudeDesc, labelNeighbor: ref labelReferenceFlagForBtAndVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfBvColorDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForBtAndVtMagnitudeDesc, labelSelf: ref labelSourceOfBvColorDesc, labelNeighbor: ref labelSourceOfBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfBvColorData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ReferenceFlagForBtAndVtMagnitudeData, labelSelf: ref labelSourceOfBvColorDesc, labelNeighbor: ref labelSourceOfBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMaximumDesc, labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMaximumDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemAtMaximumData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMaximumData, labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMaximumDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemAtMaximumData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMinimumDesc, labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMinimumDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemAtMinimumData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MedianMagnitudeInHipparcosSystemAtMinimumData, labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMinimumDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemAtMinimumData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVariabilityPeriodDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityTypeData, labelSelf: ref labelVariabilityPeriodDesc, labelNeighbor: ref labelVariabilityPeriodData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVariabilityPeriodData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityPeriodData, labelSelf: ref labelVariabilityPeriodDesc, labelNeighbor: ref labelVariabilityPeriodData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVariabilityTypeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityTypeDesc, labelSelf: ref labelVariabilityTypeDesc, labelNeighbor: ref labelVariabilityTypeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVariabilityTypeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityTypeData, labelSelf: ref labelVariabilityTypeDesc, labelNeighbor: ref labelVariabilityTypeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAdditionalDataAboutVariabilityDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AdditionalDataAboutVariabilityDesc, labelSelf: ref labelAdditionalDataAboutVariabilityDesc, labelNeighbor: ref labelAdditionalDataAboutVariabilityData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAdditionalDataAboutVariabilityData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AdditionalDataAboutVariabilityData, labelSelf: ref labelAdditionalDataAboutVariabilityDesc, labelNeighbor: ref labelAdditionalDataAboutVariabilityData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelLightCurveAnnexDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.LightCurveAnnexDesc, labelSelf: ref labelLightCurveAnnexDesc, labelNeighbor: ref labelLightCurveAnnexData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelLightCurveAnnexData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.LightCurveAnnexData, labelSelf: ref labelLightCurveAnnexDesc, labelNeighbor: ref labelLightCurveAnnexData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCcdmIdentifierDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CcdmIdentifierDesc, labelSelf: ref labelCcdmIdentifierDesc, labelNeighbor: ref labelCcdmIdentifierData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCcdmIdentifierData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CcdmIdentifierData, labelSelf: ref labelCcdmIdentifierDesc, labelNeighbor: ref labelCcdmIdentifierData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelHistoricalStatusFlagDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.HistoricalStatusFlagDesc, labelSelf: ref labelHistoricalStatusFlagDesc, labelNeighbor: ref labelHistoricalStatusFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelHistoricalStatusFlagData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.HistoricalStatusFlagData, labelSelf: ref labelHistoricalStatusFlagDesc, labelNeighbor: ref labelHistoricalStatusFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberEntriesWithSameCcdmDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberEntriesWithSameCcdmDesc, labelSelf: ref labelNumberEntriesWithSameCcdmDesc, labelNeighbor: ref labelNumberEntriesWithSameCcdmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberEntriesWithSameCcdmData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberEntriesWithSameCcdmData, labelSelf: ref labelNumberEntriesWithSameCcdmDesc, labelNeighbor: ref labelNumberEntriesWithSameCcdmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberComponentsInThisEntryDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberComponentsInThisEntryDesc, labelSelf: ref labelNumberComponentsInThisEntryDesc, labelNeighbor: ref labelNumberComponentsInThisEntryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberComponentsInThisEntryData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberComponentsInThisEntryData, labelSelf: ref labelNumberComponentsInThisEntryDesc, labelNeighbor: ref labelNumberComponentsInThisEntryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMultipleSystemsFlagDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MultipleSystemsFlagDesc, labelSelf: ref labelMultipleSystemsFlagDesc, labelNeighbor: ref labelMultipleSystemsFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMultipleSystemsFlagData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MultipleSystemsFlagData, labelSelf: ref labelMultipleSystemsFlagDesc, labelNeighbor: ref labelMultipleSystemsFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAstrometricSourceFlagDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AstrometricSourceFlagDesc, labelSelf: ref labelAstrometricSourceFlagDesc, labelNeighbor: ref labelAstrometricSourceFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAstrometricSourceFlagData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AstrometricSourceFlagData, labelSelf: ref labelAstrometricSourceFlagDesc, labelNeighbor: ref labelAstrometricSourceFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSolutionQualityDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SolutionQualityDesc, labelSelf: ref labelSolutionQualityDesc, labelNeighbor: ref labelSolutionQualityData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSolutionQualityData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SolutionQualityData, labelSelf: ref labelSolutionQualityDesc, labelNeighbor: ref labelSolutionQualityData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelComponentIdentifiersDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ComponentIdentifiersDesc, labelSelf: ref labelComponentIdentifiersDesc, labelNeighbor: ref labelComponentIdentifiersData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelComponentIdentifiersData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ComponentIdentifiersData, labelSelf: ref labelComponentIdentifiersDesc, labelNeighbor: ref labelComponentIdentifiersData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelPositionAngleBetweenComponentsDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.PositionAngleBetweenComponentsDesc, labelSelf: ref labelPositionAngleBetweenComponentsDesc, labelNeighbor: ref labelPositionAngleBetweenComponentsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelPositionAngleBetweenComponentsData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.PositionAngleBetweenComponentsData, labelSelf: ref labelPositionAngleBetweenComponentsDesc, labelNeighbor: ref labelPositionAngleBetweenComponentsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAngularSeparationBetweenComponentsDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AngularSeparationBetweenComponentsData, labelSelf: ref labelAngularSeparationBetweenComponentsDesc, labelNeighbor: ref labelAngularSeparationBetweenComponentsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAngularSeparationBetweenComponentsData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AngularSeparationBetweenComponentsData, labelSelf: ref labelAngularSeparationBetweenComponentsDesc, labelNeighbor: ref labelAngularSeparationBetweenComponentsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorRhoDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorRhoDesc, labelSelf: ref labelStandardErrorRhoDesc, labelNeighbor: ref labelStandardErrorRhoData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorRhoData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorRhoData, labelSelf: ref labelStandardErrorRhoDesc, labelNeighbor: ref labelStandardErrorRhoData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeDifferenceBetweenComponentsDesc, labelSelf: ref labelMagnitudeDifferenceBetweenComponentsDesc, labelNeighbor: ref labelMagnitudeDifferenceBetweenComponentsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeDifferenceBetweenComponentsData, labelSelf: ref labelMagnitudeDifferenceBetweenComponentsDesc, labelNeighbor: ref labelMagnitudeDifferenceBetweenComponentsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMagnitudeDifferenceBetweenComponentsDesc, labelSelf: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc, labelNeighbor: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMagnitudeDifferenceBetweenComponentsData, labelSelf: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc, labelNeighbor: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelFlagIndicatingSurveyStarDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.FlagIndicatingSurveyStarDesc, labelSelf: ref labelFlagIndicatingSurveyStarDesc, labelNeighbor: ref labelFlagIndicatingSurveyStarData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelFlagIndicatingSurveyStarData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.FlagIndicatingSurveyStarData, labelSelf: ref labelFlagIndicatingSurveyStarDesc, labelNeighbor: ref labelFlagIndicatingSurveyStarData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelIdentificationChartDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.IdentificationChartDesc, labelSelf: ref labelIdentificationChartDesc, labelNeighbor: ref labelIdentificationChartData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelIdentificationChartData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.IdentificationChartData, labelSelf: ref labelIdentificationChartDesc, labelNeighbor: ref labelIdentificationChartData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelExistenceOfNotesDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ExistenceOfNotesDesc, labelSelf: ref labelExistenceOfNotesDesc, labelNeighbor: ref labelExistenceOfNotesData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelExistenceOfNotesData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ExistenceOfNotesData, labelSelf: ref labelExistenceOfNotesDesc, labelNeighbor: ref labelExistenceOfNotesData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelHdNumberDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.HdNumberDesc, labelSelf: ref labelHdNumberDesc, labelNeighbor: ref labelHdNumberData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelHdNumberData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.HdNumberData, labelSelf: ref labelHdNumberDesc, labelNeighbor: ref labelHdNumberData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelBonnerDmDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.BonnerDmDesc, labelSelf: ref labelBonnerDmDesc, labelNeighbor: ref labelBonnerDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelBonnerDmData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.BonnerDmData, labelSelf: ref labelBonnerDmDesc, labelNeighbor: ref labelBonnerDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCordobaDmDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CordobaDmDesc, labelSelf: ref labelCordobaDmDesc, labelNeighbor: ref labelCordobaDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCordobaDmData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CordobaDmData, labelSelf: ref labelCordobaDmDesc, labelNeighbor: ref labelCordobaDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCapePhotographicDmDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CapePhotographicDmDesc, labelSelf: ref labelCapePhotographicDmDesc, labelNeighbor: ref labelCapePhotographicDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCapePhotographicDmData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CapePhotographicDmData, labelSelf: ref labelCapePhotographicDmDesc, labelNeighbor: ref labelCapePhotographicDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelViUsedForReductionsDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ViUsedForReductionsDesc, labelSelf: ref labelViUsedForReductionsDesc, labelNeighbor: ref labelViUsedForReductionsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelViUsedForReductionsData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.ViUsedForReductionsData, labelSelf: ref labelViUsedForReductionsDesc, labelNeighbor: ref labelViUsedForReductionsData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSpectralTypeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SpectralTypeDesc, labelSelf: ref labelSpectralTypeDesc, labelNeighbor: ref labelSpectralTypeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSpectralTypeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SpectralTypeData, labelSelf: ref labelSpectralTypeDesc, labelNeighbor: ref labelSpectralTypeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfSpectralTypeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfSpectralTypeDesc, labelSelf: ref labelSourceOfSpectralTypeDesc, labelNeighbor: ref labelSourceOfSpectralTypeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfSpectralTypeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfSpectralTypeData, labelSelf: ref labelSourceOfSpectralTypeDesc, labelNeighbor: ref labelSourceOfSpectralTypeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void ToolStripButtonGoToIndex_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripTextBoxGoToIndex_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonChangeDataTableStyle_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonChangeHoverEffect_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonFilter_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		#endregion

		#region Leave event handlers

		private void LabelCatalogDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCatalogData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelIdentifierDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelIdentifierData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelProximityFlagDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelProximityFlagData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMagnitudeJohnsonDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMagnitudeJohnsonData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCoarseVariabilityFlagDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCoarseVariabilityFlagData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSourceOfMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSourceOfMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelAlphaDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelAlphaData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelDeltaDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelDeltaData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelReferenceFlagForAstrometryDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelReferenceFlagForAstrometryData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelTrigonomicParallaxDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelTrigonomicParallaxData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelProperMotionAlphaDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelProperMotionAlphaData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelProperMotionDeltaDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelProperMotionDeltaData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorTrigonomicParallaxDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorTrigonomicParallaxData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationDeclinationByRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelPercentageOfRejectedDataDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelPercentageOfRejectedDataData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelGoodnessOfFitParameterDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelGoodnessOfFitParameterData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMeanBtMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMeanBtMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorMeanBtMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorMeanBtMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMeanVtMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMeanVtMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorMeanVtMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorMeanVtMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelJohnsonBvColorDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelJohnsonBvColorData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorJohnsonBvColorDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorJohnsonBvColorData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelReferenceFlagForBtAndVtMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSourceOfBvColorDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSourceOfBvColorData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelColorIndexInCousinsSystemDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelColorIndexInCousinsSystemData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorViDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorViData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSourceOfViDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSourceOfViData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelFlagForCombinedMagnitudesDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelFlagForCombinedMagnitudesData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelVariabilityPeriodDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelVariabilityPeriodData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelVariabilityTypeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelVariabilityTypeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelAdditionalDataAboutVariabilityDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelAdditionalDataAboutVariabilityData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelLightCurveAnnexDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelLightCurveAnnexData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCcdmIdentifierDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCcdmIdentifierData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelHistoricalStatusFlagDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelHistoricalStatusFlagData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelNumberEntriesWithSameCcdmDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelNumberEntriesWithSameCcdmData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelNumberComponentsInThisEntryDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelNumberComponentsInThisEntryData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMultipleSystemsFlagDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMultipleSystemsFlagData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelAstrometricSourceFlagDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelAstrometricSourceFlagData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSolutionQualityDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSolutionQualityData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelComponentIdentifiersDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelComponentIdentifiersData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelPositionAngleBetweenComponentsDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelPositionAngleBetweenComponentsData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelAngularSeparationBetweenComponentsDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelAngularSeparationBetweenComponentsData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorRhoDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorRhoData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelMagnitudeDifferenceBetweenComponentsData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelFlagIndicatingSurveyStarDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelFlagIndicatingSurveyStarData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelIdentificationChartDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelIdentificationChartData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelExistenceOfNotesDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelExistenceOfNotesData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelHdNumberDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelHdNumberData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelBonnerDmDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelBonnerDmData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCordobaDmDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCordobaDmData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCapePhotographicDmDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCapePhotographicDmData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelViUsedForReductionsDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelViUsedForReductionsData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSpectralTypeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSpectralTypeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSourceOfSpectralTypeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelSourceOfSpectralTypeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void ToolStripTextBoxGoToIndex_Leave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region MouseLeave event handlers

		private void MenuitemClose_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripMenuItemInfo_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonStepToBegin_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonStepFastBackward_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonStepBackward_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonStepForward_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonStepFastForward_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonStepToEnd_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void LabelCatalogDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCatalogDesc, labelNeighbor: ref labelCatalogData, color: SystemColors.Control);

		private void LabelCatalogData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCatalogDesc, labelNeighbor: ref labelCatalogData, color: SystemColors.Control);

		private void LabelIdentifierDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelIdentifierDesc, labelNeighbor: ref labelIdentifierData, color: SystemColors.Control);

		private void LabelIdentifierData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelIdentifierDesc, labelNeighbor: ref labelIdentifierData, color: SystemColors.Control);

		private void LabelProximityFlagDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelProximityFlagDesc, labelNeighbor: ref labelProximityFlagData, color: SystemColors.Control);

		private void LabelProximityFlagData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelProximityFlagDesc, labelNeighbor: ref labelProximityFlagData, color: SystemColors.Control);

		private void LabelRightAscensionDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelRightAscensionDesc, labelNeighbor: ref labelRightAscensionData, color: SystemColors.Control);

		private void LabelRightAscensionData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelRightAscensionDesc, labelNeighbor: ref labelRightAscensionData, color: SystemColors.Control);

		private void LabelDeclinationDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelDeclinationDesc, labelNeighbor: ref labelDeclinationData, color: SystemColors.Control);

		private void LabelDeclinationData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelDeclinationDesc, labelNeighbor: ref labelDeclinationData, color: SystemColors.Control);

		private void LabelMagnitudeJohnsonDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMagnitudeJohnsonDesc, labelNeighbor: ref labelMagnitudeJohnsonData, color: SystemColors.Control);

		private void LabelMagnitudeJohnsonData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMagnitudeJohnsonDesc, labelNeighbor: ref labelMagnitudeJohnsonData, color: SystemColors.Control);

		private void LabelCoarseVariabilityFlagDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCoarseVariabilityFlagDesc, labelNeighbor: ref labelCoarseVariabilityFlagData, color: SystemColors.Control);

		private void LabelCoarseVariabilityFlagData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCoarseVariabilityFlagDesc, labelNeighbor: ref labelCoarseVariabilityFlagData, color: SystemColors.Control);

		private void LabelSourceOfMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfMagnitudeDesc, labelNeighbor: ref labelSourceOfMagnitudeData, color: SystemColors.Control);

		private void LabelSourceOfMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfMagnitudeDesc, labelNeighbor: ref labelSourceOfMagnitudeData, color: SystemColors.Control);

		private void LabelAlphaDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAlphaDesc, labelNeighbor: ref labelAlphaData, color: SystemColors.Control);

		private void LabelAlphaData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAlphaDesc, labelNeighbor: ref labelAlphaData, color: SystemColors.Control);

		private void LabelDeltaDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelDeltaDesc, labelNeighbor: ref labelDeltaData, color: SystemColors.Control);

		private void LabelDeltaData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelDeltaDesc, labelNeighbor: ref labelDeltaData, color: SystemColors.Control);

		private void LabelReferenceFlagForAstrometryDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelReferenceFlagForAstrometryDesc, labelNeighbor: ref labelReferenceFlagForAstrometryData, color: SystemColors.Control);

		private void LabelReferenceFlagForAstrometryData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelReferenceFlagForAstrometryDesc, labelNeighbor: ref labelReferenceFlagForAstrometryData, color: SystemColors.Control);

		private void LabelTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelTrigonomicParallaxDesc, labelNeighbor: ref labelTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelTrigonomicParallaxData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelTrigonomicParallaxDesc, labelNeighbor: ref labelTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelProperMotionAlphaDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelProperMotionAlphaDesc, labelNeighbor: ref labelProperMotionAlphaData, color: SystemColors.Control);

		private void LabelProperMotionAlphaData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelProperMotionAlphaDesc, labelNeighbor: ref labelProperMotionAlphaData, color: SystemColors.Control);

		private void LabelProperMotionDeltaDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelProperMotionDeltaDesc, labelNeighbor: ref labelProperMotionDeltaData, color: SystemColors.Control);

		private void LabelProperMotionDeltaData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelProperMotionDeltaDesc, labelNeighbor: ref labelProperMotionDeltaData, color: SystemColors.Control);

		private void LabelStandardErrorRightAscensionDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorRightAscensionDesc, labelNeighbor: ref labelStandardErrorRightAscensionData, color: SystemColors.Control);

		private void LabelStandardErrorRightAscensionData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorRightAscensionDesc, labelNeighbor: ref labelStandardErrorRightAscensionData, color: SystemColors.Control);

		private void LabelStandardErrorDeclinationDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorDeclinationDesc, labelNeighbor: ref labelStandardErrorDeclinationData, color: SystemColors.Control);

		private void LabelStandardErrorDeclinationData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorDeclinationDesc, labelNeighbor: ref labelStandardErrorDeclinationData, color: SystemColors.Control);

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorTrigonomicParallaxDesc, labelNeighbor: ref labelStandardErrorTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelStandardErrorTrigonomicParallaxData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorTrigonomicParallaxDesc, labelNeighbor: ref labelStandardErrorTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorProperMotionRightAscensionDesc, labelNeighbor: ref labelStandardErrorProperMotionRightAscensionData, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorProperMotionRightAscensionDesc, labelNeighbor: ref labelStandardErrorProperMotionRightAscensionData, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorProperMotionDeclinationDesc, labelNeighbor: ref labelStandardErrorProperMotionDeclinationData, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionDeclinationData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorProperMotionDeclinationDesc, labelNeighbor: ref labelStandardErrorProperMotionDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationDeclinationByRightAscensionDesc, labelNeighbor: ref labelCorrelationDeclinationByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationDeclinationByRightAscensionDesc, labelNeighbor: ref labelCorrelationDeclinationByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationTrigonomicParallaxByRightAscensionDesc, labelNeighbor: ref labelCorrelationTrigonomicParallaxByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationTrigonomicParallaxByRightAscensionDesc, labelNeighbor: ref labelCorrelationTrigonomicParallaxByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationTrigonomicParallaxByDeclinationDesc, labelNeighbor: ref labelCorrelationTrigonomicParallaxByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationTrigonomicParallaxByDeclinationDesc, labelNeighbor: ref labelCorrelationTrigonomicParallaxByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.Control);

		private void LabelPercentageOfRejectedDataDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelPercentageOfRejectedDataDesc, labelNeighbor: ref labelPercentageOfRejectedDataData, color: SystemColors.Control);

		private void LabelPercentageOfRejectedDataData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelPercentageOfRejectedDataDesc, labelNeighbor: ref labelPercentageOfRejectedDataData, color: SystemColors.Control);

		private void LabelGoodnessOfFitParameterDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelGoodnessOfFitParameterDesc, labelNeighbor: ref labelGoodnessOfFitParameterData, color: SystemColors.Control);

		private void LabelGoodnessOfFitParameterData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelGoodnessOfFitParameterDesc, labelNeighbor: ref labelGoodnessOfFitParameterData, color: SystemColors.Control);

		private void LabelMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMeanBtMagnitudeDesc, labelNeighbor: ref labelMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMeanBtMagnitudeDesc, labelNeighbor: ref labelMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMeanVtMagnitudeDesc, labelNeighbor: ref labelMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMeanVtMagnitudeDesc, labelNeighbor: ref labelMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelJohnsonBvColorDesc, labelNeighbor: ref labelJohnsonBvColorData, color: SystemColors.Control);

		private void LabelJohnsonBvColorData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelJohnsonBvColorDesc, labelNeighbor: ref labelJohnsonBvColorData, color: SystemColors.Control);

		private void LabelStandardErrorJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorJohnsonBvColorDesc, labelNeighbor: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.Control);

		private void LabelStandardErrorJohnsonBvColorData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorJohnsonBvColorDesc, labelNeighbor: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.Control);

		private void LabelReferenceFlagForBtAndVtMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelReferenceFlagForBtAndVtMagnitudeDesc, labelNeighbor: ref labelReferenceFlagForBtAndVtMagnitudeData, color: SystemColors.Control);

		private void LabelReferenceFlagForBtAndVtMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelReferenceFlagForBtAndVtMagnitudeDesc, labelNeighbor: ref labelReferenceFlagForBtAndVtMagnitudeData, color: SystemColors.Control);

		private void LabelSourceOfBvColorDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfBvColorDesc, labelNeighbor: ref labelSourceOfBvColorData, color: SystemColors.Control);

		private void LabelSourceOfBvColorData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfBvColorDesc, labelNeighbor: ref labelSourceOfBvColorData, color: SystemColors.Control);

		private void LabelColorIndexInCousinsSystemDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelColorIndexInCousinsSystemDesc, labelNeighbor: ref labelColorIndexInCousinsSystemData, color: SystemColors.Control);

		private void LabelColorIndexInCousinsSystemData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelColorIndexInCousinsSystemDesc, labelNeighbor: ref labelColorIndexInCousinsSystemData, color: SystemColors.Control);

		private void LabelStandardErrorViDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorViDesc, labelNeighbor: ref labelStandardErrorViData, color: SystemColors.Control);

		private void LabelStandardErrorViData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorViDesc, labelNeighbor: ref labelStandardErrorViData, color: SystemColors.Control);

		private void LabelSourceOfViDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfViDesc, labelNeighbor: ref labelSourceOfViData, color: SystemColors.Control);

		private void LabelSourceOfViData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfViDesc, labelNeighbor: ref labelSourceOfViData, color: SystemColors.Control);

		private void LabelFlagForCombinedMagnitudesDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelFlagForCombinedMagnitudesDesc, labelNeighbor: ref labelFlagForCombinedMagnitudesData, color: SystemColors.Control);

		private void LabelFlagForCombinedMagnitudesData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelFlagForCombinedMagnitudesDesc, labelNeighbor: ref labelFlagForCombinedMagnitudesData, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelStandardErrorMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelStandardErrorMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelStandardErrorMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelScatterMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelScatterMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelScatterMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelScatterMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelScatterMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelScatterMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelNumberObservationsForMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelNumberObservationsForMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelReferenceFlagForMedianMagnitudeInHipparcosSystemData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemDesc, labelNeighbor: ref labelReferenceFlagForMedianMagnitudeInHipparcosSystemData, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMaximumDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemAtMaximumData, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemAtMaximumData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMaximumDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemAtMaximumData, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMinimumDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemAtMinimumData, color: SystemColors.Control);

		private void LabelMedianMagnitudeInHipparcosSystemAtMinimumData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMedianMagnitudeInHipparcosSystemAtMinimumDesc, labelNeighbor: ref labelMedianMagnitudeInHipparcosSystemAtMinimumData, color: SystemColors.Control);

		private void LabelVariabilityPeriodDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVariabilityPeriodDesc, labelNeighbor: ref labelVariabilityPeriodData, color: SystemColors.Control);

		private void LabelVariabilityPeriodData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVariabilityPeriodDesc, labelNeighbor: ref labelVariabilityPeriodData, color: SystemColors.Control);

		private void LabelVariabilityTypeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVariabilityTypeDesc, labelNeighbor: ref labelVariabilityTypeData, color: SystemColors.Control);

		private void LabelVariabilityTypeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVariabilityTypeDesc, labelNeighbor: ref labelVariabilityTypeData, color: SystemColors.Control);

		private void LabelAdditionalDataAboutVariabilityDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAdditionalDataAboutVariabilityDesc, labelNeighbor: ref labelAdditionalDataAboutVariabilityData, color: SystemColors.Control);

		private void LabelAdditionalDataAboutVariabilityData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAdditionalDataAboutVariabilityDesc, labelNeighbor: ref labelAdditionalDataAboutVariabilityData, color: SystemColors.Control);

		private void LabelLightCurveAnnexDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelLightCurveAnnexDesc, labelNeighbor: ref labelLightCurveAnnexData, color: SystemColors.Control);

		private void LabelLightCurveAnnexData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelLightCurveAnnexDesc, labelNeighbor: ref labelLightCurveAnnexData, color: SystemColors.Control);

		private void LabelCcdmIdentifierDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCcdmIdentifierDesc, labelNeighbor: ref labelCcdmIdentifierData, color: SystemColors.Control);

		private void LabelCcdmIdentifierData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCcdmIdentifierDesc, labelNeighbor: ref labelCcdmIdentifierData, color: SystemColors.Control);

		private void LabelHistoricalStatusFlagDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelHistoricalStatusFlagDesc, labelNeighbor: ref labelHistoricalStatusFlagData, color: SystemColors.Control);

		private void LabelHistoricalStatusFlagData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelHistoricalStatusFlagDesc, labelNeighbor: ref labelHistoricalStatusFlagData, color: SystemColors.Control);

		private void LabelNumberEntriesWithSameCcdmDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberEntriesWithSameCcdmDesc, labelNeighbor: ref labelNumberEntriesWithSameCcdmData, color: SystemColors.Control);

		private void LabelNumberEntriesWithSameCcdmData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberEntriesWithSameCcdmDesc, labelNeighbor: ref labelNumberEntriesWithSameCcdmData, color: SystemColors.Control);

		private void LabelNumberComponentsInThisEntryDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberComponentsInThisEntryDesc, labelNeighbor: ref labelNumberComponentsInThisEntryData, color: SystemColors.Control);

		private void LabelNumberComponentsInThisEntryData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberComponentsInThisEntryDesc, labelNeighbor: ref labelNumberComponentsInThisEntryData, color: SystemColors.Control);

		private void LabelMultipleSystemsFlagDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMultipleSystemsFlagDesc, labelNeighbor: ref labelMultipleSystemsFlagData, color: SystemColors.Control);

		private void LabelMultipleSystemsFlagData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMultipleSystemsFlagDesc, labelNeighbor: ref labelMultipleSystemsFlagData, color: SystemColors.Control);

		private void LabelAstrometricSourceFlagDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAstrometricSourceFlagDesc, labelNeighbor: ref labelAstrometricSourceFlagData, color: SystemColors.Control);

		private void LabelAstrometricSourceFlagData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAstrometricSourceFlagDesc, labelNeighbor: ref labelAstrometricSourceFlagData, color: SystemColors.Control);

		private void LabelSolutionQualityDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSolutionQualityDesc, labelNeighbor: ref labelSolutionQualityData, color: SystemColors.Control);

		private void LabelSolutionQualityData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSolutionQualityDesc, labelNeighbor: ref labelSolutionQualityData, color: SystemColors.Control);

		private void LabelComponentIdentifiersDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelComponentIdentifiersDesc, labelNeighbor: ref labelComponentIdentifiersData, color: SystemColors.Control);

		private void LabelComponentIdentifiersData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelComponentIdentifiersDesc, labelNeighbor: ref labelComponentIdentifiersData, color: SystemColors.Control);

		private void LabelPositionAngleBetweenComponentsDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelPositionAngleBetweenComponentsDesc, labelNeighbor: ref labelPositionAngleBetweenComponentsData, color: SystemColors.Control);

		private void LabelPositionAngleBetweenComponentsData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelPositionAngleBetweenComponentsDesc, labelNeighbor: ref labelPositionAngleBetweenComponentsData, color: SystemColors.Control);

		private void LabelAngularSeparationBetweenComponentsDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAngularSeparationBetweenComponentsDesc, labelNeighbor: ref labelAngularSeparationBetweenComponentsData, color: SystemColors.Control);

		private void LabelAngularSeparationBetweenComponentsData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAngularSeparationBetweenComponentsDesc, labelNeighbor: ref labelAngularSeparationBetweenComponentsData, color: SystemColors.Control);

		private void LabelStandardErrorRhoDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorRhoDesc, labelNeighbor: ref labelStandardErrorRhoData, color: SystemColors.Control);

		private void LabelStandardErrorRhoData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorRhoDesc, labelNeighbor: ref labelStandardErrorRhoData, color: SystemColors.Control);

		private void LabelMagnitudeDifferenceBetweenComponentsDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMagnitudeDifferenceBetweenComponentsDesc, labelNeighbor: ref labelMagnitudeDifferenceBetweenComponentsData, color: SystemColors.Control);

		private void LabelMagnitudeDifferenceBetweenComponentsData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMagnitudeDifferenceBetweenComponentsDesc, labelNeighbor: ref labelMagnitudeDifferenceBetweenComponentsData, color: SystemColors.Control);

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc, labelNeighbor: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsData, color: SystemColors.Control);

		private void LabelStandardErrorMagnitudeDifferenceBetweenComponentsData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsDesc, labelNeighbor: ref labelStandardErrorMagnitudeDifferenceBetweenComponentsData, color: SystemColors.Control);

		private void LabelFlagIndicatingSurveyStarDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelFlagIndicatingSurveyStarDesc, labelNeighbor: ref labelFlagIndicatingSurveyStarData, color: SystemColors.Control);

		private void LabelFlagIndicatingSurveyStarData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelFlagIndicatingSurveyStarDesc, labelNeighbor: ref labelFlagIndicatingSurveyStarData, color: SystemColors.Control);

		private void LabelIdentificationChartDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelIdentificationChartDesc, labelNeighbor: ref labelIdentificationChartData, color: SystemColors.Control);

		private void LabelIdentificationChartData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelIdentificationChartDesc, labelNeighbor: ref labelIdentificationChartData, color: SystemColors.Control);

		private void LabelExistenceOfNotesDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelExistenceOfNotesDesc, labelNeighbor: ref labelExistenceOfNotesData, color: SystemColors.Control);

		private void LabelExistenceOfNotesData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelExistenceOfNotesDesc, labelNeighbor: ref labelExistenceOfNotesData, color: SystemColors.Control);

		private void LabelHdNumberDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelHdNumberDesc, labelNeighbor: ref labelHdNumberData, color: SystemColors.Control);

		private void LabelHdNumberData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelHdNumberDesc, labelNeighbor: ref labelHdNumberData, color: SystemColors.Control);

		private void LabelBonnerDmDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelBonnerDmDesc, labelNeighbor: ref labelBonnerDmData, color: SystemColors.Control);

		private void LabelBonnerDmData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelBonnerDmDesc, labelNeighbor: ref labelBonnerDmData, color: SystemColors.Control);

		private void LabelCordobaDmDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCordobaDmDesc, labelNeighbor: ref labelCordobaDmData, color: SystemColors.Control);

		private void LabelCordobaDmData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCordobaDmDesc, labelNeighbor: ref labelCordobaDmData, color: SystemColors.Control);

		private void LabelCapePhotographicDmDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCapePhotographicDmDesc, labelNeighbor: ref labelCapePhotographicDmData, color: SystemColors.Control);

		private void LabelCapePhotographicDmData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCapePhotographicDmDesc, labelNeighbor: ref labelCapePhotographicDmData, color: SystemColors.Control);

		private void LabelViUsedForReductionsDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelViUsedForReductionsDesc, labelNeighbor: ref labelViUsedForReductionsData, color: SystemColors.Control);

		private void LabelViUsedForReductionsData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelViUsedForReductionsDesc, labelNeighbor: ref labelViUsedForReductionsData, color: SystemColors.Control);

		private void LabelSpectralTypeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSpectralTypeDesc, labelNeighbor: ref labelSpectralTypeData, color: SystemColors.Control);

		private void LabelSpectralTypeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSpectralTypeDesc, labelNeighbor: ref labelSpectralTypeData, color: SystemColors.Control);

		private void LabelSourceOfSpectralTypeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfSpectralTypeDesc, labelNeighbor: ref labelSourceOfSpectralTypeData, color: SystemColors.Control);

		private void LabelSourceOfSpectralTypeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfSpectralTypeDesc, labelNeighbor: ref labelSourceOfSpectralTypeData, color: SystemColors.Control);

		private void ToolStripButtonGoToIndex_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripTextBoxGoToIndex_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonChangeDataTableStyle_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonChangeHoverEffect_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonFilter_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		#endregion

		#region Key* event handlers

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
					break;
				case Keys.Right:
					index++;
					CheckIndexMaximum();
					break;
				case Keys.PageUp:
					index -= 1000;
					CheckIndexMinimum();
					break;
				case Keys.PageDown:
					index += 1000;
					CheckIndexMinimum();
					break;
				case Keys.Home:
					index = 1;
					break;
				case Keys.End:
					index = maxIndex;
					break;
			}
			UpdateIndexLabel();
			ShowEntriesOnIndex();
		}

		#endregion

		private void ToolStripButtonFilter_Click(object sender, EventArgs e)
		{
			using (HipparcosCatalogFilterForm hipparcosCatalogFilterForm = new HipparcosCatalogFilterForm())
			{
				hipparcosCatalogFilterForm.ShowDialog();
			}
		}
	}
}