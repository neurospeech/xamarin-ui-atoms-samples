using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using UIAtomsDemo.RestServices.Models;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices;
using UIAtomsDemo;
using System.Linq;

namespace Chooser.ViewModels
{
    public class ChooserMultipleSelectionPageViewModel: AtomViewModel
    {



        public AtomList<YouTubeVideo> Videos { get; } 
            = new AtomList<YouTubeVideo>();

        public ChooserMultipleSelectionPageViewModel()
        {
            this.TapCommand = new AtomCommand<IEnumerable<YouTubeVideo>>(async items => await OnTapCommandAsync(items));
        }

        private async Task OnTapCommandAsync(IEnumerable<YouTubeVideo> items)
        {
            string labels = string.Join(",\r\n", items.Select(x => x.Title));
            await App.Current.MainPage.DisplayAlert("Selected", labels, "OK");
        }

        public override async Task InitAsync()
        {
            var service = Get<YouTubeService>();

            // this replaces existing items with new items
            // unlike Clear and AddRange, this method does not cause full list refresh
            this.Videos.Replace(await service.GetVideos());
        }

        




        #region Property SelectedVideoIDs

        private string _SelectedVideoIDs = null;

        public string SelectedVideoIDs
        {
            get
            {
                return _SelectedVideoIDs;
            }
            set
            {
                SetProperty(ref _SelectedVideoIDs, value);
            }
        }

        public AtomCommand<IEnumerable<YouTubeVideo>> TapCommand { get; private set; }
        #endregion




    }
}
