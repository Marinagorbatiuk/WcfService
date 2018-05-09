using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        StaffWCF GetUserAutorization(string login, string password);
        [OperationContract]
        ServicesWCF[] GetServices();
        [OperationContract]
        WorkPositionWCF[] GetListPositions();
        [OperationContract]
        BalsamWCF[] GetListBalsam();
        [OperationContract]
        ShampooWCF[] GetListShampoo();
        [OperationContract]
        LaqueWCF[] GetListLaque();
        [OperationContract]
        ColorWCF[] GetListColor();
        [OperationContract]
        FoundationWCF[] GetListFoundation();
        [OperationContract]
        PowderWCF[] GetListPowder();
        [OperationContract]
        ShadowsWCF[] GetListShadow();
        [OperationContract]
        MascaraWCF[] GetListMascara();
        [OperationContract]
        LipstickWCF[] GetListLipstick();
        [OperationContract]
        NailTopWCF[] GetListTop();
        [OperationContract]
        NailBaseWCF[] GetListBase();
        [OperationContract]
        NailPolishWCF[] GetListPolish();
        [OperationContract]
        void DeleteProduct(int id);
        [OperationContract]
        StaffWCF[] GetEmployees();
        [OperationContract]
        void DeleteEmployee(int id);
        [OperationContract]
        void AddEmployee(StaffWCF staffWCF);
        [OperationContract]
        void AddShampoo(ShampooWCF shampooWCF);
        [OperationContract]
        void AddBalsam(BalsamWCF balsamWCF);
        [OperationContract]
        void AddColor(ColorWCF colorWCF);
        [OperationContract]
        void AddLaque(LaqueWCF laqueWCF);
        [OperationContract]
        void AddFoundation(FoundationWCF foundationWCF);
        [OperationContract]
        void AddPowder(PowderWCF powderWCF);
        [OperationContract]
        void AddShadow(ShadowsWCF shadowsWCF);
        [OperationContract]
        void AddMascara(MascaraWCF mascaraWCF);
        [OperationContract]
        void AddLipstick(LipstickWCF lipstickWCF);
        [OperationContract]
        void AddTop(NailTopWCF nailTopWCF);
        [OperationContract]
        void AddBase(NailBaseWCF nailBaseWCF);
        [OperationContract]
        void AddPolish(NailPolishWCF nailPolishWCF);

        [OperationContract]
        void UpdateShampoo(ShampooWCF shampooWCF);
        [OperationContract]
        void UpdateBalsam(BalsamWCF balsamWCF);
        [OperationContract]
        void UpdateColor(ColorWCF colorWCF);
        [OperationContract]
        void UpdateLaque(LaqueWCF laqueWCF);
        [OperationContract]
        void UpdateFoundation(FoundationWCF foundationWCF);
        [OperationContract]
        void UpdatePowder(PowderWCF powderWCF);
        [OperationContract]
        void UpdateShadow(ShadowsWCF shadowsWCF);
        [OperationContract]
        void UpdateMascara(MascaraWCF mascaraWCF);
        [OperationContract]
        void UpdateLipstick(LipstickWCF lipstickWCF);
        [OperationContract]
        void UpdateTop(NailTopWCF nailTopWCF);
        [OperationContract]
        void UpdateBase(NailBaseWCF nailBaseWCF);
        [OperationContract]
        void UpdatePolish(NailPolishWCF nailPolishWCF);
        //?????????????????????????????????????????????????????????????????????
        //[OperationContract]
        //MaterialsWCF GetBllMaterials();
    }
}
