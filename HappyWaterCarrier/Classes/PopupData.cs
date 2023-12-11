using PropertyChanged;
using System.Windows.Media;

namespace HappyWaterCarrier.Classes
{
    [AddINotifyPropertyChangedInterface]
    public class PopupData
    {
        public string Text { get; set; }
        public SolidColorBrush Foreground { get; set; }
        public bool IsOpen { get; set; }
    }
}
