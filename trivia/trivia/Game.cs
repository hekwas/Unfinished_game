using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace trivia
{

    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        private int seconds = 0;
        private int punctaj = 0;
        string intr1 = "Cand a inceput primul razboi mondial?";
        string intr2 = "Ce este dava?";
        string intr3 = "";
        string intr4 = "";
        string intr5 = "";
        string intr6 = "";
        string intr7 = "";
        string intr8 = "";
        string intr9 = "";
        string intr10 = "";

        bool btnwasclicked = false;
        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            seconds++;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            labelTimer.Text = time.ToString(@"hh\:mm\:ss");

        }
        private void PuncteUp()
        {
            punctaj += 10;
        }
        private void PuncteDown()
        {
            punctaj -= 10;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        { 
            timer1.Start();
            intrb_txt.Text = intr1;
            checkBox1.Text = "1914";
            checkBox2.Text = "1918";
            checkBox3.Text = "1939";
            checkBox4.Text = "1945";


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(intrb_txt.Text == intr1)
            {
                checkBox1.Text = "1914";
                checkBox2.Text = "1918";
                checkBox3.Text = "1939";
                checkBox4.Text = "1945";
            }
            if (intrb_txt.Text == intr2)
            {
                checkBox1.Text = "Cetate Daco-Getica";
                checkBox2.Text = "Regat Daco-Getic";
                checkBox3.Text = "Constructie Dacp-Getica";
                checkBox4.Text = "Fortareata Daco-Getica";
            }

            if (intrb_txt.Text == intr1 &&  btnwasclicked)
            {
                PuncteUp();
            }
            if (intrb_txt.Text == intr2 && btnwasclicked)
            {
                PuncteDown();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (intrb_txt.Text == intr1 && btnwasclicked)
            {
                PuncteDown();
            }
            if (intrb_txt.Text == intr2 && btnwasclicked)
            {
                PuncteDown();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (intrb_txt.Text == intr1 && btnwasclicked)
            {
                PuncteDown();
            }
            if (intrb_txt.Text == intr2 && btnwasclicked)
            {
                PuncteDown();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (intrb_txt.Text == intr1 && btnwasclicked)
            {
                PuncteDown();
            }
            if (intrb_txt.Text == intr2 && btnwasclicked)
            {
                PuncteUp();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            btnwasclicked = true;
            Thread.Sleep(1000);
            btnwasclicked = false;
            checkBox1.CheckState =CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            string data_intrebare = "intr";
            string intrr = data_intrebare +i.ToString();
            intrb_txt.Text = intrr;
        }
    }
}
