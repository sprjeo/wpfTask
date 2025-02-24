using System.Windows;
using System.Windows.Controls;

namespace CustomControlsLibrary
{
    public partial class DialogHost : UserControl
    {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(DialogHost), new PropertyMetadata(new CornerRadius(0)));

        public static readonly DependencyProperty BackgroundOpacityProperty =
            DependencyProperty.Register("BackgroundOpacity", typeof(double), typeof(DialogHost), new PropertyMetadata(0.4));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public double BackgroundOpacity
        {
            get => (double)GetValue(BackgroundOpacityProperty);
            set => SetValue(BackgroundOpacityProperty, value);
        }

        public DialogHost()
        {
            InitializeComponent();
        }
    }
}
