using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe2.Properties;

namespace TicTacToe2
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        bool turn = true; //true=X false=O
        int turn_count = 0;
        bool against_computer = true;
        

        public Form1()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                test.Text = "Player 2 turn";
            }

            else
            {
                b.Text = "O";
                test.Text = "Player 1 turn";
            }

            turn = !turn;
            
            b.ForeColor = b.Enabled ? Color.Black : Color.Silver;
            b.Enabled = false;

            turn_count++;
            New.Focus();
            checkForWinner();
            
            if ((!turn) && (against_computer))
            {
                computer_make_move();
                test.Text = "";
            }
            
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //orizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();
                test.Text = "";
                String winner = "";
                if (turn)
                {
                    winner = p1.Text;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = p2.Text;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                //MessageBox.Show(winner + " win!!", "yehh!!");
                label.Text = winner + " win!!";
                //New.PerformClick();
            }
            else
            {
                
                if (turn_count == 9)
                {
                    turn = true;
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    //MessageBox.Show("draw", "bummer");
                    label.Text =  " Draw!!";
                    //New.PerformClick();
                    test.Text = "";
                }
            }
        }

        private void disableButtons()
        {
            foreach (Control btn in panel1.Controls)
            {
                btn.Enabled = false;
                //try
                //{
                //    foreach (Component c in Controls)
                //    {
                //        Button b = (Button)c;
                //        b.Enabled = false;
                //        Exit.Enabled = true;
                //        New.Enabled = true;
                //        //reset.Enabled = true;
                //        //button1.Enabled = true;
                //    }
                //}
                //catch { }
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (against_computer == true)
            {
                test.Text = "";
            }
            else
                test.Text = "Player 1 turn";
            turn = true;
            turn_count = 0;
            foreach (Control btn in panel1.Controls)
            {
                btn.Enabled = true;
                btn.Text = "";
            }
            label.Text = "";
            //    foreach (Control c in Controls)
            //{
            //    try
            //    {
            //        Button b = (Button)c;
            //        b.Enabled = true;
            //        b.Text = "";
            //        Exit.Text = "EXIT";
            //        //reset.Text = "R";
            //        New.Text = "NEW";
            //        //button1.Text = "def";
            //    }
            //    catch { }
            //}

        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }

        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            draw_count.Text = "0";
            label.Text = "";
            New.PerformClick();
            //test.Text = "player 1 turn";
        }

        private void computer_make_move()
        {
            Button move = null;

            move = look_for_win_or_move("O");
            if (move == null)
            {
                move = look_for_win_or_move("X");
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = loo_for_open_space();
                    }
                }
            }
            move.PerformClick();
        }

        private Button loo_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (B2.Text == "")
            {
                 return B2;
            }
               
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }
            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }
            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }
            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }
            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C3.Text == "")
                return C3;
            if (C1.Text == "")
                return C1;
            return null;

        }

        private Button look_for_win_or_move(string mark)
        {
            Console.WriteLine("Looking for win or block: " + mark);
            //orizontal
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;
            //verical
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;
            //diagonal
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PvsC.Checked = true;
            p2.Text = "Player 1";
            p1.Text = "Computer";
            //test.Text = "player 1 turn";
        }

        private void PvsP_CheckedChanged(object sender, EventArgs e)
        {
            against_computer = false;
            p2.Text = "Player 1";
            p1.Text = "Player 2";
            Reset.PerformClick();
            New.PerformClick();
            //test.Text = "player 1 turn";
        }

        private void PvsC_CheckedChanged(object sender, EventArgs e)
        {
            against_computer = true;
            p2.Text = "Player 1";
            p1.Text = "Computer";
            Reset.PerformClick();
            New.PerformClick();
            //test.Text = "";
        }

        
    }
}
