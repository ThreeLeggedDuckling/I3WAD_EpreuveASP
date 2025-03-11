CREATE TABLE [dbo].[Loan]
(
	[Copy] UNIQUEIDENTIFIER NOT NULL,
	[Loan_Date] DATETIME2 NOT NULL,
	[Return_Date] DATETIME2,
	[Lender] UNIQUEIDENTIFIER NOT NULL,		-- besoin trace
	[Lender_Score] TINYINT,
	[Borrower] UNIQUEIDENTIFIER NOT NULL,	-- besoin trace
	[Borrower_Score] TINYINT,
	
	-- PK composite
	CONSTRAINT [PK_Loan] PRIMARY KEY ([Copy], [Loan_Date]),
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
		-- état != 'Incomplete'
)
GO

-- ajout d'index pour de meilleures performances de requête
CREATE INDEX [IX_Loan_Copy] ON [dbo].[Loan] ([Copy])
GO
CREATE INDEX [IX_Loan_Lender] ON [dbo].[Loan] ([Lender])
GO
CREATE INDEX [IX_Loan_Borrower] ON [dbo].[Loan] ([Borrower])
GO
