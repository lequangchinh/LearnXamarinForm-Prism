using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using TaskWeek6.Views;


namespace TaskWeek6.ViewModels
{
    public class AboutModel : ViewModelBase
    {
        private string name;
        private string userName;
        private string passWord;

        public AboutModel(INavigationService navigationService) : base(navigationService)
        {
            Name = "Leanne Graham";
            UserName = "Bret";
            PassWord = "123abc456qwe";
        }

        public string Name { get => name; set => name = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            //base.OnNavigatedFrom(parameters);

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("name"))
                Name = (string)parameters["name"] + " and Prism";
        }
    }
}
