using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices.Models;

namespace UIAtomsDemo.RestServices.Mock
{
    public class MockYouTubeService: YouTubeService
    {

        private static YouTubeVideo[] videos = new YouTubeVideo[] {
            new YouTubeVideo("Music","LY39km8rkWY","2CELLOS - \"Mombasa\" from INCEPTION [OFFICIAL VIDEO]",6476448,52367,439),
            new YouTubeVideo("Music","uT3SBzmDxGk","2CELLOS - Thunderstruck [OFFICIAL VIDEO]",71409643,697597,10903),
            new YouTubeVideo("Music","Mx0xCI1jaUM","2CELLOS - Smooth Criminal [OFFICIAL VIDEO]",22477180,197842,2156)
        };


        public override Task<IEnumerable<YouTubeVideo>> GetVideos()
        {
            return Task.FromResult<IEnumerable<YouTubeVideo>>(videos);
        }

    }
}
