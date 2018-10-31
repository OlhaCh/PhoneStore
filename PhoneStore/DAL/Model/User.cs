using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
