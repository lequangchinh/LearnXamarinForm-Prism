using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using TaskWeek6.Views;
namespace TaskWeek6.ViewModels
{
  public  class HomePageMasterModel
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _navigateCommand;


        public HomePageMasterModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand LogoutCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand(OnLogout));

        private void OnLogout()
        {
            _navigationService.GoBackToRootAsync();
        }
    }
}
