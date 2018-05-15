using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    public class WriteOffMaterialsWCF
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int UsedQuantity { get; set; }
        [DataMember]
        public virtual MaterialsWCF Material { get; set; }
    }
}