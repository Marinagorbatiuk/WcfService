using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
 public   class UpdateFunctionDal
    {
        ModelBeauty model = new ModelBeauty();
        public void UpdateShampoo(Shampoo shampoo)
        {
            Shampoo sh = null;
            // ModelBeauty model = new ModelBeauty();
            sh = (model.Materials.Where(x => x.Id == shampoo.Id).First() as Shampoo);

            model.Materials.Attach(sh);
            // sh = DALConvertation.ConvertShampooToEntity(shampoo);//???????????
            model.SaveChanges();
        }

        public void UpdateBalsam(Balsam dTOBalsam)
        {
            Balsam balsam = null;
            balsam = (model.Materials.Where(x => x.Id == dTOBalsam.Id).First() as Balsam);
            model.Materials.Attach(balsam);
            model.SaveChanges();
        }
        public void UpdateColor(HairColor dTOColor)
        {
            HairColor hairColor = null;
            hairColor = (model.Materials.Where(x => x.Id == dTOColor.Id).First() as HairColor);
            model.Materials.Attach(hairColor);
            model.SaveChanges();
        }
        public void UpdateLaque(Laque dTOLaque)
        {
            Laque laque = null;
            laque = (model.Materials.Where(x => x.Id == dTOLaque.Id).First() as Laque);
            model.Materials.Attach(laque);
            model.SaveChanges();
        }
        public void UpdateMascara(Mascara dTOMascara)
        {
            Mascara mascara = null;
            mascara = (model.Materials.Where(x => x.Id == dTOMascara.Id) as Mascara);//??????? 342
            model.Materials.Attach(mascara);
            model.SaveChanges();
        }
        public void UpdateLipstick(Lipstick dTOLipstick)
        {
            Lipstick lipstick = null;
            lipstick = (model.Materials.Where(x => x.Id == dTOLipstick.Id).First() as Lipstick);
            model.Materials.Attach(lipstick);
            model.SaveChanges();
        }
        public void UpdateShadow(Shadows dTOShadows)
        {
            Shadows shadows = null;
            shadows = (model.Materials.Where(x => x.Id == dTOShadows.Id).First() as Shadows);
            model.Materials.Attach(shadows);
            model.SaveChanges();
        }
        public void UpdateFoundation(Foundation dTOFoundation)
        {
            Foundation foundation = null;
            foundation = (model.Materials.Where(x => x.Id == dTOFoundation.Id).First() as Foundation);
            model.Materials.Attach(foundation);
            model.SaveChanges();
        }
        public void UpdatePowder(Powder dTOPowder)
        {
            Powder powder = null;
            powder = (model.Materials.Where(x => x.Id == dTOPowder.Id).First() as Powder);
            model.Materials.Attach(powder);
            model.SaveChanges();
        }
        public void UpdateTop(NailTop dTONailTop)
        {
            NailTop nailTop = null;
            nailTop = (model.Materials.Where(x => x.Id == dTONailTop.Id).First() as NailTop);
            model.Materials.Attach(nailTop);
            model.SaveChanges();
        }
        public void UpdateBase(NailBase dTONailBase)
        {
            NailBase nailBase = null;
            nailBase = (model.Materials.Where(x => x.Id == dTONailBase.Id).First() as NailBase);
            model.Materials.Attach(nailBase);
            model.SaveChanges();
        }
        public void UpdatePolish(NailPolish dTOPolish)
        {
            NailPolish nailPolish = null;
            nailPolish = (model.Materials.Where(x => x.Id == dTOPolish.Id).First() as NailPolish);
            model.Materials.Attach(nailPolish);
            model.SaveChanges();
        }
    }
}
