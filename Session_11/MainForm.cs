using PetShopLib;
using System.IO;
using System.Text.Json;
using PetShopLib.Impl;

namespace Session_11
{
    public partial class MainForm : Form
        //test 
    {
        private const string FILE_NAME = "PetShop.json";
        private PetShop _petShop;

        public MainForm()
        {
            InitializeComponent();

        }

        private void Menu_PetClick(object sender, EventArgs e)
        {
            PetForm petForm = new PetForm();
            petForm.ShowDialog();
        }

        private void LoadData()
        {
            string s = File.ReadAllText(FILE_NAME);
            _petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));
        }

        private void SaveData()
        {
            string json = JsonSerializer.Serialize(_petShop);

            File.WriteAllText(FILE_NAME, json);

            MessageBox.Show("File Saved!");
        }
    }
}