CREATE PROCEDURE [dbo].[SP_Loan_Insert]
	@user_id UNIQUEIDENTIFIER,
	@copy_id UNIQUEIDENTIFIER,
	@loan_date DATETIME2,
	@return_date DATETIME2 = NULL,
	@borrower UNIQUEIDENTIFIER,
	@inserted_loan_id UNIQUEIDENTIFIER OUTPUT	-- besoin param OUTPUT à cause des triggers
AS
BEGIN
	INSERT INTO [Loan] ([Copy], [LoanDate], [ReturnDate], [Lender], [Borrower])
	OUTPUT [inserted].[Loan_Id] INTO [@TempTable]	-- table temporaire
	VALUES (@copy_id, @loan_date, @return_date, @user_id, @borrower)
	-- récupération variable temp si trigger non déclenché
	SELECT @inserted_loan_id = [Loan_Id]
	FROM [@TempTable]
END
