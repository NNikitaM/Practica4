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

namespace Zadanie3
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
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(TbNumberN.Text);
                double b = Convert.ToDouble(TbNumberB.Text);
                switch (n)
                {
                    case 1:
                        TextBlockAnswer.Text = $"Ответ:\nДиаметр: {b * 2}\nДлина: {b * 2 * 3.14}\nПлощадь: {3.14 * b * b}";
                        break;
                    case 2:
                        TextBlockAnswer.Text = $"Ответ:\nРадиус: {b / 2}\nДлина: {b * 2 * 3.14}\nПлощадь: {3.14 * Math.Pow(b / 2, 2)}";
                        break;
                    case 3:
                        TextBlockAnswer.Text = $"Ответ:\nРадиус: {b / 2}\nДиаметр: {b * 2}\nПлощадь: {3.14 * Math.Pow(b / (2 * 3.14), 2)}";
                        break;
                    case 4:
                        TextBlockAnswer.Text = $"Ответ:\nРадиус: {b / 2}\nДиаметр: {b * 2}\nДлина: {2 * Math.Sqrt(3.14 * b)}";
                        break;
                    default:
                        TextBlockAnswer.Text = "Неккоректный номер элемента";
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
