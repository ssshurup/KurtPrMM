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
    /// Логика взаимодействия для LoginP.xaml
    /// </summary>
    public partial class LoginP : Page
    {
        public LoginP()
        {
            InitializeComponent();
        }

        private void LogBT_Click(object sender, RoutedEventArgs e)
        {
            var loggedUser = App.DB.users.FirstOrDefault(a => a.login == LoginTB.Text && a.password == PassTB.Text);
            if (loggedUser != null)
            {
                App.LoggedUser = loggedUser;
                NavigationService.Navigate(new MainP());
            }
            else MessageBox.Show("Something wrong");
        }

        private void RegBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterP());
        }
    }
}
