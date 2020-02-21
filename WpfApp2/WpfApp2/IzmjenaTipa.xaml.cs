using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Tip.xaml
    /// </summary>
    public partial class IzmjenaTipa : Window
    {
        private String putanja=null;
        public IzmjenaTipa(StrukturaTip tip)
        {
            InitializeComponent();
            tbID.Text = tip.IDD;
            tipIme.Text = tip.Ime;
            tbOpis.Text = tip.Opis;
            image.Source = tip.Ikonica;
            putanja = tip.putanjaT;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {

            if (String.IsNullOrEmpty(tbID.Text) || String.IsNullOrWhiteSpace(tbID.Text))
            {
                Greska err = new Greska("Morate unijeti ID tipa da biste ga dodali.");
                err.Show();
            }
            else if ((String.IsNullOrEmpty(tipIme.Text) || String.IsNullOrWhiteSpace(tipIme.Text)))
            {
                Greska err = new Greska("Morate unijeti ime tipa da biste ga dodali.");
                err.Show();
            }
            else
            {
                StrukturaTip tip = new StrukturaTip();

                foreach (StrukturaTip tip1 in ((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi)
                {
                    if (tip1.IDD.Equals(tbID.Text))
                    {
                        tip = tip1;
                        break;
                    }
                }


            ((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi.Remove(tip);

                tip.IDD = tbID.Text;
                tip.Opis = tbOpis.Text;
                tip.Ime = tipIme.Text;
                tip.Ikonica = (BitmapImage)image.Source;
                ((MainWindow)System.Windows.Application.Current.MainWindow).Tipovi.Add(tip);


                foreach (StrukturaManifestacija sm in ((MainWindow)System.Windows.Application.Current.MainWindow).Manifestacije)
                {
                    if(sm.Tipp.IDD.Equals(tip.IDD))
                    {
                        sm.Tipp = tip;
                        if(sm.DobilaSlicicuOdTipa)
                        {
                            sm.putanjaT = putanja;
                            sm.ikonicaManif = new BitmapImage(new Uri(putanja));
                        }
                        
                    }
                }

                foreach (StrukturaManifestacija sm in SveStrukture.Instance.ManifestacijeLista)
                {
                    if (sm.Tipp.IDD.Equals(tip.IDD))
                    {
                        sm.Tipp = tip;
                        if (sm.DobilaSlicicuOdTipa)
                        {
                            sm.putanjaT = putanja;
                            sm.ikonicaManif = new BitmapImage(new Uri(putanja));
                        }

                    }
                }

                for (int j=0;j<SveStrukture.Instance.SliciceManifestacije.Count;j++)
                {
                    Slicice s = SveStrukture.Instance.SliciceManifestacije[j];
                    if (s.Manifestacija.DobilaSlicicuOdTipa)
                    {
                        if(s.Manifestacija.Tipp.IDD.Equals(tip.IDD))
                        {
                            s.Manifestacija.Tipp = tip;
                            s.Manifestacija.putanjaT = putanja;
                            s.Manifestacija.ikonicaManif = new BitmapImage(new Uri(putanja));
                            Image ikonica = new Image();
                            ikonica.Height = 40;
                            ikonica.Width = 40;
                            BitmapImage ikonicaSource = new BitmapImage(new Uri(s.Manifestacija.putanjaT));
                            ikonica.Name = s.Manifestacija.IDManifestacija;
                            ikonica.Source = ikonicaSource;
                            ToolTip tt = new ToolTip();
                            ListView lv = new ListView();
                            ObservableCollection<Ellipse> listaElipsa = new ObservableCollection<Ellipse>();
                            for (int i = 0; i < s.Manifestacija.EtiketaM.Count; i++)
                            {
                                Ellipse elipsa = new Ellipse();
                                elipsa.Height = 20;
                                elipsa.Width = 20;
                                elipsa.Fill = s.Manifestacija.EtiketaM[i].ColorBrush;
                                // tt.Content = elipsa;
                                listaElipsa.Add(elipsa);
                            }
                            lv.ItemsSource = listaElipsa;
                            tt.Content = lv;
                            ikonica.ToolTip = tt;
                            ((MainWindow)System.Windows.Application.Current.MainWindow).mapaSlika.Children.RemoveAt(j);
                            ((MainWindow)System.Windows.Application.Current.MainWindow).mapaSlika.Children.Insert(j, ikonica);

                            Canvas.SetLeft(ikonica, s.X);
                            Canvas.SetTop(ikonica, s.Y);
                        }
                    }
                }


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
                putanja = dlg.FileName;
            }
            
        }

        private void tbID_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tbID_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupID.IsOpen = true;
        }

        private void tbID_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tipIme_LostFocus(object sender, RoutedEventArgs e)
        {
            popupIme.IsOpen = false;
        }

        private void tipIme_GotFocus(object sender, RoutedEventArgs e)
        {
            popupIme.IsOpen = true;
        }

        private void tipIme_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupIme.IsOpen = true;
        }
    }
}
