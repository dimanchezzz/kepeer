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

namespace Course_kepeer_1
{
    /// <summary>
    /// Логика взаимодействия для Style.xaml
    /// </summary>
    public partial class Style : Page
    {
        Border Bord;
        public Style(Border bord)
        {
            InitializeComponent();
            Bord = bord;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation an = new DoubleAnimation();
            an.To = 0;
            an.Duration = TimeSpan.FromSeconds(0.3);
            Bord.BeginAnimation(Border.WidthProperty, an);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            if ( standart.IsChecked==true)
            {
                Resources = new ResourceDictionary() { Source = new Uri("Resources/standart_style.xaml", UriKind.Relative) };
                MessageBox.Show("ok");
            }

        }
    }
}
