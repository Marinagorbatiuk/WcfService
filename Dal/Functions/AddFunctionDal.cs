using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
  public  class AddFunctionDal
    {
        ModelBeauty model = new ModelBeauty();
        public void AddUser(Staff dTODallStaff)
        {
                dTODallStaff.WorkPosition = model.WorkPositions.Single(x=>x.Id== dTODallStaff.WorkPosition.Id);
                model.Staffs.Add(dTODallStaff);
                model.SaveChanges();
        }
        public void AddShampooToDB(Shampoo shampoos)
        {
                shampoos.Service=model.Materials.Single(x => (x is Shampoo)).Service;
                model.Materials.Add(shampoos);
                model.SaveChanges();
        }
        public void AddBalsamToDB(Balsam balsam)
        {
                balsam.Service = model.Materials.Single(x => (x is Balsam)).Service;
                model.Materials.Add(balsam);
                model.SaveChanges();
        }
        public void AddColorToDB(HairColor Color)
        {
               Color.Service = model.Materials.Single(x => (x is HairColor)).Service;
                model.Materials.Add(Color);
                model.SaveChanges();
        }
        public void AddLaqueToDB(Laque Laque)
        {
            Laque.Service = model.Materials.Single(x => (x is Laque)).Service;
                model.Materials.Add(Laque);
                model.SaveChanges();
        }
        public void AddLipstickToDB(Lipstick Lipstick)
        {
            Lipstick.Service = model.Materials.Single(x => (x is Lipstick)).Service;
                model.Materials.Add(Lipstick);
                model.SaveChanges();
        }
        public void AddMascaraToDB(Mascara Mascara)
        {
            Mascara.Service = model.Materials.Single(x => (x is Mascara)).Service;
                model.Materials.Add(Mascara);
                model.SaveChanges();        
        }
        public void AddShadowToDB(Shadows Shadows)
        {
            Shadows.Service = model.Materials.Single(x => (x is Shadows)).Service;
                model.Materials.Add(Shadows);
                model.SaveChanges();
        }
        public void AddFoundationToDB(Foundation Foundation)
        {
            Foundation.Service = model.Materials.Single(x => (x is Foundation)).Service;
                model.Materials.Add(Foundation);
                model.SaveChanges();
        }
        public void AddPowderToDB(Powder Powder)
        {
            Powder.Service = model.Materials.Single(x => (x is Foundation)).Service;
                model.Materials.Add(Powder);
                model.SaveChanges();
        }
        public void AddPolishToDB(NailPolish Polish)
        {
            Polish.Service = model.Materials.Single(x => (x is NailPolish)).Service;
                model.Materials.Add(Polish);
                model.SaveChanges();
        }
        public void AddTopToDB(NailTop NailTop)
        {
            NailTop.Service = model.Materials.Single(x => (x is NailTop)).Service;
                model.Materials.Add(NailTop);
                model.SaveChanges();
        }
        public void AddBaseToDB(NailBase NailBase)
        {
            NailBase.Service = model.Materials.Single(x => (x is NailBase)).Service;
                model.Materials.Add(NailBase);
                model.SaveChanges();
        }
    }
}
