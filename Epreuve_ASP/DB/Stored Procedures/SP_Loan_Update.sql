CREATE PROCEDURE [dbo].[SP_Loan_Update]
	@loan_id UNIQUEIDENTIFIER,
	@retun_date DATETIME2 = NULL,
	@lender_score TINYINT = NULL,
	@borrowerer_score TINYINT = NULL
AS
BEGIN
	UPDATE [Loan]
		SET [Return_Date] = ISNULL(@retun_date, [Return_Date]),
			[Lender_Score] = ISNULL(@lender_score, [Lender_Score]),
			[Borrower_Score] = ISNULL(@borrowerer_score, [Borrower_Score])
	WHERE [Loan_Id] = @loan_id
END
