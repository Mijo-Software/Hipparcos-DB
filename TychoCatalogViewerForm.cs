using Hipparcos_DB.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Hipparcos_DB
{
	public partial class TychoCatalogViewerForm : Form
	{
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

		#region Local methods

		private string RemoveFileExtension(string filename) => filename.Substring(startIndex: 0, length: filename.LastIndexOf(value: "."));

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

		private void SetColorSelfAndSetStatusbar(uint astroElemId, ref Label labelSelf, Color color, object sender, EventArgs e)
		{
			astrophysicalElement = astroElemId;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				SetColorSelf(labelSelf: ref labelSelf, color: color);
			}
		}

		private void SetColorSelfAndClearStatusbar(ref Label labelSelf, Color color)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				SetColorSelf(labelSelf: ref labelSelf, color: color);
			}
		}

		private void SetColorSelfAndNeighbourAndSetStatusbar(uint astroElemId, ref Label labelSelf, ref Label labelNeighbour, Color color, object sender, EventArgs e)
		{
			astrophysicalElement = astroElemId;
			SetStatusbar(sender: sender, e: e);
			if (settings.UserEnableHoverEffect)
			{
				SetColorSelfAndNeighbour(labelSelf: ref labelSelf, labelNeighbour: ref labelNeighbour, color: color);
			}
		}

		private void SetColorSelfAndNeighbourAndClearStatusbar(ref Label labelSelf, ref Label labelNeighbour, Color color)
		{
			ClearStatusbar();
			if (settings.UserEnableHoverEffect)
			{
				SetColorSelfAndNeighbour(labelSelf: ref labelSelf, labelNeighbour: ref labelNeighbour, color: color);
			}
		}

		private void SetColorSelf(ref Label labelSelf, Color color) => labelSelf.BackColor = color;

		private void SetColorSelfAndNeighbour(ref Label labelSelf, ref Label labelNeighbour, Color color) => labelSelf.BackColor = labelNeighbour.BackColor = color;

		private void UpdateIndexLabel() => toolStripTextBoxGoToIndex.Text = index.ToString();

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
			labelCatalogData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelIdentifierData.Text = catalogEntries[index - 1].Substring(startIndex: 14, length: 12); //.Trim();
			labelProximityFlagData.Text = catalogEntries[index - 1].Substring(startIndex: 16, length: 1); //.Trim();
			labelRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 28, length: 11); //.Trim();
			labelDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 40, length: 11); //.Trim();
			labelMagnitudeJohnsonData.Text = catalogEntries[index - 1].Substring(startIndex: 46, length: 5); //.Trim();
			labelSourceOfMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 50, length: 1); //.Trim();
			labelAlphaData.Text = catalogEntries[index - 1].Substring(startIndex: 63, length: 12); //.Trim();
			labelDeltaData.Text = catalogEntries[index - 1].Substring(startIndex: 76, length: 12); //.Trim();
			labelReferenceFlagForAstrometryData.Text = catalogEntries[index - 1].Substring(startIndex: 78, length: 1); //.Trim();
			labelTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 85, length: 6); //.Trim();
			labelProperMotionAlphaData.Text = catalogEntries[index - 1].Substring(startIndex: 94, length: 7); //.Trim();
			labelProperMotionDeltaData.Text = catalogEntries[index - 1].Substring(startIndex: 103, length: 7); //.Trim();
			labelStandardErrorRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 110, length: 5); //.Trim();
			labelStandardErrorDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 117, length: 5); //.Trim();
			labelStandardErrorTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 124, length: 5); //.Trim();
			labelStandardErrorProperMotionRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 131, length: 5); //.Trim();
			labelStandardErrorProperMotionDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 138, length: 5); //.Trim();
			labelCorrelationDeclinationByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 145, length: 5); //.Trim();
			labelCorrelationTrigonomicParallaxByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 151, length: 5); //.Trim();
			labelCorrelationTrigonomicParallaxByDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 157, length: 5); //.Trim();
			labelCorrelationProperMotionRightAscensionByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 163, length: 5); //.Trim();
			labelCorrelationProperMotionRightAscensionByDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 169, length: 5); //.Trim();
			labelCorrelationProperMotionRightAscensionByTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 175, length: 5); //.Trim();
			labelCorrelationProperMotionDeclinationByRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 181, length: 5); //.Trim();
			labelCorrelationProperMotionDeclinationByDeclinationData.Text = catalogEntries[index - 1].Substring(startIndex: 187, length: 5); //.Trim();
			labelCorrelationProperMotionDeclinationByTrigonomicParallaxData.Text = catalogEntries[index - 1].Substring(startIndex: 193, length: 5); //.Trim();
			labelCorrelationProperMotionDeclinationByProperMotionRightAscensionData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelNumberOfTransitsForAstrometryData.Text = catalogEntries[index - 1].Substring(startIndex: 203, length: 3); //.Trim();
			labelGoodnessOfFitParameterData.Text = catalogEntries[index - 1].Substring(startIndex: 209, length: 5); //.Trim();
			labelHipparcosNumberData.Text = catalogEntries[index - 1].Substring(startIndex: 216, length: 6); //.Trim();
			labelMeanBtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelStandardErrorMeanBtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelMeanVtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelStandardErrorMeanVtMagnitudeData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelSourceOfPhotometryData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelJohnsonBvColorData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelStandardErrorJohnsonBvColorData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelAstrometricQualityFlagData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelSignalToNoiseRatioOfTheStarImageData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelSourceOfAstrometricDataData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelNumberOfTransitsForPhotometryData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelEstimateOfVtmagScatterData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelVtmagAtMaximumData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelVtmagAtMinimumData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelKnownVariabilityFromGcvsNsvData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelVariabilityFromTychoData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelDuplicityFromTychoData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelEpochPhotometryInAnnexData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelCcdmComponentIdentifierData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelPpmAndSupplementData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelHdNumberData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelBonnerDmData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelCordobaDmData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelCapePhotographicDmData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
			labelNotesData.Text = catalogEntries[index - 1].Substring(startIndex: 0, length: 1); //.Trim();
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

		#endregion

		#region Con- and destructor

		public TychoCatalogViewerForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Form* event handlers

		private void TychoCatalogViewerForm_Load(object sender, EventArgs e)
		{

		}

		private void TychoCatalogViewerForm_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		#endregion

		#region Enter event handlers

		private void ToolStripTextBoxGoToIndex_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCatalogDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCatalogData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelIdentifierDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelIdentifierData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelProximityFlagDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelProximityFlagData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelRightAscensionDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelRightAscensionData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelDeclinationDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelDeclinationData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeJohnsonDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeJohnsonData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfMagnitudeDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfMagnitudeData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAlphaDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAlphaData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelDeltaDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelDeltaData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForAstrometryDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForAstrometryData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelTrigonomicParallaxData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionAlphaDesc_Enter(object sender, EventArgs e)
		{

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

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Enter(object sender, EventArgs e)
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

		private void LabelNumberOfTransitsForAstrometryDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForAstrometryData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosNumberDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosNumberData_Enter(object sender, EventArgs e)
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

		private void LabelSourceOfPhotometryDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfPhotometryData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColorDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColorData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColorDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColorData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricQualityFlagDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricQualityFlagData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSignalToNoiseRatioOfTheStarImageDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSignalToNoiseRatioOfTheStarImageData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfAstrometricDataDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfAstrometricDataData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForPhotometryDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForPhotometryData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelEstimateOfVtmagScatterDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelEstimateOfVtmagScatterData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMaximumDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMaximumData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMinimumDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMinimumData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelKnownVariabilityFromGcvsNsvDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelKnownVariabilityFromGcvsNsvData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityFromTychoDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityFromTychoData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelDuplicityFromTychoDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelDuplicityFromTychoData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelEpochPhotometryInAnnexDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelEpochPhotometryInAnnexData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCcdmComponentIdentifierDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelCcdmComponentIdentifierData_Enter(object sender, EventArgs e)
		{

		}

		private void LabelPpmAndSupplementDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelPpmAndSupplementData_Enter(object sender, EventArgs e)
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

		private void LabelNotesDesc_Enter(object sender, EventArgs e)
		{

		}

		private void LabelNotesData_Enter(object sender, EventArgs e)
		{

		}

		#endregion

		#region MouseEnter event handlers

		private void MenuitemClose_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripMenuItemInfo_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepToBegin_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepFastBackward_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepBackward_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepForward_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepFastForward_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepToEnd_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripTextBoxGoToIndex_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonGoToIndex_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonChangeDataTableStyle_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonChangeHoverEffect_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCatalogDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCatalogData_MouseEnter(object sender, EventArgs e)
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

		private void LabelProximityFlagData_MouseEnter(object sender, EventArgs e)
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

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseEnter(object sender, EventArgs e)
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

		private void LabelNumberOfTransitsForAstrometryDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForAstrometryData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosNumberDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosNumberData_MouseEnter(object sender, EventArgs e)
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

		private void LabelSourceOfPhotometryDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfPhotometryData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColorData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColorDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColorData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricQualityFlagDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricQualityFlagData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSignalToNoiseRatioOfTheStarImageDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSignalToNoiseRatioOfTheStarImageData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfAstrometricDataDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfAstrometricDataData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForPhotometryDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForPhotometryData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelEstimateOfVtmagScatterDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelEstimateOfVtmagScatterData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMaximumDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMaximumData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMinimumDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMinimumData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelKnownVariabilityFromGcvsNsvDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelKnownVariabilityFromGcvsNsvData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityFromTychoDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityFromTychoData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelDuplicityFromTychoDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelDuplicityFromTychoData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelEpochPhotometryInAnnexDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelEpochPhotometryInAnnexData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCcdmComponentIdentifierDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelCcdmComponentIdentifierData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelPpmAndSupplementDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelPpmAndSupplementData_MouseEnter(object sender, EventArgs e)
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

		private void LabelNotesDesc_MouseEnter(object sender, EventArgs e)
		{

		}

		private void LabelNotesData_MouseEnter(object sender, EventArgs e)
		{

		}

		private void ContextMenuStripCopyData_MouseEnter(object sender, EventArgs e)
		{

		}

		#endregion

		#region Leave event handlers

		private void ToolStripTextBoxGoToIndex_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCatalogDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCatalogData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelIdentifierDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelIdentifierData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelProximityFlagDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelProximityFlagData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelRightAscensionDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelRightAscensionData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelDeclinationDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelDeclinationData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeJohnsonDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeJohnsonData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfMagnitudeDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfMagnitudeData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelAlphaDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelAlphaData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelDeltaDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelDeltaData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForAstrometryDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForAstrometryData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionAlphaDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionAlphaData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionDeltaDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionDeltaData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRightAscensionDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRightAscensionData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorDeclinationDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorDeclinationData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionRightAscensionData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionDeclinationDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionDeclinationData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationDeclinationByRightAscensionData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForAstrometryDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForAstrometryData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosNumberDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosNumberData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelMeanBtMagnitudeDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelMeanBtMagnitudeData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanBtMagnitudeData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelMeanVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelMeanVtMagnitudeData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanVtMagnitudeData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfPhotometryDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfPhotometryData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColorDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColorData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColorDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColorData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricQualityFlagDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricQualityFlagData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelSignalToNoiseRatioOfTheStarImageDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelSignalToNoiseRatioOfTheStarImageData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfAstrometricDataDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfAstrometricDataData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForPhotometryDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForPhotometryData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelEstimateOfVtmagScatterDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelEstimateOfVtmagScatterData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMaximumDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMaximumData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMinimumDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMinimumData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelKnownVariabilityFromGcvsNsvDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelKnownVariabilityFromGcvsNsvData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityFromTychoDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityFromTychoData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelDuplicityFromTychoDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelDuplicityFromTychoData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelEpochPhotometryInAnnexDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelEpochPhotometryInAnnexData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCcdmComponentIdentifierDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCcdmComponentIdentifierData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelPpmAndSupplementDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelPpmAndSupplementData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelHdNumberDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelHdNumberData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelBonnerDmDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelBonnerDmData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCordobaDmDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCordobaDmData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCapePhotographicDmDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelCapePhotographicDmData_Leave(object sender, EventArgs e)
		{

		}

		private void LabelNotesDesc_Leave(object sender, EventArgs e)
		{

		}

		private void LabelNotesData_Leave(object sender, EventArgs e)
		{

		}

		#endregion

		#region MouseLeave event handlers

		private void MenuitemClose_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripMenuItemInfo_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepToBegin_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepFastBackward_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepBackward_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepForward_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepFastForward_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepToEnd_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripTextBoxGoToIndex_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonGoToIndex_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonChangeDataTableStyle_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonChangeHoverEffect_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCatalogDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCatalogData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelIdentifierDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelIdentifierData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelProximityFlagDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelProximityFlagData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelRightAscensionData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelDeclinationData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeJohnsonDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelMagnitudeJohnsonData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfMagnitudeData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelAlphaDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelAlphaData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelDeltaDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelDeltaData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForAstrometryDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelReferenceFlagForAstrometryData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionAlphaDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionAlphaData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionDeltaDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelProperMotionDeltaData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorRightAscensionData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorDeclinationData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorProperMotionDeclinationData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForAstrometryDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForAstrometryData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelGoodnessOfFitParameterData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosNumberDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelHipparcosNumberData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanBtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorMeanVtMagnitudeData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfPhotometryDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfPhotometryData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelJohnsonBvColorData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColorDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelStandardErrorJohnsonBvColorData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricQualityFlagDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelAstrometricQualityFlagData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelSignalToNoiseRatioOfTheStarImageDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelSignalToNoiseRatioOfTheStarImageData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfAstrometricDataDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelSourceOfAstrometricDataData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForPhotometryDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelNumberOfTransitsForPhotometryData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelEstimateOfVtmagScatterDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelEstimateOfVtmagScatterData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMaximumDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMaximumData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMinimumDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelVtmagAtMinimumData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelKnownVariabilityFromGcvsNsvDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelKnownVariabilityFromGcvsNsvData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityFromTychoDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelVariabilityFromTychoData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelDuplicityFromTychoDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelDuplicityFromTychoData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelEpochPhotometryInAnnexDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelEpochPhotometryInAnnexData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCcdmComponentIdentifierDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCcdmComponentIdentifierData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelPpmAndSupplementDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelPpmAndSupplementData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelHdNumberDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelHdNumberData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelBonnerDmDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelBonnerDmData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCordobaDmDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCordobaDmData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCapePhotographicDmDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelCapePhotographicDmData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelNotesDesc_MouseLeave(object sender, EventArgs e)
		{

		}

		private void LabelNotesData_MouseLeave(object sender, EventArgs e)
		{

		}

		private void ContextMenuStripCopyData_MouseLeave(object sender, EventArgs e)
		{

		}

		#endregion

		#region Click event handlers

		private void MenuitemClose_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripMenuItemInfo_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripMenuItemCopyData_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepToBegin_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepFastBackward_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepBackward_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepForward_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepFastForward_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStepToEnd_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonGoToIndex_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonChangeDataTableStyle_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonChangeHoverEffect_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region DoubleClick event handlers

		private void LabelCatalogDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCatalogData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelIdentifierDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelIdentifierData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelProximityFlagDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelProximityFlagData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelDeclinationData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelMagnitudeJohnsonDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelMagnitudeJohnsonData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelSourceOfMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelSourceOfMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelAlphaDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelAlphaData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelDeltaDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelDeltaData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelReferenceFlagForAstrometryDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelReferenceFlagForAstrometryData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelTrigonomicParallaxDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelTrigonomicParallaxData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelProperMotionAlphaDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelProperMotionAlphaData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelProperMotionDeltaDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelProperMotionDeltaData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorDeclinationData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorTrigonomicParallaxDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorTrigonomicParallaxData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorProperMotionRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorProperMotionRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorProperMotionDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorProperMotionDeclinationData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationDeclinationByRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationDeclinationByRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationTrigonomicParallaxByRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationTrigonomicParallaxByDeclinationData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionRightAscensionByRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionRightAscensionByDeclinationData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionRightAscensionByTrigonomicParallaxData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionDeclinationByRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionDeclinationByDeclinationDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionDeclinationByTrigonomicParallaxData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCorrelationProperMotionDeclinationByProperMotionRightAscensionData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelNumberOfTransitsForAstrometryDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelNumberOfTransitsForAstrometryData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelGoodnessOfFitParameterDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelGoodnessOfFitParameterData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelHipparcosNumberDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelHipparcosNumberData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelMeanBtMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelMeanBtMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorMeanBtMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorMeanBtMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelMeanVtMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelMeanVtMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorMeanVtMagnitudeDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorMeanVtMagnitudeData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelSourceOfPhotometryDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelSourceOfPhotometryData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelJohnsonBvColorDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelJohnsonBvColorData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorJohnsonBvColorDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelStandardErrorJohnsonBvColorData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelAstrometricQualityFlagDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelAstrometricQualityFlagData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelSignalToNoiseRatioOfTheStarImageDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelSignalToNoiseRatioOfTheStarImageData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelSourceOfAstrometricDataDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelSourceOfAstrometricDataData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelNumberOfTransitsForPhotometryDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelNumberOfTransitsForPhotometryData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelEstimateOfVtmagScatterDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelEstimateOfVtmagScatterData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelVtmagAtMaximumDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelVtmagAtMaximumData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelVtmagAtMinimumDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelVtmagAtMinimumData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelKnownVariabilityFromGcvsNsvDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelKnownVariabilityFromGcvsNsvData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelVariabilityFromTychoDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelVariabilityFromTychoData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelDuplicityFromTychoDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelDuplicityFromTychoData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelEpochPhotometryInAnnexDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelEpochPhotometryInAnnexData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCcdmComponentIdentifierDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCcdmComponentIdentifierData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelPpmAndSupplementDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelPpmAndSupplementData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelHdNumberDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelHdNumberData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelBonnerDmDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelBonnerDmData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCordobaDmDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCordobaDmData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCapePhotographicDmDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelCapePhotographicDmData_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelNotesDesc_DoubleClick(object sender, EventArgs e)
		{
		}

		private void LabelNotesData_DoubleClick(object sender, EventArgs e)
		{
		}

		#endregion

		#region Key* event handlers

		private void TychoCatalogViewerForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
		}

		private void ToolStripTextBoxGoToIndex_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		#endregion
	}
}
