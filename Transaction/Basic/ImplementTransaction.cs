using System;
using System.Collections.Generic;
using System.Text;
using Transaction.Definition;
using Transaction;

namespace SocketService
{
    public abstract class ImplementTransaction : IImplementTransaction
    {
        public ITransactionTx Tx { get; set; }
        public ITransactionRx Rx { get; set; }
        public virtual ITransaction Action() { return null; }
    }
}
