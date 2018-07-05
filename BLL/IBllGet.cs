using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  interface IBllGet
    {
        ICollection<BllInfo> GetLoggs();
        void GetChangedQuantity(int QuantityBottles, double QuantityGeneralVolume, int id);
        List<BllWorkPosition> GetListPositions();
        List<BllMaterials> GetListMaterials();
        List<BllStaff> GetEmployees();
        List<BllServices> GetListServices();
        BllStaff GetUserAutorization(string login, string password);
    }
}
