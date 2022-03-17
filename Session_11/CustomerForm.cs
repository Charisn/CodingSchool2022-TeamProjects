using DevExpress.XtraEditors;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "storage.json";
        public List<Customer> _customers;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            
            
            PetShop _petShop = new PetShop();
            _petShop.Customers = new List<Customer>();
            var customer = new Customer();
            customer.Name = "Vaggelis";
            _petShop.Customers.Add(customer);
            bsCustomers.DataSource = _petShop.Customers;

            ctrlName.EditValue = customer.Name;
            SetDataBindings();

        }

        private void SetDataBindings()
        {
            ctrlName.DataBindings.Add(new Binding("EditValue", bsCustomers,"Name",true));
            ctrlSurName.DataBindings.Add(new Binding("EditValue", bsCustomers, "SurName", true));
            ctrlTIN.DataBindings.Add(new Binding("EditValue", bsCustomers, "TIN", true));
            ctrlPhone.DataBindings.Add(new Binding("EditValue", bsCustomers, "Phone", true));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Customer s = new Customer();
        }
    }
}