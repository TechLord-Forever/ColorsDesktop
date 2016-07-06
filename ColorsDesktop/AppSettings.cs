using System.Net;
using Microsoft.Win32;

namespace ColorsDesktop
{
    public enum PROXY_TYPE
    {
        NONE, SYSTEM, CUSTOM
    }

    public struct Settings
    {
        public PROXY_TYPE proxyType;
        public string proxyAddr; // Only for custom user defined proxies
        public int proxyPort;
    }

    class AppSettings
    {
        public static void SaveSettings(Settings settings)
        {
            RegistryKey mykey = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("ColorsDesktop");
            mykey.SetValue("ProxyType", settings.proxyType, RegistryValueKind.DWord);
            mykey.SetValue("ProxyAddr", settings.proxyAddr);
            mykey.SetValue("ProxyPort", settings.proxyPort);
            mykey.Close();
        }

        public static void ClearSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            if (key.OpenSubKey("ColorsDesktop") != null) key.DeleteSubKey("ColorsDesktop");
            key.Close();
        }

        public static Settings RestoreSettings()
        {
            Settings settings;
            RegistryKey mykey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("ColorsDesktop");

            if (mykey == null)
            {
                settings.proxyType = PROXY_TYPE.SYSTEM;
                settings.proxyAddr = string.Empty;
                settings.proxyPort = 80;
            }
            else
            {
                settings.proxyType = (PROXY_TYPE) mykey.GetValue("ProxyType", PROXY_TYPE.SYSTEM);

                // Assuming data stored in registry has not been tampered
                settings.proxyAddr = (string) mykey.GetValue("ProxyAddr", string.Empty);
                settings.proxyPort = (int) mykey.GetValue("ProxyPort", 80);
                mykey.Close();
            }
            return settings;
        }

        // Settings must be valid
        public static void ApplySettings(Settings settings)
        {
            switch (settings.proxyType)
            {
                case PROXY_TYPE.NONE:
                    WebRequest.DefaultWebProxy = new WebProxy();
                    break;

                case PROXY_TYPE.SYSTEM:
                    WebRequest.DefaultWebProxy = WebRequest.GetSystemWebProxy();
                    break;

                case PROXY_TYPE.CUSTOM:
                    WebRequest.DefaultWebProxy = new WebProxy(settings.proxyAddr, settings.proxyPort);
                    break;
            }
        }
    }
}
