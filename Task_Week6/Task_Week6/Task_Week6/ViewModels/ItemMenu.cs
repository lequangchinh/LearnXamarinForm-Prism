using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Task_Week6.Views;


namespace Task_Week6.ViewModels
{
	public class ItemMenu 
	{
        public ItemMenu()
        {
            TargetType = typeof(DetailPage);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
