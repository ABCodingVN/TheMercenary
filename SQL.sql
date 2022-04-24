CREATE DATABASE TIKIAPP
USE TIKIAPP
drop table Categories
drop table Products
drop table Users
drop table Vouchers
drop table Orders

create table Categories(
CategoryId nvarchar(100) primary key,
Name nvarchar(100)
)

create table Products(
ProductId nvarchar(100) primary key,
CategoryId nvarchar(100),
Name nvarchar(100),
ImageURL nvarchar(200),
Price float,
Description nvarchar(3000),
Quantity int,
Size nvarchar(100),
Color nvarchar(100),
Origin nvarchar(100),
OriginBrand nvarchar(100),
LocalBrand nvarchar(100),
ExpiryDate datetime)

create table Users (
UserId nvarchar(100) primary key,
Name nvarchar(100),
Password nvarchar(100),
TypeAccount nvarchar(100),
PhoneNumber nvarchar(20),
Location nvarchar(100),
City nvarchar(100),
District nvarchar(100),
Wards nvarchar(100),
Address nvarchar(100),
Gmail nvarchar(100) )

create table Vouchers(
VoucherId nvarchar(100) primary key,
CodeVoucher nvarchar(100),
Name nvarchar(100),
CategoryVoucher nvarchar(100),
DateBegin datetime,
DateFinish datetime,
Quantity int,
QuantityUsed int,
PercentDiscount float,
MaxMoney float
)

create table Orders(
OrderId nvarchar(100) primary key,
ProductId nvarchar(100),
UserId nvarchar(100),
VoucherId nvarchar(100),
Quantity int,
TotalPayment float,
DiscountMoney float,
DateOrders datetime
)

insert into Categories values('CT01','Điện tử')
insert into Categories values('CT02','Thiết bị số')
insert into Categories values('CT03','Điện thoại')
insert into Categories values('CT04','Mẹ & Bé')
insert into Categories values('CT05','Làm đẹp')
insert into Categories values('CT06','Gia dụng')
insert into Categories values('CT07','Thời trang nữ')
insert into Categories values('CT08','Thời trang nam')
insert into Categories values('CT09','Giày nữ')
insert into Categories values('CT10','Túi nữ')
insert into Categories values('CT11','Balo & Vali')
insert into Categories values('CT12','Phụ kiện')
insert into Categories values('CT13','Đồng hồ')
insert into Categories values('CT14','Xe')
insert into Categories values('CT15','Sách')

insert into Products values('PD01','CT01', 'Smart Tivi Samsung 4K 50 inch UA50AU7700','https://salt.tikicdn.com/cache/400x400/ts/product/3a/0c/fe/09bbf1fad770994003014fcaa748b37d.jpg.webp', 11737700, 'PurColor Tái Hiện Sắc Màu Cuộc Sống, Rực Rỡ Và Sống Động Hơn Smart Tivi Samsung 4K 50 inch UA50AU7700 Mới 2021 - Choáng ngợp trước dải màu sắc hiển thị rộng lớn và rực rỡ từ công nghệ PurColor. Đắm chìm trong từng khung hình sống động và chân thực như bước ra từ cuộc sống.',20, 'null', 'null','Hàn Quốc', 'Hàn Quốc', 'SamSung', 21/01/2030  )
insert into Products values('PD02','CT01', 'Smart Tivi Samsung 4K 50 inch UA50AU7700','https://salt.tikicdn.com/cache/400x400/ts/product/3a/0c/fe/09bbf1fad770994003014fcaa748b37d.jpg.webp', 11737700, 'PurColor Tái Hiện Sắc Màu Cuộc Sống, Rực Rỡ Và Sống Động Hơn Smart Tivi Samsung 4K 50 inch UA50AU7700 Mới 2021 - Choáng ngợp trước dải màu sắc hiển thị rộng lớn và rực rỡ từ công nghệ PurColor. Đắm chìm trong từng khung hình sống động và chân thực như bước ra từ cuộc sống.',20, 'null', 'null','Hàn Quốc', 'Hàn Quốc', 'SamSung', 21/01/2030  )
insert into Products values('PD03','CT01', 'Smart Tivi Samsung 4K 50 inch UA50AU7700','https://salt.tikicdn.com/cache/400x400/ts/product/3a/0c/fe/09bbf1fad770994003014fcaa748b37d.jpg.webp', 11737700, 'PurColor Tái Hiện Sắc Màu Cuộc Sống, Rực Rỡ Và Sống Động Hơn Smart Tivi Samsung 4K 50 inch UA50AU7700 Mới 2021 - Choáng ngợp trước dải màu sắc hiển thị rộng lớn và rực rỡ từ công nghệ PurColor. Đắm chìm trong từng khung hình sống động và chân thực như bước ra từ cuộc sống.',20, 'null', 'null','Hàn Quốc', 'Hàn Quốc', 'SamSung', 21/01/2030  )

insert into Users values('US01', 'Nguyễn Thị Nhân', '12345678','user','0987654321', '34 đường 6','Hồ Chí Minh','Thủ Đức', 'Linh Trung','Tăng Nhơn Phú B','nguyenthinhan2101@gmail.com')
insert into Users values('US02', 'Bùi Quốc Huy', '12345678', 'user','0987654321', '34 đường 6', 'Hồ Chí Minh', 'Thủ Đức','Linh Trung', 'Tăng Nhơn Phú B', 'huybui@gmail.com')


insert into Vouchers values('VC01', 'NhanCute', 'Khuyến mãi tháng 5', 'TIKI khuyen mai',01/05/2022, 03/05/2022, 100, 2, 0.1, 30000 )
insert into Vouchers values('VC02', 'SaleDauThang', 'Khuyến mãi 1 tháng 5', 'freeship',10/05/2022, 25/05/2022, 100, 5, 0.1, 20000 )

insert into Orders values('OD01','PD01','US01','VC01',1,11727700, 10000, 22/04/2022)
insert into Orders values('OD02','PD02','US03','VC01',1,11727700, 10000, 24/04/2022)
insert into Orders values('OD03','PD03','US01','VC02',1,11727700, 10000, 23/04/2022)
