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
    public partial class Window1 : Window, INotifyPropertyChanged
    {
        ToolTip toolTip = new ToolTip();
        private string validString1;
        private string validString2;
        private String putanja;
        private bool odTipa=false;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<StrukturaEtiketa> MEtiketa;

        internal ObservableCollection<StrukturaEtiketa> EtiketaManifestacije
        {
            get { return MEtiketa; }
            set
            {
                if (MEtiketa != value)
                {
                    MEtiketa = value;
                    OnPropertyChanged("EtiketaManifestacije");
                }
            }
        }

        public ObservableCollection<StrukturaEtiketa> listaEtikete
        {
            get;
            set;
        }
        public ObservableCollection<pomocnaEtikete> pomocnaLista { get; set; } //lista klasa koja sadrzi sve unijete etikete i bool da li je data etiketa selektovana u nekoj manifestaciji


        public Window1()
        {
            InitializeComponent();
            inicijalizacija();

            this.DataContext = this;
            pomocnaLista = new ObservableCollection<pomocnaEtikete>();
            ObservableCollection<StrukturaEtiketa> sveEtikete = ((MainWindow)System.Windows.Application.Current.MainWindow).Etikete;
            for (int i = 0; i < sveEtikete.Count; i++)
            {
                pomocnaLista.Add(new pomocnaEtikete { IsSelected = false, TheText = sveEtikete[i].IDEtiketa });
            }

            //etikete za CheckComboBox
          
            listaEtikete = new ObservableCollection<StrukturaEtiketa>(sveEtikete);

        }
        
        private void inicijalizacija()
        {
            ComboBoxTipovi.Items.Clear();
            for (int i = 0; i < ((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi.Count; i++)
            {
                
                ComboBoxTipovi.Items.Add(((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi[i]);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Boolean Capslock = Console.CapsLock;

            /*   ToolTip toolTip = new ToolTip();
           TextBlock tb = new TextBlock();
           Brush b= (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF722F2F"));
           Brush f= (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFFFFFF"));

           tb.Foreground = f;
           tb.Background = b;
           tb.Text= "Jedinstven ID za vašu manifestaciju. Možete unijeti bilo koji niz karaktera koji nije već korišten za neku manifestaciju.";
           toolTip.Content = tb;

               toolTip.IsOpen = true;
          // toolTip.HasDropShadow = true;

               manifestacijaID.ToolTip = toolTip;*/
            popup.IsOpen = true;
            
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool idPostoji = false;
            if (!String.IsNullOrEmpty(manifestacijaID.Text) || !String.IsNullOrWhiteSpace(manifestacijaID.Text))
            {
                String manifID = manifestacijaID.Text;
                
                ObservableCollection<StrukturaManifestacija> manifestacijeLista = ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije;

                for (int i = 0; i < manifestacijeLista.Count; i++)
                {
                    if (manifID.Equals(manifestacijeLista[i].IDManifestacija))
                    {
                        idPostoji = true;
                        break;
                        /* Greska err = new Greska("ID vec postoji");
                         err.Show();*/
                    }
                }
            }


            if(idPostoji)
                {
                    Greska err = new Greska("Ovaj ID vec postoji");
                    err.Show();
                }
             else if (String.IsNullOrEmpty(manifestacijaID.Text) || String.IsNullOrWhiteSpace(manifestacijaID.Text))
                {
                    Greska err = new Greska("Morate unijeti ID manifestacije da biste je dodali.");
                    err.Show();
                }
                else if ((String.IsNullOrEmpty(manifestacijaIme.Text) || String.IsNullOrWhiteSpace(manifestacijaIme.Text)))
                {
                    Greska err = new Greska("Morate unijeti ime manifestacije da biste je dodali.");
                    err.Show();
                }
                else if (ComboBoxTipovi.SelectedItem == null)
                {
                    Greska err = new Greska("Nije izabran tip manifestacije.");
                    err.Show();
                } else if (!char.IsLetter(manifestacijaID.Text[0]) && !(manifestacijaID.Text[0].Equals("_")))
            {
                Greska err = new Greska("ID ne može počinjati ovim znakom. Molimo, unesite ID sa slovom ,ili znakom '_' ,na prvom mjestu.");
                err.Show();
            }
                else
                {
                    String manifID = manifestacijaID.Text;

                    String ime = manifestacijaIme.Text;
                    StrukturaTip tipp = (StrukturaTip)ComboBoxTipovi.SelectedValue;
                    DateTime dat = (DateTime)datumm.SelectedDate;
                    String cijene = katCijena.Text;
                    String alkohol = alkoh.Text;
                    String dostupan = "Ne";
                    String mjesto = "Napolju";
                    String pusenje = "Dozvoljeno";
                    BitmapImage ikonica = null;
                    if (dostupanzaH.IsChecked == true)
                    {
                        dostupan = "Da";
                    }
                    if (rbUnutra.IsChecked == true)
                    {
                        mjesto = "Unutra";
                    }
                    if (rbZabranjeno.IsChecked == true)
                    {
                        pusenje = "Zabranjeno";
                    }

                    String opis = opisMan.Text;

                    if (image.Source != null)
                    {
                        ikonica = (BitmapImage)image.Source;
                        //   novi.PutanjaMan = putanja;
                    }
                    else if (tipp != null)
                    {
                        if (tipp.Ikonica != null)
                        {
                            ikonica = (BitmapImage)tipp.Ikonica;
                            putanja = tipp.putanjaT;
                        odTipa = true;
                            
                        }
                    }
                    ObservableCollection<StrukturaEtiketa> EtiketeLista = new ObservableCollection<StrukturaEtiketa>();
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
                                    EtiketeLista.Add(et);
                                }
                            }
                        }
                    }
                    StrukturaManifestacija manif = new StrukturaManifestacija(manifID, ime, tipp, dat, ikonica, dostupan, pusenje, mjesto, cijene, alkohol, opis, EtiketeLista, putanja);
                if (odTipa)
                {
                  
                    manif.DobilaSlicicuOdTipa = true;
                }
                manif.ImeTipaa = manif.Tipp.Ime;
                ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije.Add(manif);
                SveStrukture.Instance.ManifestacijeLista.Add(manif);

                    this.Close();
                }
                
            
        }

        private void ComboBoxLoaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>
            {
                "Besplatno",
                "Niske cijene",
                "Srednje cijene",
                "Visoke cijene"
            };
            var combo = sender as ComboBox;
            combo.ItemsSource = data;
            combo.SelectedIndex = 0;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var SelectedComboItem = sender as ComboBox;
            string name = SelectedComboItem.SelectedItem as string;
            // MessageBox.Show(name);
        }

        private void ComboBoxAlkoholLoaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>
            {
                "Nema alkohola",
                "Alkohol se može donijeti",
                "alkohol se može kupiti na licu mesta"
            };
            var combo = sender as ComboBox;
            combo.ItemsSource = data;
            combo.SelectedIndex = 0;
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
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {

        }

        private void manifestacijaIme_LostFocus(object sender, RoutedEventArgs e)
        {
            popupIme.IsOpen = false;
            BindingExpression be1 = this.manifestacijaIme.GetBindingExpression(TextBox.TextProperty);
            be1.UpdateSource();
            if (be1.HasError)
            {
                this.manifestacijaIme.BorderBrush = Brushes.Red;
               
            }
            else
            {
                this.manifestacijaIme.BorderBrush = Brushes.Green;
                
            }

        }

        private void manifestacijaID_LostFocus(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = false;
            BindingExpression be1 = this.manifestacijaID.GetBindingExpression(TextBox.TextProperty);
            be1.UpdateSource();
            if (be1.HasError)
            {
                this.manifestacijaID.BorderBrush = Brushes.Red;
                
            }
            else
            {
                this.manifestacijaID.BorderBrush = Brushes.Green;
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (.jpg;.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (.png)|.png";

            if (dlg.ShowDialog() == true)
            {
                // stavis izabranu sliku kao source tvog elementa gdje treba biti slika
                image.Source = new BitmapImage(new Uri(dlg.FileName));
                putanja = dlg.FileName;
            }
        }

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
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

        public string ValidString2
        {
            get { return validString2; }
            set
            {
                if (value != validString2)
                {
                    validString2 = value;
                    OnPropertyChanged("ValidString2");
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        

        private void manifestacijaIme_GotFocus(object sender, RoutedEventArgs e)
        {
            popupIme.IsOpen = true;
        }

        private void opisMan_GotFocus(object sender, RoutedEventArgs e)
        {
            popupOpis.IsOpen = true;
        }

        private void opisMan_LostFocus(object sender, RoutedEventArgs e)
        {
            popupOpis.IsOpen = false;
        }

        private void manifestacijaID_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popup.IsOpen = true;
        }

        private void manifestacijaIme_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupIme.IsOpen = true;
        }

        private void opisMan_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupOpis.IsOpen = true;
        }
    }
}
