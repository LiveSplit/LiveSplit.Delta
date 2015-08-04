namespace LiveSplit.UI.Components
{
    partial class DeltaSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeltaSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoSeconds = new System.Windows.Forms.RadioButton();
            this.rdoTenths = new System.Windows.Forms.RadioButton();
            this.rdoHundredths = new System.Windows.Forms.RadioButton();
            this.chkDropDecimals = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbComparison = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.chkOverrideTextColor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGradientType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.chkTwoRows = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbComparison, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbGradientType, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnColor1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnColor2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkTwoRows, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 4);
            this.groupBox4.Controls.Add(this.tableLayoutPanel5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.rdoSeconds, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.rdoTenths, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.rdoHundredths, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.chkDropDecimals, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // rdoSeconds
            // 
            resources.ApplyResources(this.rdoSeconds, "rdoSeconds");
            this.rdoSeconds.Name = "rdoSeconds";
            this.rdoSeconds.TabStop = true;
            this.rdoSeconds.UseVisualStyleBackColor = true;
            this.rdoSeconds.CheckedChanged += new System.EventHandler(this.rdoSeconds_CheckedChanged);
            // 
            // rdoTenths
            // 
            resources.ApplyResources(this.rdoTenths, "rdoTenths");
            this.rdoTenths.Name = "rdoTenths";
            this.rdoTenths.TabStop = true;
            this.rdoTenths.UseVisualStyleBackColor = true;
            // 
            // rdoHundredths
            // 
            resources.ApplyResources(this.rdoHundredths, "rdoHundredths");
            this.rdoHundredths.Name = "rdoHundredths";
            this.rdoHundredths.TabStop = true;
            this.rdoHundredths.UseVisualStyleBackColor = true;
            this.rdoHundredths.CheckedChanged += new System.EventHandler(this.rdoHundredths_CheckedChanged);
            // 
            // chkDropDecimals
            // 
            resources.ApplyResources(this.chkDropDecimals, "chkDropDecimals");
            this.tableLayoutPanel5.SetColumnSpan(this.chkDropDecimals, 2);
            this.chkDropDecimals.Name = "chkDropDecimals";
            this.chkDropDecimals.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // cmbComparison
            // 
            resources.ApplyResources(this.cmbComparison, "cmbComparison");
            this.tableLayoutPanel1.SetColumnSpan(this.cmbComparison, 3);
            this.cmbComparison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComparison.FormattingEnabled = true;
            this.cmbComparison.Name = "cmbComparison";
            this.cmbComparison.SelectedIndexChanged += new System.EventHandler(this.cmbComparison_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnTextColor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkOverrideTextColor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnTextColor
            // 
            resources.ApplyResources(this.btnTextColor, "btnTextColor");
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.UseVisualStyleBackColor = false;
            this.btnTextColor.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // chkOverrideTextColor
            // 
            resources.ApplyResources(this.chkOverrideTextColor, "chkOverrideTextColor");
            this.tableLayoutPanel2.SetColumnSpan(this.chkOverrideTextColor, 3);
            this.chkOverrideTextColor.Name = "chkOverrideTextColor";
            this.chkOverrideTextColor.UseVisualStyleBackColor = true;
            this.chkOverrideTextColor.CheckedChanged += new System.EventHandler(this.chkOverrideTextColor_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbGradientType
            // 
            resources.ApplyResources(this.cmbGradientType, "cmbGradientType");
            this.cmbGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradientType.FormattingEnabled = true;
            this.cmbGradientType.Items.AddRange(new object[] {
            resources.GetString("cmbGradientType.Items"),
            resources.GetString("cmbGradientType.Items1"),
            resources.GetString("cmbGradientType.Items2")});
            this.cmbGradientType.Name = "cmbGradientType";
            this.cmbGradientType.SelectedIndexChanged += new System.EventHandler(this.cmbGradientType_SelectedIndexChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // btnColor1
            // 
            resources.ApplyResources(this.btnColor1, "btnColor1");
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnColor2
            // 
            resources.ApplyResources(this.btnColor2, "btnColor2");
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // chkTwoRows
            // 
            resources.ApplyResources(this.chkTwoRows, "chkTwoRows");
            this.chkTwoRows.Name = "chkTwoRows";
            this.chkTwoRows.UseVisualStyleBackColor = true;
            // 
            // DeltaSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeltaSettings";
            this.Load += new System.EventHandler(this.DeltaSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.CheckBox chkOverrideTextColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton rdoSeconds;
        private System.Windows.Forms.RadioButton rdoTenths;
        private System.Windows.Forms.RadioButton rdoHundredths;
        private System.Windows.Forms.ComboBox cmbGradientType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbComparison;
        private System.Windows.Forms.CheckBox chkTwoRows;
        private System.Windows.Forms.CheckBox chkDropDecimals;
    }
}
