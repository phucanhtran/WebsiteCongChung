USE WebsiteCongChung
GO
CREATE TABLE HopDongCongChung
(
	Id int identity(1,1) primary key,
	SoHD varchar(128) not null,
	SoCD varchar(128),
	LoaiHD int not null,
	HinhThucCongChung nvarchar not null,
	MaTaiSan int,
	TrangThai int,
	MaKH int,
	MaCongChungVien int,
	MaCongTacVien int,
	MaNguoiTao int,
	NgayTaoHD datetime,
	MaCoSo int not null
)