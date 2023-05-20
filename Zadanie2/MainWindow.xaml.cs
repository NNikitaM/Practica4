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

namespace Zadanie2
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
                string s = "лет";
                string s1 = "год";
                string s2 = "года";
                switch (b)
                {
                    case 2:
                        if (c == 0)
                        { str += " двадцать " + s; }
                        else
                        { str += " двадцать"; }
                        break;
                    case 3:
                        if (c == 0)
                        { str += " тридцать " + s; }
                        else
                        { str += " тридцать"; }
                        break;
                    case 4:
                        if (c == 0)
                        { str += " сорок " + s; }
                        else
                        { str += " сорок"; }
                        break;
                    case 5:
                        if (c == 0)
                        { str += " пятьдесят " + s; }
                        else
                        { str += " пятьдесят"; }
                        break;
                    case 6:
                        if (c == 0)
                        { str += " шестьдесят " + s; }
                        else
                        { str += " шестьдесят"; }
                        break;
                }
                if (b != 1)
                {
                    switch (c)
                    {
                        case 1:
                            str += " один " + s1;
                            break;
                        case 2:
                            str += " два " + s2;
                            break;
                        case 3:
                            str += " три " + s2;
                            break;
                        case 4:
                            str += " четыре " + s2;
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
