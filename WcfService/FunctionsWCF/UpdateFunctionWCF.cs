using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
namespace WcfService
{
    public class UpdateFunctionWCF
    {
        UpdateFunctions function = new UpdateFunctions();
        public void UpdateShampoo(ShampooWCF Shampoo)
        {
            function.UpdateShampoo(ConvertationsWCF.ConvertShampoToBLL(Shampoo));
        }
        public void UpdateBalsam(BalsamWCF Balsam)
        {
            function.UpdateBalsam(ConvertationsWCF.ConvertBalsamToBll(Balsam));
        }
        public void UpdateLaque(LaqueWCF Laque)
        {
            function.UpdateLaque(ConvertationsWCF.ConvertLaqueToBll(Laque));
        }
        public void UpdateColor(ColorWCF Color)
        {
            function.UpdateColor(ConvertationsWCF.ConvertColorToBll(Color));
        }
        public void UpdateFoundation(FoundationWCF Foundation)
        {
            function.UpdateFoundation(ConvertationsWCF.ConvertFoundationToBll(Foundation));
        }
        public void UpdatePowder(PowderWCF Powder)
        {
            function.UpdatePowder(ConvertationsWCF.ConvertPowderToBll(Powder));
        }
        public void UpdateShadow(ShadowsWCF Shadows)
        {
            function.UpdateShadow(ConvertationsWCF.ConvertShadowToBll(Shadows));
        }
        public void UpdateMascara(MascaraWCF Mascara)
        {
            function.UpdateMascara(ConvertationsWCF.ConvertMascaraToBll(Mascara));
        }
        public void UpdateLipstick(LipstickWCF Lipstick)
        {
            function.UpdateLipstick(ConvertationsWCF.ConvertLipstickToBLL(Lipstick));
        }
        public void UpdateNailBase(NailBaseWCF NailBase)
        {
            function.UpdateNailBase(ConvertationsWCF.ConvertBaseToBll(NailBase));
        }
        public void UpdatePolish(NailPolishWCF NailPolish)
        {
            function.UpdatePolish(ConvertationsWCF.ConvertPolishToBLL(NailPolish));
        }
        public void UpdateTop(NailTopWCF NailTop)
        {
            function.UpdateTop(ConvertationsWCF.ConvertTopTOBLL(NailTop));
        }
    }
}