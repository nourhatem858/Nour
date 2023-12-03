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

namespace test8
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        int frirtnum;
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text=="0"&& text.Text != null)
            {
                text.Text = "1";
            }       
            else
            {
                text.Text = text.Text + "1";
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "0" && text.Text != null)
            {
                text.Text = "2";
            }
            else
            {
                text.Text = text.Text + "2";
            }
        }

        private void threa_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "0" && text.Text != null)
            {
                text.Text = "3";
            }
            else
            {
                text.Text = text.Text + "3";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (text.Text == "0" && text.Text != null)
            {
                text.Text = "5";
            }
            else
            {
                text.Text = text.Text + "5";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (text.Text == "0" && text.Text != null)
            {
                text.Text = "6";
            }
            else
            {
                text.Text = text.Text + "6";
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "0" && text.Text != null)
            {
                text.Text = "8";
            }
            else
            {
                text.Text = text.Text + "8";
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "0" && text.Text != null)
            {
                text.Text = "9";
            }
            else
            {
                text.Text = text.Text + "9";
            }
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "0" && text.Text != null)
            {
                text.Text = "0";
            }
            else
            {
                text.Text = text.Text + "0";
            }
        }

        private void fa_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "0" && text.Text != null)
            {
                text.Text = ".";
            }
            else
            {
                text.Text = text.Text + ".";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int x= int .Parse(text.Text);
            text.Text = "0";
           char op= '+';
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(text.Text);
            text.Text = "0";
            char op = '-';
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(text.Text);
            text.Text = "0";
            char op = 'x';
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(text.Text);
            text.Text = "0";
            char op = '/';
        }

        private void eqil_Click(object sender, RoutedEventArgs e)
        {
            double num;
            double result;
            num = double.Parse(text.Text);
            if (num == '+')
            {
                
            }
        }
    }
}
