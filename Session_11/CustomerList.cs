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
    public partial class grdCustomers : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "storage.json";
        public grdCustomers()
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
            var _petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));

            BindingSource bsCustomers = new BindingSource();
            bsCustomers.DataSource = _petShop.Customers;
            gridCustomers.DataSource = bsCustomers;
        }
    }
}