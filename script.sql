USE [master]
GO
/****** Object:  Database [SwimMood]    Script Date: 21/11/2022 00:02:58 ******/
CREATE DATABASE [SwimMood]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SwimMood', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SwimMood.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SwimMood_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SwimMood_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SwimMood] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SwimMood].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SwimMood] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SwimMood] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SwimMood] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SwimMood] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SwimMood] SET ARITHABORT OFF 
GO
ALTER DATABASE [SwimMood] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SwimMood] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SwimMood] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SwimMood] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SwimMood] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SwimMood] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SwimMood] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SwimMood] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SwimMood] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SwimMood] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SwimMood] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SwimMood] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SwimMood] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SwimMood] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SwimMood] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SwimMood] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SwimMood] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SwimMood] SET RECOVERY FULL 
GO
ALTER DATABASE [SwimMood] SET  MULTI_USER 
GO
ALTER DATABASE [SwimMood] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SwimMood] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SwimMood] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SwimMood] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SwimMood] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SwimMood] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SwimMood', N'ON'
GO
ALTER DATABASE [SwimMood] SET QUERY_STORE = OFF
GO
USE [SwimMood]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NOT NULL,
	[NameCours] [nvarchar](50) NULL,
	[PeopleAmount] [int] NULL,
	[Dis] [nvarchar](50) NULL,
	[IdUser] [int] NOT NULL,
	[Status] [bit] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CoursToCustomer]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoursToCustomer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[IdCours] [int] NOT NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_CoursToCustomer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerToPool]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerToPool](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPackage] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
	[AmountLeft] [int] NULL,
	[AmountGet] [int] NULL,
	[TotalPrice] [int] NULL,
	[DateBuy] [date] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_CustomerToPool] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Days]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Days](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameDay] [nvarchar](50) NULL,
 CONSTRAINT [PK_Days] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DaysToCours]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaysToCours](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCours] [int] NOT NULL,
	[IdDays] [int] NOT NULL,
	[StartHour] [time](7) NULL,
	[EndHour] [time](7) NULL,
	[Type] [bit] NULL,
	[IdPool] [int] NOT NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_DaysToCours] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DaysToPool]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaysToPool](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NOT NULL,
	[IdDays] [int] NOT NULL,
	[StartHour] [time](7) NULL,
	[EndHour] [time](7) NULL,
	[Type] [bit] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_DaysToPool] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnterCustomer]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnterCustomer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NOT NULL,
	[EnterDate] [date] NULL,
	[IdCustomerToPool] [int] NOT NULL,
	[StartHour] [time](7) NULL,
	[EndHour] [time](7) NULL,
	[NumPeople] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_EnterCustomer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Erea]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Erea](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Erea] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Packages]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NOT NULL,
	[EntersAmount] [int] NULL,
	[Price] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_packages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pool]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pool](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[Price] [int] NULL,
	[Amount] [int] NULL,
	[IdUser] [int] NOT NULL,
	[IdErea] [int] NOT NULL,
	[Phone] [nvarchar](10) NULL,
	[Status] [bit] NULL,
	[Pic] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pool] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeUser] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NOT NULL,
	[Dis] [nvarchar](50) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[EnterAmount] [int] NULL,
	[Price] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 21/11/2022 00:02:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Type] [bit] NULL,
	[IdRole] [int] NOT NULL,
	[LastEntery] [date] NULL,
	[Phone] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Course] ON 
GO
INSERT [dbo].[Course] ([Id], [IdPool], [NameCours], [PeopleAmount], [Dis], [IdUser], [Status], [Price]) VALUES (5, 3, N'שחיה', 30, N'בוא לשחות איתננוווו', 26, 1, 1000)
GO
INSERT [dbo].[Course] ([Id], [IdPool], [NameCours], [PeopleAmount], [Dis], [IdUser], [Status], [Price]) VALUES (10, 6, N'לחימה', 25, N'ללחום כמו מקצוענים', 26, 1, 1200)
GO
INSERT [dbo].[Course] ([Id], [IdPool], [NameCours], [PeopleAmount], [Dis], [IdUser], [Status], [Price]) VALUES (12, 3, N'התעמלות קרקע', 10, N'גלגלונים וכל השאר', 26, 1, 2000)
GO
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[CoursToCustomer] ON 
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (1, 26, 5, NULL)
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (2, 26, 5, NULL)
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (3, 26, 10, NULL)
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (4, 26, 5, NULL)
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (5, 26, 10, NULL)
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (6, 26, 5, NULL)
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (7, 26, 10, NULL)
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (8, 26, 10, NULL)
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (9, 26, 5, 1)
GO
INSERT [dbo].[CoursToCustomer] ([Id], [IdUser], [IdCours], [Status]) VALUES (10, 26, 12, 1)
GO
SET IDENTITY_INSERT [dbo].[CoursToCustomer] OFF
GO
SET IDENTITY_INSERT [dbo].[Erea] ON 
GO
INSERT [dbo].[Erea] ([Id], [Name]) VALUES (1, N'one')
GO
SET IDENTITY_INSERT [dbo].[Erea] OFF
GO
SET IDENTITY_INSERT [dbo].[Packages] ON 
GO
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (1, 3, 10, 250, 1)
GO
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (2, 3, 5, 120, 1)
GO
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (3, 6, 20, 850, 1)
GO
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (4, 6, 5, 130, 1)
GO
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (5, 10, 5, 300, 1)
GO
SET IDENTITY_INSERT [dbo].[Packages] OFF
GO
SET IDENTITY_INSERT [dbo].[Pool] ON 
GO
INSERT [dbo].[Pool] ([Id], [Name], [Adress], [Price], [Amount], [IdUser], [IdErea], [Phone], [Status], [Pic]) VALUES (3, N'מעיינות', N'צפריר 30 אור יהודה', 30, 300, 28, 1, N'0526453672', 1, NULL)
GO
INSERT [dbo].[Pool] ([Id], [Name], [Adress], [Price], [Amount], [IdUser], [IdErea], [Phone], [Status], [Pic]) VALUES (6, N'קאנטרי', N'התמר 2 צפת', 50, 550, 32, 1, N'0556743527', 1, NULL)
GO
INSERT [dbo].[Pool] ([Id], [Name], [Adress], [Price], [Amount], [IdUser], [IdErea], [Phone], [Status], [Pic]) VALUES (10, N'בריכת החוף', N'הרצים 30 אילת', 80, 700, 33, 1, N'0527896646', 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[Pool] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 
GO
INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (1, N'מנהל ראשי')
GO
INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (2, N'מנהל בריכה')
GO
INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (3, N'מדריך קורס')
GO
INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (4, N'מציל')
GO
INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (5, N'לקוח')
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone], [Status]) VALUES (23, N'Chayush', N'Chayush@gmail.com', N'1111', 1, 1, CAST(N'2019-01-01' AS Date), 35462736, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone], [Status]) VALUES (24, N'Liel', N'Liel@gmail.com', N'2222', 1, 1, CAST(N'2019-12-12' AS Date), 37267483, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone], [Status]) VALUES (26, N'מוישי', N'Moishy@gmail.com', N'3333', 0, 5, CAST(N'2018-07-03' AS Date), 7363872, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone], [Status]) VALUES (28, N'Beni', N'Beni@gmail.com', N'4444', 0, 2, CAST(N'2020-06-20' AS Date), 52736726, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone], [Status]) VALUES (30, N'Talya', N'Talya@gmail.com', N'5555', 1, 3, CAST(N'2022-11-17' AS Date), 35333264, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone], [Status]) VALUES (32, N'Shay', N'Shay@gmail.com', N'6666', 1, 2, CAST(N'2019-12-22' AS Date), 7753628, 1)
GO
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone], [Status]) VALUES (33, N'Shir', N'Shir@gmail.com', N'7777', 1, 2, CAST(N'2022-11-17' AS Date), 647363, 1)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Pool] FOREIGN KEY([IdPool])
REFERENCES [dbo].[Pool] ([Id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Pool]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_User] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_User]
GO
ALTER TABLE [dbo].[CoursToCustomer]  WITH CHECK ADD  CONSTRAINT [FK_CoursToCustomer_Course] FOREIGN KEY([IdCours])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[CoursToCustomer] CHECK CONSTRAINT [FK_CoursToCustomer_Course]
GO
ALTER TABLE [dbo].[CoursToCustomer]  WITH CHECK ADD  CONSTRAINT [FK_CoursToCustomer_User] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[CoursToCustomer] CHECK CONSTRAINT [FK_CoursToCustomer_User]
GO
ALTER TABLE [dbo].[CustomerToPool]  WITH CHECK ADD  CONSTRAINT [FK_CustomerToPool_packages] FOREIGN KEY([IdPackage])
REFERENCES [dbo].[Packages] ([Id])
GO
ALTER TABLE [dbo].[CustomerToPool] CHECK CONSTRAINT [FK_CustomerToPool_packages]
GO
ALTER TABLE [dbo].[CustomerToPool]  WITH CHECK ADD  CONSTRAINT [FK_CustomerToPool_User] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[CustomerToPool] CHECK CONSTRAINT [FK_CustomerToPool_User]
GO
ALTER TABLE [dbo].[DaysToCours]  WITH CHECK ADD  CONSTRAINT [FK_DaysToCours_Course] FOREIGN KEY([IdCours])
REFERENCES [dbo].[Course] ([Id])
GO
ALTER TABLE [dbo].[DaysToCours] CHECK CONSTRAINT [FK_DaysToCours_Course]
GO
ALTER TABLE [dbo].[DaysToCours]  WITH CHECK ADD  CONSTRAINT [FK_DaysToCours_Days] FOREIGN KEY([IdDays])
REFERENCES [dbo].[Days] ([Id])
GO
ALTER TABLE [dbo].[DaysToCours] CHECK CONSTRAINT [FK_DaysToCours_Days]
GO
ALTER TABLE [dbo].[DaysToCours]  WITH CHECK ADD  CONSTRAINT [FK_DaysToCours_Pool] FOREIGN KEY([IdPool])
REFERENCES [dbo].[Pool] ([Id])
GO
ALTER TABLE [dbo].[DaysToCours] CHECK CONSTRAINT [FK_DaysToCours_Pool]
GO
ALTER TABLE [dbo].[DaysToPool]  WITH CHECK ADD  CONSTRAINT [FK_DaysToPool_Days] FOREIGN KEY([IdDays])
REFERENCES [dbo].[Days] ([Id])
GO
ALTER TABLE [dbo].[DaysToPool] CHECK CONSTRAINT [FK_DaysToPool_Days]
GO
ALTER TABLE [dbo].[DaysToPool]  WITH CHECK ADD  CONSTRAINT [FK_DaysToPool_Pool] FOREIGN KEY([IdPool])
REFERENCES [dbo].[Pool] ([Id])
GO
ALTER TABLE [dbo].[DaysToPool] CHECK CONSTRAINT [FK_DaysToPool_Pool]
GO
ALTER TABLE [dbo].[EnterCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EnterCustomer_CustomerToPool] FOREIGN KEY([IdCustomerToPool])
REFERENCES [dbo].[CustomerToPool] ([Id])
GO
ALTER TABLE [dbo].[EnterCustomer] CHECK CONSTRAINT [FK_EnterCustomer_CustomerToPool]
GO
ALTER TABLE [dbo].[EnterCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EnterCustomer_Pool] FOREIGN KEY([IdPool])
REFERENCES [dbo].[Pool] ([Id])
GO
ALTER TABLE [dbo].[EnterCustomer] CHECK CONSTRAINT [FK_EnterCustomer_Pool]
GO
ALTER TABLE [dbo].[Packages]  WITH CHECK ADD  CONSTRAINT [FK_packages_Pool] FOREIGN KEY([IdPool])
REFERENCES [dbo].[Pool] ([Id])
GO
ALTER TABLE [dbo].[Packages] CHECK CONSTRAINT [FK_packages_Pool]
GO
ALTER TABLE [dbo].[Pool]  WITH CHECK ADD  CONSTRAINT [FK_Pool_Erea] FOREIGN KEY([IdErea])
REFERENCES [dbo].[Erea] ([Id])
GO
ALTER TABLE [dbo].[Pool] CHECK CONSTRAINT [FK_Pool_Erea]
GO
ALTER TABLE [dbo].[Pool]  WITH CHECK ADD  CONSTRAINT [FK_Pool_User] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Pool] CHECK CONSTRAINT [FK_Pool_User]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Pool] FOREIGN KEY([IdPool])
REFERENCES [dbo].[Pool] ([Id])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Pool]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [SwimMood] SET  READ_WRITE 
GO
