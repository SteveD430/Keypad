using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Safe
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Safe"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Safe;assembly=Safe"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class DiscreteMarkProgressBar : ProgressBar
    {
        static DiscreteMarkProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DiscreteMarkProgressBar), new FrameworkPropertyMetadata(typeof(DiscreteMarkProgressBar)));
        }

        public static readonly DependencyProperty NumberMarksProperty = DependencyProperty.Register("NumberMarks", typeof(System.Int32), typeof(DiscreteMarkProgressBar));
        public static readonly DependencyProperty IsMaxValueProperty = DependencyProperty.Register("IsMaxValue", 
            typeof(System.Boolean), 
            typeof(DiscreteMarkProgressBar), 
            new FrameworkPropertyMetadata(false,
                                           new PropertyChangedCallback(OnIsMaxValueChanged)));
        public static readonly RoutedEvent MaxDigitsSelectedEvent = EventManager.RegisterRoutedEvent("MaxDigitsSelected", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(DiscreteMarkProgressBar));

        public DiscreteMarkProgressBar()
        {
            SnapsToDevicePixels = true;
            Value = 0;
        }

        public int NumberMarks
        {
            get { return (int)GetValue(NumberMarksProperty); }
            set { SetValue(NumberMarksProperty, value); }
        }

        public bool IsMaxValue
        {
            get { return (bool)GetValue(IsMaxValueProperty); }
            set { SetValue(IsMaxValueProperty, value); }
        }

        public event RoutedEventHandler MaxDigitsSelected
        {
            add { AddHandler(MaxDigitsSelectedEvent, value); }
            remove { RemoveHandler(MaxDigitsSelectedEvent, value); } 
        }

        private static void OnIsMaxValueChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            DiscreteMarkProgressBar progressBar = dependencyObject as DiscreteMarkProgressBar;
            if (progressBar != null && progressBar.IsMaxValue)
            {
                RoutedEventArgs rargs = new RoutedEventArgs(MaxDigitsSelectedEvent);
                progressBar.RaiseEvent(rargs);
            }
        }
    }
}
