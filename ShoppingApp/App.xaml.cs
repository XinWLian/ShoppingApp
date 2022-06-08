using ShoppingApp.Model;
using ShoppingApp.Stores;
using ShoppingApp.ViewModel;
using ShoppingApp.ViewModel.ItemPageViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ShoppingApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Customer _customer;
        private NavigationStore _navigationStore;

        public App()
        {
            _customer = new Customer();
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new ProducePageViewModel(_customer);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_customer, _navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
