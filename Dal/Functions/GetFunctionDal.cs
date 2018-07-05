using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class GetFunctionDal:IDalGet 
    {
        DbContext model;
        public GetFunctionDal(DbContext context)
        {
            model = context;

        }
        public void GetChangedQuantity(int QuantityBottles, double QuantityGeneralVolume, int id)
        {

            Material materialNew = model.Set<Material>().First(x => x.Id == id);
            materialNew.QuantityGeneralVolume = QuantityGeneralVolume;
            materialNew.QuantityBottles = QuantityBottles;
            Logger.WriteLog(
           new Info
           {
               Action = "Material has been bought",
               ActionTime = DateTime.Now,
               InputParameters = "Quantity  "+ QuantityBottles.ToString(),
               OutputParameters = $"The { materialNew.ToString()}  has been bought "
           }
           );
            model.SaveChanges();
        }
        public List<Service> getServices()
        {
            return model.Set<Service>().ToList();
        }
        public List<Staff> GetStaff()
        {
            List<Staff> Staffs = new List<Staff>();
            Staffs = model.Set<Staff>().ToList();
            return Staffs;
        }
        public List<Material> GetMaterial()
        {
            
            return model.Set<Material>().ToList();
        }
       
        /// <summary>
        /// The method gets users from the Entity by login and pass
        /// </summary>
        /// <param name="login"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public Staff GetUser(string login, string passWord)
        {
            Staff staff = null;
            staff = model.Set<Staff>().Where(x => x.Login == login && x.Password == passWord).FirstOrDefault();
            Logger.WriteLog(new Info
            {
                Login = login ,
                Action = "Trying to enter into the system",
                ActionTime = DateTime.Now,
                InputParameters = $"Login - {login}",
                OutputParameters = staff == null ? "Non authentificated user was trying to get the access" : 
                $"User with login { staff.ToString()} has entered "
            });

            return staff;
        }

        public ICollection<Info> GetLoggs()
        {
            return model.Set<Info>().ToList();
        }
        /// <summary>
        /// The method gets the list of work positions from Entity
        /// </summary>
        /// <returns></returns>
        public ICollection<WorkPosition> GetWorkPosition()
        {
            ICollection<WorkPosition> works = null;
            works = model.Set<WorkPosition>().ToList();
            return works;
        }

        public WorkPosition GetOneWorkPosition(int Id)
        {
            WorkPosition workPosition = null;
            Staff staff = model.Set<Staff>().Where(x => x.Id == Id).First();
            workPosition = staff.WorkPosition;
            return workPosition;
        }


    }
}
