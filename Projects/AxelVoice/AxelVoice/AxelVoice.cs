using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;

namespace AxelVoice
{
    public partial class AxelVoice : Form
    {
        public AxelVoice()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (rtbText.Text != string.Empty)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Volume = trbVolume.Value * 10;
                synth.Speak(rtbText.Text);
            }
            else
            {
                MessageBox.Show("Nu pot citi textul", "Text de necitit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine engine = new SpeechRecognitionEngine();
            Grammar word = new DictationGrammar();
            engine.LoadGrammar(word);

            try
            {
                rtbTextSpeak.Text = "Listening now...";
                engine.SetInputToDefaultAudioDevice();
                RecognitionResult result = engine.Recognize();
                rtbTextSpeak.Clear();
                rtbTextSpeak.Text = result.Text;
            }
            catch
            {
                rtbTextSpeak.Text = string.Empty;
                MessageBox.Show("Mic not found");
            }
            finally
            {
                engine.UnloadAllGrammars();
            }
        }  


        private void btnClose_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine engine = new SpeechRecognitionEngine();
            Grammar word = new DictationGrammar();
            engine.LoadGrammar(word);

            try
            {
                engine.SetInputToDefaultAudioDevice();
                RecognitionResult result = engine.Recognize();
                string raspuns = result.Text;

                string close = "Close";
                DialogResult dr = new DialogResult();

                if (raspuns == close)
                {
                    dr = MessageBox.Show("Doriti sa inchideti aplicatia?", "Aplicatie inchisa", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }

                if (dr == DialogResult.OK)
                {
                    Thread.Sleep(2000);
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Mic not found");
            }
        }
    }
}
