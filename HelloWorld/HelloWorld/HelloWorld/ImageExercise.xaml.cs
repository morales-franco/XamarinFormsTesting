using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageExercise : ContentPage
    {
        private Dictionary<string, bool> _images = new Dictionary<string, bool>();

        public ImageExercise()
        {
            InitializeComponent();
            LoadImageDictionary();

            image.Source = new UriImageSource()
            {
                Uri = GetNextImage(),
                CachingEnabled = false
            };
        }

        private void LoadImageDictionary()
        {
            _images.Add("https://cdn.britannica.com/700x450/25/180825-004-F51CFBFE.jpg", false);
            _images.Add("https://www.volvooceanrace.com/static/assets/2017-18/cropped/1004/m100339_crop11005_1440x1440_148847964505CD.jpg", false);
            _images.Add("http://www.aucklandtourism.co.nz/img/1511310556Homepage%20Image.jpg", false);
            _images.Add("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSmhSZKGm5jqgDKcgW81asHWo1RHywc-y4gs9__RijatlU6xGYk", false);


        }

        private Uri GetNextImage()
        {
            var nextUri = string.Empty;

            if (!_images.Any(i => i.Value))
            {
                nextUri = _images.FirstOrDefault().Key;
                _images[nextUri] = true;
                return new Uri(nextUri);
            }

            var currentImage = _images.FirstOrDefault(i => i.Value);
            var nextKey = 0;
            for (int i = 0; i < _images.Keys.Count; i++)
            {
                _images[_images.Keys.ElementAt(i)] = false;

                if (_images.Keys.ElementAt(i) == currentImage.Key && i < _images.Keys.Count - 1)
                    nextKey = i + 1;

            }

            var nextImage = _images.FirstOrDefault(i => i.Key == _images.Keys.ElementAt(nextKey));
            nextUri = nextImage.Key;
            _images[nextUri] = true;

            return new Uri(nextUri);
        }

        private void ButtonRight_Clicked(object sender, EventArgs e)
        {
            image.Source = new UriImageSource()
            {
                Uri = GetNextImage(),
                CachingEnabled = false
            };
        }

        private void ButtonLeft_Clicked(object sender, EventArgs e)
        {
            image.Source = new UriImageSource()
            {
                Uri = GetPreviousImage(),
                CachingEnabled = false
            };
        }

        private Uri GetPreviousImage()
        {
            var prevUri = string.Empty;

            var currentImage = _images.FirstOrDefault(i => i.Value);
            var prevKey = 0;
            for (int i = 0; i < _images.Keys.Count; i++)
            {
                _images[_images.Keys.ElementAt(i)] = false;

                if (_images.Keys.ElementAt(i) == currentImage.Key)
                    prevKey = i - 1;

            }

            var nextImage = _images.FirstOrDefault(i => i.Key == _images.Keys.ElementAt(prevKey < 0 ? _images.Count -1 : prevKey));
            prevUri = nextImage.Key;
            _images[prevUri] = true;

            return new Uri(prevUri);
        }
    }
}