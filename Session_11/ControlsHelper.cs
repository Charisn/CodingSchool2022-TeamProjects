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

namespace Session_11
{
    internal class ControlsHelper
    {
        public void PopulatePetType(RepositoryItemLookUpEdit lookup)
        {
            Dictionary<AnimalTypeEnum, string> animalTypes = new Dictionary<AnimalTypeEnum, string>();
            animalTypes.Add(AnimalTypeEnum.Bird, "Bird");
            animalTypes.Add(AnimalTypeEnum.Fish, "Fish");
            animalTypes.Add(AnimalTypeEnum.Lizard, "Lizard");
            animalTypes.Add(AnimalTypeEnum.Cat, "Cat");
            animalTypes.Add(AnimalTypeEnum.Dog, "Dog");

            lookup.DataSource = animalTypes;
            lookup.Columns.Add(new LookUpColumnInfo("Value"));
            lookup.DisplayMember = "Value";
            lookup.ValueMember = "Key";
            lookup.ShowHeader = false;
            lookup.NullText = null;
        }
    }
}
