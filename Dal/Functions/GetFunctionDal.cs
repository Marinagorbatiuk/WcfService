using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class GetFunctionDal:IDalGet 
    {
        ModelBeauty model = new ModelBeauty();
        public void GetChangedQuantity(int QuantityBottles, double QuantityGeneralVolume, int id)
        {

            Material materialNew = model.Materials.First(x => x.Id == id);
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
            return model.Services.ToList();
        }
        public List<Staff> GetStaff()
        {
            List<Staff> Staffs = new List<Staff>();
            Staffs = model.Staffs.ToList();
            return Staffs;
        }
        public List<Material> GetMaterial()
        {
            List<Material> materials = new List<Material>();
            materials = model.Materials.Select(x => (x as Material)).ToList();
            return materials;
        }
        ///// <summary>
        ///// The method gets list of shampoo from Entity
        ///// </summary>
        ///// <returns></returns>
        //public List<Shampoo> GetShampoo()
        //{
        //    List<Shampoo> shampoo = new List<Shampoo>();

        //    shampoo = model.Materials.Where(x => (x is Shampoo)).Select(y => (y as Shampoo)).ToList();
        //    return shampoo;
        //}
        //public List<Balsam> GetBalsam()
        //{
        //    List<Balsam> balsam = new List<Balsam>();

        //    balsam = model.Materials.Where(x => (x is Balsam)).Select(y => (y as Balsam)).ToList();
        //    return balsam;
        //}
        //public List<HairColor> GetColor()
        //{
        //    List<HairColor> color = new List<HairColor>();

        //    color = model.Materials.Where(x => (x is HairColor)).Select(y => (y as HairColor)).ToList();
        //    return color;
        //}
        //public List<Foundation> GetFoundation()
        //{
        //    List<Foundation> foundation = new List<Foundation>();

        //    foundation = model.Materials.Where(x => (x is Foundation)).Select(y => (y as Foundation)).ToList();

        //    return foundation;
        //}
        //public List<Laque> GetLaque()
        //{
        //    List<Laque> laque = new List<Laque>();

        //    laque = model.Materials.Where(x => (x is Laque)).Select(y => (y as Laque)).ToList();
        //    return laque;
        //}
        //public List<Lipstick> GetLipstick()
        //{
        //    List<Lipstick> lipstick = new List<Lipstick>();

        //    lipstick = model.Materials.Where(x => (x is Lipstick)).Select(y => (y as Lipstick)).ToList();
        //    return lipstick;
        //}
        //public List<Mascara> GetMascara()
        //{
        //    List<Mascara> mascara = new List<Mascara>();

        //    mascara = model.Materials.Where(x => (x is Mascara)).Select(y => (y as Mascara)).ToList();
        //    return mascara;
        //}
        //public List<NailBase> GetNailBase()
        //{
        //    List<NailBase> nailBases = new List<NailBase>();

        //    nailBases = model.Materials.Where(x => (x is NailBase)).Select(y => (y as NailBase)).ToList();
        //    return nailBases;
        //}
        //public List<NailPolish> GetNailPolish()
        //{
        //    List<NailPolish> nailPolish = new List<NailPolish>();

        //    nailPolish = model.Materials.Where(x => (x is NailPolish)).Select(y => (y as NailPolish)).ToList();
        //    return nailPolish;
        //}
        //public List<NailTop> GetNailTop()
        //{
        //    List<NailTop> nailTop = new List<NailTop>();

        //    nailTop = model.Materials.Where(x => (x is NailTop)).Select(y => (y as NailTop)).ToList();
        //    return nailTop;
        //}
        //public List<Powder> GetPowder()
        //{
        //    List<Powder> powder = new List<Powder>();

        //    powder = model.Materials.Where(x => (x is Powder)).Select(y => (y as Powder)).ToList();
        //    return powder;
        //}
        //public List<Shadows> GetShadow( )
        //{
        //    List<Shadows> shadows = new List<Shadows>();

        //    shadows = model.Materials.Where(x => (x is Shadows)).Select(y => (y as Shadows)).ToList();
        //    return shadows;
        //}

        /// <summary>
        /// The method gets users from the Entity by login and pass
        /// </summary>
        /// <param name="login"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public Staff GetUser(string login, string passWord)
        {
            Staff staff = null;
            staff = model.Staffs.Where(x => x.Login == login && x.Password == passWord).FirstOrDefault();
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
            return model.Infos.ToList();
        }
        /// <summary>
        /// The method gets the list of work positions from Entity
        /// </summary>
        /// <returns></returns>
        public ICollection<WorkPosition> GetWorkPosition()
        {
            ICollection<WorkPosition> works = null;
            works = model.WorkPositions.ToList();
            return works;
        }

        public WorkPosition GetOneWorkPosition(int Id)
        {
            WorkPosition workPosition = null;
            Staff staff = model.Staffs.Where(x => x.Id == Id).First();
            workPosition = staff.WorkPosition;
            return workPosition;
        }


    }
}
