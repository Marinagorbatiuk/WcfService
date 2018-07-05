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
        IConvertationBll convertationBll;
        public AddFunctions(IDalAdd dalAdd, IConvertationBll convertationBll )
        {
            function = dalAdd;
           this.convertationBll = convertationBll;
        }
        public void AddEmployee(BllStaff bllStaff)
        {        
               function.AddUser(convertationBll.ConvertStaffToDTO(bllStaff));
        }

        public List<string> WritingOff(List<WriteOffMaterialBll> writeOffMaterials)
        {
            return function.WritingOff(writeOffMaterials.Select(x => convertationBll.ConvertWriteOffToBD(x)).ToList());
        }
        public void AddMaterialToDB(BllMaterials bllmaterials )
        {
            function.AddMaterialToDB(convertationBll.ConvertMaterialsToDB(bllmaterials));
        }
       
    }
}
