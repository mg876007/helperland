CREATE TABLE [dbo].[Address-Table] (
  [Id] [int] NOT NULL,
  [Street Name] [nvarchar](50) NULL,
  [Home Number] [int] NULL,
  [Postal Code] [numeric] NOT NULL,
  [City] [nvarchar](50) NULL,
  [Phone number] [numeric] NULL,
  [User Id] [int] NULL,
  CONSTRAINT [PK_Address-Table] PRIMARY KEY CLUSTERED ([Id])
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Address-Table]
  ADD CONSTRAINT [FK_Address-Table_User-Table] FOREIGN KEY ([User Id]) REFERENCES [dbo].[User-Table] ([User Id])
GO