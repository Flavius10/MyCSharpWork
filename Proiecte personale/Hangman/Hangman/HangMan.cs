using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    public partial class HangMan : Form
    {

        private Bitmap[] hangImages =
        {
            global::Hangman.Properties.Resources.Hangman_0,
            global::Hangman.Properties.Resources.Hangman_1,
            global::Hangman.Properties.Resources.Hangman_2,
            global::Hangman.Properties.Resources.Hangman_3,
            global::Hangman.Properties.Resources.Hangman_4,
            global::Hangman.Properties.Resources.Hangman_5,
            global::Hangman.Properties.Resources.Hangman_6
        };

        private int wrongGuesses = 0;
        private string Current = string.Empty;
        private string[] words;
        private string copyCurrent = string.Empty;


        public HangMan()
        {
            InitializeComponent();
        }

        private void loadwords()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("Cuvinte.txt");
            words = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                words[index++] = line[1];
            }
        }
        private void setupwordChoise()
        {
            wrongGuesses = 0;
            hangImage.Image = hangImages[wrongGuesses];
            int guessIndex = (new Random().Next(words.Length));
            Current = words[guessIndex];
            copyCurrent = "";
            for (int index = 0; index < Current.Length; index++)
            {
                copyCurrent += "_";
            }
            displayCopy();
        }
        private void displayCopy()
        {
            lblRezultat.Text = "";
            for (int index = 0; index < copyCurrent.Length; index++)
            {
                lblRezultat.Text += copyCurrent.Substring(index, 1);
                lblRezultat.Text += " ";
            }
        }
        private void guessClick(object sender, EventArgs e)
        {
            Button choise = sender as Button;
            choise.Enabled = true;
            if (Current.Contains(choise.Text))
            {
                char[] temp = copyCurrent.ToCharArray();
            char[] find = Current.ToCharArray();
                char guessChar = choise.Text.ElementAt(0);
                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();
            }
            else
            {
                wrongGuesses++;
            }
            if (wrongGuesses < 7)
            {
                hangImage.Image = hangImages[wrongGuesses];
            }
            else
            {
                lblRezultat.Text = "Ai pierdut!";
            }
            if (copyCurrent.Equals(Current))
            {
                lblRezultat.Text = "Ai castigat!";
            }
        }
        private void HangMan_Load(object sender, EventArgs e)
        {
            loadwords();
            setupwordChoise();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            setupwordChoise();
            lblRezultat.Text = "";
        }
    
    }
}
