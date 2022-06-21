using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M120_M226.Stores;
using M120_M226.ViewModels;
using M120_M226.Models;
using M120_M226.Services;

namespace M120_M226.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        public NavigateCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
