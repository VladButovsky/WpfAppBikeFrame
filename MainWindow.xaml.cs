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
//Здесь явно слишком много лишних юзингов

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
           
            string legAsString = textBoxLegLength.Text.Trim(); 
            // А зачем вообще Num? Я оставил чтобы показать что можно обойтись без инициализации выше,
            //как у тебя было. Весь TryParse вообще можно в if запихать
            bool isNum = int.TryParse(leg, out int Num); 
            if (isNum) 
            {
                double leg = Math.Round(int.Parse(legAsString) * 0.662 - 1);
                resultText.Text = leg.ToString();
                textBoxLegLength.Background = Brushes.White;
            }
            else 
            { 
                textBoxLegLength.ToolTip = "error"; 
                textBoxLegLength.Background = Brushes.Red;
            }
        }
    }
}
