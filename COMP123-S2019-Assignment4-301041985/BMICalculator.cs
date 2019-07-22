using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4_301041985
{
    public partial class BMICalculator : Form
    {
        public float userHeight { get; set; }
        public float userWeight { get; set; }
        public float userBMI { get; set; }        

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            CalculateBMIbutton.Enabled = false;
        }

        //These are the event handlers for switching between Imperial and Metric
        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImperialTableLayoutPanel.Visible = true;
            MetricTableLayoutPanel.Visible = false;
        }

        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetricTableLayoutPanel.Visible = true;
            ImperialTableLayoutPanel.Visible = false;
        }

        //These are the event handlers for Imperial textbox textchange event
        private void ImperialHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(ImperialHeightTextBox.Text);
                CalculateBMIbutton.Enabled = true;
            }
            catch
            {
                CalculateBMIbutton.Enabled = false;
            }
        }

        private void ImperialWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(ImperialWeightTextBox.Text);
                CalculateBMIbutton.Enabled = true;
            }
            catch
            {
                CalculateBMIbutton.Enabled = false;
            }
        }

        //These are the event handlers for Metric textbox textchange event
        private void MetricHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(MetricHeightTextBox.Text);
                CalculateBMIbutton.Enabled = true;
            }
            catch
            {
                CalculateBMIbutton.Enabled = false;
            }
        }

        private void MetricWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(MetricWeightTextBox.Text);
                CalculateBMIbutton.Enabled = true;
            }
            catch
            {
                CalculateBMIbutton.Enabled = false;
            }
        }

        //This is the event handler for CalculateBMIbutton click event
        private void CalculateBMIbutton_Click(object sender, EventArgs e)
        {
            if (ImperialTableLayoutPanel.Visible == true)
            {
                userHeight = float.Parse(ImperialHeightTextBox.Text);
                userWeight = float.Parse(ImperialWeightTextBox.Text);
                userBMI = (userWeight * 703) / (userHeight * userHeight);
                BMIDisplayTextBox.Text = userBMI.ToString();
                BMIDisplayTextBox.BackColor = Color.LightSkyBlue;
            }
            else
            {
                userHeight = float.Parse(MetricHeightTextBox.Text);
                userWeight = float.Parse(MetricWeightTextBox.Text);
                userBMI = userWeight / (userHeight * userHeight);
                BMIDisplayTextBox.Text = userBMI.ToString();
                BMIDisplayTextBox.BackColor = Color.LightSeaGreen;
            }
        }

        private void ClearForm()
        {
            ImperialHeightTextBox.Clear();
            ImperialWeightTextBox.Clear();
            MetricHeightTextBox.Clear();
            MetricWeightTextBox.Clear();
            CalculateBMIbutton.Enabled = false;
        }
    }
}
