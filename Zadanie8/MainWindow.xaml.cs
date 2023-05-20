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

namespace Zadanie8
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
                int a = n / 100;
                int b = (n / 10) % 10;
                int c = n % 10;
                string str = "";
                switch (a)
                {
                    case 1:
                        str += "сто";
                        break;
                    case 2:
                        str += "двести";
                        break;
                    case 3:
                        str += "триста";
                        break;
                    case 4:
                        str += "четырести";
                        break;
                    case 5:
                        str += "пятьсот";
                        break;
                    case 6:
                        str += "шестьсот";
                        break;
                    case 7:
                        str += "семьсот";
                        break;
                    case 8:
                        str += "восемьсот";
                        break;
                    case 9:
                        str += "девятьсот";
                        break;
                }
                switch (b)
                {
                    case 1:
                        switch (c)
                        {
                            case 0:
                                str += " десять";
                                return;
                            case 1:
                                str += " одиннадцать";
                                return;
                            case 2:
                                str += " двенадцать";
                                return;
                            case 3:
                                str += " тринадцать";
                                return;
                            case 4:
                                str += " четырнадцать";
                                return;
                            case 5:
                                str += " пятнадцать";
                                return;
                            case 6:
                                str += " шестнадцать";
                                return;
                            case 7:
                                str += " семнадцать";
                                return;
                            case 8:
                                str += " восемнадцать";
                                return;
                            case 9:
                                str += " девятнадцать";
                                return;
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
                    case 5:
                        str += " пятьдесят";
                        break;
                    case 6:
                        str += " шестьдесят";
                        break;
                    case 7:
                        str += " семьдесят";
                        break;
                    case 8:
                        str += " восемдесят";
                        break;
                    case 9:
                        str += " девяносто";
                        break;
                }
                if (b != 1)
                {
                    switch (c)
                    {
                        case 1:
                            str += " один";
                            break;
                        case 2:
                            str += " два";
                            break;
                        case 3:
                            str += " три";
                            break;
                        case 4:
                            str += " четыре";
                            break;
                        case 5:
                            str += " пять";
                            break;
                        case 6:
                            str += " шесть";
                            break;
                        case 7:
                            str += " семь";
                            break;
                        case 8:
                            str += " восемь";
                            break;
                        case 9:
                            str += " девять";
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
