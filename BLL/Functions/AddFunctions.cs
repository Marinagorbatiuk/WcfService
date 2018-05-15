using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.ComponentModel.DataAnnotations;
namespace BLL
{
   public class AddFunctions
    {
        //  DalFunction function = new DalFunction();
        AddFunctionDal function = new AddFunctionDal();
        // Employee
        public void AddEmployee(BllStaff bllStaff)
        {
            ValidationContext context = new ValidationContext(bllStaff);
            List<ValidationResult> result = new List<ValidationResult>();
            if(Validator.TryValidateObject(bllStaff,context,result,true))
            {
                function.AddUser(ConvertationsBLL.ConvertStaffToDTO(bllStaff));
            }
            else
            {
                //result[0].MemberNames[0]
            }
         
        }

        //public List<string> WritingOff(List<WriteOffMaterialBll> writeOffMaterials)
        //{
        //    function.WritingOff(ConvertationsBLL.ConvertWriteOffToBD(writeOffMaterials));

        //}

        public List<string> WritingOff(List<WriteOffMaterialBll> writeOffMaterials)
        {
            //List<string> newlist = new List<string>();
            //List<WriteOffMaterial> WriteoffMaterials = writeOffMaterials.Select(x => ConvertationsBLL.ConvertWriteOffToBD(x)).ToList();
            //newlist = function.WritingOff(WriteoffMaterials);
            //return newlist;

            return function.WritingOff(writeOffMaterials.Select(x => ConvertationsBLL.ConvertWriteOffToBD(x)).ToList());
        }

        public void AddShampooToDB(BllShampoo bllShampoo)
        {
            function.AddShampooToDB(ConvertationsBLL.ConvertShampooToDTO(bllShampoo));
        }
        public void AddBalsamToDB(BllBalsam bllBalsam)
        {
            function.AddBalsamToDB(ConvertationsBLL.ConvertBalsamToDTO(bllBalsam));
        }
        public void AddColorToDB(BllColor bllColor)
        {
            function.AddColorToDB(ConvertationsBLL.ConvertColorToDTO(bllColor));
        }
        public void AddLaqueToDB(BllLaque bllLaque)
        {
            function.AddLaqueToDB(ConvertationsBLL.ConvertLaqueToDTO(bllLaque));
        }
        public void AddFoundationToDB(BllFoundation bllFoundation)
        {
            function.AddFoundationToDB(ConvertationsBLL.ConvertFoundationToDTO(bllFoundation));
        }
        public void AddLipstickToDB(BllLipstick bllLipstick)
        {
            function.AddLipstickToDB(ConvertationsBLL.ConvertLipstickToDTO(bllLipstick));
        }
        public void AddMascaraToDB(BllMascara bllMascara)
        {
            function.AddMascaraToDB(ConvertationsBLL.ConvertMascaraToDTO(bllMascara));
        }
        public void AddPowderToDB(BllPowder bllPowder)
        {
            function.AddPowderToDB(ConvertationsBLL.ConvertPowderToDTO(bllPowder));
        }
        public void AddShadowToDB(BllShadows bllShadows)
        {
            function.AddShadowToDB(ConvertationsBLL.ConvertShadowToDTO(bllShadows));
        }
        public void AddPolishToDB(BllNailPolish bllNailPolish)
        {
            function.AddPolishToDB(ConvertationsBLL.ConvertPolishToDTO(bllNailPolish));
        }
        public void AddTopToDB(BllNailTop bllNailTop)
        {
            function.AddTopToDB(ConvertationsBLL.ConvertTopToDTO(bllNailTop));
        }
        public void AddBaseToDB(BllNailBase bllNailBase)
        {
            function.AddBaseToDB(ConvertationsBLL.ConvertBaseToDTO(bllNailBase));
        }

    }
}
