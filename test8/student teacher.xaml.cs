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
    /// Interaction logic for student_teacher.xaml
    /// </summary>
    public partial class student_teacher : Page
    {
        my_projectEntities dp = new my_projectEntities();

        public student_teacher()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            stu s = new stu();
            string ss = tea.Text;
            dg.ItemsSource = dp.stus.Where(x => x.teacher == ss ).Select(x=>new{x.namee }).ToList();
        }
    }
}
