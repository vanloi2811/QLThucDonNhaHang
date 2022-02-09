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
    class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }
        }
        private TableDAO() { }
        
        public List<Table> LoadTable()
        {
            List<Table> tables = new List<Table>();
            string query = "select * from TableFood";
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    int tableId = (int)item["TableId"];
                    string tableName = item["TableName"].ToString();
                    string status = item["Status"].ToString();

                    Table t = new Table(tableId, tableName, status);

                    tables.Add(t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem bàn DAO!");
            }
            return tables;
        }
        public List<Table> ShowTable()
        {
            List<Table> tables = new List<Table>();
            string query = "select * from TableFood";
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    int tableId = (int)item["TableId"];
                    string tableName = item["TableName"].ToString();
                    string status = item["Status"].ToString();

                    Table t = new Table(tableId, tableName, status);

                    tables.Add(t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem bàn DAO!");
            }
            return tables;
        }
        public bool AddTable(Table t)
        {
            try
            {
                //DateTime now = DateTime.Now;

                string query = string.Format("insert into TableFood (TableName, Status) " +
                    "values (N'{0}', N'{1}')", t.TableName, t.Status);


                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm bàn DAO!");
            }
            return false;
        }

        public bool EditTable(Table t)
        {
            try
            {
                string query = string.Format("update TableFood set TableName = N'{0}' , Status = N'{1}' where TableId = '{2}'", t.TableName, t.Status, t.TableId);

                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa bàn DAO!");
            }

            return false;
        }

        public bool DeleteTable(int tableId)
        {
            try
            {
                if (tableId == 0)
                    return false;
                string query = string.Format("delete from TableFood where TableId = '{0}'", tableId);


                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa bàn DAO!");
            }
            return false;
        }
        public List<Table> SearchNameTable(string nameSearch)
        {
            List<Table> tables = new List<Table>();
            string query = string.Format("select * from TableFood where TableName like N'%{0}%'", nameSearch);
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {

                    int tableId = (int)item["TableId"];
                    string tableName = item["TableName"].ToString();
                    string status = item["Status"].ToString();

                    Table t = new Table(tableId, tableName, status);

                    tables.Add(t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm bàn theo tên DAO!");
            }
            return tables;
        }
    }
}
