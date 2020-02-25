using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDTracker2._0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (SecondBox.Text == " " || SecondBox.Text == "" || SecondBox.Text == null)
            {
                SecondBox.Text = "0";
            }
            if(MinuteBox.Text == " " || MinuteBox.Text == "" || MinuteBox.Text == null)
            {
                MinuteBox.Text = "0";
            }
            if (HourBox.Text == " " || HourBox.Text == "" || HourBox.Text == null)
            {
                HourBox.Text = "0";
            }
            ResultBox.Text = ((int.Parse(SecondBox.Text)) + (int.Parse(MinuteBox.Text) * 60) + (int.Parse(HourBox.Text) * 3600)).ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SecondBox.ResetText();
            MinuteBox.ResetText();
            HourBox.ResetText();
            ResultBox.ResetText();
        }
    }
}
