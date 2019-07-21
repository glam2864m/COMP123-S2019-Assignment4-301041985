namespace COMP123_S2019_Assignment4_301041985
{
    partial class BMICalculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BMICalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.BMIDisplayTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIbutton = new System.Windows.Forms.Button();
            this.BMICalculatorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorTableLayoutPanel
            // 
            this.BMICalculatorTableLayoutPanel.ColumnCount = 2;
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.BMICalculatorTableLayoutPanel.Location = new System.Drawing.Point(12, 148);
            this.BMICalculatorTableLayoutPanel.Name = "BMICalculatorTableLayoutPanel";
            this.BMICalculatorTableLayoutPanel.RowCount = 2;
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorTableLayoutPanel.Size = new System.Drawing.Size(300, 100);
            this.BMICalculatorTableLayoutPanel.TabIndex = 0;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(153, 53);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(144, 55);
            this.WeightTextBox.TabIndex = 3;
            this.WeightTextBox.Text = "pounds";
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 50);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(144, 50);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(144, 50);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Location = new System.Drawing.Point(153, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(144, 55);
            this.HeightTextBox.TabIndex = 1;
            this.HeightTextBox.Text = "inches";
            // 
            // ImperialUnitRadioButton
            // 
            this.ImperialUnitRadioButton.AutoSize = true;
            this.ImperialUnitRadioButton.Location = new System.Drawing.Point(35, 26);
            this.ImperialUnitRadioButton.Name = "ImperialUnitRadioButton";
            this.ImperialUnitRadioButton.Size = new System.Drawing.Size(170, 44);
            this.ImperialUnitRadioButton.TabIndex = 1;
            this.ImperialUnitRadioButton.TabStop = true;
            this.ImperialUnitRadioButton.Text = "Imperial";
            this.ImperialUnitRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricUnitRadioButton
            // 
            this.MetricUnitRadioButton.AutoSize = true;
            this.MetricUnitRadioButton.Location = new System.Drawing.Point(35, 85);
            this.MetricUnitRadioButton.Name = "MetricUnitRadioButton";
            this.MetricUnitRadioButton.Size = new System.Drawing.Size(142, 44);
            this.MetricUnitRadioButton.TabIndex = 2;
            this.MetricUnitRadioButton.TabStop = true;
            this.MetricUnitRadioButton.Text = "Metric";
            this.MetricUnitRadioButton.UseVisualStyleBackColor = true;
            // 
            // BMIDisplayTextBox
            // 
            this.BMIDisplayTextBox.Enabled = false;
            this.BMIDisplayTextBox.Location = new System.Drawing.Point(95, 357);
            this.BMIDisplayTextBox.Name = "BMIDisplayTextBox";
            this.BMIDisplayTextBox.Size = new System.Drawing.Size(100, 55);
            this.BMIDisplayTextBox.TabIndex = 3;
            // 
            // CalculateBMIbutton
            // 
            this.CalculateBMIbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalculateBMIbutton.Location = new System.Drawing.Point(46, 276);
            this.CalculateBMIbutton.Name = "CalculateBMIbutton";
            this.CalculateBMIbutton.Size = new System.Drawing.Size(197, 60);
            this.CalculateBMIbutton.TabIndex = 4;
            this.CalculateBMIbutton.Text = "Calculate BMI";
            this.CalculateBMIbutton.UseVisualStyleBackColor = false;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.CalculateBMIbutton);
            this.Controls.Add(this.BMIDisplayTextBox);
            this.Controls.Add(this.MetricUnitRadioButton);
            this.Controls.Add(this.ImperialUnitRadioButton);
            this.Controls.Add(this.BMICalculatorTableLayoutPanel);
            this.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMICalculatorTableLayoutPanel.ResumeLayout(false);
            this.BMICalculatorTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculatorTableLayoutPanel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
        private System.Windows.Forms.RadioButton MetricUnitRadioButton;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox BMIDisplayTextBox;
        private System.Windows.Forms.Button CalculateBMIbutton;
    }
}

