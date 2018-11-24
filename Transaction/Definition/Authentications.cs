using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction.Definition
{
    /// <summary>
    /// 验证验证码上送报文定义
    /// </summary>
    [Serializable]
    public class AuthenticationsTx : TransactionTx, IHotelTransaction
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode => "100002";
        /// <summary>
        /// 酒店ID
        /// </summary>
        public string HotelId { get; set; }
        /// <summary>
        /// 预定人手机号码
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 预定号
        /// </summary>
        public string ReservationNo { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string VerificationCode { get; set; }
    }
    /// <summary>
    /// 验证验证码下送报文定义
    /// </summary>
    [Serializable]
    public class AuthenticationsRx : TransactionRx, ITransactionRx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100002"; }
    }
}
