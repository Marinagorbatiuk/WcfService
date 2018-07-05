using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
  public  class AddFunctionDal:IDalAdd
    {
        DbContext model;
        public AddFunctionDal(DbContext context)
        {
            model = context;
        }
        public void AddUser(Staff dTODallStaff)
        {
         
                dTODallStaff.WorkPosition = model.Set<WorkPosition>().First(x=>x.Name== dTODallStaff.WorkPosition.Name);
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
           model.Set<Staff>().Add(dTODallStaff);
                model.SaveChanges();
        
        }
        public List<string> WritingOff (List<WriteOffMaterial> writeOffMaterials)
        {
            List<string> newlist = new List<string>();
            Material material=null;
            foreach ( var item in writeOffMaterials)
            {
                material= model.Set<Material>().First(x => x.Id == item.Material.Id);
                    if (material.QuantityGeneralVolume <((double)item.UsedQuantity * material.QuntityCount))
                    {
                        newlist.Add(material.Name+" "+material.Brand+" "+ material.Color);
                    }
            }
           if(newlist.Count==0)
            {
                foreach(var item in writeOffMaterials)
                {
                     material = model.Set<Material>().First(x => x.Id == item.Material.Id);
                    item.Material = material;
                    material.QuantityGeneralVolume -= item.UsedQuantity * material.QuntityCount;
                    material.QuantityBottles = (int)(material.QuantityGeneralVolume / material.Volume);
                }
                model.Set<WriteOffMaterial>().AddRange(writeOffMaterials);
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
                   InputParameters = "Name " + material.Name,
                   OutputParameters = material == null ? "The adding of new material has been failed" :
                   $"The { material.ToString()} has been added "
               }
               );
            if(material is Shampoo)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "HairCut" || x.Name == "HairColoring").ToList();
            }
            else if (material is Balsam)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "HairCut" || x.Name == "HairColoring").ToList();
            }
            else if (material is Laque)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "HairCut" || x.Name == "HairColoring").ToList();
            }
            else if (material is HairColor)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "HairColoring").ToList();
            }
            else if (material is Foundation)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "MakeUp").ToList();
            }
            else if (material is Powder)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "MakeUp").ToList();
            }
            else if (material is Mascara)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "MakeUp").ToList();
            }
            else if (material is Shadows)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "MakeUp").ToList();
            }
            else if (material is Lipstick)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "MakeUp").ToList();
            }
            else if (material is NailTop)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "Manicure").ToList();
            }
            else if (material is NailPolish)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "Manicure").ToList();
            }
            else if (material is NailBase)
            {
                material.Service = (model as ModelBeauty).Services.Where(x => x.Name == "Manicure").ToList();
            }
            (model as ModelBeauty).Materials.Add(material);
                model.SaveChanges();
        }
   
    }
}
