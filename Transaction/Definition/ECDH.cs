using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction.Definition
{
    public class ECDHTx : TransactionTx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode => "100000";
        /// <summary>
        /// 客户端公钥
        /// </summary>
        public string ClientPublicKey { get; set; }
    }

    public class ECDHRx : TransactionRx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode => "100000";
        /// <summary>
        /// 服务端公钥
        /// </summary>
        public string ServerPublicKey { get; set; }
        /// <summary>
        /// 客户端公钥
        /// </summary>
        public string ClientPublicKey { get; set; }
    }
}
