using QuanLyThucDonNhaHang.DAO;
using QuanLyThucDonNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang.BUS
{
    class FoodBUS
    {
        private static FoodBUS instance;
        public static FoodBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodBUS();
                return instance;
            }
        }

        private FoodBUS() { }
        public void Load_CategoryId(ComboBox cboCategoryid)
        {
            try
            {
                //cboCategoryId.Items.Clear();
                //foreach (Category item in FoodDAO.Instance.Load_CategoryId())
                //{
                //    cboCategoryId.Items.Add(item.CategoryId);
                //}
                List<Category> list = new List<Category>();
                list = FoodDAO.Instance.Load_CategoryId();
                cboCategoryid.Items.Clear();
                foreach (Category item in list)
                {
                    cboCategoryid.Items.Add(item.CategoryId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load mã loại món ăn BUS!");
            }
        }

        public void ShowFood(DataGridView data)
        {
            try
            {
                data.DataSource = FoodDAO.Instance.ShowFood();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem món ăn BUS!");
            }
        }

        public bool AddFood(string foodName, double price, int categoryId)
        {
            try
            {
                Food f = new Food(foodName, price, categoryId);
                if (FoodDAO.Instance.AddFood(f))
                    return true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món ăn BUS!");
            }
            return false;
        }

        public bool EditFood(DataGridView data)
        {
            try
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                int foodId = (int)row.Cells["FoodId"].Value;
                string foodName = row.Cells["FoodName"].Value.ToString();
                double price = (double)row.Cells["Price"].Value;
                int categoryId = (int)row.Cells["CategoryId"].Value;

                Food f = new Food(foodId, foodName, price, categoryId);
                if (FoodDAO.Instance.EditFood(f))
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa món ăn BUS!");
            }

            return false;
        }

        public bool DeleteFood(DataGridView data)
        {
            try
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                int foodId = (int)row.Cells["FoodId"].Value;

                if (FoodDAO.Instance.DeleteFood(foodId))
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa món ăn BUS!");
            }

            return false;
        }

        public void SearchNameFood(DataGridView data, string nameSearch)
        {
            try
            {
                data.DataSource = FoodDAO.Instance.SearchNameFood(nameSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm bàn theo tên BUS!");
            }
        }

        public void SearchPriceFood(DataGridView data, int minPrice, int maxPrice)
        {
            try
            {
                data.DataSource = FoodDAO.Instance.SearchPriceFood(minPrice, maxPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm món ăn theo khoảng giá BUS!");
            }
        }
    }
}
