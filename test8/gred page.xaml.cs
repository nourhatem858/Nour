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
    /// Interaction logic for gred_page.xaml
    /// </summary>
    public partial class gred_page : Page
    {
        my_projectEntities dp = new my_projectEntities();

        public gred_page()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            stu s = new stu();
            int idd = int.Parse(id.Text);
            dg.ItemsSource = dp.stus.Where(x => x.id ==idd ).Select(x => new { x.grade }).ToList();
        }
    }
}
