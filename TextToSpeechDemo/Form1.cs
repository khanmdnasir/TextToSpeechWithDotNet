using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextToSpeechDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SpeechSynthesizer synth = new SpeechSynthesizer();
        private void SpeechButton_Click(object sender, EventArgs e)
        {
            if (VoiceComboBox.Text == "Male")
            {
                synth.SelectVoiceByHints(VoiceGender.Male);
            }

            if (VoiceComboBox.Text == "Female")
            {
                synth.SelectVoiceByHints(VoiceGender.Female);
            }
            
            synth.Speak(textBox1.Text);
        }

        private void SoundTrackBar_Scroll(object sender, EventArgs e)
        {
            synth.Volume = SoundTrackBar.Value;
        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            synth.Rate = SpeedTrackBar.Value;
        }

        
    }
}
