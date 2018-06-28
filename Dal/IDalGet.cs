using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
 public   interface IDalGet
    {
        void GetChangedQuantity(int QuantityBottles, double QuantityGeneralVolume, int id);
        List<Service> getServices();
        List<Staff> GetStaff();
        List<Material> GetMaterial();
        Staff GetUser(string login, string passWord);
        ICollection<Info> GetLoggs();
        ICollection<WorkPosition> GetWorkPosition();
        WorkPosition GetOneWorkPosition(int Id); 

    }
}
