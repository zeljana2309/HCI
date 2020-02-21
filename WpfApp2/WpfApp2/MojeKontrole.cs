using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WpfApp2
{
    public static class MojeKontrole
    {
        public static readonly RoutedUICommand KreirajTip = new RoutedUICommand(
            "Kreiraj Tip",
            "KreirajTip",
            typeof(MojeKontrole),
            new InputGestureCollection()
            {
                new KeyGesture(Key.T, ModifierKeys.Control),
            }
            );

        public static readonly RoutedUICommand KreirajManifestaciju = new RoutedUICommand(
           "Kreiraj manifestaciju",
           "KreirajManifestaciju",
           typeof(MojeKontrole),
           new InputGestureCollection()
           {
                new KeyGesture(Key.M, ModifierKeys.Control),
           }
           );

        public static readonly RoutedUICommand KreirajEtiketu = new RoutedUICommand(
           "Kreiraj Etiketu",
           "KomandaEtiketu",
           typeof(MojeKontrole),
           new InputGestureCollection()
           {
                new KeyGesture(Key.E, ModifierKeys.Control),
           }
           );

    }
}

