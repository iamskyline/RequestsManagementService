USE [master]
GO
/****** Object:  Database [RequestsManagement]    Script Date: 04.04.2024 20:58:53 ******/
CREATE DATABASE [RequestsManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RequestsManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RequestsManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RequestsManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RequestsManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RequestsManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RequestsManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RequestsManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RequestsManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RequestsManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RequestsManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RequestsManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [RequestsManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RequestsManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RequestsManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RequestsManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RequestsManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RequestsManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RequestsManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RequestsManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RequestsManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RequestsManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RequestsManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RequestsManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RequestsManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RequestsManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RequestsManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RequestsManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RequestsManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RequestsManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RequestsManagement] SET  MULTI_USER 
GO
ALTER DATABASE [RequestsManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RequestsManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RequestsManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RequestsManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RequestsManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RequestsManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RequestsManagement] SET QUERY_STORE = OFF
GO
USE [RequestsManagement]
GO
/****** Object:  Table [dbo].[ExecutionRequests]    Script Date: 04.04.2024 20:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExecutionRequests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RequestId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK__Executio__3214EC071A6196A4] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 04.04.2024 20:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[RestOfMaterial] [int] NOT NULL,
 CONSTRAINT [PK__Material__3214EC07FC83FE73] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestMaterials]    Script Date: 04.04.2024 20:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestMaterials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaterialId] [int] NOT NULL,
	[RequestId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK__RequestM__3214EC07449948B0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 04.04.2024 20:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[Equipment] [varchar](max) NOT NULL,
	[Malfunction] [varchar](max) NOT NULL,
	[IssueDescription] [varchar](max) NULL,
	[UserDescription] [varchar](max) NULL,
	[ExpectedCompletionDate] [date] NOT NULL,
	[ExpectedCompletionTime] [time](7) NOT NULL,
 CONSTRAINT [PK__Requests__3214EC076D18FC95] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestWorks]    Script Date: 04.04.2024 20:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestWorks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RequestId] [int] NOT NULL,
	[WorkId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK__RequestW__3214EC07A2144DB7] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 04.04.2024 20:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
 CONSTRAINT [PK__Roles__3214EC07786E5C04] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statuses]    Script Date: 04.04.2024 20:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statuses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
 CONSTRAINT [PK__Statuses__3214EC07E925840B] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 04.04.2024 20:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Surname] [varchar](max) NOT NULL,
	[Lastname] [varchar](max) NULL,
	[Login] [varchar](100) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK__Users__3214EC07D126939E] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Work]    Script Date: 04.04.2024 20:58:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Work](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK__Work__3214EC077F45A390] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ExecutionRequests] ON 

INSERT [dbo].[ExecutionRequests] ([Id], [RequestId], [UserId], [StartDate], [EndDate]) VALUES (1, 1, 1, CAST(N'2024-03-26T01:23:56.123' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ExecutionRequests] OFF
GO
SET IDENTITY_INSERT [dbo].[Materials] ON 

INSERT [dbo].[Materials] ([Id], [Name], [Price], [RestOfMaterial]) VALUES (1, N'Втулка', CAST(200 AS Decimal(18, 0)), 10)
SET IDENTITY_INSERT [dbo].[Materials] OFF
GO
SET IDENTITY_INSERT [dbo].[RequestMaterials] ON 

INSERT [dbo].[RequestMaterials] ([Id], [MaterialId], [RequestId], [Quantity], [Price]) VALUES (1, 1, 1, 1, CAST(100 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[RequestMaterials] OFF
GO
SET IDENTITY_INSERT [dbo].[Requests] ON 

INSERT [dbo].[Requests] ([Id], [UserId], [StatusId], [CreatedDate], [Equipment], [Malfunction], [IssueDescription], [UserDescription], [ExpectedCompletionDate], [ExpectedCompletionTime]) VALUES (1, 4, 2, CAST(N'2024-03-26' AS Date), N'Стиральная машина', N'Тест', N'Тест', N'еее', CAST(N'2024-03-30' AS Date), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Requests] ([Id], [UserId], [StatusId], [CreatedDate], [Equipment], [Malfunction], [IssueDescription], [UserDescription], [ExpectedCompletionDate], [ExpectedCompletionTime]) VALUES (2, 4, 1, CAST(N'2024-04-01' AS Date), N'Тест', N'Тест', N'Тест', N'Тест', CAST(N'2024-04-10' AS Date), CAST(N'10:00:00' AS Time))
INSERT [dbo].[Requests] ([Id], [UserId], [StatusId], [CreatedDate], [Equipment], [Malfunction], [IssueDescription], [UserDescription], [ExpectedCompletionDate], [ExpectedCompletionTime]) VALUES (4, 4, 1, CAST(N'2024-04-02' AS Date), N'Тест2', N'Тест2', N'Тест2', N'Тест2', CAST(N'2024-04-11' AS Date), CAST(N'22:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[Requests] OFF
GO
SET IDENTITY_INSERT [dbo].[RequestWorks] ON 

INSERT [dbo].[RequestWorks] ([Id], [RequestId], [WorkId], [UserId], [Price]) VALUES (1, 1, 1, 1, CAST(300 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[RequestWorks] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'Администратор')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'Менеджер')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (3, N'Исполнитель')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (4, N'Клиент')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Statuses] ON 

INSERT [dbo].[Statuses] ([Id], [Name]) VALUES (1, N'В обработке')
INSERT [dbo].[Statuses] ([Id], [Name]) VALUES (2, N'Выполняется')
INSERT [dbo].[Statuses] ([Id], [Name]) VALUES (3, N'Завершено')
INSERT [dbo].[Statuses] ([Id], [Name]) VALUES (4, N'Частично завершено')
SET IDENTITY_INSERT [dbo].[Statuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Lastname], [Login], [Password], [RoleId]) VALUES (1, N'Администратор', N'Администратор', NULL, N'admin', N'1', 1)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Lastname], [Login], [Password], [RoleId]) VALUES (2, N'Клиент', N'Клиент', NULL, N'client', N'1', 4)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Lastname], [Login], [Password], [RoleId]) VALUES (3, N'Исполнитель', N'Исполнитель', NULL, N'performer', N'1', 3)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Lastname], [Login], [Password], [RoleId]) VALUES (4, N'Менеджер', N'Менеджер', NULL, N'manager', N'1', 2)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Lastname], [Login], [Password], [RoleId]) VALUES (5, N'Иванов', N'Иван ', N'Иванович', N'ivan', N'1234', 4)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Work] ON 

INSERT [dbo].[Work] ([Id], [Name], [Price]) VALUES (1, N'Смена втулки', CAST(100 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Work] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__5E55825B045C1C9B]    Script Date: 04.04.2024 20:58:53 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [UQ__Users__5E55825B045C1C9B] UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ExecutionRequests]  WITH CHECK ADD  CONSTRAINT [FK__Execution__Reque__4CA06362] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Requests] ([Id])
GO
ALTER TABLE [dbo].[ExecutionRequests] CHECK CONSTRAINT [FK__Execution__Reque__4CA06362]
GO
ALTER TABLE [dbo].[ExecutionRequests]  WITH CHECK ADD  CONSTRAINT [FK__Execution__UserI__4D94879B] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ExecutionRequests] CHECK CONSTRAINT [FK__Execution__UserI__4D94879B]
GO
ALTER TABLE [dbo].[RequestMaterials]  WITH CHECK ADD  CONSTRAINT [FK__RequestMa__Mater__5070F446] FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Materials] ([Id])
GO
ALTER TABLE [dbo].[RequestMaterials] CHECK CONSTRAINT [FK__RequestMa__Mater__5070F446]
GO
ALTER TABLE [dbo].[RequestMaterials]  WITH CHECK ADD  CONSTRAINT [FK__RequestMa__Reque__5165187F] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Requests] ([Id])
GO
ALTER TABLE [dbo].[RequestMaterials] CHECK CONSTRAINT [FK__RequestMa__Reque__5165187F]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK__Requests__Status__49C3F6B7] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Statuses] ([Id])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK__Requests__Status__49C3F6B7]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK__Requests__UserId__48CFD27E] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK__Requests__UserId__48CFD27E]
GO
ALTER TABLE [dbo].[RequestWorks]  WITH CHECK ADD  CONSTRAINT [FK__RequestWo__Reque__5441852A] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Requests] ([Id])
GO
ALTER TABLE [dbo].[RequestWorks] CHECK CONSTRAINT [FK__RequestWo__Reque__5441852A]
GO
ALTER TABLE [dbo].[RequestWorks]  WITH CHECK ADD  CONSTRAINT [FK__RequestWo__UserI__5629CD9C] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[RequestWorks] CHECK CONSTRAINT [FK__RequestWo__UserI__5629CD9C]
GO
ALTER TABLE [dbo].[RequestWorks]  WITH CHECK ADD  CONSTRAINT [FK__RequestWo__WorkI__5535A963] FOREIGN KEY([WorkId])
REFERENCES [dbo].[Work] ([Id])
GO
ALTER TABLE [dbo].[RequestWorks] CHECK CONSTRAINT [FK__RequestWo__WorkI__5535A963]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK__Users__RoleId__45F365D3] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK__Users__RoleId__45F365D3]
GO
USE [master]
GO
ALTER DATABASE [RequestsManagement] SET  READ_WRITE 
GO
