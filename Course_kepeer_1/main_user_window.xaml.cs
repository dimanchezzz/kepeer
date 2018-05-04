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
using System.Windows.Shapes;
using System.Security.Cryptography;
using MahApps.Metro.Controls;

namespace Course_kepeer_1
{
    /// <summary>
    /// Логика взаимодействия для main_user_window.xaml
    /// </summary>
    public partial class main_user_window : MetroWindow
    {

        

        private static User_info thisuser;
        
        public main_user_window(User_info user)
        {
          
            InitializeComponent();
            Thisuser = user;
            date.Content = Thisuser.Login;
        }

        public static User_info Thisuser
        {
            get
            {
                return thisuser;
            }

            set
            {
                thisuser = value;
            }
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User.Content = new Add_pass();
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            User.Content = new Add_pass();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            main_user.Close();

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            User.Content = new My_password();

        }

        private void Mouse_move(object sender, MouseEventArgs e)
        {
            date.FontFamily = new FontFamily("Century Gothic");
        }

        private void leave(object sender, MouseEventArgs e)
        {
            date.FontFamily = new FontFamily("Italic");
        }

        private void clack(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to change the user?", "Question", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result==MessageBoxResult.OK)
            {
                MainWindow man = new MainWindow();
                man.Show();
                Close();
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            User.Content = new Setting();
        }
        private MetroWindow accentThemeTestWindow;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (accentThemeTestWindow != null)
            {
                accentThemeTestWindow.Activate();
                return;
            }

            accentThemeTestWindow = new AccentStyleWindow();
            accentThemeTestWindow.Owner = this;
            accentThemeTestWindow.Closed += (o, args) => accentThemeTestWindow = null;
            accentThemeTestWindow.Left = this.Left + this.ActualWidth / 2.0;
            accentThemeTestWindow.Top = this.Top + this.ActualHeight / 2.0;
            accentThemeTestWindow.Show();

        }
    }
}
