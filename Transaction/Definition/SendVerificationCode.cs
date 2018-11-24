using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction.Definition
{
    /// <summary>
    /// 发送验证码上送报文定义
    /// </summary>
    [Serializable]
    public class SendVerificationCodeTx : TransactionTx, IHotelTransaction
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100003"; }

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
    }
    /// <summary>
    /// 发送验证码下送报文定义
    /// </summary>
    [Serializable]
    public class SendVerificationCodeRx : TransactionRx, ITransactionRx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100003"; }
    }
}
