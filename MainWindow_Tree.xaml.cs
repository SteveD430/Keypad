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
    public partial class MainWindow_Tree : Window
    {
        public ICollection<AccountGroup> Groups;

        public static string XmlDB = @"c:\users\steve\personal\encodedAccounts.xml";

        public MainWindow_Tree()
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
            SafeDocument.Load(XmlDB);
        }
    }
}
