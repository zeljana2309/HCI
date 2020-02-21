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
    /// Interaction logic for Etiketa1.xaml
    /// </summary>
    public partial class Etiketa1 : Window
    {
        public Etiketa1()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private string validString3;

        public string ValidString3
        {
            get { return validString3; }
            set
            {
                if (value != validString3)
                {
                    validString3 = value;
                    OnPropertyChanged("ValidString3");
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool idPostoji = false;
            if (!String.IsNullOrEmpty(EtiketaID.Text) || !String.IsNullOrWhiteSpace(EtiketaID.Text))
            {
                String etID = EtiketaID.Text;
                ObservableCollection<StrukturaEtiketa> etiketeLista = ((MainWindow)System.Windows.Application.Current.MainWindow).Etikete;

                for (int i = 0; i < etiketeLista.Count; i++)
                {
                    if (etID.Equals(etiketeLista[i].IDEtiketa))
                    {
                        idPostoji = true;
                        break;
                        /* Greska err = new Greska("ID vec postoji");
                         err.Show();*/
                    }
                }
            }


            if (idPostoji)
            {
                Greska err = new Greska("Ovaj ID vec postoji");
                err.Show();
            }
            else
            if (String.IsNullOrEmpty(EtiketaID.Text) || String.IsNullOrWhiteSpace(EtiketaID.Text))
            {
                Greska err = new Greska("Morate unijeti ID etikete da biste je dodali.");
                err.Show();
            }
            else { 
                String etiketaIDD = EtiketaID.Text;

            String opis = EtiketaOpis.Text;
            Color boja = (System.Windows.Media.Color)_colorEtiketa.SelectedColor;
               
                // Color bojaE = Color.FromRgb(_colorEtiketa.SelectedColor.R, _colorEtiketa.SelectedColor.G, _colorEtiketa.SelectedColor.B);
                StrukturaEtiketa et = new StrukturaEtiketa();
                et.IDEtiketa = etiketaIDD;
                et.OpisEtiketa = opis;
                et.bojaEtiketa = boja;
                et.Prva = boja.R;
                et.Druga = boja.G;
                et.Treca = boja.B;
                et.bojaEtiketa = (Color)_colorEtiketa.SelectedColor;
                ((MainWindow)System.Windows.Application.Current.MainWindow).Etikete.Add(et);
            this.Close();
        }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void etiketaID_LostFocus(object sender, RoutedEventArgs e)
        {
            popupID.IsOpen = false;
            BindingExpression be1 = this.EtiketaID.GetBindingExpression(TextBox.TextProperty);
            be1.UpdateSource();
            if (be1.HasError)
            {
                this.EtiketaID.BorderBrush = Brushes.Red;
            }
            else
            {
                this.EtiketaID.BorderBrush = Brushes.Green;
            }

        }

        private void Pomoc_Click_(object sender, RoutedEventArgs e)
        {
            PomocEtiketa pomoc = new PomocEtiketa();
            pomoc.Show();
        }

        private void EtiketaID_GotFocus(object sender, RoutedEventArgs e)
        {
            popupID.IsOpen = true;
        }

        private void EtiketaID_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupID.IsOpen = true;
        }

        private void EtiketaOpis_GotFocus(object sender, RoutedEventArgs e)
        {
            popupOpis.IsOpen = true;
        }

        private void EtiketaOpis_LostFocus(object sender, RoutedEventArgs e)
        {
            popupOpis.IsOpen = false;
        }

        private void EtiketaOpis_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popupOpis.IsOpen = true;
        }
    }
}
