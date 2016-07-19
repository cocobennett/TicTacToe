using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = x turn, false = y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Coco\nCourtesy of Tic Tac Toe C# Tutorial on Youtube by Chris", "About Tic Tac Toe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(turn)
            {
                b.Text = "x";
            } else
            {
                b.Text = "o";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool winner = false;

            //horizontal checks
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            {
                winner = true;
            }
            else if((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                winner = true;
            }
            else if((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
            {
                winner = true;
            }


            //vertical checks
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
            {
                winner = true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
            {
                winner = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
            {
                winner = true;
            }

            //diagonial checks
            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            {
                winner = true;
            }
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
            {
                winner = true;
            }



            if (winner)
            {
                disableButtons();
                String name = "";
                if (turn)
                {
                    name = "o";
                    oWinCount.Text = (Int32.Parse(oWinCount.Text) + 1).ToString();
                }
                else
                {
                    name = "x";
                    xWinCount.Text = (Int32.Parse(xWinCount.Text) + 1).ToString();
                }
                MessageBox.Show(name + " wins!", "Yay!");
            }
            else
            {
                if(turn_count==9)
                {
                    drawCount.Text = (Int32.Parse(drawCount.Text) + 1).ToString();
                    MessageBox.Show("It was a draw", "Oh!");
                }
            }

        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            } catch { }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            //reset buttons
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }   
            
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "x";
                }
                else
                {
                    b.Text = "o";
                }
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "";
                }
                else
                {
                    b.Text = "";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oWinCount.Text = "0";
            xWinCount.Text = "0";
            drawCount.Text = "0";
            newGameToolStripMenuItem_Click(sender, e);
        }
    }
}
