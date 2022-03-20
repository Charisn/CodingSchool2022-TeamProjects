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
using PetShopLib.Impl;
using System.IO;
using System.Text.Json;
using PetShopLib.Enums;

namespace Session_11
{
    public partial class EmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "PetShop.json";


        private PetShop _petShop;
        private Employee _employee;
        public EmployeeForm(PetShop petShop)
        {
            InitializeComponent();
            _petShop = petShop;
        }

        public EmployeeForm(PetShop petShop,Employee employee) :this(petShop)
        {
           
            _employee = employee;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            PopulateEmployeeTypes();


            if(_employee == null)
            {
                _employee = new Employee();
                _petShop.Employees.Add(_employee);
                bsEmployees.DataSource = _employee;

                
            }

            bsEmployees.DataSource = _employee;

            SetDataBindings();

        }


        private void PopulateEmployeeTypes()
        {

            List<EmployeeTypeEnum> employeeTypes = new List<EmployeeTypeEnum>();
            employeeTypes.Add(EmployeeTypeEnum.Staff);
            employeeTypes.Add(EmployeeTypeEnum.Manager);

            ctrlEmployeeType.Properties.DataSource = employeeTypes;
            ctrlEmployeeType.Properties.NullText = null;

        }

        private void SetDataBindings()
        {
            //ctrlName.DataBindings.Clear();
            //ctrlSurname.DataBindings.Clear();
            //ctrlSalaryPerMonth.DataBindings.Clear();

            //TODO : PROBLHMA STO EDIT

            ctrlName.DataBindings.Add(new Binding("EditValue", bsEmployees, "Name", true));
            ctrlSurname.DataBindings.Add(new Binding("EditValue", bsEmployees, "SurName", true));
            ctrlSalaryPerMonth.DataBindings.Add(new Binding("EditValue", bsEmployees, "SalaryPerMonth", true));
            ctrlEmployeeType.DataBindings.Add(new Binding("EditValue", bsEmployees, "EmployeeType", true));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(_petShop);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _petShop.Employees.Remove(_employee);
            this.Close();
        }
    }
}