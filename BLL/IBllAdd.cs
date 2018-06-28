using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public interface IBllAdd
    {
        void AddEmployee(BllStaff bllStaff);
        List<string> WritingOff(List<WriteOffMaterialBll> writeOffMaterials);
        void AddMaterialToDB(BllMaterials bllmaterials);
    }
}
