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
using LibProducto;

namespace VistaProducto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comOp.Text)
                {
                    case "Guardar":
                        saveProduct();
                        break;
                    case "Actualizar":
                        updateProduct();
                        break;
                    case "Eliminar":
                        deleteProduct();
                        break;
                    case "Consultar":
                        getProducto();
                        break;
                    case "Listar":
                        getProducts();
                        break;
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private bool saveProduct()
        {
            try
            {
                dataGrid.Visible = false;
                LNProducto objP = new LNProducto();
                objP.IdP = txtId.Text;
                objP.Nombre = txtNombre.Text;
                objP.Caracteristica = txtCaract.Text;
                objP.Precio = Convert.ToDouble(txtValue.Text);
                objP.Cantidad = Convert.ToInt32(txtCantidad.Text);
                if (!objP.GuardarProducto())
                {
                    MessageBox.Show(objP.Error);
                    objP = null;
                    return false;
                }
                MessageBox.Show(objP.Resultado);
                objP = null;
                resetForm();
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool updateProduct()
        {
            try
            {
                dataGrid.Visible = false;
                LNProducto objP = new LNProducto();
                objP.IdP = txtId.Text;
                objP.Nombre = txtNombre.Text;
                objP.Caracteristica = txtCaract.Text;
                objP.Precio = Convert.ToDouble(txtValue.Text);
                objP.Cantidad = Convert.ToInt32(txtCantidad.Text);
                if (!objP.UpdateProducto())
                {
                    MessageBox.Show(objP.Error);
                    objP = null;
                    return false;
                }
                MessageBox.Show(objP.Resultado);
                objP = null;
                resetForm();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool deleteProduct()
        {
            try
            {
                dataGrid.Visible = false;
                LNProducto objP = new LNProducto();
                objP.IdP = txtId.Text;
                if (!objP.DeleteProducto())
                {
                    MessageBox.Show(objP.Error);
                    objP = null;
                    return false;
                }
                MessageBox.Show(objP.Resultado);
                objP = null;
                resetForm();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        private bool getProducto()
        {
            try
            {
                dataGrid.Visible = false;
                LNProducto objP = new LNProducto();
                objP.IdP = txtId.Text;
                if (!objP.ConsultarProducto())
                {
                    MessageBox.Show(objP.Error);
                    objP = null;
                    return false;
                }
                SqlDataReader readerP;
                readerP = objP.Reader;
                if (readerP.HasRows)
                {
                    readerP.Read();
                    txtNombre.Text = readerP.GetString(1);
                    txtCaract.Text = readerP.GetString(2);
                    txtValue.Text = readerP.GetDouble(3).ToString();
                    txtCantidad.Text = readerP.GetInt32(4).ToString();
                    readerP.Close();
                }
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        private bool getProducts()
        {
            try
            {
                dataGrid.Visible = true;
                LNProducto objP = new LNProducto();
                if (!objP.ListarProducto(dataGrid))
                {
                    MessageBox.Show(objP.Error);
                    return false;
                }
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        private void resetForm()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtCaract.Text = "";
            txtValue.Text = "";
            txtCantidad.Text = "";
            comOp.SelectedIndex = -1;
        }
    }
}
