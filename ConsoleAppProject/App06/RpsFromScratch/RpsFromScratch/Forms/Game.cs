using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RpsFromScratch
{
    public partial class formRps : Form
    {
        //count computer and player victories
        private int _npcCounter;
        private int _playerCounter;
        //store computer and user plays
        private int _npcChoice;
        private int _playerChoice;
        //player nickname and rounds counter
        private string _nickname;
        private int _roundsCounter;
        private int _rounds;

        /// <summary>
        /// This method allows us to get the player nickname and
        /// the rounds he is willing to play from the form: WelcomeMenu
        /// </summary>
        public formRps(string name, int rounds)
        {
            InitializeComponent();
            _nickname = name;
            _roundsCounter = rounds - 1;
            _rounds = rounds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method allows us to quit the game
        /// </summary>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The following three methods allow the player to pick his turn (they also change the previwed image)
        /// This one chooses the Rock 
        /// </summary>
        private void rdbRock_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxUserChoice.Image = imageList1.Images[0];
            _playerChoice = 0;
        }

        /// <summary>
        /// This method allows us to pick Paper
        /// </summary>
        private void rdbPaper_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxUserChoice.Image = imageList1.Images[1];
            _playerChoice = 1;
        }

        /// <summary>
        /// This method allows us to pick Scissors 
        /// </summary>
        private void rdbScissors_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxUserChoice.Image = imageList1.Images[2];
            _playerChoice = 2;
        }

        /// <summary>
        /// THIS METHOD (BUTTON) IS VERY IMPORTANT. It rolls the computer choice,
        /// after that it compares it with the player choice and after that,
        /// it finally displays the result displaying who won.
        /// 
        /// It also stores the scores in a TXT file using StreamWriters and StreamReaders
        /// </summary>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            textBoxPlayerName.Text = "Player: " + _nickname;
            textBoxRounds.Text = "Remaining Rounds: " + Convert.ToString(_roundsCounter);

            int randomplay = new Random().Next(0, 3);

            if(_roundsCounter > 0)
            {
                _roundsCounter--;

                //computer play
                if (randomplay == 0)
                {
                    pictureBoxComputerChoice.Image = imageList2.Images[0];
                    _npcChoice = 0;
                }
                else if (randomplay == 1)
                {
                    pictureBoxComputerChoice.Image = imageList2.Images[1];
                    _npcChoice = 1;
                }
                else if (randomplay == 2)
                {
                    pictureBoxComputerChoice.Image = imageList2.Images[2];
                    _npcChoice = 2;
                }

                //results
                if (_playerChoice == 0 && _npcChoice == 1)
                {
                    textBoxResult.Text = "NPC WON";
                    _npcCounter++;
                }
                else if (_playerChoice == 1 && _npcChoice == 2)
                {
                    textBoxResult.Text = "NPC WON";
                    _npcCounter++;
                }
                else if (_playerChoice == 2 && _npcChoice == 0)
                {
                    textBoxResult.Text = "NPC WON";
                    _npcCounter++;
                }
                else if (_playerChoice == _npcChoice)
                {
                    textBoxResult.Text = "TIE";
                }
                else
                {
                    textBoxResult.Text = _nickname + " WON";
                    _playerCounter++;
                }

                textBoxCounterComputer.Text = "Computer has: " + Convert.ToString(_npcCounter) + " victories!";
                textBoxCounterPlayer.Text = _nickname + " has: " + Convert.ToString(_playerCounter) + " victories!";
            }
            else
            {
                string path = @"C:\Users\Gomez\Documents\GitHub\RpsFromScratch\RpsFromScratch\bin\Debug\netcoreapp3.1\Highscores.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                    TextWriter tw = new StreamWriter(path);
                    tw.WriteLine("RPS Highscores:");
                    tw.Close();
                }
                else if (File.Exists(path))
                {
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(_nickname + " won " + _playerCounter + " times in " + _rounds + " rounds!                                                        ");
                    }
                }

                if (_npcCounter > _playerCounter)
                {
                    System.Windows.Forms.MessageBox.Show("Game Over! You Lost...");
                }
                else if(_npcCounter < _playerCounter)
                {
                    System.Windows.Forms.MessageBox.Show("Congratulations "  + _nickname + "! You Won!");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Game Over! You tied.");
                }

                this.Close();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupboxResult_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxCounterComputer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
