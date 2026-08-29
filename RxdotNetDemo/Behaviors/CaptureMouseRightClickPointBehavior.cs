using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Input;

namespace RxdotNetDemo.Behaviors
{
    public class CaptureMouseRightClickPointBehavior : Behavior<FrameworkElement>
    {
        public Point Location
        {
            get { return (Point)GetValue(LocationProperty); }
            set { SetValue(LocationProperty, value); }
        }
        public static readonly DependencyProperty LocationProperty =
            DependencyProperty.Register("Location", typeof(Point), typeof(CaptureMouseRightClickPointBehavior), new PropertyMetadata(new Point()));

        protected override void OnAttached()
        {
            AssociatedObject.PreviewMouseRightButtonDown += PreviewMouseRightButtonDown;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.PreviewMouseRightButtonDown -= PreviewMouseRightButtonDown;
        }

        private void PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Location = e.GetPosition(AssociatedObject);
        }
    }
}
