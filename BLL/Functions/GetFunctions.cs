using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace BLL
{
  public  class GetFunctions
    {
        GetFunctionDal function = new GetFunctionDal();
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
                positions.Add(ConvertationsBLL.ConvertPositionToBll(item));
            }

            return positions;
        }

        public List<BllShampoo> GetListShampoo()
        {
            
            List<BllShampoo> bllShampoosList = new List<BllShampoo>();

            bllShampoosList = function.GetShampoo().Select(x => ConvertationsBLL.ConvertShampoToBLL(x)).ToList();

            return bllShampoosList;
        }
        public List<BllBalsam> GetListBalsam()
        {
            
            List<BllBalsam> bllBalsamList = new List<BllBalsam>();

           bllBalsamList = function.GetBalsam().Select(x => ConvertationsBLL.ConvertBalsamToBll(x)).ToList();

            return bllBalsamList;
        }
        public List<BllColor> GetListColor()
        {
         
            List<BllColor> bllBaColorList = new List<BllColor>();

            bllBaColorList = function.GetColor().Select(x => ConvertationsBLL.ConvertColorToBll(x)).ToList();

            return bllBaColorList;
        }
        public List<BllFoundation> GetListFoundation()
        {
           
            List<BllFoundation> bllBaFoundationList = new List<BllFoundation>();

            bllBaFoundationList = function.GetFoundation().Select(x => ConvertationsBLL.ConvertFoundationToBll(x)).ToList();

            return bllBaFoundationList;
        }

        public List<BllLaque> GetListLaque()
        {
          
            List<BllLaque> bllBaLaqueList = new List<BllLaque>();

            bllBaLaqueList = function.GetLaque().Select(x => ConvertationsBLL.ConvertLaqueToBll(x)).ToList();

            return bllBaLaqueList;
        }
        public List<BllLipstick> GetListLipstick()
        {
           
            List<BllLipstick> bllBaLipstickList = new List<BllLipstick>();

            bllBaLipstickList = function.GetLipstick().Select(x => ConvertationsBLL.ConvertLipstickToBLL(x)).ToList();

            return bllBaLipstickList;
        }
        public List<BllMascara> GetListMascara()
        {
          
            List<BllMascara> bllBaMascaraList = new List<BllMascara>();

            bllBaMascaraList = function.GetMascara().Select(x => ConvertationsBLL.ConvertMascaraToBll(x)).ToList();

            return bllBaMascaraList;
        }
        public List<BllNailBase> GetListNailBase()
        {
           
            List<BllNailBase> bllBaseList = new List<BllNailBase>();

            bllBaseList = function.GetNailBase().Select(x => ConvertationsBLL.ConvertBaseToBll(x)).ToList();

            return bllBaseList;
        }

        public List<BllNailPolish> GetListNailPolish()
        {
            
            List<BllNailPolish> bllPolishList = new List<BllNailPolish>();

            bllPolishList = function.GetNailPolish().Select(x => ConvertationsBLL.ConvertPolishToBLL(x)).ToList();

            return bllPolishList;
        }
        public List<BllNailTop> GetListNailTop()
        {
           
            List<BllNailTop> bllTopList = new List<BllNailTop>();

            bllTopList = function.GetNailTop().Select(x => ConvertationsBLL.ConvertTopTOBLL(x)).ToList();

            return bllTopList;
        }
        public List<BllPowder> GetListPowder()
        {
          
            List<BllPowder> bllPowderList = new List<BllPowder>();

            bllPowderList = function.GetPowder().Select(x => ConvertationsBLL.ConvertPowderToBll(x)).ToList();

            return bllPowderList;
        }
        public List<BllShadows> GetListShadow()
        {
          
            List<BllShadows> bllShadowList = new List<BllShadows>();

            bllShadowList = function.GetShadow().Select(x => ConvertationsBLL.ConvertShadowToBll(x)).ToList();

            return bllShadowList;
        }
        // Employee
        public List<BllStaff> GetEmployees()
        {
            List<BllStaff> bllStaffs = new List<BllStaff>();
            bllStaffs = function.GetStaff().Select(x => ConvertationsBLL.ConvertStaffToBll(x)).ToList();
            return bllStaffs;
        }
        // services
        public List<BllServices> GetListServices()
        {
          
            List<BllServices> getlistServices = new List<BllServices>();
            List<Service> tmplistServices = function.getServices();
            getlistServices.AddRange(tmplistServices.Select(x => new BllServices
            {
                Name = x.Name,
                Price = x.Price,
                BllMaterials = new List<BllMaterials>(x.Materials.Select(y => ConvertationsBLL.ConvertBllMaterials(y)).ToList())
            }).ToList());
            return getlistServices;
        }
     
    }
}
