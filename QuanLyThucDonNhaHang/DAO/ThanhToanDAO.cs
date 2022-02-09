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
    class ThanhToanDAO
    {
        private static ThanhToanDAO instance;
        public static ThanhToanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThanhToanDAO();
                return instance;
            }
        }
        private ThanhToanDAO() { }

        public List<Table> Load_TableThanhToan()
        {
            List<Table> tables = new List<Table>();
            //int i = 0;
            string query = "select TableId, TableName from TableFood where Status <> N'Trống'";
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Table t = new Table((int)item["TableId"], item["TableName"].ToString());
                    tables.Add(t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem thanh toán DAO!");
            }
            return tables;
        }

        public List<string> Load_EmployeeId()
        {
            List<string> Employees = new List<string>();
            //int i = 0;
            string query = "select EmployeeId from Employee";
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Employees.Add(item["EmployeeId"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem thanh toán DAO!");
            }
            return Employees;
        }


        public int getOrderId(int tableId)
        {
            int orderId = 0;
            string query = string.Format("select OrderId from Orders where TableId = '{0}' and Paid = 0", tableId);
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    orderId = (int)item["OrderId"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem mã hóa đơn thanh toán DAO!");
            }
            return orderId;
        }

        public string Load_TotalPrice(int tableId)
        {
            int orderId = getOrderId(tableId);
            //string ketQua = "";
            double total = 0;
            string query = string.Format("select sum(od.Quantity * f.Price) as 'TotalPrice' " +
                "from OrderDetail od, Food f " +
                "where od.OrderId = {0} and od.FoodId = f.FoodId", orderId); // chưa biết nhập điều kiện
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    total = (double)item["TotalPrice"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem thanh toán DAO!");
            }
            return total.ToString();
        }

        public List<OrderDetail> ShowThanhToan(int tableId)
        {
            if (tableId == 0)
                return null;
            int orderId = getOrderId(tableId);

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            string query = string.Format("select f.FoodId, f.FoodName, f.Price, od.Quantity, (od.Quantity * f.Price) as 'Total' " +
                "from OrderDetail od, Food f " +
                "where od.OrderId = {0} and od.FoodId = f.FoodId", orderId); // chưa biết nhập điều kiện
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    int foodId = (int)item["FoodId"];
                    string foodName = item["FoodName"].ToString();
                    double price = (double)item["Price"];
                    int quantity = (int)item["Quantity"];
                    double total = (double)item["Total"];
                    OrderDetail orderDetail = new OrderDetail(foodId, foodName, price, quantity, total);

                    orderDetails.Add(orderDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem thanh toán DAO!");
            }
            return orderDetails;
        }

        public bool ThanhToanHoaDon(int tableId, string totalPrice) // tong tien = txtTongTien
        {
            int orderId = getOrderId(tableId);
            bool kiemTra = false;
            bool ktOrder = false;
            bool ktTable = false;
            try
            {
                string query = string.Format("update Orders set TotalPrice = {0}, Paid = 1 where OrderId = {1}", double.Parse(totalPrice), orderId);
                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    ktOrder = true;

                query = string.Format("update TableFood set Status = N'Trống' where TableId = '{0}'", tableId);
                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    ktTable = true;

                kiemTra = ktOrder && ktTable;
                return kiemTra;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán DAO!");
            }

            return false;
        }
    }
}
