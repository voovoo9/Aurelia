CREATE PROCEDURE [dbo].[GetFormById]
	@Id int
AS
BEGIN
SET NOCOUNT ON;
	select * from Form wherE Id = @Id
END
GO
