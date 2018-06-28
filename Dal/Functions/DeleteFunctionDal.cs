using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
 public   class DeleteFunctionDal:IDalDelete 
    {
        ModelBeauty model = new ModelBeauty();
        public void Delete(int id)
        {
            Logger.WriteLog(
                new Info
                {
                    Action = "Material has been deleted",
                    ActionTime = DateTime.Now,
                    InputParameters = model.Materials.First(x => x.Id == id).Name,
                    OutputParameters =  $"The { model.Materials.First(x => x.Id == id).Name} has been deleted "

                }
                );
                model.Materials.Remove(model.Materials.Where(x => x.Id == id).First());
                model.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            Logger.WriteLog(
                new Info
                {
                    Action = "User has been deleted",
                    ActionTime = DateTime.Now,
                    InputParameters = "Login - "+model.Staffs.First(x => x.Id == id).Login,
                    OutputParameters = $"The user with login {model.Staffs.First(x => x.Id == id).Login} has been deleted "

                }
                );
            model.Staffs.Remove(model.Staffs.Where(x => x.Id == id).First());
                model.SaveChanges();
        }
    }
}
