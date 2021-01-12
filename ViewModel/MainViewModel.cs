using System;
using System.Collections.Generic;
using System.Text;

namespace TDNote
{
    class MainViewModel
    {
        public MainViewModel()
        {

            listAlbum = new PostViewModel[]
                {
                new PostViewModel() { NomAlbum="QALF", NomArtiste="Damso"},
                new PostViewModel() { NomAlbum="Trône", NomArtiste="Booba"},
                new PostViewModel() { NomAlbum="Or noir", NomArtiste="Kaaris"},
                };
        }

        private readonly PostViewModel[] listAlbum;
        public PostViewModel[] ListAlbum
        {
            get { return listAlbum; }
        }

    }
}
