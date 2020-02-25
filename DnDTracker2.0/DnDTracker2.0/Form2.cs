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
    public partial class Form2 : Form
    {
        public static int turnNumber = 0;
        public static int encounterTime = 0;

        public static List<Tuple<string, int>> spells = new List<Tuple<string, int>>();

        public Form3 form3 = null;

        public Form2()
        {
            InitializeComponent();
            form3 = new Form3();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(turnNumber >= Form1.initiatives.Count - 1)
            {
                turnNumber = 0;
            }
            else
            {
                turnNumber++;
            }
            UpdateTurnOrder();

            encounterTime += 6;
            TimerLabel.Text = encounterTime.ToString();

            UpdateDuration(spells, 6);
            WriteToList(spells);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if(turnNumber <= 0)
            {
                turnNumber = Form1.initiatives.Count - 1;
            }
            else
            {
                turnNumber--;
            }
            UpdateTurnOrder();

            encounterTime -= 6;
            TimerLabel.Text = encounterTime.ToString();

            UpdateDuration(spells, -6);
            WriteToList(spells);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(SpellBox.Text == " " || SpellBox.Text == "" || SpellBox.Text == null || DurationBox.Text == "0" || DurationBox.Text == " " || DurationBox.Text == "" || DurationBox.Text == null)
            {
                ErrorLabel.Text = "No valid spell info was given";
            }
            else
            {
                spells.Add(new Tuple<string, int>(SpellBox.Text, int.Parse(DurationBox.Text)));
                spells = spells.OrderByDescending(t => t.Item2).ToList();

                WriteToList(spells);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = SpellList.SelectedIndex;

            spells.RemoveAt(index);
            WriteToList(spells);
        }

        public void UpdateTurnOrder()
        {
            //Form2 update Handling
            
            if (turnNumber + 1 >= Form1.initiatives.Count)
            {
                PreviousName.Text = Form1.initiatives[turnNumber - 1].Item1;
                CurrentName.Text = Form1.initiatives[turnNumber].Item1;
                NextName.Text = Form1.initiatives[0].Item1;

            }
            else if(turnNumber - 1 < 0)
            {
                PreviousName.Text = Form1.initiatives[Form1.initiatives.Count - 1].Item1;
                CurrentName.Text = Form1.initiatives[turnNumber].Item1;
                NextName.Text = Form1.initiatives[turnNumber + 1].Item1;
            }
            else
            {
                PreviousName.Text = Form1.initiatives[turnNumber - 1].Item1;
                CurrentName.Text = Form1.initiatives[turnNumber].Item1;
                NextName.Text = Form1.initiatives[turnNumber + 1].Item1;
            }
            
        }

        private void UpdateDuration(List<Tuple<string, int>> spells, int change)
        {
            for (int i = 0; i <= spells.Count - 1; i++)
            {
                if(spells[i].Item2 <= 0)
                {
                    spells.RemoveAt(i);
                }
                else
                {
                    spells[i] = new Tuple<string, int>(spells[i].Item1, spells[i].Item2 - change);
                }
            }
        }

        private void WriteToList(List<Tuple<string, int>> spells)
        {
            SpellList.Items.Clear();
            TimerList.Items.Clear();

            foreach (Tuple<string, int> spell in spells)
            {
                SpellList.Items.Add(spell.Item1);
                TimerList.Items.Add(spell.Item2.ToString());
            }
            SpellBox.ResetText();
            DurationBox.ResetText();
        }

        public void SetCalculate()
        {
            DurationBox.Text = form3.ResultBox.Text;
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            if(form3.)
            form3.Show();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            DurationBox.Text = form3.ResultBox.Text;
        }
    }
}
