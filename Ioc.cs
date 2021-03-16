using library_accounting_system.Services;
using library_accounting_system.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_accounting_system
{
    class Ioc
    {
        private static readonly ServiceProvider _provider;

        static Ioc()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<LoginPageViewModel>();
            services.AddSingleton<RegistrationPageViewModel>();
            services.AddSingleton<MainLibraryPageViewModel>();
            services.AddSingleton<BookAuthorPageViewModel>();
            services.AddSingleton<BookInfoPageViewModel>();


            services.AddSingleton<PageService>();

            _provider = services.BuildServiceProvider();
        }

        public static T Resolve<T>() => _provider.GetRequiredService<T>();
    }
}
