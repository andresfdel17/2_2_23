using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOperacion
{
    public class Operacion
    {
        #region ATRIBUTOS
        private double num1 = 0;
        private double num2 = 0;
        private double resultado = 0;
        private readonly Dictionary<string, dynamic> error = new Dictionary<string, dynamic>()
        {
            { "isError", false },
            { "data", "" },
            { "timestamp", new DateTime().ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:sszz") }
        };
        #endregion
        #region METODOS PUBLICOS
        public Operacion()
        {}
        public bool Calculate(double number1, double number2)
        {
            this.num1 = number1;
            this.num2 = number2;
            if (this.Validate())
            {
                this.resultado = number1 + number2;
                return true;
            }
            return false;
        }
        #endregion
        #region METODOS PRIVADOS
        private bool Validate()
        {
            try
            {
                double suma = this.num1 + this.num2;
                return true;
            }
            catch (Exception error)
            {
                this.error["isError"] = true ;
                this.error["data"] = error.Message;
                return false;
            }
        }
        #endregion
        #region PROPIEDADES
        public double SetNumber1
        {
            set { num1 = value; }
        }
        public double SetNumber2
        {
            set { num2 = value; }
        }
        public double GetSuma
        {
            get { return this.resultado; }
        }
        public Dictionary<string, dynamic> GetError
        {
            get { return this.error; }
        }
        #endregion

    }
}
