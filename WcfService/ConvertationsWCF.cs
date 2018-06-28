using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
namespace WcfService
{
    public class ConvertationsWCF
    {
        public static InfoWCF ConvertToBllInfo(BllInfo info)
        {
            return new InfoWCF
            {
                id = info.id,
                Action = info.Action,
                ActionTime = info.ActionTime,
                InputParameters = info.InputParameters,
                OutputParameters = info.OutputParameters,
                Login = info.Login
            };
        }

        public static StaffWCF ConvertStaffToWcf(BllStaff dTODallStaff)
        {
            StaffWCF wcfStaff = new StaffWCF()
            {
                Login = dTODallStaff.Login,
                Password = dTODallStaff.Password,
                
                Id = dTODallStaff.Id,
                WorkPosition = new WorkPositionWCF { Name= dTODallStaff .WorkPosition.Name,
                                                     Id = dTODallStaff.WorkPosition.Id},
            };

            return wcfStaff;
        }
        public static BllStaff ConvertStaffToBll(StaffWCF wcfStaff)
        {
            BllStaff bllStaff = new BllStaff()
            {
                Login = wcfStaff.Login,
                Password = wcfStaff.Password,
                WorkPosition = new BllWorkPosition
                {
                    Id = wcfStaff.WorkPosition.Id,
                    Name = wcfStaff.WorkPosition.Name
                }
            };

            return bllStaff;
        }

        public static WorkPositionWCF ConvertPositionToWcf(BllWorkPosition WorkPosition)
        {
            WorkPositionWCF wcfWorkPosition = new WorkPositionWCF()
            {
                Name = WorkPosition.Name,
                Id = WorkPosition.Id,
               
            };

            return wcfWorkPosition;
        }
        public static BllWorkPosition ConvertPositionToBll(WorkPositionWCF wcfWorkPosition)
        {
            BllWorkPosition bllWorkPosition = new BllWorkPosition()
            {
                Name = wcfWorkPosition.Name,
                Id = wcfWorkPosition.Id
            };


            return bllWorkPosition;
        }
        public static BllServices ConvertServicesToBll(ServicesWCF dTODalService)
        {
            BllServices bllServices = new BllServices()
            {
                Name = dTODalService.Name,
                Price = dTODalService.Price,
                Id = dTODalService.Id,
                //BllMaterials= dTODalService.Id
            };

            return bllServices;
        }
        public static ServicesWCF ConvertServicesToWcf(BllServices bllServices)
        {
            ServicesWCF wcfService = new ServicesWCF()
            {
                Name = bllServices.Name,
                Price = bllServices.Price,
                Id = bllServices.Id,
              //  Materials=bllServices.BllMaterials
            };

            return wcfService;
        }
        public static BllBalsam ConvertBalsamToBll(BalsamWCF Balsam)
        {
            BllBalsam bllBalsam = new BllBalsam()
            {
                Name = Balsam.Name,
                Brand = Balsam.Brand,
                Price = Balsam.Price,
                QuantityBottles = Balsam.QuantityBottles,
                QuantityGeneralVolume = Balsam.QuantityGeneralVolume,
                Volume = Balsam.Volume,
                Id = Balsam.Id,
                QuntityCount = Balsam.QuntityCount

            };

            return bllBalsam;
        }
        public static BalsamWCF ConvertBalsamToWcf(BllBalsam bllBalsam)
        {
            BalsamWCF wcfBalsam = new BalsamWCF()
            {
                Name = bllBalsam.Name,
                Brand = bllBalsam.Brand,
                Price = bllBalsam.Price,
                QuantityBottles = bllBalsam.QuantityBottles,
                QuantityGeneralVolume = bllBalsam.QuantityGeneralVolume,
                Volume = bllBalsam.Volume,
                Id = bllBalsam.Id,
                QuntityCount = bllBalsam.QuntityCount

            };
            
            return wcfBalsam;
        }
        public static BllColor ConvertColorToBll(ColorWCF wcfColor)
        {
            BllColor bllColor = new BllColor()
            {
                Id = wcfColor.Id,
                Name = wcfColor.Name,
                Brand = wcfColor.Brand,
                Price = wcfColor.Price,
                Color = wcfColor.Color,
                Volume = wcfColor.Volume,
                QuantityBottles = wcfColor.QuantityBottles,
                QuantityGeneralVolume = wcfColor.QuantityGeneralVolume,
                Description = wcfColor.Description,
                QuntityCount = wcfColor.QuntityCount
            };
            return bllColor;
        }
        public static ColorWCF ConvertColorToWcf(BllColor bllColor)
        {
            ColorWCF wcfColor = new ColorWCF()
            {
               Id = bllColor.Id,
                Name = bllColor.Name,
                Brand = bllColor.Brand,
                Price = bllColor.Price,
                Color = bllColor.Color,
                Volume = bllColor.Volume,
                QuantityBottles = bllColor.QuantityBottles,
                QuantityGeneralVolume = bllColor.QuantityGeneralVolume,
                Description = bllColor.Description,
                QuntityCount = bllColor.QuntityCount

            };

            return wcfColor;
        }
        public static BllFoundation ConvertFoundationToBll(FoundationWCF wcfFoundation)
        {
            BllFoundation bllFoundation = new BllFoundation()
            {
                Id = wcfFoundation.Id,
                Name = wcfFoundation.Name,
                Brand = wcfFoundation.Brand,
                Price = wcfFoundation.Price,
                Color = wcfFoundation.Color,
                Volume = wcfFoundation.Volume,
                QuantityBottles = wcfFoundation.QuantityBottles,
                QuantityGeneralVolume = wcfFoundation.QuantityGeneralVolume,
                Description = wcfFoundation.Description,
                QuntityCount = wcfFoundation.QuntityCount

            };

            return bllFoundation;
        }
        public static FoundationWCF ConvertFoundationTowcf(BllFoundation bllFoundation)
        {
            FoundationWCF wcfFoundation = new FoundationWCF()
            {
                Id = bllFoundation.Id,
                Name = bllFoundation.Name,
                Brand = bllFoundation.Brand,
                Price = bllFoundation.Price,
                Color = bllFoundation.Color,
                Volume = bllFoundation.Volume,
                QuantityBottles = bllFoundation.QuantityBottles,
                QuantityGeneralVolume = bllFoundation.QuantityGeneralVolume,
                Description = bllFoundation.Description,
                QuntityCount = bllFoundation.QuntityCount

            };

            return wcfFoundation;
        }
        public static BllLaque ConvertLaqueToBll(LaqueWCF wcfLaque)
        {
            BllLaque bllLaque = new BllLaque()
            {
               Id = wcfLaque.Id,
                Name = wcfLaque.Name,
                Brand = wcfLaque.Brand,
                Price = wcfLaque.Price,
                Volume = wcfLaque.Volume,
                QuantityBottles = wcfLaque.QuantityBottles,
                QuantityGeneralVolume = wcfLaque.QuantityGeneralVolume,
                QuntityCount = wcfLaque.QuntityCount

            };

            return bllLaque;
        }
        public static LaqueWCF ConvertLaqueToWcf(BllLaque bllLaque)
        {
            LaqueWCF wcfLaque = new LaqueWCF()
            {
               Id = bllLaque.Id,
                Name = bllLaque.Name,
                Brand = bllLaque.Brand,
                Price = bllLaque.Price,
                Volume = bllLaque.Volume,
                QuantityBottles = bllLaque.QuantityBottles,
                QuantityGeneralVolume = bllLaque.QuantityGeneralVolume,
                QuntityCount = bllLaque.QuntityCount

            };

            return wcfLaque;
        }
        public static BllLipstick ConvertLipstickToBLL(LipstickWCF wcfLipstick)
        {
            BllLipstick bllLipstick = new BllLipstick()
            {
                Id = wcfLipstick.Id,
                Name = wcfLipstick.Name,
                Brand = wcfLipstick.Brand,
                Price = wcfLipstick.Price,
                Color = wcfLipstick.Color,
                Volume = wcfLipstick.Volume,
                QuantityBottles = wcfLipstick.QuantityBottles,
                QuantityGeneralVolume = wcfLipstick.QuantityGeneralVolume,
                Description = wcfLipstick.Description,
                QuntityCount = wcfLipstick.QuntityCount

            };

            return bllLipstick;
        }
        public static LipstickWCF ConvertLipstickTowcf(BllLipstick bllLipstick)
        {
            LipstickWCF wcfLipstick = new LipstickWCF()
            {
                Id = bllLipstick.Id,
                Name = bllLipstick.Name,
                Brand = bllLipstick.Brand,
                Price = bllLipstick.Price,
                Color = bllLipstick.Color,
                Volume = bllLipstick.Volume,
                QuantityBottles = bllLipstick.QuantityBottles,
                QuantityGeneralVolume = bllLipstick.QuantityGeneralVolume,
                Description = bllLipstick.Description,
                QuntityCount = bllLipstick.QuntityCount

            };
            return wcfLipstick;
        }
        public static BllMascara ConvertMascaraToBll(MascaraWCF wcfMascara)
        {
            BllMascara bllMascara = new BllMascara()
            {
                Id = wcfMascara.Id,
                Name = wcfMascara.Name,
                Brand = wcfMascara.Brand,
                Price = wcfMascara.Price,
                Color = wcfMascara.Color,
                Volume = wcfMascara.Volume,
                QuantityBottles = wcfMascara.QuantityBottles,
                QuantityGeneralVolume = wcfMascara.QuantityGeneralVolume,
                QuntityCount = wcfMascara.QuntityCount

            };

            return bllMascara;
        }
        public static MascaraWCF ConvertMascaraToWcf(BllMascara bllMascara)
        {
            MascaraWCF wcfMascara = new MascaraWCF()
            {
                Id = bllMascara.Id,
                Name = bllMascara.Name,
                Brand = bllMascara.Brand,
                Price = bllMascara.Price,
                Color = bllMascara.Color,
                Volume = bllMascara.Volume,
                QuantityBottles = bllMascara.QuantityBottles,
                QuantityGeneralVolume = bllMascara.QuantityGeneralVolume,
                QuntityCount = bllMascara.QuntityCount

            };

            return wcfMascara;
        }
        public static BllNailBase ConvertBaseToBll(NailBaseWCF wcfNailBase)
        {
            BllNailBase bllNailBase = new BllNailBase()
            {
                Id = wcfNailBase.Id,
                Name = wcfNailBase.Name,
                Brand = wcfNailBase.Brand,
                Price = wcfNailBase.Price,
                Volume = wcfNailBase.Volume,
                QuantityBottles = wcfNailBase.QuantityBottles,
                QuantityGeneralVolume = wcfNailBase.QuantityGeneralVolume,
                QuntityCount = wcfNailBase.QuntityCount

            };

            return bllNailBase;
        }
        public static NailBaseWCF ConvertBaseToWCF(BllNailBase bllNailBase)
        {
            NailBaseWCF wcfNailBase = new NailBaseWCF()
            {
                Id = bllNailBase.Id,
                Name = bllNailBase.Name,
                Brand = bllNailBase.Brand,
                Price = bllNailBase.Price,
                Volume = bllNailBase.Volume,
                QuantityBottles = bllNailBase.QuantityBottles,
                QuantityGeneralVolume = bllNailBase.QuantityGeneralVolume,
                QuntityCount = bllNailBase.QuntityCount

            };

            return wcfNailBase;
        }
        public static BllNailPolish ConvertPolishToBLL(NailPolishWCF wcfPolish)
        {
            BllNailPolish bllNailPolish = new BllNailPolish()
            {
                 Id = wcfPolish.Id,
                Name = wcfPolish.Name,
                Brand = wcfPolish.Brand,
                Price = wcfPolish.Price,
                Volume = wcfPolish.Volume,
                QuantityBottles = wcfPolish.QuantityBottles,
                QuantityGeneralVolume = wcfPolish.QuantityGeneralVolume,
                Color = wcfPolish.Color,
                QuntityCount = wcfPolish.QuntityCount

            };

            return bllNailPolish;
        }
        public static NailPolishWCF ConvertPolishToWcf(BllNailPolish bllNailPolish)
        {
            NailPolishWCF wcfPolish = new NailPolishWCF()
            {
                Id = bllNailPolish.Id,
                Name = bllNailPolish.Name,
                Brand = bllNailPolish.Brand,
                Price = bllNailPolish.Price,
                Volume = bllNailPolish.Volume,
                QuantityBottles = bllNailPolish.QuantityBottles,
                QuantityGeneralVolume = bllNailPolish.QuantityGeneralVolume,
                Color = bllNailPolish.Color,
                QuntityCount = bllNailPolish.QuntityCount

            };

            return wcfPolish;
        }
        public static BllNailTop ConvertTopTOBLL(NailTopWCF wcfNailTop)
        {
            BllNailTop bllNailTop = new BllNailTop()
            {
                Id = wcfNailTop.Id,
                Name = wcfNailTop.Name,
                Brand = wcfNailTop.Brand,
                Price = wcfNailTop.Price,
                Volume = wcfNailTop.Volume,
                QuantityBottles = wcfNailTop.QuantityBottles,
                QuantityGeneralVolume = wcfNailTop.QuantityGeneralVolume,
                QuntityCount = wcfNailTop.QuntityCount

            };

            return bllNailTop;
        }
        public static NailTopWCF ConvertTopToWcf(BllNailTop bllNailTop)
        {
            NailTopWCF wcfNailTop = new NailTopWCF()
            {
                Id = bllNailTop.Id,
                Name = bllNailTop.Name,
                Brand = bllNailTop.Brand,
                Price = bllNailTop.Price,
                Volume = bllNailTop.Volume,
                QuantityBottles = bllNailTop.QuantityBottles,
                QuantityGeneralVolume = bllNailTop.QuantityGeneralVolume,
                QuntityCount = bllNailTop.QuntityCount

            };

            return wcfNailTop;
        }
        public static BllPowder ConvertPowderToBll(PowderWCF wcfPowder)
        {
            BllPowder bllPowder = new BllPowder()
            {
                Id = wcfPowder.Id,
                Name = wcfPowder.Name,
                Brand = wcfPowder.Brand,
                Price = wcfPowder.Price,
                Volume = wcfPowder.Volume,
                QuantityBottles = wcfPowder.QuantityBottles,
                QuantityGeneralVolume = wcfPowder.QuantityGeneralVolume,
                Color = wcfPowder.Color,
                QuntityCount = wcfPowder.QuntityCount

            };

            return bllPowder;
        }
        public static PowderWCF ConvertPowderToWCF(BllPowder bllPowder)
        {
            PowderWCF wcfpowder = new PowderWCF()
            {
                Id = bllPowder.Id,
                Name = bllPowder.Name,
                Brand = bllPowder.Brand,
                Price = bllPowder.Price,
                Volume = bllPowder.Volume,
                QuantityBottles = bllPowder.QuantityBottles,
                QuantityGeneralVolume = bllPowder.QuantityGeneralVolume,
                Color = bllPowder.Color,
                QuntityCount = bllPowder.QuntityCount

            };

            return wcfpowder;
        }
        public static BllShadows ConvertShadowToBll(ShadowsWCF wcfShadows)
        {
            BllShadows bllShadows = new BllShadows()
            {
                Id = wcfShadows.Id,
                Name = wcfShadows.Name,
                Brand = wcfShadows.Brand,
                Price = wcfShadows.Price,
                Volume = wcfShadows.Volume,
                QuantityBottles = wcfShadows.QuantityBottles,
                QuantityGeneralVolume = wcfShadows.QuantityGeneralVolume,
                Color = wcfShadows.Color,
                QuntityCount = wcfShadows.QuntityCount

            };

            return bllShadows;
        }
        public static ShadowsWCF ConvertShadowToWcf(BllShadows bllShadows)
        {
            ShadowsWCF wcfShadows = new ShadowsWCF()
            {
                Id = bllShadows.Id,
                Name = bllShadows.Name,
                Brand = bllShadows.Brand,
                Price = bllShadows.Price,
                Volume = bllShadows.Volume,
                QuantityBottles = bllShadows.QuantityBottles,
                QuantityGeneralVolume = bllShadows.QuantityGeneralVolume,
                Color = bllShadows.Color,
                QuntityCount = bllShadows.QuntityCount

            };

            return wcfShadows;
        }
        public static BllShampoo ConvertShampoToBLL(ShampooWCF wcfShampoo)
        {
            BllShampoo bllShampoo = new BllShampoo()
            {
                Id = wcfShampoo.Id,
                Name = wcfShampoo.Name,
                Brand = wcfShampoo.Brand,
                Price = wcfShampoo.Price,
                Volume = wcfShampoo.Volume,
                QuantityBottles = wcfShampoo.QuantityBottles,
                QuantityGeneralVolume = wcfShampoo.QuantityGeneralVolume,
                Description = wcfShampoo.Description,
                QuntityCount = wcfShampoo.QuntityCount,

            };

            return bllShampoo;
        }
        public static ShampooWCF ConvertShampooToWCF(BllShampoo bllShampoo)
        {
            ShampooWCF wcfShampoo = new ShampooWCF()
            {
                Id = bllShampoo.Id,
                Name = bllShampoo.Name,
                Brand = bllShampoo.Brand,
                Price = bllShampoo.Price,
                Volume = bllShampoo.Volume,
                QuantityBottles = bllShampoo.QuantityBottles,
                QuantityGeneralVolume = bllShampoo.QuantityGeneralVolume,
                Description = bllShampoo.Description,
                QuntityCount = bllShampoo.QuntityCount
            };

            return wcfShampoo;
        }

        // materials
        public static MaterialsWCF ConvertWcfMaterials(BllMaterials tmpMaterial)
        {
            MaterialsWCF getmaterial = null;
            if (tmpMaterial is BllBalsam)
            {
                getmaterial = ConvertBalsamToWcf(tmpMaterial as BllBalsam);
            }
            else if (tmpMaterial is BllShampoo)
            {
                getmaterial = ConvertShampooToWCF(tmpMaterial as BllShampoo);
            }
            else if (tmpMaterial is BllLaque)
            {
                getmaterial = ConvertLaqueToWcf(tmpMaterial as BllLaque);
            }
            else if (tmpMaterial is BllColor)
            {
                getmaterial = ConvertColorToWcf(tmpMaterial as BllColor);
            }
            else if (tmpMaterial is BllPowder)
            {
                getmaterial = ConvertPowderToWCF(tmpMaterial as BllPowder);
            }
            else if (tmpMaterial is BllFoundation)
            {
                getmaterial = ConvertFoundationTowcf(tmpMaterial as BllFoundation);
            }
            else if (tmpMaterial is BllMascara)
            {
                getmaterial = ConvertMascaraToWcf(tmpMaterial as BllMascara);
            }
            else if (tmpMaterial is BllLipstick)
            {
                getmaterial = ConvertLipstickTowcf(tmpMaterial as BllLipstick);
            }
            else if (tmpMaterial is BllShadows)
            {
                getmaterial = ConvertShadowToWcf(tmpMaterial as BllShadows);
            }
            else if (tmpMaterial is BllNailBase)
            {
                getmaterial = ConvertBaseToWCF(tmpMaterial as BllNailBase);
            }
            else if (tmpMaterial is BllNailTop)
            {
                getmaterial = ConvertTopToWcf(tmpMaterial as BllNailTop);
            }
            else if (tmpMaterial is BllNailPolish)
            {
                getmaterial = ConvertPolishToWcf(tmpMaterial as BllNailPolish);
            }
            return getmaterial;
        }

        public static WriteOffMaterialBll ConvertWriteOffToBD(WriteOffMaterialsWCF writeOffMaterialwcf)
        {
            WriteOffMaterialBll writeOffMaterial = new WriteOffMaterialBll()
            {
                UsedQuantity = writeOffMaterialwcf.UsedQuantity,
                Material = ConvertMaterialsToDB(writeOffMaterialwcf.Material)
            };
            return writeOffMaterial;
        }

        public static BllMaterials ConvertMaterialsToDB(MaterialsWCF tmpMaterial)
        {
            GetFunctions get = new GetFunctions();
            BllMaterials getmaterial = null;
            if (tmpMaterial is BalsamWCF)
            {
                getmaterial = ConvertBalsamToBll(tmpMaterial as BalsamWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "HairCut" || x.Name == "HairColoring").ToList();
            }
            else if (tmpMaterial is ShampooWCF)
            {
                getmaterial = ConvertShadowToBll(tmpMaterial as ShadowsWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "HairCut" || x.Name == "HairColoring").ToList();
            }
            else if (tmpMaterial is LaqueWCF)
            {
                getmaterial = ConvertLaqueToBll(tmpMaterial as LaqueWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "HairCut" || x.Name == "HairColoring").ToList();
            }
            else if (tmpMaterial is ColorWCF)
            {
                getmaterial = ConvertColorToBll(tmpMaterial as ColorWCF);
                getmaterial.BllServices = get.GetListServices().Where(x =>  x.Name == "HairColoring").ToList();
            }
            else if (tmpMaterial is PowderWCF)
            {
                getmaterial = ConvertPowderToBll(tmpMaterial as PowderWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "MakeUp").ToList();
            }
            else if (tmpMaterial is FoundationWCF)
            {
                getmaterial = ConvertFoundationToBll(tmpMaterial as FoundationWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "MakeUp").ToList();
            }
            else if (tmpMaterial is MascaraWCF)
            {
                getmaterial = ConvertMascaraToBll(tmpMaterial as MascaraWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "MakeUp").ToList();
            }
            else if (tmpMaterial is LipstickWCF)
            {
                getmaterial = ConvertLipstickToBLL(tmpMaterial as LipstickWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "MakeUp").ToList();
            }
            else if (tmpMaterial is ShadowsWCF)
            {
                getmaterial = ConvertShadowToBll(tmpMaterial as ShadowsWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "MakeUp").ToList();
            }
            else if (tmpMaterial is NailBaseWCF)
            {
                getmaterial = ConvertBaseToBll(tmpMaterial as NailBaseWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "Manicure").ToList();
            }
            else if (tmpMaterial is NailTopWCF)
            {
                getmaterial = ConvertTopTOBLL(tmpMaterial as NailTopWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "Manicure").ToList();

            }
            else if (tmpMaterial is NailPolishWCF)
            {
                getmaterial = ConvertPolishToBLL(tmpMaterial as NailPolishWCF);
                getmaterial.BllServices = get.GetListServices().Where(x => x.Name == "Manicure").ToList();

            }
            return getmaterial;
        }
    }
}