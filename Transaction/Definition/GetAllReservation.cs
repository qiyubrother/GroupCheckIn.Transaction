using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction.Definition
{
    /// <summary>
    /// 取得所有预定上送报文定义
    /// </summary>
    [Serializable]
    public class GetAllReservationTx : TransactionTx, IHotelTransaction
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100005"; }
        /// <summary>
        /// 酒店ID
        /// </summary>
        public string HotelId { get; set; }
        /// <summary>
        /// 订单状态：Invalid or Valid
        /// </summary>
        public string Status { get; set; }
    }
    /// <summary>
    /// 取得所有预定下送报文定义
    /// </summary>
    [Serializable]
    public class GetAllReservationRx : TransactionRx, ITransactionRx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100005"; }
        /// <summary>
        /// 预定房间信息
        /// </summary>
        public IEnumerable<ReservationInfo> Reservations { get; set; }
    }

    /// <summary>
    /// 返回预定数据定义
    /// </summary>
    public class ReservationInfo
    {
        /// <summary>
        /// 酒店ID
        /// </summary>
        public string HotelId { get; set; }
        /// <summary>
        /// 预定号
        /// </summary>
        public string ReservationNo { get; set; }
        /// <summary>
        /// 预定人
        /// </summary>
        public string ReservationBy { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 入住日期
        /// </summary>
        public string CheckInDate { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public string CreateDate { get; set; }
    }
}
