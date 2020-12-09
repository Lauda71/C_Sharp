using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace radiobutton_checkbox_Yeah
{
    public partial class Main_Form : Form
    {


        SoundPlayer Play1 = new System.Media.SoundPlayer(@"C:\Users\User\source\repos\radiobutton_checkbox_Yeah\radiobutton_checkbox_Yeah\bin\Debug\NuPogodi.wav");
        SoundPlayer Play2 = new System.Media.SoundPlayer(@"C:\Users\User\source\repos\radiobutton_checkbox_Yeah\radiobutton_checkbox_Yeah\bin\Debug\Masuda.wav");
        SoundPlayer Play3 = new System.Media.SoundPlayer(@"C:\Users\User\source\repos\radiobutton_checkbox_Yeah\radiobutton_checkbox_Yeah\bin\Debug\Nightcall.wav");
        SoundPlayer Play4 = new System.Media.SoundPlayer(@"C:\Users\User\source\repos\radiobutton_checkbox_Yeah\radiobutton_checkbox_Yeah\bin\Debug\CB.wav");
        SoundPlayer Play5 = new System.Media.SoundPlayer(@"C:\Users\User\source\repos\radiobutton_checkbox_Yeah\radiobutton_checkbox_Yeah\bin\Debug\Orax2.wav");
        SoundPlayer Play6 = new System.Media.SoundPlayer(@"C:\Users\User\source\repos\radiobutton_checkbox_Yeah\radiobutton_checkbox_Yeah\bin\Debug\Plenka.wav");

        //RadioButton rb_mus1 = (RadioButton)sender;

        int gif1 = 0, gif2 = 0, gif3 = 0, gif4 = 0, gif5 = 0, gif6 = 0;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void rb_mus1_CheckedChanged(object sender, EventArgs e)
        {            
        }

        private void fb_music_Enter(object sender, EventArgs e)
        {
        }

        private void letsplay1(object sender, EventArgs e)
        {
            Play2.Stop();
            Play3.Stop();
            Play4.Stop();
            Play5.Stop();
            Play6.Stop();

            Play1.Play();            
        }

        private void letsplay2(object sender, EventArgs e)
        {
            Play1.Stop();
            Play3.Stop();
            Play4.Stop();
            Play5.Stop();
            Play6.Stop();

            Play2.Play();
        }

        private void letsplay3(object sender, EventArgs e)
        {
            Play2.Stop();
            Play1.Stop();
            Play4.Stop();
            Play5.Stop();
            Play6.Stop();

            Play3.Play();
        }

        private void letsplay4(object sender, EventArgs e)
        {
            Play2.Stop();
            Play3.Stop();
            Play1.Stop();
            Play5.Stop();
            Play6.Stop();

            Play4.Play();
        }

        private void letsplay5(object sender, EventArgs e)
        {
            Play2.Stop();
            Play3.Stop();
            Play4.Stop();
            Play1.Stop();
            Play6.Stop();

            Play5.Play();
        }

        private void stop(object sender, EventArgs e)
        {
            Play1.Stop();
            Play2.Stop();
            Play3.Stop();
            Play4.Stop();
            Play5.Stop();
            Play6.Stop();
        }

        private void letsplay6(object sender, EventArgs e)
        {
            Play2.Stop();
            Play3.Stop();
            Play4.Stop();
            Play1.Stop();
            Play5.Stop();

            Play6.Play();
        }

        private void gifNP(object sender, EventArgs e)
        {
            gif1++;
            if (gif1 == 1) { NP.Visible = true; }
            else { NP.Visible = false; gif1 = 0; }
        }

        private void gifMasuda(object sender, EventArgs e)
        {
            
            gif2++;
            if (gif2 == 1) { Masuda.Visible = true; }
            else { Masuda.Visible = false; gif2 = 0; }
        }

        private void gifNc(object sender, EventArgs e)
        {
            
            gif3++;
            if (gif3 == 1) { Nightcall.Visible = true; }
            else { Nightcall.Visible = false; gif3 = 0; }
        }

        private void gifBru(object sender, EventArgs e)
        {
            
            gif4++;
            if (gif4 == 1) { Brut.Visible = true; }
            else { Brut.Visible = false; gif4 = 0; }
        }

        private void gifOra(object sender, EventArgs e)
        {
            
            gif5++;
            if (gif5 == 1) { Orax.Visible = true; }
            else { Orax.Visible = false; gif5 = 0; }
        }

        private void gifPlen(object sender, EventArgs e)
        {
            
            gif6++;
            if (gif6 == 1) { Plenka.Visible = true; }
            else { Plenka.Visible = false; gif6 = 0; }
        }
    }
}
