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
            this.ImperialTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialWeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialWeightLabel = new System.Windows.Forms.Label();
            this.ImperialHeightLabel = new System.Windows.Forms.Label();
            this.ImperialHeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.BMIDisplayTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIbutton = new System.Windows.Forms.Button();
            this.MetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MetricWeightTextBox = new System.Windows.Forms.TextBox();
            this.MetricWeightLabel = new System.Windows.Forms.Label();
            this.MetricHeightLabel = new System.Windows.Forms.Label();
            this.MetricHeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialTableLayoutPanel.SuspendLayout();
            this.MetricTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialTableLayoutPanel
            // 
            this.ImperialTableLayoutPanel.ColumnCount = 2;
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialWeightTextBox, 1, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialWeightLabel, 0, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialHeightLabel, 0, 0);
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialHeightTextBox, 1, 0);
            this.ImperialTableLayoutPanel.Location = new System.Drawing.Point(10, 110);
            this.ImperialTableLayoutPanel.Name = "ImperialTableLayoutPanel";
            this.ImperialTableLayoutPanel.RowCount = 3;
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ImperialTableLayoutPanel.Size = new System.Drawing.Size(280, 100);
            this.ImperialTableLayoutPanel.TabIndex = 0;
            // 
            // ImperialWeightTextBox
            // 
            this.ImperialWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialWeightTextBox.Location = new System.Drawing.Point(143, 43);
            this.ImperialWeightTextBox.Name = "ImperialWeightTextBox";
            this.ImperialWeightTextBox.Size = new System.Drawing.Size(134, 55);
            this.ImperialWeightTextBox.TabIndex = 3;
            this.ImperialWeightTextBox.Text = "pounds";
            this.ImperialWeightTextBox.TextChanged += new System.EventHandler(this.ImperialWeightTextBox_TextChanged);
            // 
            // ImperialWeightLabel
            // 
            this.ImperialWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialWeightLabel.AutoSize = true;
            this.ImperialWeightLabel.Location = new System.Drawing.Point(3, 40);
            this.ImperialWeightLabel.Name = "ImperialWeightLabel";
            this.ImperialWeightLabel.Size = new System.Drawing.Size(134, 40);
            this.ImperialWeightLabel.TabIndex = 2;
            this.ImperialWeightLabel.Text = "My Weight";
            this.ImperialWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImperialHeightLabel
            // 
            this.ImperialHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialHeightLabel.AutoSize = true;
            this.ImperialHeightLabel.Location = new System.Drawing.Point(3, 0);
            this.ImperialHeightLabel.Name = "ImperialHeightLabel";
            this.ImperialHeightLabel.Size = new System.Drawing.Size(134, 40);
            this.ImperialHeightLabel.TabIndex = 0;
            this.ImperialHeightLabel.Text = "My Height";
            this.ImperialHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImperialHeightTextBox
            // 
            this.ImperialHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialHeightTextBox.Location = new System.Drawing.Point(143, 3);
            this.ImperialHeightTextBox.Name = "ImperialHeightTextBox";
            this.ImperialHeightTextBox.Size = new System.Drawing.Size(134, 55);
            this.ImperialHeightTextBox.TabIndex = 1;
            this.ImperialHeightTextBox.Text = "inches";
            this.ImperialHeightTextBox.TextChanged += new System.EventHandler(this.ImperialHeightTextBox_TextChanged);
            // 
            // ImperialUnitRadioButton
            // 
            this.ImperialUnitRadioButton.AutoSize = true;
            this.ImperialUnitRadioButton.Checked = true;
            this.ImperialUnitRadioButton.Location = new System.Drawing.Point(20, 10);
            this.ImperialUnitRadioButton.Name = "ImperialUnitRadioButton";
            this.ImperialUnitRadioButton.Size = new System.Drawing.Size(170, 44);
            this.ImperialUnitRadioButton.TabIndex = 1;
            this.ImperialUnitRadioButton.TabStop = true;
            this.ImperialUnitRadioButton.Text = "Imperial";
            this.ImperialUnitRadioButton.UseVisualStyleBackColor = true;
            this.ImperialUnitRadioButton.CheckedChanged += new System.EventHandler(this.ImperialUnitRadioButton_CheckedChanged);
            // 
            // MetricUnitRadioButton
            // 
            this.MetricUnitRadioButton.AutoSize = true;
            this.MetricUnitRadioButton.Location = new System.Drawing.Point(20, 60);
            this.MetricUnitRadioButton.Name = "MetricUnitRadioButton";
            this.MetricUnitRadioButton.Size = new System.Drawing.Size(142, 44);
            this.MetricUnitRadioButton.TabIndex = 2;
            this.MetricUnitRadioButton.Text = "Metric";
            this.MetricUnitRadioButton.UseVisualStyleBackColor = true;
            this.MetricUnitRadioButton.CheckedChanged += new System.EventHandler(this.MetricUnitRadioButton_CheckedChanged);
            // 
            // BMIDisplayTextBox
            // 
            this.BMIDisplayTextBox.Enabled = false;
            this.BMIDisplayTextBox.Location = new System.Drawing.Point(95, 300);
            this.BMIDisplayTextBox.Name = "BMIDisplayTextBox";
            this.BMIDisplayTextBox.Size = new System.Drawing.Size(100, 55);
            this.BMIDisplayTextBox.TabIndex = 3;
            // 
            // CalculateBMIbutton
            // 
            this.CalculateBMIbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalculateBMIbutton.Location = new System.Drawing.Point(10, 225);
            this.CalculateBMIbutton.Name = "CalculateBMIbutton";
            this.CalculateBMIbutton.Size = new System.Drawing.Size(280, 50);
            this.CalculateBMIbutton.TabIndex = 4;
            this.CalculateBMIbutton.Text = "Calculate BMI";
            this.CalculateBMIbutton.UseVisualStyleBackColor = false;
            this.CalculateBMIbutton.Click += new System.EventHandler(this.CalculateBMIbutton_Click);
            // 
            // MetricTableLayoutPanel
            // 
            this.MetricTableLayoutPanel.ColumnCount = 2;
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.Controls.Add(this.MetricWeightTextBox, 1, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.MetricWeightLabel, 0, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.MetricHeightLabel, 0, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.MetricHeightTextBox, 1, 0);
            this.MetricTableLayoutPanel.Location = new System.Drawing.Point(10, 110);
            this.MetricTableLayoutPanel.Name = "MetricTableLayoutPanel";
            this.MetricTableLayoutPanel.RowCount = 3;
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MetricTableLayoutPanel.Size = new System.Drawing.Size(280, 100);
            this.MetricTableLayoutPanel.TabIndex = 5;
            this.MetricTableLayoutPanel.Visible = false;
            // 
            // MetricWeightTextBox
            // 
            this.MetricWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricWeightTextBox.Location = new System.Drawing.Point(143, 43);
            this.MetricWeightTextBox.Name = "MetricWeightTextBox";
            this.MetricWeightTextBox.Size = new System.Drawing.Size(134, 55);
            this.MetricWeightTextBox.TabIndex = 3;
            this.MetricWeightTextBox.Text = "kilograms";
            this.MetricWeightTextBox.TextChanged += new System.EventHandler(this.MetricWeightTextBox_TextChanged);
            // 
            // MetricWeightLabel
            // 
            this.MetricWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricWeightLabel.AutoSize = true;
            this.MetricWeightLabel.Location = new System.Drawing.Point(3, 40);
            this.MetricWeightLabel.Name = "MetricWeightLabel";
            this.MetricWeightLabel.Size = new System.Drawing.Size(134, 40);
            this.MetricWeightLabel.TabIndex = 2;
            this.MetricWeightLabel.Text = "My Weight";
            this.MetricWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MetricHeightLabel
            // 
            this.MetricHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricHeightLabel.AutoSize = true;
            this.MetricHeightLabel.Location = new System.Drawing.Point(3, 0);
            this.MetricHeightLabel.Name = "MetricHeightLabel";
            this.MetricHeightLabel.Size = new System.Drawing.Size(134, 40);
            this.MetricHeightLabel.TabIndex = 0;
            this.MetricHeightLabel.Text = "My Height";
            this.MetricHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MetricHeightTextBox
            // 
            this.MetricHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricHeightTextBox.Location = new System.Drawing.Point(143, 3);
            this.MetricHeightTextBox.Name = "MetricHeightTextBox";
            this.MetricHeightTextBox.Size = new System.Drawing.Size(134, 55);
            this.MetricHeightTextBox.TabIndex = 1;
            this.MetricHeightTextBox.Text = "meters";
            this.MetricHeightTextBox.TextChanged += new System.EventHandler(this.MetricHeightTextBox_TextChanged);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.MetricTableLayoutPanel);
            this.Controls.Add(this.CalculateBMIbutton);
            this.Controls.Add(this.BMIDisplayTextBox);
            this.Controls.Add(this.MetricUnitRadioButton);
            this.Controls.Add(this.ImperialUnitRadioButton);
            this.Controls.Add(this.ImperialTableLayoutPanel);
            this.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.ImperialTableLayoutPanel.ResumeLayout(false);
            this.ImperialTableLayoutPanel.PerformLayout();
            this.MetricTableLayoutPanel.ResumeLayout(false);
            this.MetricTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ImperialTableLayoutPanel;
        private System.Windows.Forms.Label ImperialHeightLabel;
        private System.Windows.Forms.TextBox ImperialHeightTextBox;
        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
        private System.Windows.Forms.RadioButton MetricUnitRadioButton;
        private System.Windows.Forms.TextBox ImperialWeightTextBox;
        private System.Windows.Forms.Label ImperialWeightLabel;
        private System.Windows.Forms.TextBox BMIDisplayTextBox;
        private System.Windows.Forms.Button CalculateBMIbutton;
        private System.Windows.Forms.TableLayoutPanel MetricTableLayoutPanel;
        private System.Windows.Forms.TextBox MetricWeightTextBox;
        private System.Windows.Forms.Label MetricWeightLabel;
        private System.Windows.Forms.Label MetricHeightLabel;
        private System.Windows.Forms.TextBox MetricHeightTextBox;
    }
}

