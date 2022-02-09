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
    class DatBanDAO
    {
        private static DatBanDAO instance;
        public static DatBanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatBanDAO();
                return instance;
            }
        }
        private DatBanDAO() { }

        public List<Table> Load_TableId()
        {
            List<Table> tables = new List<Table>();
            //int i = 0;
            string query = "select TableId, Status from TableFood";
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Table t = new Table(item["TableId"].ToString(), item["Status"].ToString());
                    tables.Add(t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem đặt món DAO!");
            }
            return tables;
        }

        public List<Food> Load_Food()
        {
            List<Food> foods = new List<Food>();

            //int i = 0;
            string query = "select FoodId, FoodName from Food";
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Food f = new Food((int)item["FoodId"], item["FoodName"].ToString());
                    foods.Add(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem đặt bàn DAO!");
            }
            return foods;
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
                MessageBox.Show("Lỗi xem mã hóa đơn đặt bàn DAO!");
            }
            return orderId;
        }
        public List<OrderDetail> ShowDatBan(int tableId)
        {
            int orderId = getOrderId(tableId);

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            string query = string.Format("select od.FoodId, f.FoodName, f.Price, od.Quantity, od.Quantity * f.Price as 'Total' " +
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
                MessageBox.Show("Lỗi xem đặt bàn DAO!");
            }
            return orderDetails;
        }
        public bool AddDatBan(int foodId, int quantity, int tableId)
        {
            int orderId = getOrderId(tableId);
            string query;
            try
            {

                if (orderId == 0)
                {
                    query = string.Format("update TableFood set Status = N'Có khách' where  TableId = '{0}'", tableId);
                    if (DataProvider.Instance.ExecuteNonQuery(query) < 1)
                        return false;

                    query = string.Format("insert into Orders (TotalPrice, TableId, EmployeeId) " +
                    "values ({0}, '{1}', {2})", 0, tableId, 1);
                    if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                        orderId = getOrderId(tableId);
                    else
                        return false;

                }

                query = string.Format("insert into OrderDetail (OrderId, FoodId, Quantity) " +
                    "values ({0}, {1}, {2})", orderId, foodId, quantity);


                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món đặt bàn DAO!");
            }
            return false;
        }
        public bool EditDatBan(OrderDetail od, int tableId, int foodId)
        {
            int orderId = getOrderId(tableId);
            try
            {
                string query = string.Format("update OrderDetail set Quantity = {0} "
                 + " where OrderId = {1} and FoodId = {2}", od.Quantity, orderId, foodId);

                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa món đặt bàn DAO!");
            }

            return false;
        }
        public bool DeleteDatBan(int tableId, int foodId)
        {
            int orderId = getOrderId(tableId);
            try
            {
                if (orderId == 0)
                    return false;
                string query = string.Format("delete from OrderDetail where OrderId = {0} and FoodId = {1}", orderId, foodId);

                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa món đặt bàn DAO!");
            }
            return false;
        }
        public bool DeleteAllDatBan(int tableId)
        {
            int orderId = getOrderId(tableId);
            try
            {
                if (orderId == 0)
                    return false;
                string query = string.Format("delete from Orders where OrderId = {0}", orderId);

                if (DataProvider.Instance.ExecuteNonQuery(query) > 0) ;

                string query1 = string.Format("update TableFood set Status = N'Trống' where TableId = '{0}'", tableId);

                if (DataProvider.Instance.ExecuteNonQuery(query1) > 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa tất cả món đặt bàn DAO!");
            }
            return false;
        }
    }
}
