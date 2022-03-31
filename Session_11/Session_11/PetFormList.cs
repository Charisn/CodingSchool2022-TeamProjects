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
    public partial class PetFormList : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "PetShop.json";
        public PetFormList()
        {
            InitializeComponent();
        }

        private void PetFormList_Load(object sender, EventArgs e)
        {
            PopulatePets();
            
        }
        
        private void PopulatePets()
        { 
            string s = File.ReadAllText(FILE_NAME);
            var petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));

            bsPetShop.DataSource = petShop;

            bsPets.DataSource = bsPetShop;
            bsPets.DataMember = "Pets";

            grdPets.DataSource = bsPets;
        }

       
        public void SaveData()
        {
            var petShop = bsPetShop.Current as PetShop;
            string json = JsonSerializer.Serialize(petShop);
            File.WriteAllText(FILE_NAME, json);


        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            var petShop = bsPetShop.Current as PetShop;

            PetForm petForm = new PetForm(petShop);
            petForm.ShowDialog();
            grvPets.RefreshData();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            var petShop = bsPetShop.Current as PetShop;
            var pet = bsPets.Current as Pet;

            PetForm petFoodForm = new PetForm(petShop, pet);
            petFoodForm.ShowDialog();
            grvPets.RefreshData();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete this pet?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var pet = bsPets.Current as Pet;
            bsPets.Remove(pet);
            grvPets.RefreshData();
            SaveData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}