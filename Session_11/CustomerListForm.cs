using DevExpress.XtraEditors;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class CustomerListForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "PetShop.json";
        
        public CustomerListForm()
        {
            InitializeComponent();
        }
       

        private void gridControl1_Load(object sender, EventArgs e)
        {

        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
            
        }
        private void PopulateCustomers()
        {
            
            
            string s = File.ReadAllText(FILE_NAME);
            var petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));

            bsPetShop.DataSource = petShop;
            bsCustomers.DataSource = bsPetShop;
            bsCustomers.DataMember = "Customers";
            gridCustomers.DataSource = bsCustomers;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var petShop = bsPetShop.Current as PetShop;
            CustomerForm customerForm = new CustomerForm(petShop);
            customerForm.ShowDialog();
            grvCustomers.RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var petShop= bsPetShop.Current as PetShop; 
            var customer = bsCustomers.Current as Customer;
            CustomerForm customForm = new CustomerForm(petShop,customer);
            customForm.ShowDialog();
            grvCustomers.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete this customer? He is such a good customer!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var customer = bsCustomers.Current as Customer;
            bsCustomers.Remove(customer);
            SaveData();
        }
        public void SaveData()
        {
            var petShop = bsPetShop.Current as PetShop;
            string json = JsonSerializer.Serialize(petShop);
            File.WriteAllText(FILE_NAME, json);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}