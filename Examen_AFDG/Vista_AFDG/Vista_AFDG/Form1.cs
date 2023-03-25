using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_LN_AFDG;

namespace Vista_AFDG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Clase_AFDG objC = new Clase_AFDG();
                pgBar.Minimum = 0;
                pgBar.Maximum = 2;
                pgBar.Value = 0;
                pgBar.Step = 1;
                pgBar.Visible = true;
                objC.Codigo = Convert.ToInt32(txtCodigo.Text);
                objC.Caracteristicas = txtCaract.Text;
                pgBar.PerformStep();
                if (!objC.saveRegister())
                {
                    pgBar.PerformStep();
                    MessageBox.Show(objC.Error);
                    pgBar.Visible = false;
                    pgBar.Value = 0;
                    objC = null;
                    return;
                }
                pgBar.PerformStep();
                MessageBox.Show(objC.Resultado);
                objC = null;
                txtCaract.Text = "";
                txtCodigo.Text = "0";
                pgBar.Visible = false;
                pgBar.Value = 0;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
