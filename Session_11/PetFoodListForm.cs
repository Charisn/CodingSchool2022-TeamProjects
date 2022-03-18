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
using System.Text.Json;
using PetShopLib.Impl;

namespace Session_11
{
    public partial class PetFoodListForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "PetShop.json";
        public PetFoodListForm()
        {
            InitializeComponent();
        }

        private void PetFoodListForm_Load(object sender, EventArgs e)
        {
            //PopulateControls();
            PopulatePetFoods();
        }

        private void PopulatePetFoods()
        {
            string s = File.ReadAllText(FILE_NAME);
            var petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop)); //mporei na yparksei thema edw epeidi einai null

            bsPetShop.DataSource = petShop;

            bsPetFoods.DataSource = bsPetShop;
            bsPetFoods.DataMember = "PetFoods";

            grdPetFoods.DataSource = bsPetFoods;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var petShop = bsPetShop.Current as PetShop;

            PetFoodForm petFoodForm = new PetFoodForm(petShop);
            petFoodForm.ShowDialog();
            grvPetFoods.RefreshData();
        }
    }
}