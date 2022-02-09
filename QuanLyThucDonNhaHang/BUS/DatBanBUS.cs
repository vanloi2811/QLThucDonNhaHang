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
    class DatBanBUS
    {
        private static DatBanBUS instance;
        public static DatBanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatBanBUS();
                return instance;
            }
        }
        private DatBanBUS() { }

        //public void Load_MaBan(ComboBox cbMaban)
        //{
        //    try
        //    {
        //        cbMaban.Items.Clear();
        //        foreach (Table item in DatBanDAO.Instance.Load_TableId())
        //        {
        //            cbMaban.Items.Add(string.Format("{0} {1}", item.TableId, item.Status));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi load mã bàn đặt món BUS!");
        //    }
        //}

        public void Load_Food(ComboBox cboFood)
        {
            try
            {
                cboFood.Items.Clear();
                foreach (Food item in DatBanDAO.Instance.Load_Food())
                {
                    cboFood.Items.Add(string.Format("{0} {1}", item.FoodId, item.FoodName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load món đặt bàn BUS!");
            }
        }
        public void ShowDatBan(DataGridView data, int tableId)
        {
            try
            {
                data.DataSource = DatBanDAO.Instance.ShowDatBan(tableId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem đặt bàn BUS!");
            }
        }
        public bool AddDatBan(int tableId, int foodId, int quantity)
        {
            try
            {
                if (DatBanDAO.Instance.AddDatBan(foodId, quantity, tableId))
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món đặt bàn BUS!");
            }
            return false;
        }
        public bool EditDatBan(DataGridView data, int tableId)
        {
            try
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                int quantity = (int)row.Cells["Quantity"].Value;
                int foodId = (int)row.Cells["FoodId"].Value;
                OrderDetail od = new OrderDetail(quantity);
                if (DatBanDAO.Instance.EditDatBan(od, tableId, foodId))
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa món đặt bàn BUS!");
            }

            return false;
        }
        public bool DeleteDatBan(DataGridView data, int tableId)
        {
            try
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                int foodId = (int)row.Cells["FoodId"].Value;

                if (DatBanDAO.Instance.DeleteDatBan(tableId, foodId))
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa món đặt bàn BUS!");
            }

            return false;
        }
        public bool DeleteAllDatBan(int tableId)
        {
            try
            {
                if (DatBanDAO.Instance.DeleteAllDatBan(tableId))
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hủy đặt bàn BUS!");
            }

            return false;
        }
    }
}
