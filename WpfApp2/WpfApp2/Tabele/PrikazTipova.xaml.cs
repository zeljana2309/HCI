using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Shapes;
using WpfApp2.Strukture;
using WpfApp2.Upozorenja;

namespace WpfApp2.Tabele
{
    /// <summary>
    /// Interaction logic for PrikazTipova.xaml
    /// </summary>
    public partial class PrikazTipova : Window, INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }

        }

        private ICollectionView _View;
        public ICollectionView View
        {
            get
            {
                return _View;
            }
            set
            {
                _View = value;
                OnPropertyChanged("View");
            }
        }

        //kolekcija koja prati promjene 
        public ObservableCollection<Strukture.StrukturaTip> Tipovi
        {
            get;
            set;
        }


       
        public PrikazTipova()
        {
            InitializeComponent();
            this.DataContext = this;

            Tipovi = new ObservableCollection<Strukture.StrukturaTip>(((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi);
            View = CollectionViewSource.GetDefaultView(Tipovi);
        }

        private void IzbrisiKlik(object sender, RoutedEventArgs e)
        {
            StrukturaTip tip1 = (StrukturaTip)dataGridTipovi.SelectedItem;

            if (tip1 != null)
            {

                Brisanje brisanje = new Brisanje();
                brisanje.ShowDialog();
                if (brisanje.Brisi)
                {
                    ObservableCollection<StrukturaManifestacija> pom = ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije;
                    for (int i = 0; i < pom.Count(); i++)
                    {
                        StrukturaManifestacija m = pom[i];
                        if (m.Tipp == tip1)
                        {
                            pom.Remove(m);
                            ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije.Remove(m);
                            i--;
                        }
                    }

                    dataGridTipovi.ItemsSource = null;

                    ((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi.Remove(tip1);

                    Tipovi = new ObservableCollection<StrukturaTip>(((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi);
                    View = CollectionViewSource.GetDefaultView(Tipovi);
                    dataGridTipovi.ItemsSource = Tipovi;

                }
            }
        }

        private void Izmjeni_Click(object sender, RoutedEventArgs e)
        {
            StrukturaTip tip = (StrukturaTip)dataGridTipovi.SelectedItem;
            if (tip != null)
            {
                IzmjenaTipa it = new IzmjenaTipa(tip);
                it.ShowDialog();

                dataGridTipovi.ItemsSource = null;
                Tipovi = new ObservableCollection<StrukturaTip>(((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi);

                View = CollectionViewSource.GetDefaultView(Tipovi);
                dataGridTipovi.ItemsSource = Tipovi;
            }
        }

        private void Zatvori_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
