using System;
using System.Globalization;
using Windows.Globalization;
using RockMe.Platforms;

namespace RockMe.UWP.Platforms
{
    public class LocalizeUwp : ILocalize
    {
        public CultureInfo GetCurrentCultureInfo ()
        {
            ApplicationLanguages.PrimaryLanguageOverride = "tr";
            return CultureInfo.CurrentUICulture;
        }

        public void SetLocale ()
        {
            throw new NotImplementedException();
        }
    }
}
