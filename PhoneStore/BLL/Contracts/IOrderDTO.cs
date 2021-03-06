﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   [ServiceContract]
   public interface IOrderDTO
    {
        [OperationContract]
        IEnumerable<OrderDTO> GetOrder();
        [OperationContract]
        OrderDTO GetByNick(UserDTO user);
    }
}
