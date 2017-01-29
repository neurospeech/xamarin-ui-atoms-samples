using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices;
using UIAtomsDemo.RestServices.Models;

namespace ListView.ViewModels
{
    public class ListViewPageViewModel : AtomViewModel
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





        #region Property SelectedVideo

        private YouTubeVideo _SelectedVideo = null;

        public YouTubeVideo SelectedVideo
        {
            get
            {
                return _SelectedVideo;
            }
            set
            {
                SetProperty(ref _SelectedVideo, value);
            }
        }
        #endregion






    }
}
