using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
  public  interface IWCFGet
    {
        ICollection<InfoWCF> GetLoggs();
        StaffWCF GetUserAutorization(string login, string password);
        void GetChangedQuantity(int QuantityBottles, double QuantityGeneralVolume, int id);
        List<WorkPositionWCF> GetListPositions();
        List<MaterialsWCF> GetMaterials();
        List<StaffWCF> GetEmployees();
        List<ServicesWCF> GetListServices();
    }
}
