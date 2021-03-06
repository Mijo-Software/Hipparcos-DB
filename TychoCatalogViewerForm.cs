﻿using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Hipparcos_DB.Properties;

namespace Hipparcos_DB
{
	/// <summary>
	/// TychoCatalogViewerForm : Form
	/// </summary>
	public partial class TychoCatalogViewerForm : Form
	{
		/// <summary>
		/// AstroElement
		/// </summary>
		private enum AstroElement
		{
			None = 0,
			CatalogDesc,
			IdentifierDesc,
			ProximityFlagDesc,
			RightAscensionDesc,
			DeclinationDesc,
			MagnitudeJohnsonDesc,
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
			NumberOfTransitsForAstrometryDesc,
			GoodnessOfFitParameterDesc,
			HipparcosNumberDesc,
			MeanBtMagnitudeDesc,
			StandardErrorMeanBtMagnitudeDesc,
			MeanVtMagnitudeDesc,
			StandardErrorMeanVtMagnitudeDesc,
			SourceOfPhotometryDesc,
			JohnsonBvColorDesc,
			StandardErrorJohnsonBvColorDesc,
			AstrometricQualityFlagDesc,
			SignalToNoiseRatioOfTheStarImageDesc,
			SourceOfAstrometricDataDesc,
			NumberOfTransitsForPhotometryDesc,
			EstimateOfVtmagScatterDesc,
			VtmagAtMaximumDesc,
			VtmagAtMinimumDesc,
			KnownVariabilityFromGcvsNsvDesc,
			VariabilityFromTychoDesc,
			DuplicityFromTychoDesc,
			EpochPhotometryInAnnexDesc,
			CcdmComponentIdentifierDesc,
			PpmAndSupplementDesc,
			HdNumberDesc,
			BonnerDmDesc,
			CordobaDmDesc,
			CapePhotographicDmDesc,
			NotesDesc,
			CatalogData,
			IdentifierData,
			ProximityFlagData,
			RightAscensionData,
			DeclinationData,
			MagnitudeJohnsonData,
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
			NumberOfTransitsForAstrometryData,
			GoodnessOfFitParameterData,
			HipparcosNumberData,
			MeanBtMagnitudeData,
			StandardErrorMeanBtMagnitudeData,
			MeanVtMagnitudeData,
			StandardErrorMeanVtMagnitudeData,
			SourceOfPhotometryData,
			JohnsonBvColorData,
			StandardErrorJohnsonBvColorData,
			AstrometricQualityFlagData,
			SignalToNoiseRatioOfTheStarImageData,
			SourceOfAstrometricDataData,
			NumberOfTransitsForPhotometryData,
			EstimateOfVtmagScatterData,
			VtmagAtMaximumData,
			VtmagAtMinimumData,
			KnownVariabilityFromGcvsNsvData,
			VariabilityFromTychoData,
			DuplicityFromTychoData,
			EpochPhotometryInAnnexData,
			CcdmComponentIdentifierData,
			PpmAndSupplementData,
			HdNumberData,
			BonnerDmData,
			CordobaDmData,
			CapePhotographicDmData,
			NotesData
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
			labelCatalogData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelIdentifierData.Text = catalogEntries[index - 1].Substring(startIndex: 2, length: 12); //.Trim();
			labelProximityFlagData.Text = catalogEntries[index - 1].Substring(startIndex: 15, length: 1); //.Trim();
			labelRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 17, length: 11); //.Trim();
			labelDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 29, length: 11); //.Trim();
			labelMagnitudeJohnsonData.Text = catalogEntries[index - 1].Substring(startIndex: 41, length: 5); //.Trim();
			labelSourceOfMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 47, length: 1); //.Trim();
			labelAlphaData.Text = catalogEntries[index - 1].Substring(startIndex: 51, length: 12); //.Trim();
			labelDeltaData.Text = catalogEntries[index - 1].Substring(startIndex: 64, length: 12); //.Trim();
			labelReferenceFlagForAstrometryData.Text = catalogEntries[index - 1].Substring(startIndex: 77, length: 1); //.Trim();
			labelTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 79, length: 6); //.Trim();
			labelProperMotionAlphaData.Text = catalogEntries[index - 1].Substring(startIndex: 87, length: 7); //.Trim();
			labelProperMotionDeltaData.Text = catalogEntries[index - 1].Substring(startIndex: 96, length: 7); //.Trim();
			labelStandardErrorRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 105, length: 5); //.Trim();
			labelStandardErrorDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 112, length: 5); //.Trim();
			labelStandardErrorTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 119, length: 5); //.Trim();
			labelStandardErrorProperMotionRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 126, length: 5); //.Trim();
			labelStandardErrorProperMotionDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 133, length: 5); //.Trim();
			labelCorrelationDeclinationByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 140, length: 5); //.Trim();
			labelCorrelationTrigonomicParallaxByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 146, length: 5); //.Trim();
			labelCorrelationTrigonomicParallaxByDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 152, length: 5); //.Trim();
			labelCorrelationProperMotionRightAscensionByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 158, length: 5); //.Trim();
			labelCorrelationProperMotionRightAscensionByDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 164, length: 5); //.Trim();
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 170, length: 5); //.Trim();
			labelCorrelationProperMotionDeclinationByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 176, length: 5); //.Trim();
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 182, length: 5); //.Trim();
			labelCorrelationProperMotionDeclinationByDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 188, length: 5); //.Trim();
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 194, length: 5); //.Trim();
			labelNumberOfTransitsForAstrometryData.Text = catalogEntries[index - 1].Substring(startIndex: 200, length: 3); //.Trim();
			labelGoodnessOfFitParameterData.Text = catalogEntries[index - 1].Substring(startIndex: 204, length: 5); //.Trim();
			labelHipparcosNumberData.Text = catalogEntries[index - 1].Substring(startIndex: 210, length: 6); //.Trim();
			labelMeanBtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 217, length: 6); //.Trim();
			labelStandardErrorMeanBtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 224, length: 5); //.Trim();
			labelMeanVtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 230, length: 6); //.Trim();
			labelStandardErrorMeanVtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 237, length: 5); //.Trim();
			labelSourceOfPhotometryData.Text = catalogEntries[index - 1].Substring(startIndex: 243, length: 1); //.Trim();
			labelJohnsonBvColorData.Text = catalogEntries[index - 1].Substring(startIndex: 245, length: 6); //.Trim();
			labelStandardErrorJohnsonBvColorData.Text = catalogEntries[index - 1].Substring(startIndex: 252, length: 5); //.Trim();
			labelAstrometricQualityFlagData.Text = catalogEntries[index - 1].Substring(startIndex: 260, length: 1); //.Trim();
			labelSignalToNoiseRatioOfTheStarImageData.Text = catalogEntries[index - 1].Substring(startIndex: 262, length: 4); //.Trim();
			labelSourceOfAstrometricDataData.Text = catalogEntries[index - 1].Substring(startIndex: 267, length: 1); //.Trim();
			labelNumberOfTransitsForPhotometryData.Text = catalogEntries[index - 1].Substring(startIndex: 269, length: 3); //.Trim();
			labelEstimateOfVtmagScatterData.Text = catalogEntries[index - 1].Substring(startIndex: 273, length: 5); //.Trim();
			labelVtmagAtMaximumData.Text = catalogEntries[index - 1].Substring(startIndex: 279, length: 5); //.Trim();
			labelVtmagAtMinimumData.Text = catalogEntries[index - 1].Substring(startIndex: 285, length: 5); //.Trim();
			labelKnownVariabilityFromGcvsNsvData.Text = catalogEntries[index - 1].Substring(startIndex: 291, length: 1); //.Trim();
			labelVariabilityFromTychoData.Text = catalogEntries[index - 1].Substring(startIndex: 293, length: 1); //.Trim();
			labelDuplicityFromTychoData.Text = catalogEntries[index - 1].Substring(startIndex: 295, length: 1); //.Trim();
			labelEpochPhotometryInAnnexData.Text = catalogEntries[index - 1].Substring(startIndex: 297, length: 1); //.Trim();
			labelCcdmComponentIdentifierData.Text = catalogEntries[index - 1].Substring(startIndex: 299, length: 2).Trim();
			labelPpmAndSupplementData.Text = catalogEntries[index - 1].Substring(startIndex: 302, length: 6); //.Trim();
			labelHdNumberData.Text = catalogEntries[index - 1].Substring(startIndex: 309, length: 6); //.Trim();
			labelBonnerDmData.Text = catalogEntries[index - 1].Substring(startIndex: 316, length: 10).Trim();
			labelCordobaDmData.Text = catalogEntries[index - 1].Substring(startIndex: 327, length: 10); //.Trim();
			labelCapePhotographicDmData.Text = catalogEntries[index - 1].Substring(startIndex: 338, length: 10); //.Trim();
			labelNotesData.Text = catalogEntries[index - 1].Substring(startIndex: 349, length: 1); //.Trim();
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
		public TychoCatalogViewerForm()
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
		private void TychoCatalogViewerForm_Load(object sender, EventArgs e)
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
		private void TychoCatalogViewerForm_FormClosing(object sender, FormClosingEventArgs e) => settings.Save();

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
			string dataFile = settings.UserHipparcosCatalogDirectory + "tyc_main.dat";
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

		private void ToolStripButtonGoToIndex_Click(object sender, EventArgs e) => GoToIndex();

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
				case (uint)AstroElement.None: break;
				case (uint)AstroElement.CatalogDesc: CopyToClipboard(text: labelCatalogDesc.Text); break;
				case (uint)AstroElement.IdentifierDesc: CopyToClipboard(text: labelIdentifierDesc.Text); break;
				case (uint)AstroElement.ProximityFlagDesc: CopyToClipboard(text: labelProximityFlagDesc.Text); break;
				case (uint)AstroElement.RightAscensionDesc: CopyToClipboard(text: labelRightAscensionDesc.Text); break;
				case (uint)AstroElement.DeclinationDesc: CopyToClipboard(text: labelDeclinationDesc.Text); break;
				case (uint)AstroElement.MagnitudeJohnsonDesc: CopyToClipboard(text: labelMagnitudeJohnsonDesc.Text); break;
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
				case (uint)AstroElement.NumberOfTransitsForAstrometryDesc: CopyToClipboard(text: labelNumberOfTransitsForAstrometryDesc.Text); break;
				case (uint)AstroElement.GoodnessOfFitParameterDesc: CopyToClipboard(text: labelGoodnessOfFitParameterDesc.Text); break;
				case (uint)AstroElement.HipparcosNumberDesc: CopyToClipboard(text: labelHipparcosNumberDesc.Text); break;
				case (uint)AstroElement.MeanBtMagnitudeDesc: CopyToClipboard(text: labelMeanBtMagnitudeDesc.Text); break;
				case (uint)AstroElement.StandardErrorMeanBtMagnitudeDesc: CopyToClipboard(text: labelStandardErrorMeanBtMagnitudeDesc.Text); break;
				case (uint)AstroElement.MeanVtMagnitudeDesc: CopyToClipboard(text: labelMeanVtMagnitudeDesc.Text); break;
				case (uint)AstroElement.StandardErrorMeanVtMagnitudeDesc: CopyToClipboard(text: labelStandardErrorMeanVtMagnitudeDesc.Text); break;
				case (uint)AstroElement.SourceOfPhotometryDesc: CopyToClipboard(text: labelSourceOfPhotometryDesc.Text); break;
				case (uint)AstroElement.JohnsonBvColorDesc: CopyToClipboard(text: labelJohnsonBvColorDesc.Text); break;
				case (uint)AstroElement.StandardErrorJohnsonBvColorDesc: CopyToClipboard(text: labelStandardErrorJohnsonBvColorDesc.Text); break;
				case (uint)AstroElement.AstrometricQualityFlagDesc: CopyToClipboard(text: labelAstrometricQualityFlagDesc.Text); break;
				case (uint)AstroElement.SignalToNoiseRatioOfTheStarImageDesc: CopyToClipboard(text: labelSignalToNoiseRatioOfTheStarImageDesc.Text); break;
				case (uint)AstroElement.SourceOfAstrometricDataDesc: CopyToClipboard(text: labelSourceOfAstrometricDataDesc.Text); break;
				case (uint)AstroElement.NumberOfTransitsForPhotometryDesc: CopyToClipboard(text: labelNumberOfTransitsForPhotometryDesc.Text); break;
				case (uint)AstroElement.EstimateOfVtmagScatterDesc: CopyToClipboard(text: labelEstimateOfVtmagScatterDesc.Text); break;
				case (uint)AstroElement.VtmagAtMaximumDesc: CopyToClipboard(text: labelVtmagAtMaximumDesc.Text); break;
				case (uint)AstroElement.VtmagAtMinimumDesc: CopyToClipboard(text: labelVtmagAtMinimumDesc.Text); break;
				case (uint)AstroElement.KnownVariabilityFromGcvsNsvDesc: CopyToClipboard(text: labelKnownVariabilityFromGcvsNsvDesc.Text); break;
				case (uint)AstroElement.VariabilityFromTychoDesc: CopyToClipboard(text: labelVariabilityFromTychoDesc.Text); break;
				case (uint)AstroElement.DuplicityFromTychoDesc: CopyToClipboard(text: labelDuplicityFromTychoDesc.Text); break;
				case (uint)AstroElement.EpochPhotometryInAnnexDesc: CopyToClipboard(text: labelEpochPhotometryInAnnexDesc.Text); break;
				case (uint)AstroElement.CcdmComponentIdentifierDesc: CopyToClipboard(text: labelCcdmComponentIdentifierDesc.Text); break;
				case (uint)AstroElement.PpmAndSupplementDesc: CopyToClipboard(text: labelPpmAndSupplementDesc.Text); break;
				case (uint)AstroElement.HdNumberDesc: CopyToClipboard(text: labelHdNumberDesc.Text); break;
				case (uint)AstroElement.BonnerDmDesc: CopyToClipboard(text: labelBonnerDmDesc.Text); break;
				case (uint)AstroElement.CordobaDmDesc: CopyToClipboard(text: labelCordobaDmDesc.Text); break;
				case (uint)AstroElement.CapePhotographicDmDesc: CopyToClipboard(text: labelCapePhotographicDmDesc.Text); break;
				case (uint)AstroElement.NotesDesc: CopyToClipboard(text: labelNotesDesc.Text); break;
				case (uint)AstroElement.CatalogData: CopyToClipboard(text: labelCatalogData.Text); break;
				case (uint)AstroElement.IdentifierData: CopyToClipboard(text: labelIdentifierData.Text); break;
				case (uint)AstroElement.ProximityFlagData: CopyToClipboard(text: labelProximityFlagData.Text); break;
				case (uint)AstroElement.RightAscensionData: CopyToClipboard(text: labelRightAscensionData.Text); break;
				case (uint)AstroElement.DeclinationData: CopyToClipboard(text: labelDeclinationData.Text); break;
				case (uint)AstroElement.MagnitudeJohnsonData: CopyToClipboard(text: labelMagnitudeJohnsonData.Text); break;
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
				case (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByDeclinationData.Text); break;
				case (uint)AstroElement.CorrelationProperMotionDeclinationByProperMotionRightAscensionData: CopyToClipboard(text: labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.Text); break;
				case (uint)AstroElement.NumberOfTransitsForAstrometryData: CopyToClipboard(text: labelNumberOfTransitsForAstrometryData.Text); break;
				case (uint)AstroElement.GoodnessOfFitParameterData: CopyToClipboard(text: labelGoodnessOfFitParameterData.Text); break;
				case (uint)AstroElement.HipparcosNumberData: CopyToClipboard(text: labelHipparcosNumberData.Text); break;
				case (uint)AstroElement.MeanBtMagnitudeData: CopyToClipboard(text: labelMeanBtMagnitudeData.Text); break;
				case (uint)AstroElement.StandardErrorMeanBtMagnitudeData: CopyToClipboard(text: labelStandardErrorMeanBtMagnitudeData.Text); break;
				case (uint)AstroElement.MeanVtMagnitudeData: CopyToClipboard(text: labelMeanVtMagnitudeData.Text); break;
				case (uint)AstroElement.StandardErrorMeanVtMagnitudeData: CopyToClipboard(text: labelStandardErrorMeanVtMagnitudeData.Text); break;
				case (uint)AstroElement.SourceOfPhotometryData: CopyToClipboard(text: labelSourceOfPhotometryData.Text); break;
				case (uint)AstroElement.JohnsonBvColorData: CopyToClipboard(text: labelJohnsonBvColorData.Text); break;
				case (uint)AstroElement.StandardErrorJohnsonBvColorData: CopyToClipboard(text: labelStandardErrorJohnsonBvColorData.Text); break;
				case (uint)AstroElement.AstrometricQualityFlagData: CopyToClipboard(text: labelAstrometricQualityFlagData.Text); break;
				case (uint)AstroElement.SignalToNoiseRatioOfTheStarImageData: CopyToClipboard(text: labelSignalToNoiseRatioOfTheStarImageData.Text); break;
				case (uint)AstroElement.SourceOfAstrometricDataData: CopyToClipboard(text: labelSourceOfAstrometricDataData.Text); break;
				case (uint)AstroElement.NumberOfTransitsForPhotometryData: CopyToClipboard(text: labelNumberOfTransitsForPhotometryData.Text); break;
				case (uint)AstroElement.EstimateOfVtmagScatterData: CopyToClipboard(text: labelEstimateOfVtmagScatterData.Text); break;
				case (uint)AstroElement.VtmagAtMaximumData: CopyToClipboard(text: labelVtmagAtMaximumData.Text); break;
				case (uint)AstroElement.VtmagAtMinimumData: CopyToClipboard(text: labelVtmagAtMinimumData.Text); break;
				case (uint)AstroElement.KnownVariabilityFromGcvsNsvData: CopyToClipboard(text: labelKnownVariabilityFromGcvsNsvData.Text); break;
				case (uint)AstroElement.VariabilityFromTychoData: CopyToClipboard(text: labelVariabilityFromTychoData.Text); break;
				case (uint)AstroElement.DuplicityFromTychoData: CopyToClipboard(text: labelDuplicityFromTychoData.Text); break;
				case (uint)AstroElement.EpochPhotometryInAnnexData: CopyToClipboard(text: labelEpochPhotometryInAnnexData.Text); break;
				case (uint)AstroElement.CcdmComponentIdentifierData: CopyToClipboard(text: labelCcdmComponentIdentifierData.Text); break;
				case (uint)AstroElement.PpmAndSupplementData: CopyToClipboard(text: labelPpmAndSupplementData.Text); break;
				case (uint)AstroElement.HdNumberData: CopyToClipboard(text: labelHdNumberData.Text); break;
				case (uint)AstroElement.BonnerDmData: CopyToClipboard(text: labelBonnerDmData.Text); break;
				case (uint)AstroElement.CordobaDmData: CopyToClipboard(text: labelCordobaDmData.Text); break;
				case (uint)AstroElement.CapePhotographicDmData: CopyToClipboard(text: labelCapePhotographicDmData.Text); break;
				case (uint)AstroElement.NotesData: CopyToClipboard(text: labelNotesData.Text); break;
				default: break;
			}
		}

		private void ToolStripButtonChangeDataTableStyle_Click(object sender, EventArgs e)
		{
			if (tableLayoutPanel.CellBorderStyle == TableLayoutPanelCellBorderStyle.InsetDouble)
			{
				tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
				settings.UserDataTableStyle = 0;
			}
			else if (tableLayoutPanel.CellBorderStyle == TableLayoutPanelCellBorderStyle.OutsetDouble)
			{
				tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
				settings.UserDataTableStyle = 1;
			}
		}

		private void ToolStripButtonChangeHoverEffect_Click(object sender, EventArgs e)
		{
			toolStripButtonChangeHoverEffect.Checked = !toolStripButtonChangeHoverEffect.Checked;
			settings.UserEnableHoverEffect = !settings.UserEnableHoverEffect;
			if (toolStripButtonChangeHoverEffect.Checked)
			{
				toolStripButtonChangeHoverEffect.Image = Resources.fugue_table_select_row_16px_shadowless;
			}
			else if (!toolStripButtonChangeHoverEffect.Checked)
			{
				toolStripButtonChangeHoverEffect.Image = Resources.fugue_table_16px_shadowless;
			}
		}

		private void ProgressBar_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				owner: this,
				text: Resources.jokeLoadingText,
				caption: Resources.jokeLoadingTitle,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Exclamation,
				defaultButton: MessageBoxDefaultButton.Button1,
				options: MessageBoxOptions.DefaultDesktopOnly);
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

		private void LabelRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.RightAscensionDesc, labelSelf: ref labelRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.RightAscensionData, labelSelf: ref labelRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelDeclinationDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.DeclinationDesc, labelSelf: ref labelDeclinationDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelDeclinationData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.DeclinationData, labelSelf: ref labelDeclinationData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMagnitudeJohnsonDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeJohnsonDesc, labelSelf: ref labelMagnitudeJohnsonDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMagnitudeJohnsonData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MagnitudeJohnsonData, labelSelf: ref labelMagnitudeJohnsonData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfMagnitudeDesc, labelSelf: ref labelSourceOfMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfMagnitudeData, labelSelf: ref labelSourceOfMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAlphaDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AlphaDesc, labelSelf: ref labelAlphaDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAlphaData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AlphaData, labelSelf: ref labelAlphaData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelDeltaDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.DeltaDesc, labelSelf: ref labelDeltaDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

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

		private void LabelCorrelationDeclinationByRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationDeclinationByRightAscensionDesc, labelSelf: ref labelCorrelationDeclinationByRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationDeclinationByRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationDeclinationByRightAscensionData, labelSelf: ref labelCorrelationDeclinationByRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

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

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxData, labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationData, labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByProperMotionRightAscensionData, labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberOfTransitsForAstrometryDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberOfTransitsForAstrometryDesc, labelSelf: ref labelNumberOfTransitsForAstrometryDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberOfTransitsForAstrometryData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberOfTransitsForAstrometryData, labelSelf: ref labelNumberOfTransitsForAstrometryData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelGoodnessOfFitParameterDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.GoodnessOfFitParameterDesc, labelSelf: ref labelGoodnessOfFitParameterDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelGoodnessOfFitParameterData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.GoodnessOfFitParameterData, labelSelf: ref labelGoodnessOfFitParameterData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelHipparcosNumberDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.HipparcosNumberDesc, labelSelf: ref labelHipparcosNumberDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelHipparcosNumberData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.HipparcosNumberData, labelSelf: ref labelHipparcosNumberData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMeanBtMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MeanBtMagnitudeDesc, labelSelf: ref labelMeanBtMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMeanBtMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MeanBtMagnitudeData, labelSelf: ref labelMeanBtMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMeanBtMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanBtMagnitudeDesc, labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMeanBtMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanBtMagnitudeData, labelSelf: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMeanVtMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MeanVtMagnitudeDesc, labelSelf: ref labelMeanVtMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelMeanVtMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.MeanVtMagnitudeData, labelSelf: ref labelMeanVtMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMeanVtMagnitudeDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeDesc, labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorMeanVtMagnitudeData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeData, labelSelf: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfPhotometryDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfPhotometryDesc, labelSelf: ref labelSourceOfPhotometryDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfPhotometryData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfPhotometryData, labelSelf: ref labelSourceOfPhotometryData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelJohnsonBvColorDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.JohnsonBvColorDesc, labelSelf: ref labelJohnsonBvColorDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelJohnsonBvColorData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.JohnsonBvColorData, labelSelf: ref labelJohnsonBvColorData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorJohnsonBvColorDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorJohnsonBvColorDesc, labelSelf: ref labelStandardErrorJohnsonBvColorDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelStandardErrorJohnsonBvColorData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorJohnsonBvColorData, labelSelf: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAstrometricQualityFlagDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AstrometricQualityFlagDesc, labelSelf: ref labelAstrometricQualityFlagDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelAstrometricQualityFlagData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.AstrometricQualityFlagData, labelSelf: ref labelAstrometricQualityFlagData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSignalToNoiseRatioOfTheStarImageDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SignalToNoiseRatioOfTheStarImageDesc, labelSelf: ref labelSignalToNoiseRatioOfTheStarImageDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSignalToNoiseRatioOfTheStarImageData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SignalToNoiseRatioOfTheStarImageData, labelSelf: ref labelSignalToNoiseRatioOfTheStarImageData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfAstrometricDataDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfAstrometricDataDesc, labelSelf: ref labelSourceOfAstrometricDataDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelSourceOfAstrometricDataData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfAstrometricDataData, labelSelf: ref labelSourceOfAstrometricDataData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberOfTransitsForPhotometryDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberOfTransitsForPhotometryDesc, labelSelf: ref labelNumberOfTransitsForPhotometryDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNumberOfTransitsForPhotometryData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NumberOfTransitsForPhotometryData, labelSelf: ref labelNumberOfTransitsForPhotometryData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelEstimateOfVtmagScatterDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.EstimateOfVtmagScatterDesc, labelSelf: ref labelEstimateOfVtmagScatterDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelEstimateOfVtmagScatterData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.EstimateOfVtmagScatterData, labelSelf: ref labelEstimateOfVtmagScatterData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVtmagAtMaximumDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VtmagAtMaximumDesc, labelSelf: ref labelVtmagAtMaximumDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVtmagAtMaximumData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VtmagAtMaximumData, labelSelf: ref labelVtmagAtMaximumData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVtmagAtMinimumDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VtmagAtMinimumDesc, labelSelf: ref labelVtmagAtMinimumDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVtmagAtMinimumData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VtmagAtMinimumData, labelSelf: ref labelVtmagAtMinimumData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelKnownVariabilityFromGcvsNsvDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.KnownVariabilityFromGcvsNsvDesc, labelSelf: ref labelKnownVariabilityFromGcvsNsvDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelKnownVariabilityFromGcvsNsvData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.KnownVariabilityFromGcvsNsvData, labelSelf: ref labelKnownVariabilityFromGcvsNsvData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVariabilityFromTychoDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityFromTychoDesc, labelSelf: ref labelVariabilityFromTychoDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelVariabilityFromTychoData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityFromTychoData, labelSelf: ref labelVariabilityFromTychoData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelDuplicityFromTychoDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.DuplicityFromTychoDesc, labelSelf: ref labelDuplicityFromTychoDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelDuplicityFromTychoData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.DuplicityFromTychoData, labelSelf: ref labelDuplicityFromTychoData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelEpochPhotometryInAnnexDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.EpochPhotometryInAnnexDesc, labelSelf: ref labelEpochPhotometryInAnnexDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelEpochPhotometryInAnnexData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.EpochPhotometryInAnnexData, labelSelf: ref labelEpochPhotometryInAnnexData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCcdmComponentIdentifierDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CcdmComponentIdentifierDesc, labelSelf: ref labelCcdmComponentIdentifierDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCcdmComponentIdentifierData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CcdmComponentIdentifierData, labelSelf: ref labelCcdmComponentIdentifierData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelPpmAndSupplementDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.PpmAndSupplementDesc, labelSelf: ref labelPpmAndSupplementDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelPpmAndSupplementData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.PpmAndSupplementData, labelSelf: ref labelPpmAndSupplementData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelHdNumberDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.HdNumberDesc, labelSelf: ref labelHdNumberDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelHdNumberData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.HdNumberData, labelSelf: ref labelHdNumberData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelBonnerDmDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.BonnerDmDesc, labelSelf: ref labelBonnerDmDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelBonnerDmData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.BonnerDmData, labelSelf: ref labelBonnerDmData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCordobaDmDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CordobaDmDesc, labelSelf: ref labelCordobaDmDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCordobaDmData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CordobaDmData, labelSelf: ref labelCordobaDmData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCapePhotographicDmDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CapePhotographicDmDesc, labelSelf: ref labelCapePhotographicDmDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelCapePhotographicDmData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.CapePhotographicDmData, labelSelf: ref labelCapePhotographicDmData, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNotesDesc_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NotesDesc, labelSelf: ref labelNotesDesc, color: SystemColors.ControlLightLight, sender: sender, e: e);

		private void LabelNotesData_Enter(object sender, EventArgs e) => SetColorSelfAndSetStatusbar(astroElemId: (uint)AstroElement.NotesData, labelSelf: ref labelNotesData, color: SystemColors.ControlLightLight, sender: sender, e: e);

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

		private void ToolStripButtonGoToIndex_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripTextBoxGoToIndex_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonChangeDataTableStyle_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

		private void ToolStripButtonChangeHoverEffect_MouseEnter(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

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

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByTrigonomicParallaxData, labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByDeclinationData, labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CorrelationProperMotionDeclinationByProperMotionRightAscensionData, labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberOfTransitsForAstrometryDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberOfTransitsForAstrometryDesc, labelSelf: ref labelNumberOfTransitsForAstrometryDesc, labelNeighbor: ref labelNumberOfTransitsForAstrometryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberOfTransitsForAstrometryData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberOfTransitsForAstrometryData, labelSelf: ref labelNumberOfTransitsForAstrometryDesc, labelNeighbor: ref labelNumberOfTransitsForAstrometryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelGoodnessOfFitParameterDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.GoodnessOfFitParameterDesc, labelSelf: ref labelGoodnessOfFitParameterDesc, labelNeighbor: ref labelGoodnessOfFitParameterData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelGoodnessOfFitParameterData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.GoodnessOfFitParameterData, labelSelf: ref labelGoodnessOfFitParameterDesc, labelNeighbor: ref labelGoodnessOfFitParameterData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelHipparcosNumberDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.HipparcosNumberDesc, labelSelf: ref labelHipparcosNumberDesc, labelNeighbor: ref labelHipparcosNumberData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelHipparcosNumberData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.HipparcosNumberData, labelSelf: ref labelHipparcosNumberDesc, labelNeighbor: ref labelHipparcosNumberData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MeanBtMagnitudeDesc, labelSelf: ref labelMeanBtMagnitudeDesc, labelNeighbor: ref labelMeanBtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MeanBtMagnitudeData, labelSelf: ref labelMeanBtMagnitudeDesc, labelNeighbor: ref labelMeanBtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanBtMagnitudeDesc, labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMeanBtMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanBtMagnitudeData, labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MeanVtMagnitudeDesc, labelSelf: ref labelMeanVtMagnitudeDesc, labelNeighbor: ref labelMeanVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.MeanVtMagnitudeData, labelSelf: ref labelMeanVtMagnitudeDesc, labelNeighbor: ref labelMeanVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeDesc, labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorMeanVtMagnitudeData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorMeanVtMagnitudeData, labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfPhotometryDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfPhotometryDesc, labelSelf: ref labelSourceOfPhotometryDesc, labelNeighbor: ref labelSourceOfPhotometryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfPhotometryData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfPhotometryData, labelSelf: ref labelSourceOfPhotometryDesc, labelNeighbor: ref labelSourceOfPhotometryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.JohnsonBvColorDesc, labelSelf: ref labelJohnsonBvColorDesc, labelNeighbor: ref labelJohnsonBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelJohnsonBvColorData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.JohnsonBvColorData, labelSelf: ref labelJohnsonBvColorDesc, labelNeighbor: ref labelJohnsonBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorJohnsonBvColorDesc, labelSelf: ref labelStandardErrorJohnsonBvColorDesc, labelNeighbor: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelStandardErrorJohnsonBvColorData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.StandardErrorJohnsonBvColorData, labelSelf: ref labelStandardErrorJohnsonBvColorDesc, labelNeighbor: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAstrometricQualityFlagDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AstrometricQualityFlagDesc, labelSelf: ref labelAstrometricQualityFlagDesc, labelNeighbor: ref labelAstrometricQualityFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelAstrometricQualityFlagData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.AstrometricQualityFlagData, labelSelf: ref labelAstrometricQualityFlagDesc, labelNeighbor: ref labelAstrometricQualityFlagData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSignalToNoiseRatioOfTheStarImageDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SignalToNoiseRatioOfTheStarImageDesc, labelSelf: ref labelSignalToNoiseRatioOfTheStarImageDesc, labelNeighbor: ref labelSignalToNoiseRatioOfTheStarImageData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSignalToNoiseRatioOfTheStarImageData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SignalToNoiseRatioOfTheStarImageData, labelSelf: ref labelSignalToNoiseRatioOfTheStarImageDesc, labelNeighbor: ref labelSignalToNoiseRatioOfTheStarImageData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfAstrometricDataDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfAstrometricDataDesc, labelSelf: ref labelSourceOfAstrometricDataDesc, labelNeighbor: ref labelSourceOfAstrometricDataData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelSourceOfAstrometricDataData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.SourceOfAstrometricDataData, labelSelf: ref labelSourceOfAstrometricDataDesc, labelNeighbor: ref labelSourceOfAstrometricDataData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberOfTransitsForPhotometryDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberOfTransitsForPhotometryDesc, labelSelf: ref labelNumberOfTransitsForPhotometryDesc, labelNeighbor: ref labelNumberOfTransitsForPhotometryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNumberOfTransitsForPhotometryData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NumberOfTransitsForPhotometryData, labelSelf: ref labelNumberOfTransitsForPhotometryDesc, labelNeighbor: ref labelNumberOfTransitsForPhotometryData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelEstimateOfVtmagScatterDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.EstimateOfVtmagScatterDesc, labelSelf: ref labelEstimateOfVtmagScatterDesc, labelNeighbor: ref labelEstimateOfVtmagScatterData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelEstimateOfVtmagScatterData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.EstimateOfVtmagScatterData, labelSelf: ref labelEstimateOfVtmagScatterDesc, labelNeighbor: ref labelEstimateOfVtmagScatterData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVtmagAtMaximumDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VtmagAtMaximumDesc, labelSelf: ref labelVtmagAtMaximumDesc, labelNeighbor: ref labelVtmagAtMaximumData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVtmagAtMaximumData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VtmagAtMaximumData, labelSelf: ref labelVtmagAtMaximumDesc, labelNeighbor: ref labelVtmagAtMaximumData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVtmagAtMinimumDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VtmagAtMinimumDesc, labelSelf: ref labelVtmagAtMinimumDesc, labelNeighbor: ref labelVtmagAtMinimumData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVtmagAtMinimumData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VtmagAtMinimumData, labelSelf: ref labelVtmagAtMinimumDesc, labelNeighbor: ref labelVtmagAtMinimumData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelKnownVariabilityFromGcvsNsvDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.KnownVariabilityFromGcvsNsvDesc, labelSelf: ref labelKnownVariabilityFromGcvsNsvDesc, labelNeighbor: ref labelKnownVariabilityFromGcvsNsvData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelKnownVariabilityFromGcvsNsvData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.KnownVariabilityFromGcvsNsvData, labelSelf: ref labelKnownVariabilityFromGcvsNsvDesc, labelNeighbor: ref labelKnownVariabilityFromGcvsNsvData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVariabilityFromTychoDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityFromTychoDesc, labelSelf: ref labelVariabilityFromTychoDesc, labelNeighbor: ref labelVariabilityFromTychoData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelVariabilityFromTychoData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.VariabilityFromTychoData, labelSelf: ref labelVariabilityFromTychoDesc, labelNeighbor: ref labelVariabilityFromTychoData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelDuplicityFromTychoDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.DuplicityFromTychoDesc, labelSelf: ref labelDuplicityFromTychoDesc, labelNeighbor: ref labelDuplicityFromTychoData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelDuplicityFromTychoData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.DuplicityFromTychoData, labelSelf: ref labelDuplicityFromTychoDesc, labelNeighbor: ref labelDuplicityFromTychoData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelEpochPhotometryInAnnexDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.EpochPhotometryInAnnexDesc, labelSelf: ref labelEpochPhotometryInAnnexDesc, labelNeighbor: ref labelEpochPhotometryInAnnexData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelEpochPhotometryInAnnexData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.EpochPhotometryInAnnexData, labelSelf: ref labelEpochPhotometryInAnnexDesc, labelNeighbor: ref labelEpochPhotometryInAnnexData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCcdmComponentIdentifierDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CcdmComponentIdentifierDesc, labelSelf: ref labelCcdmComponentIdentifierDesc, labelNeighbor: ref labelCcdmComponentIdentifierData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCcdmComponentIdentifierData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CcdmComponentIdentifierData, labelSelf: ref labelCcdmComponentIdentifierDesc, labelNeighbor: ref labelCcdmComponentIdentifierData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelPpmAndSupplementDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.PpmAndSupplementDesc, labelSelf: ref labelPpmAndSupplementDesc, labelNeighbor: ref labelPpmAndSupplementData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelPpmAndSupplementData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.PpmAndSupplementData, labelSelf: ref labelPpmAndSupplementDesc, labelNeighbor: ref labelPpmAndSupplementData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelHdNumberDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.HdNumberDesc, labelSelf: ref labelHdNumberDesc, labelNeighbor: ref labelHdNumberData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelHdNumberData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.HdNumberData, labelSelf: ref labelHdNumberDesc, labelNeighbor: ref labelHdNumberData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelBonnerDmDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.BonnerDmDesc, labelSelf: ref labelBonnerDmDesc, labelNeighbor: ref labelBonnerDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelBonnerDmData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.BonnerDmData, labelSelf: ref labelBonnerDmDesc, labelNeighbor: ref labelBonnerDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCordobaDmDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CordobaDmDesc, labelSelf: ref labelCordobaDmDesc, labelNeighbor: ref labelCordobaDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCordobaDmData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CordobaDmData, labelSelf: ref labelCordobaDmDesc, labelNeighbor: ref labelCordobaDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCapePhotographicDmDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CapePhotographicDmDesc, labelSelf: ref labelCapePhotographicDmDesc, labelNeighbor: ref labelCapePhotographicDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelCapePhotographicDmData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.CapePhotographicDmData, labelSelf: ref labelCapePhotographicDmDesc, labelNeighbor: ref labelCapePhotographicDmData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNotesDesc_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NotesDesc, labelSelf: ref labelNotesDesc, labelNeighbor: ref labelNotesData, color: SystemColors.ControlLight, sender: sender, e: e);

		private void LabelNotesData_MouseEnter(object sender, EventArgs e) => SetColorSelfAndNeighborAndSetStatusbar(astroElemId: (uint)AstroElement.NotesData, labelSelf: ref labelNotesDesc, labelNeighbor: ref labelNotesData, color: SystemColors.ControlLight, sender: sender, e: e);

		#endregion

		#region Leave event handlers

		private void LabelCatalogDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogDesc, color: SystemColors.Control);

		private void LabelCatalogData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCatalogData, color: SystemColors.Control);

		private void LabelIdentifierDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelIdentifierDesc, color: SystemColors.Control);

		private void LabelIdentifierData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelIdentifierData, color: SystemColors.Control);

		private void LabelProximityFlagDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelProximityFlagDesc, color: SystemColors.Control);

		private void LabelProximityFlagData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelProximityFlagData, color: SystemColors.Control);

		private void LabelRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelRightAscensionDesc, color: SystemColors.Control);

		private void LabelRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelRightAscensionData, color: SystemColors.Control);

		private void LabelDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelDeclinationDesc, color: SystemColors.Control);

		private void LabelDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelDeclinationData, color: SystemColors.Control);

		private void LabelMagnitudeJohnsonDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelMagnitudeJohnsonDesc, color: SystemColors.Control);

		private void LabelMagnitudeJohnsonData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelMagnitudeJohnsonData, color: SystemColors.Control);

		private void LabelSourceOfMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelSourceOfMagnitudeDesc, color: SystemColors.Control);

		private void LabelSourceOfMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelSourceOfMagnitudeData, color: SystemColors.Control);

		private void LabelAlphaDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelAlphaDesc, color: SystemColors.Control);

		private void LabelAlphaData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelAlphaData, color: SystemColors.Control);

		private void LabelDeltaDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelDeltaDesc, color: SystemColors.Control);

		private void LabelDeltaData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelDeltaData, color: SystemColors.Control);

		private void LabelReferenceFlagForAstrometryDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelReferenceFlagForAstrometryDesc, color: SystemColors.Control);

		private void LabelReferenceFlagForAstrometryData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelReferenceFlagForAstrometryData, color: SystemColors.Control);

		private void LabelTrigonomicParallaxDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelTrigonomicParallaxDesc, color: SystemColors.Control);

		private void LabelTrigonomicParallaxData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelProperMotionAlphaDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelProperMotionAlphaDesc, color: SystemColors.Control);

		private void LabelProperMotionAlphaData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelProperMotionAlphaData, color: SystemColors.Control);

		private void LabelProperMotionDeltaDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelProperMotionDeltaDesc, color: SystemColors.Control);

		private void LabelProperMotionDeltaData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelProperMotionDeltaData, color: SystemColors.Control);

		private void LabelStandardErrorRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorRightAscensionDesc, color: SystemColors.Control);

		private void LabelStandardErrorRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorRightAscensionData, color: SystemColors.Control);

		private void LabelStandardErrorDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorDeclinationDesc, color: SystemColors.Control);

		private void LabelStandardErrorDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorDeclinationData, color: SystemColors.Control);

		private void LabelStandardErrorTrigonomicParallaxDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorTrigonomicParallaxDesc, color: SystemColors.Control);

		private void LabelStandardErrorTrigonomicParallaxData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorProperMotionRightAscensionDesc, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorProperMotionRightAscensionData, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorProperMotionDeclinationDesc, color: SystemColors.Control);

		private void LabelStandardErrorProperMotionDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorProperMotionDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationDeclinationByRightAscensionDesc, color: SystemColors.Control);

		private void LabelCorrelationDeclinationByRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationDeclinationByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationTrigonomicParallaxByRightAscensionDesc, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationTrigonomicParallaxByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationTrigonomicParallaxByDeclinationDesc, color: SystemColors.Control);

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationTrigonomicParallaxByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByRightAscensionDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByDeclinationDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByRightAscensionDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.Control);

		private void LabelNumberOfTransitsForAstrometryDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelNumberOfTransitsForAstrometryDesc, color: SystemColors.Control);

		private void LabelNumberOfTransitsForAstrometryData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelNumberOfTransitsForAstrometryData, color: SystemColors.Control);

		private void LabelGoodnessOfFitParameterDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelGoodnessOfFitParameterDesc, color: SystemColors.Control);

		private void LabelGoodnessOfFitParameterData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelGoodnessOfFitParameterData, color: SystemColors.Control);

		private void LabelHipparcosNumberDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelHipparcosNumberDesc, color: SystemColors.Control);

		private void LabelHipparcosNumberData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelHipparcosNumberData, color: SystemColors.Control);

		private void LabelMeanBtMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelMeanBtMagnitudeDesc, color: SystemColors.Control);

		private void LabelMeanBtMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanBtMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, color: SystemColors.Control);

		private void LabelStandardErrorMeanBtMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelMeanVtMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelMeanVtMagnitudeDesc, color: SystemColors.Control);

		private void LabelMeanVtMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanVtMagnitudeDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, color: SystemColors.Control);

		private void LabelStandardErrorMeanVtMagnitudeData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelSourceOfPhotometryDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelSourceOfPhotometryDesc, color: SystemColors.Control);

		private void LabelSourceOfPhotometryData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelSourceOfPhotometryData, color: SystemColors.Control);

		private void LabelJohnsonBvColorDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelJohnsonBvColorDesc, color: SystemColors.Control);

		private void LabelJohnsonBvColorData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelJohnsonBvColorData, color: SystemColors.Control);

		private void LabelStandardErrorJohnsonBvColorDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorJohnsonBvColorDesc, color: SystemColors.Control);

		private void LabelStandardErrorJohnsonBvColorData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.Control);

		private void LabelAstrometricQualityFlagDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelAstrometricQualityFlagDesc, color: SystemColors.Control);

		private void LabelAstrometricQualityFlagData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelAstrometricQualityFlagData, color: SystemColors.Control);

		private void LabelSignalToNoiseRatioOfTheStarImageDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelSignalToNoiseRatioOfTheStarImageDesc, color: SystemColors.Control);

		private void LabelSignalToNoiseRatioOfTheStarImageData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelSignalToNoiseRatioOfTheStarImageData, color: SystemColors.Control);

		private void LabelSourceOfAstrometricDataDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelSourceOfAstrometricDataDesc, color: SystemColors.Control);

		private void LabelSourceOfAstrometricDataData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelSourceOfAstrometricDataData, color: SystemColors.Control);

		private void LabelNumberOfTransitsForPhotometryDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelNumberOfTransitsForPhotometryDesc, color: SystemColors.Control);

		private void LabelNumberOfTransitsForPhotometryData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelNumberOfTransitsForPhotometryData, color: SystemColors.Control);

		private void LabelEstimateOfVtmagScatterDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelEstimateOfVtmagScatterDesc, color: SystemColors.Control);

		private void LabelEstimateOfVtmagScatterData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelEstimateOfVtmagScatterData, color: SystemColors.Control);

		private void LabelVtmagAtMaximumDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelVtmagAtMaximumDesc, color: SystemColors.Control);

		private void LabelVtmagAtMaximumData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelVtmagAtMaximumData, color: SystemColors.Control);

		private void LabelVtmagAtMinimumDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelVtmagAtMinimumDesc, color: SystemColors.Control);

		private void LabelVtmagAtMinimumData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelVtmagAtMinimumData, color: SystemColors.Control);

		private void LabelKnownVariabilityFromGcvsNsvDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelKnownVariabilityFromGcvsNsvDesc, color: SystemColors.Control);

		private void LabelKnownVariabilityFromGcvsNsvData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelKnownVariabilityFromGcvsNsvData, color: SystemColors.Control);

		private void LabelVariabilityFromTychoDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelVariabilityFromTychoDesc, color: SystemColors.Control);

		private void LabelVariabilityFromTychoData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelVariabilityFromTychoData, color: SystemColors.Control);

		private void LabelDuplicityFromTychoDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelDuplicityFromTychoDesc, color: SystemColors.Control);

		private void LabelDuplicityFromTychoData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelDuplicityFromTychoData, color: SystemColors.Control);

		private void LabelEpochPhotometryInAnnexDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelEpochPhotometryInAnnexDesc, color: SystemColors.Control);

		private void LabelEpochPhotometryInAnnexData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelEpochPhotometryInAnnexData, color: SystemColors.Control);

		private void LabelCcdmComponentIdentifierDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCcdmComponentIdentifierDesc, color: SystemColors.Control);

		private void LabelCcdmComponentIdentifierData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCcdmComponentIdentifierData, color: SystemColors.Control);

		private void LabelPpmAndSupplementDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelPpmAndSupplementDesc, color: SystemColors.Control);

		private void LabelPpmAndSupplementData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelPpmAndSupplementData, color: SystemColors.Control);

		private void LabelHdNumberDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelHdNumberDesc, color: SystemColors.Control);

		private void LabelHdNumberData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelHdNumberData, color: SystemColors.Control);

		private void LabelBonnerDmDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelBonnerDmDesc, color: SystemColors.Control);

		private void LabelBonnerDmData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelBonnerDmData, color: SystemColors.Control);

		private void LabelCordobaDmDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCordobaDmDesc, color: SystemColors.Control);

		private void LabelCordobaDmData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCordobaDmData, color: SystemColors.Control);

		private void LabelCapePhotographicDmDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCapePhotographicDmDesc, color: SystemColors.Control);

		private void LabelCapePhotographicDmData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelCapePhotographicDmData, color: SystemColors.Control);

		private void LabelNotesDesc_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelNotesDesc, color: SystemColors.Control);

		private void LabelNotesData_Leave(object sender, EventArgs e) => SetColorSelfAndClearStatusbar(labelSelf: ref labelNotesData, color: SystemColors.Control);

		private void ToolStripTextBoxGoToIndex_Leave(object sender, EventArgs e) => SetStatusbar(sender: sender, e: e);

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

		private void ToolStripButtonGoToIndex_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripTextBoxGoToIndex_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonChangeDataTableStyle_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

		private void ToolStripButtonChangeHoverEffect_MouseLeave(object sender, EventArgs e) => ClearStatusbar();

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

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByTrigonomicParallaxData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByDeclinationDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByDeclinationData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.Control);

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc, labelNeighbor: ref labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData, color: SystemColors.Control);

		private void LabelNumberOfTransitsForAstrometryDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberOfTransitsForAstrometryDesc, labelNeighbor: ref labelNumberOfTransitsForAstrometryData, color: SystemColors.Control);

		private void LabelNumberOfTransitsForAstrometryData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberOfTransitsForAstrometryDesc, labelNeighbor: ref labelNumberOfTransitsForAstrometryData, color: SystemColors.Control);

		private void LabelGoodnessOfFitParameterDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelGoodnessOfFitParameterDesc, labelNeighbor: ref labelGoodnessOfFitParameterData, color: SystemColors.Control);

		private void LabelGoodnessOfFitParameterData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelGoodnessOfFitParameterDesc, labelNeighbor: ref labelGoodnessOfFitParameterData, color: SystemColors.Control);

		private void LabelHipparcosNumberDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelHipparcosNumberDesc, labelNeighbor: ref labelHipparcosNumberData, color: SystemColors.Control);

		private void LabelHipparcosNumberData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelHipparcosNumberDesc, labelNeighbor: ref labelHipparcosNumberData, color: SystemColors.Control);

		private void LabelMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMeanBtMagnitudeDesc, labelNeighbor: ref labelMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMeanBtMagnitudeDesc, labelNeighbor: ref labelMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMeanBtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanBtMagnitudeData, color: SystemColors.Control);

		private void LabelMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMeanVtMagnitudeDesc, labelNeighbor: ref labelMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelMeanVtMagnitudeDesc, labelNeighbor: ref labelMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelStandardErrorMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorMeanVtMagnitudeDesc, labelNeighbor: ref labelStandardErrorMeanVtMagnitudeData, color: SystemColors.Control);

		private void LabelSourceOfPhotometryDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfPhotometryDesc, labelNeighbor: ref labelSourceOfPhotometryData, color: SystemColors.Control);

		private void LabelSourceOfPhotometryData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfPhotometryDesc, labelNeighbor: ref labelSourceOfPhotometryData, color: SystemColors.Control);

		private void LabelJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelJohnsonBvColorDesc, labelNeighbor: ref labelJohnsonBvColorData, color: SystemColors.Control);

		private void LabelJohnsonBvColorData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelJohnsonBvColorDesc, labelNeighbor: ref labelJohnsonBvColorData, color: SystemColors.Control);

		private void LabelStandardErrorJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorJohnsonBvColorDesc, labelNeighbor: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.Control);

		private void LabelStandardErrorJohnsonBvColorData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelStandardErrorJohnsonBvColorDesc, labelNeighbor: ref labelStandardErrorJohnsonBvColorData, color: SystemColors.Control);

		private void LabelAstrometricQualityFlagDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAstrometricQualityFlagDesc, labelNeighbor: ref labelAstrometricQualityFlagData, color: SystemColors.Control);

		private void LabelAstrometricQualityFlagData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelAstrometricQualityFlagDesc, labelNeighbor: ref labelAstrometricQualityFlagData, color: SystemColors.Control);

		private void LabelSignalToNoiseRatioOfTheStarImageDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSignalToNoiseRatioOfTheStarImageDesc, labelNeighbor: ref labelSignalToNoiseRatioOfTheStarImageData, color: SystemColors.Control);

		private void LabelSignalToNoiseRatioOfTheStarImageData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSignalToNoiseRatioOfTheStarImageDesc, labelNeighbor: ref labelSignalToNoiseRatioOfTheStarImageData, color: SystemColors.Control);

		private void LabelSourceOfAstrometricDataDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfAstrometricDataDesc, labelNeighbor: ref labelSourceOfAstrometricDataData, color: SystemColors.Control);

		private void LabelSourceOfAstrometricDataData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelSourceOfAstrometricDataDesc, labelNeighbor: ref labelSourceOfAstrometricDataData, color: SystemColors.Control);

		private void LabelNumberOfTransitsForPhotometryDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberOfTransitsForPhotometryDesc, labelNeighbor: ref labelNumberOfTransitsForPhotometryData, color: SystemColors.Control);

		private void LabelNumberOfTransitsForPhotometryData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNumberOfTransitsForPhotometryDesc, labelNeighbor: ref labelNumberOfTransitsForPhotometryData, color: SystemColors.Control);

		private void LabelEstimateOfVtmagScatterDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelEstimateOfVtmagScatterDesc, labelNeighbor: ref labelEstimateOfVtmagScatterData, color: SystemColors.Control);

		private void LabelEstimateOfVtmagScatterData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelEstimateOfVtmagScatterDesc, labelNeighbor: ref labelEstimateOfVtmagScatterData, color: SystemColors.Control);

		private void LabelVtmagAtMaximumDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVtmagAtMaximumDesc, labelNeighbor: ref labelVtmagAtMaximumData, color: SystemColors.Control);

		private void LabelVtmagAtMaximumData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVtmagAtMaximumDesc, labelNeighbor: ref labelVtmagAtMaximumData, color: SystemColors.Control);

		private void LabelVtmagAtMinimumDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVtmagAtMinimumDesc, labelNeighbor: ref labelVtmagAtMinimumData, color: SystemColors.Control);

		private void LabelVtmagAtMinimumData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVtmagAtMinimumDesc, labelNeighbor: ref labelVtmagAtMinimumData, color: SystemColors.Control);

		private void LabelKnownVariabilityFromGcvsNsvDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelKnownVariabilityFromGcvsNsvDesc, labelNeighbor: ref labelKnownVariabilityFromGcvsNsvData, color: SystemColors.Control);

		private void LabelKnownVariabilityFromGcvsNsvData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelKnownVariabilityFromGcvsNsvDesc, labelNeighbor: ref labelKnownVariabilityFromGcvsNsvData, color: SystemColors.Control);

		private void LabelVariabilityFromTychoDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVariabilityFromTychoDesc, labelNeighbor: ref labelVariabilityFromTychoData, color: SystemColors.Control);

		private void LabelVariabilityFromTychoData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelVariabilityFromTychoDesc, labelNeighbor: ref labelVariabilityFromTychoData, color: SystemColors.Control);

		private void LabelDuplicityFromTychoDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelDuplicityFromTychoDesc, labelNeighbor: ref labelDuplicityFromTychoData, color: SystemColors.Control);

		private void LabelDuplicityFromTychoData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelDuplicityFromTychoDesc, labelNeighbor: ref labelDuplicityFromTychoData, color: SystemColors.Control);

		private void LabelEpochPhotometryInAnnexDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelEpochPhotometryInAnnexDesc, labelNeighbor: ref labelEpochPhotometryInAnnexData, color: SystemColors.Control);

		private void LabelEpochPhotometryInAnnexData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelEpochPhotometryInAnnexDesc, labelNeighbor: ref labelEpochPhotometryInAnnexData, color: SystemColors.Control);

		private void LabelCcdmComponentIdentifierDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCcdmComponentIdentifierDesc, labelNeighbor: ref labelCcdmComponentIdentifierData, color: SystemColors.Control);

		private void LabelCcdmComponentIdentifierData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCcdmComponentIdentifierDesc, labelNeighbor: ref labelCcdmComponentIdentifierData, color: SystemColors.Control);

		private void LabelPpmAndSupplementDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelPpmAndSupplementDesc, labelNeighbor: ref labelPpmAndSupplementData, color: SystemColors.Control);

		private void LabelPpmAndSupplementData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelPpmAndSupplementDesc, labelNeighbor: ref labelPpmAndSupplementData, color: SystemColors.Control);

		private void LabelHdNumberDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelHdNumberDesc, labelNeighbor: ref labelHdNumberData, color: SystemColors.Control);

		private void LabelHdNumberData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelHdNumberDesc, labelNeighbor: ref labelHdNumberData, color: SystemColors.Control);

		private void LabelBonnerDmDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelBonnerDmDesc, labelNeighbor: ref labelBonnerDmData, color: SystemColors.Control);

		private void LabelBonnerDmData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelBonnerDmDesc, labelNeighbor: ref labelBonnerDmData, color: SystemColors.Control);

		private void LabelCordobaDmDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCordobaDmDesc, labelNeighbor: ref labelCordobaDmData, color: SystemColors.Control);

		private void LabelCordobaDmData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCordobaDmDesc, labelNeighbor: ref labelCordobaDmData, color: SystemColors.Control);

		private void LabelCapePhotographicDmDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCapePhotographicDmDesc, labelNeighbor: ref labelCapePhotographicDmData, color: SystemColors.Control);

		private void LabelCapePhotographicDmData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelCapePhotographicDmDesc, labelNeighbor: ref labelCapePhotographicDmData, color: SystemColors.Control);

		private void LabelNotesDesc_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNotesDesc, labelNeighbor: ref labelNotesData, color: SystemColors.Control);

		private void LabelNotesData_MouseLeave(object sender, EventArgs e) => SetColorSelfAndNeighborAndClearStatusbar(labelSelf: ref labelNotesDesc, labelNeighbor: ref labelNotesData, color: SystemColors.Control);

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

		private void TychoCatalogViewerForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
					UpdateIndexLabel();
					ShowEntriesOnIndex();
					break;
				case Keys.End:
					index = maxIndex;
					break;
			}
			UpdateIndexLabel();
			ShowEntriesOnIndex();
		}

		#endregion
	}
}
