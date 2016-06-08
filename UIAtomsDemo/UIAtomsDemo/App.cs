using ComboBox.Views;
using ConfirmButton.Views;
using Form;
using Form.Views;
using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIAtomsDemo.RestServices.Mock;
using UIAtomsDemo.Services;
using UIAtomsDemo.Views;
using Xamarin.Forms;

namespace UIAtomsDemo
{
	public class App : Application
	{
		public App ()
        {
            // The root page of your application


            // setup mock...
            MockApp.Init();

            MainPage = new ContentPage
            {
                Content = new ActivityIndicator
                {
                    IsRunning = true,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                }
            };

            Device.BeginInvokeOnMainThread(async () =>
            {
                await UIAtomsApplication.Instance.InitAsync(new UIAtomsConfig());
                LoadMainPage();
            });

            
        }

        private void LoadMainPage()
        {

            var menuService = DependencyService.Get<MenuService>();

            menuService.Add<HomePage>("Home","Home");

            menuService.Add<SimpleFormPage>("Simple Form","Form");
            menuService.Add<SimpleValidationPage>("Simple Validation", "Form");

            menuService.Add<ConfirmButtonPage>("Confirm Button", "Button");

            menuService.Add<SimpleComboBoxPage>("Simple ComboBox", "ComboBox");
            menuService.Add<ComboBoxPropertyFilterPage>("Property Filter", "ComboBox");


            try
            {
                MainPage = new RootPage();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                MainPage = new ContentPage
                {
                    Content = new Editor
                    {
                        Text = ex.ToString()
                    }
                };
            }
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
