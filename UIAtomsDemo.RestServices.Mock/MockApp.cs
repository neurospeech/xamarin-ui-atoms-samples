using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UIAtomsDemo.RestServices.Mock
{
    public class MockApp
    {

        public static void Init() {
            DependencyService.Register<ConfigService, MockConfigService>();
            DependencyService.Register<YouTubeService, MockYouTubeService>();
        }

    }
}
