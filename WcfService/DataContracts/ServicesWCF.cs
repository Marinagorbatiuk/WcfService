using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class ServicesWCF
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        // collection 
    }
}