using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Constants
{
    public enum OrderStatus
    {
        Pendding = 0,
        Approved = 1,
        Delivered = 2,
        Shipped = 3,
        Cancelled = 4
    }
}
