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
        public List<DTOShampoo> GetShampoo()
        {
            List<DTOShampoo> shampoo = new List<DTOShampoo>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmpshampo = model.Materials.Where(x => (x is Shampoo)).Select(y => (y as Shampoo)).ToList();
                shampoo = tmpshampo.Select(x=> DALConvertation.ConvertShampooFromEntityToDTO(x)).ToList();
            }

                return shampoo;
        }
        public List<DTOBalsam> GetBalsam()
        {
            List<DTOBalsam> balsam = new List<DTOBalsam>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmpbalsam = model.Materials.Where(x => (x is Balsam)).Select(y => (y as Balsam)).ToList();
                balsam = tmpbalsam.Select(x => DALConvertation.ConvertBalsamFromEntityToDTO(x)).ToList();
            }

            return balsam;
        }
        public List<DTOColor> GetColor()
        {
            List<DTOColor> color = new List<DTOColor>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmpcolor = model.Materials.Where(x => (x is HairColor)).Select(y => (y as HairColor)).ToList();
                color = tmpcolor.Select(x => DALConvertation.ConvertColorFromEntityToDTO(x)).ToList();
            }

            return color;
        }
        public List<DTOFoundation> GetFoundation()
        {
            List<DTOFoundation> foundation = new List<DTOFoundation>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmpfoundation = model.Materials.Where(x => (x is Foundation)).Select(y => (y as Foundation)).ToList();
                foundation = tmpfoundation.Select(x => DALConvertation.ConvertFoundationFromEntityToDTO(x)).ToList();
            }

            return foundation;
        }
        public List<DTOLaque> GetLaque()
        {
            List<DTOLaque> laque = new List<DTOLaque>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmplaque = model.Materials.Where(x => (x is Laque)).Select(y => (y as Laque)).ToList();
                laque = tmplaque.Select(x => DALConvertation.ConvertLaqueFromEntityToDTO(x)).ToList();
            }

            return laque;
        }
        public List<DTOLipstick> GetLipstick()
        {
            List<DTOLipstick> lipstick = new List<DTOLipstick>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmplipstick = model.Materials.Where(x => (x is Lipstick)).Select(y => (y as Lipstick)).ToList();
                lipstick = tmplipstick.Select(x => DALConvertation.DTOLipstickConvertLipsticFromEntityToDTO(x)).ToList();
            }

            return lipstick;
        }
        public List<DTOMascara> GetMascara()
        {
            List<DTOMascara> mascara = new List<DTOMascara>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmpmascaras = model.Materials.Where(x => (x is Mascara)).Select(y => (y as Mascara)).ToList();
                mascara = tmpmascaras.Select(x => DALConvertation.ConvertMascaraFomEntityToDTO(x)).ToList();
            }

            return mascara;
        }
        public List<DTONailBase> GetNailBase()
        {
            List<DTONailBase> nailBases = new List<DTONailBase>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmpbase = model.Materials.Where(x => (x is NailBase)).Select(y => (y as NailBase)).ToList();
                nailBases = tmpbase.Select(x => DALConvertation.ConvertBaseFromEntityToDTO(x)).ToList();
            }

            return nailBases;
        }
        public List<DTOPolish> GetNailPolish()
        {
            List<DTOPolish> nailPolish = new List<DTOPolish>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmppolish = model.Materials.Where(x => (x is NailPolish)).Select(y => (y as NailPolish)).ToList();
                nailPolish = tmppolish.Select(x => DALConvertation.ConvertPolishFromEntityToDTO(x)).ToList();
            }

            return nailPolish;
        }
        public List<DTONailTop> GetNailTop()
        {
            List<DTONailTop> nailTop = new List<DTONailTop>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmptop = model.Materials.Where(x => (x is NailTop)).Select(y => (y as NailTop)).ToList();
                nailTop = tmptop.Select(x => DALConvertation.ConvertTopFRomEntityToDTO(x)).ToList();
            }

            return nailTop;
        }
        public List<DTOPowder> GetPowder()
        {
            List<DTOPowder> powder = new List<DTOPowder>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmppowder = model.Materials.Where(x => (x is Powder)).Select(y => (y as Powder)).ToList();
                powder = tmppowder.Select(x => DALConvertation.ConvertPowderFromEntityToDTO(x)).ToList();
            }

            return powder;
        }
        public List<DTOShadows> GetShadow()
        {
            List<DTOShadows> shadows = new List<DTOShadows>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmpshadow = model.Materials.Where(x => (x is Shadows)).Select(y => (y as Shadows)).ToList();
                shadows = tmpshadow.Select(x => DALConvertation.ConvertSadowFromEntityToDTO(x)).ToList();
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
        public List <DTODallStaff> GetStaff()
        {
            List<DTODallStaff> dTODallStaffs = new List<DTODallStaff>();
            using (ModelBeauty model = new ModelBeauty())
            {
                var tmpstaff = model.Staffs.Where(x => x.WorkPosition.Name == "Employee").ToList();
                dTODallStaffs = tmpstaff.Select(x => DALConvertation.ConvertStaffFromEntityToDTO(x)).ToList();
            }
                return dTODallStaffs;
        }
        public void  DeleteUser(int id)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Staffs.Remove(model.Staffs.Where(x => x.Id == id).First());
                model.SaveChanges();
            }
        }

        public void AddUser(DTODallStaff dTODallStaff)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Staffs.Add(DALConvertation.ConvertStaffToEntity(dTODallStaff));
                model.SaveChanges();
            }
        }

        public void AddShampooToDB(DTOShampoo shampoos)
        {
        //    Shampoo shampoos = new Shampoo();
            using (ModelBeauty model = new ModelBeauty())
            {
                //shampoos = model.Materials.Add(model.Materials.Where(x=>(x is Shampoo)).Select(y=>(y as Shampoo)).First());
                //shampoos= model.Materials.Add(model.Materials.Where(x => (x is Shampoo)).First());
                model.Materials.Add(DALConvertation.ConvertShampooToEntity(shampoos));
                
                model.SaveChanges();
               
            }
          // return shampoos;
        }

        public void AddBalsamToDB (DTOBalsam balsam)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertBalsamToEntity(balsam));
                model.SaveChanges();
            }
        }
        public void AddColorToDB (DTOColor dTOColor)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertColorToEntity(dTOColor));
                model.SaveChanges();
            }
        }
        public void AddLaqueToDB (DTOLaque dTOLaque)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertLaqueToEntity(dTOLaque));
                model.SaveChanges();
            }
        }
        public void AddLipstickToDB(DTOLipstick dTOLipstick)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertLipstickToEntity(dTOLipstick));
                model.SaveChanges();
            }
        }
        public void AddMascaraToDB(DTOMascara dTOMascara)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertMascaraToEntity(dTOMascara));
                model.SaveChanges();
            }
        }
        public void AddShadowToDB( DTOShadows dTOShadows )
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertShadowToEntity(dTOShadows));
                model.SaveChanges();
            }
        }
        public void AddFoundationToDB(DTOFoundation dTOFoundation)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertFoundationToEntity(dTOFoundation));
                model.SaveChanges();
            }
        }
        public void AddPowderToDB(DTOPowder dTOPowder)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertPowderToEntity(dTOPowder));
                model.SaveChanges();
            }
        }
        public void AddPolishToDB(DTOPolish dTOPolish)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertPolishToEntity(dTOPolish));
                model.SaveChanges();
            }
        }
        public void AddTopToDB(DTONailTop dTONailTop)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertTopToEntity(dTONailTop));
                model.SaveChanges();
            }
        }
        public void AddBaseToDB(DTONailBase dTONailBase)
        {
            using (ModelBeauty model = new ModelBeauty())
            {
                model.Materials.Add(DALConvertation.ConvertBaseToEntity(dTONailBase));
                model.SaveChanges();
            }
        }
        ModelBeauty model = new ModelBeauty();
        public void UpdateShampoo(DTOShampoo shampoo)
        {
            Shampoo sh = null;
           // ModelBeauty model = new ModelBeauty();
           sh= (model.Materials.Where(x => x.Id == shampoo.Id).First() as Shampoo);

            model.Materials.Attach(sh);
            sh = DALConvertation.ConvertShampooToEntity(shampoo);//???????????
            model.SaveChanges();
        }

        public void UpdateBalsam (DTOBalsam dTOBalsam)
        {
            Balsam balsam = null;
            balsam = (model.Materials.Where(x => x.Id == dTOBalsam.Id).First() as Balsam);
            model.Materials.Attach(balsam);
            balsam = DALConvertation.ConvertBalsamToEntity(dTOBalsam);
            model.SaveChanges();
        }
        public void UpdateColor (DTOColor dTOColor)
        {
            HairColor hairColor = null;
            hairColor = (model.Materials.Where(x => x.Id == dTOColor.Id).First() as HairColor);
            model.Materials.Attach(hairColor);
            hairColor = DALConvertation.ConvertColorToEntity(dTOColor);
            model.SaveChanges();
        }
        public void UpdateLaque (DTOLaque dTOLaque)
        {
            Laque laque = null;
            laque = (model.Materials.Where(x=>x.Id==dTOLaque.Id).First() as Laque);//?????????? 350
            model.Materials.Attach(laque);//  344
            laque = DALConvertation.ConvertLaqueToEntity(dTOLaque);// 343
            model.SaveChanges();
        }
        public void UpdateMascara(DTOMascara dTOMascara)
        {
            Mascara mascara = null;
            mascara = (model.Materials.Where(x => x.Id == dTOMascara.Id) as Mascara);//??????? 342
            model.Materials.Attach(mascara);
            mascara = DALConvertation.ConvertMascaraToEntity(dTOMascara);
            model.SaveChanges();
        }
        public void UpdateLipstick(DTOLipstick dTOLipstick)
        {
            Lipstick lipstick = null;
            lipstick = (model.Materials.Where(x => x.Id == dTOLipstick.Id).First() as Lipstick);
            model.Materials.Attach(lipstick);
            lipstick = DALConvertation.ConvertLipstickToEntity(dTOLipstick);
            model.SaveChanges();
        }
        public void UpdateShadow (DTOShadows dTOShadows)
        {
            Shadows shadows = null;
            shadows = (model.Materials.Where(x => x.Id == dTOShadows.Id).First() as Shadows);
            model.Materials.Attach(shadows);
            shadows = DALConvertation.ConvertShadowToEntity(dTOShadows);
            model.SaveChanges();
        }
        public void UpdateFoundation (DTOFoundation dTOFoundation)
        {
            Foundation foundation = null;
            foundation = (model.Materials.Where(x => x.Id == dTOFoundation.Id).First() as Foundation);
            model.Materials.Attach(foundation);
            foundation = DALConvertation.ConvertFoundationToEntity(dTOFoundation);
            model.SaveChanges();               
        }
        public void UpdatePowder (DTOPowder dTOPowder)
        {
            Powder powder = null;
            powder = (model.Materials.Where(x => x.Id == dTOPowder.Id).First() as Powder);
            model.Materials.Attach(powder);
            powder = DALConvertation.ConvertPowderToEntity(dTOPowder);
            model.SaveChanges();
        }
        public void UpdateTop (DTONailTop dTONailTop)
        {
            NailTop nailTop = null;
            nailTop = (model.Materials.Where(x => x.Id == dTONailTop.Id).First() as NailTop);
            model.Materials.Attach(nailTop);
            nailTop = DALConvertation.ConvertTopToEntity(dTONailTop);
            model.SaveChanges();
        }
        public void UpdateBase (DTONailBase dTONailBase)
        {
            NailBase nailBase = null;
            nailBase = (model.Materials.Where(x => x.Id == dTONailBase.Id).First() as NailBase);
            model.Materials.Attach(nailBase);
            nailBase = DALConvertation.ConvertBaseToEntity(dTONailBase);
            model.SaveChanges();
        }
        public void UpdatePolish(DTOPolish dTOPolish)
        {
            NailPolish nailPolish= null;
            nailPolish = (model.Materials.Where(x => x.Id == dTOPolish.Id).First() as NailPolish);
            model.Materials.Attach(nailPolish);
            nailPolish = DALConvertation.ConvertPolishToEntity(dTOPolish);
            model.SaveChanges();
        }
    }
}
