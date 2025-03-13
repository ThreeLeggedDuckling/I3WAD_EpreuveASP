CREATE PROCEDURE [dbo].[SP_Copy_Update]
	@copy_id UNIQUEIDENTIFIER,
	@state NVARCHAR(10)
AS
BEGIN
	UPDATE [Copy]
		SET [State] = @state
		WHERE [Copy_Id] = @copy_id
END
