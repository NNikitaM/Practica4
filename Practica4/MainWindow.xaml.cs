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

namespace Practica4
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
                int A = Convert.ToInt32(TbNumberA.Text);
                double B = Convert.ToDouble(TbNumberB.Text);
                double res;
                switch (A)
                {
                    case 1: //дециметр
                        res = B / 10;
                        break;
                    case 2: //километр
                        res = B * 1000;
                        break;
                    case 3: //метр
                        res = B;
                        break;
                    case 4: //миллиметр
                        res = B / 1000;
                        break;
                    case 5: //сантиметр
                        res = B / 100;
                        break;
                    default:
                        TextBlockAnswer.Text = $"\nОшибка: неверный номер единицы длины";
                        return;
                }
                TextBlockAnswer.Text = $"Ответ:\nДлина отрезка в метрах: {res}";
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
