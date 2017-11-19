CREATE TABLE [dbo].[DangNhap] (
    [ID]   NCHAR (10) NOT NULL,
    [Pass] NCHAR (10) NULL,
    CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED ([ID] ASC)
);

