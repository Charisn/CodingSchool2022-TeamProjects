using PetShopLib;
using System.IO;
using System.Text.Json;
using PetShopLib.Impl;
using PetShopLib.Enums;

namespace Session_11
{
    public partial class MainForm : Form
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
            if (File.Exists(FILE_NAME))
            {
                string s = File.ReadAllText(FILE_NAME);
                _petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));
            }
            else
            {
                _petShop = new PetShop();
                CreateCustomers();
                CreateEmployees();
                CreatePets();
                CreatePetFoods();

                SaveData();

            }
        }
        private void CreateCustomers()
        {
            var customer = new Customer() {
                Name = "Mitsos",
                SurName = "Tade",
                TIN = 4585875,
                Phone = 698888888
            };
            _petShop.Customers.Add(customer);
        }
        private void CreateEmployees()
        {

        }
        private void CreatePets()
        {
            var pets = new Pet()
            {
                Breed = "Tsiouaoua",
                AnimalType = AnimalTypeEnum.Dog,
                Price = 10,
                PetStatus = PetStatusEnum.Healthy,
                Cost = 4
            };
        }
        private void CreatePetFoods()
        {
            var petfoods = new PetFood()
            {
                AnimalType = AnimalTypeEnum.Dog,
                Price = 150,
                Cost = 50
            };

        }

        private void SaveData()
        {
            string json = JsonSerializer.Serialize(_petShop);

            File.WriteAllText(FILE_NAME, json);

            MessageBox.Show("OKAY!", "PetShop");

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MenuStripEmployee(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            form.Show();
        }

        private void MenuStripCustomer(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form = new CustomerForm();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void MainButtonExit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to leave our shop?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                SaveData();
                this.Close();
            }
            else
            {
                //Not closing window.
            }
        }
                  
        

    private void MainButtonManager_Click(object sender, EventArgs e)
        {
            LoginForm managerForm = new LoginForm();
            managerForm.Show();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

        }
        //Apo kato edit vaggeli
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerListForm cList = new CustomerListForm() ;
            cList.Show();
        }
    }
}