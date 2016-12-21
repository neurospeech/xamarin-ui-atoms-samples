using NeuroSpeech.UIAtoms.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIAtomsDemo.Services;
using UIAtomsDemo.Views;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace UIAtomsDemo
{
    public class RootPage: MasterDetailPage
    {

        public RootPage()
        {

            Master = new ContentPage {
                Title = "Loading..."
            };

            Detail = new ContentPage {
                Content = new Label {
                    Text = "Loading..."
                }
            };

            var menuService = DependencyService.Get<MenuService>();

            menuService.MenuClicked += MenuService_MenuClicked;

            Device.BeginInvokeOnMainThread(async () => await LoadDefaultPage());

            
        }

        private async Task LoadDefaultPage()
        {
            var appNavigator = DependencyService.Get<IAppNavigator>();
            var menuService = DependencyService.Get<MenuService>();
            Master = await appNavigator.NewPage<MenuPage>();


            Detail = await menuService.Menus.First().GetPageAsync();

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
