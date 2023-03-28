using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibEmpleado;
using LibLlenarGrids;

namespace VistaFinal
{
    public partial class EmpleadosV : Form
    {
        private static EmpleadosV instancia = null;
        public static EmpleadosV ventana_unica()
        {
            if (instancia == null)
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

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                dtGridEmpl.Visible = false;
                ClsLnEmpleado objE = new ClsLnEmpleado();
                switch (comProcess.Text)
                {
                    case "Guardar":
                        objE.Name = txtNombre.Text;
                        objE.Last_name = txtApellidos.Text;
                        objE.Email = txtEmail.Text;
                        objE.Phone = txtTelefono.Text;
                        if (!objE.GuardarEmpleado())
                        {
                            MessageBox.Show(objE.Error);
                            return;
                        }
                        MessageBox.Show(objE.Resultado);
                        objE = null;
                        ResetForm();
                        Listar();
                        break;
                    case "Editar":
                        objE.Id = Convert.ToInt32(txtId.Text);
                        objE.Name = txtNombre.Text;
                        objE.Last_name = txtApellidos.Text;
                        objE.Email = txtEmail.Text;
                        objE.Phone = txtTelefono.Text;
                        if (!objE.EditarEmpleado())
                        {
                            MessageBox.Show(objE.Error);
                            return;
                        }
                        MessageBox.Show(objE.Resultado);
                        objE = null;
                        ResetForm();
                        Listar();
                        break;
                    case "Eliminar":
                        objE.Id = Convert.ToInt32(txtId.Text);
                        if (!objE.EliminarEmpleado())
                        {
                            MessageBox.Show(objE.Error);
                            return;
                        }
                        MessageBox.Show(objE.Resultado);
                        objE = null;
                        ResetForm();
                        Listar();
                        break;
                    case "Consultar":
                        objE.Id = Convert.ToInt32(txtId.Text);
                        if (!objE.ConsultarEmpleado())
                        {
                            MessageBox.Show(objE.Error);
                            return;
                        }
                        SqlDataReader reader = null;
                        reader = objE.EmReader;
                        reader.Read();
                        txtNombre.Text = reader.GetString(1);
                        txtApellidos.Text = reader.GetString(2);
                        txtEmail.Text = reader.GetString(3);
                        txtTelefono.Text = reader.GetString(4);
                        reader.Close();
                        objE = null;
                        break;
                    default:
                        MessageBox.Show("Por favor elija una opción válida");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ResetForm()
        {
            txtNombre.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            comProcess.SelectedIndex = -1;
        }

        private void ComProcess_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] status = { "Editar", "Consultar", "Eliminar" };
                if (Array.Exists(status, element => element.ToString() == comProcess.Text))
                {
                    txtId.Visible = true;
                    labelId.Visible = true;
                    return;
                }
                txtId.Text = String.Empty;
                txtId.Visible = false;
                labelId.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Listar()
        {
            try
            {
                dtGridEmpl.Visible = true;
                ClsLLenarGrids objL = new ClsLLenarGrids();
                objL.NombreTabla = "empleado";
                objL.SQL = "usp_listar_empleado";
                if (!objL.LlenarGrid(dtGridEmpl))
                {
                    MessageBox.Show(objL.ERROR);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
