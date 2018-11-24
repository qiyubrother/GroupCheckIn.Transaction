using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction.Definition
{
    /// <summary>
    /// 删除预定上送报文
    /// </summary>
    [Serializable]
    public class DeleteReservationTx : TransactionTx, IHotelTransaction
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100007"; }
        /// <summary>
        /// 酒店ID
        /// </summary>
        public string HotelId { get; set; }
        /// <summary>
        /// 预定号
        /// </summary>
        public string ReservationNo { get; set; }
    }

    /// <summary>
    /// 删除预定下送报文
    /// </summary>
    [Serializable]
    public class DeleteReservationRx : TransactionRx, ITransactionRx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode => "100007";
    }
}
