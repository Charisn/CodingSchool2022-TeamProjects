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
        #region DummyData
        private void CreateCustomers()
        {
            var customer = new Customer()
            {
                Name = "{ADD NAME}",
                SurName = "{ADD SURNAME}",
                TIN = 45858751,
                Phone = 698323214
            };
            _petShop.Customers.Add(customer);
        }
        private void CreateEmployees()
        {
            var employee = new Employee()
            {
                Name = "{ADD NAME}",
                SurName = "{ADD SURNAME}",
                EmployeeType = EmployeeTypeEnum.Staff,
                SalaryPerMonth = 0
            };
            _petShop.Employees.Add(employee);
        }
        private void CreatePets()
        {
            var pets = new Pet()
            {
                Breed = "{ADD NAME}",
                AnimalType = AnimalTypeEnum.Dog,
                Price = 10,
                PetStatus = PetStatusEnum.Healthy,
                Cost = 4
            };
            _petShop.Pets.Add(pets);
        }
        private void CreatePetFoods()
        {
            var petfoods = new PetFood()
            {
                AnimalType = AnimalTypeEnum.Dog,
                Price = 150,
                Cost = 50
            };
            _petShop.PetFoods.Add(petfoods);
        }
        #endregion

        private void SaveData()
        {
            string json = JsonSerializer.Serialize(_petShop);

            File.WriteAllText(FILE_NAME, json);
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
            string message = "Do you want to leave the shop?";
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
            InteractWithUser();
        }

        private void MainMenuStripLoad(object sender, EventArgs e)
        {
            LoadData();
            InteractWithUser();
        }

        private void editPetFood_Click(object sender, EventArgs e)
        {
            PetFoodListForm petFoodListForm = new PetFoodListForm();
            petFoodListForm.Show();
        }

        private void MenuStripPetList_Click(object sender, EventArgs e)
        {
            PetFormList petListForm = new PetFormList();
            petListForm.Show();
        }
        private void MainFormClosing(object sencer, FormClosingEventArgs e)
        {
            e.Cancel = true;
            SaveData();
        }
        private void InteractWithUser()
        {
            MessageBox.Show("Completed Successefully!", "Pet Shop");
        }
    }
}