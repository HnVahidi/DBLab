using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLabrator.UI.ProductActions
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raspberryDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.raspberryDataSet.Product);

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DA.ProductDA.SearchAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DA.ProductDA.Search(IDTextBox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DA.ProductDA.Delete(IDTextBox.Text);
            dataGridView1.DataSource = DA.ProductDA.SearchAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DO.Product prod = new DO.Product();
            prod.id = Convert.ToInt32(IDTextBox.Text);
            prod.availableQuantity = Convert.ToInt32(QuantityTextBox.Text);
            prod.price = Convert.ToInt32(PriceTextBox.Text);
            prod.productName = NameTextBox.Text;

            DA.ProductDA.InsertProduct(prod);
            dataGridView1.DataSource = DA.ProductDA.SearchAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text != "")
                DA.ProductDA.Update(new DO.Product
                {
                    id = Convert.ToInt32(IDTextBox.Text),
                    price = Convert.ToInt32(PriceTextBox.Text),
                    availableQuantity = Convert.ToInt32(QuantityTextBox.Text),
                    productName = NameTextBox.Text
                });
            dataGridView1.DataSource = DA.ProductDA.SearchAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            IDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            PriceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            QuantityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DA.ProductDA.Delete(IDTextBox.Text);
            dataGridView1.DataSource = DA.ProductDA.SearchAll();
        }
    }
}
