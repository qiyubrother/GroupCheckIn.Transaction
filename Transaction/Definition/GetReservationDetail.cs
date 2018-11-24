using System;
using System.Collections.Generic;
using System.Text;

namespace Transaction.Definition
{
    /// <summary>
    /// 取得预定房间明细上送报文
    /// </summary>
    [Serializable]
    public class GetReservationDetailTx : TransactionTx, IHotelTransaction
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode { get => "100004"; }
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
    /// 取得预定房间明细下送报文
    /// </summary>
    [Serializable]
    public class GetReservationDetailRx : TransactionRx, ITransactionRx
    {
        /// <summary>
        /// 交易码
        /// </summary>
        public override string TransCode => "100004";
        /// <summary>
        /// 预定房间信息
        /// </summary>
        public IEnumerable<RoomReservationInfo> ReservationRooms { get; set; }
    }
    /// <summary>
    /// 房间预定信息
    /// </summary>
    public class RoomReservationInfo
    {
        /// <summary>
        /// 子预定号
        /// </summary>
        public string SubReservationNo { get; set; }
        /// <summary>
        /// 房号
        /// </summary>
        public string RoomNo { get; set; }
        /// <summary>
        /// 房间类型
        /// </summary>
        public RoomType RoomType { get; set; }
    }
    /// <summary>
    /// 房间类型定义
    /// </summary>
    public enum RoomType
    {
        /// <summary>
        /// 标准间
        /// </summary>
        Standard,
        /// <summary>
        /// 单间
        /// </summary>
        Single,
        /// <summary>
        /// 套间
        /// </summary>
        Suite
    }
}
