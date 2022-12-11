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
    /// Логика взаимодействия для SingIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn(AuthData authData)
        {
            InitializeComponent();
            AuthData = authData;
        }
        public AuthData AuthData { get; set; }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
           if(!AuthData.Authorization(Login_TB.Text, PasswordBox.ToString()))
           {
               MessageBox.Show("Вы ввели неверные данные");
               return;
           }
            Owner.Close();
            
        }
    }
}
