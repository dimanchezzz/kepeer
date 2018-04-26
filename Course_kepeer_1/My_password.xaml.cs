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
using System.Data;
using System.Data.Entity;
using System.Windows.Media.Animation;

namespace Course_kepeer_1
{
    /// <summary>
    /// Логика взаимодействия для My_password.xaml
    /// </summary>
    /// 
  
    public partial class My_password : Page
    {
        First_model db = new First_model();
        
        public My_password()
        {
            InitializeComponent();
            First_model db = new First_model();
            List<Resource_info> info = db.Resource_info.ToList();
           
           
            list.ItemsSource = info;
            list.DisplayMemberPath = "Resource";
            
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           
            Resource_info info = (Resource_info)list.SelectedItem;
            my_passframe.Content = new Edit_pass(border1);

            DoubleAnimation an = new DoubleAnimation();
            an.To = 300;
            an.Duration = TimeSpan.FromSeconds(0.3);
            border1.BeginAnimation(Border.WidthProperty, an);
            

        }

        
    }
}
