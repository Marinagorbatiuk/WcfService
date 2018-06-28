using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class InfoWCF
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Action { get; set; }
        [DataMember]
        public DateTime ActionTime { get; set; }
        [DataMember]
        public string InputParameters { get; set; }
        [DataMember]
        public string OutputParameters { get; set; }
    }
}