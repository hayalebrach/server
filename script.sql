USE [master]
GO
/****** Object:  Database [SwimMood]    Script Date: 02/11/2022 21:17:36 ******/
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
/****** Object:  Table [dbo].[Course]    Script Date: 02/11/2022 21:17:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NULL,
	[NameCours] [nvarchar](50) NULL,
	[PeopleAmount] [int] NULL,
	[Dis] [nvarchar](50) NULL,
	[IdUser] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CoursToCustomer]    Script Date: 02/11/2022 21:17:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoursToCustomer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NULL,
	[IdCours] [int] NULL,
 CONSTRAINT [PK_CoursToCustomer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerToPool]    Script Date: 02/11/2022 21:17:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerToPool](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPackage] [int] NULL,
	[IdUser] [int] NULL,
	[AmountLeft] [int] NULL,
	[AmountGet] [int] NULL,
	[TotalPrice] [int] NULL,
	[DateBuy] [date] NULL,
 CONSTRAINT [PK_CustomerToPool] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Days]    Script Date: 02/11/2022 21:17:36 ******/
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
/****** Object:  Table [dbo].[DaysToCours]    Script Date: 02/11/2022 21:17:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaysToCours](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCours] [int] NULL,
	[IdDays] [int] NULL,
	[StartHour] [time](7) NULL,
	[EndHour] [time](7) NULL,
	[Type] [bit] NULL,
	[IdPool] [int] NULL,
 CONSTRAINT [PK_DaysToCours] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DaysToPool]    Script Date: 02/11/2022 21:17:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaysToPool](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NULL,
	[IdDays] [int] NULL,
	[StartHour] [time](7) NULL,
	[EndHour] [time](7) NULL,
	[Type] [bit] NULL,
 CONSTRAINT [PK_DaysToPool] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnterCustomer]    Script Date: 02/11/2022 21:17:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnterCustomer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NULL,
	[EnterDate] [date] NULL,
	[IdCustomerToPool] [int] NULL,
	[StartHour] [time](7) NULL,
	[EndHour] [time](7) NULL,
	[NumPeople] [int] NULL,
 CONSTRAINT [PK_EnterCustomer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Erea]    Script Date: 02/11/2022 21:17:36 ******/
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
/****** Object:  Table [dbo].[Packages]    Script Date: 02/11/2022 21:17:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NULL,
	[EntersAmount] [int] NULL,
	[Price] [int] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_packages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pool]    Script Date: 02/11/2022 21:17:36 ******/
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
	[IdUser] [int] NULL,
	[IdErea] [int] NULL,
	[Phone] [nvarchar](10) NULL,
 CONSTRAINT [PK_Pool] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 02/11/2022 21:17:36 ******/
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
/****** Object:  Table [dbo].[Sale]    Script Date: 02/11/2022 21:17:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPool] [int] NULL,
	[Dis] [nvarchar](50) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[EnterAmount] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 02/11/2022 21:17:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [int] NULL,
	[Type] [bit] NULL,
	[IdRole] [int] NULL,
	[LastEntery] [date] NULL,
	[Phone] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([Id], [IdPool], [NameCours], [PeopleAmount], [Dis], [IdUser], [Status]) VALUES (19, 1, N'hbbh', 10, N'שחיה בכיף', NULL, NULL)
INSERT [dbo].[Course] ([Id], [IdPool], [NameCours], [PeopleAmount], [Dis], [IdUser], [Status]) VALUES (20, 3, N'לחימה', 3, N'לחימות בשטח', NULL, NULL)
INSERT [dbo].[Course] ([Id], [IdPool], [NameCours], [PeopleAmount], [Dis], [IdUser], [Status]) VALUES (22, 2, N'ררררר', NULL, N'עעעעע', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerToPool] ON 

INSERT [dbo].[CustomerToPool] ([Id], [IdPackage], [IdUser], [AmountLeft], [AmountGet], [TotalPrice], [DateBuy]) VALUES (1, 4, 4, 23, 2, 450, CAST(N'2022-10-10' AS Date))
INSERT [dbo].[CustomerToPool] ([Id], [IdPackage], [IdUser], [AmountLeft], [AmountGet], [TotalPrice], [DateBuy]) VALUES (2, 4, 65, 23, 2, 450, CAST(N'2022-10-10' AS Date))
INSERT [dbo].[CustomerToPool] ([Id], [IdPackage], [IdUser], [AmountLeft], [AmountGet], [TotalPrice], [DateBuy]) VALUES (3, 14, 65, 24, 21, 34, CAST(N'2022-10-31' AS Date))
INSERT [dbo].[CustomerToPool] ([Id], [IdPackage], [IdUser], [AmountLeft], [AmountGet], [TotalPrice], [DateBuy]) VALUES (4, 15, 65, 23, 12, 43, CAST(N'2022-10-21' AS Date))
INSERT [dbo].[CustomerToPool] ([Id], [IdPackage], [IdUser], [AmountLeft], [AmountGet], [TotalPrice], [DateBuy]) VALUES (5, 1, 4, 23, 2, 450, CAST(N'2022-10-15' AS Date))
SET IDENTITY_INSERT [dbo].[CustomerToPool] OFF
GO
SET IDENTITY_INSERT [dbo].[Days] ON 

INSERT [dbo].[Days] ([Id], [NameDay]) VALUES (1, N'ראשון')
INSERT [dbo].[Days] ([Id], [NameDay]) VALUES (2, N'שני')
INSERT [dbo].[Days] ([Id], [NameDay]) VALUES (3, N'שלישי')
INSERT [dbo].[Days] ([Id], [NameDay]) VALUES (4, N'רביעי')
INSERT [dbo].[Days] ([Id], [NameDay]) VALUES (5, N'חמישי')
INSERT [dbo].[Days] ([Id], [NameDay]) VALUES (6, N'שישי')
INSERT [dbo].[Days] ([Id], [NameDay]) VALUES (7, N'מוצא"ש')
SET IDENTITY_INSERT [dbo].[Days] OFF
GO
SET IDENTITY_INSERT [dbo].[Erea] ON 

INSERT [dbo].[Erea] ([Id], [Name]) VALUES (1, N'צפון')
INSERT [dbo].[Erea] ([Id], [Name]) VALUES (2, N'דרום')
INSERT [dbo].[Erea] ([Id], [Name]) VALUES (3, N'מרכז')
SET IDENTITY_INSERT [dbo].[Erea] OFF
GO
SET IDENTITY_INSERT [dbo].[Packages] ON 

INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (1, 1, 12, 320, NULL)
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (2, 2, 5, 5, 0)
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (3, 1, 4, 100, NULL)
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (4, 2, 23, 450, 1)
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (14, 2, 23, 23, 1)
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (15, 2, 30, 220, 0)
INSERT [dbo].[Packages] ([Id], [IdPool], [EntersAmount], [Price], [Status]) VALUES (16, 2, 12, 12, 1)
SET IDENTITY_INSERT [dbo].[Packages] OFF
GO
SET IDENTITY_INSERT [dbo].[Pool] ON 

INSERT [dbo].[Pool] ([Id], [Name], [Adress], [Price], [Amount], [IdUser], [IdErea], [Phone]) VALUES (1, N'chayush', N'zahal', 3, 10, NULL, NULL, NULL)
INSERT [dbo].[Pool] ([Id], [Name], [Adress], [Price], [Amount], [IdUser], [IdErea], [Phone]) VALUES (2, N'קאנטרי', N'dghgfhfdjg', 12, 180, 62, 2, NULL)
INSERT [dbo].[Pool] ([Id], [Name], [Adress], [Price], [Amount], [IdUser], [IdErea], [Phone]) VALUES (3, N'קאנטרי כפר יונה', N'הדרים 40', 50, 200, 64, 3, NULL)
SET IDENTITY_INSERT [dbo].[Pool] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (1, N'לקןח')
INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (2, N'מנהל אתר')
INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (3, N'ttttttt')
INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (4, N'sdgsd')
INSERT [dbo].[Role] ([Id], [TypeUser]) VALUES (5, N'מנהל בריכה')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone]) VALUES (4, N'SARA', N'sara5780272@gmail.com', 123456, 1, 1, CAST(N'2022-02-12' AS Date), 556783732)
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone]) VALUES (19, N'נהוראי ברגה', N'bergh2323@gmail.com', 444444, 1, 2, CAST(N'0001-01-01' AS Date), 506875889)
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone]) VALUES (62, N'מוישי', N'fwge@gmail.com', 22222, 1, 5, CAST(N'0001-01-01' AS Date), 98765432)
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone]) VALUES (64, N'רות שעיבי', N'ruthshaibi@gmail.com‏', 533113926, 1, 5, CAST(N'0001-01-01' AS Date), 533113926)
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [Type], [IdRole], [LastEntery], [Phone]) VALUES (65, N'אבישג חברוני', N'avishag2065@gmail.com', 3522, 1, 1, CAST(N'0001-01-01' AS Date), 3500)
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
