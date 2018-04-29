using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;
namespace BLL
{
    public class ConvertationsBLL
    {
        public static BllStaff ConvertStaffToBll(DTODallStaff dTODallStaff)
        {
            BllStaff bllStaff = new BllStaff();
            Mapper.Initialize(x => x.CreateMap<DTODallStaff, BllStaff>());
            bllStaff = Mapper.Map<DTODallStaff, BllStaff>(dTODallStaff);
            return bllStaff;
        }
        public static DTODallStaff ConvertStaffToDTO(BllStaff bllStaff)
        {
            DTODallStaff dTODallStaff = new DTODallStaff();
            Mapper.Initialize(x => x.CreateMap<BllStaff, DTODallStaff>());
            dTODallStaff = Mapper.Map<BllStaff, DTODallStaff>(bllStaff);
            return dTODallStaff;
        }

        public static BllWorkPosition ConvertPositionToBll(DTODalWorkPosition dTODalWorkPosition)
        {
            BllWorkPosition bllWorkPosition = new BllWorkPosition();
            Mapper.Initialize(x => x.CreateMap<DTODalWorkPosition, BllWorkPosition>());
            bllWorkPosition = Mapper.Map<DTODalWorkPosition, BllWorkPosition>(dTODalWorkPosition);
            return bllWorkPosition;
        }
        public static DTODalWorkPosition ConvertPositionToDTO(BllWorkPosition bllWorkPosition)
        {
            DTODalWorkPosition dTODalWorkPosition = new DTODalWorkPosition();
            Mapper.Initialize(x => x.CreateMap<BllWorkPosition, DTODalWorkPosition>());
            dTODalWorkPosition = Mapper.Map<BllWorkPosition, DTODalWorkPosition>(bllWorkPosition);
            return dTODalWorkPosition;
        }
        public static BllServices ConvertServicesToBll(DTODalService dTODalService)
        {
            BllServices bllServices = new BllServices();
            Mapper.Initialize(x => x.CreateMap<DTODalService, BllServices>());
            bllServices = Mapper.Map<DTODalService, BllServices>(dTODalService);
            return bllServices;
        }
        public static DTODalService ConvertServicesToDTO(BllServices bllServices)
        {
            DTODalService dTODalService = new DTODalService();
            Mapper.Initialize(x => x.CreateMap<BllServices, DTODalService>());
            dTODalService = Mapper.Map<BllServices, DTODalService>(bllServices);
            return dTODalService;
        }
        public static BllBalsam ConvertBalsamToBll(DTOBalsam dTOBalsam)
        {
            BllBalsam bllBalsam = new BllBalsam();
            Mapper.Initialize(x => x.CreateMap<DTOBalsam, BllBalsam>());
            bllBalsam = Mapper.Map<DTOBalsam, BllBalsam>(dTOBalsam);
            return bllBalsam;
        }
        public static DTOBalsam ConvertBalsamToDTO(BllBalsam bllBalsam)
        {
            DTOBalsam dTOBalsam = new DTOBalsam();
            Mapper.Initialize(x => x.CreateMap<BllBalsam, DTOBalsam>());
            dTOBalsam = Mapper.Map<BllBalsam, DTOBalsam>(bllBalsam);
            return dTOBalsam;
        }
        public static BllColor ConvertColorToBll(DTOColor dTOColor)
        {
            BllColor bllColor = new BllColor();
            Mapper.Initialize(x => x.CreateMap<DTOColor, BllColor>());
            bllColor = Mapper.Map<DTOColor, BllColor>(dTOColor);
            return bllColor;
        }
        public static DTOColor ConvertColorToDTO(BllColor bllColor)
        {
            DTOColor dTOColor = new DTOColor();
            Mapper.Initialize(x => x.CreateMap<BllColor, DTOColor>());
            dTOColor = Mapper.Map<BllColor, DTOColor>(bllColor);
            return dTOColor;
        }
        public static BllFoundation ConvertFoundationToBll(DTOFoundation dTOFoundation)
        {
            BllFoundation bllFoundation = new BllFoundation();
            Mapper.Initialize(x => x.CreateMap<DTOFoundation, BllFoundation>());
            bllFoundation = Mapper.Map<DTOFoundation, BllFoundation>(dTOFoundation);
            return bllFoundation;
        }
        public static DTOFoundation ConvertFoundationToDTO(BllFoundation bllFoundation)
        {
            DTOFoundation dTOFoundation = new DTOFoundation();
            Mapper.Initialize(x => x.CreateMap<BllFoundation, DTOFoundation>());
            dTOFoundation = Mapper.Map<BllFoundation, DTOFoundation>(bllFoundation);
            return dTOFoundation;
        }
        public static BllLaque ConvertLaqueToBll(DTOLaque dTOLaque)
        {
            BllLaque bllLaque = new BllLaque();
            Mapper.Initialize(x => x.CreateMap<DTOLaque, BllLaque>());
            bllLaque = Mapper.Map<DTOLaque, BllLaque>(dTOLaque);
            return bllLaque;
        }
        public static DTOLaque ConvertLaqueToDTO(BllLaque bllLaque)
        {
            DTOLaque dTOLaque = new DTOLaque();
            Mapper.Initialize(x => x.CreateMap<BllLaque, DTOLaque>());
            dTOLaque = Mapper.Map<BllLaque, DTOLaque>(bllLaque);
            return dTOLaque;
        }
        public static BllLipstick ConvertLipstickToBLL(DTOLipstick dTOLipstick)
        {
            BllLipstick bllLipstick = new BllLipstick();
            Mapper.Initialize(x => x.CreateMap<DTOLipstick, BllLipstick>());
            bllLipstick = Mapper.Map<DTOLipstick, BllLipstick>(dTOLipstick);
            return bllLipstick;
        }
        public static DTOLipstick ConvertLipstickToDTO(BllLipstick bllLipstick)
        {
            DTOLipstick dTOLipstick = new DTOLipstick();
            Mapper.Initialize(x => x.CreateMap<BllLipstick, DTOLipstick>());
            dTOLipstick = Mapper.Map<BllLipstick, DTOLipstick>(bllLipstick);
            return dTOLipstick;
        }
        public static BllMascara ConvertMascaraToBll(DTOMascara dTOMascara)
        {
            BllMascara bllMascara = new BllMascara();
            Mapper.Initialize(x => x.CreateMap<DTOMascara, BllMascara>());
            bllMascara = Mapper.Map<DTOMascara, BllMascara>(dTOMascara);
            return bllMascara;
        }
        public static DTOMascara ConvertMascaraToDTO(BllMascara bllMascara)
        {
            DTOMascara dTOMascara = new DTOMascara();
            Mapper.Initialize(x => x.CreateMap<BllMascara, DTOMascara>());
            dTOMascara = Mapper.Map<BllMascara, DTOMascara>(bllMascara);
            return dTOMascara;
        }
        public static BllNailBase ConvertBaseToBll(DTONailBase dTONailBase)
        {
            BllNailBase bllNailBase = new BllNailBase();
            Mapper.Initialize(x => x.CreateMap<DTONailBase, BllNailBase>());
            bllNailBase = Mapper.Map<DTONailBase, BllNailBase>(dTONailBase);
            return bllNailBase;
        }
        public static DTONailBase ConvertBaseToDTO(BllNailBase bllNailBase)
        {
            DTONailBase dTONailBase = new DTONailBase();
            Mapper.Initialize(x => x.CreateMap<BllNailBase, DTONailBase>());
            dTONailBase = Mapper.Map<BllNailBase, DTONailBase>(bllNailBase);
            return dTONailBase;
        }
        public static BllNailPolish ConvertPolishToBLL(DTOPolish dTOPolish)
        {
            BllNailPolish bllNailPolish = new BllNailPolish();
            Mapper.Initialize(x => x.CreateMap<DTOPolish, BllNailPolish>());
            bllNailPolish = Mapper.Map<DTOPolish, BllNailPolish>(dTOPolish);
            return bllNailPolish;
        }
        public static DTOPolish ConvertPolishToDTO(BllNailPolish bllNailPolish)
        {
            DTOPolish dTOPolish = new DTOPolish();
            Mapper.Initialize(x => x.CreateMap<BllNailPolish, DTOPolish>());
            dTOPolish = Mapper.Map<BllNailPolish, DTOPolish>(bllNailPolish);
            return dTOPolish;
        }
        public static BllNailTop ConvertTopTOBLL(DTONailTop dTONailTop)
        {
            BllNailTop bllNailTop = new BllNailTop();
            Mapper.Initialize(x => x.CreateMap<DTONailTop, BllNailTop>());
            bllNailTop = Mapper.Map<DTONailTop, BllNailTop>(dTONailTop);
            return bllNailTop;
        }
        public static DTONailTop ConvertTopToDTO(BllNailTop bllNailTop)
        {
            DTONailTop dTONailTop = new DTONailTop();
            Mapper.Initialize(x => x.CreateMap<BllNailTop, DTONailTop>());
            dTONailTop = Mapper.Map<BllNailTop, DTONailTop>(bllNailTop);
            return dTONailTop;
        }
        public static BllPowder ConvertPowderToBll(DTOPowder dTOPowder)
        {
            BllPowder bllPowder = new BllPowder();
            Mapper.Initialize(x => x.CreateMap<DTOPowder, BllPowder>());
            bllPowder = Mapper.Map<DTOPowder, BllPowder>(dTOPowder);
            return bllPowder;
        }
        public static DTOPowder ConvertPowderToDTO(BllPowder bllPowder)
        {
            DTOPowder dTOPowder = new DTOPowder();
            Mapper.Initialize(x => x.CreateMap<BllPowder, DTOPowder>());
            dTOPowder = Mapper.Map<BllPowder, DTOPowder>(bllPowder);
            return dTOPowder;
        }
        public static BllShadows ConvertShadowToBll(DTOShadows dTOShadows)
        {
            BllShadows bllShadows = new BllShadows();
            Mapper.Initialize(x => x.CreateMap<DTOShadows, BllShadows>());
            bllShadows = Mapper.Map<DTOShadows, BllShadows>(dTOShadows);
            return bllShadows;
        }
        public static DTOShadows ConvertShadowToDTO(BllShadows bllShadows)
        {
            DTOShadows dTOShadows = new DTOShadows();
            Mapper.Initialize(x => x.CreateMap<BllShadows, DTOShadows>());
            dTOShadows = Mapper.Map<BllShadows, DTOShadows>(bllShadows);
            return dTOShadows;
        }
        public static BllShampoo ConvertShampoToBLL(DTOShampoo dTOShampoo)
        {
            BllShampoo bllShampoo = new BllShampoo();
            Mapper.Initialize(x => x.CreateMap<DTOShampoo, BllShampoo>());
            bllShampoo = Mapper.Map<DTOShampoo, BllShampoo>(dTOShampoo);
            return bllShampoo;
        }
      
    }
}
