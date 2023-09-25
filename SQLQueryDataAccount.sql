
create database btnhomotp
go

--t?o b?ng l?u d? li?u
create table DataAccount
(
	UID nchar(10) PRIMARY KEY,
	Email nvarchar(50) unique not null ,
	MatKhau nchar(20) not null,
	TenNguoiDung nvarchar(50) not null
)

--xóa b?ng
drop table DataAccount

--thêm d? li?u
INSERT INTO DataAccount (UID, Email, MatKhau,TenNguoiDung) VALUES ('1', N'2worldteamsayshi@gmail.com','111', N'My team');

--INSERT INTO DataAccount (UID, Email, MatKhau,TenNguoiDung) VALUES ('2', N'phat23102003@gmail.com','111', N'My Account');
--INSERT INTO DataAccount (UID, Email, MatKhau,TenNguoiDung) VALUES ('3', N'phanngocduc818@gmail.com','12345', N'Your Account');

--xóa t?t c? d? li?u
delete DataAccount 

--in ra t?t c? d? li?u
select *
from DataAccount