﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class StaffWCF
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }

        [DataMember] 

        public WorkPositionWCF WorkPosition { get; set; }
    }
}