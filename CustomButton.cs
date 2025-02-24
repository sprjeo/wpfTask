using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CustomControlsLibrary
{
    public class CustomButton : Button
    {
        // Зависимое свойство для фона кнопки
        public static readonly DependencyProperty ButtonBackgroundProperty =
            DependencyProperty.Register("ButtonBackground", typeof(Brush), typeof(CustomButton), new PropertyMetadata(Brushes.LightGray));

        public Brush ButtonBackground
        {
            get { return (Brush)GetValue(ButtonBackgroundProperty); }
            set { SetValue(ButtonBackgroundProperty, value); }
        }

        // Зависимое свойство для цвета шрифта
        public static readonly DependencyProperty FontColorProperty =
            DependencyProperty.Register("FontColor", typeof(Brush), typeof(CustomButton), new PropertyMetadata(Brushes.Black));

        public Brush FontColor
        {
            get { return (Brush)GetValue(FontColorProperty); }
            set { SetValue(FontColorProperty, value); }
        }

        // Зависимое свойство для размера шрифта
        public static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(CustomButton), new PropertyMetadata(12.0));

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        // Конструктор
        static CustomButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomButton), new FrameworkPropertyMetadata(typeof(CustomButton)));
        }
    }
}
