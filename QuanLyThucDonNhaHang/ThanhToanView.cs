using QuanLyThucDonNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang
{
    class ThanhToanView
    {
        private static ThanhToanView instance;
        public static ThanhToanView Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThanhToanView();
                return instance;
            }
        }
        private ThanhToanView() { }

        public void Load_StyleTable(DataGridView dtgvThanhtoan)
        {
            // Gán tiếng việt cho header
            dtgvThanhtoan.Columns[0].HeaderText = "Mã món ăn";
            dtgvThanhtoan.Columns[1].HeaderText = "Tên món ăn";
            dtgvThanhtoan.Columns[2].HeaderText = "Gía bán";
            dtgvThanhtoan.Columns[3].HeaderText = "Số lượng";
            dtgvThanhtoan.Columns[4].HeaderText = "Tổng";

            dtgvThanhtoan.Columns[0].Width = 90;
            dtgvThanhtoan.Columns[1].Width = 120;
            dtgvThanhtoan.Columns[2].Width = 70;
            dtgvThanhtoan.Columns[3].Width = 70;
            dtgvThanhtoan.Columns[4].Width = 82;
        }

        public void Load_TableThanhToan(ComboBox cboTableIdThanhToan)
        {
            try
            {
                ThanhToanBUS.Instance.Load_TableThanhToan(cboTableIdThanhToan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem danh sách mã bàn thanh toán View!");
            }
        }

        public void Load_EmployeeId(ComboBox cboEmloyeeId)
        {
            try
            {
                ThanhToanBUS.Instance.Load_EmployeeId(cboEmloyeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem danh sách mã nhân viên thanh toán View!");
            }
        }

        public void Load_TotalPrice(TextBox txtTotalPriceThanhToan, int tableId)
        {
            try
            {
                ThanhToanBUS.Instance.Load_TotalPrice(txtTotalPriceThanhToan, tableId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem tổng tiền thanh toán View!");
            }
        }

        public void ShowThanhToan(DataGridView dtgv, int tableId)
        {
            if (tableId == 0)
                return;
            try
            {
                ThanhToanBUS.Instance.ShowThanhToan(dtgv, tableId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem danh sách thanh toán APP!");
            }
            Load_StyleTable(dtgv);
        }

        public bool ThanhToanHoaDon(int tableId, string totalPrice)
        {
            try
            {
                return ThanhToanBUS.Instance.ThanhToanHoaDon(tableId, totalPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán hóa đơn APP!");
            }
            return false;
        }

        internal void Load_TotalPrice(object txtTotalPriceThanhToan, int tableId)
        {
            throw new NotImplementedException();
        }
    }
}
