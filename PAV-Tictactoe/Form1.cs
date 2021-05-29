using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV_Tictactoe
{
    public partial class Form1 : Form
    {
        bool player_turn = true; // if true, player 1's turn; if false, player 2's turn
        int turn_count = 0; // variable to contain counter
        int scoreTwo = 0;
        int scoreOne = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TicTacButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (player_turn) // if player turn = true
            {
                b.Text = "X";
                playerTurn.Text = "Player one's turn";
            }
            else // if player turn = false
            {
                b.Text = "O";
                playerTurn.Text = "Player one's turn";
            }
           
            player_turn = !player_turn;
            b.Enabled = false; 

            turn_count += 1;
            
            WinnerChecker();
        }
        private void WinnerChecker() // checks if there is a winner
        {
            bool gameSet = false;
            
            if ((button_R1C1.Text == button_R1C2.Text)&&(button_R1C2.Text == button_R1C3.Text) && (!button_R1C1.Enabled))
                gameSet = true;
            else if ((button_R1C1.Text == button_R2C2.Text) && (button_R2C2.Text == button_R3C3.Text) &&(!button_R1C1.Enabled))
                gameSet = true;
            else if ((button_R1C1.Text == button_R2C1.Text) && (button_R2C1.Text == button_R3C1.Text) && (!button_R1C1.Enabled))
                gameSet = true;
            else if ((button_R1C2.Text == button_R2C2.Text) && (button_R2C2.Text == button_R3C2.Text) && (!button_R1C2.Enabled))
                gameSet = true; 
            else if ((button_R2C1.Text == button_R2C2.Text) && (button_R2C2.Text == button_R2C3.Text) && (!button_R2C1.Enabled))
                gameSet = true;
            else if ((button_R1C3.Text == button_R2C3.Text) && (button_R2C3.Text == button_R3C3.Text) && (!button_R1C3.Enabled))
                gameSet = true;
            else if ((button_R3C1.Text == button_R3C2.Text) && (button_R3C2.Text == button_R3C3.Text)&& (!button_R3C1.Enabled))
                gameSet = true;
            else if ((button_R1C3.Text == button_R2C2.Text) && (button_R2C2.Text == button_R3C1.Text) && (!button_R1C3.Enabled))
                gameSet = true;
            
            
           
            if (gameSet)
            {
                
                string winner = "";
                if (player_turn)
                {
                    winner += "Player 2";
                    scoreTwo += 1;
                    TwoScore.Text = "Player two: " + scoreTwo;
                }
                else
                {
                    winner += "Player 1";
                    scoreOne += 1;
                    OneScore.Text = "Player one: " + scoreOne; 
                }

                string title = "Tic-tac-toe";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(winner + " " + "wins." + " " + "Play again?", title, buttons);
                if (result == DialogResult.Yes)
                {
                    PlayAgain();
                }
                else
                    this.Close();
            }
            else if (turn_count == 9) // if there is no winner until last button
            {
                string title = "Tic-tac-toe";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show( "Draw. Play again?", title, buttons);
                if (result == DialogResult.Yes)
                {
                    PlayAgain();
                }
                else
                    this.Close();
            }
            
        }

        private void PlayAgain() 
        {
            foreach(var Control in Controls)    
            {
                if (Control is Button b)
                {
                    if (b.Name.StartsWith("button_R"))
                    {
                        b.Enabled = true;
                        b.Text = "";
                    }
                }
            }
            
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            scoreOne = 0;
            scoreTwo = 0;
            OneScore.Text = "Player one: " + scoreTwo;
            TwoScore.Text = "Player two: " + scoreTwo;
            
            foreach (var Control in Controls)
            {
                if (Control is Button b)
                {
                    if (b.Name.StartsWith("button_R"))
                    {
                        b.Enabled = true;
                        b.Text = "";
                    }
                }
            }

        }

    }
}
