create database QuanLyThucDon
go

use QuanLyThucDon
go

--Account
--Employee
--Table
--Food
--Category
--Order
--OrderDetail

create table Account
(
	Id int identity primary key,
	UserName nvarchar(100) not null,
	PassWord nvarchar(100) not null,
	Type int not null		-- 1: admin, 2: nhân viên
)
go

create table Employee
(
	EmployeeId int identity primary key,
	EmployeeName nvarchar(100) not null,
	Service int not null, -- 1: admin, 2: nhân viên
	AccountId int not null

	foreign key (AccountId) references dbo.Account(id)
)
go


create table TableFood
(
	TableId int identity primary key,
	TableName nvarchar(100) not null,
	Status nvarchar(100) not null default N'Trống' -- Trống // Đã Đặt
)
go

create table Category
(
	CategoryId int identity primary key,
	CategoryName nvarchar(100) not null,
	Description nvarchar(100)
)
go

create table Food
(
	FoodId int identity primary key,
	FoodName nvarchar(100) not null,
	Price float not null default 0,
	CategoryId int not null

	foreign key (CategoryId) references dbo.Category(CategoryId)
)
go

create table Orders
(
	OrderId int identity primary key,
	CreateDate datetime not null default getdate(),
	TotalPrice float not null,
	Paid bit not null default 0, --0 chưa thanh toán, 1 thanh toán rồi
	TableId int not null,
	EmployeeId int not null

	foreign key (TableId) references dbo.TableFood(TableId),
	foreign key (EmployeeId) references dbo.Employee(EmployeeId),
)
go

create table OrderDetail
(
	OrderId int not null,
	FoodId int not null,
	Quantity int not null

	primary key(OrderId, FoodId)
	foreign key (OrderId) references dbo.Orders(OrderId) on delete cascade,
	foreign key (FoodId) references dbo.Food(FoodId)
)
go

--thêm dữ liệu

insert into Account(UserName, PassWord, Type) values ('admin', '1111', 1),
('nhanvien1', '2222', 2),
('nhanvien2', '3333', 2)
go

insert into Employee(EmployeeName, Service, AccountId) values (N'Trần Văn Lợi', 1, 1),
(N'Nguyễn Bá Hà', 2, 2),
(N'Trần Thanh Mai', 2, 3)
go

insert into TableFood(TableName, Status) values(N'Bàn số 1', N'Trống'),
(N'Bàn số 2', N'Trống'),
(N'Bàn số 3', N'Trống'),
(N'Bàn số 4', N'Trống'),
(N'Bàn số 5', N'Trống'),
(N'Bàn số 6', N'Trống'),
(N'Bàn số 7', N'Trống'),
(N'Bàn số 8', N'Trống')
go

insert into Category(CategoryName, Description) values (N'Hải sản', N'Đồ biển'),
(N'Lẩu', N'Các loại cá, mực, nấm,...'),
(N'Đồ Nướng', N'Các loại thịt, rau')
go

insert into Food(FoodName, Price, CategoryId) values (N'Bào ngư', 500000, 1),
(N'Lẩu cá kèo', 200000, 2),
(N'Lẩu thập cẩm', 250000, 2),
(N'Thịt bò nướng', 150000, 3),
(N'Cà tím nướng', 50000, 3),
(N'Tôm hùm', 200000, 1)

insert into Orders(OrderId, CreateDate, TotalPrice, Paid, TableId, EmployeeId) values (1, CAST(N'2021-09-06 17:03:50.120' AS DateTime), 0, 0, 1, 1),
(2, CAST(N'2021-10-01 19:05:50.120' AS DateTime), 400000, 1, 3, 1),
(3, CAST(N'2021-10-11 20:05:50.120' AS DateTime), 0, 0, 5, 1)
go

insert into OrderDetail(OrderId, FoodId, Quantity) values (1, 2, 1),
(1, 2, 1),
(2, 4, 2),
(2, 5, 2),
(3, 1, 2),
(3, 6, 5)
go