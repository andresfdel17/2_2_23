using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias externas de Adalberto
using LibConexionBD;
using LibLlenarGrids;

namespace LibEmpleado
{
    public class ClsLnEmpleado
    {
        #region ATRIBUTOS
        // Id del empleado
        private int id = 0;
        // Nombre
        private string name = String.Empty;
        // Apelidos
        private string last_name = String.Empty;
        // Correo electronico
        private string email = String.Empty;
        // Telefono
        private string phone = String.Empty;
        // Resultado corrcto
        private string resultado = String.Empty;
        // Posible error
        private string error = String.Empty;
        // Data Reader para consultas
        private SqlDataReader emReader = null;
        #endregion
        #region PROPIEDADES
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader EmReader { get => emReader; set => emReader = value; }
        #endregion
        #region METODOS PUBLICOS
        public ClsLnEmpleado() { }
        public bool GuardarEmpleado()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "EXECUTE usp_save_empleado '" + name + "','" + last_name + "','" + email + "','" + phone + "'";
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Empleado guardado correctamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool EditarEmpleado()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "EXECUTE usp_update_empleado " + id + ",'" + name + "','" + last_name + "','" + email + "','" + phone + "'";
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Empleado editado correctamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool EliminarEmpleado()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "EXECUTE usp_delete_empleado " + id;
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Empleado eliminado correctamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool ConsultarEmpleado()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "EXECUTE usp_consultar_empleado " + id;
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
        public bool ListarEmpleado(DataGridView grid)
        {
            try
            {
                ClsLLenarGrids objL = new ClsLLenarGrids
                {
                    NombreTabla = "empleado",
                    SQL = "usp_listar_empleado"
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
