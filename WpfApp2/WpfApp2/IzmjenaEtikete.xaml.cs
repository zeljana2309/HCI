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
using System.Windows.Shapes;
using WpfApp2.Strukture;
using WpfApp2.Upozorenja;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Etiketa1.xaml
    /// </summary>
    public partial class IzmjenaEtikete : Window
    {
        public IzmjenaEtikete(StrukturaEtiketa etiketa)
        {
            InitializeComponent();

            tbID.Text = etiketa.IDEtiketa;
            tbOpis.Text = etiketa.OpisEtiketa;
            colorPicker.SelectedColor = etiketa.bojaEtiketa;
        }

        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tbID.Text) || String.IsNullOrWhiteSpace(tbID.Text))
            {
                Greska err = new Greska("Morate unijeti ID etikete da biste je dodali.");
                err.Show();
            }
            else
            {
                StrukturaEtiketa et = new StrukturaEtiketa();

                foreach (StrukturaEtiketa etiketa1 in ((MainWindow)System.Windows.Application.Current.MainWindow).Etikete)
                {
                    if (etiketa1.IDEtiketa.Equals(tbID.Text))
                    {
                        et = etiketa1;
                        break;
                    }
                }


            ((MainWindow)System.Windows.Application.Current.MainWindow).Etikete.Remove(et);

                et.IDEtiketa = tbID.Text;
                et.OpisEtiketa = tbOpis.Text;
                Color boja = (Color)colorPicker.SelectedColor;
                et.Prva = boja.R;
                et.Druga = boja.G;
                et.Treca = boja.B;
                et.bojaEtiketa = (Color)colorPicker.SelectedColor;
                ((MainWindow)System.Windows.Application.Current.MainWindow).Etikete.Add(et);
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Pomoc_Click_(object sender, RoutedEventArgs e)
        {
            PomocEtiketa pomoc = new PomocEtiketa();
            pomoc.Show();
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
