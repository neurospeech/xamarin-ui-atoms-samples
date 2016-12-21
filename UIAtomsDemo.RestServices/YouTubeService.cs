using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo.RestServices;
using UIAtomsDemo.RestServices.Models;

[assembly: Xamarin.Forms.Dependency(typeof(YouTubeService))]

namespace UIAtomsDemo.RestServices
{
    public class YouTubeService : BaseService
    {

        public virtual async Task<IEnumerable<YouTubeVideo>> GetVideos() {
            throw new NotImplementedException();
        }

    }
}
