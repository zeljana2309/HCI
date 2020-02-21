using Microsoft.Win32;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class IzmjenaManif : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private string putanja=null;
        private bool odTipa;
        private string validString1;
        public ObservableCollection<StrukturaEtiketa> listaEtikete
        {
            get;
            set;
        }

        public IzmjenaManif(StrukturaManifestacija m)
        {
            InitializeComponent();
            this.DataContext = this;

            tbID.Text = m.IDManifestacija;
            tbIme.Text = m.ImeManifestacija;

            tipMan.Items.Clear();

            for (int i = 0; i < ((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi.Count; i++)
            {
                tipMan.Items.Add(((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi[i]);
            }

            tipMan.SelectedItem = m.Tipp;
            int gg = m.DatumManifest.Year;
            int mm = m.DatumManifest.Month;
            int dd = m.DatumManifest.Day;
            DateTime MDatum = new DateTime(gg, mm, dd);


            katCijene.Items.Add("Besplatno");
            katCijene.Items.Add("Niske cijene");
            katCijene.Items.Add("Srednje cijene");
            katCijene.Items.Add("Visoke cijene");

            alkCOmbo.Items.Add("Nema alkohola");
            alkCOmbo.Items.Add("Alkohol se može donijeti");
            alkCOmbo.Items.Add("alkohol se može kupiti na licu mesta");
            
            datummm.SelectedDate = MDatum;
            katCijene.Text = m.Katcijena;
            alkCOmbo.SelectedItem = m.Alkoholl;
            tbOpis.Text = m.OpisManif;
            image.Source = m.ikonicaManif;

            if (m.OdrzavaSe.Equals("Napolju"))
            {
                rbNapolju.IsChecked = true;
            }
            else rbUnutra.IsChecked = true;

            if (m.DozvoljenoPusenje.Equals("Dozvoljeno"))
            {
                rbDozvoljeno.IsChecked = true;
            }
            else rbZabranjeno.IsChecked = true;

            if (m.Dostupno.Equals("Da"))
            {
                rbDostupnoDA.IsChecked = true;
            }
            else rbDostupnoNE.IsChecked = true;


            ObservableCollection<StrukturaEtiketa> sveEtikete = new ObservableCollection<StrukturaEtiketa>(((MainWindow)System.Windows.Application.Current.MainWindow).Etikete);
            ObservableCollection<StrukturaEtiketa> oznacene = new ObservableCollection<StrukturaEtiketa>(m.EtiketaM);

            listaEtikete = new ObservableCollection<StrukturaEtiketa>(sveEtikete);


            for (int i = 0; i < oznacene.Count; i++)
            {
                CheckComboBox.SelectedItems.Add(oznacene[i]);
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            bool postojao = false;
            if (String.IsNullOrEmpty(tbID.Text) || String.IsNullOrWhiteSpace(tbID.Text))
            {
                Greska err = new Greska("Morate unijeti ID manifestacije da biste je dodali.");
                err.Show();
            }
            else if ((String.IsNullOrEmpty(tbIme.Text) || String.IsNullOrWhiteSpace(tbIme.Text)))
            {
                Greska err = new Greska("Morate unijeti ime manifestacije da biste je dodali.");
                err.Show();
            }
            else if (tipMan.SelectedItem == null)
            {
                Greska err = new Greska("Nije izabran tip manifestacije.");
                err.Show();
            }
            else
            {
                StrukturaManifestacija novi = new StrukturaManifestacija();

                foreach (StrukturaManifestacija m in ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije)
                {
                    if (m.IDManifestacija.Equals(tbID.Text))
                    {
                        novi = m;
                        break;
                    }
                }

                odTipa = novi.DobilaSlicicuOdTipa;
                    ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije.Remove(novi);

                if (SveStrukture.Instance.ManifestacijeLista.Contains(novi))
                {
                    SveStrukture.Instance.ManifestacijeLista.Remove(novi);
                    postojao = true;
                }


                novi.IDManifestacija = tbID.Text;
                novi.OpisManif = tbOpis.Text;
                novi.ImeManifestacija = tbIme.Text;
                //ComboBoxevi
                novi.Tipp = (StrukturaTip)tipMan.SelectedValue;
                novi.ImeTipaa = novi.Tipp.Ime;
                if (novi.DobilaSlicicuOdTipa)
                {
                    novi.putanjaT = novi.Tipp.putanjaT;
                    //image.Source = new BitmapImage(new Uri(novi.putanjaT));
                }

                ObservableCollection<StrukturaEtiketa> pomocna = new ObservableCollection<StrukturaEtiketa>();
                if (CheckComboBox.Text.Equals("") == false)
                {
                    String[] pom = CheckComboBox.Text.ToString().Split(',');
                    for (int i = 0; i < pom.Length; i++)
                    {
                        //Console.WriteLine("****:" + el[i] + "\n");
                        foreach (StrukturaEtiketa et in ((MainWindow)System.Windows.Application.Current.MainWindow).Etikete)
                        {
                            if (et.IDEtiketa.Equals(pom[i]))
                            {
                                pomocna.Add(et);
                            }
                        }
                    }
                }
                novi.EtiketaM = pomocna;

                novi.Alkoholl = alkCOmbo.Text;
                novi.Katcijena = katCijene.Text;

                if (rbNapolju.IsChecked == true)
                {
                    novi.OdrzavaSe = "Napolju";
                }
                else
                {
                    novi.OdrzavaSe = "Unutra";
                }

                if (rbDozvoljeno.IsChecked == true)
                {
                    novi.DozvoljenoPusenje = "Dozvoljeno";
                }
                else
                {
                    novi.DozvoljenoPusenje = "Zabranjeno";
                }


                if (rbDostupnoDA.IsChecked == true)
                {
                    novi.Dostupno = "Da";
                }
                else
                {
                    novi.Dostupno = "Ne";
                }



                novi.DatumManifest = (DateTime)datummm.SelectedDate;

                
                novi.ikonicaManif = (BitmapImage)image.Source;
                if (putanja != null)
                {
                    novi.putanjaT = putanja;
                }


                ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije.Add(novi);
                if (postojao == true)
                {
                    SveStrukture.Instance.ManifestacijeLista.Add(novi);
                }
                else
                {
                   // Console.WriteLine("aaaaaaaaaaaaaaaaaa");
                    for (int i = 0; i < SveStrukture.Instance.SliciceManifestacije.Count; i++)
                    {
                        Slicice slicica = SveStrukture.Instance.SliciceManifestacije[i];
                        if (slicica.Manifestacija.IDManifestacija.Equals(novi.IDManifestacija))
                        {
                            ((MainWindow)System.Windows.Application.Current.MainWindow).mapaSlika.Children.RemoveAt(i);

                            slicica.Manifestacija = novi;

                            Image ikonica = new Image();
                            ikonica.Height = 40;
                            ikonica.Width = 40;
                            BitmapImage ikonicaSource = new BitmapImage(new Uri(novi.putanjaT));
                            ikonica.Name = slicica.Manifestacija.IDManifestacija;
                            ikonica.Source = ikonicaSource;

                            Canvas.SetLeft(ikonica, slicica.X);
                            Canvas.SetTop(ikonica, slicica.Y);

                            ((MainWindow)System.Windows.Application.Current.MainWindow).mapaSlika.Children.Insert(i, ikonica);
                            break;
                        }
                         
                    }

                }
                this.Close();
            }
        }

        

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var SelectedComboItem = sender as ComboBox;
            string name = SelectedComboItem.SelectedItem as string;
            // MessageBox.Show(name);
        }

     
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var SelectedComboItem = sender as ComboBox;
            string name = SelectedComboItem.SelectedItem as string;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void ComboBoxManifestacijeLoaded(object sender, RoutedEventArgs e)
        { 
        }
        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            var SelectedComboItem = sender as ComboBox;
            string name = SelectedComboItem.SelectedItem as string;
            StrukturaManifestacija novi=null;
            foreach (StrukturaManifestacija m in ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije)
            {
                if (m.IDManifestacija.Equals(tbID.Text))
                {
                    novi = m;
                    break;
                }
            }

            odTipa = novi.DobilaSlicicuOdTipa;
            if (odTipa)
            {
               // Console.WriteLine("aaaaaaaaaaaaa");
                StrukturaTip tip= (StrukturaTip)tipMan.SelectedValue; ;
                image.Source = new BitmapImage(new Uri(tip.putanjaT));
            }
            
        }

        public string ValidString1
        {
            get { return validString1; }
            set
            {
                if (value != validString1)
                {
                    validString1 = value;
                    OnPropertyChanged("ValidString1");
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (.jpg;.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (.png)|.png";

            if (dlg.ShowDialog() == true)
            {
              
                image.Source = new BitmapImage(new Uri(dlg.FileName));
                putanja = dlg.FileName;
                odTipa = false;
            }
        }

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void tbIme_GotFocus(object sender, RoutedEventArgs e)
        {
            popupIme.IsOpen = true;
        }

        private void tbIme_LostFocus(object sender, RoutedEventArgs e)
        {
            popupIme.IsOpen = false;
           
        }

        

        private void tbIme_PreviewMouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            popupIme.IsOpen = true;
        }

        private void tbOpis_GotFocus(object sender, RoutedEventArgs e)
        {
            popupOpis.IsOpen = true;
        }

        private void tbOpis_LostFocus(object sender, RoutedEventArgs e)
        {
            popupOpis.IsOpen = false;
        }

        private void tbOpis_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupOpis.IsOpen = true;
        }
    }
}
