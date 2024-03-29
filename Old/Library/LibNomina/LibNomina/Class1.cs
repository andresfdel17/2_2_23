﻿namespace LibNomina
{
    public class NominaClass
    {
        #region ATRIBUTOS
        private double salary = 0;
        private int days = 0;
        private double sueldo = 0;
        private string error = "";
        #endregion

        #region METODOS PUBLICOS
        public NominaClass() { }
        public bool Calculate()
        {
            try
            {
                if (this.validate())
                {
                    this.sueldo = (this.salary / 30) * this.days;
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                this.error = e.Message;
                return false;
            }
        }
        #endregion
        #region METODOS PRIVADOS
        private bool validate()
        {
            if (this.days < 0 || this.days > 30)
            {
                this.error = "Los dias no pueden ser menores a 0 ni mayores a 30 dias";
                return false;
            }
            return true;
        }
        #endregion
        #region PROPIEDADES
        public double setSalary
        {
            set { salary = value; }
        }
        public int setDays
        {
            set { days = value; }
        }
        public double getSueldo
        {
            get { return sueldo; }
        }
        public string getError
        {
            get { return error; }
        }
        #endregion
    }
}