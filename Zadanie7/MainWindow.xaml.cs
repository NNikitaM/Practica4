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

namespace Zadanie7
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
                int b = (n / 10) % 10;
                int c = n % 10;
                string str = "";
                string s = "учебных заданий";
                string s1 = "учебных задания";
                string s2 = "учебное задание";
                switch (b)
                {
                    case 1:
                        switch (c)
                        {
                            case 0:
                                str += " десять " + s;
                                break;
                            case 1:
                                str += " одиннадцать " + s;
                                break;
                            case 2:
                                str += " двенадцать " + s;
                                break;
                            case 3:
                                str += " тринадцать " + s;
                                break;
                            case 4:
                                str += " четырнадцать " + s;
                                break;
                            case 5:
                                str += " пятнадцать " + s;
                                break;
                            case 6:
                                str += " шестнадцать " + s;
                                break;
                            case 7:
                                str += " семнадцать " + s;
                                break;
                            case 8:
                                str += " восемнадцать " + s;
                                break;
                            case 9:
                                str += " девятнадцать " + s;
                                break;
                        }
                        break;
                    case 2:
                        str += " двадцать";
                        break;
                    case 3:
                        str += " тридцать";
                        break;
                    case 4:
                        str += " сорок";
                        break;
                }
                if (b != 1)
                {
                    switch (c)
                    {
                        case 1:
                            str += " одно " + s2;
                            break;
                        case 2:
                            str += " два " + s1;
                            break;
                        case 3:
                            str += " три " + s1;
                            break;
                        case 4:
                            str += " четыре " + s1;
                            break;
                        case 5:
                            str += " пять " + s;
                            break;
                        case 6:
                            str += " шесть " + s;
                            break;
                        case 7:
                            str += " семь " + s;
                            break;
                        case 8:
                            str += " восемь " + s;
                            break;
                        case 9:
                            str += " девять " + s;
                            break; ;
                    }
                }
                TextBlockAnswer.Text = $"Ответ:\n {str}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
