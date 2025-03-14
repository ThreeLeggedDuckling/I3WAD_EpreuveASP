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
            /*  Console de test pré base service (voir commit 2 feb)  */

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
                Username = "CT02",
                Email = "ct02@test.net",
                Password = "Test!1234"
            };

            Console.WriteLine("TEST INSERT USER");
            Guid userInsert_id = userService.Insert(userInsert);
            User checkTestInsert = userService.Get(userInsert_id);

            Console.WriteLine($"{checkTestInsert.Username} ({checkTestInsert.User_Id})");
            Console.WriteLine(checkTestInsert.Email);
            Console.WriteLine(checkTestInsert.Password);
            Console.WriteLine(checkTestInsert.CreatedAt.ToShortTimeString());
            Console.WriteLine((checkTestInsert.DisabledAt is null) ? "active account" : "disabled account");
            */


            /*  2. Update
            User userUpdate = new User()
            {
                User_Id = Guid.Parse("8141b015-2aff-4a41-a81b-070191d9e856"),   // I3
                Username = "CT02-updated",
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
                User_Id = Guid.Parse("8141b015-2aff-4a41-a81b-070191d9e856"),   // I3
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
                Name = "CTGame02",
                Description = "Lorem ipsum 02",
                AgeMin = 10,
                AgeMax = 99,
                NbPlayersMin = 2,
                NbPlayersMax = 6,
                PlayingTime = 90
            };

            Console.WriteLine("TEST INSERT GAME");
            Guid gameInserted_id = gameService.Insert(gameInsert);
            Game checkTestInsert = gameService.Get(gameInserted_id);

            Console.WriteLine($"{checkTestInsert.Name} ({checkTestInsert.Game_Id})");
            Console.WriteLine($"Description : {checkTestInsert.Description}");
            Console.WriteLine($"Age : {checkTestInsert.AgeMin} - {checkTestInsert.AgeMax}");
            Console.WriteLine($"Nb players : {checkTestInsert.NbPlayersMin} - {checkTestInsert.NbPlayersMax}");
            Console.WriteLine($"Playing time : {checkTestInsert.PlayingTime}");
            */

            /*  2. GetAll + GetByName
            Console.WriteLine("TEST GET ALL GAMEs");
            foreach (Game g in gameService.Get())
            {
                Console.WriteLine($"{g.Name} ({g.Game_Id})");
            }

            Console.WriteLine("TEST GET GAME BY NAME");
            IEnumerable<Game> gamesByName = gameService.GetByName("02");
            Console.WriteLine($"Games with '02' in their name : {gamesByName.Count()}");
            foreach (Game g in gamesByName)
            {
                Console.WriteLine($"{g.Name} ({g.Game_Id})");
            }
            */



            /*  2. Update
            User userUpdate = new User()
            {
                User_Id = Guid.Parse("8141b015-2aff-4a41-a81b-070191d9e856"),   // I3
                Username = "CT02-updated",
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
                User_Id = Guid.Parse("8141b015-2aff-4a41-a81b-070191d9e856"),   // I3
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

            #region Test DAL CopyService
            /*  1. Insert + GetById
            User userInsert = new User()
            {
                Username = "CT02",
                Email = "ct02@test.net",
                Password = "Test!1234"
            };

            Console.WriteLine("TEST INSERT USER");
            Guid userInsert_id = userService.Insert(userInsert);
            User checkTestInsert = userService.Get(userInsert_id);

            Console.WriteLine($"{checkTestInsert.Username} ({checkTestInsert.User_Id})");
            Console.WriteLine(checkTestInsert.Email);
            Console.WriteLine(checkTestInsert.Password);
            Console.WriteLine(checkTestInsert.CreatedAt.ToShortTimeString());
            Console.WriteLine((checkTestInsert.DisabledAt is null) ? "active account" : "disabled account");
            */


            /*  2. Update
            User userUpdate = new User()
            {
                User_Id = Guid.Parse("8141b015-2aff-4a41-a81b-070191d9e856"),   // I3
                Username = "CT02-updated",
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
                User_Id = Guid.Parse("8141b015-2aff-4a41-a81b-070191d9e856"),   // I3
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

            // services pour tester la BLL
            //ServiceProvider serviceProvider = new ServiceCollection()
            //    .AddScoped<IUserRepository<DAL.Entities.User>, DAL.Services.UserService>()
            //    .AddScoped<UserService>()
            //    .BuildServiceProvider();
            //UserService userService = serviceProvider.GetRequiredService<UserService>();

            #region Test BLL UserService
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
