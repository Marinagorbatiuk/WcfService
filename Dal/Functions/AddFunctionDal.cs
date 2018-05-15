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
                dTODallStaff.WorkPosition = model.WorkPositions.First(x=>x.Name== dTODallStaff.WorkPosition.Name);
                model.Staffs.Add(dTODallStaff);
                model.SaveChanges();
        }
        public List<string> WritingOff (List<WriteOffMaterial> writeOffMaterials)
        {
            List<string> newlist = new List<string>();

            foreach( var item in writeOffMaterials)
            {
                Material material = model.Materials.First(x => x.Id == item.Material.Id);
                if(material.QuantityGeneralVolume < item.UsedQuantity*item.Material.QuntityCount)
                {
                    newlist.Add(material.Name);
                }
            }
           if(newlist.Count==0)
            {
                foreach(var item in writeOffMaterials)
                {
                    Material material = model.Materials.First(x => x.Id == item.Material.Id);
                    material.QuantityGeneralVolume -= item.UsedQuantity * item.Material.QuntityCount;
                    material.QuantityBottles = (int)(material.QuantityGeneralVolume / material.Volume);
                }
            }
            return newlist;
        }
        public void AddShampooToDB(Shampoo shampoos)
        {
                shampoos.Service=model.Materials.First(x => (x is Shampoo)).Service;
                model.Materials.Add(shampoos);
                model.SaveChanges();
        }
        public void AddBalsamToDB(Balsam balsam)
        {
                balsam.Service = model.Materials.First(x => (x is Balsam)).Service;
                model.Materials.Add(balsam);
                model.SaveChanges();
        }
        public void AddColorToDB(HairColor Color)
        {
               Color.Service = model.Materials.First(x => (x is HairColor)).Service;
                model.Materials.Add(Color);
                model.SaveChanges();
        }
        public void AddLaqueToDB(Laque Laque)
        {
            Laque.Service = model.Materials.First(x => (x is Laque)).Service;
                model.Materials.Add(Laque);
                model.SaveChanges();
        }
        public void AddLipstickToDB(Lipstick Lipstick)
        {
            Lipstick.Service = model.Materials.First(x => (x is Lipstick)).Service;
                model.Materials.Add(Lipstick);
                model.SaveChanges();
        }
        public void AddMascaraToDB(Mascara Mascara)
        {
            Mascara.Service = model.Materials.First(x => (x is Mascara)).Service;
                model.Materials.Add(Mascara);
                model.SaveChanges();        
        }
        public void AddShadowToDB(Shadows Shadows)
        {
            Shadows.Service = model.Materials.First(x => (x is Shadows)).Service;
                model.Materials.Add(Shadows);
                model.SaveChanges();
        }
        public void AddFoundationToDB(Foundation Foundation)
        {
            Foundation.Service = model.Materials.First(x => (x is Foundation)).Service;
                model.Materials.Add(Foundation);
                model.SaveChanges();
        }
        public void AddPowderToDB(Powder Powder)
        {
            Powder.Service = model.Materials.First(x => (x is Foundation)).Service;
                model.Materials.Add(Powder);
                model.SaveChanges();
        }
        public void AddPolishToDB(NailPolish Polish)
        {
            Polish.Service = model.Materials.First(x => (x is NailPolish)).Service;
                model.Materials.Add(Polish);
                model.SaveChanges();
        }
        public void AddTopToDB(NailTop NailTop)
        {
            NailTop.Service = model.Materials.First(x => (x is NailTop)).Service;
                model.Materials.Add(NailTop);
                model.SaveChanges();
        }
        public void AddBaseToDB(NailBase NailBase)
        {
            NailBase.Service = model.Materials.First(x => (x is NailBase)).Service;
                model.Materials.Add(NailBase);
                model.SaveChanges();
        }
    }
}
