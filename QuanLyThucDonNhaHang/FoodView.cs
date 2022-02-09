using QuanLyThucDonNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang
{
    class FoodView
    {
        private static FoodView instance;
        public static FoodView Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodView();
                return instance;
            }
        }
        private FoodView() { }

        public void Load_StyleTable(DataGridView dtgvFood)
        {
            // Gán tiếng việt cho header
            dtgvFood.Columns[0].HeaderText = "Mã món ăn";
            dtgvFood.Columns[1].HeaderText = "Tên món ăn";
            dtgvFood.Columns[2].HeaderText = "Gía bán";
            dtgvFood.Columns[3].HeaderText = "Mã loại món ăn";

            dtgvFood.Columns[0].Width = 120;
            dtgvFood.Columns[1].Width = 140;
            dtgvFood.Columns[2].Width = 100;
            dtgvFood.Columns[3].Width = 120;
        }

        public void Load_CategoryId(ComboBox cboCategoryid)
        {
            try
            {
                FoodBUS.Instance.Load_CategoryId(cboCategoryid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load mã loại món ăn View!");
            }
        }

        public void ShowFood(DataGridView dtgvFood)
        {
            try
            {
                FoodBUS.Instance.ShowFood(dtgvFood);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem món ăn View!");
            }
            Load_StyleTable(dtgvFood);
        }

        public void AddFood(string foodName, double price, int categoryId)
        {
            try
            {
                if (FoodBUS.Instance.AddFood(foodName, price, categoryId))
                {
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món ăn View!");
            }
        }

        public void EditFood(DataGridView dtgvFood)
        {
            try
            {
                if (FoodBUS.Instance.EditFood(dtgvFood))
                {
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa món ăn View!");
            }
        }
        public void DeleteFood(DataGridView dtgvFood)
        {
            try
            {
                if (FoodBUS.Instance.DeleteFood(dtgvFood))
                {
                    MessageBox.Show("Xóa thành công!");
                }

            }
            catch
            {
                MessageBox.Show("Lỗi xóa món ăn View!");
            }

        }
        public void SearchPriceFood(DataGridView dtgvFood, int minPrice, int maxPrice)
        {
            try
            {
                FoodBUS.Instance.SearchPriceFood(dtgvFood, minPrice, maxPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm món ăn theo khoảng giá View!");
            }

        }

        public void SearchNameFood(DataGridView dtgvFood, string searchName)
        {
            try
            {
                FoodBUS.Instance.SearchNameFood(dtgvFood, searchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm món ăn theo tên View!");
            }

        }
    }
}
