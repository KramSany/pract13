using pract13.Auth;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private AuthData _authData = new();
        public Menu()
        {
            InitializeComponent();
        }
        
        private void Window_Activated(object sender, EventArgs e)
        {
            

        }

        private void SingIn_Click(object sender, RoutedEventArgs e)
        {
            SignIn singIn = new SignIn(_authData);
            singIn.Owner = this;
            singIn.ShowDialog();
        }

        private void SingUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp window2 = new SignUp(_authData);
            window2.Owner = this;
            window2.ShowDialog();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Close();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
