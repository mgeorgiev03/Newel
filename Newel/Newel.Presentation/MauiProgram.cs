using Android.SE.Omapi;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Controls;

namespace Newel.Presentation
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

           // builder.Services.AddDbContext<DbContext>(options =>
            //options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = NewelDb"));

            // Register repositories
            builder.Services.AddScoped<IToDoListRepository, ToDoListRepository>();
            builder.Services.AddScoped<IToDoItemRepository, ToDoItemRepository>();

            // Register services
            //builder.Services.AddScoped<IChatService, ChatService>();
            //builder.Services.AddScoped<IMessageService, MessageService>();
            //builder.Services.AddScoped<IUserService, UserService>();
            //builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}