using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
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
using System.Xml;

namespace Safe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ICollection<AccountGroup> Groups;

        public static string XmlDB = @"c:\users\steve\personal\encodedAccounts.xml";

        public MainWindow()
        {
            InitializeComponent();
            Groups = new List<AccountGroup>();

            Populate();
        }

        public XmlDocument SafeDocument { get; set; }

        private void txtViewer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Populate()
        {
            SafeDocument = new XmlDocument();
           // SafeDocument.Load(XmlDB);
        }

#region CommandBinding Actions
        //Command Binding Actions
        public void NewCommandExecuted(object o, RoutedEventArgs e)
        {
        }

        public void NewCommandCanExecute(object o, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void OpenCommandExecuted(object o, RoutedEventArgs e)
        {
        }

        public void OpenCommandCanExecute(object o, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void CloseCommandExecuted(object o, RoutedEventArgs e)
        {
        }

        public void CloseCommandCanExecute(object o, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void ExitCommandExecuted(object o, RoutedEventArgs e)
        {
        }

        public void ExitCommandCanExecute(object o, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void CutCommandExecuted(object o, RoutedEventArgs e)
        {
        }

        public void CutCommandCanExecute(object o, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void CopyCommandExecuted(object o, RoutedEventArgs e)
        {
        }

        public void CopyCommandCanExecute(object o, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void PasteCommandExecuted(object o, RoutedEventArgs e)
        {
        }

        public void PasteCommandCanExecute(object o, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void HelpCommandExecuted(object o, RoutedEventArgs e)
        {
        }

        public void HelpCommandCanExecute(object o, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
#endregion CommandBinding Actions

    }
}
