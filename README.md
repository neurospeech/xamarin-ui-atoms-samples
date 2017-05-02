# UI Atoms Samples for Xamarin.Forms

UI Atoms Samples repository contains samples of usage scenarios of all controls provided in UI Atoms for Xamarin.Forms.

# Getting Started

## Install NuGet package,

    Install-Package UIAtoms.Xamarin.Forms

## Initialize Config

    Device.BeginInvokeOnMainThread(async () =>
    {
        await UIAtomsApplication.Instance.InitAsync(new UIAtomsConfig{
			LicenseKey = ".........."
		});
    });

# Controls

1. [AtomForm](form/README.md)
    * Field grouping
    * Field search for large forms
    * Simple Validations
    * Custom Validations
    * [Third party control validations](FormValidations/README.md)
    * Templates

2. [AtomChooser](Chooser/README.md)
    * Multiple Value Selector
    * Key,Value pair 
    * ValuePath
    * Support for Popup view
    * Inbuilt search

4. [AtomGridView](GridView/README.md)
    * Grid view with header support

5. [AtomToggleButtonBar](ToggleButtonBar/README.md)
    * Simple horizontal toggle button bar

6. [AtomConfirmButton](ConfirmButton/README.md)
    * Confirm alert

7. [AtomImageCropper](ImageCropper/README.md)
    * Simple pinch and zoom image cropper (for both iOS and Android)

8. [AtomListView](ListView/README.md)
    * Multiple Item selector (check box selector)

9. [AtomCalendar](Calendar/README.md)

10. [AtomDatePicker](DatePicker/README.md)

11. [AtomImage](Image/README.md)
    * Ability to display progress while loading image
    * Ability to load images from embedded DLL resources via `app-res://` and `res://AssemblyName/ResourceName` format
12. [ToolBarItems](ToolBar/README.md)
    * AtomPopupToolbarItem
    * AtomToolbarItem


# Simple MVVM Support    

## AtomCommand
AtomCommand executes `Func<Task>` asynchronously, and it prevents multiple execution by waiting till previous task is executed.

## IAppNavigator interface
`IAppNavigator` interface serves as navigation service and provides allows you to create new page and push to stack. This service uses Dependency Injection to create appropriate model and initialize the model.

        await navigator.PushModalAsync<PageViewModel>(new {
            Property1 = value1,
            Property2 = value2
        });

Navigator service will detect current page and it will push page accordingly. You can either provide type of `PageViewModel` or `Page` as a generic argument. You can use `NewPage<T>` method to create page.

        Application.Current.MainPage = new NavigationPage(await navigator.NewPage<PageViewModel>(new {
            Property1 = value1,
            Property2 = value2
        }));

## AtomModel
`AtomModel` implements `INotifyPropertyChanged` and it provides `SetProperty<T>` method to easily create bindable models.

## AtomViewModel
`AtomViewModel` provides standard `ViewModel` with `OnAppearing`, `OnDisappearing` and `OnRemoved` methods, which helps you in receiving events on page appear/disappear. `OnRemoved` will be called only once page is removed from stack.

You can use `OnMessage<T>` in `ViewModel` constructor to subscribe for `MessagingCenter`. Subscription will be created after the page has appeared and it will be removed when page has disappeared. This will take care of memory leaks.

You can use `OnBackgroundMessage<T>` in `ViewModel` constructor to subscribe for `MessagingCenter` even when page is not visible. This subscription will be removed in `OnRemoved` method.

`AtomViewModel` provides handy `Get<T>` and `New<T>` as shortcuts for `DependencyService.Get` method.

## AtomListViewModel
`AtomListViewMdoel` is derived from `AtomViewModel` and it provides `Items` property along with `OnLoadItemsAsync` method which provies loading method to load items asynchronously from various sources. It also provies cancellation token. In addition, it provides `RefreshCommand`, `IsRefreshing` property etc.

# Licensing
These samples are provided under `MIT` license. However, you need to obtain license for `UI Atoms for Xamarin.Forms` from NeuroSpeech. 