using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
 public   class DeleteFunctionDal:IDalDelete 
    {
        DbContext model;
        public DeleteFunctionDal(DbContext context)
        {
            model = context;
        }
        public void Delete(int id)
        {
            Logger.WriteLog(
                new Info
                {
                    Action = "Material has been deleted",
                    ActionTime = DateTime.Now,
                    InputParameters = model.Set<Material>().First(x => x.Id == id).Name,
                    OutputParameters =  $"The { model.Set<Material>().First(x => x.Id == id).Name} has been deleted "

                }
                );
                model.Set<Material>().Remove(model.Set<Material>().Where(x => x.Id == id).First());
                model.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            Logger.WriteLog(
                new Info
                {
                    Action = "User has been deleted",
                    ActionTime = DateTime.Now,
                    InputParameters = "Login - "+model.Set<Staff>().First(x => x.Id == id).Login,
                    OutputParameters = $"The user with login {model.Set<Staff>().First(x => x.Id == id).Login} has been deleted "

                }
                );
            model.Set<Staff>().Remove(model.Set<Staff>().Where(x => x.Id == id).First());
                model.SaveChanges();
        }
    }
}
