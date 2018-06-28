using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    interface IDalDelete
    {
        void Delete(int id);
        void DeleteUser(int id);
    }
}
