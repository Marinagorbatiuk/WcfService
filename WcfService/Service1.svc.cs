using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL;
namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        AddFunctionWCF addFunctionWCF = new AddFunctionWCF();
        DeleteFunctionWCF deleteFunctionWCF = new DeleteFunctionWCF();
        GetFunctionWCF getFunctionWCF = new GetFunctionWCF();
        UpdateFunctionWCF updateFunctionWCF = new UpdateFunctionWCF();

        public void AddBalsam(BalsamWCF balsamWCF)
        {
            addFunctionWCF.AddBalsamToDB(balsamWCF);
        }

        public void AddBase(NailBaseWCF nailBaseWCF)
        {
            addFunctionWCF.AddBaseToDB(nailBaseWCF);
        }

        public void AddColor(ColorWCF colorWCF)
        {
            addFunctionWCF.AddColorToDB(colorWCF);
        }

        public void AddEmployee(StaffWCF staffWCF)
        {
            addFunctionWCF.AddEmployee(staffWCF);
        }

        public void AddFoundation(FoundationWCF foundationWCF)
        {
            addFunctionWCF.AddFoundationToDB(foundationWCF);
        }

        public void AddLaque(LaqueWCF laqueWCF)
        {
            addFunctionWCF.AddLaqueToDB(laqueWCF);
        }

        public void AddLipstick(LipstickWCF lipstickWCF)
        {
            addFunctionWCF.AddLipstickToDB(lipstickWCF);
        }

        public void AddMascara(MascaraWCF mascaraWCF)
        {
            addFunctionWCF.AddMascaraToDB(mascaraWCF);
        }

        public void AddPolish(NailPolishWCF nailPolishWCF)
        {
            addFunctionWCF.AddPolishToDB(nailPolishWCF);
        }

        public void AddPowder(PowderWCF powderWCF)
        {
            addFunctionWCF.AddPowderToDB(powderWCF);
        }

        public void AddShadow(ShadowsWCF shadowsWCF)
        {
            addFunctionWCF.AddShadowToDB(shadowsWCF);
        }

        public void AddShampoo(ShampooWCF shampooWCF)
        {
            addFunctionWCF.AddShampooToDB(shampooWCF);
        }

        public void AddTop(NailTopWCF nailTopWCF)
        {
            addFunctionWCF.AddTopToDB(nailTopWCF);
        }

        public void DeleteEmployee(int id)
        {
            deleteFunctionWCF.DeleteEmployee(id);
        }

        public void DeleteProduct(int id)
        {
            deleteFunctionWCF.DeleteProduct(id);
        }

        //public MaterialsWCF GetBllMaterials()
        //{
        //    throw new NotImplementedException();
        //}

        public StaffWCF[] GetEmployees()
        {
            throw new NotImplementedException();
        }

        public BalsamWCF[] GetListBalsam()
        {
            throw new NotImplementedException();
        }

        public NailBaseWCF[] GetListBase()
        {
            throw new NotImplementedException();
        }

        public ColorWCF[] GetListColor()
        {
            throw new NotImplementedException();
        }

        public FoundationWCF[] GetListFoundation()
        {
            throw new NotImplementedException();
        }

        public LaqueWCF[] GetListLaque()
        {
            throw new NotImplementedException();
        }

        public LipstickWCF[] GetListLipstick()
        {
            throw new NotImplementedException();
        }

        public MascaraWCF[] GetListMascara()
        {
            throw new NotImplementedException();
        }

        public NailPolishWCF[] GetListPolish()
        {
            throw new NotImplementedException();
        }

        public WorkPositionWCF[] GetListPositions()
        {
            throw new NotImplementedException();
        }

        public PowderWCF[] GetListPowder()
        {
            throw new NotImplementedException();
        }

        public ShadowsWCF[] GetListShadow()
        {
            throw new NotImplementedException();
        }

        public ShampooWCF[] GetListShampoo()
        {
            throw new NotImplementedException();
        }

        public NailTopWCF[] GetListTop()
        {
            // throw new NotImplementedException();
            getFunctionWCF.GetListNailTop();
        }

        public StaffWCF GetUserAutorization(string login, string password)
        {
            getFunctionWCF.GetUserAutorization(login, password);
        }

        public void UpdateBalsam(BalsamWCF balsamWCF)
        {
            updateFunctionWCF.UpdateBalsam(balsamWCF);
        }

        public void UpdateBase(NailBaseWCF nailBaseWCF)
        {
            updateFunctionWCF.UpdateNailBase(nailBaseWCF);
        }

        public void UpdateColor(ColorWCF colorWCF)
        {
            updateFunctionWCF.UpdateColor(colorWCF);
        }

        public void UpdateFoundation(FoundationWCF foundationWCF)
        {
            updateFunctionWCF.UpdateFoundation(foundationWCF);
        }

        public void UpdateLaque(LaqueWCF laqueWCF)
        {
            updateFunctionWCF.UpdateLaque(laqueWCF);
        }

        public void UpdateLipstick(LipstickWCF lipstickWCF)
        {
            updateFunctionWCF.UpdateLipstick(lipstickWCF);
        }

        public void UpdateMascara(MascaraWCF mascaraWCF)
        {
            updateFunctionWCF.UpdateMascara(mascaraWCF);
        }

        public void UpdatePolish(NailPolishWCF nailPolishWCF)
        {
            updateFunctionWCF.UpdatePolish(nailPolishWCF);
        }

        public void UpdatePowder(PowderWCF powderWCF)
        {
            updateFunctionWCF.UpdatePowder(powderWCF);
        }

        public void UpdateShadow(ShadowsWCF shadowsWCF)
        {
            updateFunctionWCF.UpdateShadow(shadowsWCF);
        }

        public void UpdateShampoo(ShampooWCF shampooWCF)
        {
            updateFunctionWCF.UpdateShampoo(shampooWCF);
        }

        public void UpdateTop(NailTopWCF nailTopWCF)
        {
            updateFunctionWCF.UpdateTop(nailTopWCF);
        }
    }
}
