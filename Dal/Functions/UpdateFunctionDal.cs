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
            Shampoo shampooEnt = null;
            shampooEnt = (model.Materials.Where(x => x.Id == shampoo.Id).First() as Shampoo);
            model.Materials.Attach(shampooEnt);
            shampooEnt.Brand = shampoo.Brand;
            shampooEnt.Name = shampoo.Name;
            shampooEnt.Price = shampoo.Price;
            shampooEnt.QuantityBottles = shampoo.QuantityBottles;
            shampoo.QuantityGeneralVolume= shampoo.QuantityGeneralVolume;
            shampooEnt.Volume = shampoo.Volume;
            shampooEnt.Description = shampoo.Description;
            shampoo.Color = shampoo.Color;
            model.SaveChanges();
        }

        public void UpdateBalsam(Balsam dTOBalsam)
        {
            Balsam balsam = null;
            balsam = (model.Materials.Where(x => x.Id == dTOBalsam.Id).First() as Balsam);
            model.Materials.Attach(balsam);
            balsam.Brand = dTOBalsam.Brand;
            balsam.Name = dTOBalsam.Name;
            balsam.Price = dTOBalsam.Price;
            balsam.QuantityBottles = dTOBalsam.QuantityBottles;
            balsam.QuantityGeneralVolume = dTOBalsam.QuantityGeneralVolume;
            balsam.Volume = dTOBalsam.Volume;
            balsam.Description = dTOBalsam.Description;
            balsam.Color = dTOBalsam.Color;
            model.SaveChanges();
        }
        public void UpdateColor(HairColor dTOColor)
        {
            HairColor hairColor = null;
            hairColor = (model.Materials.Where(x => x.Id == dTOColor.Id).First() as HairColor);
            model.Materials.Attach(hairColor);
            hairColor.Brand = dTOColor.Brand;
            hairColor.Name = dTOColor.Name;
           hairColor.Price = dTOColor.Price;
           hairColor.QuantityBottles = dTOColor.QuantityBottles;
           hairColor.QuantityGeneralVolume = dTOColor.QuantityGeneralVolume;
           hairColor.Volume = dTOColor.Volume;
           hairColor.Description = dTOColor.Description;
            hairColor.Color = dTOColor.Color;
            model.SaveChanges();
        }
        public void UpdateLaque(Laque dTOLaque)
        {
            Laque laque = null;
            laque = (model.Materials.Where(x => x.Id == dTOLaque.Id).First() as Laque);
            model.Materials.Attach(laque);
           laque.Brand = dTOLaque.Brand;
           laque.Name = dTOLaque.Name;
           laque.Price = dTOLaque.Price;
           laque.QuantityBottles = dTOLaque.QuantityBottles;
           laque.QuantityGeneralVolume = dTOLaque.QuantityGeneralVolume;
           laque.Volume = dTOLaque.Volume;
           laque.Description = dTOLaque.Description;
            laque.Color = dTOLaque.Color;
            model.SaveChanges();
        }
        public void UpdateMascara(Mascara dTOMascara)
        {
            Mascara mascara = null;
            mascara = (model.Materials.Where(x => x.Id == dTOMascara.Id) as Mascara);//??????? 342
            model.Materials.Attach(mascara);
            mascara.Brand = dTOMascara.Brand;
            mascara.Name = dTOMascara.Name;
            mascara.Price = dTOMascara.Price;
            mascara.QuantityBottles = dTOMascara.QuantityBottles;
            mascara.QuantityGeneralVolume = dTOMascara.QuantityGeneralVolume;
            mascara.Volume = dTOMascara.Volume;
            mascara.Description = dTOMascara.Description;
            mascara.Color = dTOMascara.Color;
            model.SaveChanges();
        }
        public void UpdateLipstick(Lipstick dTOLipstick)
        {
            Lipstick lipstick = null;
            lipstick = (model.Materials.Where(x => x.Id == dTOLipstick.Id).First() as Lipstick);
            model.Materials.Attach(lipstick);
            lipstick.Brand = dTOLipstick.Brand;
            lipstick.Name = dTOLipstick.Name;
            lipstick.Price = dTOLipstick.Price;
            lipstick.QuantityBottles = dTOLipstick.QuantityBottles;
            lipstick.QuantityGeneralVolume = dTOLipstick.QuantityGeneralVolume;
            lipstick.Volume = dTOLipstick.Volume;
            lipstick.Description = dTOLipstick.Description;
            lipstick.Color = dTOLipstick.Color;
            model.SaveChanges();
        }
        public void UpdateShadow(Shadows dTOShadows)
        {
            Shadows shadows = null;
            shadows = (model.Materials.Where(x => x.Id == dTOShadows.Id).First() as Shadows);
            model.Materials.Attach(shadows);
           shadows.Brand = dTOShadows.Brand;
           shadows.Name = dTOShadows.Name;
           shadows.Price = dTOShadows.Price;
           shadows.QuantityBottles = dTOShadows.QuantityBottles;
           shadows.QuantityGeneralVolume = dTOShadows.QuantityGeneralVolume;
           shadows.Volume = dTOShadows.Volume;
           shadows.Description = dTOShadows.Description;
            shadows.Color = dTOShadows.Color;
            model.SaveChanges();
        }
        public void UpdateFoundation(Foundation dTOFoundation)
        {
            Foundation foundation = null;
            foundation = (model.Materials.Where(x => x.Id == dTOFoundation.Id).First() as Foundation);
            model.Materials.Attach(foundation);
           foundation.Brand = dTOFoundation.Brand;
           foundation.Name = dTOFoundation.Name;
           foundation.Price = dTOFoundation.Price;
           foundation.QuantityBottles = dTOFoundation.QuantityBottles;
           foundation.QuantityGeneralVolume = dTOFoundation.QuantityGeneralVolume;
           foundation.Volume = dTOFoundation.Volume;
           foundation.Description = dTOFoundation.Description;
            foundation.Color = dTOFoundation.Color;
            model.SaveChanges();
        }
        public void UpdatePowder(Powder dTOPowder)
        {
            Powder powder = null;
            powder = (model.Materials.Where(x => x.Id == dTOPowder.Id).First() as Powder);
            model.Materials.Attach(powder);
            powder.Brand = dTOPowder.Brand;
            powder.Name = dTOPowder.Name;
            powder.Price = dTOPowder.Price;
            powder.QuantityBottles = dTOPowder.QuantityBottles;
            powder.QuantityGeneralVolume = dTOPowder.QuantityGeneralVolume;
            powder.Volume = dTOPowder.Volume;
            powder.Description = dTOPowder.Description;
            powder.Color = dTOPowder.Color;
            model.SaveChanges();
        }
        public void UpdateTop(NailTop dTONailTop)
        {
            NailTop nailTop = null;
            nailTop = (model.Materials.Where(x => x.Id == dTONailTop.Id).First() as NailTop);
            model.Materials.Attach(nailTop);
           nailTop.Brand = dTONailTop.Brand;
           nailTop.Name = dTONailTop.Name;
           nailTop.Price = dTONailTop.Price;
           nailTop.QuantityBottles = dTONailTop.QuantityBottles;
           nailTop.QuantityGeneralVolume = dTONailTop.QuantityGeneralVolume;
           nailTop.Volume = dTONailTop.Volume;
           nailTop.Description = dTONailTop.Description;
            nailTop.Color = dTONailTop.Color;
            model.SaveChanges();
        }
        public void UpdateBase(NailBase dTONailBase)
        {
            NailBase nailBase = null;
            nailBase = (model.Materials.Where(x => x.Id == dTONailBase.Id).First() as NailBase);
            model.Materials.Attach(nailBase);
            nailBase.Brand = dTONailBase.Brand;
            nailBase.Name = dTONailBase.Name;
            nailBase.Price = dTONailBase.Price;
            nailBase.QuantityBottles = dTONailBase.QuantityBottles;
            nailBase.QuantityGeneralVolume = dTONailBase.QuantityGeneralVolume;
            nailBase.Volume = dTONailBase.Volume;
            nailBase.Description = dTONailBase.Description;
            nailBase.Color = dTONailBase.Color;
            model.SaveChanges();
        }
        public void UpdatePolish(NailPolish dTOPolish)
        {
            NailPolish nailPolish = null;
            nailPolish = (model.Materials.Where(x => x.Id == dTOPolish.Id).First() as NailPolish);
            model.Materials.Attach(nailPolish);
            nailPolish.Brand = dTOPolish.Brand;
            nailPolish.Name = dTOPolish.Name;
            nailPolish.Price = dTOPolish.Price;
            nailPolish.QuantityBottles = dTOPolish.QuantityBottles;
            nailPolish.QuantityGeneralVolume = dTOPolish.QuantityGeneralVolume;
            nailPolish.Volume = dTOPolish.Volume;
            nailPolish.Description = dTOPolish.Description;
            nailPolish.Color = dTOPolish.Color;
            model.SaveChanges();
        }
    }
}
