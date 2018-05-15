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
     public static BllStaff ConvertStaffToBll(Staff dTODallStaff)
     {
         BllStaff bllStaff = new BllStaff()
         {
             Login= dTODallStaff.Login,
             Password= dTODallStaff.Password,
            WorkPosition = new BllWorkPosition
            {
                Name = dTODallStaff.WorkPosition.Name,
                Id =dTODallStaff.WorkPosition.Id
            },
            Id = dTODallStaff.Id
         };
      
         return bllStaff;
     }

        public static BllStaff ConvertStaffToBllpartial(Staff dTODallStaff)
        {
            BllStaff bllStaff = new BllStaff()
            {
                Login = dTODallStaff.Login,
                Password = dTODallStaff.Password,
               
                Id = dTODallStaff.Id
            };

            return bllStaff;
        }
        public static Staff ConvertStaffToDTO(BllStaff bllStaff)
        {
            Staff dTODallStaff = new Staff()
            {
                Login = bllStaff.Login,
            Password=bllStaff.Password,
            WorkPosition= new WorkPosition
            {
                Id =bllStaff.WorkPosition.Id,
                Name= bllStaff.WorkPosition.Name
            }
            };
            
            return dTODallStaff;
        }

        public static BllWorkPosition ConvertPositionToBll(WorkPosition WorkPosition)
        {
            BllWorkPosition bllWorkPosition = new BllWorkPosition()
            { Name = WorkPosition.Name,
                Id = WorkPosition.Id,
            };
            bllWorkPosition.Staff = new List<BllStaff>();
            foreach(var item in WorkPosition.Staff)
            {
                bllWorkPosition.Staff.Add
                    (
                    new BllStaff
                    {
                        Id =item.Id,
                        Login = item.Login,
                        Password = item.Password                        
                    }
                    );
            } 
            return bllWorkPosition;
        }
        public static WriteOffMaterial ConvertWriteOffToBD(WriteOffMaterialBll writeOffMaterialBll)
        {
           WriteOffMaterial writeOffMaterial = new WriteOffMaterial()
            {
                UsedQuantity= writeOffMaterialBll.UsedQuantity,
                Material = ConvertMaterialsToDB(writeOffMaterialBll.Material)
            };
            return writeOffMaterial;
        }

        public static WorkPosition ConvertPositionToDTO(BllWorkPosition bllWorkPosition)
        {
            WorkPosition dTODalWorkPosition = new WorkPosition()
            {
                Name=bllWorkPosition.Name,
                Id= bllWorkPosition.Id
            };

          
            return dTODalWorkPosition;
        }
        public static BllServices ConvertServicesToBll(Service dTODalService)
        {
            BllServices bllServices = new BllServices()
            {
                Name=dTODalService.Name,
                Price= dTODalService.Price,
                Id=dTODalService.Id,
                //BllMaterials=dTODalService.Id
            };
       
            return bllServices;
        }
        public static Service ConvertServicesToDTO(BllServices bllServices)
        {
            Service dTODalService = new Service()
            {
                Name= bllServices.Name,
                Price= bllServices.Price,
                Id=bllServices.Id,
               // Materials=bllServices.BllMaterials
            };
      
            return dTODalService;
        }
        public static BllBalsam ConvertBalsamToBll(Balsam Balsam)
        {
            BllBalsam bllBalsam = new BllBalsam()
            {
                Name = Balsam.Name,
                Brand = Balsam.Brand,
                Price= Balsam.Price,
                QuantityBottles= Balsam.QuantityBottles,
                QuantityGeneralVolume= Balsam.QuantityGeneralVolume,
                Volume= Balsam.Volume,
                Id=Balsam.Id,
                QuntityCount = Balsam.QuntityCount
            };
        
            return bllBalsam;
        }
        public static Balsam ConvertBalsamToDTO(BllBalsam bllBalsam)
        {
            Balsam dTOBalsam = new Balsam()
            {
                Name= bllBalsam.Name,
                Brand = bllBalsam.Brand,
                Price=bllBalsam.Price,
                QuantityBottles=bllBalsam.QuantityBottles,
                QuantityGeneralVolume= bllBalsam.QuantityGeneralVolume,
                Volume = bllBalsam.Volume,
                Id= bllBalsam.Id,
                QuntityCount= bllBalsam.QuntityCount
            };
        
            return dTOBalsam;
        }
        public static BllColor ConvertColorToBll(HairColor dTOColor)
        {
            BllColor bllColor = new BllColor()
            {Id=dTOColor.Id,
            Name=dTOColor.Name,
            Brand=dTOColor.Brand,
            Price=dTOColor.Price,
            Color=dTOColor.Color,
            Volume=dTOColor.Volume,
            QuantityBottles=dTOColor.QuantityBottles,
            QuantityGeneralVolume=dTOColor.QuantityGeneralVolume,
            Description=dTOColor.Description,
            QuntityCount= dTOColor.QuntityCount
            };            
            return bllColor;
        }
        public static HairColor ConvertColorToDTO(BllColor bllColor)
        {
            HairColor dTOColor = new HairColor()
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
                QuntityCount= bllColor.QuntityCount
            };
           
            return dTOColor;
        }
        public static BllFoundation ConvertFoundationToBll(Foundation dTOFoundation)
        {
            BllFoundation bllFoundation = new BllFoundation()
            {
                Id = dTOFoundation.Id,
                Name = dTOFoundation.Name,
                Brand = dTOFoundation.Brand,
                Price = dTOFoundation.Price,
                Color = dTOFoundation.Color,
                Volume = dTOFoundation.Volume,
                QuantityBottles = dTOFoundation.QuantityBottles,
                QuantityGeneralVolume = dTOFoundation.QuantityGeneralVolume,
                Description = dTOFoundation.Description,
                QuntityCount= dTOFoundation.QuntityCount
            };
         
            return bllFoundation;
        }
        public static Foundation ConvertFoundationToDTO(BllFoundation bllFoundation)
        {
            Foundation dTOFoundation = new Foundation()
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

            return dTOFoundation;
        }
        public static BllLaque ConvertLaqueToBll(Laque dTOLaque)
        {
            BllLaque bllLaque = new BllLaque()
            {
                Id = dTOLaque.Id,
                Name = dTOLaque.Name,
                Brand = dTOLaque.Brand,
                Price = dTOLaque.Price,              
                Volume = dTOLaque.Volume,
                QuantityBottles = dTOLaque.QuantityBottles,
                QuantityGeneralVolume = dTOLaque.QuantityGeneralVolume,
               QuntityCount= dTOLaque.QuntityCount
            };
                    
            return bllLaque;
        }
        public static Laque ConvertLaqueToDTO(BllLaque bllLaque)
        {
            Laque dTOLaque = new Laque()
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
        
            return dTOLaque;
        }
        public static BllLipstick ConvertLipstickToBLL(Lipstick dTOLipstick)
        {
            BllLipstick bllLipstick = new BllLipstick()
            {
                Id = dTOLipstick.Id,
                Name = dTOLipstick.Name,
                Brand = dTOLipstick.Brand,
                Price = dTOLipstick.Price,
                Color = dTOLipstick.Color,
                Volume = dTOLipstick.Volume,
                QuantityBottles = dTOLipstick.QuantityBottles,
                QuantityGeneralVolume = dTOLipstick.QuantityGeneralVolume,
                Description = dTOLipstick.Description,
                QuntityCount = dTOLipstick.QuntityCount
            };
            
            return bllLipstick;
        }
        public static Lipstick ConvertLipstickToDTO(BllLipstick bllLipstick)
        {
            Lipstick dTOLipstick = new Lipstick()
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
            return dTOLipstick;
        }
        public static BllMascara ConvertMascaraToBll(Mascara dTOMascara)
        {
            BllMascara bllMascara = new BllMascara()
            {
                Id = dTOMascara.Id,
                Name = dTOMascara.Name,
                Brand = dTOMascara.Brand,
                Price = dTOMascara.Price,
                Color = dTOMascara.Color,
                Volume = dTOMascara.Volume,
                QuantityBottles = dTOMascara.QuantityBottles,
                QuantityGeneralVolume = dTOMascara.QuantityGeneralVolume,
                QuntityCount = dTOMascara.QuntityCount
            };
  
            return bllMascara;
        }
        public static Mascara ConvertMascaraToDTO(BllMascara bllMascara)
        {
            Mascara dTOMascara = new Mascara() {
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
            
            return dTOMascara;
        }
        public static BllNailBase ConvertBaseToBll(NailBase dTONailBase)
        {
            BllNailBase bllNailBase = new BllNailBase()
            {
                Id = dTONailBase.Id,
                Name = dTONailBase.Name,
                Brand = dTONailBase.Brand,
                Price = dTONailBase.Price,
                Volume = dTONailBase.Volume,
                QuantityBottles = dTONailBase.QuantityBottles,
                QuantityGeneralVolume = dTONailBase.QuantityGeneralVolume,
                QuntityCount = dTONailBase.QuntityCount
            };
            
            return bllNailBase;
        }
        public static NailBase ConvertBaseToDTO(BllNailBase bllNailBase)
        {
            NailBase dTONailBase = new NailBase()
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
            
            return dTONailBase;
        }
        public static BllNailPolish ConvertPolishToBLL(NailPolish dTOPolish)
        {
            BllNailPolish bllNailPolish = new BllNailPolish()
            {
                Id = dTOPolish.Id,
                Name = dTOPolish.Name,
                Brand = dTOPolish.Brand,
                Price = dTOPolish.Price,
                Volume = dTOPolish.Volume,
                QuantityBottles = dTOPolish.QuantityBottles,
                QuantityGeneralVolume = dTOPolish.QuantityGeneralVolume,
                Color = dTOPolish.Color,
                QuntityCount= dTOPolish.QuntityCount
            };
      
            return bllNailPolish;
        }
        public static NailPolish ConvertPolishToDTO(BllNailPolish bllNailPolish)
        {
            NailPolish dTOPolish = new NailPolish()
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
      
            return dTOPolish;
        }
        public static BllNailTop ConvertTopTOBLL(NailTop dTONailTop)
        {
            BllNailTop bllNailTop = new BllNailTop()
            {
                Id = dTONailTop.Id,
                Name = dTONailTop.Name,
                Brand = dTONailTop.Brand,
                Price = dTONailTop.Price,
                Volume = dTONailTop.Volume,
                QuantityBottles = dTONailTop.QuantityBottles,
                QuantityGeneralVolume = dTONailTop.QuantityGeneralVolume,
              QuntityCount = dTONailTop.QuntityCount
            };
         
            return bllNailTop;
        }
        public static NailTop ConvertTopToDTO(BllNailTop bllNailTop)
        {
            NailTop dTONailTop = new NailTop()
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
            
            return dTONailTop;
        }
        public static BllPowder ConvertPowderToBll(Powder dTOPowder)
        {
            BllPowder bllPowder = new BllPowder()
            {
                Id = dTOPowder.Id,
                Name = dTOPowder.Name,
                Brand = dTOPowder.Brand,
                Price = dTOPowder.Price,
                Volume = dTOPowder.Volume,
                QuantityBottles = dTOPowder.QuantityBottles,
                QuantityGeneralVolume = dTOPowder.QuantityGeneralVolume,
                Color = dTOPowder.Color,
                QuntityCount = dTOPowder.QuntityCount
            };
           
            return bllPowder;
        }
        public static Powder ConvertPowderToDTO(BllPowder bllPowder)
        {
            Powder dTOPowder = new Powder()
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
        
            return dTOPowder;
        }
        public static BllShadows ConvertShadowToBll(Shadows dTOShadows)
        {
            BllShadows bllShadows = new BllShadows()
            {
                Id = dTOShadows.Id,
                Name = dTOShadows.Name,
                Brand = dTOShadows.Brand,
                Price = dTOShadows.Price,
                Volume = dTOShadows.Volume,
                QuantityBottles = dTOShadows.QuantityBottles,
                QuantityGeneralVolume = dTOShadows.QuantityGeneralVolume,
                Color = dTOShadows.Color,
                QuntityCount = dTOShadows.QuntityCount
            };
            
            return bllShadows;
        }
        public static Shadows ConvertShadowToDTO(BllShadows bllShadows)
        {
            Shadows dTOShadows = new Shadows()
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
         
            return dTOShadows;
        }
        public static BllShampoo ConvertShampoToBLL(Shampoo dTOShampoo)
        {
            BllShampoo bllShampoo = new BllShampoo()
            {
                Id = dTOShampoo.Id,
                Name = dTOShampoo.Name,
                Brand = dTOShampoo.Brand,
                Price = dTOShampoo.Price,
                Volume = dTOShampoo.Volume,
                QuantityBottles = dTOShampoo.QuantityBottles,
                QuantityGeneralVolume = dTOShampoo.QuantityGeneralVolume,
               Description = dTOShampoo.Description,
               QuntityCount = dTOShampoo.QuntityCount
            };
        
            return bllShampoo;
        }
        public static Shampoo ConvertShampooToDTO(BllShampoo bllShampoo)
        {
            Shampoo dTOShampoo = new Shampoo()
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
            return dTOShampoo;
        }

        // materials
        public static BllMaterials ConvertBllMaterials(Material tmpMaterial)
        {
            BllMaterials getmaterial = null;
            if (tmpMaterial is Balsam)
            {
                getmaterial = ConvertBalsamToBll(tmpMaterial as Balsam);
            }
            else if (tmpMaterial is Shampoo)
            {
                getmaterial = ConvertShampoToBLL(tmpMaterial as Shampoo);
            }
            else if (tmpMaterial is Laque)
            {
                getmaterial = ConvertLaqueToBll(tmpMaterial as Laque);
            }
            else if (tmpMaterial is HairColor)
            {
                getmaterial = ConvertColorToBll(tmpMaterial as HairColor);
            }
            else if (tmpMaterial is Powder)
            {
                getmaterial = ConvertPowderToBll(tmpMaterial as Powder);
            }
            else if (tmpMaterial is Foundation)
            {
                getmaterial = ConvertFoundationToBll(tmpMaterial as Foundation);
            }
            else if (tmpMaterial is Mascara)
            {
                getmaterial =ConvertMascaraToBll(tmpMaterial as Mascara);
            }
            else if (tmpMaterial is Lipstick)
            {
                getmaterial = ConvertLipstickToBLL(tmpMaterial as Lipstick);
            }
            else if (tmpMaterial is Shadows)
            {
                getmaterial = ConvertShadowToBll(tmpMaterial as Shadows);
            }
            else if (tmpMaterial is NailBase)
            {
                getmaterial = ConvertBaseToBll(tmpMaterial as NailBase);
            }
            else if (tmpMaterial is NailTop)
            {
                getmaterial =ConvertTopTOBLL(tmpMaterial as NailTop);
            }
            else if (tmpMaterial is NailPolish)
            {
                getmaterial = ConvertPolishToBLL(tmpMaterial as NailPolish);
            }
            return getmaterial;
        }

        public static Material ConvertMaterialsToDB(BllMaterials tmpMaterial)
        {
            Material getmaterial = null;
            if (tmpMaterial is BllBalsam)
            {
                getmaterial = ConvertBalsamToDTO(tmpMaterial as BllBalsam);
            }
            else if (tmpMaterial is BllShampoo)
            {
                getmaterial = ConvertShampooToDTO(tmpMaterial as BllShampoo);
            }
            else if (tmpMaterial is BllLaque)
            {
                getmaterial = ConvertLaqueToDTO(tmpMaterial as BllLaque);
            }
            else if (tmpMaterial is BllColor)
            {
                getmaterial = ConvertColorToDTO(tmpMaterial as BllColor);
            }
            else if (tmpMaterial is BllPowder)
            {
                getmaterial = ConvertPowderToDTO(tmpMaterial as BllPowder);
            }
            else if (tmpMaterial is BllFoundation)
            {
                getmaterial = ConvertFoundationToDTO(tmpMaterial as BllFoundation);
            }
            else if (tmpMaterial is BllMascara)
            {
                getmaterial = ConvertMascaraToDTO(tmpMaterial as BllMascara);
            }
            else if (tmpMaterial is BllLipstick)
            {
                getmaterial = ConvertLipstickToDTO(tmpMaterial as BllLipstick);
            }
            else if (tmpMaterial is BllShadows)
            {
                getmaterial = ConvertShadowToDTO(tmpMaterial as BllShadows);
            }
            else if (tmpMaterial is BllNailBase)
            {
                getmaterial = ConvertBaseToDTO(tmpMaterial as BllNailBase);
            }
            else if (tmpMaterial is BllNailTop)
            {
                getmaterial = ConvertTopToDTO(tmpMaterial as BllNailTop);
            }
            else if (tmpMaterial is BllNailPolish)
            {
                getmaterial = ConvertPolishToDTO(tmpMaterial as BllNailPolish);
            }
            return getmaterial;
        }

    }
}
