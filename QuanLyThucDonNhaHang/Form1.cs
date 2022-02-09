using QuanLyThucDonNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyThucDonNhaHang
{
    public partial class Form1 : Form
    {
        //phân quyền
        int id = 0;
        string userName = "";
        string passWord = "";
        int type = 0;
        public Form1(int id, string userName, string passWord, int type)
        {
            InitializeComponent();
            LoadTable();
            this.id = id;
            this.userName = userName;
            this.passWord = passWord;
            this.type = type;
            if(type != 1)
            {
                btnAddTable.Enabled = false;
                btnDeleteTable.Enabled = false;
                btnEditTable.Enabled = false;
                btnAddFood.Enabled = false;
                btnEditFood.Enabled = false;
                btnDeleteFood.Enabled = false;
                tcMenu.TabPages.Remove(tbEmloyee);
            }
        }
        public Form1()
        {
            InitializeComponent();
            //LoadTable();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableView.Instance.ShowTable(dtgvTable);
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            //if (type == 1)
            //{
                try
                {
                    string tableName = txtTableName.Text.Trim();
                    string status = txtStatus.Text.Trim();

                    TableView.Instance.AddTable(tableName, status);
                    TableView.Instance.ShowTable(dtgvTable);
                    txtTableName.Text = "";
                    txtStatus.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm bàn form!");
                }
            //}
            //else
            //    btnAddTable.Enabled = false;
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            TableView.Instance.EditTable(dtgvTable);
            TableView.Instance.ShowTable(dtgvTable);
        }

        private void btnResetTable_Click(object sender, EventArgs e)
        {
            TableView.Instance.ShowTable(dtgvTable);
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TableView.Instance.DeleteTable(dtgvTable);
                TableView.Instance.ShowTable(dtgvTable);
            }
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            try
            {
                string nameSearch = txtTableNameSearch.Text;
                TableView.Instance.SearchNameTable(dtgvTable, nameSearch);
                txtTableNameSearch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm theo tên ở form!");
            }
        }

        private void tcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcMenu.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    FoodView.Instance.ShowFood(dtgvFood);
                    FoodView.Instance.Load_CategoryId(cboCategoryid);
                    break;
                case 2:
                    
                    DatBanView.Instance.Load_Food(cboFood);
                    LoadTable();
                    break;
                case 3:
                    ThanhToanView.Instance.Load_TableThanhToan(cboTableIdThanhToan);
                    ThanhToanView.Instance.Load_EmployeeId(cboEmloyeeId);
                    break;
                default:
                    EmployeeView.Instance.ShowEmployee(dtgvEmployee);
                    break;
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string foodName = txtFoodName.Text.Trim();
                double price = double.Parse(txtPrice.Text);
                int categoryId = int.Parse(cboCategoryid.SelectedItem.ToString());

                FoodView.Instance.AddFood(foodName, price, categoryId);
                FoodView.Instance.ShowFood(dtgvFood);

                txtFoodName.Text = "";
                txtPrice.Text = "";
                cboCategoryid.SelectedItem = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm ở form!");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FoodView.Instance.DeleteFood(dtgvFood);
                FoodView.Instance.ShowFood(dtgvFood);
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            FoodView.Instance.EditFood(dtgvFood);
            FoodView.Instance.ShowFood(dtgvFood);
        }

        private void btnResetFood_Click(object sender, EventArgs e)
        {
            FoodView.Instance.ShowFood(dtgvFood);
        }

        private void btnSearchFoodName_Click(object sender, EventArgs e)
        {
            try
            {
                string nameSearch = txtFoodNameSearch.Text;
                FoodView.Instance.SearchNameFood(dtgvFood, nameSearch);
                txtFoodNameSearch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm món ăn theo tên ở form!");
            }
        }

        private void btnSearchPriceFood_Click(object sender, EventArgs e)
        {
            try
            {
                int minPrice = int.Parse(txtMinPrice.Text);
                int maxPrice = int.Parse(txtMaxPrice.Text);
                FoodView.Instance.SearchPriceFood(dtgvFood, minPrice, maxPrice);
                txtMinPrice.Text = "";
                txtMaxPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm theo khoảng giá ở form!");
            }
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tables = TableView.Instance.LoadTable();

            foreach(Table item in tables)
            {
                Button btn = new Button() { Width = TableView.TableWidth, Height = TableView.TableHeight };
                btn.Text =  item.TableName + "\n" + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch(item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightGray;
                        break;
                }    
                flpTable.Controls.Add(btn);
            }    
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as Table).TableId;
            dtgvDatBan.Tag = (sender as Button).Tag;
            DatBanView.Instance.ShowDatBan(dtgvDatBan, tableId);
        }    
        private void btnAddDatBan_Click(object sender, EventArgs e)
        {
            Table table = dtgvDatBan.Tag as Table;
            string[] foodIdName = cboFood.SelectedItem.ToString().Split(' ');
            int foodId = int.Parse(foodIdName[0]);
            int quantity = int.Parse(txtQuantity.Text);
            DatBanView.Instance.AddDatBan(table.TableId, foodId, quantity);
            ThanhToanView.Instance.Load_TableThanhToan(cboTableIdThanhToan);
            DatBanView.Instance.ShowDatBan(dtgvDatBan, table.TableId);
            TableView.Instance.ShowTable(dtgvTable);
            LoadTable();
            txtQuantity.Text = "";
        }

        private void btnEditDatBan_Click(object sender, EventArgs e)
        {
            Table table = dtgvDatBan.Tag as Table;
            DatBanView.Instance.EditDatBan(dtgvDatBan, table.TableId);
            DatBanView.Instance.ShowDatBan(dtgvDatBan, table.TableId);
        }

        private void btnDeleteDatBan_Click(object sender, EventArgs e)
        {
            Table table = dtgvDatBan.Tag as Table;
            if(dtgvDatBan.RowCount > 1)
            {
                DatBanView.Instance.DeleteDatBan(dtgvDatBan, table.TableId);
                DatBanView.Instance.ShowDatBan(dtgvDatBan, table.TableId);
            }
            else
                MessageBox.Show("Số món còn lại quá ít!");
            
        }

        private void btnDeleteAllDatBan_Click(object sender, EventArgs e)
        {
            Table table = dtgvDatBan.Tag as Table;
            DatBanView.Instance.DeleteAllDatBan(table.TableId);
            DatBanView.Instance.ShowDatBan(dtgvDatBan, table.TableId);
            LoadTable();
            TableView.Instance.ShowTable(dtgvTable);
        }

        private void cboTableIdThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tableIdName = cboTableIdThanhToan.SelectedItem.ToString().Split(' ');
            int tableId = int.Parse(tableIdName[0]);
            if (tableId != 0)
            {
                ThanhToanView.Instance.ShowThanhToan(dtgvThanhToan, tableId);
                ThanhToanView.Instance.Load_TotalPrice(txtTotalPriceThanhToan, tableId);
            }
            else
                dtgvThanhToan.DataSource = null;
        }

        private void btnThanhToanHoaDon_Click(object sender, EventArgs e)
        {
            string[] tableIdName = cboTableIdThanhToan.SelectedItem.ToString().Split(' ');
            int tableId = int.Parse(tableIdName[0]);
            if (cboTableIdThanhToan.SelectedItem == null)
            {
                MessageBox.Show("Bạn không chọn mã bàn!");
                return;
            }
            if (cboEmloyeeId.SelectedItem == null)
            {
                MessageBox.Show("Bạn không chọn mã nhân viên!");
                return;
            }
            if (ThanhToanView.Instance.ThanhToanHoaDon(tableId, txtTotalPriceThanhToan.Text))
            {
                MessageBox.Show("Thanh toán thành công!");

                string fileExcel = "";

                for (int i = 0; i < 1000; i++)
                {
                    fileExcel = "C:\\Users\\loi2\\Desktop\\HoaDonThanhToan\\HoaDon" + i.ToString() + ".xlsx";
                    if (File.Exists(fileExcel) == false)
                    {
                        break;
                    }
                }

                Excel.Application oApp;
                Excel.Worksheet oSheet;
                Excel.Workbook oBook;

                oApp = new Excel.Application();
                oBook = oApp.Workbooks.Add();
                oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);

                oSheet.Cells[1, 2] = "HÓA";
                oSheet.Cells[1, 3] = "ĐƠN";
                oSheet.Cells[1, 4] = "THANH";
                oSheet.Cells[1, 5] = "TOÁN";

                oSheet.Cells[3, 1] = "Bàn thanh toán";
                oSheet.Cells[3, 2] = "Mã nhân viên";
                oSheet.Cells[3, 3] = "Tổng tiền thanh toán";

                oSheet.Cells[4, 1] = cboTableIdThanhToan.Text.Trim();
                oSheet.Cells[4, 2] = cboEmloyeeId.Text.Trim();
                oSheet.Cells[4, 3] = txtTotalPriceThanhToan.Text.Trim();

                oSheet.Cells[6, 1] = "Danh sách món ăn thanh toán:";

                for (int i = 1; i < dtgvThanhToan.Columns.Count + 1; i++)
                {
                    oSheet.Cells[7, i] = dtgvThanhToan.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dtgvThanhToan.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgvThanhToan.Columns.Count; j++)
                    {
                        oSheet.Cells[i + 8, j + 1] = dtgvThanhToan.Rows[i].Cells[j].Value.ToString();
                    }
                }

                oBook.SaveAs(fileExcel);
                oBook.Close();
                oApp.Quit();

                txtTotalPriceThanhToan.Text = "";
                ThanhToanView.Instance.ShowThanhToan(dtgvThanhToan, 0);
                cboTableIdThanhToan.SelectedIndex = 0;
                ThanhToanView.Instance.Load_TableThanhToan(cboTableIdThanhToan);
                DatBanView.Instance.Load_Food(cboFood);
                TableView.Instance.ShowTable(dtgvTable);
                LoadTable();
            }

            else
                MessageBox.Show("Thanh toán thất bại!");
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string nameSearch = txtSearchEmployee.Text;
                EmployeeView.Instance.SearchNameEmployee(dtgvEmployee, nameSearch);
                txtSearchEmployee.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm nhân viên theo tên ở form!");
            }
        }

        private void btnResetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeView.Instance.ShowEmployee(dtgvEmployee);
        }

        private void btnEditEmpoyee_Click(object sender, EventArgs e)
        {
            EmployeeView.Instance.EditEmployee(dtgvEmployee);
            EmployeeView.Instance.ShowEmployee(dtgvEmployee);
        }
    }
}
