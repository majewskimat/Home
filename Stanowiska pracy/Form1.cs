using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stanowiska_pracy
{
    public partial class Form1 : Form
    {


        public Form1()
        {
           
            this.Refresh();

            InitializeComponent();
        }

        List<string> pracownicy = new List<string>();

        private void Losowanie(object sender, EventArgs e)
        {
            if (pracownicy.Count < 15)
            {
                info.Text = ("By wypełnić stanowiska potrzebnych jest conajmniej 15 pracowników!\n\n Aktualnie wpisałeś: " + pracownicy.Count);

            }
            else
            {

                Random rand = new Random();



                L1P.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L1P.Text);
                L1P.BackColor = Color.LightGreen;


                L1F.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L1F.Text);
                L1F.BackColor = Color.LightGreen;

                L1W.Text = L1P.Text;
                L1W.BackColor = Color.LightGreen;

                L1S.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L1S.Text);
                L1S.BackColor = Color.LightGreen;

                //=====================================================

                L2P.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L2P.Text);
                L2P.BackColor = Color.LightGreen;

                L2F.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L2F.Text);
                L2F.BackColor = Color.LightGreen;

                L2W.Text = L2P.Text;
                L2W.BackColor = Color.LightGreen;

                L2S.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L2S.Text);
                L2S.BackColor = Color.LightGreen;

                //=====================================================

                L3P.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L3P.Text);
                L3P.BackColor = Color.LightGreen;

                L3F.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L3F.Text);
                L3F.BackColor = Color.LightGreen;

                L3W.Text = L3P.Text;
                L3W.BackColor = Color.LightGreen;

                L3S.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L3S.Text);
                L3S.BackColor = Color.LightGreen;

                //=====================================================

                L4P.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L4P.Text);
                L4P.BackColor = Color.LightGreen;

                L4F.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L4F.Text);
                L4F.BackColor = Color.LightGreen;

                L4W.Text = L4P.Text;
                L4W.BackColor = Color.LightGreen;

                L4S.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(L4S.Text);
                L4S.BackColor = Color.LightGreen;


                //=====================================================


                PW.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(PW.Text);
                PW.BackColor = Color.LightGreen;


                FOM1.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(FOM1.Text);
                FOM1.BackColor = Color.LightGreen;



                FOM2.Text = pracownicy[rand.Next(pracownicy.Count)];
                pracownicy.Remove(FOM2.Text);
                FOM2.BackColor = Color.LightGreen;
            }


        }


        private void DodajPracownika(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                info.Text = "Wprowadź poprawną nazwę";
            }
            else
            {
                pracownicy.Add(textBox1.Text);
                dataGridView1.DataSource = pracownicy.Select(x => new { Nazwa = x }).ToList();
                
                
            }
            
            
            textBox1.ResetText();
        }

        private void usunPracownika_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string prod = (string)dataGridView1.CurrentRow.DataBoundItem;             // usuwanie pracownika z datagrid i listy do ogarnięcia
                pracownicy.Remove(prod);
                dataGridView1.DataSource = pracownicy.ToList();
            }

        }
    }
}
