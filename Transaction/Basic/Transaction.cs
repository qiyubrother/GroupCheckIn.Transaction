using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Transaction
{
    public class Transaction : Object
    {
    }

    public class TransactionTx : ITransactionTx
    {
        public virtual string TransCode { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public virtual Direction Direction => Direction.Tx;
        public virtual string Timestamp => DateTime.Now.ToString();
    }

    public class TransactionRx : ITransactionRx
    {
        public virtual string TransCode { get; }
        public virtual Direction Direction => Direction.Rx;
        public virtual string Timestamp => DateTime.Now.ToString();
        public virtual string ErrorCode { get; set; }
        public virtual string ErrorMessage { get; set; }
    }
}
