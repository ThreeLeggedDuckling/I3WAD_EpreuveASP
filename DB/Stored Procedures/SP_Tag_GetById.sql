CREATE PROCEDURE [dbo].[SP_Tag_GetById]
	@tag NVARCHAR(10)
AS
BEGIN
	SELECT [Tag_Id]
	FROM [Tag]
	WHERE [Tag_Id] = @tag
END
