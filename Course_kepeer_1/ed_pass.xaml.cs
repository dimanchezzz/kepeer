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
using System.Text.RegularExpressions;


namespace Course_kepeer_1
{
    /// <summary>
    /// Логика взаимодействия для ed_pass.xaml
    /// </summary>
    public partial class ed_pass : Page
    {
        Resource_info info;
        public ed_pass(Resource_info Info)
        {
            isEnable += Isena;
            Coding cod = new Coding();
            InitializeComponent();
            info = Info;
            resou.Text = Info.Resource;
            log.Text = Info.Login_resource;
            pass.Text =cod.Decode(Info.Password_resource);
          
        }
        public delegate void MethodCHeck();
        public static event MethodCHeck isEnable;
        public void Isena()
        {
            if (log.Text == "" || pass.Text == "" || resou.Text == "")

            {
                save.IsEnabled = false;

            }
            else
            {
                save.IsEnabled = true;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(pass.Text, register.pattern))
            {
                MessageBox.Show("Invalid password format");
                pass.Clear();
                return;
            }
          using (First_model db = new First_model())
            {
                Coding cod = new Coding();
                IEnumerable<Resource_info> res = db.Resource_info.Where(u => u.Id.Equals(info.Id));
                Resource_info reso = res.First();
                reso.Resource = resou.Text;
                reso.Login_resource = log.Text;
                reso.Password_resource = cod.Encode(pass.Text);
                db.SaveChanges();
                MessageBox.Show("Ok");
                return;


            }           
        }
        private void resou_SelectionChanged(object sender, RoutedEventArgs e)
        {
            isEnable();

        }
    }
}
