using NeuroSpeech.UIAtoms;
using NeuroSpeech.UIAtoms.DI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo;

namespace ConfirmButton.ViewModels
{
    public class ConfirmButtonPageViewModel : BaseViewModel
    {

        public ConfirmButtonPageViewModel()
        {
            this.DeleteCommand = new AtomCommand(async () => await OnDeleteCommandAsync());
        }

        public AtomCommand DeleteCommand { get; private set; }

        private Task OnDeleteCommandAsync()
        {
            return Get<INotificationService>().NotifyAsync("Deleted successfully");
        }
    }
}

