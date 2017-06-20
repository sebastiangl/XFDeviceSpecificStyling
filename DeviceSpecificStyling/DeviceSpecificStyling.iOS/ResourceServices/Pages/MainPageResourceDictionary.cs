using Xamarin.Forms;

namespace DeviceSpecificStyling.iOS.ResourceServices.Pages
{
    class MainPageResourceDictionary : ResourceDictionary
    {
        //TODO: move to XAML
        public MainPageResourceDictionary()
        {
            this.AddValueIfSetForCurrentDevice("TitleFontSize",
               new ResourceValue<double>
               {
                   iPhone5 = 24,
                   iPhone6 = 36,
                   iPhone6Plus = 48
               });
        }
    }
}