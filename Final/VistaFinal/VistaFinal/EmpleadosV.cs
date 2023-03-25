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
    public partial class EmpleadosV : Form
    {
        private static EmpleadosV instancia = null;
        public static EmpleadosV ventana_unica()
        {
            if(instancia == null)
            {
                instancia = new EmpleadosV();
            }
            return instancia;
        }
        public EmpleadosV()
        {
            InitializeComponent();
        }

        private void EmpleadosV_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}
