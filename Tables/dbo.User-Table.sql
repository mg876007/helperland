CREATE TABLE [dbo].[User-Table] (
  [User Id] [int] NOT NULL,
  [First Name] [nvarchar](50) NOT NULL,
  [Last Name] [nvarchar](50) NULL,
  [Email] [nvarchar](max) NULL,
  [Mobile Number] [numeric] NULL,
  [Password] [nvarchar](50) NOT NULL,
  CONSTRAINT [PK_User Table] PRIMARY KEY CLUSTERED ([User Id])
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO