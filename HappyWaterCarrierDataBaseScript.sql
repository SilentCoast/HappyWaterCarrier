USE [master]
GO
/****** Object:  Database [HappyWaterCarrier]    Script Date: 30.01.2023 1:30:26 ******/
CREATE DATABASE [HappyWaterCarrier]
GO
ALTER DATABASE [HappyWaterCarrier] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET ARITHABORT OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HappyWaterCarrier] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HappyWaterCarrier] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HappyWaterCarrier] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HappyWaterCarrier] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HappyWaterCarrier] SET  MULTI_USER 
GO
ALTER DATABASE [HappyWaterCarrier] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HappyWaterCarrier] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HappyWaterCarrier] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HappyWaterCarrier] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HappyWaterCarrier] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HappyWaterCarrier] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HappyWaterCarrier] SET QUERY_STORE = OFF
GO
USE [HappyWaterCarrier]
GO
/****** Object:  Table [dbo].[Заказ]    Script Date: 30.01.2023 1:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Заказ](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Номер] [int] NULL,
	[Название_товара] [nvarchar](50) NULL,
	[Сотрудник_Id] [int] NULL,
 CONSTRAINT [PK_Заказ] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Подразделение]    Script Date: 30.01.2023 1:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Подразделение](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nvarchar](50) NULL,
	[Руководитель_Id] [int] NULL,
 CONSTRAINT [PK_Подразделение] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Пол]    Script Date: 30.01.2023 1:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пол](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Пол] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сотрудник]    Script Date: 30.01.2023 1:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сотрудник](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия] [nvarchar](50) NULL,
	[Имя] [nvarchar](50) NULL,
	[Отчество] [nvarchar](50) NULL,
	[Дата_рождения] [date] NULL,
	[Пол_Id] [int] NULL,
	[Подразделение_Id] [int] NULL,
 CONSTRAINT [PK_Сотрудник] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Заказ] ON 
GO
INSERT [dbo].[Заказ] ([Id], [Номер], [Название_товара], [Сотрудник_Id]) VALUES (3020, 3232, N'Ручка гелевая синяя', 3)
GO
INSERT [dbo].[Заказ] ([Id], [Номер], [Название_товара], [Сотрудник_Id]) VALUES (5002, 231, N'Штаны прозрачные', 3)
GO
INSERT [dbo].[Заказ] ([Id], [Номер], [Название_товара], [Сотрудник_Id]) VALUES (5003, 555, N'Клавиатура', 4003)
GO
INSERT [dbo].[Заказ] ([Id], [Номер], [Название_товара], [Сотрудник_Id]) VALUES (5004, 1322, N'Коврик для мыши', 4002)
GO
SET IDENTITY_INSERT [dbo].[Заказ] OFF
GO
SET IDENTITY_INSERT [dbo].[Подразделение] ON 
GO
INSERT [dbo].[Подразделение] ([Id], [Название], [Руководитель_Id]) VALUES (1, N'Новосибирский отдел', 4003)
GO
INSERT [dbo].[Подразделение] ([Id], [Название], [Руководитель_Id]) VALUES (2, N'Омский отдел', 4002)
GO
INSERT [dbo].[Подразделение] ([Id], [Название], [Руководитель_Id]) VALUES (2002, N'Московский отдел', 3)
GO
SET IDENTITY_INSERT [dbo].[Подразделение] OFF
GO
SET IDENTITY_INSERT [dbo].[Пол] ON 
GO
INSERT [dbo].[Пол] ([Id], [Name]) VALUES (1, N'Мужчина')
GO
INSERT [dbo].[Пол] ([Id], [Name]) VALUES (2, N'Женщина')
GO
INSERT [dbo].[Пол] ([Id], [Name]) VALUES (3, N'Трансгендер')
GO
INSERT [dbo].[Пол] ([Id], [Name]) VALUES (4, N'Нон-бинари')
GO
SET IDENTITY_INSERT [dbo].[Пол] OFF
GO
SET IDENTITY_INSERT [dbo].[Сотрудник] ON 
GO
INSERT [dbo].[Сотрудник] ([Id], [Фамилия], [Имя], [Отчество], [Дата_рождения], [Пол_Id], [Подразделение_Id]) VALUES (2, N'Петров', N'Антон', N'Иванович', CAST(N'1995-12-10' AS Date), 1, 2002)
GO
INSERT [dbo].[Сотрудник] ([Id], [Фамилия], [Имя], [Отчество], [Дата_рождения], [Пол_Id], [Подразделение_Id]) VALUES (3, N'Степанова', N'Антонина', N'Ивановича', CAST(N'1995-12-06' AS Date), 2, 2)
GO
INSERT [dbo].[Сотрудник] ([Id], [Фамилия], [Имя], [Отчество], [Дата_рождения], [Пол_Id], [Подразделение_Id]) VALUES (4002, N'Григорьев', N'Пётр', N'Абрамович', CAST(N'1986-02-05' AS Date), 4, 1)
GO
INSERT [dbo].[Сотрудник] ([Id], [Фамилия], [Имя], [Отчество], [Дата_рождения], [Пол_Id], [Подразделение_Id]) VALUES (4003, N'Жуков', N'Артём', N'Генадьевич', CAST(N'1989-07-14' AS Date), 1, 2002)
GO
SET IDENTITY_INSERT [dbo].[Сотрудник] OFF
GO
ALTER TABLE [dbo].[Заказ]  WITH CHECK ADD  CONSTRAINT [FK_Заказ_Сотрудник] FOREIGN KEY([Сотрудник_Id])
REFERENCES [dbo].[Сотрудник] ([Id])
GO
ALTER TABLE [dbo].[Заказ] CHECK CONSTRAINT [FK_Заказ_Сотрудник]
GO
ALTER TABLE [dbo].[Подразделение]  WITH CHECK ADD  CONSTRAINT [FK_Подразделение_Сотрудник] FOREIGN KEY([Руководитель_Id])
REFERENCES [dbo].[Сотрудник] ([Id])
GO
ALTER TABLE [dbo].[Подразделение] CHECK CONSTRAINT [FK_Подразделение_Сотрудник]
GO
ALTER TABLE [dbo].[Сотрудник]  WITH CHECK ADD  CONSTRAINT [FK_Сотрудник_Подразделение] FOREIGN KEY([Подразделение_Id])
REFERENCES [dbo].[Подразделение] ([Id])
GO
ALTER TABLE [dbo].[Сотрудник] CHECK CONSTRAINT [FK_Сотрудник_Подразделение]
GO
ALTER TABLE [dbo].[Сотрудник]  WITH CHECK ADD  CONSTRAINT [FK_Сотрудник_Пол] FOREIGN KEY([Пол_Id])
REFERENCES [dbo].[Пол] ([Id])
GO
ALTER TABLE [dbo].[Сотрудник] CHECK CONSTRAINT [FK_Сотрудник_Пол]
GO
USE [master]
GO
ALTER DATABASE [HappyWaterCarrier] SET  READ_WRITE 
GO
