using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для Reset_main.xaml
    /// </summary>
    /// 
    public partial class Reset_main : Page, INotifyPropertyChanged
    {
        Border Bord;
        public Reset_main(Border bord)
        {
            isEnable += Isena;
            InitializeComponent();
            Bord = bord;
            DataContext = this;
        }
        public delegate void MethodCHeck();
        public static event MethodCHeck isEnable;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public void Isena()
        {
            if (log.Text == "" || res.Text == "" )

            {
                sav.IsEnabled = false;

            }
            else
            {
                sav.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validation.GetHasError(log) == true || Validation.GetHasError(res))
            {
                MessageBox.Show("Incorrectly filled data!");
                return;
            }
            else if (log.Text != res.Text)
            {
                MessageBox.Show("Passwords do not match!");
                log.Clear();
                res.Clear();
                return;
            }
            else
            {


                using (First_model db = new First_model())
                {
           
                    IEnumerable<User_info> users = db.User_info.Where(u => u.Login.Equals(main_user_window.Thisuser.Login));
                    User_info user = users.FirstOrDefault<User_info>();
                    user.Password = Hash.GetHash(log.Text);
                    MessageBoxResult result = MessageBox.Show("Do you want to change the user?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        db.SaveChanges();
                        MessageBox.Show("ok", "Message");

                    }
                    else
                    {
                        log.Clear();
                        res.Clear();
                        return;
                    }
                        
                   


                   
                }
            }

        }

        private void res_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
            else if (e.Key == Key.Enter)
            {
                e.Handled = true;
            }

        }

        private void res_SelectionChanged(object sender, RoutedEventArgs e)
        {
            isEnable();

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation an = new DoubleAnimation();
            an.To = 0;
            an.Duration = TimeSpan.FromSeconds(0.3);
            Bord.BeginAnimation(Border.WidthProperty, an);
        }
    }
}
