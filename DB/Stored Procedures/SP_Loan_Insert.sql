CREATE PROCEDURE [dbo].[SP_Loan_Insert]
	@user_id UNIQUEIDENTIFIER,
	@copy_id UNIQUEIDENTIFIER,
	@loan_date DATETIME2,
	@return_date DATETIME2 = NULL,
	@borrower UNIQUEIDENTIFIER
AS
BEGIN
	-- création table temporaire pour stocker l'output (conflit OUTPUT - trigger)
	DECLARE @InsertedId TABLE (Loan_Id UNIQUEIDENTIFIER);

	INSERT INTO [Loan] ([Copy], [LoanDate], [ReturnDate], [Lender], [Borrower])
	OUTPUT [inserted].[Loan_Id] INTO @InsertedId
	VALUES (@copy_id, @loan_date, @return_date, @user_id, @borrower)

	-- récupération variable temporaire si aucun trigger déclenché
	SELECT [Loan_Id]
	FROM @InsertedId
END
