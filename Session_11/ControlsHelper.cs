using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using PetShopLib.Enums;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Session_10
//{
//    internal class ControlsHelper
//    {
//        public void PopulatePetType(RepositoryItemLookUpEdit lookup)
//        {
//            var animalType = new List<AnimalType>();
//            animalType.Add(new AnimalType() { Code = "000001", Name = "Under-Graduate" , ID = "59A21C37-3FCA-4B40-AB75-22E662942044" });
//            animalType.Add(new AnimalType() { Code = "000002", Name = "Post-Graduate", ID = "99447DAD-3845-4DF7-8A8F-8C9F8ABCF843" });
//            lookup.DataSource = animalType;
//            lookup.Columns.Add(new LookUpColumnInfo("Code", "Code"));
//            lookup.Columns.Add(new LookUpColumnInfo("Name", "Name"));
//            lookup.DisplayMember = "Name";
//            lookup.ValueMember = "ID";
//        }

//        public void PopulateGender(RepositoryItemLookUpEdit lookup)
//        {
//            Dictionary<AnimalTypeEnum, string> genders = new Dictionary<AnimalTypeEnum, string>();
//            genders.Add(AnimalTypeEnum.Male, "Male");
//            genders.Add(AnimalTypeEnum.Female, "Female");
//            genders.Add(AnimalTypeEnum.OtherGender, "Other Gender");

//            lookup.DataSource = genders;
//            lookup.Columns.Add(new LookUpColumnInfo("Value"));
//            lookup.DisplayMember = "Value";
//            lookup.ValueMember = "Key";
//            lookup.ShowHeader = false;
//            lookup.NullText = null;
//        }

//    }
//}
