using Common.Repositories;
//using DAL.Entities;
//using DAL.Services;
using BLL.Entities;
using BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console de test pré base service (voir commit 2 feb)  */

            #region Test DAL UserService
            //UserService userService = new UserService();

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

            #region Test BLL UserService
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddScoped<IUserRepository<DAL.Entities.User>, DAL.Services.UserService>()
                .AddScoped<UserService>()
                .BuildServiceProvider();
            UserService userService = serviceProvider.GetRequiredService<UserService>();

            /*  1. Insert + Get
            User userInsert = new User("CT03", "ct03@test.net", "Test!1234");

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
            /*  Update
 
            Console.WriteLine("\nTEST UPDATE");
 
            Cocktail testUpdate = new Cocktail("Test v2", "Look some text", "[updated]")
 
            {
 
                //Cocktail_Id = Guid.Parse(),   // I3
 
                Cocktail_Id = Guid.Parse("3bd259fa-676c-43df-815d-528b7c7046db"),   // home
 
            };
            Console.WriteLine("BEFORE");
 
            Cocktail preUpdateCheck = service.GetById(testUpdate.Cocktail_Id);
 
            Console.WriteLine($"{preUpdateCheck.Name} ({preUpdateCheck.CreatedBy}, {preUpdateCheck.CreatedAt})");
 

            Console.WriteLine(preUpdateCheck.Name);
 
            Console.WriteLine($"Description : {preUpdateCheck.Description}");
 

            Console.WriteLine($"Instructions : {preUpdateCheck.Instructions}");
 

            Console.WriteLine("Instructions :");
 

            Console.WriteLine(preUpdateCheck.Instructions);
 

 
            service.Update(testUpdate.Cocktail_Id, testUpdate);
 
            Console.WriteLine("\nAFTER");
 
            Cocktail postUpdateCheck = service.GetById(testUpdate.Cocktail_Id);
 

            Console.WriteLine($"{postUpdateCheck.Name} ({postUpdateCheck.CreatedBy}, {postUpdateCheck.CreatedAt})");
 

            Console.WriteLine($"{postUpdateCheck.Name}");
 
            Console.WriteLine($"Description : {postUpdateCheck.Description}");
 

            Console.WriteLine($"Instructions : {postUpdateCheck.Instructions}");
 

            Console.WriteLine("Instructions :");
 

            Console.WriteLine(postUpdateCheck.Instructions");
 
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








            /*  Delete
 
            Console.WriteLine("\nTEST DELETE");
 
            Console.WriteLine("BEFORE");
 
            foreach (Cocktail cocktail in service.GetAll())
 
            {
 
                Console.WriteLine($"{cocktail.Cocktail_Id} : {cocktail.Name}");
 
            }
 
            //service.Delete(Guid.Parse("")); // I3
 
            service.Delete(Guid.Parse("3bd259fa-676c-43df-815d-528b7c7046db")); // home
 
            Console.WriteLine("\nAFTER");
 
            foreach (Cocktail cocktail in service.GetAll())
 
            {
 
                Console.WriteLine($"{cocktail.Cocktail_Id} : {cocktail.Name}");
 
            }
 
            */

            #endregion

        }
    }
}
