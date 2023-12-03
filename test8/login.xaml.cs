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
using System.Xml.Linq;

namespace test8
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        my_projectEntities dp = new my_projectEntities();
        public login()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            stu s = new stu();
            s = dp.stus.FirstOrDefault(x => x.namee == user.Text);
            s = dp.stus.FirstOrDefault(z => z.passw == pass.Text);
            if (s.namee == user.Text && s.passw == pass.Text)
            {
                welcome w = new welcome();
                this.NavigationService.Navigate(w);
            }
            else
            {
                MessageBox.Show("your acount not falid");
            }
        }
    }
}
