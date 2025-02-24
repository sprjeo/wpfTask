using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CustomControlsLibrary
{
    public class CustomTextButton : Button
    {
        public static readonly DependencyProperty CustomBackgroundProperty =
            DependencyProperty.Register("CustomBackground", typeof(Brush), typeof(CustomTextButton), new PropertyMetadata(Brushes.LightGray));

        public Brush CustomBackground
        {
            get { return (Brush)GetValue(CustomBackgroundProperty); }
            set { SetValue(CustomBackgroundProperty, value); }
        }

        public static readonly DependencyProperty CustomForegroundProperty =
            DependencyProperty.Register("CustomForeground", typeof(Brush), typeof(CustomTextButton), new PropertyMetadata(Brushes.Black));
        public Brush CustomForeground
        {
            get { return (Brush)GetValue(CustomForegroundProperty); }
            set { SetValue(CustomForegroundProperty, value); }
        }

        public static readonly DependencyProperty CustomFontSizeProperty =
            DependencyProperty.Register("CustomFontSize", typeof(double), typeof(CustomTextButton), new PropertyMetadata(14.0));

        public double CustomFontSize
        {
            get { return (double)GetValue(CustomFontSizeProperty); }
            set { SetValue(CustomFontSizeProperty, value); }
        }

        static CustomTextButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomTextButton), new FrameworkPropertyMetadata(typeof(CustomTextButton)));
        }
    }
    public class CustomImageButton : Button
    {
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(CustomImageButton), new PropertyMetadata(null));

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty XScaleProperty =
            DependencyProperty.Register("XScale", typeof(double), typeof(CustomImageButton), new PropertyMetadata(1.0));

        public double XScale
        {
            get { return (double)GetValue(XScaleProperty); }
            set { SetValue(XScaleProperty, value); }
        }

        public static readonly DependencyProperty YScaleProperty =
            DependencyProperty.Register("YScale", typeof(double), typeof(CustomImageButton), new PropertyMetadata(1.0));

        public double YScale
        {
            get { return (double)GetValue(YScaleProperty); }
            set { SetValue(YScaleProperty, value); }
        }

        static CustomImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomImageButton), new FrameworkPropertyMetadata(typeof(CustomImageButton)));
        }
    }
    public class CustomScrollViewer : ScrollViewer
    {
        public static readonly DependencyProperty ScrollBarColorProperty =
            DependencyProperty.Register("ScrollBarColor", typeof(Brush), typeof(CustomScrollViewer), new PropertyMetadata(Brushes.Gray));

        public Brush ScrollBarColor
        {
            get { return (Brush)GetValue(ScrollBarColorProperty); }
            set { SetValue(ScrollBarColorProperty, value); }
        }

        static CustomScrollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomScrollViewer), new FrameworkPropertyMetadata(typeof(CustomScrollViewer)));
        }
    }


}