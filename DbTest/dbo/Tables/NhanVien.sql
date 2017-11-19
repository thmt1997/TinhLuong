CREATE TABLE [dbo].[NhanVien] (
    [ID]          NCHAR (10) NOT NULL,
    [HoTen]       NCHAR (10) NULL,
    [SoDienThoai] INT        NULL,
    [HinhThuc]    NCHAR (10) NULL,
    [HeSo]        INT        NULL,
    [Luong]       REAL       NULL,
    CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED ([ID] ASC)
);

