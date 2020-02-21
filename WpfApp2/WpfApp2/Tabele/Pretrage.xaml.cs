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

namespace WpfApp2.Tabele
{
    /// <summary>
    /// Interaction logic for Pretrage.xaml
    /// </summary>
    public partial class Pretrage : Window, INotifyPropertyChanged
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
    
        public Pretrage()
        {

            InitializeComponent();
            this.DataContext = this;
            Manifestacije = new ObservableCollection<Strukture.StrukturaManifestacija>(((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije);
            View = CollectionViewSource.GetDefaultView(Manifestacije);
            View.Refresh();
            View.Filter = null;
           

            comboFilter.Items.Add("Svi atributi");
            comboFilter.Items.Add("ID");
            comboFilter.Items.Add("Ime");
            comboFilter.Items.Add("Tip");
            comboFilter.Items.Add("Dostupno za hendikepirane");
            comboFilter.Items.Add("Mjesto odrzavanja");
            comboFilter.Items.Add("Pusenje");
            comboFilter.Items.Add("Kategorija cijena");
            comboFilter.Items.Add("Alkohol");
            comboFilter.Items.Add("Opis manifestacije");
            comboFilter.Items.Add("Etikete");

           // Manifestacije = new ObservableCollection<Strukture.StrukturaManifestacija>(((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije);
            tipMan.Items.Clear();

            for (int i = 0; i < ((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi.Count; i++)
            {
                tipMan.Items.Add(((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi[i]);
            }

            katCijene.Items.Add("Besplatno");
            katCijene.Items.Add("Niske cijene");
            katCijene.Items.Add("Srednje cijene");
            katCijene.Items.Add("Visoke cijene");

            alkCOmbo.Items.Add("Nema alkohola");
            alkCOmbo.Items.Add("Alkohol se može donijeti");
            alkCOmbo.Items.Add("alkohol se može kupiti na licu mesta");
            ObservableCollection<StrukturaEtiketa> sveEtikete = new ObservableCollection<StrukturaEtiketa>(((MainWindow)System.Windows.Application.Current.MainWindow).Etikete);
            etCombo.ItemsSource = sveEtikete;
            this.DataContext = this;

        }
    

        

        private void rbDostupnoNE_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void dataGridManifestacije_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void onemoguci()
        {
            tbID.IsEnabled = false;
            tbIme.IsEnabled = false;
            tipMan.IsEnabled = false;
            rbDostupnoDA.IsEnabled = false;
            rbDostupnoNE.IsEnabled = false;
            rbNapolju.IsEnabled = false;
            rbUnutra.IsEnabled = false;
            rbDozvoljeno.IsEnabled = false;
            rbZabranjeno.IsEnabled = false;
            rbDozvoljeno.IsChecked = false;
            katCijene.IsEnabled = false;
            alkCOmbo.IsEnabled = false;
            tbOpis.IsEnabled = false;
            etCombo.IsEnabled = false;
        }

        private void comboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (comboFilter.SelectedItem.Equals("Svi atributi"))
            {
                onemoguci();
                pretragaPoSvim.Visibility = Visibility.Visible;
            }
            else if (comboFilter.SelectedItem.Equals("ID"))
            {
                onemoguci();
                tbID.IsEnabled = true;
            }
            else if (comboFilter.SelectedItem.Equals("Ime"))
            {
                onemoguci();
                tbIme.IsEnabled = true;
            }
            else if (comboFilter.SelectedItem.Equals("Tip"))
            {
                onemoguci();
                tipMan.IsEnabled = true;
            }
            else if (comboFilter.SelectedItem.Equals("Dostupno za hendikepirane"))
            {
                onemoguci();
                rbDostupnoDA.IsEnabled = true;
                rbDostupnoNE.IsEnabled = true;
                rbDostupnoDA.IsChecked = true;
            }
            else if (comboFilter.SelectedItem.Equals("Mjesto odrzavanja"))
            {
                onemoguci();
                rbNapolju.IsEnabled = true;
                rbUnutra.IsEnabled = true;
                rbUnutra.IsChecked = true;
            }
            else if (comboFilter.SelectedItem.Equals("Pusenje"))
            {
                onemoguci();
                rbDozvoljeno.IsEnabled = true;
                rbZabranjeno.IsEnabled = true;
                rbDozvoljeno.IsChecked = true;
            }
            else if (comboFilter.SelectedItem.Equals("Kategorija cijena"))
            {
                onemoguci();
                katCijene.IsEnabled = true;
            }
            else if (comboFilter.SelectedItem.Equals("Alkohol"))
            {
                onemoguci();
                alkCOmbo.IsEnabled = true;
            }
            else if (comboFilter.SelectedItem.Equals("Opis manifestacije"))
            {
                onemoguci();
                tbOpis.IsEnabled = true;
            }
            else if (comboFilter.SelectedItem.Equals("Etikete"))
            {
                onemoguci();
                etCombo.IsEnabled = true;
            }


        }

        private void dugmePretrazi_Click(object sender, RoutedEventArgs e)
        {
            if (comboFilter.SelectedItem.Equals("Svi atributi"))
            {
                for (int i = 0; i < dataGridManifestacije.Items.Count; i++)
                {
                    DataGridRow row = (DataGridRow)dataGridManifestacije.ItemContainerGenerator.ContainerFromIndex(i);
                    row.Background = new SolidColorBrush(Colors.White);
                }
                string searchText = pretragaPoSvim.Text;
                bool selected = true;
                for (int i = 0; i < dataGridManifestacije.Items.Count; i++)
                {
                    StrukturaManifestacija sm = dataGridManifestacije.Items[i] as StrukturaManifestacija;
                    if (sm.IDManifestacija.ToUpper().Contains(searchText.ToUpper()) || sm.OpisManif.ToUpper().Contains(searchText.ToUpper()) ||
                        sm.ImeManifestacija.ToUpper().Contains(searchText.ToUpper()) || 
                    sm.Katcijena.ToUpper().Contains(searchText.ToUpper())  || sm.Alkoholl.ToUpper().Contains(searchText.ToUpper()) ||
                    sm.DatumManifest.ToString().Contains(searchText.ToUpper()) || sm.Tipp.IDD.ToUpper().Contains(searchText.ToUpper()) || sm.DozvoljenoPusenje.ToUpper().Contains(searchText.ToUpper())
                    || sm.OdrzavaSe.ToUpper().Contains(searchText.ToUpper()) )
                    {
                        DataGridRow row = (DataGridRow)dataGridManifestacije.ItemContainerGenerator.ContainerFromIndex(i);
                        row.Background = new SolidColorBrush(Colors.DarkSeaGreen);
                        if (selected)
                        {
                            dataGridManifestacije.SelectedItem = sm;
                            dataGridManifestacije.ScrollIntoView(sm);
                            row.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                            selected = false;
                        }
                    }

                }

            }

        
                
            
            else if (comboFilter.SelectedItem.Equals("ID"))
            {
                View.Filter += (x => ((StrukturaManifestacija)x).IDManifestacija.Contains(tbID.Text));
            }
            else if (comboFilter.SelectedItem.Equals("Ime"))
            {
                View.Filter += (x => ((StrukturaManifestacija)x).ImeManifestacija.Contains(tbIme.Text));
            }
            else if (comboFilter.SelectedItem.Equals("Tip"))
            {
                View.Filter += (x => ((StrukturaManifestacija)x).Tipp.IDD.Contains(((StrukturaTip)tipMan.SelectedItem).IDD));

            }
            else if (comboFilter.SelectedItem.Equals("Dostupno za hendikepirane"))
            {
                if (rbDostupnoDA.IsChecked == true)
                {
                    View.Filter += (x => ((StrukturaManifestacija)x).Dostupno.Equals("Da"));
                }
                else
                {
                    View.Filter += (x => ((StrukturaManifestacija)x).Dostupno.Equals("Ne"));
                }
            }
            else if (comboFilter.SelectedItem.Equals("Mjesto odrzavanja"))
            {
                if (rbNapolju.IsChecked == true)
                {
                    View.Filter += (x => ((StrukturaManifestacija)x).OdrzavaSe.Equals("Napolju"));
                }
                else
                {
                    View.Filter += (x => ((StrukturaManifestacija)x).OdrzavaSe.Equals("Unutra"));
                }
            }
            else if (comboFilter.SelectedItem.Equals("Pusenje"))
            {
                if (rbDozvoljeno.IsChecked == true)
                {
                    View.Filter += (x => ((StrukturaManifestacija)x).DozvoljenoPusenje.Equals("Dozvoljeno"));
                }
                else
                {
                    View.Filter += (x => ((StrukturaManifestacija)x).DozvoljenoPusenje.Equals("Zabranjeno"));
                }
            }
            else if (comboFilter.SelectedItem.Equals("Kategorija cijena"))
            {
                View.Filter += (x => ((StrukturaManifestacija)x).Katcijena.Equals(katCijene.SelectedItem));
            }
            else if (comboFilter.SelectedItem.Equals("Alkohol"))
            {
                View.Filter += (x => ((StrukturaManifestacija)x).Alkoholl.Equals(alkCOmbo.SelectedItem));
            }
            else if (comboFilter.SelectedItem.Equals("Opis manifestacije"))
            {
                View.Filter += (x => ((StrukturaManifestacija)x).OpisManif.Contains(tbOpis.Text));
            }
            else if (comboFilter.SelectedItem.Equals("Etikete"))
            {
                if (etCombo.Text.Equals("") == false)
                {
                      
                        View.Filter += (x => ((StrukturaManifestacija)x).EtiketaM.Contains(etCombo.SelectedItem));
                    }
                    
                   

           
                
            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!comboFilter.SelectedItem.Equals("Svi atributi")) { 
                View.Refresh();
                 View.Filter = null;
                //comboFilter.SelectedItem = null;
            } else{
                for (int i = 0; i < dataGridManifestacije.Items.Count; i++)
                {
                    DataGridRow row = (DataGridRow)dataGridManifestacije.ItemContainerGenerator.ContainerFromIndex(i);
                    row.Background = new SolidColorBrush(Colors.White);
                }
            }

        }
    }
}
