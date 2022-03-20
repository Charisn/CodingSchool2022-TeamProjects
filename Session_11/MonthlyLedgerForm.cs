using DevExpress.XtraEditors;
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
using PetShopLib.Impl;

namespace Session_11;

public partial class MonthlyLedgerForm : DevExpress.XtraEditors.XtraForm
{
    private MonthlyLedger _monthlyLedger = new MonthlyLedger();

    public MonthlyLedgerForm()
    {
        InitializeComponent();
        // PopulateEmployees();
       
    }

    public void PopulateTransactions()
    {
        grdMonthlyLedger.DataSource = _monthlyLedger.Transactions;
    }




}
