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

namespace WpfApp2.Upozorenja
{
    /// <summary>
    /// Interaction logic for Zatvaranje.xaml
    /// </summary>
    public partial class Zatvaranje : Window
    {
        private bool sacuvaj = false;
        public Zatvaranje()
        {
            InitializeComponent();
        }

        public bool Sacuvaj { get => sacuvaj; set => sacuvaj = value; }

        private void Da_click(object sender, RoutedEventArgs e)
        {
            sacuvaj = true;
            this.Close();
        }


        private void Ne_click(object sender, RoutedEventArgs e)
        {
            sacuvaj = false;
            this.Close();
        }
    }
}
