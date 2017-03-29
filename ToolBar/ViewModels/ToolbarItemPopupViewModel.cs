using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ToolBar.ViewModels
{
    public class ToolbarItemPopupViewModel: AtomViewModel
    {

        public ToolbarItemPopupViewModel()
        {
            this.SearchCommand = new AtomCommand(() => {
                return Task.CompletedTask;
            });
        }

        public AtomCommand SearchCommand { get; private set; }
    }
}
