using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction
{
    public interface IHotelTransaction : ITransaction
    {
        string HotelId { get; set; }
    }
}
