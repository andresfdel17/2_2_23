using System;
using System.Windows.Forms;
using LibOperacion;

namespace OperacionVista
{
    public partial class Suma : Form
    {
        Operacion objO = new Operacion();
        public Suma()
        {
            InitializeComponent();
           
        }       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Obtener valores a enviar
            double n1 = Convert.ToDouble(txtNum1.Text);
            double n2 = Convert.ToDouble(txtNum2.Text);
            this.objO.SetNumber1= n1;
            this.objO.SetNumber2 = n2;
            if (this.objO.Calculate())
            {
                txtRes.Text = this.objO.GetSuma.ToString();
                return;
            }
            MessageBox.Show(this.objO.GetError["data"]);
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtRes.Text = "";
        }
    }
}
