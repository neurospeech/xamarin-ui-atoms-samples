using NeuroSpeech.UIAtoms.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIAtomsDemo.Services;
using UIAtomsDemo.Views;
using Xamarin.Forms;

namespace UIAtomsDemo
{
    public class RootPage: MasterDetailPage
    {

        public RootPage()
        {
            var appNavigator = DependencyService.Get<IAppNavigator>();
            Master = appNavigator.NewPage<MenuPage>();

            var menuService = DependencyService.Get<MenuService>();

            Detail = menuService.Menus.First().Page;

            menuService.MenuClicked += MenuService_MenuClicked;

            
        }

        private void MenuService_MenuClicked(object sender, EventArgs e)
        {
            if (Device.Idiom != TargetIdiom.Tablet)
            {
                IsPresented = false;
            }
        }
    }
}
