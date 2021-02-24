create database latihan;
use latihan;
go

CREATE TABLE [dbo].[BARANG](
	[product_id] [varchar](50) NOT NULL,
	[product_name] [varchar](50) NULL,
	[price] [int] NULL
) ON [PRIMARY]
GO

insert into BARANG values ('tlkm', 'kartu telkomsel', 1000),('isat', 'kartu indosat', 2000)
go
