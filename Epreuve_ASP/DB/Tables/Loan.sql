CREATE TABLE [dbo].[Loan]
(
	[Loan_Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[Copy] UNIQUEIDENTIFIER NOT NULL,		-- besoin trace
	[LoanDate] DATETIME2 NOT NULL,
	[ReturnDate] DATETIME2,
	[Lender] UNIQUEIDENTIFIER NOT NULL,		-- besoin trace
	[LenderScore] TINYINT,
	[Borrower] UNIQUEIDENTIFIER NOT NULL,	-- besoin trace
	[BorrowerScore] TINYINT,
	
	-- PK composite
	CONSTRAINT [PK_Loan] PRIMARY KEY ([Loan_Id]),
	-- FK exemplaire
	CONSTRAINT [FK_Loan_Game] FOREIGN KEY ([Copy])
		REFERENCES [Copy]([Copy_Id])
		ON DELETE NO ACTION,
	-- FK prêteur
	CONSTRAINT [FK_Loan_Lender] FOREIGN KEY ([Lender])
		REFERENCES [User]([User_Id])
		ON DELETE NO ACTION,
	-- FK emprunteur
	CONSTRAINT [FK_Loan_Borrower] FOREIGN KEY ([Borrower])
		REFERENCES [User]([User_Id])
		ON DELETE NO ACTION,
	-- CK notes
	CONSTRAINT [CK_Loan_LenderScore] CHECK ([LenderScore] IS NULL OR [LenderScore] BETWEEN 0 AND 5),
	CONSTRAINT [CK_Loan_BorrowerScore] CHECK ([BorrowerScore] IS NULL OR [BorrowerScore] BETWEEN 0 AND 5)

	-- contraintes validées par trigger :
		-- prêteur = propriétaire
		-- état exemplaire != 'Incomplete'
)
