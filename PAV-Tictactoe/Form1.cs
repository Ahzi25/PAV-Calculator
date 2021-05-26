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
        byte turn_count = 0; // variable to contain counter
        public Form1()
        {
            InitializeComponent();
        }

        private void TicTacButton_Click(object sender, EventArgs e)
        {
            Button tictacButton = (Button)sender;
            if (player_turn) // if player turn = true
            {
                tictacButton.Text = "X";                                                                                                                                           
            }
            else // if player turn = false
            {
                tictacButton.Text = "O";
            }
           
            player_turn = !player_turn; // player_turn value changer every click

            tictacButton.Enabled = false; // locks the text value of button every click

            turn_count += 1;
            WinnerChecker();
        }
        private void WinnerChecker() // checks if there is a winner
        {
            bool gameSet = false;
            
            if ((button1.Text == button2.Text)&&(button2.Text == button3.Text) && (!button1.Enabled))
                gameSet = true;
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) &&(!button1.Enabled))
                gameSet = true;
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                gameSet = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                gameSet = true; 
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                gameSet = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                gameSet = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text)&& (!button7.Enabled))
                gameSet = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
                gameSet = true;

            if (gameSet)
            {
                ButtonsDisable();
                string winner = "";
                if (player_turn)
                    winner += "Player 2";
                else
                    winner += "Player 1";
                string title = "Tic-tac-toe";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(winner + " " + "wins" + " " + "Play again?", title, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
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
                    Application.Restart();
                }
                else
                    this.Close();
            }
            
        }
        private void ButtonsDisable() // prevents win evaluation every turn
        {
            try {
                foreach (Control c in Controls)
                {
                    Button tictacButton = (Button)c;
                    tictacButton.Enabled = false;
                }
            }
            catch { }
        } 

        private void Form1_Load(object sender, EventArgs e)                                                                                                                                          
        {

        }
    }
}
