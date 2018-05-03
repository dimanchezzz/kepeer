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

namespace Course_kepeer_1
{
    /// <summary>
    /// Логика взаимодействия для Reset_main.xaml
    /// </summary>
    /// 
    public partial class Reset_main : Page
    {
        Border Bord;
        public Reset_main(Border bord)
        {
            InitializeComponent();
            Bord = bord;
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
                    db.SaveChanges();


                    MessageBox.Show("ok", "Message");
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

        
    }
}
