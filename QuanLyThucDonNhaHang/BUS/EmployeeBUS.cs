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
    class EmployeeBUS
    {
        private static EmployeeBUS instance;
        public static EmployeeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeBUS();
                return instance;
            }
        }

        private EmployeeBUS() { }

        public void ShowEmployee(DataGridView data)
        {
            try
            {
                data.DataSource = EmployeeDAO.Instance.ShowEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem nhân viên BUS!");
            }
        }

        public bool EditEmployee(DataGridView data)
        {
            try
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                int employeeId = (int)row.Cells["EmployeeId"].Value;
                string employeeName = row.Cells["EmployeeName"].Value.ToString();
                int service = (int)row.Cells["Service"].Value;
                int accountId = (int)row.Cells["AccountId"].Value;

                Employee e = new Employee(employeeId, employeeName, service, accountId);
                if (EmployeeDAO.Instance.EditEmployee(e))
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa nhân viên BUS!");
            }

            return false;
        }

        public void SearchNameEmployee(DataGridView data, string nameSearch)
        {
            try
            {
                data.DataSource = EmployeeDAO.Instance.SearchNameEmployee(nameSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm nhân viên theo tên BUS!");
            }
        }
    }
}
