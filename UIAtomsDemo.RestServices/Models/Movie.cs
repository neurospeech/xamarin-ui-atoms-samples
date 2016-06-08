using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIAtomsDemo.RestServices.Models
{
    public class Movie: AtomModel
    {

        #region Property Title

        private string _Title = null;

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                SetProperty(ref _Title, value);
            }
        }
        #endregion

        #region Property Category

        private string _Category = null;

        public string Category
        {
            get
            {
                return _Category;
            }
            set
            {
                SetProperty(ref _Category, value);
            }
        }
        #endregion

        

    }
}
