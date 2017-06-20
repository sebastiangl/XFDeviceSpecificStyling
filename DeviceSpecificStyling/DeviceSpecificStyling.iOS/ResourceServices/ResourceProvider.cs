using System;
using DeviceSpecificStyling.iOS.ResourceServices;
using DeviceSpecificStyling.iOS.ResourceServices.Pages;
using DeviceSpecificStyling.ResourceServices;
using Xamarin.Forms;

[assembly:Dependency(typeof(ResourceProvider))]
namespace DeviceSpecificStyling.iOS.ResourceServices
{
    public class ResourceProvider : IResourceProvider
    {
        public Type GetPlatformSpecificResourceDictionaryType(PageNames pageType)
        {
            switch (pageType)
            {
                case PageNames.MainPage: return typeof(MainPageResourceDictionary);
                default:
                    throw new ArgumentOutOfRangeException(nameof(pageType), pageType, null);
            }
        }
    }
}