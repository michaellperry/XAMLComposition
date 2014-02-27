using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XAMLComposition.Controls
{
    public class IconButton : Button
    {
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon",
            typeof(object),
            typeof(IconButton),
            new PropertyMetadata(null));

        public object Icon
        {
            get
            {
                return GetValue(IconProperty);
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }
    }
}
