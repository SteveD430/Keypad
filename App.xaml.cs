using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Security;

namespace Safe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            Current.MainWindow = new MainWindow();


            /*
             * bool loginSuccessful = false;
           Visibility errorVisibility = Visibility.Hidden;

           User user = null;           
           do
           {
               var dialogue = new LoginDialogue();
               dialogue.Top = Current.MainWindow.Top;
               dialogue.Left = Current.MainWindow.Left;

               dialogue.lblError.Visibility = errorVisibility;
               Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

               if (dialogue.ShowDialog() == true)
               {
                   // Retrieve Username and Password and ensure correct.
                   string userName = dialogue.txtUser.Text;

                   if (this.Users.TryGetValue(userName.ToLowerInvariant(), out user))
                   {
                       if (user.Password == dialogue.txtPassword.Password)
                       {
                           loginSuccessful = true;
                       }
                   }
                   errorVisibility = Visibility.Visible;
               }
               else
               {
                   Current.Shutdown(-1);
               }
           } while (!loginSuccessful);
           */
 
            // If Application Data Exists, then retrieve, if not assume new user.
            string safeFile = Path.Combine(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "QUINTIC"), "SAFE"), "safe.xml");
            if (File.Exists(safeFile))
            {
                UserAccount userAccount = new UserAccount();
            }
            else
            {
                Keypad keypad = new Keypad();
                keypad.TitleLbl.Content = "Enter PassKey";
                keypad.ShowDialog();
            }
            
            // Open main window
            Current.MainWindow.Title = Current.MainWindow.Title + Environment.UserName;
            Current.MainWindow.ShowDialog();
            Current.Shutdown(0);
        }
     }
}
