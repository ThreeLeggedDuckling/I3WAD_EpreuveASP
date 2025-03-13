CREATE PROCEDURE [dbo].[SP_Loan_GetById]
	@loan_id UNIQUEIDENTIFIER
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
	WHERE [Loan_Id] = @loan_id
END
