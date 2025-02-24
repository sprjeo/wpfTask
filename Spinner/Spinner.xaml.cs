using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CustomControlsLibrary
{
    public partial class Spinner : UserControl
    {
        public static readonly DependencyProperty CircleCountProperty =
            DependencyProperty.Register("CircleCount", typeof(int), typeof(Spinner), new PropertyMetadata(5));

        public static readonly DependencyProperty CircleColorProperty =
            DependencyProperty.Register("CircleColor", typeof(Brush), typeof(Spinner), new PropertyMetadata(Brushes.Blue));

        public static readonly DependencyProperty CircleSizeProperty =
            DependencyProperty.Register("CircleSize", typeof(double), typeof(Spinner), new PropertyMetadata(20.0));

        public static readonly DependencyProperty RotationSpeedProperty =
            DependencyProperty.Register("RotationSpeed", typeof(double), typeof(Spinner), new PropertyMetadata(1.0));

        public static readonly DependencyProperty IsClockwiseProperty =
            DependencyProperty.Register("IsClockwise", typeof(bool), typeof(Spinner), new PropertyMetadata(true));

        private double angle = 0;
        private DispatcherTimer timer;

        public int CircleCount
        {
            get => (int)GetValue(CircleCountProperty);
            set => SetValue(CircleCountProperty, value);
        }

        public Brush CircleColor
        {
            get => (Brush)GetValue(CircleColorProperty);
            set => SetValue(CircleColorProperty, value);
        }

        public double CircleSize
        {
            get => (double)GetValue(CircleSizeProperty);
            set => SetValue(CircleSizeProperty, value);
        }

        public double RotationSpeed
        {
            get => (double)GetValue(RotationSpeedProperty);
            set => SetValue(RotationSpeedProperty, value);
        }

        public bool IsClockwise
        {
            get => (bool)GetValue(IsClockwiseProperty);
            set => SetValue(IsClockwiseProperty, value);
        }

        public Spinner()
        {
            InitializeComponent();
            Loaded += Spinner_Loaded;
        }

        private void Spinner_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < CircleCount; i++)
            {
                var circle = new Ellipse
                {
                    Fill = CircleColor,
                    Width = CircleSize,
                    Height = CircleSize
                };
                Circles.Items.Add(circle);
            }

            // Настройка таймера
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(16); 
            timer.Tick += OnTimerTick;
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            angle += (IsClockwise ? 1 : -1) * RotationSpeed;
            double radius = 70; // Радиус вращения

            for (int i = 0; i < Circles.Items.Count; i++)
            {
                var circle = (Ellipse)Circles.Items[i];
                double circleAngle = angle + (360.0 / CircleCount) * i; 
                double x = (Width / 2) + radius * Math.Cos(circleAngle * Math.PI / 180);
                double y = (Height / 2) + radius * Math.Sin(circleAngle * Math.PI / 180); 

                Canvas.SetLeft(circle, x - CircleSize / 2);
                Canvas.SetTop(circle, y - CircleSize / 2);
            }
        }
    }
}
