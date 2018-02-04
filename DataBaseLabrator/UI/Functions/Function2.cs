using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLabrator.UI.Functions
{
    public partial class Function2 : Form
    {
        public Function2()
        {
            InitializeComponent();
        }

        private void Function2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raspberryDataSet.orderT' table. You can move, or remove it, as needed.
            this.orderTTableAdapter.Fill(this.raspberryDataSet.orderT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DA.Function.dateDifference(textBox1.Text));
        }
    }
}
