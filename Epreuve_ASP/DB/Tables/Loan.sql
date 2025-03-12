CREATE TABLE [dbo].[Loan]
(
	[Loan_Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[Copy] UNIQUEIDENTIFIER NOT NULL,		-- besoin trace
	[Loan_Date] DATETIME2 NOT NULL,
	[Return_Date] DATETIME2,
	[Lender] UNIQUEIDENTIFIER NOT NULL,		-- besoin trace
	[Lender_Score] TINYINT,
	[Borrower] UNIQUEIDENTIFIER NOT NULL,	-- besoin trace
	[Borrower_Score] TINYINT,
	
	-- PK composite
	CONSTRAINT [PK_Loan] PRIMARY KEY ([Loan_Id]),
	-- FK exemplaire
	CONSTRAINT [FK_Loan_Game] FOREIGN KEY ([Copy])
		REFERENCES [Copy]([Copy_Id]),
	-- FK prêteur
	CONSTRAINT [FK_Loan_Lender] FOREIGN KEY ([Lender])
		REFERENCES [User]([User_Id])
		ON DELETE NO ACTION,
	-- FK emprunteur
	CONSTRAINT [FK_Loan_Borrower] FOREIGN KEY ([Borrower])
		REFERENCES [User]([User_Id])
		ON DELETE NO ACTION,
	-- CK notes
	CONSTRAINT [CK_Loan_LenderScore] CHECK ([Lender_Score] IS NULL OR [Lender_Score] BETWEEN 0 AND 5),
	CONSTRAINT [CK_Loan_BorrowerScore] CHECK ([Borrower_Score] IS NULL OR [Borrower_Score] BETWEEN 0 AND 5)

	-- contraintes validées par trigger :
		-- prêteur = propriétaire
		-- état exemplaire != 'Incomplete'
)
