CREATE DATABASE CH_DIENTHOAIDIDONG_LinQ
USE CH_DIENTHOAIDIDONG_LinQ

CREATE TABLE NHANVIEN
(
MANV CHAR(20) PRIMARY KEY,
HOTEN NVARCHAR(50),
DIACHI NVARCHAR(100),
CMND CHAR(500),
NGAYSINH DATE,
SDT CHAR(15),
EMAIL CHAR(100),
CHUCVU NVARCHAR(50),
HINHANH NVARCHAR(500),
)


CREATE TABLE TAIKHOAN
(
TENDANGNHAP CHAR(50),
 PRIMARY KEY(TENDANGNHAP),
MATKHAU CHAR(20),
MANV CHAR(20),
CONSTRAINT FK_THANHVIEN_MANV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)

CREATE TABLE HANGSX
(
MAHANGSX CHAR(20) PRIMARY KEY,
TENHANGSX CHAR(20),
DIACHI NVARCHAR(50),
SDT CHAR(20),
)

--sửa ngày sinh khách hàng
CREATE TABLE KHACHHANG
(
MAKH CHAR(20)PRIMARY KEY,
TENKH NVARCHAR(50),
DIACHI NVARCHAR(50),
SDT CHAR(15),
NAMSINH INT,
EMAIL CHAR(50),
)



CREATE TABLE SANPHAM
(
MASP CHAR(20),
PRIMARY KEY(MASP),
TENSP NVARCHAR(50)
)



CREATE TABLE CHITIET_SP
(
MASP CHAR(20),
MAHANGSX CHAR(20),
thoiGian_BH int,
PRIMARY KEY(MASP,xuatxu),
CHIEUDAI FLOAT,
CHIEURONG FLOAT,
DODAY FLOAT,
TRONGLUONG FLOAT,
MANHINH FLOAT,
RAM NVARCHAR(20),
BONHOTRONG NVARCHAR(20),
HEDIEUHANH NVARCHAR(500),
MOTA NVARCHAR(1000),
HINH NvarChar(500),
SOLUONG INT,
DONGIA FLOAT,
XUATXU NVARCHAR(50),
CONSTRAINT FK_CHITIETSP_MASP FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP),
CONSTRAINT FK_CHITIETSP_MAHANGSX FOREIGN KEY(MAHANGSX) REFERENCES HANGSX(MAHANGSX)
)


CREATE TABLE HOADON 
(
MAHD CHAR(20),
MANV CHAR(20),
MAKH CHAR(20),
PRIMARY KEY(MAHD),
CONSTRAINT FK_HOADON_MANV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
CONSTRAINT FK_HOADON_MAKH FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
NGAYLAPHD DATE,
TONGTIEN INT
)

CREATE TABLE CHITIET_HD
(
MAHD CHAR(20),
MASP CHAR(20),
PRIMARY KEY(MAHD,MASP,XUATXU),
CONSTRAINT FK_CHITIET_HD_MAHD FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD),
CONSTRAINT FK_CHITIET_HD_MASP FOREIGN KEY(MASP,XUATXU) REFERENCES CHITIET_SP(MASP,XUATXU),
SOLUONG INT,
DONGIA FLOAT,
TONGTIEN FLOAT,
XUATXU NVARCHAR(50)
)


SET DATEFORMAT DMY
INSERT INTO NHANVIEN
VALUES 
('CH01',N'NGUYỄN VĂN A',N'TP.HCM','215464','22/12/2000','3132134543','nguyenvana@gmail.com',N'Chủ','CH01.jpg'),
('NV02',N'ĐẶNG VĂN B',N'Bình Định','2154264','12/02/1999','3132134543','dangvanb@gmail.com',N'Nhân Viên','NV02.jpg'),
('NV03',N'Trần Văn C',N'Long An','21545464','19/02/1998','3132134543','tranvanc@gmail.com',N'Nhân Viên','NV03.jpg')


INSERT INTO TAIKHOAN
VALUES
('admin','123','CH01'),
('aa','123','NV02'),
('bb','123','NV03')

INSERT INTO HANGSX
VALUES 
('HSX01',N'SAMSUNG',N'Hàn Quốc','0967123124'),
('HSX02',N'XIAOMI',N'Trung Quốc','0969437682'),
('HSX03',N'VSMART',N'Việt Nam','0939247575'),
('HSX04',N'APPLE',N'Mỹ','0162345689'),
('HSX05',N'NOKIA',N'Phần Lan','0375932658'),
('HSX06',N'LG',N'Hàn Quốc','0893643225')


SET DATEFORMAT DMY
INSERT INTO KHACHHANG
VALUES
('KH01',N'NGUYỄN VĂN ĐÔ',N'TÂY NINH','3213130311','1997','vando@gmail.com'),
('KH02',N'PHẠM THỊ NGỌC MAI',N'LÂM ĐỒNG','13130123','2000','ngocmai@gmail.com'),
('KH03',N'VÕ CÔNG CHẨN',N'BÌNH ĐỊNH','9874356','2000','congchan@gmail.com')



INSERT INTO SANPHAM
VALUES
('SP01','Xiaomi Mi6x'),
('SP02','Vsmart Aris Pro'),
('SP03','iPhone 12 Pro Max'),
('SP04','Samsung Galaxy S21 UlTra 5G'),
('SP05','Iphone 7 plus'),
('SP06','Samsung Galaxy A32'),
('SP07','Xiaomi Mi 11 Lite 5G'),
('SP08','Samsung Galaxy A52'),
('SP09','Oppo Reno5'),
('SP10','Xiaomi Redmi 9T'),
('SP11','Xiaomi Mi 10T Pro'),
('SP12','iPhone 11'),
('SP13','Iphone 8'),
('SP14','Iphone 7'),
('SP17','Xiaomi Redmi Note 10 Pro'),
('SP18','Samsung Galaxy A02s'),
('SP19','Vsmart Joy 4'),
('SP20','Vsmart Star 5')


INSERT INTO CHITIET_SP
VALUES
('SP01','HSX01','9','158.7','75.4','7.3','168','5.99','4G','64G',N'Android 8.1 (Oreo), upgradable to Android 9.0 (Pie), Android One',N'Chipset:	Qualcomm SDM660 Snapdragon 660 (14 nm),CPU:	Octa-core (4x2.2 GHz Kryo 260 Gold & 4x1.8 GHz Kryo 260 Silver)','SP01_TrungQuoc.jpg','40','4990000',N'Trung Quốc'),
('SP01','HSX01','6','158.7','75.4','7.3','166','5.99','4G','64G',N'Android 8.1 (Oreo), upgradable to Android 9.0 (Pie), Android One',N'Chipset:	Qualcomm SDM660 Snapdragon 660 (14 nm),CPU:	Octa-core (4x2.2 GHz Kryo 260 Gold & 4x1.8 GHz Kryo 260 Silver)','SP01_VietNam.jpg','80','5500000',N'Việt Nam'),
('SP02','HSX03','12','156.2','75.04','8.55','178','6.39','8G','128G',N'Android 10',N'Chip xử lý (CPU):Snapdragon 730, Tốc độ CPU:2 nhân 2.2 GHz & 6 nhân 1.8 GHz','SP02_VietNam.jpg','50','5490000',N'Việt Nam'),
('SP03','HSX04','15','160.8','78.1','7.4','228','6.7','4G','64G','iOS 14',N'Chip xử lý (CPU): Apple A14 Bionic, Tốc độ CPU:2 nhân 3.1 GHz & 4 nhân 1.8 GHz','SP03_NhatBan.jpg','60','20200000',N'Nhật Bản'),
('SP04','HSX01','18','166.9','76','8.8','220','6.8','3G','32G',N'Android 11, One UI 3.0',N'Chipset	Exynos 2100 8 nhân','SP04_HongKong.jpg','70','20800000',N'Hồng Kông'),
('SP05','HSX04','6','158.2','77.9','7.3','188','5.5','4G','64G','iOS 11',N'Chipset	Apple A10 Fusion APL1W24','SP05_TrungQuoc.jpg','100','5920000',N'Trung Quốc'),
('SP06','HSX01','12','158.9','73.6','8.4','184','6.2','3G','32G',N'Android 11, One UI 3.0',N'Chipset	Mediatek Helio G80 (12 nm)','SP06_HanQuoc.jpg','120','5600000',N'Hàn Quốc'),
('SP07','HSX02','15','160.5','75.7','6.8','159','6.55','4G','64G',N'Android 11, MIUI 12',N'Chipset	Snapdragon 780G (5 nm)','SP07_DaiLoan.jpg','80','8490000',N'Đài Loan'),
('SP08','HSX01','9','159.9','75.1','8.4','189','6.5','3G','32G',N'	Android 11, One UI 3.0',N'Chipset	Snapdragon 720G (8 nm)','SP08_HanQuoc.jpg','90','8600000',N'Hàn quốc'),
('SP09','HSX02','12','159.1','73.3','7.7','171','6.43','4G','64G',N'ColorOS 11.1, Nền tảng Android 11',N'Chipset	Qualcomm Snapdragon 720G, tối đa 2.3GHz','SP09_TrungQuoc.jpg','50','8690000',N'Trung Quốc'),
('SP10','HSX02','15','162.3','77.3','9.6','198','6.53','4G','64G',N'Android 10, MIUI 12',N'Chipset	Qualcomm SM6115 Snapdragon 662 (11 nm)','SP10_TrungQuoc.jpg','40','8490000',N'Trung Quốc'),
('SP11','HSX02','18','165.1','76.4','9.3','218','6.67','4G','64G',N'Android 10, MIUI 12',N'Chipset	Qualcomm SM8250 Snapdragon 865 (7 nm+)','SP11_TrungQuoc.jpg','30','9290000',N'Trung Quốc'),
('SP12','HSX04','12','150.9','75.7','8.3','194','6.1','4G','64G','Hệ điều hành	iOS 13 hoặc cao hơn',N'Chipset	A13 Bionic','SP12_My.jpg','50','15850000',N'Mỹ'),
('SP13','HSX04','15','138.4','67.3','7.3','148','4.7','4G','64G','iOS 11',N'Chipset	Apple A11 Bionic APL1W72','SP13_TrungQuoc.jpg','60','6520000',N'Trung Quốc'),
('SP14','HSX04','18','138.3','67.1',' 7.1','138','4.7','4G','64G','iOS 11',N'Chipset	Apple A10 Fusion APL1W24','SP14_DaiLoan.jpg','70','4020000',N'Đài Loan'),
('SP17','HSX03','12','164','76.5','8.1','193','6.67','8G','128G',N'	Android 11, MIUI 12',N'Chipset	Snapdragon 732G (8 nm)','SP17_DaiLoan.jpg','50','6550000',N'Đài Loan'),
('SP18','HSX01','6','164.2','75.9','9.1','196','6.5','3G','32G',N'Android 10, One UI 3.1',N'Chipset	Qualcomm SDM450 Snapdragon 450 (14 nm)','SP18_HanQuoc.jpg','30','3300000',N'Hàn Quốc'),
('SP19','HSX03','6','163.65','77.65','9.15','203','6.5','8G','128G',N'Android 10, VOS 3.0',N'Chip Qualcomm SDM665 Snapdragon 665 (11 nm)','SP19_VietNam.jpg','80','2390000',N'Việt Nam'),
('SP20','HSX03','6','163.91','75.67','9.1','196.26','6.52','8G','128G',N'Android 11',N'4 nhân 2.5 GHz & 4 nhân 1.8 GHz','SP20_VietNam.jpg','50','2390000',N'Việt Nam')

SET DATEFORMAT DMY
INSERT INTO HOADON
VALUES
('HD01','NV03','KH01',getdate(),''),
('HD02','CH01','KH02','12/12/2021',''),
('HD03','NV03','KH03','16/09/2020',''),
('HD04','CH01','KH02','14/07/2021',''),
('HD05','NV03','KH01','22/08/2020',''),
('HD06','NV02','KH03','28/07/2021','')

INSERT INTO CHITIET_HD
VALUES
('HD01','SP01','','','1000',N'Trung Quốc'),
('HD01','SP01','','','1000',N'Việt Nam')


