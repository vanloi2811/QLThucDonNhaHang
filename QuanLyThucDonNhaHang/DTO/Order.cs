using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThucDonNhaHang.DTO
{
    public class Order
    {
        private int orderId;
        private double totalPrice;
        private DateTime createDate;
        private bool paid;

        public int OrderId { get => orderId; set => orderId = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public bool Paid { get => paid; set => paid = value; }

        public Order()
        { }
        public Order(int orderId, double totalPrice, DateTime createDate)
        {
            this.orderId = orderId;
            this.totalPrice = totalPrice;
            this.createDate = createDate;
            this.paid = false;
        }
        public Order(int orderId, double totalPrice, DateTime createDate, bool paid)
        {
            this.orderId = orderId;
            this.totalPrice = totalPrice;
            this.createDate = createDate;
            this.paid = paid;
        }
    }
}
