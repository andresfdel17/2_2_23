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
    public partial class FacturasV : Form
    {
        private static FacturasV instancia = null;
        public static FacturasV Ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FacturasV();
            }
            return instancia;
        }
        public FacturasV()
        {
            InitializeComponent();
        }

        private void FacturasV_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
