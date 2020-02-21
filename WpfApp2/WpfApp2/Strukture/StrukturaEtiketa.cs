using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp2.Strukture
{
    [Serializable]
    public class StrukturaEtiketa : INotifyPropertyChanged
    {

        private String ID;
        private String opis;
        [NonSerialized]
        private System.Windows.Media.Color boja;

        [NonSerialized]
        private Brush bojaBoja;

        public Brush ColorBrush
        {
            get { return bojaBoja; }
            set
            {
                bojaBoja = value;

                OnPropertyChanged("ColorBrush");
            }

        }


        private byte prva;
        public byte Prva
        {
            get
            {
                return prva;
            }
            set { prva = value; }
        }
        private byte druga;
        public byte Druga
        {
            get
            {
                return druga;
            }
            set { druga = value; }
        }
        private byte treca;
        public byte Treca
        {
            get
            {
                return treca;
            }
            set { treca = value; }
        }


        public StrukturaEtiketa()
        {
        }

        public StrukturaEtiketa(String idd,String opiss,Color boja)
        {
            this.ID = idd;
            this.opis = opiss;
            this.boja = boja;
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


        public string IDEtiketa
        {
            get { return ID; }
            set
            {
                if (ID != value)
                {
                    ID = value;
                    OnPropertyChanged("IDEtiketa");
                }
            }
        }


        public string OpisEtiketa
        {
            get { return opis; }
            set
            {
                if (opis != value)
                {
                    opis = value;
                    OnPropertyChanged("OpisEtiketa");
                }
            }
        }

        public System.Windows.Media.Color bojaEtiketa
        {
            get { return boja; }
            set
            {
                if (boja != value)
                {
                    boja = value;
                    ColorBrush = new SolidColorBrush(boja);
                    OnPropertyChanged("bojaEtiketa");
                }
            }
        }

    }
}
