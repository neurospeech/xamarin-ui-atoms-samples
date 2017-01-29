using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolBar.ViewModels
{
    public class ToolbarItemPopupViewModel: AtomViewModel
    {

        public ToolbarItemPopupViewModel()
        {
            this.SearchCommand = new AtomCommand(() => { });
        }

        public AtomCommand SearchCommand { get; private set; }
    }
}
