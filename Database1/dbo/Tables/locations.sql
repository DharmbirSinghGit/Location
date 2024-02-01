CREATE TABLE [dbo].[locations] (
    [Id]        NVARCHAR (450) NOT NULL,
    [Name]      NVARCHAR (MAX) NOT NULL,
    [StartTime] DATETIME2 (7)  NOT NULL,
    [EndTime]   DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_locations] PRIMARY KEY CLUSTERED ([Id] ASC)
);

