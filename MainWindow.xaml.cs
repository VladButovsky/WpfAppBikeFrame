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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click_Count(object sender, RoutedEventArgs e)
        {
           
            string leg = textBoxLegLength.Text.Trim();
            int Num;
            bool isNum = int.TryParse(leg, out Num);
            if (isNum)
            {
                int leg2 = int.Parse(leg);
                double leg3 = Math.Round(leg2 * 0.662 - 1);
                string result = leg3.ToString();
                resultText.Text = result;
                textBoxLegLength.Background = Brushes.White;
            }
            else 
            { 
                textBoxLegLength.ToolTip = "error"; 
                textBoxLegLength.Background = Brushes.Red;
            }
        }
        

        /*private void Button_Click_Count(object sender, RoutedEventArgs e)
        {
            resultText.Text = Math.Round(int.Parse(textBoxLegLength.Text) * 0.662 - 1).ToString();
        }*/
    }
}
