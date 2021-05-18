CREATE DATABASE [Taze]
GO

USE [Taze]
GO

/****** Object:  Table [dbo].[Topic]    Script Date: 7.03.2021 16:41:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Topic](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SystemName] [nvarchar](max) NULL,
	[DisplayOrder] [int] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Body] [nvarchar](max) NULL,
	[Published] [bit] NOT NULL,
	[CreatedOnUtc] [datetime] NOT NULL,
	[UpdatedOnUtc] [datetime] NOT NULL,
	[TopicTypeId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Topic] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Topic] ADD  CONSTRAINT [DF_Topic_TopicTypeId]  DEFAULT ((10)) FOR [TopicTypeId]
GO

SET IDENTITY_INSERT [dbo].[Topic] ON 
INSERT [dbo].[Topic] ([Id], [SystemName], [DisplayOrder], [Title], [Body], [Published], [CreatedOnUtc], [UpdatedOnUtc], [TopicTypeId]) VALUES (1, N'1. içerik', 1, N'1. içerik', N'1. içerik', 1, CAST(N'2021-03-07T13:54:37.860' AS DateTime), CAST(N'2021-03-07T13:54:37.863' AS DateTime), 10)
INSERT [dbo].[Topic] ([Id], [SystemName], [DisplayOrder], [Title], [Body], [Published], [CreatedOnUtc], [UpdatedOnUtc], [TopicTypeId]) VALUES (2, N'1. kategori update', 1, N'1. kategori update', N'1. kategori update', 0, CAST(N'2021-03-07T13:54:54.897' AS DateTime), CAST(N'2021-03-07T16:58:02.077' AS DateTime), 20)
INSERT [dbo].[Topic] ([Id], [SystemName], [DisplayOrder], [Title], [Body], [Published], [CreatedOnUtc], [UpdatedOnUtc], [TopicTypeId]) VALUES (3, N'2. içerik', 1, N'1. içerik', N'1. içerik', 0, CAST(N'2021-03-07T13:55:26.337' AS DateTime), CAST(N'2021-03-07T13:55:26.337' AS DateTime), 10)
SET IDENTITY_INSERT [dbo].[Topic] OFF
GO


