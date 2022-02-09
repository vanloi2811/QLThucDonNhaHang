using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThucDonNhaHang.DTO
{
    public class Table
    {
        
        private int tableId;
        private string tableName;
        private string status;

        public int TableId { get => tableId; set => tableId = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public string Status { get => status; set => status = value; }
        public Table() { }

        public Table(string tableName, string status)
        {
            this.tableName = tableName;
            this.status = status;
        }
        public Table(int tableId, string tableName, string status)
        {
            this.tableId = tableId;
            this.tableName = tableName;
            this.status = status;
        }
        public Table(int tableId, string tableName)
        {
            this.tableId = tableId;
            this.tableName = tableName;
        }
    }
}
