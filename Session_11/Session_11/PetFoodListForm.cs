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
using PetShopLib.Enums;
using DevExpress.XtraEditors.Controls;

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
            PopulateControls();
            PopulatePetFoods();
        }


        private void PopulateControls()
        {

            Dictionary<AnimalTypeEnum, string> animalTypes = new Dictionary<AnimalTypeEnum, string>();
            animalTypes.Add(AnimalTypeEnum.Bird, "Bird");
            animalTypes.Add(AnimalTypeEnum.Fish, "Fish");
            animalTypes.Add(AnimalTypeEnum.Lizard, "Lizard");
            animalTypes.Add(AnimalTypeEnum.Cat, "Cat");
            animalTypes.Add(AnimalTypeEnum.Dog, "Dog");



            repAnimalTypes.DataSource = animalTypes;
            repAnimalTypes.Columns.Add(new LookUpColumnInfo("Value"));
            repAnimalTypes.DisplayMember = "Value";
            repAnimalTypes.ValueMember = "Key";
            repAnimalTypes.ShowHeader = false;
            repAnimalTypes.NullText = null;





        }









        private void PopulatePetFoods()
        {
            string s = File.ReadAllText(FILE_NAME);
            var petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop)); 

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var petShop = bsPetShop.Current as PetShop;
            var petfood = bsPetFoods.Current as PetFood;

            PetFoodForm petFoodForm = new PetFoodForm(petShop, petfood);
            petFoodForm.ShowDialog();
            grvPetFoods.RefreshData();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete this pet food?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var petfood = bsPetFoods.Current as PetFood;
            bsPetFoods.Remove(petfood);
            SaveData();

        }

        public void SaveData()
        {
            var petShop = bsPetShop.Current as PetShop;
            string json = JsonSerializer.Serialize(petShop);
            File.WriteAllText(FILE_NAME, json);


        }
    }
}