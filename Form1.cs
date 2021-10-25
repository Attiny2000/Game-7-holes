using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_holes
{
    public partial class Form1 : Form
    {
        private static Hole[] holes = new Hole[7];
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GameRefresh();
        }
        private static void GameRefresh()
        {
            holes[0] = new Hole(Program.form1.button1, "black");
            holes[1] = new Hole(Program.form1.button2, "black");
            holes[2] = new Hole(Program.form1.button3, "black");
            holes[3] = new Hole(Program.form1.button4);
            holes[4] = new Hole(Program.form1.button5, "white");
            holes[5] = new Hole(Program.form1.button6, "white");
            holes[6] = new Hole(Program.form1.button7, "white");
            Program.form1.button1.BackgroundImage = Properties.Resources.black;
            Program.form1.button2.BackgroundImage = Properties.Resources.black;
            Program.form1.button3.BackgroundImage = Properties.Resources.black;
            Program.form1.button4.BackgroundImage = null;
            Program.form1.button5.BackgroundImage = Properties.Resources.white;
            Program.form1.button6.BackgroundImage = Properties.Resources.white;
            Program.form1.button7.BackgroundImage = Properties.Resources.white;
            Program.form1.button1.Focus();

        }

        private void checkResult()
        {
            if (holes[0].color == "white" && holes[1].color == "white" && holes[2].color == "white" && holes[4].color == "black" && holes[5].color == "black" && holes[6].color == "black")
                MessageBox.Show("Victory!", "Game is finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void noSelectButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                if (holes[i].button.Focused)
                {
                    try
                    {
                        for (int j = i; j >= 0; j--)
                        {
                            if (holes[j].isEmpty)
                            {
                                holes[j].color = holes[i].color;
                                holes[j].button.BackgroundImage = holes[i].button.BackgroundImage;
                                holes[j].isEmpty = false;
                                holes[j].button.Focus();
                                holes[i].button.BackgroundImage = null;
                                holes[i].color = "No color";
                                holes[i].isEmpty = true;
                                break;
                            }
                        }
                        checkResult();
                    }
                    catch { }
                    break;
                }
            }
        }

        private void noSelectButton3_Click(object sender, EventArgs e)
        {
            GameRefresh();
        }

        private void noSelectButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                if (holes[i].button.Focused)
                {
                    try
                    {
                        for (int j = i; j < 7; j++)
                        {
                            if (holes[j].isEmpty)
                            {
                                holes[j].color = holes[i].color;
                                holes[j].button.BackgroundImage = holes[i].button.BackgroundImage;
                                holes[j].isEmpty = false;
                                holes[j].button.Focus();
                                holes[i].button.BackgroundImage = null;
                                holes[i].color = "No color";
                                holes[i].isEmpty = true;
                                break;
                            }
                        }    
                        checkResult();
                    }
                    catch { }
                    break;
                }
            }
        }
    }
}
