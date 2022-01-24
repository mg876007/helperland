CREATE TABLE [dbo].[Services-table] (
  [Service Id] [int] NOT NULL,
  [Start-Time] [time] NULL,
  [Duration] [int] NULL,
  [Extra Services] [int] NULL,
  [Comments] [nvarchar](50) NULL,
  [User Id] [int] NOT NULL,
  [Service Provider] [nvarchar](50) NULL,
  CONSTRAINT [PK_Services-table] PRIMARY KEY CLUSTERED ([Service Id])
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Services-table]
  ADD CONSTRAINT [FK_Services-table_Services-table] FOREIGN KEY ([User Id]) REFERENCES [dbo].[User-Table] ([User Id])
GO