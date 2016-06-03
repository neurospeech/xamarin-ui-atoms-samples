using NeuroSpeech.UIAtoms;
using NeuroSpeech.UIAtoms.DI;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UIAtomsDemo
{
    public class BaseViewModel : AtomViewModel
    {

        protected readonly IAppNavigator navigator;

        public BaseViewModel()
        {
            navigator = Get<IAppNavigator>();
        }

        protected T Get<T>()
            where T:class
        {
            return DependencyService.Get<T>();
        }


        protected T New<T>()
            where T : class
        {
            return DependencyService.Get<T>(DependencyFetchTarget.NewInstance);
        }
    }
}
