USE [UserRegistration]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 10/25/2023 2:23:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Mail] [nvarchar](100) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[Skillsets] [nvarchar](50) NULL,
	[Hobby] [nvarchar](50) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserDetails] ON 
GO
INSERT [dbo].[UserDetails] ([ID], [UserName], [Mail], [PhoneNumber], [Skillsets], [Hobby], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [IsActive]) VALUES (1, N'Test', N'test@gmail.com', 123456789, N'Engineer', N'Playing', N'Admin', CAST(N'2023-10-23T22:34:13.720' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[UserDetails] ([ID], [UserName], [Mail], [PhoneNumber], [Skillsets], [Hobby], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [IsActive]) VALUES (2, N'John', N'John@gmail.com', 123456789, N'Engineer', N'Playing', N'Admin', CAST(N'2023-10-23T22:34:25.140' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[UserDetails] ([ID], [UserName], [Mail], [PhoneNumber], [Skillsets], [Hobby], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [IsActive]) VALUES (3, N'Tession', N'lestim@gmail.com', 123456789, N'Engineer', N'Playing', N'Admin', CAST(N'2023-10-23T22:34:25.927' AS DateTime), NULL, NULL, 0)
GO
INSERT [dbo].[UserDetails] ([ID], [UserName], [Mail], [PhoneNumber], [Skillsets], [Hobby], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [IsActive]) VALUES (4, N'Teddy', N'teddy@gmail.com', 123456789, N'Engineer', N'Playing', N'Admin', CAST(N'2023-10-23T22:34:26.450' AS DateTime), NULL, NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[UserDetails] OFF
GO
ALTER TABLE [dbo].[UserDetails] ADD  CONSTRAINT [DF_UserDetails_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
