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
    /// Interaction logic for PrikazEtiketa.xaml
    /// </summary>
    public partial class PrikazEtiketa : Window, INotifyPropertyChanged
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
        public ObservableCollection<Strukture.StrukturaEtiketa> Etikete
        {
            get;
            set;
        }

        public PrikazEtiketa()
        {
            InitializeComponent();
            this.DataContext = this;

            Etikete = new ObservableCollection<Strukture.StrukturaEtiketa>(((MainWindow)System.Windows.Application.Current.MainWindow).Etikete);
            View = CollectionViewSource.GetDefaultView(Etikete);
        }

        private void ZatvoriKlik(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ObrisiKlik(object sender, RoutedEventArgs e)
        {

            Brisanje brisanje= new Brisanje();
            brisanje.ShowDialog();
            if (brisanje.Brisi)
            {
                StrukturaEtiketa et = (StrukturaEtiketa)dataGridEtiketa.SelectedItem;
                ObservableCollection<StrukturaManifestacija> mmLista= ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije;
                if (et != null)
                {
                    dataGridEtiketa.ItemsSource = null;

                    for(int i=0;i<mmLista.Count();i++)
                    {
                        for(int j=0;j<mmLista[i].EtiketaM.Count();j++)
                        {
                            if(mmLista[i].EtiketaM[j].IDEtiketa.Equals(et.IDEtiketa))
                            {
                                mmLista[i].EtiketaM.Remove(et);
                                break;
                            }
                        }
                    }

                    ((MainWindow)System.Windows.Application.Current.MainWindow).Etikete.Remove(et);

                    Etikete = new ObservableCollection<StrukturaEtiketa>(((MainWindow)System.Windows.Application.Current.MainWindow).Etikete);
                    View = CollectionViewSource.GetDefaultView(Etikete);
                    dataGridEtiketa.ItemsSource = Etikete;

                }
            }
        }

        private void IzmjeniKlik(object sender, RoutedEventArgs e)
        {
            StrukturaEtiketa etiketa = (StrukturaEtiketa)dataGridEtiketa.SelectedItem;
            if(etiketa!=null)
            {
                IzmjenaEtikete et = new IzmjenaEtikete(etiketa);
                et.ShowDialog();

                dataGridEtiketa.ItemsSource = null;
                Etikete = new ObservableCollection<StrukturaEtiketa>(((MainWindow)System.Windows.Application.Current.MainWindow).Etikete);

                View = CollectionViewSource.GetDefaultView(Etikete);
                dataGridEtiketa.ItemsSource = Etikete;
            }

        }
    }
}
