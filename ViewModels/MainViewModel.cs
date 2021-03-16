using DevExpress.Mvvm;
using library_accounting_system.Pages;
using library_accounting_system.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace library_accounting_system.ViewModels
{
    class MainViewModel : BindableBase
    {
        private readonly PageService _navigation;

        public Page CurrentPage { get; set; }



        public MainViewModel(PageService navigation)
        {
            navigation.OnPageChanged += page => CurrentPage = page;
            navigation.Navigate(new LoginPage());
            _navigation = navigation;
        }


        public ICommand GoToBack => new DelegateCommand(() =>
        {
            _navigation.GoToBack();
        }, () => _navigation.CanGoToBack);


        public ICommand GoRu => new DelegateCommand(() =>
        {
            Selector("RU");
        });

        public ICommand GoEn => new DelegateCommand(() =>
        {
            Selector("EN");
        });

        public void Selector(string lang)
        {
            var uri = new Uri("Resources/Lang" + lang + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}
