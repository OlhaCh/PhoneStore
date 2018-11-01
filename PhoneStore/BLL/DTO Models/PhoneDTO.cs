using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [DataContract]
    public class PhoneDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public double Cost { get; set; }
    }
}
