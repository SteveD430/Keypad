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
    /// Interaction logic for Keypad.xaml
    /// </summary>
    public partial class Keypad : Window
    {
        public static readonly DependencyProperty DigitCountProperty = DependencyProperty.Register("DigitCount", typeof(System.Int32), typeof(Keypad));

        public int DigitCount
        {
            get { return (int)GetValue(DigitCountProperty); }
            set { SetValue(DigitCountProperty, value); }
        }
        public Keypad()
        {
            DigitCount = 0;
            InitializeComponent();
            discreteMarkProgressBar.MaxDigitsSelected += new RoutedEventHandler(OnMaxDigitsSelected);
        }
        public void Btn0_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void Btn2_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void Btn3_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void Btn4_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void Btn5_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void Btn6_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void Btn7_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void Btn8_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void Btn9_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount++;
        }
        public void BtnDel_OnClick(object sender, RoutedEventArgs e)
        {
            DigitCount--;
        }

        private void OnMaxDigitsSelected(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
