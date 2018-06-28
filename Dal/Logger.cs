using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dal
{
   
    public  class Logger
    {
        public static void WriteLog(Info stringToLog)
        {
            ModelBeauty model = new ModelBeauty();
            model.Infos.Add(stringToLog);
            model.SaveChanges();
        }
    }
}
