using System;
using System.Windows.Media;

namespace HappyWaterCarrier.Classes
{
    public static class PopupManager
    {
        private static PopupData Data { get; set; } = new PopupData();
        public static event EventHandler IsOpenChanged;

        /// <summary>
        /// shows the message with Red foreground
        /// </summary>
        /// <param name="errorText"></param>
        public static void OpenErrorPopup(string errorText)
        {
            Data.Text = errorText;
            Data.Foreground = Brushes.Red;
            Data.IsOpen = true;
            IsOpenChanged(Data, EventArgs.Empty);
        }
        /// <summary>
        /// shows the message with DarkGreen foreground
        /// </summary>
        /// <param name="message"></param>
        public static void OpenMessagePopup(string message)
        {
            Data.Text = message;
            Data.Foreground = Brushes.DarkGreen;
            Data.IsOpen = true;
            IsOpenChanged(Data, EventArgs.Empty);
        }
    }
}
