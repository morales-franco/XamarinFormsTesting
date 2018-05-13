using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.MarkupExtensions
{
    /*
     * Declarando el ContentProperty podemos hacer esto en xaml:
     * Source="{local:EmbeddedImage HelloWorld.Images.sobre-animus1.jpg}"
     * 
     * Sin declararlo tenemos que especificar la property
     * Source="{local:EmbeddedImage ResourceID=HelloWorld.Images.sobre-animus1.jpg}"
     */

    [ContentProperty("ResourceID")]
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceID { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(ResourceID))
                return null;

            return ImageSource.FromResource(ResourceID);
        }
    }
}
