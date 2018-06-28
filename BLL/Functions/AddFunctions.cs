using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.ComponentModel.DataAnnotations;
namespace BLL
{
   public class AddFunctions:IBllAdd
    {
        IDalAdd function;
        public AddFunctions(IDalAdd dalAdd)
        {
            function = dalAdd;
        }
        public void AddEmployee(BllStaff bllStaff)
        {        
               function.AddUser(ConvertationsBLL.ConvertStaffToDTO(bllStaff));
        }

        public List<string> WritingOff(List<WriteOffMaterialBll> writeOffMaterials)
        {
            return function.WritingOff(writeOffMaterials.Select(x => ConvertationsBLL.ConvertWriteOffToBD(x)).ToList());
        }
        public void AddMaterialToDB(BllMaterials bllmaterials )
        {
            function.AddMaterialToDB(ConvertationsBLL.ConvertMaterialsToDB(bllmaterials));
        }
        //public void AddShampooToDB(BllShampoo bllShampoo)
        //{
        //    function.AddShampooToDB(ConvertationsBLL.ConvertShampooToDTO(bllShampoo));      
        // }
        //public void AddBalsamToDB(BllBalsam bllBalsam)
        //{
        //    function.AddBalsamToDB(ConvertationsBLL.ConvertBalsamToDTO(bllBalsam));
        //}
        //public void AddColorToDB(BllColor bllColor)
        //{
        //    function.AddColorToDB(ConvertationsBLL.ConvertColorToDTO(bllColor));
        //}
        //public void AddLaqueToDB(BllLaque bllLaque)
        //{
        //    function.AddLaqueToDB(ConvertationsBLL.ConvertLaqueToDTO(bllLaque));
        //}
        //public void AddFoundationToDB(BllFoundation bllFoundation)
        //{
        //    function.AddFoundationToDB(ConvertationsBLL.ConvertFoundationToDTO(bllFoundation));
        //}
        //public void AddLipstickToDB(BllLipstick bllLipstick)
        //{
        //    function.AddLipstickToDB(ConvertationsBLL.ConvertLipstickToDTO(bllLipstick));
        //}
        //public void AddMascaraToDB(BllMascara bllMascara)
        //{
        //    function.AddMascaraToDB(ConvertationsBLL.ConvertMascaraToDTO(bllMascara));
        //}
        //public void AddPowderToDB(BllPowder bllPowder)
        //{
        //    function.AddPowderToDB(ConvertationsBLL.ConvertPowderToDTO(bllPowder));
        //}
        //public void AddShadowToDB(BllShadows bllShadows)
        //{
        //    function.AddShadowToDB(ConvertationsBLL.ConvertShadowToDTO(bllShadows));
        //}
        //public void AddPolishToDB(BllNailPolish bllNailPolish)
        //{
        //    function.AddPolishToDB(ConvertationsBLL.ConvertPolishToDTO(bllNailPolish));
        //}
        //public void AddTopToDB(BllNailTop bllNailTop)
        //{
        //    function.AddTopToDB(ConvertationsBLL.ConvertTopToDTO(bllNailTop));
        //}
        //public void AddBaseToDB(BllNailBase bllNailBase)
        //{
        //    function.AddBaseToDB(ConvertationsBLL.ConvertBaseToDTO(bllNailBase));
        //}

    }
}
