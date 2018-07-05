using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace BLL
{
  public  class GetFunctions:IBllGet
    {
        IDalGet function;
        IConvertationBll convertationBll;
        public GetFunctions(IDalGet dalGet, IConvertationBll convertationBll)
        {
            function = dalGet;
            this.convertationBll = convertationBll;
        }

        public ICollection<BllInfo> GetLoggs()
        {
            return function.GetLoggs().Select(x => convertationBll.ConvertToBllInfo(x)).ToList();
        }
        public BllStaff GetUserAutorization(string login, string password)
        {
            BllStaff bllStaff = null;        
            Staff staff = function.GetUser(login, password);
            if (staff != null)
            {
                bllStaff = new BllStaff
                {
                    Login = staff.Login,
                    Password = staff.Password,
                    WorkPosition = new BllWorkPosition
                    {
                        Name = staff.WorkPosition.Name,
                    }
                };
            }
            return bllStaff;
        }
        public void GetChangedQuantity(int QuantityBottles, double QuantityGeneralVolume, int id)
        {
            function.GetChangedQuantity(QuantityBottles, QuantityGeneralVolume, id);
        }
        public List<BllWorkPosition> GetListPositions()
        {      
            List<BllWorkPosition> positions = new List<BllWorkPosition>();
            foreach (var item in function.GetWorkPosition())
            {
                positions.Add(convertationBll.ConvertPositionToBll(item));
            }

            return positions;
        }
        public List<BllMaterials> GetListMaterials()
        {
           
            return function.GetMaterial().Select(x => convertationBll.ConvertBllMaterials(x)).ToList();
        }
       
        public List<BllStaff> GetEmployees()
        {
            List<BllStaff> bllStaffs = new List<BllStaff>();
            bllStaffs = function.GetStaff().Select(x => convertationBll.ConvertStaffToBll(x)).ToList();
            return bllStaffs;
        }
        public List<BllServices> GetListServices()
        {
          
            List<BllServices> getlistServices = new List<BllServices>();
            List<Service> tmplistServices = function.getServices();
            getlistServices.AddRange(tmplistServices.Select(x => new BllServices
            {
                Name = x.Name,
                Price = x.Price,
                BllMaterials = new List<BllMaterials>(x.Materials.Select(y => convertationBll.ConvertBllMaterials(y)).ToList())
            }).ToList());
            return getlistServices;
        }
     
    }
}
