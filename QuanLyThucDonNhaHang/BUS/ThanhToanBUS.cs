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
    class ThanhToanBUS
    {
        private static ThanhToanBUS instance;
        public static ThanhToanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThanhToanBUS();
                return instance;
            }
        }
        private ThanhToanBUS() { }

        public void Load_TableThanhToan(ComboBox cboTableIdThanhToan)
        {
            try
            {
                cboTableIdThanhToan.Items.Clear();
                //Thêm 0 để khi thanh toán datagirdview sẽ tự động load lại
                cboTableIdThanhToan.Items.Add("0");
                foreach (Table item in ThanhToanDAO.Instance.Load_TableThanhToan())
                {
                    cboTableIdThanhToan.Items.Add(string.Format("{0} {1}", item.TableId, item.TableName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load mã bàn thanh toán BUS!");
            }
        }

        public void Load_EmployeeId(ComboBox cboEmloyeeId)
        {
            try
            {
                cboEmloyeeId.Items.Clear();
                foreach (string item in ThanhToanDAO.Instance.Load_EmployeeId())
                {
                    cboEmloyeeId.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load nhân viên thanh toán BUS!");
            }
        }

        public void Load_TotalPrice(TextBox txtTotalPriceThanhToan, int tableId)
        {
            try
            {
                txtTotalPriceThanhToan.Text = ThanhToanDAO.Instance.Load_TotalPrice(tableId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load tổng tiền thanh toán BUS!");
            }
        }

        public void ShowThanhToan(DataGridView data, int tableId)
        {
            if (tableId == 0)
                return;
            try
            {

                data.DataSource = ThanhToanDAO.Instance.ShowThanhToan(tableId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem thanh toán BUS!");
            }
        }

        public bool ThanhToanHoaDon(int tableId, string tongTien)
        {
            try
            {
                return ThanhToanDAO.Instance.ThanhToanHoaDon(tableId, tongTien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán hóa đơn BUS!");
            }
            return false;
        }
    }
}
