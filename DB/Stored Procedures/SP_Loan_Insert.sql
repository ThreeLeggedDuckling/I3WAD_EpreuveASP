CREATE PROCEDURE [dbo].[SP_Loan_Insert]
	@user_id UNIQUEIDENTIFIER,
	@copy_id UNIQUEIDENTIFIER,
	@loan_date DATETIME2,
	@return_date DATETIME2 = NULL,
	@borrower UNIQUEIDENTIFIER
AS
BEGIN
	INSERT INTO [Loan] ([Copy], [LoanDate], [ReturnDate], [Lender], [Borrower])
	OUTPUT [inserted].[Loan_Id]
	VALUES (@copy_id, @loan_date, @return_date, @user_id, @borrower)
END
