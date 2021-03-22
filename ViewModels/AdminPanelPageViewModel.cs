using DevExpress.Mvvm;
using library_accounting_system.Pages;
using library_accounting_system.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace library_accounting_system.ViewModels
{
    class AdminPanelPageViewModel : BindableBase
    {
        private readonly PageService _navigation;
        public AdminPanelPageViewModel(PageService navigation)
        {
            _navigation = navigation;
        }






        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public ICommand GoMainPage => new DelegateCommand(() =>
        {
            _navigation.Navigate(new MainLibraryPage());
        });

        public ICommand GoAutorPage => new DelegateCommand(() =>
        {
            _navigation.Navigate(new BookAuthorPage());
        });

        public ICommand GoSearchPage => new DelegateCommand(() =>
        {
            //_navigation.Navigate(new BookAuthorPage());
        });

        //////////////////
        public ICommand GoSettingPage => new DelegateCommand(() =>
        {
            //_navigation.Navigate(new BookAuthorPage());
        });

    }
}
