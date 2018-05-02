using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
 public   class DeleteFunctionDal
    {
        ModelBeauty model = new ModelBeauty();
        public void Delete(int id)
        {
                model.Materials.Remove(model.Materials.Where(x => x.Id == id).First());
                model.SaveChanges();
        }

        public void DeleteUser(int id)
        {
                model.Staffs.Remove(model.Staffs.Where(x => x.Id == id).First());
                model.SaveChanges();
        }
    }
}
