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
        private Transaction _transaction;

        private const string FILE_NAME = "PetShop.json";
        private const string TRANSACTIONS = "Transactions.json";

        private Pet _pet;
        private PetShop _petShop;
        private Customer _customer;
        private Employee _employee;
        private PetFood _petFood;

        public TransactionNewForm()
        {
            InitializeComponent();
            _pet = new Pet();
            _petShop = new PetShop();
            _petFood = new PetFood();
            _customer = new Customer();
            _customer = new Customer();
            bsTransactions = new BindingSource();
        }

        private void TransactionNewForm_Load(object sender, EventArgs e)
        {
            PopulateControls();
            ctrlPetPrice.ReadOnly = true;
            ctrlPetFoodPrice.ReadOnly = true;
            ctrlTotalPrice.ReadOnly = true;
            //DataBindingsTrans();
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
            if (ctrlPetFoodQty.Value == null || ctrlPetFoodQty.Value <1 ) 
            { ctrlPetFoodQty.Value = 1; }
            
            string s = File.ReadAllText(FILE_NAME);
            _petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));

            bsPetShop.DataSource = _petShop;
            bsPetShop.DataMember = "Pets";
            ctrlPet.Properties.DataSource = bsPetShop;
            var ctrlpet = ctrlPet.EditValue;
            var pet = _petShop.Pets.Find(x => x.ID.Equals(ctrlpet));
            var animal = pet.AnimalType; // edw exw to Dog se animalTypeEnum
            var petFood = _petShop.PetFoods.Find(x => x.AnimalType.Equals(animal));
            decimal _totalpetFood = Convert.ToDecimal(petFood.Price);
            decimal _totalPet = Convert.ToDecimal(pet.Price);
            int _qty = Convert.ToInt16(ctrlPetFoodQty.Value);
            var _grandTotal = (_totalpetFood * (_qty - 1) + _totalPet);
            ctrlTotalPrice.Text = _grandTotal.ToString();

            if (pet != null)
            {
                ctrlPetPrice.EditValue=pet.Price;
                ctrlPetFoodPrice.EditValue = petFood.Price;
            } 
        }

        //private void DataBindingsTrans()
        //{
        //    ctrlPetFoodPrice.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetFoodPrice", true));
        //    ctrlPetPrice.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetPrice", true));
        //    ctrlPetFoodQty.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetFoodQty", true));
        //    ctrlCustomer.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetFoodQty", true));
        //    ctrlEmployee.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetFoodQty", true));
        //    ctrlPet.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetType", true));
        //    _transaction.PetID = _pet.ID;
        //    _transaction.EmployeeID = _employee.ID;
        //    _transaction.CustomerID = _customer.ID;
        //    _transaction.PetFoodID = _petFood.ID;
        //}

        private void btnSaveNewTrans_Click(object sender, EventArgs e)
        {
            SaveTransaction(_transaction);
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
        
        private void SaveTransaction(Transaction transaction)
        {
            if (File.Exists(TRANSACTIONS))
            {
                //Load
                string s = File.ReadAllText(TRANSACTIONS);
                _transaction = (Transaction)JsonSerializer.Deserialize(s, typeof(Transaction));
            }
            else
            {
                string json = JsonSerializer.Serialize(_transaction);
                File.WriteAllText(TRANSACTIONS, json);
                DialogResult = DialogResult.OK;
            }
        }
    }
}