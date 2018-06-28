using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
  public  class AddFunctionDal:IDalAdd
    {
        ModelBeauty model = new ModelBeauty();
        public void AddUser(Staff dTODallStaff)
        {
                dTODallStaff.WorkPosition = model.WorkPositions.First(x=>x.Name== dTODallStaff.WorkPosition.Name);

            Logger.WriteLog(
               new Info
               {
                   Action = "New user has been added",
                   ActionTime = DateTime.Now,
                   InputParameters = $"Login - {dTODallStaff.Login}",
                   OutputParameters = dTODallStaff == null ? "The adding of new user has been failed" : 
                   $"User with login { dTODallStaff.ToString()} has been added "
               }
               );

            model.Staffs.Add(dTODallStaff);
                model.SaveChanges();
        }
        public List<string> WritingOff (List<WriteOffMaterial> writeOffMaterials)
        {
            List<string> newlist = new List<string>();
            Material material=null;
            foreach ( var item in writeOffMaterials)
            {
                material= model.Materials.First(x => x.Id == item.Material.Id);
                    if (material.QuantityGeneralVolume <((double)item.UsedQuantity * material.QuntityCount))
                    {
                        newlist.Add(material.Name+" "+material.Brand+" "+ material.Color);
                    }
            }
           if(newlist.Count==0)
            {
                foreach(var item in writeOffMaterials)
                {
                     material = model.Materials.First(x => x.Id == item.Material.Id);
                    item.Material = material;
                    material.QuantityGeneralVolume -= item.UsedQuantity * material.QuntityCount;
                    material.QuantityBottles = (int)(material.QuantityGeneralVolume / material.Volume);
                }
                model.WriteOffMaterials.AddRange(writeOffMaterials);
                model.SaveChanges();
            }
            Logger.WriteLog(
      new Info
      {
          Action = "Material has been written off",
          ActionTime = DateTime.Now,
          InputParameters = material.ToString(),
          OutputParameters = $"The { material.ToString()}  has been written off "
      }
      );
            return newlist;
        }
        public void AddMaterialToDB(Material material)
        {
            Logger.WriteLog(
               new Info
               {
                   Action = "Material has been added",
                   ActionTime = DateTime.Now,
                   InputParameters= "Name "+ material.Name,
                   OutputParameters = material == null ? "The adding of new material has been failed" : 
                   $"The { material.ToString()} has been added "
               }
               );

         //   shampoos.Service=model.Materials.First(x => (x is Shampoo)).Service;
                model.Materials.Add(material);
                model.SaveChanges();
        }
        //public void AddBalsamToDB(Balsam balsam)
        //{
        //    Logger.WriteLog(
        //       new Info
        //       {
        //           Action = "Material has been added",
        //           ActionTime = DateTime.Now,
        //           InputParameters = "Name "+ balsam.Name,
        //           OutputParameters = balsam == null ? "The adding of new material has been failed" :
        //           $"The { balsam.ToString()} has been added "
        //       }
        //       );
        //    balsam.Service = model.Materials.First(x => (x is Balsam)).Service;
        //        model.Materials.Add(balsam);
        //        model.SaveChanges();
        //}
        //public void AddColorToDB(HairColor Color)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name " +Color.Name,
        //         OutputParameters = Color == null ? "The adding of new material has been failed" :
        //         $"The { Color.ToString()} has been added "
        //     }
        //     );
        //    Color.Service = model.Materials.First(x => (x is HairColor)).Service;
        //        model.Materials.Add(Color);
        //        model.SaveChanges();
        //}
        //public void AddLaqueToDB(Laque Laque)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name "+ Laque.Name,
        //         OutputParameters = Laque == null ? "The adding of new material has been failed" :
        //         $"The { Laque.ToString()} has been added "
        //     }
        //     );
        //   // Laque.Service = model.Materials.First(x => (x is Laque)).Service;
        //        model.Materials.Add(Laque);
        //        model.SaveChanges();
        //}
        //public void AddLipstickToDB(Lipstick Lipstick)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name "+ Lipstick.Name,
        //         OutputParameters = Lipstick == null ? "The adding of new material has been failed" :
        //         $"The { Lipstick.ToString()} has been added "
        //     }
        //     );
        //    Lipstick.Service = model.Materials.First(x => (x is Lipstick)).Service;
        //        model.Materials.Add(Lipstick);
        //        model.SaveChanges();
        //}
        //public void AddMascaraToDB(Mascara Mascara)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name "+ Mascara.Name,
        //         OutputParameters = Mascara == null ? "The adding of new material has been failed" :
        //         $"The { Mascara.ToString()} has been added "
        //     }
        //     );
        //    Mascara.Service = model.Materials.First(x => (x is Mascara)).Service;
        //        model.Materials.Add(Mascara);
        //        model.SaveChanges();        
        //}
        //public void AddShadowToDB(Shadows Shadows)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name " +Shadows.Name,
        //         OutputParameters = Shadows == null ? "The adding of new material has been failed" :
        //         $"The { Shadows.ToString()} has been added "
        //     }
        //     );
        //    Shadows.Service = model.Materials.First(x => (x is Shadows)).Service;
        //        model.Materials.Add(Shadows);
        //        model.SaveChanges();
        //}
        //public void AddFoundationToDB(Foundation Foundation)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name "+Foundation.Name,
        //         OutputParameters = Foundation == null ? "The adding of new material has been failed" :
        //         $"The { Foundation.ToString()} has been added "
        //     }
        //     );
        //    Foundation.Service = model.Materials.First(x => (x is Foundation)).Service;
        //        model.Materials.Add(Foundation);
        //        model.SaveChanges();
        //}
        //public void AddPowderToDB(Powder Powder)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name "+Powder.Name,
        //         OutputParameters = Powder == null ? "The adding of new material has been failed" :
        //         $"The { Powder.ToString()} has been added "
        //     }
        //     );
        //    Powder.Service = model.Materials.First(x => (x is Foundation)).Service;
        //        model.Materials.Add(Powder);
        //        model.SaveChanges();
        //}
        //public void AddPolishToDB(NailPolish Polish)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name "+Polish.Name,
        //         OutputParameters = Polish == null ? "The adding of new material has been failed" :
        //         $"The { Polish.ToString()} has been added "
        //     }
        //     );
        //    Polish.Service = model.Materials.First(x => (x is NailPolish)).Service;
        //        model.Materials.Add(Polish);
        //        model.SaveChanges();
        //}
        //public void AddTopToDB(NailTop NailTop)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name "+NailTop.Name,
        //         OutputParameters = NailTop == null ? "The adding of new material has been failed" :
        //         $"The { NailTop.ToString()} has been added "
        //     }
        //     );
        //    NailTop.Service = model.Materials.First(x => (x is NailTop)).Service;
        //        model.Materials.Add(NailTop);
        //        model.SaveChanges();
        //}
        //public void AddBaseToDB(NailBase NailBase)
        //{
        //    Logger.WriteLog(
        //     new Info
        //     {
        //         Action = "Material has been added",
        //         ActionTime = DateTime.Now,
        //         InputParameters = "Name " +NailBase.Name,
        //         OutputParameters = NailBase == null ? "The adding of new material has been failed" :
        //         $"The { NailBase.ToString()} has been added "
        //     }
        //     );
        //    NailBase.Service = model.Materials.First(x => (x is NailBase)).Service;
        //        model.Materials.Add(NailBase);
        //        model.SaveChanges();
        //}
    }
}
