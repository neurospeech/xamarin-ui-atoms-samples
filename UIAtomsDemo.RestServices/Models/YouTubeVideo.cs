using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIAtomsDemo.RestServices.Models
{
    public class YouTubeVideo : AtomModel
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

        #region Property ID

        private string _ID = null;

        public string ID
        {
            get
            {
                return _ID;
            }
            set
            {
                SetProperty(ref _ID, value);
            }
        }
        #endregion

        #region Property Thumbnail

        private string _Thumbnail = null;

        public string Thumbnail
        {
            get
            {
                return _Thumbnail;
            }
            set
            {
                SetProperty(ref _Thumbnail, value);
            }
        }
        #endregion

        #region Property Category

        private string _Category = "General";

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

        #region Property Views

        private long _Views = 0;

        public long Views
        {
            get
            {
                return _Views;
            }
            set
            {
                SetProperty(ref _Views, value);
            }
        }
        #endregion

        #region Property UpVotes

        private long _UpVotes = 0;

        public long UpVotes
        {
            get
            {
                return _UpVotes;
            }
            set
            {
                SetProperty(ref _UpVotes, value);
            }
        }
        #endregion

        #region Property DownVotes

        private long _DownVotes = 0;

        public long DownVotes
        {
            get
            {
                return _DownVotes;
            }
            set
            {
                SetProperty(ref _DownVotes, value);
            }
        }
        #endregion


        public YouTubeVideo(string category, string id, string title, long views, long upVotes, long downVotes)
        {
            this._Category = category;
            this._ID = id;
            this._Title = title;
            this._Views = views;
            this._UpVotes = upVotes;
            this._DownVotes = downVotes;
            this._Thumbnail = $"https://img.youtube.com/vi/{id}/0.jpg";
        }

    }
}
