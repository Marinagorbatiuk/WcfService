﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
  public  interface IWCFUpdate
    {
      void  UpdateMaterials(MaterialsWCF materialsWCF);
    }
}
