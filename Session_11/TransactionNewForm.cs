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
        private const string TRANSACTIONS = "Transactions.json";
        private Transaction _transaction;
        private PetShop _petShop;

        public TransactionNewForm()
        {
            LoadPetsShopJson();
            InitializeComponent();
            _transaction = new Transaction();            
            _petShop.Transactions.Add(_transaction);
            
        }

        private void TransactionNewForm_Load(object sender, EventArgs e)
        {
            PopulateControls();
            ctrlPetPrice.ReadOnly = true;
            ctrlPetFoodPrice.ReadOnly = true;
            ctrlTotalPrice.ReadOnly = true;

            bsTransactions.DataSource = _petShop.Transactions;

            SetDataBindings();
        }
        private void PopulateControls()
        {
            var helper = new ControlsHelper();
            
            helper.PopulatePetType(ctrlPet.Properties, _petShop);
            helper.PopulateCustomer(ctrlCustomer.Properties, _petShop);
            helper.PopulateEmployee(ctrlEmployee.Properties, _petShop);
        }

        private void AddNewCustomer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerListForm linkLabel = new CustomerListForm();
            linkLabel.Show();
        }

        private void SetDataBindings()
        {
            //BindingSource bsTransactions = new BindingSource();
            ctrlPetFoodPrice.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetFoodPrice", true));
            ctrlPetPrice.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetPrice", true));
            ctrlPetFoodQty.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetFoodQty", true));
            ctrlTotalPrice.DataBindings.Add(new Binding("EditValue", bsTransactions, "TotalPrice", true));
        }

        private void Calculations()
        {
            if (ctrlPetFoodQty.Value == null || ctrlPetFoodQty.Value <1 ) 
            { ctrlPetFoodQty.Value = 1; }

            bsPetShop.DataSource = _petShop;
            bsPetShop.DataMember = "Pets";
            ctrlPet.Properties.DataSource = bsPetShop;
            

            var ctrlpet = ctrlPet.EditValue;
            var pet = _petShop.Pets.Find(x => x.ID.Equals(ctrlpet));
            var animal = pet.AnimalType; // edw exw to Dog se animalTypeEnum
            var petFood = _petShop.PetFoods.Find(x => x.AnimalType.Equals(animal));

            if (pet.PetStatus == PetShopLib.Enums.PetStatusEnum.Unhealthy)
            {
                MessageBox.Show("Pet selected is unavailable", "Warning");
                //DialogResult = DialogResult.Yes;
                //ctrlPet
            }

            decimal _totalpetFood = Convert.ToDecimal(petFood.Price);
            decimal _totalPet = Convert.ToDecimal(pet.Price);

            int _qty = Convert.ToInt16(ctrlPetFoodQty.Value);
            var _grandTotal = (_totalpetFood * (_qty - 1) + _totalPet);
            ctrlTotalPrice.EditValue = _grandTotal;

            if (pet != null)
            {
                ctrlPetPrice.EditValue=pet.Price;
                ctrlPetFoodPrice.EditValue = petFood.Price;
                _transaction.PetFoodQty = _qty;
                _transaction.PetFoodPrice = _totalpetFood;

               // _transaction.PetPrice = animal.;

            } 
        }
        private void Save()
        {
            string json = JsonSerializer.Serialize(_petShop);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;
        }
        private void btnSaveNewTrans_Click(object sender, EventArgs e)
        {
            _petShop.Transactions.Add(_transaction);
            Save();
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

        private void ctrlPetFoodQty_EditValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }        
        private void LoadPetsShopJson()
        {
            string s = File.ReadAllText(FILE_NAME);
            _petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));
        }
        private void ctrlCustomer_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.ctrlCustomer.Refresh();
        }
    }
}