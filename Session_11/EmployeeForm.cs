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

namespace Session_11
{
    public partial class EmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        private PetShop _petShop;
        private Employee _employee;
        public EmployeeForm(PetShop petShop)
        {
            InitializeComponent();
            _petShop = petShop;
        }

        public EmployeeForm(PetShop petShop,Employee employee) :this(petShop)
        {
            InitializeComponent();
            _employee = employee;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            //PopulateControls();

            //if (_student == null)
            //{
            //    _student = new Student();
            //    _university.Students.Add(_student);
            //    bsStudents.DataSource = _student;
            //}

            if(_employee == null)
            {
                _employee = new Employee();
                _petShop.Employees.Add(_employee);
                bsEmployees.DataSource = _employee;

                
            }

            bsEmployees.DataSource = _employee;

           // SetDataBindings();

        }

       
    }
}