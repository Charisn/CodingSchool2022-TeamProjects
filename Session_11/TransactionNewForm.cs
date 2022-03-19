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
using System.Text.Json;

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
            _pet = new Pet();
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
            CustomerListForm linkLabel = new CustomerListForm();
            linkLabel.Show();
        }

        private void SetDataBindings()
        {
            BindingSource bsPetfoodQty = new BindingSource();
        }

        private void Calculations()
        {
            string s = File.ReadAllText(FILE_NAME);
            _petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));

            bsPetShop.DataSource = _petShop;
            bsPetShop.DataMember = "Pets";
            ctrlPet.Properties.DataSource = bsPetShop;
            var ctrlpet = ctrlPet.EditValue;
            
            var pet = _petShop.Pets.Find(x => x.ID.Equals(ctrlpet));
            if (pet != null)
            {
                ctrlPetFoodPrice.EditValue = pet.Price;
            } 

        }

        private void btnSaveNewTrans_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(_petShop);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;
        }

        private void ctrlPet_EditValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void btnCancelNewTrans_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Not closing window.
            }
        }
    }
}