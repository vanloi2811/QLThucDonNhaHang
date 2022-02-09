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
    class TableBUS
    {
        private static TableBUS instance;
        public static TableBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableBUS();
                return instance;
            }
        }

        private TableBUS() { }
        public List<Table> LoadTable()
        {
            List<Table> tables = new List<Table>();
            try 
            {                
                tables = TableDAO.Instance.LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load bàn BUS!");
            }
            return tables;
        }

        public void ShowTable(DataGridView data)
        {
            try
            {
                data.DataSource = TableDAO.Instance.ShowTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem bàn BUS!");
            }
        }

        public bool AddTable(string tableName, string status)
        {
            try
            {
                Table t = new Table(tableName, status);
                if (TableDAO.Instance.AddTable(t))
                    return true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm bàn BUS!");
            }
            return false;
        }

        public bool EditTable(DataGridView data)
        {
            try
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                
                int tableId = (int)row.Cells["TableId"].Value;
                string tableName = row.Cells["TableName"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                Table t = new Table(tableId, tableName, status);
                if (TableDAO.Instance.EditTable(t))
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa bàn BUS!");
            }

            return false;
        }
        public bool DeleteTable(DataGridView data)
        {
            try
            {
                DataGridViewRow row = data.SelectedCells[0].OwningRow;
                int tableId = (int)row.Cells["TableId"].Value;

                if (TableDAO.Instance.DeleteTable(tableId))
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa bàn BUS!");
            }

            return false;
        }
        public void SearchNameTable(DataGridView data, string nameSearch)
        {
            try
            {
                data.DataSource = TableDAO.Instance.SearchNameTable(nameSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm bàn theo tên BUS!");
            }
        }
    }
}
