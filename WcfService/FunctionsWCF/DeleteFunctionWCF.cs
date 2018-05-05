using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
namespace WcfService
{
    public class DeleteFunctionWCF
    {
        DeleteFunctions function = new DeleteFunctions();
        public void DeleteEmployee(int id)
        {
            function.DeleteEmployee(id);
        }
        public void DeleteProduct(int id)
        {
            function.DeleteProduct(id);
        }
    }
}