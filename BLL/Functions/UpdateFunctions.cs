using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace BLL
{
  public  class UpdateFunctions: IBllUpdate
    {
        IDalUpdate function;
        IConvertationBll convertationBll;
        public UpdateFunctions(IDalUpdate dalUpdate, IConvertationBll convertationBll)
        {
            function = dalUpdate;
            this.convertationBll = convertationBll;
        }

        public void UpdateMaterial(BllMaterials bllMaterials)
        {
            function.UpdateMaterial(convertationBll.ConvertMaterialsToDB(bllMaterials));
        }
       
    }
}
