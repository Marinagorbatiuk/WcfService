using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
namespace WcfService
{
    public class UpdateFunctionWCF:IWCFUpdate
    {
         IBllUpdate  function;
        public UpdateFunctionWCF(IBllUpdate bllUpdate)
        {
            function = bllUpdate;
        }
        public void UpdateMaterials(MaterialsWCF materialsWCF)
        {
            function.UpdateMaterial(ConvertationsWCF.ConvertMaterialsToDB(materialsWCF));
        }
        
    }
}