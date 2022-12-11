using pract13.Auth;
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

namespace pract13
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp(AuthData authData)
        {
            InitializeComponent();
            AuthData = authData;
        }
        public AuthData AuthData { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            AuthData.AddUser(Login_TB.Text, PasswordBox.ToString());
            Close();


        }
    }
}
