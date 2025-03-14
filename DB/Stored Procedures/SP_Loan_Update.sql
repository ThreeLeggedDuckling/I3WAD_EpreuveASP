CREATE PROCEDURE [dbo].[SP_Loan_Update]
	@loan_id UNIQUEIDENTIFIER,
	@ReturnDate DATETIME2 = NULL,
	@LenderScore TINYINT = NULL,
	@BorrowerScore TINYINT = NULL
AS
BEGIN
	UPDATE [Loan]
		SET [ReturnDate] = ISNULL(@ReturnDate, [ReturnDate]),
			[LenderScore] = ISNULL(@LenderScore, [LenderScore]),
			[BorrowerScore] = ISNULL(@BorrowerScore, [BorrowerScore])
	WHERE [Loan_Id] = @loan_id
END
