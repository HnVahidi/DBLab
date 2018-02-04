using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLabrator.UI.OrderActions
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raspberryDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.raspberryDataSet.OrderDetails);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderIdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            productIdTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            customerIdtextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            empIdtextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            orderdateTimePicker.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            promiseddateTimePicker.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            statustextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            quantitytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            if(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString()!="")
            shipmentdateTimePicker.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DA.OrderDetailsDA.SearchAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= DA.OrderDetailsDA.Search(orderIdtextBox.Text, productIdTextBox.Text);
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            DA.OrderDetailsDA.Delete(orderIdtextBox.Text, productIdTextBox.Text);
            dataGridView1.DataSource = DA.OrderDetailsDA.SearchAll();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(orderdateTimePicker.Text);
            string dts = dt.ToString("yyyy-MM-dd h:mm:ss");
            dt = Convert.ToDateTime(promiseddateTimePicker.Text);
            string dts2 = dt.ToString("yyyy-MM-dd h:mm:ss");
            dt = Convert.ToDateTime(shipmentdateTimePicker.Text);
            string dts3 = dt.ToString("yyyy-MM-dd h:mm:ss");

            DA.OrderDetailsDA.Insert(new DO.OrderDetails
            {
                orderId = orderIdtextBox.Text,
                customerId = customerIdtextBox.Text,
                empId = empIdtextBox.Text,
                productId = productIdTextBox.Text,
                quantity = quantitytextBox.Text,
                statusId = statustextBox.Text,
                orderDate = dts,
                promisedDate = dts2,
                shipmentDate = dts3
            });
            dataGridView1.DataSource = DA.OrderDetailsDA.SearchAll();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(orderdateTimePicker.Text);
            string dts = dt.ToString("yyyy-MM-dd h:mm:ss");
            dt = Convert.ToDateTime(promiseddateTimePicker.Text);
            string dts2 = dt.ToString("yyyy-MM-dd h:mm:ss");
            dt = Convert.ToDateTime(shipmentdateTimePicker.Text);
            string dts3 = dt.ToString("yyyy-MM-dd h:mm:ss");

            DA.OrderDetailsDA.Update(new DO.OrderDetails
            {
                orderId = orderIdtextBox.Text,
                customerId = customerIdtextBox.Text,
                empId = empIdtextBox.Text,
                productId = productIdTextBox.Text,
                quantity = quantitytextBox.Text,
                statusId = statustextBox.Text,
                orderDate = dts,
                promisedDate = dts2,
                shipmentDate = dts3
            });
            dataGridView1.DataSource = DA.OrderDetailsDA.SearchAll();
        }
    }
}
