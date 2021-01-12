using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace TDNote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

       
    public partial class MainWindow : Window
    {
        private Album _album;
        public MainWindow()
        {
            InitializeComponent();

            _album = new Album();
            _album.NomAlbum = "QALF";
            _album.NomArtiste = "Damso";

            DataContext = _album;
        }
    }

    public class Album : Observable
    {
        private String _nomAlbum;
        public string NomAlbum
        {
            get { return _nomAlbum; }
            set
            {
                _nomAlbum = value;
                OnPropertyChanged(nameof(NomAlbum));

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

            }
        }
    }

    public class Observable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
