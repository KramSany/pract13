using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MatrixCool;
using pract13.Auth;

namespace pract13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
       private Auth.AuthData _authData = new();
        MatrixM<int> matrix = new MatrixM<int>(0, 0);
        
        
        private void Solving_Click(object sender, RoutedEventArgs e)
        {
                MatrixM<double> results = new MatrixM<double>(matrix.RowCount, matrix.ColumnCount);
                results = ExtensionMatrix.Solving(matrix);
                DataGridResults.ItemsSource = results.ToDataTable().DefaultView;
        }


        private void Open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamReader streamReader = new("config1.ini");
                using (streamReader)
                {
                    int rowCount = Convert.ToInt32(streamReader.ReadLine());
                    int columnCount = Convert.ToInt32(streamReader.ReadLine());

                    matrix = new MatrixM<int>(rowCount, columnCount);
                    matrix.Create(rowCount, columnCount);
                    DataGrid.ItemsSource = matrix.ToDataTable().DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Menu pas = new Menu();
            pas.Owner = this;
            pas.ShowDialog();

        }

        private void SizeMatrix_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new();
            settings.Owner = this;
            settings.ShowDialog();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = null;
            DataGridResults.ItemsSource = null;
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dev: Polivoda A.A");
        }
    }
}
