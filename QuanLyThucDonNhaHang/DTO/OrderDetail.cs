using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThucDonNhaHang.DTO
{
    public class OrderDetail
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public double Price { get; set; }



        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Total { get; set; }

        public OrderDetail(string foodName, double price, int quantity, double total)
        {
            this.FoodName = foodName;
            this.Price = price;
            this.Quantity = quantity;
            this.Total = total;
        }
        public OrderDetail(string foodName, double price, int quantity)
        {
            this.FoodName = foodName;
            this.Price = price;
            this.Quantity = quantity;
        }
        public OrderDetail(int foodId, string foodName, double price, int quantity, double total)
        {
            this.FoodId = foodId;
            this.FoodName = foodName;
            this.Price = price;
            this.Quantity = quantity;
            this.Total = total;
        }
        public OrderDetail(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
