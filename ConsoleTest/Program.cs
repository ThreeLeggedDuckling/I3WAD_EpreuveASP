using Common.Repositories;
using DAL.Entities;
using DAL.Services;
//using BLL.Entities;
//using BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console de test pre-baseService  */

            // services pour tester la DAL
            UserService userService = new UserService();
            GameService gameService = new GameService();
            CopyService copyService = new CopyService();
            LoanService loanService = new LoanService();
            TagService tagService = new TagService();

            #region Test DAL UserService
            /*  1. Insert + GetById
            User userInsert = new User()
            {
                Username = "CT01",
                Email = "ct01@test.net",
                Password = "Test!1234"
            };

            Console.WriteLine("TEST INSERT USER");
            Guid userInsert_id = userService.Insert(userInsert);
            User checkUserInsert = userService.Get(userInsert_id);

            Console.WriteLine($"{checkUserInsert.Username} ({checkUserInsert.User_Id})");
            Console.WriteLine(checkUserInsert.Email);
            Console.WriteLine(checkUserInsert.Password);
            Console.WriteLine(checkUserInsert.CreatedAt.ToShortTimeString());
            Console.WriteLine((checkUserInsert.DisabledAt is null) ? "active account" : "disabled account");
            //*/


            /*  2. Update
            User userUpdate = new User()
            {
                User_Id = Guid.Parse("8141b015-2aff-4a41-a81b-070191d9e856"),
                Username = "CT01-updated",
            };

            Console.WriteLine("TEST UPDATE");
            Console.WriteLine("BEFORE");
            User preUpdateUser = userService.Get(userUpdate.User_Id);
            Console.WriteLine($"{preUpdateUser.User_Id} : {preUpdateUser.Username}");

            Console.WriteLine("\nAFTER");
            userService.Update(userUpdate.User_Id, userUpdate);
            User postUpdateUser = userService.Get(userUpdate.User_Id);
            Console.WriteLine($"{postUpdateUser.User_Id} : {postUpdateUser.Username}");
            */


            /*  3. Delete
            User userDelete = new User()
            {
                User_Id = Guid.Parse("8141b015-2aff-4a41-a81b-070191d9e856"),
            };
 
            Console.WriteLine("TEST DELETE");
            Console.WriteLine("BEFORE");
            User preDeleteUser = userService.Get(userDelete.User_Id);
            Console.WriteLine($"{preDeleteUser.Username} ({preDeleteUser.User_Id})");
            Console.WriteLine(preDeleteUser.CreatedAt.ToShortTimeString());
            Console.WriteLine((preDeleteUser.DisabledAt is null) ? "active account" : "disabled account");

            Console.WriteLine("AFTER");
            userService.Delete(userDelete.User_Id);
            User postDeleteUser = userService.Get(userDelete.User_Id);
            Console.WriteLine($"{postDeleteUser.Username} ({postDeleteUser.User_Id})");
            Console.WriteLine(postDeleteUser.CreatedAt.ToShortTimeString());
            Console.WriteLine((postDeleteUser.DisabledAt is null) ? "active account" : "disabled account");
            */


            /*  4. CheckPassword
            string userEmail = "ct01@test.net";
            string userPasswordOK = "Test!1234";
            string userPasswordKO = "....";

            Console.WriteLine("TEST CHECKPASSWORD");
            Console.WriteLine("SUCCESS");
            Console.WriteLine(userService.CheckPassword(userEmail, userPasswordOK));
            Console.WriteLine("FAIL");    // pas implémenté !!!
            Console.WriteLine(userService.CheckPassword(userEmail, userPasswordKO));
            */
            #endregion

            #region Test DAL GameService
            /*  1. Insert + GetById
            Game gameInsert = new Game()
            {
                Name = "CTGame Disdain",
                Description = "Lorem ipsum blablabli",
                AgeMin = 5,
                AgeMax = 10,
                NbPlayersMin = 2,
                NbPlayersMax = 5,
                PlayingTime = 20
            };

            Console.WriteLine("TEST INSERT GAME");
            Guid gameInserted_id = gameService.Insert(gameInsert);
            Game checkGameInsert = gameService.Get(gameInserted_id);

            Console.WriteLine($"{checkGameInsert.Name} ({checkGameInsert.Game_Id})");
            Console.WriteLine($"Description : {checkGameInsert.Description}");
            Console.WriteLine($"Age : {checkGameInsert.AgeMin} - {checkGameInsert.AgeMax}");
            Console.WriteLine($"Nb players : {checkGameInsert.NbPlayersMin} - {checkGameInsert.NbPlayersMax}");
            Console.WriteLine($"Playing time : {checkGameInsert.PlayingTime}");
            //*/


            /*  2. GetAll + GetByName + GetByTag
            Console.WriteLine("TEST GET ALL GAMEs");
            foreach (Game g in gameService.Get())
            {
                Console.WriteLine($"{g.Name} ({g.Game_Id})");
            }

            Console.WriteLine("TEST GET GAME BY NAME");
            IEnumerable<Game> gamesByName = gameService.GetByName("ain");
            Console.WriteLine($"Games with 'ain' in their name ({gamesByName.Count()})");
            foreach (Game g in gamesByName)
            {
                Console.WriteLine($"{g.Name} ({g.Game_Id})");
            }

            Console.WriteLine("TEST GET GAME BY TAG");
            IEnumerable<Game> gamesByTag = gameService.GetByTag("Board");
            Console.WriteLine($"Games with 'Board' tag ({gamesByTag.Count()})");
            foreach (Game g in gamesByTag)
            {
                Console.WriteLine($"{g.Name} ({g.Game_Id})");
            }
            */
            #endregion

            #region Test DAL CopyService
            /*  1. Insert + GetById
            Copy copyInsert = new Copy()
            {
                Game = Guid.Parse("2b132521-9867-4b37-ba68-f999c440b58e"),
                Owner = Guid.Parse("b106c343-9584-49f1-baff-198e5d7015e5"),
                State = "New"
            };

            Console.WriteLine("TEST INSERT COPY");
            Guid copyInsert_id = copyService.Insert(copyInsert);
            Copy checkCopyInsert = copyService.Get(copyInsert_id);
            Console.WriteLine($"{checkCopyInsert.Copy_Id}");
            Console.WriteLine($"- owner : {userService.Get(checkCopyInsert.Owner).Username}");
            Console.WriteLine($"- game : {gameService.Get(checkCopyInsert.Game).Name}");
            Console.WriteLine($"- state : {checkCopyInsert.State}");
            //*/


            /*  2. GetByGame
            IEnumerable<Copy> copiesByGame = copyService.GetByGame(copyInsert.Game);
            Console.WriteLine($"Registered copies of {gameService.Get(copyInsert.Game).Name} : {copiesByGame.Count()}");
            */


            /*  3. Update
            Copy copyUpdate = new Copy()
            {
                Copy_Id = Guid.Parse("265436f8-91f2-4f5d-85c9-c7ccf00441a8"),
                State = "Incomplete"
            };

            Console.WriteLine("TEST UPDATE");
            Console.WriteLine("BEFORE");
            Copy preUpdateCopy = copyService.Get(copyUpdate.Copy_Id);
            Console.WriteLine(preUpdateCopy.State);

            Console.WriteLine("\nAFTER");
            copyService.Update(copyUpdate.Copy_Id, copyUpdate);
            Copy postUpdateCopy = copyService.Get(copyUpdate.Copy_Id);
            Console.WriteLine(postUpdateCopy.State);
            */


            /*  4. Delete
            Copy copyDelete = new Copy()
            {
                Copy_Id = Guid.Parse("265436f8-91f2-4f5d-85c9-c7ccf00441a8")
            };

            Console.WriteLine("TEST DELETE");
            Console.WriteLine("BEFORE");
            Copy preDeleteCopy = copyService.Get(copyDelete.Copy_Id);
            Console.WriteLine($"Defined owner : {preDeleteCopy.Owner is not null}");
            Console.WriteLine("AFTER");
            copyService.Delete(copyDelete.Copy_Id);
            Copy postDeleteCopy = copyService.Get(copyDelete.Copy_Id);
            Console.WriteLine($"Defined owner : {postDeleteCopy.Owner is not null}");
            */
            #endregion

            #region Test DAL TagService
            /*  1. GetAll
            Console.WriteLine("TEST GET ALL TAG");
            IEnumerable<Tag> allTags = tagService.Get();
            foreach (Tag t in allTags)
            {
                Console.WriteLine(t.Tag_Id);
            }
            */


            /*  2. Insert + GetById
            Tag tagInsert = new Tag()
            {
                Tag_Id = "CT-Tag01"
            };

            Console.WriteLine("TEST INSERT TAG");
            tagService.Insert(tagInsert);
            Console.WriteLine(tagService.Get(tagInsert.Tag_Id).Tag_Id);
            */


            /*  3. gameService.AddTag
            Guid gameToTag = Guid.Parse("2b132521-9867-4b37-ba68-f999c440b58e");

            Console.WriteLine("TEST ADD TAG");
            Console.WriteLine("BEFORE");
            IEnumerable<Game> gamesTaggedBefore = gameService.GetByTag("CT-Tag01");
            Console.WriteLine($"Games tagged 'CT-Tag01' ({gamesTaggedBefore.Count()})");
            foreach (Game g in gamesTaggedBefore)
            {
                Console.WriteLine(g.Name);
            }

            Console.WriteLine("AFTER");
            Console.WriteLine(gameService.AddTag(gameToTag, "CT-Tag01"));
            IEnumerable<Game> gamesTaggedAfter = gameService.GetByTag("CT-Tag01");
            Console.WriteLine($"Games tagged 'CT-Tag01' ({gamesTaggedAfter.Count()})");
            foreach (Game g in gamesTaggedAfter)
            {
                Console.WriteLine(g.Name);
            }
            */
            #endregion

            #region Test DAL LoanService
            /*  1. Insert + GetById
            Loan loanInsert = new Loan()
            {
                Copy = Guid.Parse("7b8d251d-88eb-46ee-a4b3-89fdd10e4827"),
                LoanDate = DateTime.Now,
                Lender = Guid.Parse("ca41c659-5442-4377-bd6c-c945b1927c82"),
                Borrower = Guid.Parse("23a69be7-28a9-44bd-bab0-2eb441251037")
            };

            Console.WriteLine("TEST INSERT LOAN");
            Guid loanInsert_id = loanService.Insert(loanInsert.Lender, loanInsert);
            Loan checkLoanInsert = loanService.Get(loanInsert_id);
            Console.WriteLine($"{checkLoanInsert.Loan_Id}");
            Console.WriteLine($"- game : {gameService.Get(copyService.Get(checkLoanInsert.Copy).Game).Name}");
            Console.WriteLine($"- state : {copyService.Get(checkLoanInsert.Copy).State}");
            Console.WriteLine($"- from : {userService.Get(checkLoanInsert.Lender).Username} ({checkLoanInsert.LenderScore})");
            Console.WriteLine($"- to : {userService.Get(checkLoanInsert.Borrower).Username} ({checkLoanInsert.BorrowerScore})");
            Console.WriteLine($"- begins : {checkLoanInsert.LoanDate}");
            Console.WriteLine($"- ends : {checkLoanInsert.ReturnDate}");
            */


            /*  2. GetByLender + GetByBorrower
            Guid user_id = Guid.Parse("23a69be7-28a9-44bd-bab0-2eb441251037");
            Console.WriteLine($"{userService.Get(user_id).Username} loans");

            Console.WriteLine("TEST GET LOAN BY LENDER");
            IEnumerable<Loan> loansByLender = loanService.GetByLender(user_id);
            Console.WriteLine($"Games lended ({loansByLender.Count()})");
            foreach(Loan l in loansByLender)
            {
                Console.WriteLine($"- {gameService.Get(copyService.Get(l.Copy).Game).Name} (to {userService.Get(l.Borrower).Username})");
            }

            Console.WriteLine("TEST GET LOAN BY BORROWER");
            IEnumerable<Loan> loansByBorrower = loanService.GetByBorrower(user_id);
            Console.WriteLine($"Games borrowed ({loansByBorrower.Count()})");
            foreach (Loan l in loansByBorrower)
            {
                Console.WriteLine($"- {gameService.Get(copyService.Get(l.Copy).Game).Name} (from {userService.Get(l.Lender).Username})");
            }
            */


            /*  3. Update
            Loan loanUpdate = new Loan()
            {
                Loan_Id = Guid.Parse("6200c50e-be36-4556-a8cf-ed2c60916d5e"),
                ReturnDate = DateTime.Now,
                LenderScore = 4
            };

            Console.WriteLine("TEST UPDATE");
            Console.WriteLine("BEFORE");
            Loan preUpdateLoan = loanService.Get(loanUpdate.Loan_Id);
            Console.WriteLine($"{preUpdateLoan.Loan_Id}");
            Console.WriteLine($"- game : {gameService.Get(copyService.Get(preUpdateLoan.Copy).Game).Name}");
            Console.WriteLine($"- state : {copyService.Get(preUpdateLoan.Copy).State}");
            Console.WriteLine($"- from : {userService.Get(preUpdateLoan.Lender).Username} ({preUpdateLoan.LenderScore})");
            Console.WriteLine($"- to : {userService.Get(    preUpdateLoan.Borrower).Username} ({preUpdateLoan.BorrowerScore})");
            Console.WriteLine($"- begins : {preUpdateLoan.LoanDate}");
            Console.WriteLine($"- ends : {preUpdateLoan.ReturnDate}");

            Console.WriteLine("\nAFTER");
            loanService.Update(loanUpdate.Loan_Id, loanUpdate);
            Loan postUpdateLoan = loanService.Get(loanUpdate.Loan_Id);
            Console.WriteLine($"{postUpdateLoan.Loan_Id}");
            Console.WriteLine($"- game : {gameService.Get(copyService.Get(postUpdateLoan.Copy).Game).Name}");
            Console.WriteLine($"- state : {copyService.Get(postUpdateLoan.Copy).State}");
            Console.WriteLine($"- from : {userService.Get(postUpdateLoan.Lender).Username} ({postUpdateLoan.LenderScore})");
            Console.WriteLine($"- to : {userService.Get(postUpdateLoan.Borrower).Username} ({postUpdateLoan.BorrowerScore})");
            Console.WriteLine($"- begins : {postUpdateLoan.LoanDate}");
            Console.WriteLine($"- ends : {postUpdateLoan.ReturnDate}");
            */
            #endregion

            #region Test BLL UserService
            // services pour tester la BLL
            //ServiceProvider serviceProvider = new ServiceCollection()
            //    .AddScoped<IUserRepository<DAL.Entities.User>, DAL.Services.UserService>()
            //    .AddScoped<UserService>()
            //    .BuildServiceProvider();
            //UserService userService = serviceProvider.GetRequiredService<UserService>();

            /*  1. Insert + Get
            User userInsert = new User("ct03@test.net", "CT03", "Test!1234");

            Console.WriteLine("TEST INSERT");
            Guid userInsert_id = userService.Insert(userInsert);
            User checkTestInsert = userService.Get(userInsert_id);

            Console.WriteLine($"{checkTestInsert.Username} ({checkTestInsert.User_Id})");
            Console.WriteLine(checkTestInsert.Email);
            Console.WriteLine(checkTestInsert.Password);
            Console.WriteLine(checkTestInsert.CreatedAt.ToShortTimeString());
            Console.WriteLine(checkTestInsert.IsDisabled ? "disabled account" : "active account");
            */


            /*  2. Update
            User userUpdate = new User(Guid.Parse("841d94fd-e3d9-4eaf-8967-3cf02586affc"))  // I3
            {
                Username = "CT03-updated"
            };

            Console.WriteLine("TEST UPDATE");
            Console.WriteLine("BEFORE");
            User preUpdateUser = userService.Get(userUpdate.User_Id);
            Console.WriteLine($"{preUpdateUser.User_Id} : {preUpdateUser.Username}");

            Console.WriteLine("\nAFTER");
            userService.Update(userUpdate.User_Id, userUpdate);
            User postUpdateUser = userService.Get(userUpdate.User_Id);
            Console.WriteLine($"{postUpdateUser.User_Id} : {postUpdateUser.Username}");
            */


            /*  3. Delete
            User userDelete = new User(Guid.Parse("841d94fd-e3d9-4eaf-8967-3cf02586affc")); // I3
 
            Console.WriteLine("TEST DELETE");
            Console.WriteLine("BEFORE");
            User preDeleteUser = userService.Get(userDelete.User_Id);
            Console.WriteLine($"{preDeleteUser.Username} ({preDeleteUser.User_Id})");
            Console.WriteLine(preDeleteUser.CreatedAt.ToShortTimeString());
            Console.WriteLine(preDeleteUser.IsDisabled ? "disabled account" : "active account");

            Console.WriteLine("AFTER");
            userService.Delete(userDelete.User_Id);
            User postDeleteUser = userService.Get(userDelete.User_Id);
            Console.WriteLine($"{postDeleteUser.Username} ({postDeleteUser.User_Id})");
            Console.WriteLine(postDeleteUser.CreatedAt.ToShortTimeString());
            Console.WriteLine(postDeleteUser.IsDisabled ? "disabled account" : "active account");
            */

            //  4. CheckPassword - vérification inutile
            #endregion

        }
    }
}
