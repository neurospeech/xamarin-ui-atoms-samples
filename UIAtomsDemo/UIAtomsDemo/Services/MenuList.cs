using System;
using System.Linq;
using System.Collections.Generic;
using NeuroSpeech.UIAtoms;
using NeuroSpeech.UIAtoms.DI;
using System.Text;
using UIAtomsDemo.Services;
using Xamarin.Forms;
using System.Collections.Specialized;

namespace UIAtomsDemo.Controls
{

    public class MenuList : ListView {

        public MenuList()
        {

            this.ItemSelected += MenuList_ItemSelected;


            var menuService = DependencyService.Get<MenuService>();

            this.SetBinding(MenuItemsProperty, new Binding("Menus") { Source = menuService });
        }

        private void MenuList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            Services.MenuItem mi = e.SelectedItem as Services.MenuItem;
            mi?.Click();
            SelectedItem = null;
        }


        #region Property MenuItems

        /// <summary>
        /// Bindable Property MenuItems
        /// </summary>
        public static readonly BindableProperty MenuItemsProperty = BindableProperty.Create(
          "MenuItems",
          typeof(IEnumerable<Services.MenuItem>),
          typeof(MenuList),
          null,
          BindingMode.OneWay,
          // validate value delegate
          // (sender,value) => true
          null,
          // property changed, delegate
          (sender,oldValue,newValue) => ((MenuList)sender).OnMenuItemsChanged(oldValue,newValue),
          
          // property changing delegate
          // (sender,oldValue,newValue) => {}
          null,
          // coerce value delegate 
          // (sender,value) => value
          null,
          // create default value delegate
          // () => Default(T)
          null
        );

        
        /// <summary>
        /// On MenuItems changed
        /// </summary>
        /// <param name="oldValue">Old Value</param>
        /// <param name="newValue">New Value</param>
        protected virtual void OnMenuItemsChanged(object oldValue, object newValue)
        {
            INotifyCollectionChanged ince = oldValue as INotifyCollectionChanged;
            if (ince != null) {
                ince.CollectionChanged -= Ince_CollectionChanged;
            }
            ince = newValue as INotifyCollectionChanged;
            if (ince != null) {
                ince.CollectionChanged += Ince_CollectionChanged;
            }

            Ince_CollectionChanged(null, null);
        }


        long collectionChangedLock = 0;
        private void Ince_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (MenuItems != null)
            {
                UIAtomsApplication.Instance.Trigger(ref collectionChangedLock, UpdateCollection);
            }
        }

        private void UpdateCollection() {
            var cats = MenuItems.GroupBy(x => x.Category).ToList();
            if (cats.Count() == 1)
            {
                if (string.IsNullOrWhiteSpace(cats.First().Key))
                {
                    this.IsGroupingEnabled = false;
                    this.ItemsSource = MenuItems;
                    return;
                }
            }
            this.IsGroupingEnabled = true;
            this.GroupDisplayBinding = new Binding("Key");
            this.ItemsSource = cats;
        }


        /// <summary>
        /// Property MenuItems
        /// </summary>
        public IEnumerable<Services.MenuItem> MenuItems
        {
            get
            {
                return (IEnumerable<Services.MenuItem>)GetValue(MenuItemsProperty);
            }
            set
            {
                SetValue(MenuItemsProperty, value);
            }
        }
        #endregion



    }

}