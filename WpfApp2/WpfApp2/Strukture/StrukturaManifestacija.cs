using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp2.Strukture
{
    [Serializable]
    public class StrukturaManifestacija : INotifyPropertyChanged
    {
        private String ID;
        private String ime;
        [NonSerialized]
        private BitmapImage ikonica;
        private String dostupnoZaHendikepirane;
        private String pusenje;
        private String odrzavaSe;
        private String kategorijaCijena;
        private String alkohol;
        private String opis;
        private DateTime datum;
        private StrukturaTip tip;
        private String imeTipa;
        private bool dobilaSlicicuOdTipa;
        public ObservableCollection<StrukturaEtiketa> etiketaManifestacije;
        private String putanjaIkonica;

        public string ImeTipaa
        {
            get { return imeTipa; }
            set { imeTipa = value; }
        }
        public string putanjaT
        {
            get { return putanjaIkonica; }
            set { putanjaIkonica = value; }
        }

        public StrukturaManifestacija(string iD, string ime, StrukturaTip tip, DateTime datum, BitmapImage ikonica, string dostupnoZaHendikepirane, string pusenje, string odrzavaSe, string kategorijaCijena, string alkohol, string opis,ObservableCollection<StrukturaEtiketa> etiketas,String putanja)
        {
            ID = iD;
            this.ime = ime;
            this.tip = tip;
            this.datum = datum;
            this.ikonica = ikonica;
            this.dostupnoZaHendikepirane = dostupnoZaHendikepirane;
            this.pusenje = pusenje;
            this.odrzavaSe = odrzavaSe;
            this.kategorijaCijena = kategorijaCijena;
            this.alkohol = alkohol;
            this.opis = opis;
            this.etiketaManifestacije = etiketas;
            this.putanjaIkonica = putanja;
            DobilaSlicicuOdTipa = false;
        }

        public StrukturaManifestacija()
        {
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public ObservableCollection<StrukturaEtiketa> EtiketaM
        {
            get { return etiketaManifestacije; }
            set
            {
                etiketaManifestacije = value;
                OnPropertyChanged("EtiketaM");
            }
        }
        public string IDManifestacija
        {
            get { return ID; }
            set
            {
                if (ID != value)
                {
                    ID = value;
                    OnPropertyChanged("IDManifestacija");
                }
            }
        }

        public string Dostupno
        {
            get { return dostupnoZaHendikepirane; }
            set
            {
                if (dostupnoZaHendikepirane != value)
                {
                    dostupnoZaHendikepirane = value;
                    OnPropertyChanged("Dostupno");
                }
            }
        }

        public string ImeManifestacija
        {
            get { return ime; }
            set
            {
                if (ime != value)
                {
                    ime = value;
                    OnPropertyChanged("ImeManifestacija");
                }
            }
        }

        public string DozvoljenoPusenje
        {
            get { return pusenje; }
            set
            {
                if (pusenje != value)
                {
                    pusenje = value;
                    OnPropertyChanged("DozvoljenoPusenje");
                }
            }
        }

        public string OdrzavaSe
        {
            get { return odrzavaSe; }
            set
            {
                if (odrzavaSe != value)
                {
                    odrzavaSe = value;
                    OnPropertyChanged("OdrzavaSe");
                }
            }
        }

        public string Katcijena
        {
            get { return kategorijaCijena; }
            set
            {
                if (kategorijaCijena != value)
                {
                    kategorijaCijena = value;
                    OnPropertyChanged("Katcijena");
                }
            }
        }

        public string Alkoholl
        {
            get { return alkohol; }
            set
            {
                if (alkohol != value)
                {
                    alkohol = value;
                    OnPropertyChanged("Alkoholl");
                }
            }
        }


        public string OpisManif
        {
            get { return opis; }
            set
            {
                if (opis != value)
                {
                    opis = value;
                    OnPropertyChanged("OpisManif");
                }
            }
        }

        public DateTime DatumManifest
        {
            get { return datum; }
            set
            {
                if (datum != value)
                {
                    datum = value;
                    OnPropertyChanged("DatumManifest");
                }
            }
        }

        public BitmapImage ikonicaManif
        {
            get
            {
                return ikonica;
            }
            set
            {
                ikonica = value;
                OnPropertyChanged("ikonicaManif");
            }
        }


        public StrukturaTip Tipp
        {
            get { return tip; }
            set
            {
                tip = value;
                OnPropertyChanged("Tipp");
            }
        }

        public bool DobilaSlicicuOdTipa
        {
            get { return dobilaSlicicuOdTipa; }
            set { dobilaSlicicuOdTipa = value; }
        }
    }
}
