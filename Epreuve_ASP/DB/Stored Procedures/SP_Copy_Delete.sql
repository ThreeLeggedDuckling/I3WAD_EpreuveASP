CREATE PROCEDURE [dbo].[SP_Copy_Delete]
	@copy_id UNIQUEIDENTIFIER
AS
BEGIN
	UPDATE [Copy]
		SET [Owner] = NULL
		WHERE [Copy_Id] = @copy_id
END
