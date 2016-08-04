using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;

namespace RockMe.Platforms
{
    public class Localize
    {
        private static readonly CultureInfo CultureInfo;
        private static readonly ResourceManager ResourceManager;

        static Localize ()
        {
            CultureInfo = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            ResourceManager = new ResourceManager("RockMe.Resx.AppResources", typeof(Localize).GetTypeInfo().Assembly);
        }

        public static string GetString (string key)
        {
            return  ResourceManager.GetString(key, CultureInfo);
        }
    }
}
