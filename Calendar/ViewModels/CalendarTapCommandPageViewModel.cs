using NeuroSpeech.UIAtoms;
using NeuroSpeech.UIAtoms.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UIAtomsDemo;

namespace Calendar.ViewModels
{
    public class CalendarTapCommandPageViewModel: AtomViewModel
    {

        public CalendarTapCommandPageViewModel()
        {
            TapCommand = new AtomCommand<AtomDateModel>(async (m) => await OnTapCommandAsync(m));
        }

        private async Task OnTapCommandAsync(AtomDateModel m)
        {
            await App.Current.MainPage.DisplayAlert("Date", $"Selected: {m.Value}", "Ok");
        }

        public ICommand TapCommand { get; private set; }
    }
}
