using LibParametro;
namespace LeerXMLVista
{
    public partial class Form1 : Form
    {
        ClsParametro  objP = new ClsParametro();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadena_Click(object sender, EventArgs e)
        {
            if (this.objP.CrearConexion())
            {
                txtCadena.Text = this.objP.CadenaConexion;
            }
            else
            {
                MessageBox.Show(this.objP.Error);
            }
        }
    }
}