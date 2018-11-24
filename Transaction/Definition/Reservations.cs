using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction.Definition
{
    /// <summary>
    /// 添加预定上送报文定义
    /// </summary>
    [Serializable]
    public class ReservationsTx: TransactionTx, IHotelTransaction
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode => "100001";

        /// <summary>
        /// 预定人手机号码
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 预定人
        /// </summary>
        public string ReservationBy { get; set; }
        /// <summary>
        /// 预定号
        /// </summary>
        public string ReservationNo { get; set; }
        /// <summary>
        /// 酒店ID
        /// </summary>
        public string HotelId { get; set; }
        /// <summary>
        /// 入住日期
        /// </summary>
        public string CheckInDate { get; set; }
    }
    /// <summary>
    /// 添加预定下送报文定义
    /// </summary>
    [Serializable]
    public class ReservationsRx : TransactionRx, ITransactionRx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100001"; }
        /// <summary>
        /// 酒店ID
        /// </summary>
        public string HotelId { get; set; }
    }
}
