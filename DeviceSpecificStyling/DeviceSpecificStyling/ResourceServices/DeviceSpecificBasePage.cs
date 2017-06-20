using Xamarin.Forms;

namespace DeviceSpecificStyling.ResourceServices
{
    public class DeviceSpecificBasePage : ContentPage
    {
        private PageNames pageName = PageNames.None;

        private void UpdateResources()
        {
            var resourceProvider = DependencyService.Get<IResourceProvider>();
            if (resourceProvider != null)
            {
                Resources.MergedWith = resourceProvider.GetPlatformSpecificResourceDictionaryType(PageName);
            }
        }

        public PageNames PageName
        {
            get => pageName;
            set
            {
                pageName = value;
                UpdateResources();
            }
        }
    }
}