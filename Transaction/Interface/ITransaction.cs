using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    public interface ITransaction
    {
        string TransCode { get; }
    }
    public interface ITransactionTx : ITransaction
    {
        Direction Direction { get; }
        string Timestamp { get; }
    }

    public interface ITransactionRx : ITransaction
    {
        Direction Direction { get; }
        string Timestamp { get; }
        string ErrorCode { get; set; }
        string ErrorMessage { get; set; }
    }
    public enum Direction
    {
        /// <summary>
        /// 上送报文
        /// </summary>
        Tx,
        /// <summary>
        /// 下送报文
        /// </summary>
        Rx
    }
}
