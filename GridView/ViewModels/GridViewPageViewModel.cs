using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices;
using UIAtomsDemo.RestServices.Models;

namespace GridView.ViewModels
{
    public class GridViewPageViewModel : AtomViewModel
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

    }
}
