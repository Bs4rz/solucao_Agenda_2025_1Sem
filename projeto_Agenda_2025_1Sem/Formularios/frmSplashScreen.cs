using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // Inclui  a biblioteca de sons

namespace projeto_Agenda_2025_1Sem.Formularios
{
    public partial class frmSplashScreen : Form
    {
        //vai colocar a musica
        SoundPlayer minhaMusica = new SoundPlayer(@"C:\Users\LabInfo\Desktop\solucao_Agenda_2025_1Sem\projeto_Agenda_2025_1Sem\Songs\doomSong.wav");

        public frmSplashScreen()
        {
            InitializeComponent();
            minhaMusica.Play(); //Toca a musica
            EfectTime();
            
        }
        private bool Efect = true; //variavel lógica
        private void TimerSplashScreen_Tick(object sender, EventArgs e)
        {
            if (Efect)
            {
                this.Opacity -= 0.01D;//Diminui a opacidade do form
                //esquivale a This.Opacity = this.Opacity - 0.01
            }
            if (this.Opacity == 0)
            {
                Efect = false;

                TimerSplashScreen.Enabled = false;//Desliga o timer
                //Adicionar login "frmLogin = new frmLogin()"
                //frmLogin.Show();
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
                minhaMusica.Stop();
                this.Hide();//oculta sem tirar da memoria
            }
        }
        private void EfectTime()
        {
            TimerSplashScreen.Interval = 190;
            TimerSplashScreen.Tick += new EventHandler(TimerSplashScreen_Tick);
            TimerSplashScreen.Enabled = true;
            this.Opacity = 1;
        }

    }
}
