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
            //PetListForm petForm = new PetListForm();
            //petForm.Show();
        }

        private void LoadData()
        {
            if (File.Exists(FILE_NAME))
            {
                string s = File.ReadAllText(FILE_NAME);
                _petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));

                DelayAction();
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

        internal void DelayAction()
        {
            Cursor.Current = Cursors.WaitCursor;
            System.Threading.Thread.Sleep(500);
            MessageBox.Show("Process completed", "Pet Shop");
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

            DelayAction();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MenuStripEmployee(object sender, EventArgs e)
        {
            EmployeeListForm form = new EmployeeListForm();
            form.Show();
        }

        private void MenuStripCustomer(object sender, EventArgs e)
        {
            CustomerListForm form = new CustomerListForm();
            form.Show();
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
            managerForm.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            TransactionNewForm transactionForm = new TransactionNewForm();
            transactionForm.ShowDialog();
        }

        private void MainMenuStripSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void MainMenuStripLoad(object sender, EventArgs e)
        {
            LoadData();
        }

        private void editPetFood_Click(object sender, EventArgs e)
        {
            PetFoodListForm petFoodListForm = new PetFoodListForm();
            petFoodListForm.Show();
        }

        private void MenuStripPetList_Click(object sender, EventArgs e)
        {
            //PetListForm petListForm = new PetListForm();
            //petListForm.Show();
        }
        private void MainFormClosing(object sencer, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}