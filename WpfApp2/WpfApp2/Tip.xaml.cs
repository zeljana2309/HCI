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
using WpfApp2.Tabele;
using WpfApp2.Upozorenja;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Tip.xaml
    /// </summary>
    public partial class Tip : Window
    {
        private BitmapImage pomocna=null;
        private String putanja = null;
        public Tip()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private string validString4;
        private string validString5;

        public string ValidString4
        {
            get { return validString4; }
            set
            {
                if (value != validString4)
                {
                    validString4 = value;
                    OnPropertyChanged("ValidString4");
                }
            }
        }

        public string ValidString5
        {
            get { return validString5; }
            set
            {
                if (value != validString5)
                {
                    validString5 = value;
                    OnPropertyChanged("ValidString5");
                }
            }
        }

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void tipID_LostFocus(object sender, RoutedEventArgs e)
        {
            popupID.IsOpen = false;
            BindingExpression be1 = this.tipID.GetBindingExpression(TextBox.TextProperty);
            be1.UpdateSource();
            if (be1.HasError)
            {
                this.tipID.BorderBrush = Brushes.Red;
            }
            else
            {
                this.tipID.BorderBrush = Brushes.Green;
            }

        }

        private void tipIme_LostFocus(object sender, RoutedEventArgs e)
        {
            popupIme.IsOpen = false;
            BindingExpression be1 = this.tipIme.GetBindingExpression(TextBox.TextProperty);
            be1.UpdateSource();
            if (be1.HasError)
            {
                this.tipIme.BorderBrush = Brushes.Red;
            }
            else
            {
                this.tipIme.BorderBrush = Brushes.Green;
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //klik na dugme potvrdi
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool idPostoji = false;
            String etID = tipID.Text;
            ObservableCollection<StrukturaTip> tipoviLista = ((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi;

            for (int i = 0; i < tipoviLista.Count; i++)
            {
                if (etID.Equals(tipoviLista[i].IDD))
                {
                    idPostoji = true;
                    break;
                    /* Greska err = new Greska("ID vec postoji");
                     err.Show();*/
                }
            }
        


            if (idPostoji)
            {
                Greska err = new Greska("Ovaj ID vec postoji");
        err.Show();
            }
            else
            if (String.IsNullOrEmpty(tipID.Text) || String.IsNullOrWhiteSpace(tipID.Text))
            {
                Greska err = new Greska("Morate unijeti ID tipa da biste ga dodali.");
                err.Show();
            }
            else if ((String.IsNullOrEmpty(tipIme.Text) || String.IsNullOrWhiteSpace(tipIme.Text)))
            {
                Greska err = new Greska("Morate unijeti ime tipa da biste ga dodali.");
                err.Show();
            }
            else if (pomocna== null)
            {
                Greska err = new Greska("Nije dodata ikonica tipa.");
                err.Show();
            }
            else
            {
                String tipIDD = tipID.Text;
                String tipImee = tipIme.Text;
                String opis = tipOpis.Text;
                
                
                StrukturaTip tip = new StrukturaTip(tipIDD, tipImee, opis, pomocna,putanja);
                ((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi.Add(tip);
                // MainWindow.Tipovi.Add(tip);
                //PrikazTipova.dodajTip(tip);
                //Console.WriteLine(MainWindow.Tipovi);

                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (.jpg;.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (.png)|.png";

            if (dlg.ShowDialog() == true)
            {
                // stavis izabranu sliku kao source tvog elementa gdje treba biti slika
                image.Source = new BitmapImage(new Uri(dlg.FileName));
            }
            pomocna = new BitmapImage(new Uri(dlg.FileName));
            putanja = dlg.FileName;
        }

        private void tipID_GotFocus(object sender, RoutedEventArgs e)
        {
            popupID.IsOpen = true;
        }

        private void tipID_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupID.IsOpen = true;
        }

        private void tipIme_GotFocus(object sender, RoutedEventArgs e)
        {
            popupIme.IsOpen = true;
        }

        private void tipIme_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupIme.IsOpen = true;
        }

        private void tipOpis_LostFocus(object sender, RoutedEventArgs e)
        {
            popupOpis.IsOpen = false;
        }

        private void tipOpis_GotFocus(object sender, RoutedEventArgs e)
        {
            popupOpis.IsOpen = true;
        }

        private void tipOpis_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupOpis.IsOpen = true;
        }
    }
}
