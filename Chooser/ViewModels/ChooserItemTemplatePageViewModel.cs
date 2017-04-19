using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices;
using UIAtomsDemo.RestServices.Models;

namespace Chooser.ViewModels
{
    public class ChooserItemTemplatePageViewModel: AtomViewModel
    {

        public AtomList<YouTubeVideo> Videos { get; }
                    = new AtomList<YouTubeVideo>();

        public override async Task InitAsync()
        {
            var service = Get<YouTubeService>();

            // this replaces existing items with new items
            // unlike Clear and AddRange, this method does not cause full list refresh
            this.Videos.Replace(await service.GetVideos());
        }


        #region Property SelectedVideoID

        private string _SelectedVideoID = null;

        public string SelectedVideoID
        {
            get
            {
                return _SelectedVideoID;
            }
            set
            {
                SetProperty(ref _SelectedVideoID, value);
            }
        }
        #endregion
    }
}
