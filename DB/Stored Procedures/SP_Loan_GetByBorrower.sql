CREATE PROCEDURE [dbo].[SP_Loan_GetByBorrower]
	@borrower UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [Loan_Id],
			[Copy],
			[LoanDate],
			[ReturnDate],
			[Lender],
			[LenderScore],
			[Borrower],
			[BorrowerScore]
	FROM [Loan]
	WHERE [Borrower] = @borrower
END
