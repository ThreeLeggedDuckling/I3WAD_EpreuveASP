CREATE PROCEDURE [dbo].[SP_Copy_GetById]
	@copy_id UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [Copy_Id],
			[Game],
			[Owner],
			[State]
	FROM [Copy]
	WHERE [Copy_Id] = @copy_id
END
