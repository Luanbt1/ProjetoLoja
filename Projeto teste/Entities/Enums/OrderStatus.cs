using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_teste.Entities.Enums
{
    internal enum OrderStatus : int
    {

        PendingPayment = 0, 
        Processing = 1,
        Shipping = 2,
        Delivered = 3


    }
}
