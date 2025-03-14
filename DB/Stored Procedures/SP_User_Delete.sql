﻿CREATE PROCEDURE [dbo].[SP_User_Delete]
	@user_id UNIQUEIDENTIFIER
AS
BEGIN
	-- utilisateur jamais supprimé de la db, juste désactivé
	UPDATE [User]
		SET [DisabledAt] = GETDATE()
		WHERE [User_Id] = @user_id;
END
