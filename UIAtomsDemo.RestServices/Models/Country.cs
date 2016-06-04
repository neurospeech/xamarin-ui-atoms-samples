using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIAtomsDemo.RestServices.Models
{
    public class Country : AtomModel
    {

        #region Property CountryCode

        private string _CountryCode = null;

        public string CountryCode
        {
            get
            {
                return _CountryCode;
            }
            set
            {
                SetProperty(ref _CountryCode, value);
            }
        }
        #endregion

        #region Property CountryName

        private string _CountryName = null;

        public string CountryName
        {
            get
            {
                return _CountryName;
            }
            set
            {
                SetProperty(ref _CountryName, value);
            }
        }
        #endregion



    }
}
