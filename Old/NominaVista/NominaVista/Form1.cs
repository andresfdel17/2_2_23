using LibNomina;
namespace NominaVista
{
    public partial class Nomina : Form
    {
        NominaClass objN = new NominaClass();
        public Nomina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double salary = Convert.ToDouble(salaryBox.Text);
                int days = Convert.ToInt32(daysBox.Text);
                this.objN.setSalary = salary;
                this.objN.setDays = days;
                if (this.objN.Calculate())
                {
                    resBox.Text = this.objN.getSueldo.ToString();
                    return;
                }
                MessageBox.Show(this.objN.getError);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}