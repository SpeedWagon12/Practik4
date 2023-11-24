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

namespace Zadanie_2
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
            if (!double.TryParse(Box2.Text, out double b))
            { MessageBox.Show("Поле только для чисел"); }
            switch (a)

            {
                case 1:
                    switch (a)
                    { 
                case 6:
                    Answer.Text += "шестерка";
                    break;
                case 7:
                    Answer.Text += "семерка";
                    break;
                case 8:
                    Answer.Text += "восьмерка";
                    break;
                case 9:
                    Answer.Text += "девятка";
                    break;
                case 10:
                    Answer.Text += "десятка";
                    break;
                case 11:
                    Answer.Text += "валет";
                    break;
                case 12:
                    Answer.Text += "дама";
                    break;
                case 13:
                    Answer.Text += "король";
                    break;
                case 14:
                    Answer.Text += "туз";
                    break;
                default:
                    Answer.Text += "Введено неверное число";
                    break;
                      }
                    switch (b)
                    {
                        case 6:
                            Answer.Text += "шестерка";
                            break;
                        case 7:
                            Answer.Text += "семерка";
                            break;
                        case 8:
                            Answer.Text += "восьмерка";
                            break;
                        case 9:
                            Answer.Text += "девятка";
                            break;
                        case 10:
                            Answer.Text += "десятка";
                            break;
                        case 11:
                            Answer.Text += "валет";
                            break;
                        case 12:
                            Answer.Text += "дама";
                            break;
                        case 13:
                            Answer.Text += "король";
                            break;
                        case 14:
                            Answer.Text += "туз";
                            break;
                        default:
                            Answer.Text += "Введено неверное число";
                            break;

                    }
            }
}
