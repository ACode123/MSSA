using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_6._2
{
    //Create a table “Cars”. Add columns like VIN, Make, Model, Year, Price etc.

    //Create a Windows forms app to display records in grid.Perform basic CRUD.
    public partial class Form1 : Form
    {
        CarRepository repository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repository = new CarRepository();
            CarGrid.DataSource = repository.GetCars();
            
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //didnt add a max year in case concept cars were added
        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if(txtYear.Text== "1886")
            {
                MessageBox.Show("The patent for the first car was filed in 1886." +
                    " Please enter a valid year.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMake.Text)&&!string.IsNullOrEmpty(txtYear.Text)&&
                !string.IsNullOrEmpty(txtModel.Text)&&!string.IsNullOrEmpty(txtPrice.Text)&&!string.IsNullOrEmpty(txtVIN.Text))
            {
                var newcar = new Car();
                newcar.VIN=txtVIN.Text;
                newcar.Make=txtMake.Text;
                newcar.Model=txtModel.Text;
                newcar.Year=Convert.ToInt32(txtYear.Text);
                newcar.Price=Convert.ToDecimal(txtPrice.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var VIN = CarGrid.CurrentRow.Cells[0].Value;
            var cartodel = repository.FindCar((string)VIN);
            repository.DeleteRecord(cartodel);
            MessageBox.Show("Car is removed from inventory");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var VIN = CarGrid.CurrentRow.Cells[0].Value;
            var cartoupdate = repository.FindCar((string)VIN);
            txtVIN.Text = cartoupdate.VIN;
            txtMake.Text = cartoupdate.Make;
            txtModel.Text = cartoupdate.Model;
            txtPrice.Text = cartoupdate.Price.ToString();
            txtYear.Text = cartoupdate.Year.ToString();
            btnUpdate.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtVIN.Text!=String.Empty&&txtMake.Text!=String.Empty&&txtModel.Text!=String.Empty&&txtPrice.Text!=String.Empty&&txtYear.Text!=String.Empty)
            {
                Car car = new Car();
                car.VIN = txtVIN.Text;
                car.Make = txtMake.Text;
                car.Model = txtModel.Text;
                car.Year = Int32.Parse(txtYear.Text);
                car.Price = decimal.Parse(txtPrice.Text);
                repository.AddRecord(car);
                repository.GetCars();
            }
            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtYear.Clear();


            btnSubmit.Enabled=true; 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var VIN = txtVIN.Text;
            var cartoupdate = repository.FindCar(VIN);
            cartoupdate.Make = txtMake.Text;
            cartoupdate.Model = txtModel.Text;
            cartoupdate.Year = Convert.ToInt32(txtYear.Text);
            cartoupdate.Price = Convert.ToDecimal(txtPrice.Text);
            repository.UpdateRecord(VIN, cartoupdate);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CarGrid.DataSource = null;
            CarGrid.DataSource=repository.GetCars();
        }
        private void Clear()
        {
            txtYear.Clear();
            txtVIN.Clear();
            txtPrice.Clear();
            txtMake.Clear();
            txtModel.Clear();
        }
    }
}
