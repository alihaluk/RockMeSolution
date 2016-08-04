using System;
using System.Globalization;
using Xamarin.Forms;

[assembly: Dependency(typeof(RockMe.Droid.Platforms.LocalizeDroid))]

namespace RockMe.Droid.Platforms
{
    public class LocalizeDroid : RockMe.Platforms.ILocalize
    {
        public CultureInfo GetCurrentCultureInfo ()
        {
            var androidLocale = Java.Util.Locale.Default;
            //var netLanguage = androidLocale.ToString().Replace("_", "-"); // turns pt_BR into pt-BR
            var netLanguage = "tr-TR";
            return new CultureInfo(netLanguage);
        }

        public void SetLocale ()
        {
            throw new NotImplementedException();
        }
    }
}