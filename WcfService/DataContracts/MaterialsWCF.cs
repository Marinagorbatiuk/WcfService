using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]

    [KnownType (typeof(WriteOffMaterialsWCF))]
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
    public class MaterialsWCF
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]        
        public string Name { get; set; }
        [DataMember]        
        public string Brand { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public double Volume { get; set; }
        [DataMember]
        public int QuantityBottles { get; set; }
        [DataMember]
        public double QuantityGeneralVolume { get; set; }
        [DataMember]
        public ICollection<ServicesWCF> BllServices { get; set; }
        [DataMember]
        public double QuntityCount { get; set; }
    }
    [DataContract]
    public class BalsamWCF : MaterialsWCF { }
    [DataContract]
    public class ColorWCF : MaterialsWCF
    {
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Color { get; set; }
    }
    [DataContract]
    public class FoundationWCF : MaterialsWCF
    {
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Color { get; set; }
    }
    [DataContract]
    public class LaqueWCF : MaterialsWCF { }
    [DataContract]
    public class LipstickWCF : MaterialsWCF
    {
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Color { get; set; }
    }
    [DataContract]
    public class MascaraWCF : MaterialsWCF
    {
        [DataMember]
        public string Color { get; set; }
    }
    [DataContract]
    public class NailBaseWCF : MaterialsWCF { }
  [DataContract]
    public class NailPolishWCF : MaterialsWCF
    {
        [DataMember]
        public string Color { get; set; }
    }
    [DataContract]
    public class NailTopWCF : MaterialsWCF { }    
    [DataContract]
    public class PowderWCF : MaterialsWCF
    {
        [DataMember]
        public string Color { get; set; }
    }
    [DataContract]
    public class ShadowsWCF : MaterialsWCF
    {
        [DataMember]
        public string Color { get; set; }
    }
    [DataContract]
    public class ShampooWCF : MaterialsWCF
    {
        [DataMember]
        public string Description { get; set; }
    }
}