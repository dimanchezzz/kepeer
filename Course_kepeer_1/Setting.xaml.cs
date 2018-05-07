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
using System.Windows.Media.Animation;
using MahApps.Metro.Controls;
using MahApps.Metro;

namespace Course_kepeer_1
{
    /// <summary>
    /// Логика взаимодействия для Setting.xaml
    /// </summary>
    public partial class Setting : Page
    {
        public Setting()
        {
            InitializeComponent();
        }
        public delegate void style();
        public static event style onstyleclick;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            onstyleclick();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            my_passframe.Content = new Reset_main(border1);
            DoubleAnimation an = new DoubleAnimation();
            an.To = 300;
            an.Duration = TimeSpan.FromSeconds(0.3);
            border1.BeginAnimation(Border.WidthProperty, an);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Delete_User del = new Delete_User();
                del.Show();
        }
    }
}
