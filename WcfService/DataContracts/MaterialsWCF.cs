using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class MaterialsWCF
    {
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
        // collection
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