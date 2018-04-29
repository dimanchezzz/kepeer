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

namespace Course_kepeer_1
{
    /// <summary>
    /// Логика взаимодействия для main_user_window.xaml
    /// </summary>
    public partial class main_user_window : Window
    {
      
        private static User_info thisuser;
        
      //  private static byte[] keys=ASCIIEncoding.ASCII.GetBytes(Thisuser.Login.ToString());
        public main_user_window(User_info user)
        {
            InitializeComponent();
            Thisuser = user;
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
    }
}
