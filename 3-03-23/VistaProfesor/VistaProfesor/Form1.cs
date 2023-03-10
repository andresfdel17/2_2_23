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
    public partial class Form1 : Form
    {
        private ProgressBar item;
        public Form1()
        {
            InitializeComponent();
        }

        private void setProgressBar()
        {
            progressBar.Visible = true;
            progressBar.Minimum = 0;
            progressBar.Maximum = 2;
            progressBar.Value = 0;
            progressBar.Step = 1;
            this.item = progressBar;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                string operacion = opList.Text;
                if (operacion == "")
                {
                    MessageBox.Show("No se ha seleccionado una operación válida");
                    return;
                }
                setProgressBar();
                ProgressBar pgBar = this.item;
                LNProfesor objP = new LNProfesor();
                switch (operacion)
                {
                    case "Guardar":
                        objP.Id = txtId.Text;
                        objP.Name = txtName.Text;
                        objP.Apellido = txtLastName.Text;
                        objP.Salario = Convert.ToDouble(txtSalario.Text);
                        pgBar.PerformStep();
                        if (!objP.guardarProfesor())
                        {
                            pgBar.PerformStep();
                            MessageBox.Show(objP.Error);
                            objP = null;
                            return;
                        }
                        break;
                    case "Actualizar":
                        objP.Id = txtId.Text;
                        objP.Name = txtName.Text;
                        objP.Apellido = txtLastName.Text;
                        objP.Salario = Convert.ToDouble(txtSalario.Text);
                        pgBar.PerformStep();
                        if (!objP.actualizarProfesor())
                        {
                            pgBar.PerformStep();
                            MessageBox.Show(objP.Error);
                            objP = null;
                            return;
                        }
                        break;
                    case "Eliminar":
                        objP.Id = txtId.Text;
                        pgBar.PerformStep();
                        if (!objP.eliminarProfesor())
                        {
                            pgBar.PerformStep();
                            MessageBox.Show(objP.Error);
                            objP = null;
                            return;
                        }
                        break;
                }
                pgBar.PerformStep();
                MessageBox.Show(objP.Resultado);
                objP = null;
                txtId.Text = "";
                txtName.Text = "";
                txtLastName.Text = "";
                txtSalario.Text = "0";
                opList.SelectedIndex = -1;
                pgBar.Value = 0;
                pgBar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}
