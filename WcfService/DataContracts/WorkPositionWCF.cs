using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class WorkPositionWCF
    {
        [DataMember]
        public string Name { get; set; }
        // public virtual ICollection<BllStaff> Staff { get; set; }
    }
}