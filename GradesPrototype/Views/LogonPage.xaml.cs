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
using GradesPrototype.Data;
using GradesPrototype.Services;

namespace GradesPrototype.Views
{
    /// <summary>
    /// Interaction logic for LogonPage.xaml
    /// </summary>
    public partial class LogonPage : UserControl
    {
        public LogonPage()
        {
            InitializeComponent();
        }

        #region Event Members
        // TODO: Exercise 1: Task 2a: Define the LogonSuccess event handler
        public event EventHandler LogonSuccess;

        #endregion

        #region Logon Validation

        private void Logon_Click(object sender, RoutedEventArgs e)
        {
            SessionContext.UserName = username.Text;
            SessionContext.UserRole = (bool) userrole.IsChecked ? Role.Teacher : Role.Student;

            if (SessionContext.UserRole == Role.Student) SessionContext.CurrentStudent = "Eric Gruber"; //Always Eric?£

            LogonSuccess(this, null);
        }

        //<TextBlock Grid.Row="0" FontSize= "24" Text= "Username: " />
        //< TextBox x:Name= "username" Grid.Row= "0" Grid.Column= "1" FontSize= "22" />

        //< TextBlock Grid.Row= "1" FontSize= "24" Text= "Password: " />
        //< PasswordBox x:Name= "password" Grid.Row= "1" Grid.Column= "1" FontSize= "22" />


        //< TextBlock Grid.Row= "2" FontSize= "24" Text= "Teacher:" />
        //< CheckBox x:Name= "userrole" Grid.Row= "2"  Grid.Column= "2" FontSize= "24" IsChecked= "False" VerticalAlignment= "Center" />


        // TODO: Exercise 1: Task 2b: Implement the Logon_Click event handler for the Logon button
        // Simulate logging on (no validation or authentication performed yet)

        #endregion
    }
}
