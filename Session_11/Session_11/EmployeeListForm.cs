using DevExpress.XtraEditors;
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
using PetShopLib.Impl;
using PetShopLib.Enums;
using DevExpress.XtraEditors.Controls;

namespace Session_11
{
    public partial class EmployeeListForm : DevExpress.XtraEditors.XtraForm
    {

        private const string FILE_NAME = "PetShop.json";
       
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            PopulateControls();
            PopulateEmployees();
        }

        private void PopulateControls()
        {

            Dictionary<EmployeeTypeEnum, string> employeeTypes = new Dictionary<EmployeeTypeEnum, string>();
            employeeTypes.Add(EmployeeTypeEnum.Manager, "Manager");
            employeeTypes.Add(EmployeeTypeEnum.Staff, "Staff");
            

            repEmployeeType.DataSource = employeeTypes;
            repEmployeeType.Columns.Add(new LookUpColumnInfo("Value"));
            repEmployeeType.DisplayMember = "Value";
            repEmployeeType.ValueMember = "Key";
            repEmployeeType.ShowHeader = false;
            repEmployeeType.NullText = null;



            

        }

        private void PopulateEmployees()
        {
            string s = File.ReadAllText(FILE_NAME);
            var petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));
            bsPetShop.DataSource = petShop;

            bsEmployees.DataSource = bsPetShop;
            bsEmployees.DataMember = "Employees";

            grdEmployees.DataSource = bsEmployees;
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var petShop = bsPetShop.Current as PetShop;

            EmployeeForm employeeForm = new EmployeeForm(petShop);
            employeeForm.ShowDialog();
            grvEmployees.RefreshData();

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var petShop = bsPetShop.Current as PetShop;
            var employee = bsEmployees.Current as Employee;

            EmployeeForm employeeForm = new EmployeeForm(petShop,employee);
            employeeForm.ShowDialog();
            grvEmployees.RefreshData();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this,"Are you sure you want to delete this employee?",this.Text,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var employee = bsEmployees.Current as Employee;
            bsEmployees.Remove(employee);
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