using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibProfesor;

namespace VistaProfesor
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                LNProfesor objP = new LNProfesor();
                objP.Id = txtId.Text;
                objP.Name = txtName.Text;
                objP.Apellido = txtApellido.Text;
                objP.Salario = Convert.ToDouble(txtSalario.Text);
                if (!objP.guardarProfesor())
                {
                    MessageBox.Show(objP.Error);
                    return;
                }
                MessageBox.Show(objP.Resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
