using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace RpsFromScratch
{
    public partial class WelcomeMenu : Form
    {
        //player name and how many rounds he is willing to play
        public string name;
        public int rounds;
        //highscore text file path
        public string path = @"C:\Users\Gomez\Documents\GitHub\RpsFromScratch\RpsFromScratch\bin\Debug\netcoreapp3.1\Highscores.txt";


        /// <summary>
        /// This method loads the scores as soon as we open the WelcomeMenu form.
        /// </summary>
        public WelcomeMenu()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader(@"C:\Users\Gomez\Documents\GitHub\RpsFromScratch\RpsFromScratch\bin\Debug\netcoreapp3.1\Highscores.txt"))
            {
                while (!sr.EndOfStream)
                {
                    richTextBoxHighScores.AppendText(sr.ReadLine());
                }
                sr.Close();
            }
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This method resets the player nickname and rounds willing to play input
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxPlayerName.Clear();
            numericUpDownRounds.Value = 0;
        }

        /// <summary>
        /// This will send you to the game windows unless you haven't 
        /// filled up the name and rounds you are willing to play fields
        /// </summary>
        private void buttonPlayGame_Click(object sender, EventArgs e)
        {
            name = textBoxPlayerName.Text;
            rounds = (int)numericUpDownRounds.Value;

            if(name == null || rounds == 0)
            {
                System.Windows.Forms.MessageBox.Show("Please choose a Player Name and the amount of rounds you wish to play!");
            }
            else
            {
                name = textBoxPlayerName.Text;
                rounds = (int)numericUpDownRounds.Value;
                formRps frm2 = new formRps(name, rounds);
                frm2.Show();
            }
        }

        /// <summary>
        /// This method will close the form
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This method will refresh the Highscores RichTextBox
        /// </summary>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            richTextBoxHighScores.Clear();

            using (StreamReader sr = new StreamReader(path)) 
            {
                while (!sr.EndOfStream)
                {
                    richTextBoxHighScores.AppendText(sr.ReadLine());
                }
                sr.Close();
            }
        }

        /// <summary>
        /// This method will delete the current highscores text file
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxHighScores.Clear();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    File.Delete(path);
                }
                sr.Close();
            }
        }

        private void richTextBoxHighScores_TextChanged(object sender, EventArgs e)
        {
            richTextBoxHighScores.Enabled = false;
        }
    }
}
