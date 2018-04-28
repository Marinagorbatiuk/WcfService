using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Dal
{
    public class DALConvertation
    {
       // ModelBeauty model = new ModelBeauty();
        public static DTOShampoo ConvertShampooFromEntityToDTO(Shampoo shampoo)
        {
            DTOShampoo dTOShampoo = new DTOShampoo();
            Mapper.Initialize(x => x.CreateMap<Shampoo, DTOShampoo>()/*.ForMember("Color", y=>y.MapFrom(q=>q.Color))*/);
            dTOShampoo = Mapper.Map<Shampoo, DTOShampoo>(shampoo);

            return dTOShampoo;
        }
        public static Shampoo ConvertShampooToEntity(DTOShampoo dTOShampoo)
        {
            // List<Shampoo> shampoos = new List<Shampoo>();
            Shampoo shampoo = new Shampoo();
            // shampoo = null;
            Mapper.Initialize(x => x.CreateMap<DTOShampoo, Shampoo>());
            shampoo = Mapper.Map<DTOShampoo, Shampoo>(dTOShampoo);
            shampoo.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            shampoo.Service = model.Services.Where(x => x.Name == "HairCut" || x.Name == "HairColoring").ToList();
            return shampoo;
        }
        public static DTOBalsam ConvertBalsamFromEntityToDTO(Balsam balsam)
        {
            DTOBalsam dTOBalsam = new DTOBalsam();
            Mapper.Initialize(x => x.CreateMap<Balsam, DTOBalsam>());
            dTOBalsam = Mapper.Map<Balsam, DTOBalsam>(balsam);
            return dTOBalsam;
        }
        public static Balsam ConvertBalsamToEntity(DTOBalsam dTOBalsam)
        {
            Balsam balsam = new Balsam();
            Mapper.Initialize(x => x.CreateMap<DTOBalsam, Balsam>());
            balsam = Mapper.Map<DTOBalsam, Balsam>(dTOBalsam);
            balsam.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            balsam.Service = model.Services.Where(x => x.Name == "HairCut" || x.Name == "HairColoring").ToList();
            return balsam;               
        }
        public static DTOColor ConvertColorFromEntityToDTO(HairColor hairColor)
        {
            DTOColor dTOColor = new DTOColor();
            Mapper.Initialize(x => x.CreateMap<HairColor, DTOColor>());
            dTOColor = Mapper.Map<HairColor, DTOColor>(hairColor);
            return dTOColor;
        }
        public static HairColor ConvertColorToEntity(DTOColor dTOColor)
        {
            HairColor color = new HairColor();
            Mapper.Initialize(x => x.CreateMap<DTOColor, HairColor>());
            color = Mapper.Map<DTOColor, HairColor>(dTOColor);
            color.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            color.Service = model.Services.Where(x =>  x.Name == "HairColoring").ToList();
            return color;
        }
        public static DTOFoundation ConvertFoundationFromEntityToDTO(Foundation foundation)
        {
            DTOFoundation dTOFoundation = new DTOFoundation();
            Mapper.Initialize(x => x.CreateMap<Foundation, DTOFoundation>());
            dTOFoundation = Mapper.Map<Foundation, DTOFoundation>(foundation);
            return dTOFoundation;
        }
        public static Foundation  ConvertFoundationToEntity(DTOFoundation dTOFoundation)
        {
            Foundation foundation = new Foundation();
            Mapper.Initialize(x => x.CreateMap<DTOFoundation, Foundation>());
            foundation = Mapper.Map<DTOFoundation, Foundation>(dTOFoundation);
            foundation.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            foundation.Service = model.Services.Where(x => x.Name == "MakeUp").ToList();
            return foundation;
        }
        public static DTOLaque ConvertLaqueFromEntityToDTO(Laque laque)
        {
            DTOLaque dTOLaque = new DTOLaque();
            Mapper.Initialize(x => x.CreateMap<Laque, DTOLaque>());
            dTOLaque = Mapper.Map<Laque, DTOLaque>(laque);
            return dTOLaque;
        }
        public static Laque ConvertLaqueToEntity(DTOLaque dTOLaque)
        {
            Laque laque = new Laque();
            Mapper.Initialize(x => x.CreateMap<DTOLaque, Laque>());
            laque = Mapper.Map<DTOLaque, Laque>(dTOLaque);
            laque.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            laque.Service = model.Services.Where(x => x.Name == "HairCut" || x.Name == "HairColoring").ToList();
            return laque;
        }
        public static DTOLipstick DTOLipstickConvertLipsticFromEntityToDTO(Lipstick lipstick)
        {
            DTOLipstick dTOLipstick = new DTOLipstick();
            Mapper.Initialize(x => x.CreateMap<Lipstick, DTOLipstick>());
            dTOLipstick = Mapper.Map<Lipstick, DTOLipstick>(lipstick);
            return dTOLipstick;
        }
        public static Lipstick ConvertLipstickToEntity(DTOLipstick dTOLipstick)
        {
            Lipstick lipstick = new Lipstick();
            Mapper.Initialize(x => x.CreateMap<DTOLipstick, Lipstick>());
            lipstick = Mapper.Map<DTOLipstick, Lipstick>(dTOLipstick);
            lipstick.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            lipstick.Service = model.Services.Where(x => x.Name == "MakeUp").ToList();
            return lipstick;
        }
        public static DTOMascara ConvertMascaraFomEntityToDTO(Mascara mascara)
        {
            DTOMascara dTOMascara = new DTOMascara();
            Mapper.Initialize(x => x.CreateMap<Mascara, DTOMascara>());
            dTOMascara = Mapper.Map<Mascara, DTOMascara>(mascara);
            return dTOMascara;
        }
        public static Mascara ConvertMascaraToEntity(DTOMascara dTOMascara)
        {
            Mascara mascara = new Mascara();
            Mapper.Initialize(x => x.CreateMap<DTOMascara, Mascara>());
            mascara = Mapper.Map<DTOMascara, Mascara>(dTOMascara);
            mascara.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            mascara.Service = model.Services.Where(x => x.Name == "MakeUp").ToList();
            return mascara;
        }
        public static DTONailBase ConvertBaseFromEntityToDTO(NailBase nailBase)
        {
            DTONailBase dTONailBase = new DTONailBase();
            Mapper.Initialize(x => x.CreateMap<NailBase, DTONailBase>());
            dTONailBase = Mapper.Map<NailBase, DTONailBase>(nailBase);
            return dTONailBase;
        }
        public static NailBase ConvertBaseToEntity(DTONailBase dTONailBase)
        {
            NailBase nailBase = new NailBase();
            Mapper.Initialize(x => x.CreateMap<DTONailBase, NailBase>());
            nailBase = Mapper.Map<DTONailBase, NailBase>(dTONailBase);
            nailBase.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            nailBase.Service = model.Services.Where(x => x.Name == "Manicure").ToList();
            return nailBase;
        }

        public static DTONailTop ConvertTopFRomEntityToDTO(NailTop nailTop)
        {
            DTONailTop dtonailTop = new DTONailTop();
            Mapper.Initialize(x => x.CreateMap<NailTop, DTONailTop>());
            dtonailTop = Mapper.Map<NailTop, DTONailTop>(nailTop);
            return dtonailTop;
        }
        public static NailTop ConvertTopToEntity(DTONailTop dTONailTop)
        {
            NailTop nailTop = new NailTop();
            Mapper.Initialize(x => x.CreateMap<DTONailTop, NailTop>());
            nailTop = Mapper.Map<DTONailTop, NailTop>(dTONailTop);
            nailTop.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            nailTop.Service = model.Services.Where(x => x.Name == "Manicure").ToList();
            return nailTop;
        }
        public static DTOPolish ConvertPolishFromEntityToDTO(NailPolish nailPolish)
        {
            DTOPolish dTOPolish = new DTOPolish();
            Mapper.Initialize(x => x.CreateMap<NailPolish, DTOPolish>());
            dTOPolish = Mapper.Map<NailPolish, DTOPolish>(nailPolish);
            return dTOPolish;
        }
        public static NailPolish ConvertPolishToEntity(DTOPolish dTOPolish)
        {
            NailPolish nailPolish = new NailPolish();
            Mapper.Initialize(x => x.CreateMap<DTOPolish, NailPolish>());
            nailPolish = Mapper.Map<DTOPolish, NailPolish>(dTOPolish);
            nailPolish.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            nailPolish.Service = model.Services.Where(x => x.Name == "Manicure").ToList();
            return nailPolish;
        }
        public static DTOPowder ConvertPowderFromEntityToDTO(Powder powder)
        {
            DTOPowder dTOPowder = new DTOPowder();
            Mapper.Initialize(x => x.CreateMap<Powder, DTOPowder>());
            dTOPowder = Mapper.Map<Powder, DTOPowder>(powder);
            return dTOPowder;
        }
        public static Powder ConvertPowderToEntity(DTOPowder dTOPowder)
        {
            Powder powder = new Powder();
            Mapper.Initialize(x => x.CreateMap<DTOPowder, Powder>());
            powder = Mapper.Map<DTOPowder, Powder>(dTOPowder);
            powder.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            powder.Service = model.Services.Where(x => x.Name == "MakeUp").ToList();
            return powder;
        }
        public static DTOShadows ConvertSadowFromEntityToDTO(Shadows shadows)
        {
            DTOShadows dTOShadows = new DTOShadows();
            Mapper.Initialize(x => x.CreateMap<Shadows, DTOShadows>());
            dTOShadows = Mapper.Map<Shadows, DTOShadows>(shadows);
            return dTOShadows;
        }
        public static Shadows ConvertShadowToEntity(DTOShadows dTOShadows)
        {
            Shadows shadows = new Shadows();
            Mapper.Initialize(x => x.CreateMap<DTOShadows, Shadows>());
            shadows = Mapper.Map<DTOShadows, Shadows>(dTOShadows);
            shadows.Service = new List<Service>();
            ModelBeauty model = new ModelBeauty();
            shadows.Service = model.Services.Where(x => x.Name == "MakeUp").ToList();
            return shadows;
        }

        public static DTODalService ConvertServiceFromEntityToDTO( Service service)
        {
            DTODalService dalService = new DTODalService();
            Mapper.Initialize(x => x.CreateMap<Service, DTODalService>());
            dalService = Mapper.Map<Service, DTODalService>(service);
            return dalService;
        }
        public static Service ConvertServiceToEntity(DTODalService dalService)
        {
            Service service = new Service();
            Mapper.Initialize(x => x.CreateMap<DTODalService, Service>());
            service = Mapper.Map<DTODalService, Service>(dalService);
            service.Materials = new List<Material>();
            ModelBeauty model = new ModelBeauty();
           // service.Materials = model.Materials.
        // collection 
            return service;
        }

        public static DTODallStaff ConvertStaffFromEntityToDTO(Staff staff)
        {
            DTODallStaff dTODallStaff = new DTODallStaff();
            Mapper.Initialize(x => x.CreateMap<Staff, DTODallStaff>());
            dTODallStaff = Mapper.Map<Staff, DTODallStaff>(staff);
            return dTODallStaff;
        }
        public static Staff ConvertStaffToEntity(DTODallStaff dtostaff)
        {
            Staff staff = new Staff();
            Mapper.Initialize(x => x.CreateMap<DTODallStaff, Staff>());
            staff = Mapper.Map<DTODallStaff, Staff>(dtostaff);

            return staff;
        }
        public static DTODalWorkPosition ConvertPositionFromEntityToDto(WorkPosition workPosition)
        {
            DTODalWorkPosition dalWorkPosition = new DTODalWorkPosition();
            Mapper.Initialize(x => x.CreateMap<WorkPosition, DTODalWorkPosition>());
            dalWorkPosition = Mapper.Map<WorkPosition, DTODalWorkPosition>(workPosition);
            return dalWorkPosition;
        }
    }
}
