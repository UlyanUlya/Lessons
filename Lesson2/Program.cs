namespace Lesson2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddTransient<IManagementCars, Cars>();

            var app = builder.Build();

            app.Map("/carName", HandleCarName);
            app.Map("/carAge", HandleCarAge);
            app.Map("/carEngine", HandleCarEngine);

            app.Run(async context => {
                var car = app.Services.GetService<IManagementCars>();
                await context.Response.WriteAsync(
                    $"Car name: {car?.GetCarName()}, Car engine: {car?.GetCarEngine()}, Car age: {car?.GetCarAge()}"
                );
            });

            /*// Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();*/

            app.Run();
        }

        private static void HandleCarName(IApplicationBuilder app)
        {
            app.Run(async context => {
                var car = app.ApplicationServices.GetService<IManagementCars>();
                await context.Response.WriteAsync(
                    $"Car name: {car?.GetCarName()}"
                );
            });
        }
        private static void HandleCarAge(IApplicationBuilder app)
        {
            app.Run(async context => {
                var car = app.ApplicationServices.GetService<IManagementCars>();
                await context.Response.WriteAsync(
                    $"Car Age: {car?.GetCarAge()}"
                );
            });
        }
        private static void HandleCarEngine(IApplicationBuilder app)
        {
            app.Run(async context => {
                var car = app.ApplicationServices.GetService<IManagementCars>();
                await context.Response.WriteAsync(
                    $"Car Engine: {car?.GetCarEngine()}"
                );
            });
        }
    }
}