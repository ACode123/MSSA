using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._4
{
    //Create an abstract base class to represent “Beverage”
    //and inherit “Coffee” class from it. Create a generic list
    //( you may use Dictionary/Sortedlist) of coffees. Design windows form application to display the list of coffees in grid and perform add/ delete.
    public partial class FormMenu : Form
    {
        List<Coffee> coffeelist;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnAddcoff_Click(object sender, EventArgs e)
        {
            Coffeebox.Visible = true;
            if(txtCid.Text!=String.Empty&& txtCname.Text!=String.Empty&&txtHorIce.Text!=String.Empty)
            {
                Coffee newCoffee = new Coffee();
                newCoffee.DrinkId = Int32.Parse(txtCid.Text);
                newCoffee.Name = txtCname.Text;
                newCoffee.Country =(CountryofOrig)cmbCountry.SelectedItem;
                newCoffee.HotorIced = txtHorIce.Text;
                coffeelist.Add(newCoffee);
            }
            RefreshData(); 
        }
        private void RefreshData()
        {
            txtCid.Clear();
            txtCname.Clear();
            txtHorIce.Clear();
            Coffeegrid.DataSource = null;
            Coffeegrid.DataSource = coffeelist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coffeelist.RemoveAt(Coffeegrid.CurrentRow.Index);
            RefreshData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2welcome F2 = new Form2welcome();
            F2.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            coffeelist = new List<Coffee>();
            coffeelist.Add(new Coffee() { DrinkId = 1, Name = "Americano", HotorIced = "Both",
                Country= CountryofOrig.Columbia, }); 
            Coffeegrid.DataSource = coffeelist.ToList();
            cmbCountry.DataSource = Enum.GetValues(typeof(CountryofOrig));

           
        }
    }
}
