using NeuroSpeech.UIAtoms;
using NeuroSpeech.UIAtoms.DI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo;

namespace Form.ViewModels
{
    public class SimpleValidationViewModel : BaseViewModel
    {

        public SimpleValidationViewModel()
        {
            this.SubmitCommand = new AtomCommand(async () => await OnSubmitCommandAsync());
        }

        private async Task OnSubmitCommandAsync()
        {
            await Task.Delay(100);
            Get<INotificationService>().Notify("Submitted");
        }

        public AtomCommand SubmitCommand { get; private set; }
    }
}
