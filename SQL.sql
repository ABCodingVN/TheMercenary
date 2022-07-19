CREATE DATABASE TIKI COLLATE Latin1_General_100_CI_AI_SC_UTF8
USE TIKI
<<<<<<< HEAD
=======
drop table Categories
drop table Products
drop table Supplier
drop table Ratting
drop table ReplyRatting

drop table Users
drop table Vouchers
drop table Orders
>>>>>>> main

create table Categories(
CategoryId nvarchar(100) primary key,
Name nvarchar(100)
)

create table Products(
ProductId nvarchar(100) primary key,
SupplierId nvarchar(100),
CategoryId nvarchar(100),
RattingId nvarchar(100),
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
WardsID nvarchar(100),
Name nvarchar(100),
Password nvarchar(100),
TypeAccount nvarchar(100),
PhoneNumber nvarchar(20),
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

create table Ratting(
RattingId nvarchar(100) primary key,
ProductId nvarchar(100),
Status nvarchar(100),
PointStar float,
Describe nvarchar(300),
ImageURL nvarchar(200),
VideoURL nvarchar(200),
Time datetime,
Likee int
)

create table Supplier(
SupplierId nvarchar(100) primary key,
NameShop nvarchar(100),
QuantityFollower int,
AddressShop nvarchar(100),
PercentRepChat float
)

create table ReplyRatting(
ReplyId nvarchar(100) primary key,
SupplierId nvarchar(100),
RattingId nvarchar(100),
Describe nvarchar(100),
Time datetime,
Likee int
)

create table Province(
ProvinceId nvarchar(100) primary key,
NameProvince nvarchar(100)
)


create table District(
DistrictId nvarchar(100) primary key,
ProvinceId nvarchar(100),
NameDistrict nvarchar(100)
)


create table Wards(
WardsId nvarchar(100) primary key,
DistrictId nvarchar(100),
NameWards nvarchar(100)
)

Insert into Province values('PR01','Quảng Bình')
Insert into Province values('PR02','Hà Nội')
Insert into Province values('PR03','Hồ Chí Minh')
Insert into Province values('PR04','Gia Lai')


Insert into District values('DT01','PR01','Lệ Thủy')
Insert into District values('DT02','PR01','Quảng Ninh')
Insert into District values('DT03','PR02','Cầu giấy')
Insert into District values('DT04','PR02','Hà Đông')
Insert into District values('DT05','PR03','Quận 1')
Insert into District values('DT06','PR03','Quận 3')



Insert into Wards values('W01','DT01','Hoa Thủy')
Insert into Wards values('W02','DT01','Sơn Thủy')
Insert into Wards values('W03','DT02','Dinh Mười')
Insert into Wards values('W04','DT02','Vạn Ninh')
Insert into Wards values('W05','DT03','Mai Dịch')


insert into Ratting values('RT01', 'PD01','Hài lòng', 4.5, 'Hàng đẹp, giao hàng nhanh', 'link url ảnh ne', 'link url video ne',01/05/2022, 1)
insert into Ratting values('RT02', 'PD02','Không hài lòng', 3, 'Hàng xấu, giao hàng nhanh', 'link url ảnh ne', 'link url video ne',01/06/2022, 1)
insert into Ratting values('RT03','PD03','Quá tồi tệ', 1, 'Hàng tệ, giao hàng chậm', 'link url ảnh ne', 'link url video ne',01/07/2022, 1)

insert into ReplyRatting values('REP01','SPL01', 'RT01', 'Cảm ơn bạn đã tin tưởng sử dụng sản phẩm của chúng tôi, chúc bạn zui', 02/03/2022,1)
insert into ReplyRatting values('REP02','SPL02', 'RT02', 'Chúng tôi xin lỗi bạn vì sự bất tiện này', 05/03/2022,0)
insert into ReplyRatting values('REP03','SPL03', 'RT03', 'Chúng tôi xin lỗi bạn vì sự bất tiện này, bạn rep tn để shop đền bù ạ', 08/03/2022,0)

insert into Supplier values('SPL01','Meo Meo', 1000, 'Hồ Chí Minh', 0.8)
insert into Supplier values('SPL02','Gâu Gâu', 2000, 'Hà Nội', 0.95)
insert into Supplier values('SPL03','Mỹ Phẩm', 3000, 'Đà Nẵng', 0.99)
insert into Supplier values('SPL04','Giày thể thao', 5000, 'Hồ Chí Minh', 1)
insert into Supplier values('SPL05','Bánh Tráng Tây Ninh', 2500, 'Tây Ninh', 0.98)


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

insert into Products values('PD01','SPL01','CT01','RT01', 'Smart Tivi Samsung 4K 50 inch UA50AU7700','https://salt.tikicdn.com/cache/400x400/ts/product/3a/0c/fe/09bbf1fad770994003014fcaa748b37d.jpg.webp', 11737700, 'PurColor Tái Hiện Sắc Màu Cuộc Sống, Rực Rỡ Và Sống Động Hơn Smart Tivi Samsung 4K 50 inch UA50AU7700 Mới 2021 - Choáng ngợp trước dải màu sắc hiển thị rộng lớn và rực rỡ từ công nghệ PurColor. Đắm chìm trong từng khung hình sống động và chân thực như bước ra từ cuộc sống.',20, 'null', 'null','Hàn Quốc', 'Hàn Quốc', 'SamSung', 21/01/2030  )
insert into Products values('PD02','SPL02','CT01','RT02', 'Smart Tivi Samsung 4K 50 inch UA50AU7700','https://salt.tikicdn.com/cache/400x400/ts/product/3a/0c/fe/09bbf1fad770994003014fcaa748b37d.jpg.webp', 11737700, 'PurColor Tái Hiện Sắc Màu Cuộc Sống, Rực Rỡ Và Sống Động Hơn Smart Tivi Samsung 4K 50 inch UA50AU7700 Mới 2021 - Choáng ngợp trước dải màu sắc hiển thị rộng lớn và rực rỡ từ công nghệ PurColor. Đắm chìm trong từng khung hình sống động và chân thực như bước ra từ cuộc sống.',20, 'null', 'null','Hàn Quốc', 'Hàn Quốc', 'SamSung', 21/01/2030  )
insert into Products values('PD03','SPL03','CT01', 'RT03','Smart Tivi Samsung 4K 50 inch UA50AU7700','https://salt.tikicdn.com/cache/400x400/ts/product/3a/0c/fe/09bbf1fad770994003014fcaa748b37d.jpg.webp', 11737700, 'PurColor Tái Hiện Sắc Màu Cuộc Sống, Rực Rỡ Và Sống Động Hơn Smart Tivi Samsung 4K 50 inch UA50AU7700 Mới 2021 - Choáng ngợp trước dải màu sắc hiển thị rộng lớn và rực rỡ từ công nghệ PurColor. Đắm chìm trong từng khung hình sống động và chân thực như bước ra từ cuộc sống.',20, 'null', 'null','Hàn Quốc', 'Hàn Quốc', 'SamSung', 21/01/2030  )

insert into Users values('US01','W01', 'Nguyễn Thị Nhân', '12345678','user','0987654321', '34 đường 6','nguyenthinhan2101@gmail.com')
insert into Users values('US02','W02', 'Bùi Quốc Huy', '12345678', 'user','0987654321', '34 đường 6', 'huybui@gmail.com')


insert into Vouchers values('VC01', 'NhanCute', 'Khuyến mãi tháng 5', 'TIKI khuyen mai',01/05/2022, 03/05/2022, 100, 2, 0.1, 30000 )
insert into Vouchers values('VC02', 'SaleDauThang', 'Khuyến mãi 1 tháng 5', 'freeship',10/05/2022, 25/05/2022, 100, 5, 0.1, 20000 )

insert into Orders values('OD01','PD01','US01','VC01',1,11727700, 10000, 22/04/2022)
insert into Orders values('OD02','PD02','US02','VC01',1,11727700, 10000, 24/04/2022)
insert into Orders values('OD03','PD03','US01','VC02',1,11727700, 10000, 23/04/2022)

ALTER TABLE Orders
ADD CONSTRAINT fk_id_product
 FOREIGN KEY (ProductId)
 REFERENCES Products (ProductId);

 ALTER TABLE Orders
ADD CONSTRAINT fk_id_users
 FOREIGN KEY (UserId)
 REFERENCES Users (UserId);

  ALTER TABLE Orders
ADD CONSTRAINT fk_id_voucher
 FOREIGN KEY (VoucherId)
 REFERENCES Vouchers (VoucherId);
	


   ALTER TABLE Products
ADD CONSTRAINT fk_id_Ratting_PD
 FOREIGN KEY (RattingId)
 REFERENCES Ratting (RattingId);

    ALTER TABLE Products
ADD CONSTRAINT fk_id_SupplierId_PD
 FOREIGN KEY (SupplierId)
 REFERENCES Supplier (SupplierId);

  
 
   ALTER TABLE Products
ADD CONSTRAINT fk_id_categoryId_PD
 FOREIGN KEY (CategoryId)
 REFERENCES Categories (CategoryId);

  ALTER TABLE ReplyRatting
ADD CONSTRAINT fk_id_supplier_RT
 FOREIGN KEY (SupplierId)
 REFERENCES Supplier (SupplierId);

   ALTER TABLE ReplyRatting
ADD CONSTRAINT fk_id_ratting_RTT
 FOREIGN KEY (RattingId)
 REFERENCES Ratting (RattingId);


    ALTER TABLE Ratting
ADD CONSTRAINT fk_id_product_RT
 FOREIGN KEY (ProductId)
 REFERENCES Products (ProductId);

     ALTER TABLE Users
ADD CONSTRAINT fk_id_wards
 FOREIGN KEY (WardsId)
 REFERENCES Wards (WardsId);

      ALTER TABLE Wards
ADD CONSTRAINT fk_id_district
 FOREIGN KEY (DistrictId)
 REFERENCES District (DistrictId);

       ALTER TABLE District
ADD CONSTRAINT fk_id_Province
 FOREIGN KEY (ProvinceId)
 REFERENCES Province (ProvinceId);