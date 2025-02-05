USE [dbOgrenciKayit]
GO
/****** Object:  Table [dbo].[tblDers]    Script Date: 11/20/2022 22:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDers](
	[dersKodu] [int] IDENTITY(1,1) NOT NULL,
	[dersAdi] [varchar](50) NULL,
 CONSTRAINT [PK_tblDers] PRIMARY KEY CLUSTERED 
(
	[dersKodu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login]    Script Date: 11/20/2022 22:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [varchar](50) NULL,
	[parola] [varchar](50) NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblOgrenci]    Script Date: 11/20/2022 22:10:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblOgrenci](
	[ogrNo] [int] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NULL,
	[soyad] [varchar](50) NULL,
	[dogumTarih] [date] NULL,
	[adres] [varchar](100) NULL,
	[telefon] [varchar](50) NULL,
	[dersID] [int] NULL,
	[Ortalama] [int] NULL,
 CONSTRAINT [PK_tblOgrenci] PRIMARY KEY CLUSTERED 
(
	[ogrNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_tblOgrenci_tblDers]    Script Date: 11/20/2022 22:10:25 ******/
ALTER TABLE [dbo].[tblOgrenci]  WITH CHECK ADD  CONSTRAINT [FK_tblOgrenci_tblDers] FOREIGN KEY([dersID])
REFERENCES [dbo].[tblDers] ([dersKodu])
GO
ALTER TABLE [dbo].[tblOgrenci] CHECK CONSTRAINT [FK_tblOgrenci_tblDers]
GO
