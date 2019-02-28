CREATE PROCEDURE [dbo].[AddForm]
	@Email nvarchar(50),
	@FirstName nvarchar (50),
	@LastName nvarchar (50)
AS
BEGIN
	SET NOCOUNT ON;
	insert into Form(Email, FirstName, LastName)
	values(@Email, @FirstName, @LastName)
END
GO
