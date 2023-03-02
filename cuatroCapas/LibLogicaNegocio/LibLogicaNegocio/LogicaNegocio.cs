using LibConexionBD;
namespace LibLogicaNegocio
{
    public class LogicaNegocio
    {
        #region "atributos"
        private int id;
        private string name;
        private string apellido;
        private string telefono;
        private int age;
        private string error = "";
        #endregion
        #region "metodos publicos"
        public LogicaNegocio()
        { }

        public bool Consulta()
        {
            try
            {
                ClsConexion objC = new ClsConexion();

                return true;
            } catch(Exception e)
            {
                this.error= e.Message;
                return false;
            }
        }
        #endregion
        #region "propiedades"
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Age { get => age; set => age = value; }
        public string Error { get => error; set => error = value; }
        #endregion
    }
}