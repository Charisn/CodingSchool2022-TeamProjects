using DevExpress.XtraEditors;
using PetShopLib.Enums;
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
    public partial class PetForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "PetShop.json";
        private PetShop _petShop;
        private Pet _pet;
        private Pet _originalPet = new Pet();
        public PetForm()
        {
            InitializeComponent();
            
        }
        public PetForm(PetShop petShop)
        {
            InitializeComponent();
            _petShop = petShop;
        }
        public PetForm(PetShop petShop, Pet pet) : this(petShop)
        {

            _pet = pet;
        }

        private void PetForm_Load(object sender, EventArgs e)
        {
            


            if (_pet == null)
            {
                _pet = new Pet();
                _petShop.Pets.Add(_pet);
                bsPets.DataSource = _pet;


            }

            bsPets.DataSource = _pet;
            

            ctrlBreed.DataBindings.Add(new Binding("EditValue", bsPets, "Breed", true));
            ctrlCost.DataBindings.Add(new Binding("EditValue", bsPets, "Cost", true));
            ctrlPrice.DataBindings.Add(new Binding("EditValue", bsPets, "Price", true));
            comboBoxEdit1.DataBindings.Add(new Binding("EditValue", bsPets, "PetStatus", true));
            comboBoxEdit2.DataBindings.Add(new Binding("EditValue", bsPets, "AnimalType", true));

            comboBoxEdit1.Properties.Items.Add(PetStatusEnum.Unhealthy);
            comboBoxEdit1.Properties.Items.Add(PetStatusEnum.Healthy);
            comboBoxEdit1.Properties.Items.Add(PetStatusEnum.Recovering);
            comboBoxEdit1.Properties.Items.Add(PetStatusEnum.Sold);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Dog);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Cat);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Fish);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Lizard);
            comboBoxEdit2.Properties.Items.Add(AnimalTypeEnum.Bird);
        }

        private void btnOKΚ_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(_petShop);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _petShop.Pets.Remove(_pet);
            this.Close();
        }
    }
        

       
    
}