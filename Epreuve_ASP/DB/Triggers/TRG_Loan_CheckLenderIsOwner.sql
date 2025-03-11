CREATE TRIGGER [TRG_Loan_CheckLenderIsOwner]
	ON [dbo].[Loan]
	FOR INSERT, UPDATE
	AS
	BEGIN
		SET NOCOUNT ON

		-- si résultat pour [Loan]([Lender]) != [Game_Copy]([Owner]) ...
		IF EXISTS (
			SELECT 1
			FROM [inserted] i
			JOIN [dbo].[Copy] c ON i.[Copy] = c.[Copy_Id]
			WHERE i.[Lender] <> c.[Owner]
		)
		-- ... annule la transaction (INSERT, UPDATE)
		BEGIN
			RAISERROR ('Lender must be the owner of the copy', 16, 1);
			ROLLBACK TRANSACTION;
			RETURN;
		END
	END;
