using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
  public interface IDalAdd
    {
        void AddUser(Staff dTODallStaff);
        List<string> WritingOff(List<WriteOffMaterial> writeOffMaterials);
        void AddMaterialToDB(Material material);
     
    }
}
