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

        public Compteur(int SecondesRestantes, Timer monTimer)
        {
            this.SecondesRestantes = SecondesRestantes;
            this._timer = monTimer;
        }

        public void StartTimer()
        {
            _timer.Start();   
        }
    }
}