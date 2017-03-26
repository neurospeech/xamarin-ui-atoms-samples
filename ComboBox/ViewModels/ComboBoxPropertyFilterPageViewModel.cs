using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using UIAtomsDemo;
using UIAtomsDemo.RestServices.Models;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices;

namespace ComboBox.ViewModels
{
    public class ComboBoxPropertyFilterPageViewModel: BaseViewModel
    {

        public AtomList<Person> PersonList { get; }
            = new AtomList<Person>();

        public override async Task InitAsync()
        {
            var list = await Get<ConfigService>().GetPersonListAsync();
            PersonList.Replace(list);
        }

    }
}
