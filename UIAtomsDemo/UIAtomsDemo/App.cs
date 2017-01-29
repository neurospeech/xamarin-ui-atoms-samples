using Calendar.Views;
using Chooser.Views;
using ComboBox.Views;
using ConfirmButton.Views;
using DatePicker.Views;
using Form;
using Form.Views;
using GridView.Views;
using Image.Views;
using ImageCropper.Views;
using ListView.Views;
using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToggleButtonBar.Views;
using ToolBar.Views;
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

            //menuService.Add<ListViewPage>("ListView", "ListView");
            menuService.Add<ListViewMultipleSelectionPage>("ListView - Multiple Selection", "ListView");
            menuService.Add<GridViewPage>("GridView", "ListView");
            //menuService.Add<ChooserMultipleSelectionPage>("Chooser - Multiple Selection", "Chooser");


            menuService.Add<ChooserPage>("Chooser", "Chooser");
            menuService.Add<ChooserItemTemplatePage>("Chooser - ItemTemplate", "Chooser");
            menuService.Add<ChooserMultipleSelectionPage>("Chooser - Multiple Selection", "Chooser");

            //menuService.Add<SimpleComboBoxPage>("Simple ComboBox", "ComboBox");
            //menuService.Add<ComboBoxPropertyFilterPage>("Property Filter", "ComboBox");

            menuService.Add<ImageFromWeb>("Image from Web", "Image");
            menuService.Add<ImageFromRes>("Image from Assembly Resource", "Image");
            menuService.Add<ImageFromAppRes>("Image from Application Resource", "Image");
            menuService.Add<ImageCropperPage>("Image Cropper", "Image");
            menuService.Add<ImageFromWeb>("Image from Web", "Image");

            menuService.Add<ToolbarItemVisibility>("Toolbar Visibility", "Toolbar");
            menuService.Add<ToolbarItemPopup>("Toolbar Popup", "Toolbar");

            menuService.Add<CalendarPage>("Calendar - SelectedDate", "Calendar");
            menuService.Add<CalendarTapCommandPage>("Calendar - TapCommand", "Calendar");
            menuService.Add<CalendarItemTemplatePage>("Calendar - ItemTemplate", "Calendar");

            menuService.Add<ToggleButtonBarPage>("Toggle Button Bar","Toggle Button Bar");

            menuService.Add<DatePickerPage>("Date Picker", "Date Picker");


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
