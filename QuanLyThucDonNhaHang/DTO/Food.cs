using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThucDonNhaHang.DTO
{
    public class Food
    {
        int foodId;
        string foodName;
        double price;
        private int categoryId;

        public int FoodId { get => foodId; set => foodId = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public double Price { get => price; set => price = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }

        public Food()
        {
        }
        public Food(int foodId, string foodName, double price, int categoryId)
        {
            this.foodId = foodId;
            this.foodName = foodName;
            this.price = price;
            this.categoryId = categoryId;
        }

        public Food(int foodId, string foodName, double price)
        {
            this.foodId = foodId;
            this.foodName = foodName;
            this.price = price;
        }
        public Food(int foodId, string foodName)
        {
            this.foodId = foodId;
            this.foodName = foodName;
        }

        public Food(string foodName, double price, int categoryId)
        {
            this.foodName = foodName;
            this.price = price;
            this.categoryId = categoryId;
        }

    }
}
