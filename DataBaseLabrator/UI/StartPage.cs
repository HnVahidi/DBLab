using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLabrator.UI
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ProductActions.List().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EmployeeActions.Employee().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomerActions.Edit().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new OrderActions.Order().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new OrderActions.OrderDetails().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Functions.Function1().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Functions.Function2().Show();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }
    }
}
