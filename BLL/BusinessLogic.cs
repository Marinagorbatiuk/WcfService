using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace BLL
{
    class BusinessLogic
    {
        //public BllStaff GetUserAutorization(string login, string password)
        //{

        //    BllStaff bllStaff = null;
        //    DalFunction dalFunction = new DalFunction();
        //    Staff staff = dalFunction.GetUser(login, password);

        //    if (staff != null)
        //    {

        //        bllStaff = new BllStaff
        //        {
        //            Login = staff.Login,
        //            Password = staff.Password,
        //            WorkPosition = new BllWorkPosition
        //            {
        //                Name = staff.WorkPosition.Name,
        //            }
        //        };

        //        //workPosition = ConvertationsBLL.ConvertPositionToBll(dalFunction.GetOneWorkPosition(staff.Id));
        //    }
        //    return bllStaff;
        //}


        //public List<BllWorkPosition> GetListPositions()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllWorkPosition> positions = new List<BllWorkPosition>();
        //    foreach (var item in function.GetWorkPosition())
        //    {
        //        //positions.Add(ConvertationsBLL.ConvertPositionToBll(item));
        //    }

        //    return positions;
        //}

        //public List<BllShampoo> GetListShampoo()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllShampoo> bllShampoosList = new List<BllShampoo>();

        //    bllShampoosList = function.GetShampoo().Select(x => ConvertationsBLL.ConvertShampoToBLL(x)).ToList();

        //    return bllShampoosList;
        //}
        //public List<BllBalsam> GetListBalsam()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllBalsam> bllBalsamList = new List<BllBalsam>();

        //    //bllBalsamList = function.GetBalsam().Select(x => ConvertationsBLL.ConvertBalsamToBll(x)).ToList();

        //    return bllBalsamList;
        //}
        //public List<BllColor> GetListColor()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllColor> bllBaColorList = new List<BllColor>();

        //    bllBaColorList = function.GetColor().Select(x => ConvertationsBLL.ConvertColorToBll(x)).ToList();

        //    return bllBaColorList;
        //}
        //public List<BllFoundation> GetListFoundation()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllFoundation> bllBaFoundationList = new List<BllFoundation>();

        //    bllBaFoundationList = function.GetFoundation().Select(x => ConvertationsBLL.ConvertFoundationToBll(x)).ToList();

        //    return bllBaFoundationList;
        //}

        //public List<BllLaque> GetListLaque()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllLaque> bllBaLaqueList = new List<BllLaque>();

        //    bllBaLaqueList = function.GetLaque().Select(x => ConvertationsBLL.ConvertLaqueToBll(x)).ToList();

        //    return bllBaLaqueList;
        //}
        //public List<BllLipstick> GetListLipstick()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllLipstick> bllBaLipstickList = new List<BllLipstick>();

        //    bllBaLipstickList = function.GetLipstick().Select(x => ConvertationsBLL.ConvertLipstickToBLL(x)).ToList();

        //    return bllBaLipstickList;
        //}
        //public List<BllMascara> GetListMascara()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllMascara> bllBaMascaraList = new List<BllMascara>();

        //    bllBaMascaraList = function.GetMascara().Select(x => ConvertationsBLL.ConvertMascaraToBll(x)).ToList();

        //    return bllBaMascaraList;
        //}
        //public List<BllNailBase> GetListNailBase()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllNailBase> bllBaseList = new List<BllNailBase>();

        //    bllBaseList = function.GetNailBase().Select(x => ConvertationsBLL.ConvertBaseToBll(x)).ToList();

        //    return bllBaseList;
        //}

        //public List<BllNailPolish> GetListNailPolish()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllNailPolish> bllPolishList = new List<BllNailPolish>();

        //    bllPolishList = function.GetNailPolish().Select(x => ConvertationsBLL.ConvertPolishToBLL(x)).ToList();

        //    return bllPolishList;
        //}
        //public List<BllNailTop> GetListNailTop()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllNailTop> bllTopList = new List<BllNailTop>();

        //    bllTopList = function.GetNailTop().Select(x => ConvertationsBLL.ConvertTopTOBLL(x)).ToList();

        //    return bllTopList;
        //}
        //public List<BllPowder> GetListPowder()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllPowder> bllPowderList = new List<BllPowder>();

        //    bllPowderList = function.GetPowder().Select(x => ConvertationsBLL.ConvertPowderToBll(x)).ToList();

        //    return bllPowderList;
        //}
        //public List<BllShadows> GetListShadow()
        //{
        //    DalFunction function = new DalFunction();
        //    List<BllShadows> bllShadowList = new List<BllShadows>();

        //    bllShadowList = function.GetShadow().Select(x => ConvertationsBLL.ConvertShadowToBll(x)).ToList();

        //    return bllShadowList;
        //}
        //public void DeleteProduct(int id)
        //{
        //    DalFunction function = new DalFunction();
        //    function.Delete(id);
        //}
      //public List<BllStaff> GetEmployees()
      //{
      //    DalFunction function = new DalFunction();
      //    List<BllStaff> bllStaffs = new List<BllStaff>();
      //    bllStaffs = function.GetStaff().Select(x => ConvertationsBLL.ConvertStaffToBll(x)).ToList();
      //    return bllStaffs;
      //}
        //public void DeleteEmployee(int id)
        //{
        //    DalFunction function = new DalFunction();
        //    function.DeleteUser(id);
        //}

        //public void AddEmployee(BllStaff bllStaff)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddUser(ConvertationsBLL.ConvertStaffToDTO(bllStaff));
        //}
        //public void AddShampooToDB(BllShampoo bllShampoo)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddShampooToDB(ConvertationsBLL.ConvertShampooToDTO(bllShampoo));
        //}
        //public void AddBalsamToDB(BllBalsam bllBalsam)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddBalsamToDB(ConvertationsBLL.ConvertBalsamToDTO(bllBalsam));
        //}
        //public void AddColorToDB(BllColor bllColor)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddColorToDB(ConvertationsBLL.ConvertColorToDTO(bllColor));
        //}
        //public void AddLaqueToDB(BllLaque bllLaque)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddLaqueToDB(ConvertationsBLL.ConvertLaqueToDTO(bllLaque));
        //}
        //public void AddFoundationToDB(BllFoundation bllFoundation)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddFoundationToDB(ConvertationsBLL.ConvertFoundationToDTO(bllFoundation));
        //}
        //public void AddLipstickToDB(BllLipstick bllLipstick)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddLipstickToDB(ConvertationsBLL.ConvertLipstickToDTO(bllLipstick));
        //}
        //public void AddMascaraToDB(BllMascara bllMascara)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddMascaraToDB(ConvertationsBLL.ConvertMascaraToDTO(bllMascara));
        //}
        //public void AddPowderToDB(BllPowder bllPowder)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddPowderToDB(ConvertationsBLL.ConvertPowderToDTO(bllPowder));
        //}
        //public void AddShadowToDB(BllShadows bllShadows)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddShadowToDB(ConvertationsBLL.ConvertShadowToDTO(bllShadows));
        //}
        //public void AddPolishToDB(BllNailPolish bllNailPolish)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddPolishToDB(ConvertationsBLL.ConvertPolishToDTO(bllNailPolish));
        //}
        //public void AddTopToDB(BllNailTop bllNailTop)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddTopToDB(ConvertationsBLL.ConvertTopToDTO(bllNailTop));
        //}
        //public void AddBaseToDB(BllNailBase bllNailBase)
        //{
        //    DalFunction function = new DalFunction();
        //    function.AddBaseToDB(ConvertationsBLL.ConvertBaseToDTO(bllNailBase));
        //}
        //public void UpdateShampoo (BllShampoo bllShampoo)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateShampoo(ConvertationsBLL.ConvertShampooToDTO(bllShampoo));                
        //}
        //public void UpdateBalsam (BllBalsam bllBalsam)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateBalsam(ConvertationsBLL.ConvertBalsamToDTO(bllBalsam));
        //}
        //public void UpdateLaque(BllLaque bllLaque)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateLaque(ConvertationsBLL.ConvertLaqueToDTO(bllLaque));
        //}
        //public void UpdateColor (BllColor bllColor)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateColor(ConvertationsBLL.ConvertColorToDTO(bllColor));
        //}
        //public void UpdateFoundation (BllFoundation bllFoundation)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateFoundation(ConvertationsBLL.ConvertFoundationToDTO(bllFoundation));
        //}
        //public void UpdatePowder (BllPowder bllPowder)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdatePowder(ConvertationsBLL.ConvertPowderToDTO(bllPowder));
        //}
        //public void UpdateShadow (BllShadows bllShadows)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateShadow(ConvertationsBLL.ConvertShadowToDTO(bllShadows));
        //}
        //public void UpdateMascara( BllMascara bllMascara)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateMascara(ConvertationsBLL.ConvertMascaraToDTO(bllMascara));
        //}
        //public void UpdateLipstick( BllLipstick bllLipstick)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateLipstick(ConvertationsBLL.ConvertLipstickToDTO(bllLipstick));
        //}
        //public void UpdateNailBase (BllNailBase bllNailBase)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateBase(ConvertationsBLL.ConvertBaseToDTO(bllNailBase));
        //}
        //public void UpdatePolish (BllNailPolish bllNailPolish)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdatePolish(ConvertationsBLL.ConvertPolishToDTO(bllNailPolish));
        //}
        //public void UpdateTop (BllNailTop bllNailTop)
        //{
        //    DalFunction function = new DalFunction();
        //    function.UpdateTop(ConvertationsBLL.ConvertTopToDTO(bllNailTop));
   // }
    //public List<BllServices> GetListServices ()
    //{
    //    DalFunction dalFunction = new DalFunction();

    //    List<BllServices> getlistServices = new List<BllServices>();
    //    List<Service> tmplistServices = dalFunction.getServusec();
    //    getlistServices.AddRange(tmplistServices.Select(x => new BllServices
    //    {
    //        Name = x.Name,
    //        Price = x.Price,
    //        BllMaterials = new List<BllMaterials> (x.Materials.Select(y=> GetBllMaterials(y)).ToList())
    //    }).ToList());

    //    return getlistServices;
    //}
    //public BllMaterials GetBllMaterials(Material tmpMaterial)//??????????????????
    //{
    //    BllMaterials getmaterial = null;
    //    if(tmpMaterial is Balsam)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertBalsamToBll(tmpMaterial as Balsam);
    //    }
    //    else if (tmpMaterial is Shampoo)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertShampoToBLL(tmpMaterial as Shampoo);
    //    }
    //    else if (tmpMaterial is Laque)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertLaqueToBll(tmpMaterial as Laque);
    //    }
    //    else if (tmpMaterial is HairColor)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertColorToBll(tmpMaterial as HairColor);
    //    }
    //    else if (tmpMaterial is Powder)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertPowderToBll(tmpMaterial as Powder);

    //    }
    //    else if (tmpMaterial is Foundation)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertFoundationToBll(tmpMaterial as Foundation);
    //    }
    //    else if(tmpMaterial is Mascara)
    //        {
    //        getmaterial = ConvertationsBLL.ConvertMascaraToBll(tmpMaterial as Mascara);
    //    }
    //    else if (tmpMaterial is Lipstick)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertLipstickToBLL(tmpMaterial as Lipstick);
    //    }
    //    else if (tmpMaterial is Shadows)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertShadowToBll(tmpMaterial as Shadows);
    //    }
    //    else if (tmpMaterial is NailBase)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertBaseToBll(tmpMaterial as NailBase);
    //    }
    //    else if (tmpMaterial is NailTop)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertTopTOBLL(tmpMaterial as NailTop);
    //    }
    //    else if (tmpMaterial is NailPolish)
    //    {
    //        getmaterial = ConvertationsBLL.ConvertPolishToBLL(tmpMaterial as NailPolish);
    //    }
    //    return getmaterial;
    //}
}
    
}

