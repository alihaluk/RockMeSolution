using System.Globalization;

namespace RockMe.Platforms
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo ();

        void SetLocale ();
    }
}