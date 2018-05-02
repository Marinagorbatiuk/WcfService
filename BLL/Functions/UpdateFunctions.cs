using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace BLL
{
  public  class UpdateFunctions
    {
        UpdateFunctionDal function = new UpdateFunctionDal();
        public void UpdateShampoo(BllShampoo bllShampoo)
        {
            function.UpdateShampoo(ConvertationsBLL.ConvertShampooToDTO(bllShampoo));
        }
        public void UpdateBalsam(BllBalsam bllBalsam)
        {
            function.UpdateBalsam(ConvertationsBLL.ConvertBalsamToDTO(bllBalsam));
        }
        public void UpdateLaque(BllLaque bllLaque)
        {
            function.UpdateLaque(ConvertationsBLL.ConvertLaqueToDTO(bllLaque));
        }
        public void UpdateColor(BllColor bllColor)
        {
            function.UpdateColor(ConvertationsBLL.ConvertColorToDTO(bllColor));
        }
        public void UpdateFoundation(BllFoundation bllFoundation)
        {
            function.UpdateFoundation(ConvertationsBLL.ConvertFoundationToDTO(bllFoundation));
        }
        public void UpdatePowder(BllPowder bllPowder)
        {
            function.UpdatePowder(ConvertationsBLL.ConvertPowderToDTO(bllPowder));
        }
        public void UpdateShadow(BllShadows bllShadows)
        {
            function.UpdateShadow(ConvertationsBLL.ConvertShadowToDTO(bllShadows));
        }
        public void UpdateMascara(BllMascara bllMascara)
        {
            function.UpdateMascara(ConvertationsBLL.ConvertMascaraToDTO(bllMascara));
        }
        public void UpdateLipstick(BllLipstick bllLipstick)
        {
            function.UpdateLipstick(ConvertationsBLL.ConvertLipstickToDTO(bllLipstick));
        }
        public void UpdateNailBase(BllNailBase bllNailBase)
        {
            function.UpdateBase(ConvertationsBLL.ConvertBaseToDTO(bllNailBase));
        }
        public void UpdatePolish(BllNailPolish bllNailPolish)
        {
            function.UpdatePolish(ConvertationsBLL.ConvertPolishToDTO(bllNailPolish));
        }
        public void UpdateTop(BllNailTop bllNailTop)
        {
          function.UpdateTop(ConvertationsBLL.ConvertTopToDTO(bllNailTop));
        }
    }
}
