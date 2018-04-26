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
    /// Логика взаимодействия для Edit_pass.xaml
    /// </summary>
    public partial class Edit_pass : Page
    {
        Border Bord;
        public Edit_pass(Border bord)
        {
            InitializeComponent();
            Bord = bord;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation an = new DoubleAnimation();
            an.To = 0;
            an.Duration = TimeSpan.FromSeconds(0.3);
            Bord.BeginAnimation(Border.WidthProperty, an);
        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(resou.Text);

        }
    }
}
