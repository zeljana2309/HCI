using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using WpfApp2.Pomoc;
using WpfApp2.Properties;
using WpfApp2.Strukture;
using WpfApp2.Tabele;
using WpfApp2.Upozorenja;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        Point startPoint = new Point();
        private bool promjena = false;
        private StrukturaManifestacija pomocnaZaBrisanje = null;


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }

        }


        private ObservableCollection<Strukture.StrukturaManifestacija> manifestacije;

        public ObservableCollection<StrukturaManifestacija> Manifestacije
        {
            get
            {
                return manifestacije;
            }

            set
            {
                if (manifestacije != value)
                {
                    manifestacije = value;
                    OnPropertyChanged("Manifestacije");
                }
            }
        }

        public ObservableCollection<StrukturaTip> tipovi;
        public ObservableCollection<StrukturaTip> Tipovi
        {
            get
            {
                return tipovi;
            }
            set
            {
                if (tipovi != value)
                {
                    tipovi = value;
                    OnPropertyChanged("Tipovi");
                }
            }
        }

        private static ObservableCollection<StrukturaEtiketa> etikete;
        public ObservableCollection<StrukturaEtiketa> Etikete
        {
            get
            {
                return etikete;
            }
            set
            {
                if (etikete != value)
                {
                    etikete = value;
                    // OnPropertyChanged("Etikete");
                }
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
        public MainWindow()
        {
           
            tipovi = new ObservableCollection<StrukturaTip>();
            manifestacije = new ObservableCollection<StrukturaManifestacija>();
            etikete = new ObservableCollection<StrukturaEtiketa>();
            InitializeComponent();
            
            this.manifLista.ItemsSource=  SveStrukture.Instance.ManifestacijeLista;


           
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(manifLista.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Tipp.Ime");
            view.GroupDescriptions.Add(groupDescription);
            this.DataContext = this;
            gridLogin.Visibility = Visibility.Visible;
            gridMain.Visibility = Visibility.Hidden;
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrWhiteSpace(txtName.Text) && !String.IsNullOrEmpty(txtPass.Password) && !String.IsNullOrWhiteSpace(txtPass.Password))
            {


                if (txtName.Text.Equals("admin") && txtPass.Password.Equals("admin"))
                {
                    gridLogin.Visibility = Visibility.Hidden;
                    gridMain.Visibility = Visibility.Visible;
                }
            }
            else
            {
                txtName.BorderBrush = Brushes.Red;
            }



        }




        private void KreirajTip_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void KreirejTip_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Tip dt = new Tip();
            dt.ShowDialog();
        }


        private void KreirajManifestaciju_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void KreirejManifestaciju_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Window1 dt = new Window1();
            dt.ShowDialog();
        }


        private void KreirajEtiketu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void KreirajEtiketu_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            Etiketa1 de = new Etiketa1();
            de.ShowDialog();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {


            Zatvaranje i = new Zatvaranje();
            i.ShowDialog();
            if (i.Sacuvaj)
            {

                ObservableCollection<StrukturaTip> tipoviCuvanje = tipovi;
                ObservableCollection<StrukturaManifestacija> manifCuvanje = manifestacije;
                ObservableCollection<StrukturaEtiketa> etiketeCuvanje = etikete;
                ObservableCollection<StrukturaEtiketa> etiketeManCuvanje = new ObservableCollection<StrukturaEtiketa>();
                ObservableCollection<Slicice> sliciceCuvanje = SveStrukture.Instance.SliciceManifestacije;
                SveStrukture sCuvanje = new SveStrukture(tipoviCuvanje, etiketeCuvanje, manifCuvanje);



                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = null;

                string mjesto = "E:\\projekti HCI\\Projekat\\cuvanje.txt";


                try
                {
                    stream = File.Open(mjesto, FileMode.OpenOrCreate);
                    formatter.Serialize(stream, manifCuvanje);
                    formatter.Serialize(stream, tipoviCuvanje);
                    formatter.Serialize(stream, etiketeCuvanje);
                    formatter.Serialize(stream, sliciceCuvanje);

                }
                catch (SerializationException es)
                {
                    Console.WriteLine("Greska " + es.Message);
                    throw;
                }
                finally
                {
                    if (stream != null)
                        stream.Dispose();
                }


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Tip ProzorTip = new Tip();
            //ProzorTip.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            /* Window1 w1 = new Window1();
             w1.Show();*/
        }


        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            //  IzmjenaTipa it = new IzmjenaTipa();
            // it.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            // IzmjenaEtikete ie = new IzmjenaEtikete();
            //ie.Show();
        }

        private void PrikazTipa(object sender, RoutedEventArgs e)
        {
            PrikazTipova pt = new PrikazTipova();
            pt.Show();
        }

        private void PrikazEtikete(object sender, RoutedEventArgs e)
        {
            PrikazEtiketa pe = new PrikazEtiketa();
            pe.Show();
        }

        private void PrikaziManifestacijee(object sender, RoutedEventArgs e)
        {
            PrikazManifestacija pman = new PrikazManifestacija();
            pman.Show();
        }

        private void Sacuvaj_Click(object sender, RoutedEventArgs e)
        {

            ObservableCollection<StrukturaTip> tipoviCuvanje = tipovi;
            ObservableCollection<StrukturaManifestacija> manifCuvanje = manifestacije;
            ObservableCollection<StrukturaEtiketa> etiketeCuvanje = etikete;
            ObservableCollection<StrukturaEtiketa> etiketeManCuvanje = new ObservableCollection<StrukturaEtiketa>();
            ObservableCollection<Slicice> sliciceCuvanje = SveStrukture.Instance.SliciceManifestacije;
            SveStrukture sCuvanje = new SveStrukture(tipoviCuvanje, etiketeCuvanje, manifCuvanje);



            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            string mjesto = "E:\\projekti HCI\\Projekat\\cuvanje.txt";


            try
            {
                stream = File.Open(mjesto, FileMode.OpenOrCreate);
                formatter.Serialize(stream, manifCuvanje);
                formatter.Serialize(stream, tipoviCuvanje);
                formatter.Serialize(stream, etiketeCuvanje);
                formatter.Serialize(stream, sliciceCuvanje);

            }
            catch (SerializationException es)
            {
                Console.WriteLine("Greska " + es.Message);
                throw;
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }

        }

        private void manifLista_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
            promjena = false;


        }

        private void manifLista_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                StrukturaManifestacija manif = (StrukturaManifestacija)this.manifLista.SelectedItem;

                if (manif != null)
                {
                    DataObject dragData = new DataObject("myFormat", manif);
                    DragDrop.DoDragDrop((DependencyObject)e.OriginalSource, dragData, DragDropEffects.Move);
                }
            }
        }

        private void mapaSlika_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("myFormat") || sender == e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void mapaSlika_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                StrukturaManifestacija manifestacija1 = e.Data.GetData("myFormat") as StrukturaManifestacija;

                SveStrukture.Instance.ManifestacijeLista.Remove(manifestacija1);
                Image ikonica = new Image();
                ikonica.Height = 40;
                ikonica.Width = 40;
                BitmapImage ikonicaSource = new BitmapImage(new Uri(manifestacija1.putanjaT));
                ikonica.Name = manifestacija1.IDManifestacija;
                ikonica.Source = ikonicaSource;

                ToolTip tt = new ToolTip();
                StackPanel sp = new StackPanel();
               
                ListView lv=new ListView();
               
                ObservableCollection<Ellipse> listaElipsa = new ObservableCollection<Ellipse>();
                for (int i = 0; i < manifestacija1.EtiketaM.Count; i++)
                {
                    Ellipse elipsa = new Ellipse();
                    elipsa.Height = 20;
                    elipsa.Width = 20;
                    elipsa.Fill = manifestacija1.EtiketaM[i].ColorBrush;
                   // tt.Content = elipsa;
                    listaElipsa.Add(elipsa);
                  }
                lv.ItemsSource = listaElipsa;
                Grid g = new Grid();
                Grid g2 = new Grid();
                Grid g3 = new Grid();
                TextBox tb = new TextBox();
                TextBox tb2 = new TextBox();
                tb.Text = "ID : "+manifestacija1.IDManifestacija;
                tb2.Text = "Ime : "+manifestacija1.ImeManifestacija;
                g.Children.Add(lv);
                g2.Children.Add(tb);
                g3.Children.Add(tb2);
                sp.Children.Add(g2);
                sp.Children.Add(g3);
                sp.Children.Add(g);
                tt.Content = sp;
                ikonica.ToolTip = tt;
                
               
                if (!promjena)
                {
                    this.mapaSlika.Children.Add(ikonica);
                    
                    Point p = e.GetPosition(this.mapaSlika);

                    Canvas.SetLeft(ikonica, p.X);
                    Canvas.SetTop(ikonica, p.Y);

                    Slicice slicica = new Slicice(p.X, p.Y, manifestacija1);
                    SveStrukture.Instance.SliciceManifestacije.Add(slicica);
                }
                else
                {
                    Point p = e.GetPosition(this.mapaSlika);
                    for (int i = 0; i < SveStrukture.Instance.SliciceManifestacije.Count; i++)
                    {
                        if (SveStrukture.Instance.SliciceManifestacije[i].Manifestacija.IDManifestacija.Equals(manifestacija1.IDManifestacija))
                        {

                            Slicice IzmjenaSlicice = SveStrukture.Instance.SliciceManifestacije[i];
                            mapaSlika.Children.RemoveAt(i);
                            mapaSlika.Children.Insert(i, ikonica);




                            StrukturaManifestacija pomocna = razdaljina(p);
                            if (pomocna != null)
                            {
                                p.X = IzmjenaSlicice.X;
                                p.Y = IzmjenaSlicice.Y;
                            }

                            Canvas.SetLeft(ikonica, p.X);
                            Canvas.SetTop(ikonica, p.Y);

                            SveStrukture.Instance.SliciceManifestacije[i].X = p.X;
                            SveStrukture.Instance.SliciceManifestacije[i].Y = p.Y;
                            break;
                        }
                    }
                }
            }

        }


        private void mapaSlika_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(this.mapaSlika);
            promjena = true;

            int i = 0;

            StrukturaManifestacija pomSpom = razdaljina(startPoint);

            if (pomSpom != null)
            {
                pomocnaZaBrisanje = pomSpom;
                Brisanje.Visibility = Visibility.Visible;
                for (i = 0; i < SveStrukture.Instance.SliciceManifestacije.Count; i++)
                {
                    Image img = (Image)mapaSlika.Children[i];

                    //img.Opacity = 0.7;
                    mapaSlika.Children.RemoveAt(i);
                    mapaSlika.Children.Insert(i, img);
                    if (pomSpom.IDManifestacija.Equals(SveStrukture.Instance.SliciceManifestacije[i].Manifestacija))
                    {
                        // img.Opacity = 1;
                        //img.Focus();

                        mapaSlika.Children.RemoveAt(i);
                        mapaSlika.Children.Insert(i, img);
                        pomocnaZaBrisanje = SveStrukture.Instance.SliciceManifestacije[i].Manifestacija;
                        break;
                    }
                }
            }
            else
            {
                Brisanje.Visibility = Visibility.Hidden;
            }
        }

        private void mapaSlika_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(mapaSlika);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                StrukturaManifestacija manifestacijaaa = razdaljina(startPoint);

                if (manifestacijaaa != null)
                {
                    DataObject dragData = new DataObject("myFormat", manifestacijaaa);
                    DragDrop.DoDragDrop((DependencyObject)e.OriginalSource, dragData, DragDropEffects.Move);
                }
            }

        }

        

        private StrukturaManifestacija razdaljina(Point point)
        {
            foreach (Slicice slicica in SveStrukture.Instance.SliciceManifestacije)
            {
                if ((point.X > slicica.X - 1 && point.X < slicica.X + 40) && (point.Y > slicica.Y - 1 && point.Y < slicica.Y + 40))
                {
                    return slicica.Manifestacija;
                }
            }

            return null;
        }

        //ucitaj klik
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string lokacija = "E:\\projekti HCI\\Projekat\\cuvanje.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            ObservableCollection<StrukturaEtiketa> etikete2 = new ObservableCollection<StrukturaEtiketa>();
            ObservableCollection<StrukturaTip> tipovi2 = new ObservableCollection<StrukturaTip>();
            ObservableCollection<StrukturaManifestacija> manifestacije2 = new ObservableCollection<StrukturaManifestacija>();
            ObservableCollection<Slicice> sliciceUcitavanje = new ObservableCollection<Slicice>();


            if (File.Exists(lokacija))
            {
                try
                {
                    this.mapaSlika.Children.Clear();
                    stream = File.Open(lokacija, FileMode.Open);
                    manifestacije2 = (ObservableCollection<StrukturaManifestacija>)formatter.Deserialize(stream);
                    tipovi2 = (ObservableCollection<StrukturaTip>)formatter.Deserialize(stream);

                    etikete2 = (ObservableCollection<StrukturaEtiketa>)formatter.Deserialize(stream);
                    sliciceUcitavanje = (ObservableCollection<Slicice>)formatter.Deserialize(stream);


                }
                catch
                {


                }
                finally
                {


                    if (stream != null)
                        stream.Dispose();

                }

                foreach (StrukturaEtiketa ee in etikete2)
                {
                    ee.bojaEtiketa = Color.FromRgb(ee.Prva, ee.Druga, ee.Treca);

                }

                foreach (StrukturaTip tip2 in tipovi2)
                {
                    if (tip2.putanjaT != "" && tip2.putanjaT != null)
                    {
                        tip2.Ikonica = new BitmapImage(new Uri(tip2.putanjaT, UriKind.Absolute));
                    }
                }

                foreach (StrukturaManifestacija m in manifestacije2)
                {
                    if (m.putanjaT != "" && m.putanjaT != null)
                    {
                        m.ikonicaManif = new BitmapImage(new Uri(m.putanjaT, UriKind.Absolute));
                    }

                    if (m.Tipp.IDD.Equals("") == false || m.Tipp != null)
                    {


                        for (int i = 0; i < tipovi2.Count; i++)
                        {
                            if (tipovi2[i].IDD.Equals(m.Tipp.IDD))
                            {
                                Console.WriteLine(tipovi2[i].IDD);
                                m.Tipp = tipovi2[i];
                                // m.Tipp.Ime = tipovi[i].Ime;
                                break;
                            }

                        }

                        if (m.etiketaManifestacije != new ObservableCollection<StrukturaEtiketa>() || m.etiketaManifestacije.Count != 0)
                        {
                            // m.etiketaManifestacije.Clear();
                            ObservableCollection<StrukturaEtiketa> et = new ObservableCollection<StrukturaEtiketa>();

                            foreach (StrukturaEtiketa pom in etikete2)
                            {
                                for (int i = 0; i < m.etiketaManifestacije.Count; i++)
                                {
                                    if (pom.IDEtiketa.Equals(m.etiketaManifestacije[i].IDEtiketa))
                                    {
                                        Console.WriteLine(pom.IDEtiketa);
                                        et.Add(pom);

                                    }
                                }
                            }
                            m.etiketaManifestacije = et;
                        }
                    }
                }



                etikete = etikete2;
                tipovi = tipovi2;
                manifestacije = manifestacije2;
                SveStrukture.Instance.ManifestacijeLista.Clear();

                for (int i = 0; i < manifestacije2.Count; i++)
                {
                    SveStrukture.Instance.ManifestacijeLista.Add(manifestacije2[i]);
                }


                SveStrukture.Instance.SliciceManifestacije.Clear();

                for (int i = 0; i < sliciceUcitavanje.Count; i++)
                {
                    SveStrukture.Instance.SliciceManifestacije.Add(sliciceUcitavanje[i]);

                    StrukturaManifestacija m = sliciceUcitavanje[i].Manifestacija;
                    for (int k = 0; k < tipovi2.Count; k++)
                    {
                        if (tipovi2[k].IDD.Equals(m.Tipp.IDD))
                        {
                            // Console.WriteLine(tipovi2[k].IDD);
                            m.Tipp = tipovi2[k];
                            sliciceUcitavanje[i].Manifestacija.Tipp = tipovi2[k];
                            // m.Tipp.Ime = tipovi[i].Ime;
                            break;
                        }
                    }
                        Image ikonica = new Image();
                        ikonica.Height = 40;
                        ikonica.Width = 40;
                        BitmapImage ikonicaSource = new BitmapImage(new Uri(m.putanjaT));
                        ikonica.Name = m.IDManifestacija;
                        ikonica.Source = ikonicaSource;
                        m.ikonicaManif = ikonicaSource;
                    ToolTip tt = new ToolTip();
                    StackPanel sp = new StackPanel();

                    ListView lv = new ListView();

                    ObservableCollection<Ellipse> listaElipsa = new ObservableCollection<Ellipse>();
                    foreach (StrukturaEtiketa ee in m.EtiketaM)
                    {
                        ee.bojaEtiketa = Color.FromRgb(ee.Prva, ee.Druga, ee.Treca);

                    }

                    for (int j = 0; j < m.EtiketaM.Count; j++)
                    {
                        
                        Ellipse elipsa = new Ellipse();
                        elipsa.Height = 20;
                        elipsa.Width = 20;
                        elipsa.Fill = m.EtiketaM[j].ColorBrush;
                        // tt.Content = elipsa;
                        listaElipsa.Add(elipsa);
                    }
                    lv.ItemsSource = listaElipsa;
                    Grid g = new Grid();
                    Grid g2 = new Grid();
                    Grid g3 = new Grid();
                    TextBox tb = new TextBox();
                    TextBox tb2 = new TextBox();
                    tb.Text = "ID : " + m.IDManifestacija;
                    tb2.Text = "Ime : " + m.ImeManifestacija;
                    g.Children.Add(lv);
                    g2.Children.Add(tb);
                    g3.Children.Add(tb2);
                    sp.Children.Add(g2);
                    sp.Children.Add(g3);
                    sp.Children.Add(g);
                    tt.Content = sp;
                    ikonica.ToolTip = tt;



                    this.mapaSlika.Children.Add(ikonica);



                        Canvas.SetLeft(ikonica, sliciceUcitavanje[i].X);
                        Canvas.SetTop(ikonica, sliciceUcitavanje[i].Y);

                        for (int j = 0; j < SveStrukture.Instance.ManifestacijeLista.Count; j++)
                        {
                            if (SveStrukture.Instance.ManifestacijeLista[j].IDManifestacija.Equals(m.IDManifestacija))
                            {
                                SveStrukture.Instance.ManifestacijeLista.RemoveAt(j);
                            }
                        }
                    }

                
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                PomocGlavni p = new PomocGlavni();
                p.Show();
            }
        }

        private void Brisanje_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(pomocnaZaBrisanje.ImeManifestacija);
            for (int i = 0; i < SveStrukture.Instance.SliciceManifestacije.Count; i++)
            {
                if (SveStrukture.Instance.SliciceManifestacije[i].Manifestacija.IDManifestacija.Equals(pomocnaZaBrisanje.IDManifestacija))
                {
                    Slicice tempSpom = SveStrukture.Instance.SliciceManifestacije[i];
                    mapaSlika.Children.RemoveAt(i);
                    SveStrukture.Instance.ManifestacijeLista.Add(tempSpom.Manifestacija);
                    SveStrukture.Instance.SliciceManifestacije.RemoveAt(i);
                    Brisanje.Visibility = Visibility.Hidden;
                    pomocnaZaBrisanje = null;
                    break;
                }
            }
        }

        
    }


  
}
