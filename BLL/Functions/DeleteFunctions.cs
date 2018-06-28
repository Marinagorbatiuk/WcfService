using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace BLL
{
 public   class DeleteFunctions:IBllDelete
    {
        DeleteFunctionDal function = new DeleteFunctionDal();
        public void DeleteEmployee(int id)
        {
            function.DeleteUser(id);
        }
        public void DeleteProduct(int id)
        {
            function.Delete(id);
        }
    }
}
