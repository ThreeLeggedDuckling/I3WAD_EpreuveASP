CREATE PROCEDURE [dbo].[SP_Loan_GetByLender]
	@lender UNIQUEIDENTIFIER
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
	WHERE [Lender] = @lender
END
