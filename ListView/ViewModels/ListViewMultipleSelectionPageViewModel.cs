using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices;
using UIAtomsDemo.RestServices.Models;

namespace ListView.ViewModels
{
    public class ListViewMultipleSelectionPageViewModel : AtomViewModel
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



        #region Property SelectedVideos

        private System.Collections.IEnumerable _SelectedVideos = null;

        public System.Collections.IEnumerable SelectedVideos
        {
            get
            {
                return _SelectedVideos;
            }
            set
            {
                SetProperty(ref _SelectedVideos, value);
            }
        }
        #endregion


    }
}
