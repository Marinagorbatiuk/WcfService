using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
namespace WcfService
{
    public class AddFunctionWCF
    {
        AddFunctions function = new AddFunctions();
        public void AddEmployee(StaffWCF  wcfStaff)
        {
            function.AddEmployee(ConvertationsWCF.ConvertStaffToBll(wcfStaff));
        }
        public void AddShampooToDB(ShampooWCF wcfShampoo)
        {
            function.AddShampooToDB(ConvertationsWCF.ConvertShampoToBLL(wcfShampoo));
        }

        public void AddBalsamToDB(BalsamWCF wcfBalsam)
        {
            function.AddBalsamToDB(ConvertationsWCF.ConvertBalsamToBll(wcfBalsam));
        }
        public void AddColorToDB(ColorWCF wcfColor)
        {
            function.AddColorToDB(ConvertationsWCF.ConvertColorToBll(wcfColor));
        }
        public void AddLaqueToDB(LaqueWCF wcfLaque)
        {
            function.AddLaqueToDB(ConvertationsWCF.ConvertLaqueToBll(wcfLaque));
        }
        public void AddFoundationToDB(FoundationWCF wcfFoundation)
        {
            function.AddFoundationToDB(ConvertationsWCF.ConvertFoundationToBll(wcfFoundation));
        }
        public void AddLipstickToDB(LipstickWCF Lipstick)
        {
            function.AddLipstickToDB(ConvertationsWCF.ConvertLipstickToBLL(Lipstick));
        }
        public void AddMascaraToDB(MascaraWCF Mascara)
        {
            function.AddMascaraToDB(ConvertationsWCF.ConvertMascaraToBll(Mascara));
        }
        public void AddPowderToDB(PowderWCF wcfPowder)
        {
            function.AddPowderToDB(ConvertationsWCF.ConvertPowderToBll(wcfPowder));
        }
        public void AddShadowToDB(ShadowsWCF Shadows)
        {
            function.AddShadowToDB(ConvertationsWCF.ConvertShadowToBll(Shadows));
        }
        public void AddPolishToDB(NailPolishWCF NailPolish)
        {
            function.AddPolishToDB(ConvertationsWCF.ConvertPolishToBLL(NailPolish));
        }
        public void AddTopToDB(NailTopWCF NailTop)
        {
            function.AddTopToDB(ConvertationsWCF.ConvertTopTOBLL(NailTop));
        }
        public void AddBaseToDB(NailBaseWCF NailBase)
        {
            function.AddBaseToDB(ConvertationsWCF.ConvertBaseToBll(NailBase));
        }
    }
}