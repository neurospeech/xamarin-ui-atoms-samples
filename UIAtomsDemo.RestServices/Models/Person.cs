using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIAtomsDemo.RestServices.Models
{
    public class Person: AtomModel
    {

        #region Property FirstName

        private string _FirstName = null;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                SetProperty(ref _FirstName, value);
            }
        }
        #endregion

        #region Property LastName

        private string _LastName = null;

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                SetProperty(ref _LastName, value);
            }
        }
        #endregion

        #region Property Company

        private string _Company = null;

        public string Company
        {
            get
            {
                return _Company;
            }
            set
            {
                SetProperty(ref _Company, value);
            }
        }
        #endregion

        public string Name => $"{FirstName} {LastName}";

    }
}
