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

namespace Zadanie_1
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(Box1.Text, out double a))
            { MessageBox.Show("Поле только для чисел"); }
            switch (a)
            {
                case 1:
                    Answer.Text += "понедельник";
                    break;
                case 2:
                    Answer.Text += "вторник";
                    break;
                case 3:
                    Answer.Text += "среда";
                    break;
                case 4:
                    Answer.Text += "четверг";
                    break;
                case 5:
                    Answer.Text += "пятница";
                    break;
                case 6:
                    Answer.Text += "суббота";
                    break;
                case 7:
                    Answer.Text += "воскресенье";
                    break;
                default:
                    Answer.Text +=  "Введено неверное число";
                    break;
            }

           
        }
    }
}
