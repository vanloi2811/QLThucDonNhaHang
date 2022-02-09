using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThucDonNhaHang.DTO;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return instance;
            }
        }
        private EmployeeDAO() { }

        public List<Employee> ShowEmployee()
        {
            List<Employee> employees = new List<Employee>();
            string query = "select * from Employee"; // chưa biết nhập điều kiện
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    int employeeId = (int)item["EmployeeId"];
                    string employeeName = item["EmployeeName"].ToString();
                    int service = (int)item["Service"];
                    int accountId = (int)item["AccountId"];

                    Employee e = new Employee(employeeId, employeeName, service, accountId);

                    employees.Add(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem nhân viên DAO!");
            }
            return employees;
        }

        public bool EditEmployee(Employee e)
        {
            try
            {
                string query = string.Format("update Employee set EmployeeName = N'{0}'"
                 + "where EmployeeId = {1}", e.EmployeeName, e.EmployeeId);

                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa nhân viên DAO!");
            }

            return false;
        }

        public List<Employee> SearchNameEmployee(string nameSearch)
        {
            List<Employee> employees = new List<Employee>();
            string query = string.Format("select * from Employee where EmployeeName like N'%{0}%'", nameSearch);
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    int employeeId = (int)item["EmployeeId"];
                    string employeeName = item["EmployeeName"].ToString();
                    int service = (int)item["Service"];
                    int accountId = (int)item["AccountId"];

                    Employee e = new Employee(employeeId, employeeName, service, accountId);

                    employees.Add(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm nhân viên theo tên DAO!");
            }
            return employees;
        }
    }
}
