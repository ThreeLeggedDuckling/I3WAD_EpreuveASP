CREATE PROCEDURE [dbo].[SP_Game_GetNPopular]
	@nb_results TINYINT = 10
AS
BEGIN
	SELECT TOP (@nb_results) [Game_Id], [Name]
	FROM [Loan] AS l
		INNER JOIN [Copy] AS c
		ON l.[Copy] = c.[Copy_Id]
		INNER JOIN [Game] AS g
		ON c.[Game] = g.[Game_Id]
	--GROUP BY 
	--ORDER BY COUNT(l)
END

/*	A FINIR PROPREMENT	*/
