using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSideApp
{
    public partial class GenerateurDeJetons : Form
    {
        Compteur monChrono = null;
        public GenerateurDeJetons()
        {
            InitializeComponent();
            monChrono = new Compteur(60 - DateTime.Now.Second, monTimer, progressBarWithText1, lbl_compteur); // donne le nombre de secondes restantes à la minute qui s'écoule actuellement et mon Timer winforms
        }

        private void GenerateurDeJetons_Shown(object sender, EventArgs e)
        {
            Countdown(); //Quand la fenêtre est générée, on peut commencer le countdown
        }

        private void Countdown()
        {
            monChrono.StartTimer();
        }

    }
}
