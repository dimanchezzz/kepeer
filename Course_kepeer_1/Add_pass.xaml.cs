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
using System.ComponentModel;

namespace Course_kepeer_1
{
    /// <summary>
    /// Логика взаимодействия для Add_pass.xaml
    /// </summary>
    public partial class Add_pass : Page
    {
        public Add_pass()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // ((Slider)sender).SelectionEnd = e.NewValue;
            string dic = "";
            string tmp = "";
            if(AZ.IsChecked==true)
            {
                char nvchar;
                for (int i=65;i<91;i++)
                {
                    nvchar = (char)i;
                    tmp += Convert.ToString(nvchar);
                }
                dic += tmp;
            }
            if (zero.IsChecked==true)
            {
                dic += "0123456789";
            }
            //if(az.IsChecked==true)
            //{
                tmp = "";
                char nchar;
                for (int i = 97; i < 123; i++)
                {
                    nchar = (char)i;
                    tmp += Convert.ToString(nchar);
                }
                dic += tmp;
            //}
            string pass = "";
            Random mran = new Random();
            for(int i=0;i<slValue.Value;i++)
            {
                int index = Convert.ToInt16(mran.NextDouble() * dic.Length) % dic.Length;
                char ScharS = dic[index];
                pass += Convert.ToString(ScharS);
            }
            password.Text = pass;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (First_model db = new First_model())
            {
                Resource_info rs = new Resource_info
                {
                    Resource = Res.Text,
                    Login_resource = Log_res.Text,
                    Password_resource = password.Text,
                    User = main_user_window.Thisuser.Login,
                    User_id=main_user_window.Thisuser.Id
                    


                };
                db.Resource_info.Add(rs);
                db.SaveChanges();
                MessageBox.Show("ok");
                

            }

        }

        private void Log_res_TextChanged(object sender, TextChangedEventArgs e)
        {
             if ( String.IsNullOrEmpty(Log_res.Text))
            {
                
            }

        }
    }
}

