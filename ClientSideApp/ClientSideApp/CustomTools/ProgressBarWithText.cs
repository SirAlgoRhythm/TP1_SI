
using System.ComponentModel;

namespace ClientSideApp.CustomTools
{
    public partial class ProgressBarWithText : System.Windows.Forms.ProgressBar
    {
        private int secondes;

        public int Secondes
        {
            get { return secondes; }
            set 
            { 
                secondes = value;
                Invalidate();
                this.Value = 60 - secondes;
            }
        }

        public ProgressBarWithText(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
