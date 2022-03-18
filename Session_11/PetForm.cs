using DevExpress.XtraEditors;
using PetShopLib.Enums;
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
    public partial class PetForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "storage.json";
        public List<Pet> _pets;
        public PetForm()
        {
            InitializeComponent();
        }

        private void PetForm_Load(object sender, EventArgs e)
        {
            PetShop _petShop = new PetShop();
            _petShop.Pets = new List<Pet>();
            var pet = new Pet();
            pet.Breed = "Molosos";
            _petShop.Pets.Add(pet);
            bsPets.DataSource = _petShop.Pets;
            ctrlBreed.EditValue = pet.Breed;
            SetDataBindings();
            

            comboBoxEdit1.Properties.Items.Add(PetStatusEnum.Unhealthy);
            comboBoxEdit1.Properties.Items.Add(PetStatusEnum.Healthy);
            comboBoxEdit1.Properties.Items.Add(PetStatusEnum.Recovering);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Dog);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Cat);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Fish);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Lizard);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Bird);
        }
        private void SetDataBindings()
        {
            ctrlBreed.DataBindings.Add(new Binding("EditValue", bsPets, "Breed", true));
            ctrlCost.DataBindings.Add(new Binding("EditValue", bsPets, "Cost", true));
            ctrlPrice.DataBindings.Add(new Binding("EditValue", bsPets, "Price", true));
            comboBoxEdit1.DataBindings.Add(new Binding("EditValue", bsPets, "PetStatus", true));
            comboBoxEdit2.DataBindings.Add(new Binding("EditValue", bsPets, "AnimalType", true));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Pet s = new Pet();
        }
    }
}