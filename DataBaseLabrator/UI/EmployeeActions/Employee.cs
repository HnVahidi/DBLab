using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLabrator.UI.EmployeeActions
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void refteshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= DA.EmployeeDA.SearchAll();

           // MessageBox.Show(dateTimePicker1.Text);
           // DateTime dt = Convert.ToDateTime(dateTimePicker1.Text);
           // MessageBox.Show(dt.ToString("yyyy-MM-dd h:mm:ss"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DA.EmployeeDA.Search(IDTextBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DA.EmployeeDA.Delete(IDTextBox.Text);
            dataGridView1.DataSource = DA.EmployeeDA.SearchAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DO.Employee emp = new DO.Employee();

            DateTime dt = Convert.ToDateTime(dateTimePicker1.Text);
            string dts=dt.ToString("yyyy-MM-dd h:mm:ss");

            emp.city = CityTextBox.Text;
            emp.country = CountryTextBox.Text;
            emp.dateStarted = dts;
            emp.faxNo = Convert.ToInt32(FaxNoTextBox.Text);
            emp.workTelNo = Convert.ToInt32(WorkTelNoTextBox.Text);
            emp.zipCode = Convert.ToInt32(ZipCodeTextBox.Text);
            emp.id = Convert.ToInt32(IDTextBox.Text);
            emp.firstName = FirstNameTextBox.Text;
            emp.lastName = LastNameTextBox.Text;
            emp.sex = SexTextBox.Text.ToString()[0];
            emp.mobileNo = Convert.ToInt32(MobileNoTextBox.Text);
            emp.title = TitleTextBox.Text;
            emp.street = StreetTextBox.Text;
            emp.salary = Convert.ToInt32(SalaryTextBox.Text);

            DA.EmployeeDA.InsertEmployee(emp);

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'raspberryDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.raspberryDataSet.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DO.Employee emp = new DO.Employee();

            DateTime dt = Convert.ToDateTime(dateTimePicker1.Text);
            string dts = dt.ToString("yyyy-MM-dd h:mm:ss");

            emp.city = CityTextBox.Text;
            emp.country = CountryTextBox.Text;
            emp.dateStarted = dts;
            emp.faxNo = Convert.ToInt32(FaxNoTextBox.Text);
            emp.workTelNo = Convert.ToInt32(WorkTelNoTextBox.Text);
            emp.zipCode = Convert.ToInt32(ZipCodeTextBox.Text);
            emp.id = Convert.ToInt32(IDTextBox.Text);
            emp.firstName = FirstNameTextBox.Text;
            emp.lastName = LastNameTextBox.Text;
            emp.sex = SexTextBox.Text.ToString()[0];
            emp.mobileNo = Convert.ToInt32(MobileNoTextBox.Text);
            emp.title = TitleTextBox.Text;
            emp.street = StreetTextBox.Text;
            emp.salary = Convert.ToInt32(SalaryTextBox.Text);

            DA.EmployeeDA.Update(emp);

            dataGridView1.DataSource = DA.EmployeeDA.SearchAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TitleTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            FirstNameTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            LastNameTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            SexTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            StreetTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            CityTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            CountryTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            ZipCodeTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            WorkTelNoTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            FaxNoTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            MobileNoTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            SalaryTextBox.Text= dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();

            if(dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString()!="")
            dateTimePicker1.Value= Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString());
        }
    }
}
