﻿using System;
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
using System.Text.RegularExpressions;


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
            onEnable += Isena;     
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
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
          
                tmp = "";
                char nchar;
                for (int i = 97; i < 123; i++)
                {
                    nchar = (char)i;
                    tmp += Convert.ToString(nchar);
                }
                dic += tmp;
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
            if (Regex.IsMatch(password.Text, register.pattern))
            {
                MessageBox.Show("Invalid Password format");
                password.Clear();
                return;
            }
            else
            {
                Coding cod = new Coding();
                using (First_model db = new First_model())
                {
                    Resource_info rs = new Resource_info
                    {

                        Resource = Res.Text,
                        Login_resource = Log_res.Text,
                        Password_resource = cod.Encode(password.Text),
                        User = main_user_window.Thisuser.Login,
                        User_id = main_user_window.Thisuser.Id
                    };
                    db.Resource_info.Add(rs);
                    db.SaveChanges();
                    MessageBox.Show("ok");
                    Res.Clear();
                    Log_res.Clear();
                    password.Clear();
                }
            }
        }
        public void Isena()
        {
            if(Log_res.Text=="" || Res.Text=="" ||password.Text=="")
            {
                add.IsEnabled = false;

            }
            else
            {
                add.IsEnabled = true;
            }
        }
        public delegate void MethodContainer();
        public static event MethodContainer onEnable;
        private void Res_SelectionChanged(object sender, RoutedEventArgs e)
        {
            onEnable();

        }     
    }
}

