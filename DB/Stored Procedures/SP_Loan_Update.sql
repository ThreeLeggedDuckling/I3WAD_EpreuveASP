CREATE PROCEDURE [dbo].[SP_Loan_Update]
	@loan_id UNIQUEIDENTIFIER,
	@retun_date DATETIME2 = NULL,
	@lender_score TINYINT = NULL,
	@borrowerer_score TINYINT = NULL
AS
BEGIN
	UPDATE [Loan]
		SET [ReturnDate] = ISNULL(@retun_date, [ReturnDate]),
			[LenderScore] = ISNULL(@lender_score, [LenderScore]),
			[BorrowerScore] = ISNULL(@borrowerer_score, [BorrowerScore])
	WHERE [Loan_Id] = @loan_id
END
