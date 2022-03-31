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

namespace Session_11
{
    public partial class ManagerForm : DevExpress.XtraEditors.XtraForm
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerConfirmbtn_Click(object sender, EventArgs e)
        {
           if ( RadioTransactionHistory.Checked == true )
            {
                TransactionListForm form = new TransactionListForm();
                form.ShowDialog();
            }
           else if (RadioMonthlyLedger.Checked == true )
            {
                MessageBox.Show("Error 567 - Restricted Access. Please Contact Support", "Critical Error!");
            }
            else if (RadioPetReports.Checked == true)
            {
                PetReportForm form = new PetReportForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please make sure one button is checked", "Warning");
            }
        }
    }
}