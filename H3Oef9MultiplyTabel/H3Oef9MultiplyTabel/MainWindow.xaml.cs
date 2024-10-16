using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H3Oef9MultiplyTabel
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

        StringBuilder sb = new StringBuilder();

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            int x;
            int y;         
            for (x = 1; x <= 12; x++)
            {
                for (y = 1; y <= 12; y++)
                {
                    sb.AppendLine($"{x}*{y} = {x*y}");
                }
            }                       
            resultTextBox.Text = "De Tafels van de vermenigvuldiging:\n\r" + sb.ToString();           
        }
    }
}