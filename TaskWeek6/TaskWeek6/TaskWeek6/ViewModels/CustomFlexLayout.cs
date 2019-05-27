using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TaskWeek6.ViewModels
{
    public class CustomFlexLayout : FlexLayout
    {
        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(
            nameof(ItemsSource),
            typeof(DataTemplate),
            typeof(CustomFlexLayout),
            propertyChanged: OnItemsSourceChanged);

        public static readonly BindableProperty ItemTemplateProperty = BindableProperty.Create(
            nameof(ItemTemplate),
            typeof(DataTemplate),
            typeof(CustomFlexLayout));

        private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            IEnumerable newVal = newValue as IEnumerable;
            var layout = (CustomFlexLayout)bindable;

            layout.Children.Clear();
            if(newVal != null)
            {
                foreach(var item in newVal)
                {
                    layout.Children.Add(layout.CreateChildView(item));
                }
            }

        }

        private View CreateChildView(object item)
        {
            ItemTemplate.SetValue(BindableObject.BindingContextProperty, item);
            return (View)ItemTemplate.CreateContent();
        }

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }
    }
}
