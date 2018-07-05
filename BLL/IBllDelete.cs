using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public interface IBllDelete
    {
        void DeleteEmployee(int id);
        void DeleteProduct(int id);
    }
}
