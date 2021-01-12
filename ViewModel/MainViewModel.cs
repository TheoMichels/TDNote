using System;
using System.Collections.Generic;
using System.Text;

namespace TDNote
{
    class MainViewModel : Observable
    {
        public MainViewModel()
        {

            _listAlbum = new PostViewModel[]
                {
                new PostViewModel() { NomAlbum="QALF", NomArtiste="Damso"},
                new PostViewModel() { NomAlbum="Trône", NomArtiste="Booba"},
                new PostViewModel() { NomAlbum="Or noir", NomArtiste="Kaaris"},
                };
            _selectedtAlbum = _listAlbum[0];
        }

        private readonly PostViewModel[] _listAlbum;
        public PostViewModel[] ListAlbum
        {
            get { return _listAlbum; }
        }
         
        private PostViewModel _selectedtAlbum;
        public PostViewModel SelectedtAlbum
        {
            get { return _selectedtAlbum; }
            set
            {
                _selectedtAlbum = value;
                OnPropertyChanged(nameof(SelectedtAlbum));
            }
        }
    }
}