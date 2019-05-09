using DemoMessageCenter.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMessageCenter.ViewModels
{
    public class MainPageViewModel : ViewModelBase, INotifyPropertyChanged    
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            CommandSendMessageCenter = new Command(HandelSendMessagingCenter);
        }

        public string selectItemText = DateTime.Now.ToString();

        public ICommand CommandSendMessageCenter { set; get; }

        private void HandelSendMessagingCenter(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new BehaviorView());
            MessagingCenter.Send<MainPageViewModel>(this, "messageAddress");
            MessagingCenter.Send<MainPageViewModel, string>(this, "message", "value ");
        }

        public void OnCallBack(MainPageViewModel obj)
        {
            Debug.WriteLine(obj);

        }
    }

    
}
