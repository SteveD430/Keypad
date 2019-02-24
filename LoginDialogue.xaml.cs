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
using System.Windows.Shapes;
using System.Security;

namespace Safe
{
    /// <summary>
    /// Interaction logic for LoginDialogue.xaml
    /// </summary>
    public partial class LoginDialogue : Window
    {
        public LoginDialogue()
        {
            InitializeComponent();
        }

        public void BtnEnter_OnClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
