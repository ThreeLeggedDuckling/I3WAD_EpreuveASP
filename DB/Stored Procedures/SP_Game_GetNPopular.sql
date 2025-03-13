CREATE PROCEDURE [dbo].[SP_Game_GetNPopular]
	@nb_results TINYINT
AS
BEGIN
	SELECT TOP (@nb_results)
			COUNT(l.[Loan_Id]) [Loan_Count],
			[Game_Id],
			[Name]
	FROM [Game] g
		INNER JOIN [Copy] c
		ON g.[Game_Id] = c.[Game]
		INNER JOIN [Loan] l
		ON c.[Copy_Id] = l.[Copy]
	GROUP BY g.[Game_Id], g.[Name]
	ORDER BY [Loan_Count] DESC
END
