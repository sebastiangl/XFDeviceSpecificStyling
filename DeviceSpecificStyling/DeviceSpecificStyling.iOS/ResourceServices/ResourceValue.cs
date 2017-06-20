using System;
using System.Collections.Generic;

namespace DeviceSpecificStyling.iOS.ResourceServices
{
    public class ResourceValue<T>
    {
        public T iPhone4 { get; set; }
        public T iPhone5 { get; set; }
        public T iPhone6 { get; set; }
        public T iPhone6Plus { get; set; }

        public bool CurrentDeviceHasValue
        {
            get
            {
                switch (iOSDisplayHelper.DeviceType)
                {
                    case iOSDeviceType.iPhone4:
                        return !EqualityComparer<T>.Default.Equals(iPhone4, default(T));
                    case iOSDeviceType.iPhone5:
                        return !EqualityComparer<T>.Default.Equals(iPhone5, default(T));
                    case iOSDeviceType.iPhone6:
                        return !EqualityComparer<T>.Default.Equals(iPhone6, default(T));
                    case iOSDeviceType.iPhone6Plus:
                        return !EqualityComparer<T>.Default.Equals(iPhone6Plus, default(T));
                    case iOSDeviceType.Unknown:
                        return false;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public T CurrentDeviceValue
        {
            get
            {
                switch (iOSDisplayHelper.DeviceType)
                {
                    case iOSDeviceType.iPhone4:
                        return iPhone4;
                    case iOSDeviceType.iPhone5:
                        return iPhone5;
                    case iOSDeviceType.iPhone6:
                        return iPhone6;
                    case iOSDeviceType.iPhone6Plus:
                        return iPhone6Plus;
                    case iOSDeviceType.Unknown:
                        return default(T);
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}