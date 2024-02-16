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

namespace KurtPrMM.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegisterP.xaml
    /// </summary>
    public partial class RegisterP : Page
    {
        users context;
        public RegisterP()
        {
            InitializeComponent();
            context = new users();
            DataContext = context;
        }

       

        private void RegBT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                App.DB.users.Add(context);
                App.DB.SaveChanges();
                MessageBox.Show("Succes");
                NavigationService.Navigate(new LoginP());
            }catch
            {
                MessageBox.Show("Something wrong");
            }
        }
        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
