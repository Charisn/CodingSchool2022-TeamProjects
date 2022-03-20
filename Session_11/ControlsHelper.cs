using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using PetShopLib.Enums;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Session_11
{
    internal class ControlsHelper
    {
        private const string FILE_NAME = "PetShop.json";
        private PetShop _petShop;

        public void PopulatePetType(RepositoryItemLookUpEdit lookup, PetShop petShop)
        {
            lookup.DataSource = petShop.Pets;
            lookup.Columns.Add(new LookUpColumnInfo("Breed", "Breed"));
            lookup.DisplayMember = "Breed";
            lookup.ValueMember = "ID";
            lookup.NullText = "Choose a Pet";
        }
        public void PopulateCustomer(RepositoryItemLookUpEdit lookup, PetShop petShop)
        {
            lookup.DataSource = petShop.Customers;
            lookup.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            lookup.DisplayMember = "Name";
            lookup.ValueMember = "TIN";
            lookup.NullText = "Choose a Customer";
        }
        public void PopulateEmployee(RepositoryItemLookUpEdit lookup, PetShop petShop)
        {
            lookup.DataSource = petShop.Employees;
            lookup.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            lookup.DisplayMember = "Name";
            lookup.ValueMember = "EmployeeType";
            lookup.NullText = "Choose an Employee";
        }
    }
}
