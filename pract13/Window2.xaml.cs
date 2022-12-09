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
    public partial class Window2 : Window
    {
        Password user = new();
        public Window2()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if (Login_TB != null || PasswordBox != null) user.Add(Login_TB.Text, PasswordBox.ToString());
            else MessageBox.Show("You dont input login/password.\nPlease, check your data");
            Close();


        }
    }
}
