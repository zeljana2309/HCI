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
    public class StrukturaTip : INotifyPropertyChanged
    {
        private String ID;
        private String ime;
        private String opis;
        [NonSerialized]
        private BitmapImage ikonica;
        private string putanjaIkonice;
       
       

        public string putanjaT
        {
            get { return putanjaIkonice; }
            set { putanjaIkonice = value; }
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
        
        public StrukturaTip(String ID,String ime,String opis, BitmapImage ikonica,String iPutanja)
        {
            this.ID = ID;
            this.ime = ime;
            this.opis = opis;
            this.ikonica = ikonica;
            this.putanjaIkonice = iPutanja;
            

        }

        public StrukturaTip()
        {
           
        }

        public string IDD
        {
            get { return ID; }
            set
            {
                if (ID != value)
                {
                    ID = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        public string Ime
        {
            get { return ime; }
            set
            {
                if (ime != value)
                {
                    ime = value;
                    OnPropertyChanged("Ime");
                }
            }
        }


        public string Opis
        {
            get { return opis; }
            set
            {
                if (opis != value)
                {
                    opis = value;
                    OnPropertyChanged("Opis");
                }
            }
        }

        public BitmapImage Ikonica
        {
            get { return ikonica; }
            set
            {
                if (ikonica != value)
                {
                    ikonica = value;
                    OnPropertyChanged("Ikonica");
                }
            }
        }


    }

}
