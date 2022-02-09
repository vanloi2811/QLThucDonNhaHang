namespace QuanLyThucDonNhaHang
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tbTable = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchTable = new System.Windows.Forms.Button();
            this.btnResetTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTableNameSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFood = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchFoodName = new System.Windows.Forms.Button();
            this.txtFoodNameSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchPriceFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnResetFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cboCategoryid = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDatban = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgvDatBan = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeleteAllDatBan = new System.Windows.Forms.Button();
            this.btnEditDatBan = new System.Windows.Forms.Button();
            this.btnDeleteDatBan = new System.Windows.Forms.Button();
            this.btnAddDatBan = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.tpThanhToan = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgvThanhToan = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnThanhToanHoaDon = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotalPriceThanhToan = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboEmloyeeId = new System.Windows.Forms.ComboBox();
            this.cboTableIdThanhToan = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbEmloyee = new System.Windows.Forms.TabPage();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnResetEmployee = new System.Windows.Forms.Button();
            this.btnEditEmpoyee = new System.Windows.Forms.Button();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tcMenu.SuspendLayout();
            this.tbTable.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbFood.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel3.SuspendLayout();
            this.tbDatban.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatBan)).BeginInit();
            this.panel5.SuspendLayout();
            this.tpThanhToan.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThanhToan)).BeginInit();
            this.panel7.SuspendLayout();
            this.tbEmloyee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tbTable);
            this.tcMenu.Controls.Add(this.tbFood);
            this.tcMenu.Controls.Add(this.tbDatban);
            this.tcMenu.Controls.Add(this.tpThanhToan);
            this.tcMenu.Controls.Add(this.tbEmloyee);
            this.tcMenu.Location = new System.Drawing.Point(12, 12);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(1204, 657);
            this.tcMenu.TabIndex = 0;
            this.tcMenu.SelectedIndexChanged += new System.EventHandler(this.tcMenu_SelectedIndexChanged);
            // 
            // tbTable
            // 
            this.tbTable.BackColor = System.Drawing.Color.SkyBlue;
            this.tbTable.Controls.Add(this.panel2);
            this.tbTable.Controls.Add(this.panel1);
            this.tbTable.Location = new System.Drawing.Point(4, 25);
            this.tbTable.Name = "tbTable";
            this.tbTable.Padding = new System.Windows.Forms.Padding(3);
            this.tbTable.Size = new System.Drawing.Size(1196, 628);
            this.tbTable.TabIndex = 0;
            this.tbTable.Text = "Quản lý bàn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvTable);
            this.panel2.Location = new System.Drawing.Point(422, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 569);
            this.panel2.TabIndex = 1;
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTable.Location = new System.Drawing.Point(0, 0);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(746, 569);
            this.dtgvTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchTable);
            this.panel1.Controls.Add(this.btnResetTable);
            this.panel1.Controls.Add(this.btnDeleteTable);
            this.panel1.Controls.Add(this.btnEditTable);
            this.panel1.Controls.Add(this.btnAddTable);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTableNameSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTableName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 569);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTable.Location = new System.Drawing.Point(81, 473);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(174, 50);
            this.btnSearchTable.TabIndex = 23;
            this.btnSearchTable.Text = "Tìm bàn";
            this.btnSearchTable.UseVisualStyleBackColor = true;
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // btnResetTable
            // 
            this.btnResetTable.Location = new System.Drawing.Point(26, 333);
            this.btnResetTable.Name = "btnResetTable";
            this.btnResetTable.Size = new System.Drawing.Size(102, 41);
            this.btnResetTable.TabIndex = 20;
            this.btnResetTable.Text = "Xem lại bảng";
            this.btnResetTable.UseVisualStyleBackColor = true;
            this.btnResetTable.Click += new System.EventHandler(this.btnResetTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(186, 333);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(102, 41);
            this.btnDeleteTable.TabIndex = 21;
            this.btnDeleteTable.Text = "Xóa bàn";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(186, 251);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(102, 41);
            this.btnEditTable.TabIndex = 19;
            this.btnEditTable.Text = "Sửa bàn";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(26, 251);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(102, 41);
            this.btnAddTable.TabIndex = 18;
            this.btnAddTable.Text = "Thêm bàn";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(130, 149);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(158, 22);
            this.txtStatus.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tình trạng";
            // 
            // txtTableNameSearch
            // 
            this.txtTableNameSearch.Location = new System.Drawing.Point(190, 423);
            this.txtTableNameSearch.Name = "txtTableNameSearch";
            this.txtTableNameSearch.Size = new System.Drawing.Size(137, 22);
            this.txtTableNameSearch.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nhập tên bàn cần tìm";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(130, 104);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(158, 22);
            this.txtTableName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên bàn";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 67);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản lý bàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFood
            // 
            this.tbFood.BackColor = System.Drawing.Color.SkyBlue;
            this.tbFood.Controls.Add(this.panel4);
            this.tbFood.Controls.Add(this.panel3);
            this.tbFood.Location = new System.Drawing.Point(4, 25);
            this.tbFood.Name = "tbFood";
            this.tbFood.Padding = new System.Windows.Forms.Padding(3);
            this.tbFood.Size = new System.Drawing.Size(1196, 628);
            this.tbFood.TabIndex = 1;
            this.tbFood.Text = "Quản lý thực đơn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvFood);
            this.panel4.Location = new System.Drawing.Point(469, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(710, 592);
            this.panel4.TabIndex = 1;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(0, 0);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(710, 589);
            this.dtgvFood.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearchFoodName);
            this.panel3.Controls.Add(this.txtFoodNameSearch);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtMaxPrice);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtMinPrice);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnSearchPriceFood);
            this.panel3.Controls.Add(this.btnEditFood);
            this.panel3.Controls.Add(this.btnResetFood);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Controls.Add(this.cboCategoryid);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.txtFoodName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(18, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 592);
            this.panel3.TabIndex = 0;
            // 
            // btnSearchFoodName
            // 
            this.btnSearchFoodName.Location = new System.Drawing.Point(137, 447);
            this.btnSearchFoodName.Name = "btnSearchFoodName";
            this.btnSearchFoodName.Size = new System.Drawing.Size(129, 32);
            this.btnSearchFoodName.TabIndex = 32;
            this.btnSearchFoodName.Text = "Tìm theo tên";
            this.btnSearchFoodName.UseVisualStyleBackColor = true;
            this.btnSearchFoodName.Click += new System.EventHandler(this.btnSearchFoodName_Click);
            // 
            // txtFoodNameSearch
            // 
            this.txtFoodNameSearch.Location = new System.Drawing.Point(240, 419);
            this.txtFoodNameSearch.Name = "txtFoodNameSearch";
            this.txtFoodNameSearch.Size = new System.Drawing.Size(141, 22);
            this.txtFoodNameSearch.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(47, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "Nhập tên món ăn cần tìm";
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(123, 544);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(95, 22);
            this.txtMaxPrice.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(47, 546);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Giá đến:";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(123, 501);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(95, 22);
            this.txtMinPrice.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(47, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Giá từ:";
            // 
            // btnSearchPriceFood
            // 
            this.btnSearchPriceFood.Location = new System.Drawing.Point(249, 513);
            this.btnSearchPriceFood.Name = "btnSearchPriceFood";
            this.btnSearchPriceFood.Size = new System.Drawing.Size(109, 44);
            this.btnSearchPriceFood.TabIndex = 28;
            this.btnSearchPriceFood.Text = "Tìm theo giá";
            this.btnSearchPriceFood.UseVisualStyleBackColor = true;
            this.btnSearchPriceFood.Click += new System.EventHandler(this.btnSearchPriceFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(240, 267);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(129, 48);
            this.btnEditFood.TabIndex = 25;
            this.btnEditFood.Text = "Sửa món ăn";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnResetFood
            // 
            this.btnResetFood.Location = new System.Drawing.Point(50, 345);
            this.btnResetFood.Name = "btnResetFood";
            this.btnResetFood.Size = new System.Drawing.Size(129, 48);
            this.btnResetFood.TabIndex = 29;
            this.btnResetFood.Text = "Xem lại bảng";
            this.btnResetFood.UseVisualStyleBackColor = true;
            this.btnResetFood.Click += new System.EventHandler(this.btnResetFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(240, 345);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(129, 48);
            this.btnDeleteFood.TabIndex = 24;
            this.btnDeleteFood.Text = "Xóa món ăn";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(50, 267);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(129, 48);
            this.btnAddFood.TabIndex = 21;
            this.btnAddFood.Text = "Thêm món ăn";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cboCategoryid
            // 
            this.cboCategoryid.FormattingEnabled = true;
            this.cboCategoryid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboCategoryid.Location = new System.Drawing.Point(197, 213);
            this.cboCategoryid.Name = "cboCategoryid";
            this.cboCategoryid.Size = new System.Drawing.Size(184, 24);
            this.cboCategoryid.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(47, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã loại món ăn";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(197, 158);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(184, 22);
            this.txtPrice.TabIndex = 18;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(197, 114);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(184, 22);
            this.txtFoodName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(47, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(47, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tên món ăn";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 65);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quản lý thực đơn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDatban
            // 
            this.tbDatban.BackColor = System.Drawing.Color.SkyBlue;
            this.tbDatban.Controls.Add(this.panel6);
            this.tbDatban.Controls.Add(this.panel5);
            this.tbDatban.Controls.Add(this.flpTable);
            this.tbDatban.Location = new System.Drawing.Point(4, 25);
            this.tbDatban.Name = "tbDatban";
            this.tbDatban.Padding = new System.Windows.Forms.Padding(3);
            this.tbDatban.Size = new System.Drawing.Size(1196, 628);
            this.tbDatban.TabIndex = 2;
            this.tbDatban.Text = "Đặt bàn";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtgvDatBan);
            this.panel6.Location = new System.Drawing.Point(572, 203);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(618, 408);
            this.panel6.TabIndex = 2;
            // 
            // dtgvDatBan
            // 
            this.dtgvDatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatBan.Location = new System.Drawing.Point(3, 3);
            this.dtgvDatBan.Name = "dtgvDatBan";
            this.dtgvDatBan.RowHeadersWidth = 51;
            this.dtgvDatBan.RowTemplate.Height = 24;
            this.dtgvDatBan.Size = new System.Drawing.Size(612, 402);
            this.dtgvDatBan.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeleteAllDatBan);
            this.panel5.Controls.Add(this.btnEditDatBan);
            this.panel5.Controls.Add(this.btnDeleteDatBan);
            this.panel5.Controls.Add(this.btnAddDatBan);
            this.panel5.Controls.Add(this.txtQuantity);
            this.panel5.Controls.Add(this.cboFood);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(572, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(621, 191);
            this.panel5.TabIndex = 1;
            // 
            // btnDeleteAllDatBan
            // 
            this.btnDeleteAllDatBan.Location = new System.Drawing.Point(483, 123);
            this.btnDeleteAllDatBan.Name = "btnDeleteAllDatBan";
            this.btnDeleteAllDatBan.Size = new System.Drawing.Size(114, 48);
            this.btnDeleteAllDatBan.TabIndex = 26;
            this.btnDeleteAllDatBan.Text = "Hủy đặt bàn";
            this.btnDeleteAllDatBan.UseVisualStyleBackColor = true;
            this.btnDeleteAllDatBan.Click += new System.EventHandler(this.btnDeleteAllDatBan_Click);
            // 
            // btnEditDatBan
            // 
            this.btnEditDatBan.Location = new System.Drawing.Point(483, 69);
            this.btnEditDatBan.Name = "btnEditDatBan";
            this.btnEditDatBan.Size = new System.Drawing.Size(114, 48);
            this.btnEditDatBan.TabIndex = 25;
            this.btnEditDatBan.Text = "Sửa món";
            this.btnEditDatBan.UseVisualStyleBackColor = true;
            this.btnEditDatBan.Click += new System.EventHandler(this.btnEditDatBan_Click);
            // 
            // btnDeleteDatBan
            // 
            this.btnDeleteDatBan.Location = new System.Drawing.Point(324, 123);
            this.btnDeleteDatBan.Name = "btnDeleteDatBan";
            this.btnDeleteDatBan.Size = new System.Drawing.Size(116, 48);
            this.btnDeleteDatBan.TabIndex = 24;
            this.btnDeleteDatBan.Text = "Xóa món";
            this.btnDeleteDatBan.UseVisualStyleBackColor = true;
            this.btnDeleteDatBan.Click += new System.EventHandler(this.btnDeleteDatBan_Click);
            // 
            // btnAddDatBan
            // 
            this.btnAddDatBan.Location = new System.Drawing.Point(324, 69);
            this.btnAddDatBan.Name = "btnAddDatBan";
            this.btnAddDatBan.Size = new System.Drawing.Size(116, 48);
            this.btnAddDatBan.TabIndex = 23;
            this.btnAddDatBan.Text = "Thêm món";
            this.btnAddDatBan.UseVisualStyleBackColor = true;
            this.btnAddDatBan.Click += new System.EventHandler(this.btnAddDatBan_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(451, 24);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(128, 22);
            this.txtQuantity.TabIndex = 22;
            // 
            // cboFood
            // 
            this.cboFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboFood.Location = new System.Drawing.Point(123, 27);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(184, 144);
            this.cboFood.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(342, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(15, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "Chọn món ăn";
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(6, 6);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(560, 605);
            this.flpTable.TabIndex = 0;
            // 
            // tpThanhToan
            // 
            this.tpThanhToan.BackColor = System.Drawing.Color.SkyBlue;
            this.tpThanhToan.Controls.Add(this.panel8);
            this.tpThanhToan.Controls.Add(this.panel7);
            this.tpThanhToan.Location = new System.Drawing.Point(4, 25);
            this.tpThanhToan.Name = "tpThanhToan";
            this.tpThanhToan.Padding = new System.Windows.Forms.Padding(3);
            this.tpThanhToan.Size = new System.Drawing.Size(1196, 628);
            this.tpThanhToan.TabIndex = 3;
            this.tpThanhToan.Text = "Thanh Toán";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgvThanhToan);
            this.panel8.Location = new System.Drawing.Point(539, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(651, 616);
            this.panel8.TabIndex = 1;
            // 
            // dtgvThanhToan
            // 
            this.dtgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThanhToan.Location = new System.Drawing.Point(3, 3);
            this.dtgvThanhToan.Name = "dtgvThanhToan";
            this.dtgvThanhToan.RowHeadersWidth = 51;
            this.dtgvThanhToan.RowTemplate.Height = 24;
            this.dtgvThanhToan.Size = new System.Drawing.Size(648, 610);
            this.dtgvThanhToan.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnThanhToanHoaDon);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.txtTotalPriceThanhToan);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.cboEmloyeeId);
            this.panel7.Controls.Add(this.cboTableIdThanhToan);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(6, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(527, 616);
            this.panel7.TabIndex = 0;
            // 
            // btnThanhToanHoaDon
            // 
            this.btnThanhToanHoaDon.Location = new System.Drawing.Point(202, 373);
            this.btnThanhToanHoaDon.Name = "btnThanhToanHoaDon";
            this.btnThanhToanHoaDon.Size = new System.Drawing.Size(129, 48);
            this.btnThanhToanHoaDon.TabIndex = 26;
            this.btnThanhToanHoaDon.Text = "Thanh toán";
            this.btnThanhToanHoaDon.UseVisualStyleBackColor = true;
            this.btnThanhToanHoaDon.Click += new System.EventHandler(this.btnThanhToanHoaDon_Click);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(96, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(314, 40);
            this.label17.TabIndex = 25;
            this.label17.Text = "Thanh Toán Hóa Đơn";
            // 
            // txtTotalPriceThanhToan
            // 
            this.txtTotalPriceThanhToan.Location = new System.Drawing.Point(226, 284);
            this.txtTotalPriceThanhToan.Name = "txtTotalPriceThanhToan";
            this.txtTotalPriceThanhToan.Size = new System.Drawing.Size(184, 22);
            this.txtTotalPriceThanhToan.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(93, 287);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 25);
            this.label16.TabIndex = 23;
            this.label16.Text = "Tổng tiền";
            // 
            // cboEmloyeeId
            // 
            this.cboEmloyeeId.FormattingEnabled = true;
            this.cboEmloyeeId.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboEmloyeeId.Location = new System.Drawing.Point(226, 224);
            this.cboEmloyeeId.Name = "cboEmloyeeId";
            this.cboEmloyeeId.Size = new System.Drawing.Size(184, 24);
            this.cboEmloyeeId.TabIndex = 22;
            // 
            // cboTableIdThanhToan
            // 
            this.cboTableIdThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableIdThanhToan.FormattingEnabled = true;
            this.cboTableIdThanhToan.Location = new System.Drawing.Point(226, 165);
            this.cboTableIdThanhToan.Name = "cboTableIdThanhToan";
            this.cboTableIdThanhToan.Size = new System.Drawing.Size(184, 24);
            this.cboTableIdThanhToan.TabIndex = 21;
            this.cboTableIdThanhToan.SelectedIndexChanged += new System.EventHandler(this.cboTableIdThanhToan_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(93, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 25);
            this.label15.TabIndex = 19;
            this.label15.Text = "Mã nhân viên";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(93, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "Mã bàn";
            // 
            // tbEmloyee
            // 
            this.tbEmloyee.BackColor = System.Drawing.Color.SkyBlue;
            this.tbEmloyee.Controls.Add(this.dtgvEmployee);
            this.tbEmloyee.Controls.Add(this.panel9);
            this.tbEmloyee.Location = new System.Drawing.Point(4, 25);
            this.tbEmloyee.Name = "tbEmloyee";
            this.tbEmloyee.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmloyee.Size = new System.Drawing.Size(1196, 628);
            this.tbEmloyee.TabIndex = 4;
            this.tbEmloyee.Text = "Quản lý nhân viên";
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Location = new System.Drawing.Point(446, 26);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowHeadersWidth = 51;
            this.dtgvEmployee.RowTemplate.Height = 24;
            this.dtgvEmployee.Size = new System.Drawing.Size(731, 569);
            this.dtgvEmployee.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnSearchEmployee);
            this.panel9.Controls.Add(this.btnResetEmployee);
            this.panel9.Controls.Add(this.btnEditEmpoyee);
            this.panel9.Controls.Add(this.txtSearchEmployee);
            this.panel9.Controls.Add(this.label19);
            this.panel9.Controls.Add(this.label21);
            this.panel9.Location = new System.Drawing.Point(33, 26);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(369, 569);
            this.panel9.TabIndex = 1;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(129, 300);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(112, 66);
            this.btnSearchEmployee.TabIndex = 23;
            this.btnSearchEmployee.Text = "Tìm nhân viên";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnResetEmployee
            // 
            this.btnResetEmployee.Location = new System.Drawing.Point(212, 154);
            this.btnResetEmployee.Name = "btnResetEmployee";
            this.btnResetEmployee.Size = new System.Drawing.Size(102, 41);
            this.btnResetEmployee.TabIndex = 20;
            this.btnResetEmployee.Text = "Xem lại bảng";
            this.btnResetEmployee.UseVisualStyleBackColor = true;
            this.btnResetEmployee.Click += new System.EventHandler(this.btnResetEmployee_Click);
            // 
            // btnEditEmpoyee
            // 
            this.btnEditEmpoyee.Location = new System.Drawing.Point(66, 154);
            this.btnEditEmpoyee.Name = "btnEditEmpoyee";
            this.btnEditEmpoyee.Size = new System.Drawing.Size(102, 41);
            this.btnEditEmpoyee.TabIndex = 19;
            this.btnEditEmpoyee.Text = "Sửa";
            this.btnEditEmpoyee.UseVisualStyleBackColor = true;
            this.btnEditEmpoyee.Click += new System.EventHandler(this.btnEditEmpoyee_Click);
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(119, 256);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(137, 22);
            this.txtSearchEmployee.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(89, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(198, 24);
            this.label19.TabIndex = 12;
            this.label19.Text = "Nhập tên nhân viên cần tìm";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(85, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(191, 95);
            this.label21.TabIndex = 10;
            this.label21.Text = "Quản lý nhân viên";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1228, 681);
            this.Controls.Add(this.tcMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thực đơn nhà hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMenu.ResumeLayout(false);
            this.tbTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbFood.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tbDatban.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatBan)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tpThanhToan.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThanhToan)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tbEmloyee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tbTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchTable;
        private System.Windows.Forms.Button btnResetTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTableNameSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchPriceFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnResetFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cboCategoryid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFoodNameSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchFoodName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TabPage tbDatban;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dtgvDatBan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDeleteAllDatBan;
        private System.Windows.Forms.Button btnEditDatBan;
        private System.Windows.Forms.Button btnDeleteDatBan;
        private System.Windows.Forms.Button btnAddDatBan;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tpThanhToan;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgvThanhToan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cboEmloyeeId;
        private System.Windows.Forms.ComboBox cboTableIdThanhToan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnThanhToanHoaDon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalPriceThanhToan;
        private System.Windows.Forms.TabPage tbEmloyee;
        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnResetEmployee;
        private System.Windows.Forms.Button btnEditEmpoyee;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
    }
}

