using System;
using System.Collections.Generic;
using System.Text;


namespace TDNote
{
    class PostViewModel : Observable
    {

        public override string ToString()
        {
            return TitreListe;
        }

        private String _nomAlbum;
        public string NomAlbum
        {
            get { return _nomAlbum; }
            set
            {
                _nomAlbum = value;
                OnPropertyChanged(nameof(NomAlbum));
                OnPropertyChanged(nameof(TitreListe));
                OnPropertyChanged(nameof(TitreFenetre));
            }
        }

        private String _nomArtiste;
        public string NomArtiste
        {
            get { return _nomArtiste; }
            set
            {
                _nomArtiste = value;
                OnPropertyChanged(nameof(NomArtiste));
                OnPropertyChanged(nameof(TitreListe));
                OnPropertyChanged(nameof(TitreFenetre));
            }
        }

        //pour l'affichage des éléments de la liste
        public string TitreListe
        {
            get { return $"Album : {NomAlbum} \nArtiste : {NomArtiste}"; }
        }

        //pour l'affichage du titre de la fenêtre
        public string TitreFenetre
        {
            get { return $"{NomAlbum} - {NomArtiste}"; }
        }

    }
}
