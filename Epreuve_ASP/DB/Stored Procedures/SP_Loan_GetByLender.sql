CREATE PROCEDURE [dbo].[SP_Loan_GetByLender]
	@lender UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [Loan_Id],
			[Copy],
			[Borrower],
			[BorrowerScore]
	FROM [Loan]
	WHERE [Lender] = @lender
END
