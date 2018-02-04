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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raspberryDataSet.orderT' table. You can move, or remove it, as needed.
            this.orderTTableAdapter.Fill(this.raspberryDataSet.orderT);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DA.OrderDA.Search(idtextBox.Text);
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(raiseddateTimePicker1.Text);
            string dts = dt.ToString("yyyy-MM-dd h:mm:ss");
            dt = Convert.ToDateTime(paiddateTimePicker1.Text);
            string dts2= dt.ToString("yyyy-MM-dd h:mm:ss");
            DA.OrderDA.Insert(new DO.Order
            {
                id = idtextBox.Text,
                invoice = invoicetextBox.Text,
                paymentMethodId = paymenttextBox.Text,
                shipmentMethodeId = shipmenttextBox.Text,
                dateRaised = dts,
                datePaid = dts2
            });

            dataGridView1.DataSource = DA.OrderDA.SearchAll();

            

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DA.OrderDA.Delete(idtextBox.Text);
            dataGridView1.DataSource = DA.OrderDA.SearchAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            invoicetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            raiseddateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            paiddateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            paymenttextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            shipmenttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            MessageBox.Show(e.ToString());
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DA.OrderDA.SearchAll();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(raiseddateTimePicker1.Text);
            string dts = dt.ToString("yyyy-MM-dd h:mm:ss");
            dt = Convert.ToDateTime(paiddateTimePicker1.Text);
            string dts2 = dt.ToString("yyyy-MM-dd h:mm:ss");
            DA.OrderDA.Update(new DO.Order
            {
                id = idtextBox.Text,
                invoice = invoicetextBox.Text,
                paymentMethodId = paymenttextBox.Text,
                shipmentMethodeId = shipmenttextBox.Text,
                dateRaised = dts,
                datePaid = dts2
            });

            dataGridView1.DataSource = DA.OrderDA.SearchAll();
        }

        private void GetInfoTextBox_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
                MessageBox.Show("agha bish az 1 select kardi :| ");
            dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            idtextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            invoicetextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            raiseddateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            paiddateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            paymenttextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            shipmenttextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }
    }
}
