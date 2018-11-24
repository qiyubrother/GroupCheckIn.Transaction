using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction.Definition
{
    /// <summary>
    /// 编辑预定上送报文
    /// </summary>
    [Serializable]
    public class EditReservationTx: TransactionTx, IHotelTransaction
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100006"; }
        /// <summary>
        /// 酒店ID
        /// </summary>
        public string HotelId { get; set; }
        /// <summary>
        /// 预定号
        /// </summary>
        public string ReservationNo { get; set; }

        /// <summary>
        /// 新手机号
        /// </summary>
        public string NewMobile { get; set; }

        /// <summary>
        /// 新预定人
        /// </summary>
        public string NewReservationBy { get; set; }
        /// <summary>
        /// 新入住日期
        /// </summary>
        public string NewCheckInDate { get; set; }
    }

    /// <summary>
    /// 编辑预定下送报文
    /// </summary>
    [Serializable]
    public class EditReservationRx : TransactionRx, ITransactionRx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode => "100006";
    }
}
