CREATE PROCEDURE [dbo].[SP_Tag_Insert]
	@tag NVARCHAR(64)
AS
BEGIN
	INSERT INTO	[Tag] ([Tag])
	OUTPUT [inserted].[Tag]
	VALUES (@tag)
END
