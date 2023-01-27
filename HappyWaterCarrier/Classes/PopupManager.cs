using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HappyWaterCarrier.Classes
{
    [AddINotifyPropertyChangedInterface]
    public static class PopupManager
    {
        private static bool isOpen;
        public static bool IsOpen
        {
            get { return isOpen; }
            set
            {
                isOpen = value;
                if (IsOpenChanged != null)
                {
                    IsOpenChanged(IsOpen, EventArgs.Empty);
                }
            }
        }
        public static event EventHandler IsOpenChanged;
    }
}
