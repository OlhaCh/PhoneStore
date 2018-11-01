using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapping
{
    public static class Mapper
    {

        //PHONE
        public static PhoneDTO GetDTOFromPhone(Phone p)
        {
            return new PhoneDTO
            {
                ID = p.ID,
                Name = p.Name,
                Model = p.Model,
                Cost = p.Cost
            };
        }

        public static Phone GetPhoneFromDTO(PhoneDTO p)
        {
            return new Phone
            {
                ID = p.ID,
                Name = p.Name,
                Model = p.Model,
                Cost = p.Cost
            };
        }

        //USER
        public static UserDTO GetDTOFromUser(User u )
        {
            return new UserDTO
            {
                ID=u.ID,
                NickName=u.NickName,
                Email=u.Email
            };
        }

        public static User GetUserFromDTO(UserDTO u)
        {
            return new User
            {
                ID = u.ID,
                NickName = u.NickName,
                Email = u.Email
            };
        }

        //ORDER
        public static OrderDTO GetDTOFromOrder(Order o)
        {
            return new OrderDTO
            {
                ID = o.ID,
                Phone = GetDTOFromPhone(o.phone),
                User = GetDTOFromUser(o.user)
            };

        }

        public static Order GetOrderFromDTO(OrderDTO o)
        {
            return new Order
            {
                ID = o.ID,
                phone = GetPhoneFromDTO(o.Phone),
                user = GetUserFromDTO(o.User)
            };

        }


    }
}
