using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
namespace WcfService
{
    public class GetFunctionWCF:IWCFGet
    {
        IBllGet function;
        public GetFunctionWCF(IBllGet bllGet)
        {
            function = bllGet;
        }
        public ICollection<InfoWCF> GetLoggs()
        {
            return function.GetLoggs().Select(x => ConvertationsWCF.ConvertToBllInfo(x)).ToList();
        }

        public StaffWCF GetUserAutorization(string login, string password)
        {
            StaffWCF Staffwcf = null;
            BllStaff staff = function.GetUserAutorization(login, password);

            if (staff != null)
            {
                Staffwcf = new StaffWCF
                {
                    Login = staff.Login,
                    Password = staff.Password,
                    WorkPosition = new WorkPositionWCF
                    {
                        Name = staff.WorkPosition.Name,
                    }
                };
                  
            }
            return Staffwcf;
        }
        public void GetChangedQuantity(int QuantityBottles, double QuantityGeneralVolume, int id)
        {
            function.GetChangedQuantity(QuantityBottles, QuantityGeneralVolume, id);
        }
        public List<WorkPositionWCF> GetListPositions()
        {
            List<WorkPositionWCF> positions = new List<WorkPositionWCF>();
            foreach (var item in function.GetListPositions())
            {
                positions.Add(ConvertationsWCF.ConvertPositionToWcf(item));
            }
            return positions;
        }
        public List<MaterialsWCF> GetMaterials()
        {
            return function.GetListMaterials().Select(x => ConvertationsWCF.ConvertWcfMaterials(x)).ToList();
        }
        
        public List<StaffWCF> GetEmployees()
        {
            List<StaffWCF> Staffs = new List<StaffWCF>();
            Staffs = function.GetEmployees().Select(x => ConvertationsWCF.ConvertStaffToWcf(x)).ToList();
            return Staffs;
        }
        // services
        public List<ServicesWCF> GetListServices()
        {
            List<ServicesWCF> getlistServices = new List<ServicesWCF>();
            List<BllServices> tmplistServices = function.GetListServices();
            getlistServices.AddRange(tmplistServices.Select(x => new ServicesWCF
            {
                Name = x.Name,
                Price = x.Price,
                WCFMaterials= new List<MaterialsWCF>(x.BllMaterials.Select(y => ConvertationsWCF.ConvertWcfMaterials(y)).ToList())
            }).ToList());
            return getlistServices;
        }
    }
}