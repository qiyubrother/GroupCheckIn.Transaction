using System;
using System.Collections.Generic;
using System.Text;
using Transaction.Definition;
using Transaction;

namespace SocketService
{
    public interface IImplementTransaction
    {
        ITransaction Action();
    }
}
