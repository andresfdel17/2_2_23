using System;
using System.Windows.Forms;

namespace VistaFinal
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }
        private void Facturas_Click(object sender, EventArgs e)
        {
            //Valida si ya está abierto 
            if (!FormIsOpen("FacturasV"))
            {
                //Nuevo formulario de facturas
                FacturasV emp = FacturasV.Ventana_unica();
                //setea el parent en este formulario
                emp.MdiParent = this;
                //Inicia la ventana children maximisada
                emp.WindowState = FormWindowState.Maximized;
                //Oculta el icono en el child
                emp.ShowIcon = false;
                //Lo muestra
                emp.Show();
                //Label
                tssUsuario.Text = "Facturas";
                //Lo trae al frente
                emp.BringToFront();
            }
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            //Carga empleados al iniciar
            Empleados_Click(sender, e);
        }

        bool FormIsOpen(string nameForm)
        {
            //Recorre cada children y si está abierto lo trae al frente
            foreach (var item in this.MdiChildren)
            {
                if (item.Text == nameForm)
                {
                    item.BringToFront();
                    return true;
                }
            }
            return false;
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            if (!FormIsOpen("EmpleadosV"))
            {
                EmpleadosV emp = EmpleadosV.Ventana_unica();
                emp.MdiParent = this;
                emp.WindowState = FormWindowState.Maximized;
                emp.ShowIcon = false;
                emp.Show();
                tssUsuario.Text = "Empleados";
                emp.BringToFront();
            }
        }

        private void FormMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si se cierra la ventana se sale de la aplicacion
            Application.Exit();
        }
    }
}
