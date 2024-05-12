﻿using LiveSplit.Model;
using LiveSplit.Model.Comparisons;
using LiveSplit.TimeFormatters;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class DeltaSettings : UserControl
    {
        public Color TextColor { get; set; }
        public bool OverrideTextColor { get; set; }
        public TimeAccuracy Accuracy { get; set; }
        public bool DropDecimals { get; set; }

        public Color BackgroundColor { get; set; }
        public Color BackgroundColor2 { get; set; }
        public GradientType BackgroundGradient { get; set; }
        public string GradientString
        {
            get { return BackgroundGradient.ToString(); }
            set { BackgroundGradient = (GradientType)Enum.Parse(typeof(GradientType), value); }
        }

        public string Comparison { get; set; }
        public LiveSplitState CurrentState { get; set; }
        public bool Display2Rows { get; set; }

        public bool OverrideText { get; set; }
        public bool DifferentialText { get; set; }
        public string TextBehind { get; set; }
        public string TextAhead { get; set; }

        public LayoutMode Mode { get; set; }

        public DeltaSettings()
        {
            InitializeComponent();

            TextColor = Color.FromArgb(255, 255, 255);
            OverrideTextColor = false;
            Accuracy = TimeAccuracy.Tenths;
            BackgroundColor = Color.Transparent;
            BackgroundColor2 = Color.Transparent;
            BackgroundGradient = GradientType.Plain;
            Comparison = "Current Comparison";
            Display2Rows = false;
            DropDecimals = true;
            OverrideText = false;
            DifferentialText = false;
            TextBehind = "";
            TextAhead = "";

            chkOverrideTextColor.DataBindings.Add("Checked", this, "OverrideTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnTextColor.DataBindings.Add("BackColor", this, "TextColor", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbGradientType.DataBindings.Add("SelectedItem", this, "GradientString", false, DataSourceUpdateMode.OnPropertyChanged);
            btnColor1.DataBindings.Add("BackColor", this, "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnColor2.DataBindings.Add("BackColor", this, "BackgroundColor2", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbComparison.DataBindings.Add("SelectedItem", this, "Comparison", false, DataSourceUpdateMode.OnPropertyChanged);
            chkDropDecimals.DataBindings.Add("Checked", this, "DropDecimals", false, DataSourceUpdateMode.OnPropertyChanged);
            chkOverrideText.DataBindings.Add("Checked", this, "OverrideText", false, DataSourceUpdateMode.OnPropertyChanged);
            chkDifferentialText.DataBindings.Add("Checked", this, "DifferentialText", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBehind.DataBindings.Add("Text", this, "TextBehind");
            txtAhead.DataBindings.Add("Text", this, "TextAhead");
        }

        void chkOverrideTextColor_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled = btnTextColor.Enabled = chkOverrideTextColor.Checked;
        }
        void cmbComparison_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comparison = cmbComparison.SelectedItem.ToString();
        }

        void DeltaSettings_Load(object sender, EventArgs e)
        {
            chkOverrideTextColor_CheckedChanged(null, null);
            cmbComparison.Items.Clear();
            cmbComparison.Items.Add("Current Comparison");
            cmbComparison.Items.AddRange(CurrentState.Run.Comparisons.Where(x => x != NoneComparisonGenerator.ComparisonName).ToArray());
            if (!cmbComparison.Items.Contains(Comparison))
                cmbComparison.Items.Add(Comparison);
            rdoSeconds.Checked = Accuracy == TimeAccuracy.Seconds;
            rdoTenths.Checked = Accuracy == TimeAccuracy.Tenths;
            rdoHundredths.Checked = Accuracy == TimeAccuracy.Hundredths;
            if (Mode == LayoutMode.Horizontal)
            {
                chkTwoRows.Enabled = false;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.Checked = true;
            }
            else
            {
                chkTwoRows.Enabled = true;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.DataBindings.Add("Checked", this, "Display2Rows", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            ChangeOverrideTextAppearance();
        }

        void cmbGradientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnColor1.Visible = cmbGradientType.SelectedItem.ToString() != "Plain";
            btnColor2.DataBindings.Clear();
            btnColor2.DataBindings.Add("BackColor", this, btnColor1.Visible ? "BackgroundColor2" : "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
            GradientString = cmbGradientType.SelectedItem.ToString();
        }

        void rdoHundredths_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        void rdoSeconds_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        void UpdateAccuracy()
        {
            if (rdoSeconds.Checked)
                Accuracy = TimeAccuracy.Seconds;
            else if (rdoTenths.Checked)
                Accuracy = TimeAccuracy.Tenths;
            else
                Accuracy = TimeAccuracy.Hundredths;
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            TextColor = SettingsHelper.ParseColor(element["TextColor"]);
            OverrideTextColor = SettingsHelper.ParseBool(element["OverrideTextColor"]);
            Accuracy = SettingsHelper.ParseEnum<TimeAccuracy>(element["Accuracy"]);
            BackgroundColor = SettingsHelper.ParseColor(element["BackgroundColor"]);
            BackgroundColor2 = SettingsHelper.ParseColor(element["BackgroundColor2"]);
            GradientString = SettingsHelper.ParseString(element["BackgroundGradient"]);
            Comparison = SettingsHelper.ParseString(element["Comparison"]);
            Display2Rows = SettingsHelper.ParseBool(element["Display2Rows"]);
            DropDecimals = SettingsHelper.ParseBool(element["DropDecimals"]);
            OverrideText = SettingsHelper.ParseBool(element["OverrideText"]);
            DifferentialText = SettingsHelper.ParseBool(element["DifferentialText"]);
            TextBehind = SettingsHelper.ParseString(element["TextBehind"]);
            TextAhead = SettingsHelper.ParseString(element["TextAhead"]);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.4") ^
            SettingsHelper.CreateSetting(document, parent, "TextColor", TextColor) ^
            SettingsHelper.CreateSetting(document, parent, "OverrideTextColor", OverrideTextColor) ^
            SettingsHelper.CreateSetting(document, parent, "Accuracy", Accuracy) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor", BackgroundColor) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor2", BackgroundColor2) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundGradient", BackgroundGradient) ^
            SettingsHelper.CreateSetting(document, parent, "Comparison", Comparison) ^
            SettingsHelper.CreateSetting(document, parent, "Display2Rows", Display2Rows) ^
            SettingsHelper.CreateSetting(document, parent, "DropDecimals", DropDecimals) ^
            SettingsHelper.CreateSetting(document, parent, "OverrideText", OverrideText) ^
            SettingsHelper.CreateSetting(document, parent, "DifferentialText", DifferentialText) ^
            SettingsHelper.CreateSetting(document, parent, "TextBehind", TextBehind) ^
            SettingsHelper.CreateSetting(document, parent, "TextAhead", TextAhead);
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            SettingsHelper.ColorButtonClick((Button)sender, this);
        }

        private void chkOverrideText_CheckedChanged(object sender, EventArgs e)
        {
            ChangeOverrideTextAppearance();
        }

        private void chkDifferentialText_CheckedChanged(object sender, EventArgs e)
        {
            ChangeOverrideTextAppearance();
        }

        private void ChangeOverrideTextAppearance()
        {
            chkDifferentialText.Enabled = label2.Enabled = txtBehind.Enabled = chkOverrideText.Checked;
            label3.Enabled = txtAhead.Enabled = chkOverrideText.Checked && chkDifferentialText.Checked;
            label2.Text = chkDifferentialText.Checked ? "Text when behind:" : "Text:";
        }
    }
}
