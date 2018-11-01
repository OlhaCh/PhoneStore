﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public UserDTO User { get; set; }
        [DataMember]
        public PhoneDTO Phone { get; set; }

    }
}
