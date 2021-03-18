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
    class MainLibraryPageViewModel : BindableBase
    {
        private readonly PageService _navigation;

        public ObservableCollection<BookModel> Books { get; set; } = new ObservableCollection<BookModel>();

        public MainLibraryPageViewModel(PageService navigation)
        {
            _navigation = navigation;


            Books.Add(new BookModel
            {
                Title = "TitleTitleTitleTitleTitle",
                Autor = "AutorAutorAutorAutorAutor",
                cover = "covercovercovercovercover"
            });

            Books.Add(new BookModel
            {
                Title = "2TitleTitleTitleTitleTitle",
                Autor = "2AutorAutorAutorAutorAutor",
                cover = "2covercovercovercovercover"
            });

            Books.Add(new BookModel
            {
                Title = "3TitleTitleTitleTitleTitle",
                Autor = "3AutorAutorAutorAutorAutor",
                cover = "3covercovercovercovercover"
            });

            Books.Add(new BookModel
            {
                Title = "4TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            /*Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });
            Books.Add(new BookModel
            {
                Title = "5TitleTitleTitleTitleTitle",
                Autor = "42AutorAutorAutorAutorAutor",
                cover = "4covercovercovercovercover"
            });*/
        }



        public ICommand OpenBookInfo => new DelegateCommand(() =>
        {
            _navigation.Navigate(new BookInfoPage());
        });



        /////////////////////////////NAVIGATION TEST/////////////////////////////
        ///
        public ICommand GoAutorPage => new DelegateCommand(() =>
        {
            _navigation.Navigate(new BookAuthorPage());
        });

        public ICommand GoSearchPage => new DelegateCommand(() =>
        {
            _navigation.Navigate(new BookAuthorPage());
        });

        public ICommand GoMyBookPage => new DelegateCommand(() =>
        {
            _navigation.Navigate(new BookAuthorPage());
        });
        public ICommand GoSettingPage => new DelegateCommand(() =>
        {
            _navigation.Navigate(new BookAuthorPage());
        });


    }
}
