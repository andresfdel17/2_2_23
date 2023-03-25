using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;

namespace LibProfesor
{
    public class LNProfesor
    {
        #region atributos
        private string id = "";
        private string name = "";
        private string apellido = "";
        private double salario = 0.0;
        private string error = "";
        private string resultado = "";
        #endregion
        #region metodos publicos
        public LNProfesor() { }
        #endregion
        #region propiedades
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Error { get => error; set => error = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        #endregion
        #region metodos privados
        public bool guardarProfesor()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "execute usp_guardarProf '" + this.id + "','" + this.name + "','" + this.apellido + "'," + this.salario;
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Se guardó exitsamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool actualizarProfesor()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "execute usp_editarProf '" + this.id + "','" + this.name + "','" + this.apellido + "'," + this.salario;
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Se editó exitsamente";
                objC = null;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        public bool eliminarProfesor()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "execute usp_eliminarProf '" + this.id + "'";
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    objC = null;
                    return false;
                }
                this.resultado = "Se eliminó exitosamente";
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
