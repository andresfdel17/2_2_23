using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEmpleado
{
    public class ClsLnEmpleado
    {
        #region ATRIBUTOS
        //Id del empleado
        private int id = 0;
        //Nombre
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
        public ClsLnEmpleado() {}

        #endregion
    }
}
