CREATE TRIGGER [TRG_Loan_CheckCopyNotIncomplete]
	ON [dbo].[Loan]
	-- vérification uniquement lors de l'insertion, pas lors de la modification
	FOR INSERT
	AS
	BEGIN
		SET NOCOUNT ON

		-- si résultat pour [Copy]([State]) = 'Incomplete' ...
		IF EXISTS (
			SELECT 1
			FROM [inserted] i
			JOIN [dbo].[Copy] c ON i.[Copy] = c.[Copy_Id]
			WHERE c.[State] = 'Incomplete'
		)
		-- ... annule la transaction (INSERT, UPDATE)
		BEGIN
			RAISERROR ('Incomplete copy can not be lend', 16, 1);
			ROLLBACK TRANSACTION;
			RETURN;
		END
	END
