using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
 public   class UpdateFunctionDal: IDalUpdate  
    {
        DbContext model;
        public UpdateFunctionDal(DbContext context)
        {
            model = context;
        }

        public void UpdateMaterial(Material material)
        {
            Material materialEnt = null;
            materialEnt = model.Set<Material>().First(x => x.Id == material.Id);
            model.Set<Material>().Attach(materialEnt);
            materialEnt.Brand = material.Brand;
            materialEnt.Name = material.Name;
            materialEnt.Price = material.Price;
            materialEnt.QuantityBottles = material.QuantityBottles;
            materialEnt.QuantityGeneralVolume = material.QuantityGeneralVolume;
            materialEnt.Volume = material.Volume;
            materialEnt.Description = material.Description;
            materialEnt.Color = material.Color;
            model.SaveChanges();
        }
       
    }
}
