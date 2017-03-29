using NeuroSpeech.UIAtoms.Controls;
using NeuroSpeech.UIAtoms.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FormValidations
{

    /// <summary>
    /// 
    /// </summary>
    public class CustomDateValidationRule : AtomValidationRule
    {

        /// <summary>
        /// Returns null if validation was successful or returns error if date was empty
        /// </summary>
        /// <param name="view"></param>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override AtomValidationError Validate(View view, BindableProperty property, object value)
        {
            AtomDatePicker datePicker = view as AtomDatePicker;
            if (!datePicker.Value.HasValue || datePicker.Value.Value == DateTime.MinValue) {
                return new AtomValidationError {
                    Source = datePicker,
                    Property = AtomDatePicker.ValueProperty,
                    Message = AtomForm.GetInvalidValueMessage(datePicker)
                };
            }
            return null;
        }
    }
}
