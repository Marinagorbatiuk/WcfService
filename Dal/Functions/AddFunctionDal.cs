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
                model.Staffs.Add(dTODallStaff);
                model.SaveChanges();

        }

        public void AddShampooToDB(Shampoo shampoos)
        {
                model.Materials.Add(shampoos);
                model.SaveChanges();
        }

        public void AddBalsamToDB(Balsam balsam)
        {
                model.Materials.Add(balsam);
                model.SaveChanges();
        }
        public void AddColorToDB(HairColor Color)
        {
                model.Materials.Add(Color);
                model.SaveChanges();
        }
        public void AddLaqueToDB(Laque Laque)
        {
                model.Materials.Add(Laque);
                model.SaveChanges();
        }
        public void AddLipstickToDB(Lipstick Lipstick)
        {
                model.Materials.Add(Lipstick);
                model.SaveChanges();
        }
        public void AddMascaraToDB(Mascara Mascara)
        {
                model.Materials.Add(Mascara);
                model.SaveChanges();        
        }
        public void AddShadowToDB(Shadows Shadows)
        {
                model.Materials.Add(Shadows);
                model.SaveChanges();
        }
        public void AddFoundationToDB(Foundation Foundation)
        {
                model.Materials.Add(Foundation);
                model.SaveChanges();
        }
        public void AddPowderToDB(Powder Powder)
        {
                model.Materials.Add(Powder);
                model.SaveChanges();
        }
        public void AddPolishToDB(NailPolish Polish)
        {
                model.Materials.Add(Polish);
                model.SaveChanges();
        }
        public void AddTopToDB(NailTop NailTop)
        {
                model.Materials.Add(NailTop);
                model.SaveChanges();
        }
        public void AddBaseToDB(NailBase dTONailBase)
        {
                model.Materials.Add(dTONailBase);
                model.SaveChanges();
        }
    }
}
