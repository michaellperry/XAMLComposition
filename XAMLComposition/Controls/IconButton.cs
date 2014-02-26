using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XAMLComposition.Controls
{
    public class IconButton : Button
    {
        public const string IconPropertyName = "Icon";

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            IconPropertyName,
            typeof(FrameworkElement),
            typeof(IconButton),
            new PropertyMetadata(null));

        public FrameworkElement Icon
        {
            get
            {
                return (FrameworkElement)GetValue(IconProperty);
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }
    }
}
