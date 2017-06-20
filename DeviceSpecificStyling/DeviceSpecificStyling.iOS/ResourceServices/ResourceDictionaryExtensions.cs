using Xamarin.Forms;

namespace DeviceSpecificStyling.iOS.ResourceServices
{
    public static class ResourceDictionaryExtensions
    {
        public static void AddValueIfSetForCurrentDevice<T>(this ResourceDictionary that, string key, ResourceValue<T> value)
        {
            if (value.CurrentDeviceHasValue)
                that.Add(key, value.CurrentDeviceValue);
        }
    }
}