namespace MVC_Assignment_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddControllers(); // Add services to add Controller : API
            builder.Services.AddControllersWithViews(); // Add services to add Controller : MVC
            var app = builder.Build();
            app.UseStaticFiles(); //wwwroot
            //end points
            app.MapControllerRoute(
                name: "default",
                pattern: "{Controller}/{action}");

            app.Run();
        }
    }
}
