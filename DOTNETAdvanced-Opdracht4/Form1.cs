using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DOTNETAdvanced_Opdracht4
{
    public partial class Form1 : Form
    {
        Rij<TeDoen> rij = new Rij<TeDoen>();
        public delegate void Toon(object rij);
        List<System.Timers.Timer> timerList = new List<System.Timers.Timer>();
        List<DateTime> lijstDates = new List<DateTime>();
        List<TeDoen> taaksMetDates = new List<TeDoen>();
        int teller = 0;
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void toevoegen_Click(object sender, EventArgs e)
        {

            if (checkBox.Checked)
            {
                if (dateTimePicker1.Value > DateTime.Now)
                {

                    taaksMetDates.Add(new TeDoen(titel.Text, info.Lines, dateTimePicker1.Value));
                    lijstDates.Add(dateTimePicker1.Value);
                    Timer();
                    titel.Text = "";
                    info.Text = "";
                }
                else
                {
                    MessageBox.Show("de date moet in de toekomst zijn");
                }

            }
            else
            {
                TeDoen tedoen = new TeDoen(titel.Text, info.Lines);
                rij.Toevoegen(tedoen);
                titel.Text = "";
                info.Text = "";
            }

        }
        public int Wacht()
        {
            TimeSpan tijd = dateTimePicker1.Value - DateTime.Now;
            System.Threading.Thread.Sleep((int)tijd.TotalMinutes);
            return (int)tijd.TotalMilliseconds;
        }
        public void Timer()
        {
            System.Timers.Timer Localtimer = new System.Timers.Timer(Wacht());
            Localtimer.Elapsed += TextBox;
            Localtimer.AutoReset = false;
            Localtimer.Start();
            timerList.Add(Localtimer);
        }
        private void TextBox(object sender, EventArgs e)
        {
            foreach (DateTime date in lijstDates)
            {
                if (date <= DateTime.Now)
                {
                    rij.Show(taaksMetDates[lijstDates.IndexOf(date)]);

                    taaksMetDates.RemoveAt(lijstDates.IndexOf(date));
                    lijstDates.RemoveAt(lijstDates.IndexOf(date));

                }

            }
        }
        private void volgende_Click_1(object sender, EventArgs e)
        {

            List<TeDoen> list = rij.Toon();
            titel.Text = list.ElementAt(teller).Titel;
            info.Lines = list.ElementAt(teller).Informatie;
            index = list.IndexOf(list.ElementAt(teller));
            if (list.ElementAt(teller).Tijdstip != null)
            {

                dateTimePicker1.Value = (DateTime)list.ElementAt(teller).Tijdstip;
                checkBox.Checked = true;
            }
            else
            {

                dateTimePicker1.Value = DateTime.Now;
                checkBox.Checked = false;
            }


            teller++;
            if (teller == list.Count)
            {
                teller = 0;
            }

        }

        private void achteraan_Click_1(object sender, EventArgs e)
        {

            rij.ZitAchter(index);
            teller = 0;
            titel.Text = "";
            info.Text = "";

        }

        private void toonmbox_Click_1(object sender, EventArgs e)
        {
            if (toonmbox.BackColor == Color.Red)
            {
                toonmbox.BackColor = Color.Green;
                rij.toon += new Toon(show_MessageBox);
            }
            else
            {
                toonmbox.BackColor = Color.Red;
                rij.toon -= new Toon(show_MessageBox);
            }
        }

        private void toonform_Click_1(object sender, EventArgs e)
        {
            if (toonform.BackColor == Color.Red)
            {
                toonform.BackColor = Color.Green;
                rij.toon += new Toon(show_form);
            }
            else
            {
                toonform.BackColor = Color.Red;
                rij.toon -= new Toon(show_form);
            }

        }

        private void checkBox_CheckedChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = !dateTimePicker1.Visible;
        }

        private void verwijder_Click_1(object sender, EventArgs e)
        {
            rij.Verwijder(index);
            teller = 0;
            titel.Text = "";
            info.Text = "";

        }
        private void show_form(object lijst)
        {

            info.Text = lijst.ToString();

        }


        private void show_MessageBox(object lijst)
        {

            MessageBox.Show(lijst.ToString());

        }

        private void titel_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
