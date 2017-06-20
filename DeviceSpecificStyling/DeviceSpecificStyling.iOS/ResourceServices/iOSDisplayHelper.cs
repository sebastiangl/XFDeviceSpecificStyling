using System;
using UIKit;

namespace DeviceSpecificStyling.iOS.ResourceServices
{
    //See: https://stackoverflow.com/questions/25780283/ios-how-to-detect-iphone-6-plus-iphone-6-iphone-5-by-macro
    public class iOSDisplayHelper
    {
        private static nfloat Width => UIScreen.MainScreen.Bounds.Size.Width;
        private static nfloat Height => UIScreen.MainScreen.Bounds.Size.Height;
        private static nfloat MaxLength => (nfloat) Math.Max(Width, Height);
        private static nfloat MinLength => (nfloat) Math.Min(Width, Height);
        private static bool Zoomed => UIScreen.MainScreen.NativeScale >= UIScreen.MainScreen.Scale;
        private static bool Retina => UIScreen.MainScreen.Scale >= 2.0;
        private static bool Phone => UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
        private static bool CarPlay => UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.CarPlay;
        private static bool Pad => UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad;
        private static bool PhTVone => UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.TV;

        public static iOSDeviceType DeviceType
        {
            get
            {
                if (Phone && MaxLength < 568) return iOSDeviceType.iPhone4;
                if (Phone && MaxLength == 568) return iOSDeviceType.iPhone5;
                if (Phone && MaxLength == 667) return iOSDeviceType.iPhone6;
                if (Phone && MaxLength == 736) return iOSDeviceType.iPhone6Plus;
                return iOSDeviceType.Unknown;
            }
        }
    }

    public enum iOSDeviceType
    {
        iPhone4,
        iPhone5,
        iPhone6,
        iPhone6Plus,
        Unknown
    }
}