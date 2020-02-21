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
    /// Interaction logic for PrikazManifestacija.xaml
    /// </summary>
    public partial class PrikazManifestacija : Window, INotifyPropertyChanged
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
        public ObservableCollection<Strukture.StrukturaManifestacija> Manifestacije
        {
            get;
            set;
        }



        public PrikazManifestacija()
        {
            InitializeComponent();
            this.DataContext = this;

            comboTipoviFiltracija.ItemsSource = ((MainWindow)System.Windows.Application.Current.MainWindow).tipovi;

            Manifestacije = new ObservableCollection<Strukture.StrukturaManifestacija>(((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije);
            View = CollectionViewSource.GetDefaultView(Manifestacije);
            View.Refresh();
            View.Filter = null;
        }

        private void IzbrisiManifestaciju_Click(object sender, RoutedEventArgs e)
        {
            StrukturaManifestacija manifestacija1 = (StrukturaManifestacija)dataGridManifestacije.SelectedItem;
            if (manifestacija1 != null)
            {
                
                Brisanje pom = new Brisanje();
                pom.ShowDialog();
                if (pom.Brisi)
                {

                    dataGridManifestacije.ItemsSource = null;

                    ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije.Remove(manifestacija1);

                    Manifestacije = new ObservableCollection<StrukturaManifestacija>(((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije);
                    View = CollectionViewSource.GetDefaultView(Manifestacije);
                    dataGridManifestacije.ItemsSource = Manifestacije;
                }
            }

        }

        private void Zatvori_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tipoviZaFiltraciju_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboTipoviFiltracija.SelectedItem != null)
            {
                View.Filter += (x => ((StrukturaManifestacija)x).Tipp.IDD.Equals(((StrukturaTip)comboTipoviFiltracija.SelectedItem).IDD));
            } 
        }

        private void Izmjeni_Click(object sender, RoutedEventArgs e)
        {

           
            StrukturaManifestacija man = (StrukturaManifestacija)dataGridManifestacije.SelectedItem;
            if (man != null)

            {
                bool sadrzi = false;

                for (int j = 0; j < SveStrukture.Instance.ManifestacijeLista.Count; j++)
                {
                    if (SveStrukture.Instance.ManifestacijeLista[j].IDManifestacija.Equals(man.IDManifestacija))
                    {
                        sadrzi = true;
                        break;
                    }
                }


                if (sadrzi)
                {
                    IzmjenaManif im = new IzmjenaManif(man);
                    im.ShowDialog();

                    dataGridManifestacije.ItemsSource = null;
                    Manifestacije = new ObservableCollection<StrukturaManifestacija>(((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije);

                    View = CollectionViewSource.GetDefaultView(Manifestacije);
                    dataGridManifestacije.ItemsSource = Manifestacije;
                } else
                {
                    Greska err = new Greska("Ne možete mijenjati manifestacije koje su već dodate na mapu. Uklonite manifestaciju sa mape ukoliko želite da je mijenjate");
                    err.Show();
                }
            }
        }


        private void dataGridManifestacije_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            gridElipse.Children.Clear();
            etiketePrikaz.Text = "";
            if (dataGridManifestacije.SelectedItem != null)
            {
                StrukturaManifestacija manif = (StrukturaManifestacija)dataGridManifestacije.SelectedItem;
                etiketePrikaz.Text = "";
                String upis = "";
                for (int j = 0; j < manif.etiketaManifestacije.Count; j++)
                {
                    upis += manif.etiketaManifestacije[j].IDEtiketa + " ";
                    if (j != manif.etiketaManifestacije.Count - 1)
                    {
                        upis += ",";
                    }
                }
                etiketePrikaz.Text = upis;

                ListView lv = new ListView();
                StackPanel sp = new StackPanel();
              
                sp.Orientation = Orientation.Horizontal;
                ObservableCollection<Ellipse> listaElipsa = new ObservableCollection<Ellipse>();
                for (int i = 0; i < manif.EtiketaM.Count; i++)
                {
                    Ellipse elipsa = new Ellipse();
                    elipsa.Height = 20;
                    elipsa.Width = 20;
                    elipsa.Fill = manif.EtiketaM[i].ColorBrush;
                    // tt.Content = elipsa;
                    
                    sp.Children.Add(elipsa);
                   
                }
                

              
                
                gridElipse.Children.Add(sp);

            }
        }

        private void Vrati_Click(object sender, RoutedEventArgs e)
        {
            View.Refresh();
            View.Filter = null;
            comboTipoviFiltracija.SelectedItem = null;
        }

        
            private void pronadji_Click(object sender, RoutedEventArgs e)
            {
                View.Filter += (x => ((StrukturaManifestacija)x).IDManifestacija.Equals(pretraga.Text));
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pretrage p = new Pretrage();
            p.Show();
        }
    }



}
