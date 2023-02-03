using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSideApp.CustomTools
{
    public partial class ProgressBarWithText : ProgressBar
    {
        public ProgressBarWithText()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public ProgressBarWithText(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (SolidBrush brush = new SolidBrush(ForeColor))
            {
                e.Graphics.DrawString(Value.ToString() + " secondes restantes", Font, brush,
                    this.ClientRectangle, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }
    }
}
