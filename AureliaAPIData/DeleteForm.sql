CREATE PROCEDURE [dbo].[DeleteForm]
	@Id int
AS
BEGIN
SET NOCOUNT ON;	
	delete from Form where Id = @Id
END
GO