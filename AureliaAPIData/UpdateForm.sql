CREATE PROCEDURE [dbo].[UpdateForm]
	@Id int,
	@Email nvarchar(50),
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
BEGIN
SET NOCOUNT ON;
	update Form set
	Email = @Email,
	FirstName = @FirstName,
	LastName = @LastName
	where Id = @Id
END
GO
