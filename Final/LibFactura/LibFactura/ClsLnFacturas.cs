using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibConexionBD;
using LibLlenarGrids;

namespace LibFactura
{
    public class ClsLnFacturas
    {
        #region ATRIBUTOS
        // Id del empleado
        private int id = 0;
        private int id_empleado = 0;
        private string cliente = String.Empty;
        private string nit_cliente = String.Empty;
        private string producto = String.Empty;
        private int cantidad = 0;
        private double valor = 0;
        // Resultado corrcto
        private string resultado = String.Empty;
        // Posible error
        private string error = String.Empty;
        // Data Reader para consultas
        private SqlDataReader emReader = null;
        #endregion
        #region PROPIEDADES
        public int Id { get => id; set => id = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader EmReader { get => emReader; set => emReader = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Nit_cliente { get => nit_cliente; set => nit_cliente = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Valor { get => valor; set => valor = value; }
        #endregion
        #region METODOS PUBLICOS
        public ClsLnFacturas() { }
        public bool GuardarFactura()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "EXECUTE usp_save_factura " + id_empleado + ",'" + cliente + "','" + nit_cliente + "','" + producto + "'," + cantidad + "," + valor;
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Factura guardado correctamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool EditarFactura()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "EXECUTE usp_update_factura " + id + "," + id_empleado + ",'" + cliente + "','" + nit_cliente + "','" + producto + "'," + cantidad + "," + valor;
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Factura editado correctamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool EliminarFactura()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "EXECUTE usp_delete_factura " + id;
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Factura eliminado correctamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool ConsultarFactura()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "EXECUTE usp_consultar_factura " + id;
                if (!objC.Consultar(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                emReader = objC.Reader;
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool ListarFactura(DataGridView grid)
        {
            try
            {
                ClsLLenarGrids objL = new ClsLLenarGrids
                {
                    NombreTabla = "factura",
                    SQL = "usp_listar_factura"
                };
                if (!objL.LlenarGrid(grid))
                {
                    this.error = objL.ERROR;
                    objL = null;
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }

        }
        #endregion
    }
}
