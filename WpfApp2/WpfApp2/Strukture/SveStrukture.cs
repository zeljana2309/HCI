using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Strukture
{
    class SveStrukture : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private static SveStrukture instance = null;

        private ObservableCollection<StrukturaTip> tipovi;
        private ObservableCollection<StrukturaEtiketa> etikete;
        private ObservableCollection<StrukturaManifestacija> manifestacije;
        private ObservableCollection<StrukturaManifestacija> manifestacijeLista;
        private ObservableCollection<Slicice> sliciceManifestacije;

        public ObservableCollection<Slicice> SliciceManifestacije
        {
            get { return this.sliciceManifestacije; }
            set
            {
                if (this.sliciceManifestacije != value)
                {
                    this.sliciceManifestacije = value;
                    OnPropertyChanged("SliciceManifestacije");
                }
            }
        }
        public SveStrukture(ObservableCollection<StrukturaTip> tipovi, ObservableCollection<StrukturaEtiketa> etikete, ObservableCollection<StrukturaManifestacija> manifestacije)
        {
            this.Tipovi = tipovi;
            this.Etikete = etikete;
            this.manifestacije = manifestacije;
        }

        private SveStrukture()
        {
            this.Tipovi = new ObservableCollection<StrukturaTip>();
            this.Etikete = new ObservableCollection<StrukturaEtiketa>();
            this.manifestacije = new ObservableCollection<StrukturaManifestacija>();
            this.manifestacijeLista = new ObservableCollection<StrukturaManifestacija>();
            this.sliciceManifestacije = new ObservableCollection<Slicice>();
        }

        public ObservableCollection<StrukturaTip> Tipovi { get => tipovi; set => tipovi = value; }
        public ObservableCollection<StrukturaEtiketa> Etikete { get => etikete; set => etikete = value; }

        public ObservableCollection<StrukturaManifestacija> ManifestacijeLista
        {
            get { return this.manifestacijeLista; }
            set
            {
                if (this.manifestacijeLista != value)
                {
                    this.manifestacijeLista = value;
                    OnPropertyChanged("ManifestacijeLista");
                }
            }
        }
       
        public static SveStrukture Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SveStrukture();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

       

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
                
            }
        }
    }

    
}
