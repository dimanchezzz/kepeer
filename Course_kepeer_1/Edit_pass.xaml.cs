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
        Resource_info Info;
        
        public Edit_pass(Border bord,Resource_info info)
        {
            InitializeComponent();
            Bord = bord;
            Info = info;
            passworch.Content = new labelpass(Info,Bord);
            isEnab += Isenab;

           
        }
        public void Anim()
        {
            DoubleAnimation an = new DoubleAnimation();
            an.To = 0;
            an.Duration = TimeSpan.FromSeconds(0.3);
            Bord.BeginAnimation(Border.WidthProperty, an);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Anim();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            passworch.Content = new ed_pass(Info);
        }

        public delegate void MethodContainer();
        public static event MethodContainer onDeleteClick;
        public static event MethodContainer isEnab;
         public void Isenab()
        { if (Info==null)
            {
                delete.IsEnabled = false;
                edit.IsEnabled = false;

            }
            

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            //    MessageBoxResult result = MessageBox.Show("Открыть Ворота?", "Ворота",
            //MessageBoxButton.YesNo, MessageBoxImage.Question);

            //    if (result == MessageBoxResult.Yes)
            //    {

            //        // Closes the parent form.
            //        MessageBox.Show("Странно, Это работает?");
            //        this.Close();

            //    }
            MessageBoxResult result = MessageBox.Show("Do you want to delete the entry?", "Question", MessageBoxButton.OK, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                using (First_model db = new First_model())
                {
                    IEnumerable<Resource_info> res = db.Resource_info.Where(u => u.Id.Equals(Info.Id));
                    Resource_info reso = res.First();
                    // db.Resource_info.
                    db.Resource_info.RemoveRange(res);
                    db.SaveChanges();
                    //My_password ms = new My_password();
                    onDeleteClick();
                    isEnab();

                    //List<Resource_info> info = db.Resource_info.ToList();
                    //ms.list.ItemsSource = info;
                    //ms.list.DisplayMemberPath = "Resource";
                    return;
                }
            }
           
           

        }
    }
}
