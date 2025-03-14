/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- table temporaire pour préserver IDs insertions
DECLARE @InsertedIds TABLE (Id UNIQUEIDENTIFIER);


-- insertion 3 utilisateurs
INSERT INTO @InsertedIds (Id)
EXEC SP_User_Insert     @email = N'armadillo@mail.net',
                        @username = N'Alfie',
                        @password = N'Test!1234';
DECLARE @User1 UNIQUEIDENTIFIER;
SELECT @User1 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_User_Insert     @email = N'beluga@mail.net',
                        @username = N'Bernie',
                        @password = N'Test!1234';
DECLARE @User2 UNIQUEIDENTIFIER;
SELECT @User2 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_User_Insert     @email = N'cuckoo@mail.net',
                        @username = N'Charlie',
                        @password = N'Test!1234';
DECLARE @User3 UNIQUEIDENTIFIER;
SELECT @User3 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;


-- insertion 4 jeux
INSERT INTO @InsertedIds (Id)
EXEC SP_Game_Insert     @name = N'Azul',
                        @description = N'A boardgame where you do stuff with gems',
                        @age_min = 10,
                        @age_max = 99,
                        @nb_players_min = 2,
                        @nb_players_max = 6,
                        @playing_time = 45;
DECLARE @Game1 UNIQUEIDENTIFIER;
SELECT @Game1 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Game_Insert     @name = N'Battleship',
                        @description = N'Everybody knows this classic',
                        @age_min = 8,
                        @age_max = 99,
                        @nb_players_min = 2,
                        @nb_players_max = 2,
                        @playing_time = 30;
DECLARE @Game2 UNIQUEIDENTIFIER;
SELECT @Game2 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Game_Insert     @name = N'Cards against humanity',
                        @description = N'The fine line between dark humor and outright intolerance',
                        @age_min = 14,
                        @age_max = 99,
                        @nb_players_min = 3,
                        @nb_players_max = 10,
                        @playing_time = 50;
DECLARE @Game3 UNIQUEIDENTIFIER;
SELECT @Game3 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Game_Insert     @name = N'Dodo Batallions',
                        @description = N'RTS of extinction',
                        @age_min = 14,
                        @age_max = 99,
                        @nb_players_min = 2,
                        @nb_players_max = 8,
                        @playing_time = 90;
DECLARE @Game4 UNIQUEIDENTIFIER;
SELECT @Game4 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;


-- insertion tags par défaut
INSERT INTO [Tag] ([Tag_Id])
VALUES ('Cooperation'), ('Team'), ('Dices'), ('Cards'), ('Board'), ('Money');


-- association jeux - tags
--INSERT INTO [GameTag] (Game, Tag)
--VALUES (@Game1, 'Board'), (@Game2, 'Board'), (@Game3, 'Cards'), (@Game4, 'Teams'), (@Game4, 'Board')


-- insertion exemplaires
INSERT INTO @InsertedIds (Id)
EXEC SP_Copy_Insert     @game_id = @Game1,
                        @user_id = @User1,
                        @state = 'Damaged'
DECLARE @Copy1 UNIQUEIDENTIFIER;
SELECT @Copy1 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Copy_Insert     @game_id = @Game2,
                        @user_id = @User2,
                        @state = 'Damaged'
DECLARE @Copy2 UNIQUEIDENTIFIER;
SELECT @Copy2 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Copy_Insert     @game_id = @Game3,
                        @user_id = @User3,
                        @state = 'New'
DECLARE @Copy3 UNIQUEIDENTIFIER;
SELECT @Copy3 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Copy_Insert     @game_id = @Game4,
                        @user_id = @User1,
                        @state = 'New'
DECLARE @Copy4 UNIQUEIDENTIFIER;
SELECT @Copy4 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Copy_Insert     @game_id = @Game1,
                        @user_id = @User2,
                        @state = 'Incomplete'
DECLARE @Copy5 UNIQUEIDENTIFIER;
SELECT @Copy5 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Copy_Insert     @game_id = @Game2,
                        @user_id = @User3,
                        @state = 'New'
DECLARE @Copy6 UNIQUEIDENTIFIER;
SELECT @Copy6 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Copy_Insert     @game_id = @Game3,
                        @user_id = @User1,
                        @state = 'Incomplete'
DECLARE @Copy7 UNIQUEIDENTIFIER;
SELECT @Copy7 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;

INSERT INTO @InsertedIds (Id)
EXEC SP_Copy_Insert     @game_id = @Game4,
                        @user_id = @User2,
                        @state = 'New'
DECLARE @Copy8 UNIQUEIDENTIFIER;
SELECT @Copy8 = Id FROM @InsertedIds;
DELETE FROM @InsertedIds;


-- insertion prêts
DECLARE @CurrentTime DATETIME2 = GETDATE();

EXEC SP_Loan_Insert     @user_id = @User1,
                        @copy_id = @Copy1,
                        @loan_date = @CurrentTime,
                        @borrower = @User2

EXEC SP_Loan_Insert     @user_id = @User2,
                        @copy_id = @Copy2,
                        @loan_date = @CurrentTime,
                        @borrower = @User3

EXEC SP_Loan_Insert     @user_id = @User3,
                        @copy_id = @Copy3,
                        @loan_date = @CurrentTime,
                        @borrower = @User1
