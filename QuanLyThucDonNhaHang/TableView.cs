using QuanLyThucDonNhaHang.BUS;
using QuanLyThucDonNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThucDonNhaHang
{
    class TableView
    {
        private static TableView instance;

        public static TableView Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableView();
                return instance;
            }
        }

        private TableView() { }
        public void Load_StyleTable(DataGridView dtgvTable)
        {
            // Gán tiếng việt cho header
            dtgvTable.Columns[0].HeaderText = "Mã bàn";
            dtgvTable.Columns[1].HeaderText = "Tên bàn";
            dtgvTable.Columns[2].HeaderText = "Tình trạng";

            dtgvTable.Columns[0].Width = 130;
            dtgvTable.Columns[1].Width = 220;
            dtgvTable.Columns[2].Width = 155;
        }
        public static int TableWidth = 80;
        public static int TableHeight = 80;
        public List<Table> LoadTable()
        {
            List<Table> tables = new List<Table>();
            try
            {
                tables = TableBUS.Instance.LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load bàn BUS!");
            }
            return tables;
        }
        public void ShowTable(DataGridView dtgvTable)
        {
            try
            {
                TableBUS.Instance.ShowTable(dtgvTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem bàn View!");
            }
            Load_StyleTable(dtgvTable);
        }
        public void AddTable(string tableName, string status)
        {
            try
            {
                if (TableBUS.Instance.AddTable(tableName, status))
                {
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm bàn View!");
            }
        }
        public void EditTable(DataGridView dtgvTable)
        {
            try
            {
                if (TableBUS.Instance.EditTable(dtgvTable))
                {
                    MessageBox.Show("Sửa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa bàn View!");
            }
        }
        public void DeleteTable(DataGridView dtgvTable)
        {
            try
            {
                if (TableBUS.Instance.DeleteTable(dtgvTable))
                {
                    MessageBox.Show("Xóa thành công!");
                }

            }
            catch
            {
                MessageBox.Show("Lỗi xóa bàn View!");
            }

        }
        public void SearchNameTable(DataGridView dtgvTable, string nameSearch)
        {
            try
            {
                TableBUS.Instance.SearchNameTable(dtgvTable, nameSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm bàn theo sức chứa View!");
            }

        }
    }
}
