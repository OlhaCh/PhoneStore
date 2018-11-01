using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Mapping;
using DAL;


namespace BLL
{
    public class MyOrder : IOrderDTO
    {
        public OrderDTO GetByNick(UserDTO userDTO)
        {
            Repository<Order> orders = new Repository<Order>(new Context());//DAL CRUD
            var user = Mapper.GetUserFromDTO(userDTO);
            var order = orders.GetAll().FirstOrDefault(x => x.user == user);
            return Mapper.GetDTOFromOrder(order);
        }

       
        public List<UserDTO> GetUsers()
        {
            
            Repository<User> repository = new Repository<User>(new Context());
            List<UserDTO> users = new List<UserDTO>();
            foreach(var item in repository.GetAll())
            {
                users.Add(Mapper.GetDTOFromUser(item));
            }
            return users;
           
        }

        public List<PhoneDTO> GetPhones()
        {
            Repository<Phone> repository = new Repository<Phone>(new Context());
            List<PhoneDTO> phones = new List<PhoneDTO>();
            foreach (var item in repository.GetAll())
            {
                phones.Add(Mapper.GetDTOFromPhone(item));
            }

            return phones;
        }
        
    }
}
