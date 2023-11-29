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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
        string intr2 = "Cand a fost Coreea împărțită în 2 națiuni?";  //WW2
        string intr3 = "Care este cea mai veche civilizație din lume?";  //Mesopotamia
        string intr4 = "Cine se numește Napoleon al Iranului?"; //Nader Shah
        string intr5 = "Care este ultima dinastie din China?"; //dinastia Qing
        string intr6 = "Cine este primul președinte al Statelor Unite?"; //George Washington
        string intr7 = "În ce an a fost asasinat John F. Kennedy?"; //1963
        string intr8 = "A cui perioadă a fost cunoscută drept Epoca de Aur a Romei?"; //Augustus Cezar
        string intr9 = "Unde se află rămășița Babilonului?"; //Irak
        string intr10 = "Cine a fost primul om care a mers pe Lună? "; //Neil Armstrong
        bool btnwasclicked = false;

        private void timer1_Tick(object sender, EventArgs e)
        {

            seconds++;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            labelTimer.Text = time.ToString(@"hh\:mm\:ss");
            PunctajShowUp();
            
            


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
            if (intrb_txt.Text == intr1)
            {
                checkBox1.Text = "1914";
                checkBox2.Text = "1918";
                checkBox3.Text = "1939";
                checkBox4.Text = "1945";
            }

            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (intrb_txt.Text == intr1 && btnwasclicked)
            {
                PuncteUp();
            }
            else if (intrb_txt.Text == intr2 && btnwasclicked)
            {
                PuncteDown();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnwasclicked = true;
            if (intrb_txt.Text == intr1 && btnwasclicked == true)
            {
                intrb_txt.Text = intr2;
                btnwasclicked = false;
                if (checkBox1.Checked)            
                    punctaj += 5;  
                else
                    punctaj -= 5;

            }
            else if (intrb_txt.Text == intr2 && btnwasclicked)
            {
                intrb_txt.Text = intr3;
                btnwasclicked = false;
                if (checkBox2.Checked)
                    punctaj += 5;
                else
                    punctaj -= 5;

            }

            else if (intrb_txt.Text == intr3 && btnwasclicked)
            {
                intrb_txt.Text = intr4;
                btnwasclicked = false;
                if (checkBox1.Checked)
                    punctaj += 5;
                else
                    punctaj -= 5;

            }

            else if (intrb_txt.Text == intr4 && btnwasclicked)
            {
                btnwasclicked = false;
                intrb_txt.Text = intr5;
                if (checkBox2.Checked)
                    punctaj += 5;
                else
                    punctaj -= 5;
            }

            else if (intrb_txt.Text == intr5 && btnwasclicked)
            {
                intrb_txt.Text = intr6;
                btnwasclicked = false;
                if (checkBox4.Checked)
                    punctaj += 5;
                else
                    punctaj -= 5;
            }
            else if (intrb_txt.Text == intr6 && btnwasclicked)
            {

                intrb_txt.Text = intr7;
                btnwasclicked = false;
                if (checkBox3.Checked)
                    punctaj += 5;
                else
                    punctaj -= 5;

            }
            else if (intrb_txt.Text == intr7 && btnwasclicked)
            {
                btnwasclicked = false;
                intrb_txt.Text = intr8;
                if (checkBox3.Checked)
                    punctaj += 5;
                else
                    punctaj -= 5;

            }
            else if (intrb_txt.Text == intr8 && btnwasclicked)
            {
                btnwasclicked = false;
                intrb_txt.Text = intr9;
                if (checkBox2.Checked)
                    punctaj += 5;
                else
                    punctaj -= 5;

            }
            else if (intrb_txt.Text == intr9 && btnwasclicked)
            {
                intrb_txt.Text = intr10;
                btnwasclicked = false;
                if (checkBox2.Checked)
                    punctaj += 5;
                else
                    punctaj -= 5;
            }
            else if (intrb_txt.Text == intr10 && btnwasclicked)
            {
                Thread.Sleep(1000);
                MessageBox.Show( "Felicitari , ai obtinut " + punctaj + " de puncte!");
                btnwasclicked = false;
                if (checkBox2.Checked)
                    punctaj += 5;
                else
                    punctaj -= 5;
            }

            if (intrb_txt.Text == intr1)
            {
                checkBox1.Text = "1914";
                checkBox2.Text = "1918";
                checkBox3.Text = "1939";
                checkBox4.Text = "1945";
            }
            else if (intrb_txt.Text == intr2)
            {
                checkBox1.Text = "Primul Razboi Mondial";
                checkBox2.Text = "Al doilea Razboi Mondial";
                checkBox3.Text = "Razboiul Rece";
                checkBox4.Text = "Razboiul Vietnamez";
            }
            else if (intrb_txt.Text == intr3)
            {
                checkBox1.Text = "Mesopotamia";
                checkBox2.Text = "Egipt";
                checkBox3.Text = "Bucuresti";
                checkBox4.Text = "Islanda";
            }
            else if (intrb_txt.Text == intr4)
            {
                checkBox1.Text = "Muhammad I";
                checkBox2.Text = "Nader Shah";
                checkBox3.Text = "Muhamad II";
                checkBox4.Text = "Raul Sabou";

            }
            else if (intrb_txt.Text == intr5)
            {
                checkBox1.Text = "Mulan";
                checkBox2.Text = "Jun Takahasi";
                checkBox3.Text = "Ding";
                checkBox4.Text = "Qing";

            }
            else if (intrb_txt.Text == intr6)
            {
                checkBox1.Text = "Lica Samadaul";
                checkBox2.Text = "Columb";
                checkBox3.Text = "George Washington";
                checkBox4.Text = "Donald Trump";

            }
            else if (intrb_txt.Text == intr7)
            {
                checkBox1.Text = "1960";
                checkBox2.Text = "1953";
                checkBox3.Text = "1963";
                checkBox4.Text = "1972";

            }
            else if (intrb_txt.Text == intr8)
            {
                checkBox1.Text = "Iulius Cezar";
                checkBox2.Text = "Augustus Cezar";
                checkBox3.Text = "Lucius Tarquinius Superbus";
                checkBox4.Text = "Servius Tullius";

            }
            else if (intrb_txt.Text == intr9)
            {
                checkBox1.Text = "Irak";
                checkBox2.Text = "Iran";
                checkBox3.Text = "Palestina";
                checkBox4.Text = "Nigeria";

            }
            else if (intrb_txt.Text == intr10)
            {
                checkBox1.Text = "Yuri Gagarin";
                checkBox2.Text = "Neil Armstrong";
                checkBox3.Text = "Buzz Aldrin";
                checkBox4.Text = "Alan Bean";

            }




            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
           


        }

        private void PunctajShowUp()
        {
            label2.Text = "Punctaj:" + punctaj.ToString();
        }

        
        
     private void timer3_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
