using QuanLyThucDonNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang.DAO
{
    class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodDAO();
                return instance;
            }
        }
        private FoodDAO() { }
        public List<Category> Load_CategoryId()
        {
            List<Category> list = new List<Category>();
            string query = "select CategoryId from Category";
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    int categoryId = (int)item["CategoryId"];
                    Category ct = new Category(categoryId);
                    list.Add(ct);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load mã loại thức ăn DAO!");
            }

            return list;
        }
        public List<Food> ShowFood()
        {
            List<Food> foods = new List<Food>();
            string query = "select * from Food"; // chưa biết nhập điều kiện
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    int foodId = (int)item["FoodId"];
                    string foodName = item["FoodName"].ToString();
                    double price = (double)item["Price"];
                    int categoryId = (int)item["CategoryId"];

                    Food f = new Food(foodId, foodName, price, categoryId);

                    foods.Add(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem thực đơn DAO!");
            }
            return foods;
        }
        public bool AddFood(Food f)
        {
            try
            {

                string query = string.Format("insert into Food (FoodName, Price, CategoryId) " +
                    "values (N'{0}', {1}, {2})",
                    f.FoodName, f.Price, f.CategoryId);


                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm thức ăn DAO!");
            }
            return false;
        }
        public bool EditFood(Food f)
        {
            try
            {
                string query = string.Format("update Food set FoodName = N'{0}' , Price = {1}"
                 + "where FoodId = {2}", f.FoodName, f.Price, f.FoodId);

                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa thức ăn DAO!");
            }

            return false;
        }

        public bool DeleteFood(int foodId)
        {
            try
            {
                if (foodId == 0)
                    return false;
                string query = string.Format("delete from Food where FoodId = '{0}'", foodId);

                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa món ăn DAO!");
            }
            return false;
        }
        public List<Food> SearchPriceFood(int minPrice, int maxPrice)
        {
            List<Food> foods = new List<Food>();
            string query = string.Format("select * from Food where Price >= {0} and Price <= {1}", minPrice, maxPrice);
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    int foodId = (int)item["FoodId"];
                    string foodName = item["FoodName"].ToString();
                    double price = (double)item["Price"];
                    int categoryId = (int)item["CategoryId"];

                    Food f = new Food(foodId, foodName, price, categoryId);

                    foods.Add(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm món ăn theo khoảng giá DAO!");
            }
            return foods;
        }
        public List<Food> SearchNameFood(string nameSearch)
        {
            List<Food> foods = new List<Food>();
            string query = string.Format("select * from Food where FoodName like N'%{0}%'", nameSearch);
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    int foodId = (int)item["FoodId"];
                    string foodName = item["FoodName"].ToString();
                    double price = (double)item["Price"];
                    int categoryId = (int)item["CategoryId"];

                    Food f = new Food(foodId, foodName, price, categoryId);

                    foods.Add(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm món ăn theo tên DAO!");
            }
            return foods;
        }
    }
}
