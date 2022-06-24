using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using M120_M226.ViewModels;
using M120_M226.Models;
using M120_M226.Stores;
using M120_M226.Services;

namespace M120_M226
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly HotelModel _hotel;
        private readonly NavigationStore _navigationStore;
        public App()
        {
            _hotel = new HotelModel("Hotel California");
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateGuestListViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private GuestCreateViewModel CreateGuestCreateViewModel()
        {
            return new GuestCreateViewModel(_hotel, new NavigationService(_navigationStore, CreateGuestListViewModel));
        }
        private GuestListViewModel CreateGuestListViewModel()
        {
            return new GuestListViewModel(new NavigationService(_navigationStore, CreateGuestCreateViewModel)); ;
        }
    }
}
