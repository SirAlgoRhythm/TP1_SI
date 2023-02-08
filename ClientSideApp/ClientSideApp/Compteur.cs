﻿using ClientSideApp.CustomTools;
using System;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;

namespace ClientSideApp
{
    public class Compteur
    {
        private int _secondes;
        public int SecondesRestantes { get { return _secondes; } set { _secondes = value; } }

        private Timer _timer;

        private ProgressBarWithText _progressBar;

        private Label lblDuCompteur;

        public Compteur(int SecondesRestantes, Timer monTimer, ProgressBarWithText progressBarWithText, Label lblCompteur)
        {
            this.SecondesRestantes = SecondesRestantes;
            this._timer = monTimer;
            _timer.Tick += _timer_Tick;
            _progressBar = progressBarWithText;
            lblDuCompteur = lblCompteur;
        }

        public void _timer_Tick(object sender, EventArgs e)
        {
            SecondesRestantes--;
            if (SecondesRestantes == 0)
            {
                //générer une nouvelle clée
                SecondesRestantes = 60;
            }
            lblDuCompteur.Text = SecondesRestantes.ToString();
            _progressBar.Secondes = SecondesRestantes; //donne la seconde qui doit être afficher sur le progressBar    
        }

        public void StartTimer()
        {
            _timer.Start();   
        }
    }
}