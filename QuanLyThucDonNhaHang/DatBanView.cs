using QuanLyThucDonNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang
{
    class DatBanView
    {
        private static DatBanView instance;
        public static DatBanView Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatBanView();
                return instance;
            }
        }
        private DatBanView() { }

        public void Load_StyleTable(DataGridView dtgvDatmon)
        {
            // Gán tiếng việt cho header
            dtgvDatmon.Columns[0].HeaderText = "Mã món ăn";
            dtgvDatmon.Columns[1].HeaderText = "Tên món ăn";
            dtgvDatmon.Columns[2].HeaderText = "Gía bán";
            dtgvDatmon.Columns[3].HeaderText = "Số lượng";
            dtgvDatmon.Columns[4].HeaderText = "Tổng";

            dtgvDatmon.Columns[0].Width = 70;
            dtgvDatmon.Columns[1].Width = 100;
            dtgvDatmon.Columns[2].Width = 80;
            dtgvDatmon.Columns[3].Width = 80;
            dtgvDatmon.Columns[4].Width = 75;
        }

        //public void Load_MaBan(ComboBox cbMaban)
        //{
        //    try
        //    {
        //        DatBanBUS.Instance.Load_MaBan(cbMaban);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi xem danh sách mã bàn đặt món View!");
        //    }
        //}

        public void Load_Food(ComboBox cboFood)
        {
            try
            {
                DatBanBUS.Instance.Load_Food(cboFood);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem danh sách món đặt bàn View!");
            }
        }

        public void ShowDatBan(DataGridView dtgv, int tableId)
        {
            try
            {
                DatBanBUS.Instance.ShowDatBan(dtgv, tableId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem danh sách đặt bàn View!");
            }
            Load_StyleTable(dtgv);
        }

        public void AddDatBan(int tableId, int foodId, int quantity)
        {
            try
            {
                DatBanBUS.Instance.AddDatBan(tableId, foodId, quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món đặt bàn View!");
            }
        }
        public void EditDatBan(DataGridView dtgv, int tableId)
        {
            try
            {
                if (DatBanBUS.Instance.EditDatBan(dtgv, tableId))
                {
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa món đặt bàn View!");
            }
        }
        public void DeleteDatBan(DataGridView dtgv, int table)
        {
            try
            {
                if (DatBanBUS.Instance.DeleteDatBan(dtgv, table))
                {
                    MessageBox.Show("Xóa thành công!");
                }

            }
            catch
            {
                MessageBox.Show("Lỗi xóa món đặt bàn View!");
            }

        }
        public void DeleteAllDatBan(int tableId)
        {
            try
            {
                if (DatBanBUS.Instance.DeleteAllDatBan(tableId))
                {
                    MessageBox.Show("Hủy đặt bàn thành công!");
                }

            }
            catch
            {
                MessageBox.Show("Lỗi hủy đặt bàn View!");
            }

        }
    }
}
