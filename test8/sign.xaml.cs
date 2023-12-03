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
    /// Interaction logic for sign.xaml
    /// </summary>
    public partial class sign : Page
    {
        my_projectEntities dp = new my_projectEntities();

        public sign()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            welcome welcome= new welcome();
            stu s = new stu();

            s.age = int.Parse(age.Text);
            s.id = int.Parse(id.Text);
            s.namee = user.Text;
            s.teacher = teacher.Text;
            s.addrese = addr.Text;
            s.grade = grade.Text;
            dp.stus.Add(s);
            dp.SaveChanges();
            this.NavigationService.Navigate(welcome);
        }
    }
}
