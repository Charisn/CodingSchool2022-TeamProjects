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
using System.Text.Json;
using System.IO;

namespace Session_11
{
    public partial class TransactionListForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "PetShop.json";

        public TransactionListForm()
        {
            InitializeComponent();
            PetShop petShop = new PetShop();
            bsTrans.DataSource = petShop.Transactions;
            grdTransaction.DataSource = bsTrans;
        }

        private void PopulateTransaction()
        {
            string s = File.ReadAllText(FILE_NAME);
            var petshop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));

        }
        
    }
}