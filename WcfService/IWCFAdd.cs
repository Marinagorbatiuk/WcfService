using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
  public  interface IWCFAdd
    {
        void AddEmployee(StaffWCF wcfStaff);
        List<string> WritingOff(List<WriteOffMaterialsWCF> writeOffMaterials);
        void AddMaterialsToDB(MaterialsWCF materialsWCF);
    }
}
