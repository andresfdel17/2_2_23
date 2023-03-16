using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;

namespace LibProducto
{
    public class LNProducto
    {
        #region atributos
        private string idP = String.Empty;
        private string nombre;
        private string caracteristica;
        private double precio;
        private int cantidad;
        private string error = String.Empty;
        private string resultado = String.Empty;
        private SqlDataReader reader; 
        #endregion
        #region propiedades
        public string IdP { get => idP; set => idP = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Caracteristica { get => caracteristica; set => caracteristica = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Error { get => error; set => error = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        #endregion
        #region metodops publicos
        public LNProducto() { }

        public bool GuardarProducto()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "execute usp_save_product '" + idP + "','" + nombre + "','" + caracteristica + "'," + precio + "," + cantidad;
                if(!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Se guardó correctamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool UpdateProducto()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "execute usp_update_product '" + idP + "','" + nombre + "','" + caracteristica + "'," + precio + "," + cantidad;
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Se actualizó correctamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool DeleteProducto()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "execute usp_delete_product '" + idP + "'";
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Se eliminó correctamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool ListarProducto(bool all = true)
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "execute usp_get_product '" + idP + "'," + all;
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.reader = objC.Reader;
                objC = null;
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
