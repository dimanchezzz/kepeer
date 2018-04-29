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
    /// Логика взаимодействия для labelpass.xaml
    /// </summary>
    public partial class labelpass : Page
    {
        Resource_info info;
        Page a;
        Border Bo;
        public labelpass(Resource_info Info, Border bo)
        {
            Coding cod = new Coding();
            Bo = bo;
            InitializeComponent();
            if (Info != null)
            {
                info = Info;
                resou.Content = Info.Resource;
                log.Content = Info.Login_resource;
                pass.Content = cod.Decode(Info.Password_resource);
            }
            else
            {
               

            }
        }
    }
}
