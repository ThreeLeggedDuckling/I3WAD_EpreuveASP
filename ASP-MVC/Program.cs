using ASP_MVC.Handlers;
using Common.Repositories;

namespace ASP_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // ajout accès HttpContexte
            builder.Services.AddHttpContextAccessor();
            // ajout sessions
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(
                options => {
                    options.Cookie.Name = "somenametochange";
                    options.Cookie.HttpOnly = true;
                    options.Cookie.IsEssential = true;
                    options.IdleTimeout = TimeSpan.FromSeconds(10);
                });
            // ajout session manager
            builder.Services.AddScoped<SessionManager>();
            // injection services DAL et BLL    !!! à modifier quand fini test console
            builder.Services.AddScoped<IUserRepository<DAL.Entities.User>, DAL.Services.UserService>();
            builder.Services.AddScoped<IUserRepository<BLL.Entities.User>, BLL.Services.UserService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // ajout session
            app.UseSession();
            app.UseCookiePolicy();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
