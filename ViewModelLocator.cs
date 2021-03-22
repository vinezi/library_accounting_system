using library_accounting_system.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_accounting_system
{
    class ViewModelLocator
    {
        public MainViewModel MainViewModel => Ioc.Resolve<MainViewModel>();
        public LoginPageViewModel LoginPageViewModel => Ioc.Resolve<LoginPageViewModel>();
        public RegistrationPageViewModel RegistrationPageViewModel => Ioc.Resolve<RegistrationPageViewModel>();
        public MainLibraryPageViewModel MainLibraryPageViewModel => Ioc.Resolve<MainLibraryPageViewModel>();
        public BookAuthorPageViewModel BookAuthorPageViewModel => Ioc.Resolve<BookAuthorPageViewModel>();
        public AdminPanelPageViewModel AdminPanelPageViewModel => Ioc.Resolve<AdminPanelPageViewModel>();

        //////////////////////////INFO/////////////////////
        public BookInfoPageViewModel BookInfoPageViewModel => Ioc.Resolve<BookInfoPageViewModel>();
        public AuthorInfoPageViewModel AuthorInfoPageViewModel => Ioc.Resolve<AuthorInfoPageViewModel>();
    }
}
