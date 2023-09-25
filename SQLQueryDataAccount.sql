
create database btnhomotp
go

--tạo bảng lưu dữ liệu
create table DataAccount
(
	UID nchar(10) PRIMARY KEY,
	Email nvarchar(50) unique not null ,
	MatKhau nchar(20) not null,
	TenNguoiDung nvarchar(50) not null
)

--xóa bảng
drop table DataAccount

--thêm dữ liệu
INSERT INTO DataAccount (UID, Email, MatKhau,TenNguoiDung) VALUES ('1', N'2worldteamsayshi@gmail.com','111', N'My team');

--INSERT INTO DataAccount (UID, Email, MatKhau,TenNguoiDung) VALUES ('2', N'phat23102003@gmail.com','111', N'My Account');
--INSERT INTO DataAccount (UID, Email, MatKhau,TenNguoiDung) VALUES ('3', N'phanngocduc818@gmail.com','12345', N'Your Account');

--xóa tất cả dữ liệu
delete DataAccount 

--in ra tất cả dữ liệu
select *
from DataAccount