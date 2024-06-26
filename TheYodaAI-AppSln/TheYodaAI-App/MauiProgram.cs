﻿using Microsoft.Extensions.Logging;
using TheYodaAI_App.Configuration;
using TheYodaAI_App.Services;
using TheYodaAI_App.ViewModels;
using TheYodaAI_App.Views;

namespace TheYodaAI_App
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
            // Registering Views, ViewModels, Services
            builder.RegisterServices()
                .RegisterViewModels()
                .RegisterViews();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        // Methods needing to be registered
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            // AI Assistant??

            mauiAppBuilder.Services.AddTransient<IYodaAssistant, YodaAssistant>();

            mauiAppBuilder.Services.AddTransient<ISettings, ConstantSettings>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<FunFactPageViewModel>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<FunFactsPage>();
            return mauiAppBuilder;
        }
    }
}
