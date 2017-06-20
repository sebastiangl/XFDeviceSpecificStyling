using System;

namespace DeviceSpecificStyling.ResourceServices
{
    public interface IResourceProvider
    {
        Type GetPlatformSpecificResourceDictionaryType(PageNames pageType);
    }
}