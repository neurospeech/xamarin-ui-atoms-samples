using NeuroSpeech.UIAtoms;
using NeuroSpeech.UIAtoms.DI;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using UIAtomsDemo.Services;
using Xamarin.Forms;
using System.Collections.Specialized;

[assembly: Dependency(typeof(MenuService))]

namespace UIAtomsDemo.Services
{
    public class MenuService : AtomModel
    {

        private AtomList<MenuItem> _menus = new AtomList<MenuItem>();

        public IEnumerable<MenuItem> Menus {
            get {
                return _menus;
            }
        }

        
        public MenuItem Add(string label, Action action, string category = null, string description = null, string icon = null)
        {
            MenuItem mi = new MenuItem
            {
                Label = label,
                Category = category,
                Description = description,
                Icon = icon == null ? FileImageSource.FromFile(icon) : null,
                Action = action 
            };
            _menus.Add(mi);            
            return mi;
        }

        public MenuItem Add<T>(string label, string category = null, string description = null, string icon = null) {
            MenuItem mi = new MenuItem {
                Label = label,
                Category = category,
                Description = description,
                Icon = icon ==null ? FileImageSource.FromFile(icon): null,
                PageType = typeof(T)
            };

            mi.Action = () => {
                MasterDetailPage mdp = App.Current.MainPage as MasterDetailPage;
                if (mdp != null)
                {
                    mdp.Detail = mi.Page;
                }
                else {
                    App.Current.MainPage = mi.Page;
                }

                Page np = mi.Page; 
                if (np is NavigationPage) {
                    np = ((NavigationPage)np).CurrentPage;
                }

                AtomViewModel avm = np.BindingContext as AtomViewModel;
                Device.BeginInvokeOnMainThread(async () =>
                {
                    try
                    {
                        await avm.InitAsync();
                    }
                    catch (Exception ex) {
                        System.Diagnostics.Debug.WriteLine(ex);
                    }
                });

            };
            _menus.Add(mi);
            return mi;
        }

        public bool Remove(MenuItem menu) {
            bool b = _menus.Remove(menu);
            return b;
        }

    }


    public class MenuItem  : AtomModel {

        #region Property Category

        private string _Category = null;

        public string Category
        {
            get
            {
                return _Category;
            }
            set
            {
                SetProperty(ref _Category, value);
            }
        }
        #endregion

        #region Property SortOrder

        private int _SortOrder = 0;

        public int SortOrder
        {
            get
            {
                return _SortOrder;
            }
            set
            {
                SetProperty(ref _SortOrder, value);
            }
        }
        #endregion

        #region Property Label

        private string _Label = null;

        public string Label
        {
            get
            {
                return _Label;
            }
            set
            {
                SetProperty(ref _Label, value);
            }
        }
        #endregion

        #region Property PageType

        private Type _PageType = null;

        public Type PageType
        {
            get
            {
                return _PageType;
            }
            set
            {
                SetProperty(ref _PageType, value);
            }
        }
        #endregion

        #region Property Action

        private Action _Action = null;

        public Action Action
        {
            get
            {
                return _Action;
            }
            set
            {
                SetProperty(ref _Action, value);
            }
        }
        #endregion

        #region Property Icon

        private ImageSource _Icon = null;

        public ImageSource Icon
        {
            get
            {
                return _Icon;
            }
            set
            {
                SetProperty(ref _Icon, value);
            }
        }
        #endregion

        #region Property Description

        private string _Description = null;

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                SetProperty(ref _Description, value);
            }
        }
        #endregion

        private Page _page;
        public Page Page {
            get {

                if (_page == null && _PageType!=null) {
                    var navService = DependencyService.Get<IAppNavigator>();
                    _page = new NavigationPage(navService.NewPage(PageType));
                }
                return _page;
            }
        }

    }



}
