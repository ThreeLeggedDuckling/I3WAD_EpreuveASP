CREATE PROCEDURE [dbo].[SP_Loan_GetByBorrower]
	@borrower UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [Loan_Id],
			[Copy],
			[Lender],
			[LenderScore]
	FROM [Loan]
	WHERE [Borrower] = @borrower
END
