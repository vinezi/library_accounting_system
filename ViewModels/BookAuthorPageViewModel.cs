using DevExpress.Mvvm;
using library_accounting_system.Models;
using library_accounting_system.Pages;
using library_accounting_system.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace library_accounting_system.ViewModels
{
    class BookAuthorPageViewModel : BindableBase
    {
        private readonly PageService _navigation;

        public ObservableCollection<BookModel> Books { get; set; } = new ObservableCollection<BookModel>();

        public BookAuthorPageViewModel(PageService navigation)
        {
            Books.Add(new BookModel
            {
                Title = "TitleTitleTitleTitleTitle",
                Autor = "AutorAutorAutorAutorAutor",
                cover = "covercovercovercovercover"
            });

            _navigation = navigation;
        }

        public ICommand OpenAutorInfo => new DelegateCommand(() =>
        {
            _navigation.Navigate(new AuthorInfoPage());
        });
        

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public ICommand GoMainPage => new DelegateCommand(() =>
        {
            _navigation.Navigate(new MainLibraryPage());
        });
    }
}
