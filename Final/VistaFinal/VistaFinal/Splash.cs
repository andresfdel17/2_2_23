using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaFinal
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgrBar.Increment(1);
            progressText.Text = pgrBar.Value.ToString() + "%";
            if(pgrBar.Value == pgrBar.Maximum)
            {
                timer1.Stop();
                this.Hide();
                FormMDI formParent = new FormMDI();
                formParent.ShowDialog();
            }
        }
    }
}
