using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction.Definition
{
    /// <summary>
    /// 搜索预定上送报文
    /// </summary>
    [Serializable]
    public class SearchReservationTx : TransactionTx, IHotelTransaction
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100008"; }
        /// <summary>
        /// 酒店ID
        /// </summary>
        public string HotelId { get; set; }
        /// <summary>
        /// 预定号
        /// </summary>
        public string ReservationNo { get; set; }
        /// <summary>
        /// 预定人手机号码
        /// </summary>
        public string Mobile { get; set; }
    }

    /// <summary>
    /// 搜索预定下送报文
    /// </summary>
    [Serializable]
    public class SearchReservationRx : TransactionRx, ITransactionRx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode => "100008";
        /// <summary>
        /// 预定房间信息
        /// </summary>
        public IEnumerable<ReservationInfo> Reservations { get; set; }
    }
}
