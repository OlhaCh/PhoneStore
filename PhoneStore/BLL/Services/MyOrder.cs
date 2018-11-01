using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLL
{
    public class MyOrder : IOrderDTO
    {
        public OrderDTO GetByNick(UserDTO user)
        {
            
            return null;
        }

        public IEnumerable<OrderDTO> GetOrder()
        {
            List<OrderDTO> orders = new List<OrderDTO>();

            return orders;
           
        }
    }
}
