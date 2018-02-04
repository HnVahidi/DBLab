using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLabrator.UI.CustomerActions
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DO.Customer cust = new DO.Customer();
            cust.city = CityTextBox.Text;
            cust.country=CountryTextBox.Text;
            cust.creditRating=Convert.ToInt32(CreditRatingTextBox.Text);
            cust.faxNo = Convert.ToInt32(FaxNumberTextBox.Text);
            cust.firstName=FirstNameTextBox.Text;
            cust.lastName=LastNameTextBox.Text;
            cust.sex = SexTextBox.Text.ToString()[0];
            cust.id=Convert.ToInt32(IDTextBox.Text);
            cust.zipCode=Convert.ToInt32(ZipCodeTextBox.Text);
            cust.telNo=Convert.ToInt32(TelNumberTextBox.Text);
            cust.street=StreetTextBox.Text;
            DA.CustomerDA.InsertCustomer(cust);

            dataGridView1.DataSource = DA.CustomerDA.SearchAll();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DA.CustomerDA.Search(IDTextBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DA.CustomerDA.Delete(IDTextBox.Text);
            dataGridView1.DataSource = DA.CustomerDA.SearchAll();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raspberryDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.raspberryDataSet.Customer);

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DA.CustomerDA.SearchAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DO.Customer cust = new DO.Customer();
            cust.city = CityTextBox.Text;
            cust.country = CountryTextBox.Text;
            cust.creditRating = Convert.ToInt32(CreditRatingTextBox.Text);
            cust.faxNo = Convert.ToInt32(FaxNumberTextBox.Text);
            cust.firstName = FirstNameTextBox.Text;
            cust.lastName = LastNameTextBox.Text;
            cust.sex = SexTextBox.Text.ToString()[0];
            cust.id = Convert.ToInt32(IDTextBox.Text);
            cust.zipCode = Convert.ToInt32(ZipCodeTextBox.Text);
            cust.telNo = Convert.ToInt32(TelNumberTextBox.Text);
            cust.street = StreetTextBox.Text;
            DA.CustomerDA.Update(cust);

            dataGridView1.DataSource = DA.CustomerDA.SearchAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            FirstNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LastNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            SexTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            StreetTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            CityTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            CountryTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            ZipCodeTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TelNumberTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            FaxNumberTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            CreditRatingTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
    }
}
