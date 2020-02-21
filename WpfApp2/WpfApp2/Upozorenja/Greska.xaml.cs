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
    /// Interaction logic for Greska.xaml
    /// </summary>
    public partial class Greska : Window
    {
        public Greska()
        {
            InitializeComponent();
        }

        public Greska(String s)
        {
            InitializeComponent();
            tb.Text = s;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
