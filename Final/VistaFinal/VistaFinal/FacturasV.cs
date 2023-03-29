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
using LibFactura;
using System.Reflection.Emit;

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

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ValidateEmpleado();
        }

        bool ValidateEmpleado()
        {
            try
            {
                ClsLnEmpleado objE = new ClsLnEmpleado();
                objE.Id = Convert.ToInt32(txtIdEmpl.Text);
                if (!objE.ConsultarEmpleado())
                {
                    MessageBox.Show(objE.Error);
                    return false;
                }
                SqlDataReader reader = objE.EmReader;
                reader.Read();
                txtNombreEmpl.Text = reader.GetString(1);
                reader.Close();
                return true;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                dtGridFacturas.Visible = false;
                ClsLnFacturas objE = new ClsLnFacturas();
                switch (comOp.Text)
                {
                    case "Guardar":
                        objE.Id_empleado = Convert.ToInt32(txtIdEmpl.Text);
                        objE.Cliente = txtCliente.Text;
                        objE.Nit_cliente = txtNitCliente.Text;
                        objE.Producto = txtProducto.Text;
                        objE.Cantidad = Convert.ToInt32(txtCantidad.Text);
                        objE.Valor = Convert.ToDouble(txtValor.Text);
                        if (!objE.GuardarFactura())
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
                        objE.Id = Convert.ToInt32(txtIdFactura.Text);
                        objE.Id_empleado = Convert.ToInt32(txtIdEmpl.Text);
                        objE.Cliente = txtCliente.Text;
                        objE.Nit_cliente = txtNitCliente.Text;
                        objE.Producto = txtProducto.Text;
                        objE.Cantidad = Convert.ToInt32(txtCantidad.Text);
                        objE.Valor = Convert.ToDouble(txtValor.Text);
                        if (!objE.EditarFactura())
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
                        objE.Id = Convert.ToInt32(txtIdFactura.Text);
                        if (!objE.EliminarFactura())
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
                        objE.Id = Convert.ToInt32(txtIdFactura.Text);
                        if (!objE.ConsultarFactura())
                        {
                            MessageBox.Show(objE.Error);
                            return;
                        }
                        SqlDataReader reader = null;
                        reader = objE.EmReader;
                        reader.Read();
                        txtIdEmpl.Text = reader.GetInt32(1).ToString();
                        txtCliente.Text = reader.GetString(2);
                        txtNitCliente.Text = reader.GetString(3);
                        txtProducto.Text = reader.GetString(4);
                        txtCantidad.Text = reader.GetInt32(5).ToString();
                        txtValor.Text = reader.GetDouble(6).ToString();
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
            txtIdEmpl.Text = String.Empty;
            txtIdFactura.Text = String.Empty;
            txtCliente.Text = String.Empty;
            txtNombreEmpl.Text = String.Empty;
            txtNitCliente.Text = String.Empty;
            txtProducto.Text = String.Empty;
            txtCantidad.Text = String.Empty;
            txtValor.Text = String.Empty;
            comOp.SelectedIndex = -1;
        }
        private void Listar()
        {
            try
            {
                dtGridFacturas.Visible = true;
                ClsLLenarGrids objL = new ClsLLenarGrids();
                objL.NombreTabla = "factura";
                objL.SQL = "usp_listar_factura";
                if (!objL.LlenarGrid(dtGridFacturas))
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

        private void comOp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] status = { "Editar", "Consultar", "Eliminar" };
                if (Array.Exists(status, element => element.ToString() == comOp.Text))
                {
                    txtIdFactura.Visible = true;
                    labelIdFactura.Visible = true;
                    return;
                }
                txtIdFactura.Text = String.Empty;
                txtIdFactura.Visible = false;
                labelIdFactura.Visible = false;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
