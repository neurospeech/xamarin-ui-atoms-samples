using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToolBar.ViewModels
{
    public class ToolbarItemVisibilityViewModel: AtomViewModel
    {

        public AtomCommand OptionCommand { get; private set; }

        public ToolbarItemVisibilityViewModel()
        {
            this.OptionCommand = new AtomCommand(async ()=> await OnOptionCommand());
        }

        private async Task OnOptionCommand()
        {
            await Application.Current.MainPage.DisplayAlert("Option", "Option clicked", "OK");
        }



        #region Property ShowOption

        private bool _ShowOption = false;

        public bool ShowOption
        {
            get
            {
                return _ShowOption;
            }
            set
            {
                SetProperty(ref _ShowOption, value);
            }
        }

        #endregion



    }
}
