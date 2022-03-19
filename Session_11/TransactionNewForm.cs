using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PetShopLib.Impl;

namespace Session_11
{
    public partial class TransactionNewForm : Form
    {
        private const string FILE_NAME = "PetShop.json";
        
        private Pet _pet;
        private PetShop _petShop;

        public TransactionNewForm()
        {
            InitializeComponent();
        }

        private void TransactionNewForm_Load(object sender, EventArgs e)
        {
            PopulateControls();

        }
        private void PopulateControls()
        {
            var helper = new ControlsHelper();

            helper.PopulatePetType(ctrlPet.Properties);
            helper.PopulateCustomer(ctrlCustomer.Properties);
            helper.PopulateEmployee(ctrlEmployee.Properties);
        }

        private void AddNewCustomer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerForm linkLabel = new CustomerForm();
            linkLabel.Show();
        }

        private void SetDataBindings()
        {
            BindingSource bsPetfoodQty = new BindingSource();
        }

        private void Calculations()
        {
            bsPetShop.DataSource = _petShop;
            //ctrlPetFoodPrice.Text = _petShop.PetFood
            //decimal TotalPrice => { ctrlPetFoodPrice.Text + ctrlPetPrice.Text }
        }

        private void btnSaveNewTrans_Click(object sender, EventArgs e)
        {
           // var save = new SaveToJson();
        }
    }
}