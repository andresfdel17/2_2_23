using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;

namespace Lib_LN_AFDG
{
    public class Clase_AFDG
    {
        #region atributos
        private int codigo = 0;
        private string caracteristicas = "";
        private string error = "";
        private string resultado = "";
        #endregion
        #region propiedades
        public int Codigo { get => codigo; set => codigo = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public string Error { get => error; set => error = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        #endregion
        #region metodos publicos
        public Clase_AFDG() { }
        public bool saveRegister()
        {
            if (codigo == 0 || caracteristicas == "") {
                this.error = "EL codigo debe ser distinto a 0 y caracteristicas debe ser distinto a ''";
                return false;
            }
            if (!this.save())
            {
                return false;
            }
            return true;
        }
        #endregion
        #region metodos privados
        private bool save()
        {
            try
            {
                ClsConexion objC = new ClsConexion();
                string query = "execute usp_save_AFDG " + codigo + ",'" + caracteristicas + "'";
                if (!objC.EjecutarSentencia(query, false))
                {
                    this.error = objC.Error;
                    return false;
                }
                this.resultado = "Se creó el registro exitosamente";
                return true;
            } catch (Exception ex)
            {
                this.error = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
