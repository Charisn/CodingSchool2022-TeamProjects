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

namespace Session_11
{
    public partial class TransactionNewForm : DevExpress.XtraEditors.XtraForm
    {
        public TransactionNewForm()
        {
            InitializeComponent();
        }

        private void TransactionNewForm_Load(object sender, EventArgs e)
        {

        }

        private void AddNewCustomer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerForm linkLabel = new CustomerForm();
            linkLabel.Show();
        }
    }
}