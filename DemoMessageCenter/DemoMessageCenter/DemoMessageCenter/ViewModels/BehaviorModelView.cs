using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace DemoMessageCenter.ViewModels
{
    public class BehaviorModelView
    {
        public string TextMessageCenter { get; set; } = "dèault";

        public BehaviorModelView()
        {
            MessagingCenter.Subscribe<MainPageViewModel>(this, "messageAddress", OnCallBack);
        }

        private void OnCallBack(MainPageViewModel obj)
        {
            Debug.WriteLine(obj);
            TextMessageCenter = obj.selectItemText;
            OnPropertyChanged()
        }
    }
}
