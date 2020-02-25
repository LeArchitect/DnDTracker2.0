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
    public partial class Form1 : Form
    {
        public static List<Tuple<string, float>> initiatives = new List<Tuple<string, float>>();

        public static Form2 form2 = null;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(InitBox.Text == "0" || InitBox.Text == " " || InitBox.Text == "" || InitBox.Text == null || NameBox.Text == "" || NameBox.Text == " " || NameBox.Text == null)
            {
                ErrorLabel.Text = "There was and invalid input. Try again";
            }
            else
            {
                ErrorLabel.ResetText();

                string init = InitBox.Text;
                float number;
                bool success = float.TryParse(init, out number);
                if (success == true)
                {
                    initiatives.Add(new Tuple<string, float>(NameBox.Text, number));
                    initiatives = initiatives.OrderByDescending(t => t.Item2).ToList();

                    WriteToList(initiatives);
                }
                else
                {
                    ErrorLabel.Text = "For some reason decimal , not .";
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.PreviousName.Text = " ";
            form2.CurrentName.Text = Form1.initiatives[Form2.turnNumber].Item1;
            form2.NextName.Text = Form1.initiatives[Form2.turnNumber + 1].Item1;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (NameList.SelectedItem != null)
            {
                initiatives.RemoveAt(NameList.SelectedIndex);
                WriteToList(initiatives);
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NameBox_Click(object sender, EventArgs e)
        {

        }

        private void InitBox_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nhentai.net/g/182940/1/");
        }

        private void WriteToList(List<Tuple<string, float>> initiatives)
        {
            NameList.Items.Clear();
            InitList.Items.Clear();

            foreach (Tuple<string, float> initiative in initiatives)
            {
                NameList.Items.Add(initiative.Item1);
                InitList.Items.Add(initiative.Item2);
            }
            NameBox.ResetText();
            InitBox.ResetText();
        }
    }
}
