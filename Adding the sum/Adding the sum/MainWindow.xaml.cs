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

namespace Adding_the_sum
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WriteHello("Привет, ну давай посчитаем!");
        }

        public void AddingSum()
        {
            double result;
            double sum1 = Convert.ToDouble(tbSum1.Text);
            double sum2 = Convert.ToDouble(tbSum2.Text);

            result = sum1 + sum2;
            MessageBox.Show($"Результат: {result}");
        }

        public static void WriteHello(string str)
        {
            MessageBox.Show(str);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddingSum();
        }
    }
}
