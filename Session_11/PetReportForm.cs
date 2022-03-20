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
using PetShopLib.Impl;
using System.Text.Json;
using System.IO;


namespace Session_11
{
    public partial class PetReportForm : DevExpress.XtraEditors.XtraForm
    {
        private List<Pet> _pet;
         
        private const string FILE_NAME = "PetShop.json";

        public PetReportForm()
        {
            InitializeComponent();
            PetReport petReport = new PetReport();
        }

        private void PopulateControls()
        {

        }

        private void PopulatePets()
        {

        }

        private void TotalPetsSold()
        {

        }

    }
}