using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Internals;
namespace laboratorio5
{
    [Preserve(AllMembers = true)]
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;
            // Realiza aquí tu búsqueda de traducción utilizando el método que prefieras.
            var imageSource = ImageSource.FromResource(Source, 
                typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}

