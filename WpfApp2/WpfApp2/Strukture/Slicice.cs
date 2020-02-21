using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Strukture
{
    [Serializable]
    class Slicice : INotifyPropertyChanged
    {
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }

        }

        private double x;
        private double y;
        private StrukturaManifestacija manifestacija;

        public Slicice(double x, double y, StrukturaManifestacija manifestacija, double xx, double yy, StrukturaManifestacija mmanifestacija)
        {
            X = x;
            Y = y;
            Manifestacija = manifestacija;
            X = xx;
            Y = yy;
            Manifestacija = mmanifestacija;
        }

        public Slicice(double x, double y, StrukturaManifestacija manifestacija)
        {
            this.x = x;
            this.y = y;
            this.manifestacija = manifestacija;
        }

        public double X
        {
            get { return x; }
            set
            {
                if (x != value)
                {
                    x = value;
                    OnPropertyChanged("X");
                }
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                if (value != y)
                {
                    y = value;
                    OnPropertyChanged("Y");
                }
            }
        }

        public StrukturaManifestacija Manifestacija
        {
            get { return this.manifestacija; }
            set
            {
                if (this.manifestacija != value)
                {
                    manifestacija = value;
                    OnPropertyChanged("Manifestacija");
                }
            }
        }


    }
}
