using EClerx.LayeredDemo.BLL;
using System;
using System.Windows.Forms;

namespace EClerx.LayeredDemo.PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            EmployeeBLL emp = new EmployeeBLL();
            var dt = emp.GetEmployees(TxtState.Text);
            if (dt != null)
            {
                GridEmployee.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid State name");
            }
        }
    }
}
