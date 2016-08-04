using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using RockMe.Platforms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RockMe.XamlExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        private readonly CultureInfo _cultureInfo;
        const string ResourceId = "RockMe.Resources.AppResource";
        public string Text { get; set; }

        public TranslateExtension ()
        {
            _cultureInfo = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
        }

        public object ProvideValue (IServiceProvider serviceProvider)
        {
            if (Text == null)
                return string.Empty;

            var resmgr = new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly);
            var translation = resmgr.GetString(Text, _cultureInfo);
            if (translation == null)
            {
#if DEBUG
                throw new ArgumentException($"Key '{Text}' was not found in resources '{ResourceId}' for culture '{_cultureInfo.Name}'.", nameof(Text));
#else
                translation = Text; 
#endif
            }
            return translation;
        }
    }
}
