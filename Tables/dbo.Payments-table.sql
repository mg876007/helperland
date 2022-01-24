CREATE TABLE [dbo].[Payments-table] (
  [Id] [int] NOT NULL,
  [Amount] [money] NULL,
  [Service Id] [int] NULL,
  CONSTRAINT [PK_Payments-table] PRIMARY KEY CLUSTERED ([Id])
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Payments-table]
  ADD CONSTRAINT [FK_Payments-table_Services-table] FOREIGN KEY ([Service Id]) REFERENCES [dbo].[Services-table] ([Service Id])
GO