using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Strukture
{
   public class pomocnaEtikete:INotifyPropertyChanged
    {

        public string TheText { get; set; }


        //Provide change-notification for IsSelected
        private bool _fIsSelected = false;
        public bool IsSelected
        {
            get { return _fIsSelected; }
            set
            {
                _fIsSelected = value;
                this.OnPropertyChanged("IsSelected");
            }
        }

        #region INotifyPropertyChanged
        protected void OnPropertyChanged(string strPropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(strPropertyName));
        }

        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

