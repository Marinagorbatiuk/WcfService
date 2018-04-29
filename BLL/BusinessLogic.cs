﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace BLL
{
    class BusinessLogic
    {
        public BllWorkPosition GetUser( string login, string password)
        {
            BllWorkPosition workPosition = null;
            DalFunction dalFunction = new DalFunction();
            Staff staff = dalFunction.GetUser(login, password);

            if (staff != null)
            {
               // workPosition = ConvertationsBLL.ConvertPositionToBll(dalFunction.GetOneWorkPosition(staff.Id));
            }
            return workPosition;
        }

        public List<BllWorkPosition> GetListPositions()
        {
            DalFunction function = new DalFunction();
            List<BllWorkPosition> positions = new List<BllWorkPosition>();
            foreach (var item in function.GetWorkPosition())
            {
                //positions.Add(ConvertationsBLL.ConvertPositionToBll(item));
            }

            return positions;
        }

        public List<BllShampoo> GetListShampoo()
        {
            DalFunction function = new DalFunction();
            List<BllShampoo> bllShampoosList = new List<BllShampoo>();
          
            bllShampoosList = function.GetShampoo().Select(x => ConvertationsBLL.ConvertShampoToBLL(x)).ToList();

            return bllShampoosList;
        }
        public List<BllBalsam> GetListBalsam()
        {
            DalFunction function = new DalFunction();
            List<BllBalsam> bllBalsamList = new List<BllBalsam>();

            bllBalsamList = function.GetBalsam().Select(x => ConvertationsBLL.ConvertBalsamToBll(x)).ToList();

            return bllBalsamList;
        }
        public List<BllColor> GetListColor()
        {
            DalFunction function = new DalFunction();
            List<BllColor> bllBaColorList = new List<BllColor>();

            bllBaColorList = function.GetColor().Select(x => ConvertationsBLL.ConvertColorToBll(x)).ToList();

            return bllBaColorList;
        }
        public List<BllFoundation> GetListFoundation()
        {
            DalFunction function = new DalFunction();
            List<BllFoundation> bllBaFoundationList = new List<BllFoundation>();

            bllBaFoundationList = function.GetFoundation().Select(x => ConvertationsBLL.ConvertFoundationToBll(x)).ToList();

            return bllBaFoundationList;
        }

        public List<BllLaque> GetListLaque()
        {
            DalFunction function = new DalFunction();
            List<BllLaque> bllBaLaqueList = new List<BllLaque>();

            bllBaLaqueList = function.GetLaque().Select(x => ConvertationsBLL.ConvertLaqueToBll(x)).ToList();

            return bllBaLaqueList;
        }
        public List<BllLipstick> GetListLipstick()
        {
            DalFunction function = new DalFunction();
            List<BllLipstick> bllBaLipstickList = new List<BllLipstick>();

            bllBaLipstickList = function.GetLipstick().Select(x => ConvertationsBLL.ConvertLipstickToBLL(x)).ToList();

            return bllBaLipstickList;
        }
        public List<BllMascara> GetListMascara()
        {
            DalFunction function = new DalFunction();
            List<BllMascara> bllBaMascaraList = new List<BllMascara>();

            bllBaMascaraList = function.GetMascara().Select(x => ConvertationsBLL.ConvertMascaraToBll(x)).ToList();

            return bllBaMascaraList;
        }
        public List<BllNailBase> GetListNailBase()
        {
            DalFunction function = new DalFunction();
            List<BllNailBase> bllBaseList = new List<BllNailBase>();

            bllBaseList = function.GetNailBase().Select(x => ConvertationsBLL.ConvertBaseToBll(x)).ToList();

            return bllBaseList;
        }

        public List<BllNailPolish> GetListNailPolish()
        {
            DalFunction function = new DalFunction();
            List<BllNailPolish> bllPolishList = new List<BllNailPolish>();

            bllPolishList = function.GetNailPolish().Select(x => ConvertationsBLL.ConvertPolishToBLL(x)).ToList();

            return bllPolishList;
        }
        public List<BllNailTop> GetListNailTop()
        {
            DalFunction function = new DalFunction();
            List<BllNailTop> bllTopList = new List<BllNailTop>();

            bllTopList = function.GetNailTop().Select(x => ConvertationsBLL.ConvertTopTOBLL(x)).ToList();

            return bllTopList;
        }
        public List<BllPowder> GetListPowder()
        {
            DalFunction function = new DalFunction();
            List<BllPowder> bllPowderList = new List<BllPowder>();

            bllPowderList = function.GetPowder().Select(x => ConvertationsBLL.ConvertPowderToBll(x)).ToList();

            return bllPowderList;
        }
        public List<BllShadows> GetListShadow()
        {
            DalFunction function = new DalFunction();
            List<BllShadows> bllShadowList = new List<BllShadows>();

            bllShadowList = function.GetShadow().Select(x => ConvertationsBLL.ConvertShadowToBll(x)).ToList();

            return bllShadowList;
        }
        public void DeleteFromGrid(int id)
        {
            DalFunction function = new DalFunction();
            function.Delete(id);
        }

    }
}