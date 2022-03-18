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
    public partial class PetFoodForm : DevExpress.XtraEditors.XtraForm
    {

        private const string FILE_NAME = "PetShop.json";


        private PetShop _petShop;
        private PetFood _petFood;

        public PetFoodForm()
        {
            InitializeComponent();
        }

        public PetFoodForm(PetShop petShop)
        {
            InitializeComponent();
            _petShop = petShop;
        }

        public PetFoodForm(PetShop petShop,PetFood petFood) :this(petShop)
        {
            _petFood = petFood;
        }

        private void PetFoodForm_Load(object sender, EventArgs e)
        {
            //PopulateControls();


            if (_petFood == null)
            {
                _petFood = new PetFood();
                _petShop.PetFoods.Add(_petFood);
                bsPetFoods.DataSource = _petFood;


            }

            bsPetFoods.DataSource = _petFood;

            SetDataBindings();

        }

        private void SetDataBindings()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(_petShop);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;
        }
    }
}