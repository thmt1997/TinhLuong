-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE NhanVienChinhThuc
AS
BEGIN
	select * from NhanVien where HinhThuc = 'ChinhThuc'
END

