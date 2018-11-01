using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [DataContract]
    public class UserDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string NickName { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}
