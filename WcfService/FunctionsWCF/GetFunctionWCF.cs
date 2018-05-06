using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
namespace WcfService
{
    public class GetFunctionWCF
    {
        GetFunctions function = new GetFunctions();
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

        public List<WorkPositionWCF> GetListPositions()
        {

            List<WorkPositionWCF> positions = new List<WorkPositionWCF>();
            foreach (var item in function.GetListPositions())
            {
                positions.Add(ConvertationsWCF.ConvertPositionToWcf(item));
            }
            return positions;
        }
        public List<ShampooWCF> GetListShampoo()
        {
            List<ShampooWCF> ShampoosList = new List<ShampooWCF>();
            ShampoosList = function.GetListShampoo().Select(x => ConvertationsWCF.ConvertShampooToWCF(x)).ToList();
            return ShampoosList;
        }
        public List<BalsamWCF> GetListBalsam()
        {

            List<BalsamWCF> BalsamList = new List<BalsamWCF>();
            BalsamList = function.GetListBalsam().Select(x => ConvertationsWCF.ConvertBalsamToWcf(x)).ToList();
            return BalsamList;
        }
        public List<ColorWCF> GetListColor()
        {
            List<ColorWCF> ColorList = new List<ColorWCF>();
            ColorList = function.GetListColor().Select(x =>ConvertationsWCF.ConvertColorToWcf(x)).ToList();
            return ColorList;
        }
        public List<FoundationWCF> GetListFoundation()
        {
            List<FoundationWCF> FoundationList = new List<FoundationWCF>();
            FoundationList = function.GetListFoundation().Select(x => ConvertationsWCF.ConvertFoundationTowcf(x)).ToList();
            return FoundationList;
        }

        public List<LaqueWCF> GetListLaque()
        {
            List<LaqueWCF> LaqueList = new List<LaqueWCF>();
            LaqueList = function.GetListLaque().Select(x => ConvertationsWCF.ConvertLaqueToWcf(x)).ToList();
            return LaqueList;
        }
        public List<LipstickWCF> GetListLipstick()
        {
            List<LipstickWCF> LipstickList = new List<LipstickWCF>();
            LipstickList = function.GetListLipstick().Select(x => ConvertationsWCF.ConvertLipstickTowcf(x)).ToList();
           return LipstickList;
        }
        public List<MascaraWCF> GetListMascara()
        {
            List<MascaraWCF> MascaraList = new List<MascaraWCF>();
            MascaraList = function.GetListMascara().Select(x => ConvertationsWCF.ConvertMascaraToWcf(x)).ToList();
            return MascaraList;
        }
        public List<NailBaseWCF> GetListNailBase()
        {
            List<NailBaseWCF>BaseList = new List<NailBaseWCF>();
            BaseList = function.GetListNailBase().Select(x => ConvertationsWCF.ConvertBaseToWCF(x)).ToList();
            return BaseList;
        }

        public List<NailPolishWCF> GetListNailPolish()
        {
            List<NailPolishWCF> PolishList = new List<NailPolishWCF>();
            PolishList = function.GetListNailPolish().Select(x => ConvertationsWCF.ConvertPolishToWcf(x)).ToList();
            return PolishList;
        }
        public List<NailTopWCF> GetListNailTop()
        {
            List<NailTopWCF> TopList = new List<NailTopWCF>();
            TopList = function.GetListNailTop().Select(x => ConvertationsWCF.ConvertTopToWcf(x)).ToList();
            return TopList;
        }
        public List<PowderWCF> GetListPowder()
        {
            List<PowderWCF> PowderList = new List<PowderWCF>();
            PowderList = function.GetListPowder().Select(x => ConvertationsWCF.ConvertPowderToWCF(x)).ToList();
            return PowderList;
        }
        public List<ShadowsWCF> GetListShadow()
        {
            List<ShadowsWCF> ShadowList = new List<ShadowsWCF>();
            ShadowList = function.GetListShadow().Select(x => ConvertationsWCF.ConvertShadowToWcf(x)).ToList();
            return ShadowList;
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