using Microsoft.Extensions.Logging;
using ShellLessonStep2.Views;
using ShellLessonStep2.Services;
using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2;

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
            })
            .RegisterDataServices()
            .RegisterPages()
            .RegisterViewModels()
            ;

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
    public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
    {
        //--------singleton Pages
        builder.Services.AddSingleton<Bears>();
        builder.Services.AddSingleton<Cats>();
        builder.Services.AddSingleton<Dogs>();
        builder.Services.AddSingleton<Monkeys>();
        builder.Services.AddSingleton<Elephants>();


        //--------Transient pages

        builder.Services.AddTransient<AnimalDetailsView>();

        return builder;
    }

    public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<AnimalService>();
        return builder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<AnimalViewModel>();


        //--------Transient ViewModels
        builder.Services.AddTransient<AnimalDetailsViewModels>();

        return builder;
    }
}
