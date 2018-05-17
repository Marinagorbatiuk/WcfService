using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{

    [DataContract]
    [KnownType(typeof(MaterialsWCF))]
    [KnownType(typeof(ShadowsWCF))]
    [KnownType(typeof(BalsamWCF))]
    [KnownType(typeof(ShampooWCF))]
    [KnownType(typeof(LaqueWCF))]
    [KnownType(typeof(ColorWCF))]
    [KnownType(typeof(FoundationWCF))]
    [KnownType(typeof(PowderWCF))]
    [KnownType(typeof(MascaraWCF))]
    [KnownType(typeof(LipstickWCF))]
    [KnownType(typeof(NailTopWCF))]
    [KnownType(typeof(NailPolishWCF))]
    [KnownType(typeof(NailBaseWCF))]
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