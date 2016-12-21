using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatePicker.ViewModels
{
    public class DatePickerPageViewModel: AtomViewModel
    {



        #region Property SelectedDate

        private DateTime? _SelectedDate = null;

        public DateTime? SelectedDate
        {
            get
            {
                return _SelectedDate;
            }
            set
            {
                SetProperty(ref _SelectedDate, value);
            }
        }
        #endregion



    }
}
