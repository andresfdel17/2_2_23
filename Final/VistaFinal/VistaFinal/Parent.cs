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
            if (!FormIsOpen("FacturasV"))
            {
                FacturasV emp = FacturasV.Ventana_unica();
                emp.MdiParent = this;
                emp.WindowState = FormWindowState.Maximized;
                emp.ShowIcon = false;
                emp.Show();
                tssUsuario.Text = "Facturas";
                emp.BringToFront();
            }
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            Empleados_Click(sender, e);
        }

        bool FormIsOpen(string nameForm)
        {
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
            Application.Exit();
        }
    }
}
