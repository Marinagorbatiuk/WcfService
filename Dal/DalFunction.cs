using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dal
{
    public class DalFunction
    {
       // ModelBeauty model = new ModelBeauty();

            /// <summary>
            /// The method gets users from the Entity by login and pass
            /// </summary>
            /// <param name="login"></param>
            /// <param name="passWord"></param>
            /// <returns></returns>
        public Staff GetUser(string login, string passWord)
        {
            Staff staff = null;
           
            using (ModelBeauty model = new ModelBeauty())
            {
                staff = model.Staffs.Where(x => x.Login == login && x.Password == passWord).FirstOrDefault();
            }
      
            return staff;
        }
        /// <summary>
        /// The method gets the list of work positions from Entity
        /// </summary>
        /// <returns></returns>
        public ICollection<WorkPosition> GetWorkPosition ()
        {
            ICollection<WorkPosition> works = null;
            using (ModelBeauty model = new ModelBeauty())
            {
                works = model.WorkPositions.ToList();
            }
                return works;

        }
        /// <summary>
        /// ??????????????????????????????????????????????
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public WorkPosition GetOneWorkPosition(int Id)
        {
            WorkPosition workPosition = null;

            using (ModelBeauty model = new ModelBeauty())
            {
                Staff staff = model.Staffs.Where(x => x.Id == Id).First();
              
                workPosition = staff.WorkPosition;
            }
                return workPosition;
        }
        /// <summary>
        /// The method gets list of shampoo from Entity
        /// </summary>
        /// <returns></returns>
        public List<Shampoo> GetShampoo()
        {
            List<Shampoo> shampoo = new List<Shampoo>();
            using (ModelBeauty model = new ModelBeauty())
            {
                shampoo = model.Materials.Where(x => (x is Shampoo)).Select(y => (y as Shampoo)).ToList();
               // shampoo = tmpshampo.Select(x=> x).ToList();
            }

                return shampoo;
        }
        public List<Balsam> GetBalsam()
        {
            List<Balsam> balsam = new List<Balsam>();
            using (ModelBeauty model = new ModelBeauty())
            {
           balsam = model.Materials.Where(x => (x is Balsam)).Select(y => (y as Balsam)).ToList();
               
            }

            return balsam;
        }
        public List<HairColor> GetColor()
        {
            List<HairColor> color = new List<HairColor>();
            using (ModelBeauty model = new ModelBeauty())
            {
                color = model.Materials.Where(x => (x is HairColor)).Select(y => (y as HairColor)).ToList();
            }

            return color;
        }
        public List<Foundation> GetFoundation()
        {
            List<Foundation> foundation = new List<Foundation>();
            using (ModelBeauty model = new ModelBeauty())
            {
              foundation= model.Materials.Where(x => (x is Foundation)).Select(y => (y as Foundation)).ToList();
            }

            return foundation;
        }
        public List<Laque> GetLaque()
        {
            List<Laque> laque = new List<Laque>();
            using (ModelBeauty model = new ModelBeauty())
            {
                laque= model.Materials.Where(x => (x is Laque)).Select(y => (y as Laque)).ToList();
            }

            return laque;
        }
        public List<Lipstick> GetLipstick()
        {
            List<Lipstick> lipstick = new List<Lipstick>();
            using (ModelBeauty model = new ModelBeauty())
            {
               lipstick = model.Materials.Where(x => (x is Lipstick)).Select(y => (y as Lipstick)).ToList();
            }

            return lipstick;
        }
        public List<Mascara> GetMascara()
        {
            List<Mascara> mascara = new List<Mascara>();
            using (ModelBeauty model = new ModelBeauty())
            {
                mascara = model.Materials.Where(x => (x is Mascara)).Select(y => (y as Mascara)).ToList();
            }

            return mascara;
        }
        public List<NailBase> GetNailBase()
        {
            List<NailBase> nailBases = new List<NailBase>();
            using (ModelBeauty model = new ModelBeauty())
            {
                nailBases = model.Materials.Where(x => (x is NailBase)).Select(y => (y as NailBase)).ToList();
            }

            return nailBases;
        }
        public List<NailPolish> GetNailPolish()
        {
            List<NailPolish> nailPolish = new List<NailPolish>();
            using (ModelBeauty model = new ModelBeauty())
            {
                nailPolish = model.Materials.Where(x => (x is NailPolish)).Select(y => (y as NailPolish)).ToList();
            }

            return nailPolish;
        }
        public List<NailTop> GetNailTop()
        {
            List<NailTop> nailTop = new List<NailTop>();
            using (ModelBeauty model = new ModelBeauty())
            {
                nailTop = model.Materials.Where(x => (x is NailTop)).Select(y => (y as NailTop)).ToList();
            }

            return nailTop;
        }
        public List<Powder> GetPowder()
        {
            List<Powder> powder = new List<Powder>();
            using (ModelBeauty model = new ModelBeauty())
            {
                powder = model.Materials.Where(x => (x is Powder)).Select(y => (y as Powder)).ToList();
            }

            return powder;
        }
        public List<Shadows> GetShadow()
        {
            List<Shadows> shadows = new List<Shadows>();
            using (ModelBeauty model = new ModelBeauty())
            {
                shadows = model.Materials.Where(x => (x is Shadows)).Select(y => (y as Shadows)).ToList();
            }

            return shadows;
        }
        public void Delete(int id)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Remove(model.Materials.Where(x => x.Id == id).First());
                model.SaveChanges();
            }
        }
        public List <Staff> GetStaff()
        {
            List<Staff> Staffs = new List<Staff>();
            using (ModelBeauty model = new ModelBeauty())
            {
                Staffs = model.Staffs.Where(x => x.WorkPosition.Name == "Employee").ToList();
            }
                return Staffs;
        }
        public void  DeleteUser(int id)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Staffs.Remove(model.Staffs.Where(x => x.Id == id).First());
                model.SaveChanges();
            }
        }

        public void AddUser(Staff dTODallStaff)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Staffs.Add(dTODallStaff);
                model.SaveChanges();
            }
        }

        public void AddShampooToDB(Shampoo shampoos)
        {
        //    Shampoo shampoos = new Shampoo();
            using (ModelBeauty model = new ModelBeauty())
            {
                //shampoos = model.Materials.Add(model.Materials.Where(x=>(x is Shampoo)).Select(y=>(y as Shampoo)).First());
                //shampoos= model.Materials.Add(model.Materials.Where(x => (x is Shampoo)).First());
                model.Materials.Add(shampoos);
                
                model.SaveChanges();
               
            }
          // return shampoos;
        }

        public void AddBalsamToDB (Balsam balsam)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(balsam);
                model.SaveChanges();
            }
        }
        public void AddColorToDB (HairColor Color)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(Color);
                model.SaveChanges();
            }
        }
        public void AddLaqueToDB (Laque Laque)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(Laque);
                model.SaveChanges();
            }
        }
        public void AddLipstickToDB(Lipstick Lipstick)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(Lipstick);
                model.SaveChanges();
            }
        }
        public void AddMascaraToDB(Mascara Mascara)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(Mascara);
                model.SaveChanges();
            }
        }
        public void AddShadowToDB( Shadows Shadows )
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(Shadows);
                model.SaveChanges();
            }
        }
        public void AddFoundationToDB(Foundation Foundation)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(Foundation);
                model.SaveChanges();
            }
        }
        public void AddPowderToDB(Powder Powder)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(Powder);
                model.SaveChanges();
            }
        }
        public void AddPolishToDB(NailPolish Polish)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(Polish);
                model.SaveChanges();
            }
        }
        public void AddTopToDB(NailTop NailTop)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(NailTop);
                model.SaveChanges();
            }
        }
        public void AddBaseToDB(NailBase dTONailBase)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(dTONailBase);
                model.SaveChanges();
            }
        }
        ModelBeauty model = new ModelBeauty();
        public void UpdateShampoo(Shampoo shampoo)
        {
            Shampoo sh = null;
           // ModelBeauty model = new ModelBeauty();
           sh= (model.Materials.Where(x => x.Id == shampoo.Id).First() as Shampoo);

            model.Materials.Attach(sh);
           // sh = DALConvertation.ConvertShampooToEntity(shampoo);//???????????
            model.SaveChanges();
        }

        public void UpdateBalsam (Balsam dTOBalsam)
        {
            Balsam balsam = null;
            balsam = (model.Materials.Where(x => x.Id == dTOBalsam.Id).First() as Balsam);
            model.Materials.Attach(balsam);
            model.SaveChanges();
        }
        public void UpdateColor (HairColor dTOColor)
        {
            HairColor hairColor = null;
            hairColor = (model.Materials.Where(x => x.Id == dTOColor.Id).First() as HairColor);
            model.Materials.Attach(hairColor);
            model.SaveChanges();
        }
        public void UpdateLaque (Laque dTOLaque)
        {
            Laque laque = null;
            laque = (model.Materials.Where(x=>x.Id==dTOLaque.Id).First() as Laque);
            model.Materials.Attach(laque);
            model.SaveChanges();
        }
        public void UpdateMascara(Mascara dTOMascara)
        {
            Mascara mascara = null;
            mascara = (model.Materials.Where(x => x.Id == dTOMascara.Id) as Mascara);//??????? 342
            model.Materials.Attach(mascara);
            model.SaveChanges();
        }
        public void UpdateLipstick(Lipstick dTOLipstick)
        {
            Lipstick lipstick = null;
            lipstick = (model.Materials.Where(x => x.Id == dTOLipstick.Id).First() as Lipstick);
            model.Materials.Attach(lipstick);
            model.SaveChanges();
        }
        public void UpdateShadow (Shadows dTOShadows)
        {
            Shadows shadows = null;
            shadows = (model.Materials.Where(x => x.Id == dTOShadows.Id).First() as Shadows);
            model.Materials.Attach(shadows);
            model.SaveChanges();
        }
        public void UpdateFoundation (Foundation dTOFoundation)
        {
            Foundation foundation = null;
            foundation = (model.Materials.Where(x => x.Id == dTOFoundation.Id).First() as Foundation);
            model.Materials.Attach(foundation);
            model.SaveChanges();               
        }
        public void UpdatePowder (Powder dTOPowder)
        {
            Powder powder = null;
            powder = (model.Materials.Where(x => x.Id == dTOPowder.Id).First() as Powder);
            model.Materials.Attach(powder);
            model.SaveChanges();
        }
        public void UpdateTop (NailTop dTONailTop)
        {
            NailTop nailTop = null;
            nailTop = (model.Materials.Where(x => x.Id == dTONailTop.Id).First() as NailTop);
            model.Materials.Attach(nailTop);
            model.SaveChanges();
        }
        public void UpdateBase (NailBase dTONailBase)
        {
            NailBase nailBase = null;
            nailBase = (model.Materials.Where(x => x.Id == dTONailBase.Id).First() as NailBase);
            model.Materials.Attach(nailBase);
            model.SaveChanges();
        }
        public void UpdatePolish(NailPolish dTOPolish)
        {
            NailPolish nailPolish= null;
            nailPolish = (model.Materials.Where(x => x.Id == dTOPolish.Id).First() as NailPolish);
            model.Materials.Attach(nailPolish);
            model.SaveChanges();
        }

        public List<Service> getServusec()
        {
            return model.Services.ToList();
        }
    }
}
