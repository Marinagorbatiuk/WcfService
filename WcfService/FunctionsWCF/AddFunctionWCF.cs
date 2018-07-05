using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
namespace WcfService
{
    public class AddFunctionWCF:IWCFAdd
    {
        IBllAdd function;
        public AddFunctionWCF(IBllAdd bllAdd)
        {
            function = bllAdd;
        }

        public void AddEmployee(StaffWCF  wcfStaff)
        {
            function.AddEmployee(ConvertationsWCF.ConvertStaffToBll(wcfStaff));
        }
        public List<string> WritingOff(List<WriteOffMaterialsWCF> writeOffMaterials)
        {
            return function.WritingOff(writeOffMaterials.Select(x => ConvertationsWCF.ConvertWriteOffToBD(x)).ToList());
        }

        public void AddMaterialsToDB(MaterialsWCF materialsWCF)
        {
            function.AddMaterialToDB(ConvertationsWCF.ConvertMaterialsToDB(materialsWCF));
        }
        
    }
}