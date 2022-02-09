using QuanLyThucDonNhaHang.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang
{
    class EmployeeView
    {
        private static EmployeeView instance;
        public static EmployeeView Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeView();
                return instance;
            }
        }
        private EmployeeView() { }

        public void Load_StyleTable(DataGridView dtgvEmployee)
        {
            // Gán tiếng việt cho header
            dtgvEmployee.Columns[0].HeaderText = "Mã nhân viên";
            dtgvEmployee.Columns[1].HeaderText = "Tên nhân viên";
            dtgvEmployee.Columns[2].HeaderText = "Chức vụ";
            dtgvEmployee.Columns[3].HeaderText = "Mã tài khoản";

            dtgvEmployee.Columns[0].Width = 120;
            dtgvEmployee.Columns[1].Width = 160;
            dtgvEmployee.Columns[2].Width = 100;
            dtgvEmployee.Columns[3].Width = 120;
        }

        public void ShowEmployee(DataGridView dtgvEmployee)
        {
            try
            {
                EmployeeBUS.Instance.ShowEmployee(dtgvEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem nhân viên View!");
            }
            Load_StyleTable(dtgvEmployee);
        }

        public void EditEmployee(DataGridView dtgvEmployee)
        {
            try
            {
                if (EmployeeBUS.Instance.EditEmployee(dtgvEmployee))
                {
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa nhân viên View!");
            }
        }

        public void SearchNameEmployee(DataGridView dtgvEmployee, string searchName)
        {
            try
            {
                EmployeeBUS.Instance.SearchNameEmployee(dtgvEmployee, searchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm nhân viên theo tên View!");
            }
        }

    }
}
