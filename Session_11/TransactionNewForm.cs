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
        private PetFood _petFood;

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
    }
}