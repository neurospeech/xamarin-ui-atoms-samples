using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToggleButtonBar.ViewModels
{
    public class ToggleButtonBarPageViewModel: AtomViewModel
    {
        public ToggleButtonBarPageViewModel()
        {
            this.Colors = new AtomData<string>[]{
                new AtomData<string>("Red","Red"),
                new AtomData<string>("Green","Green"),
                new AtomData<string>("Blue","Blue")
            };
        }

        public AtomData<string>[] Colors { get; private set; }







        #region Property SelectedColor

        private AtomData<string> _SelectedColor = null;

        public AtomData<string> SelectedColor
        {
            get
            {
                return _SelectedColor;
            }
            set
            {
                SetProperty(ref _SelectedColor, value);
            }
        }
        #endregion






    }
}
