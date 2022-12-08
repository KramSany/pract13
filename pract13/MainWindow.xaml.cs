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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MatrixCool;


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
        MatrixM<int> matrix = new MatrixM<int>(0, 0);
        
        private void Fill_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Row_TextBox.Text, out int rows))
            {
                MessageBox.Show("Введите числовое значение");
                Row_TextBox.Clear();
                return;

            }
            if (!int.TryParse(Column_TextBox.Text, out int column))
            {
                MessageBox.Show("Введите числовое значение");
                Column_TextBox.Clear();
                return;

            }
            ExtensionMatrix.Create(matrix, rows, column);
            DataGrid.ItemsSource = matrix.ToDataTable().DefaultView;

        }

        private void Solving_Click(object sender, RoutedEventArgs e)
        {
            if (Row_TextBox.Text != String.Empty && Column_TextBox.Text != String.Empty)
            {
                MatrixM<double> results = new MatrixM<double>(matrix.RowCount, matrix.ColumnCount);
                results = ExtensionMatrix.Solving(matrix);
                ListBox.ItemsSource = results.ToDataTable().DefaultView;
            }
            else MessageBox.Show("You are not add Row or Column. Check setting");
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddRange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            matrix.Deserialize();
            DataGrid.ItemsSource = matrix.ToDataTable().DefaultView;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
                matrix.Serialize();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
