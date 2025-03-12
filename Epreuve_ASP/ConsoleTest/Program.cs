using Common.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console de test pré base service (voir commit 2 feb)  */


            /*  Test DAL Cocktail  */



            //CocktailService service = new CocktailService();



            /*  GetAll
 
            Console.WriteLine("TEST GET ALL");
 
            foreach (Cocktail cocktail in service.GetAll())
 
            {
 
                Console.WriteLine($"{cocktail.Cocktail_Id} : {cocktail.Name}");
 
            }
 
            */



            /*  GetById
 
            Console.WriteLine("\nTEST GET BY ID");
 
            //Cocktail testById = service.GetById(Guid.Parse("59bbf71c-0585-477a-9de7-173ca1f99fd8"));    // I3
 
            Cocktail testById = service.GetById(Guid.Parse("46599bcb-f5b0-417d-b586-02ae8bbd702d"));    // home
 
            Console.WriteLine($"{testById.Name} ({testById.CreatedBy}, {testById.CreatedAt})");
 
            Console.WriteLine($"Description : {testById.Description}");
 
            Console.WriteLine($"Instructions : {testById.Instructions}");
 
            */



            /*  GetByUser
 
            Console.WriteLine("\nTEST GET BY USER");
 
            //foreach (Cocktail cocktail in service.GetByUser(Guid.Parse("")))    // I3
 
            foreach (Cocktail cocktail in service.GetByUser(Guid.Parse("967541bd-9f05-4816-a2d4-98a89f393e92")))    // home
 
            {
 
                Console.WriteLine($"{cocktail.Cocktail_Id} : {cocktail.Name}");
 
            }
 
            */



            /*  Insert
 
            Console.WriteLine("\nTEST INSERT");
 
            Cocktail testInsert = new Cocktail()
 
            {
 
                Name = "test",
 
                Description = null,
 
                Instructions = "...",
 
                //CreatedBy = Guid.Parse("365c1abc-2ef3-436a-945b-83abd143cd56")  // I3
 
                CreatedBy = Guid.Parse("967541bd-9f05-4816-a2d4-98a89f393e92")  // home
 
            };
 
            Guid id_testInsert = service.Insert(testInsert);
 
            Cocktail checkTestInsert = service.GetById(id_testInsert);
 
            Console.WriteLine($"{checkTestInsert.Name} ({checkTestInsert.CreatedBy}, {checkTestInsert.CreatedAt})");
 
            Console.WriteLine($"Description : {checkTestInsert.Description}");
 
            Console.WriteLine($"Instructions : {checkTestInsert.Instructions}");
 
            */



            /*  Update
 
            Console.WriteLine("\nTEST UPDATE");
 
            Cocktail testUpdate = new Cocktail()
 
            {
 
                //Cocktail_Id = Guid.Parse(),   // I3
 
                Cocktail_Id = Guid.Parse("38326ba3-bd9c-4dac-9d0a-af620e3e290a"),   // home
 
                Name = "Updated",
 
                Description = "A brand new version !",
 
                Instructions = "[UPDATED] ...",
 
            };
 
            Console.WriteLine("BEFORE");
 
            Cocktail preUpdateCheck = service.GetById(testUpdate.Cocktail_Id);
 
            Console.WriteLine($"{preUpdateCheck.Name} ({preUpdateCheck.CreatedBy}, {preUpdateCheck.CreatedAt})");
 
            Console.WriteLine($"Description : {preUpdateCheck.Description}");
 
            Console.WriteLine($"Instructions : {preUpdateCheck.Instructions}");
 
            service.Update(testUpdate.Cocktail_Id, testUpdate);
 
            Console.WriteLine("\nAFTER");
 
            Cocktail postUpdateCheck = service.GetById(testUpdate.Cocktail_Id);
 
            Console.WriteLine($"{postUpdateCheck.Name} ({postUpdateCheck.CreatedBy}, {postUpdateCheck.CreatedAt})");
 
            Console.WriteLine($"Description : {postUpdateCheck.Description}");
 
            Console.WriteLine($"Instructions : {postUpdateCheck.Instructions}");
 
            */



            /*  Delete
 
            Console.WriteLine("\nTEST DELETE");
 
            Console.WriteLine("BEFORE");
 
            foreach (Cocktail cocktail in service.GetAll())
 
            {
 
                Console.WriteLine($"{cocktail.Cocktail_Id} : {cocktail.Name}");
 
            }
 
            //service.Delete(Guid.Parse("38326ba3-bd9c-4dac-9d0a-af620e3e290a")); // I3
 
            service.Delete(Guid.Parse("a9f90128-1ae7-42b2-a852-1cc195106ff1")); // home
 
            Console.WriteLine("\nAFTER");
 
            foreach (Cocktail cocktail in service.GetAll())
 
            {
 
                Console.WriteLine($"{cocktail.Cocktail_Id} : {cocktail.Name}");
 
            }
 
            */







            /*  Test BLL Cocktail  */



            //ServiceProvider serviceProvider = new ServiceCollection()

            //    .AddScoped<ICocktailRepository<DAL.Entities.Cocktail>, DAL.Services.CocktailService>()

            //    .AddScoped<CocktailService>()

            //    .BuildServiceProvider();

            //CocktailService service = serviceProvider.GetRequiredService<CocktailService>();



            /*  GetAll
 
            Console.WriteLine("TEST GET ALL");
 
            foreach (Cocktail cocktail in service.GetAll())
 
            {
 
                Console.WriteLine($"{cocktail.Cocktail_Id} : {cocktail.Name}");
 
            }
 
            */



            /*  GetById
 
            Console.WriteLine("\nTEST GET BY ID");
 
            //Cocktail testById = service.GetById(Guid.Parse("59bbf71c-0585-477a-9de7-173ca1f99fd8"));    // I3
 
            Cocktail testById = service.GetById(Guid.Parse("46599bcb-f5b0-417d-b586-02ae8bbd702d"));    // home
 

            Console.WriteLine($"{testById.Name} ({testById.CreatedBy}, {testById.CreatedAt})");
 

            Console.WriteLine(testById.Name);
 

            Console.WriteLine($"By [user] ({testById.CreatedBy})");
 

            Console.WriteLine($"Posted on {testById.CreatedAt}");
 
            Console.WriteLine($"Description : {testById.Description}");
 

            Console.WriteLine($"Instructions : {testById.Instructions}");
 

            Console.WriteLine("Instructions :");
 

            Console.WriteLine(testById.Instructions);
 
            */



            /*  GetByUser
 
            Console.WriteLine("\nTEST GET BY USER");
 
            //foreach (Cocktail cocktail in service.GetByUser(Guid.Parse("")))    // I3
 
            foreach (Cocktail cocktail in service.GetByUser(Guid.Parse("967541bd-9f05-4816-a2d4-98a89f393e92")))    // home
 
                {
 
                Console.WriteLine($"{cocktail.Cocktail_Id} : {cocktail.Name}");
 
            }
 
            */



            /*  Insert
 
            Console.WriteLine("\nTEST INSERT");
 
            //Cocktail testInsert = new Cocktail("test", null, "...", Guid.Parse("365c1abc-2ef3-436a-945b-83abd143cd56"));    // I3
 
            Cocktail testInsert = new Cocktail("test", null, "...", Guid.Parse("967541bd-9f05-4816-a2d4-98a89f393e92"));    // home
 
            Guid id_testInsert = service.Insert(testInsert);
 
            Cocktail checkTestInsert = service.GetById(id_testInsert);
 

            Console.WriteLine($"{checkTestInsert.Name} ({checkTestInsert.CreatedBy}, {checkTestInsert.CreatedAt})");
 

            Console.WriteLine(checkTestInsert.Name");
 

            Console.WriteLine($"By [user] ({checkTestInsert.CreatedBy})");
 

            Console.WriteLine($"Posted on {checkTestInsert.CreatedAt}");
 
            Console.WriteLine($"Description : {checkTestInsert.Description}");
 

            Console.WriteLine($"Instructions : {checkTestInsert.Instructions}");
 

            Console.WriteLine("Instructions :");
 

            Console.WriteLine(checkTestInsert.Instructions");
 
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
        }
    }
}
