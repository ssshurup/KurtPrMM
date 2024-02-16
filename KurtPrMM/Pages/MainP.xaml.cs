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
    /// Логика взаимодействия для MainP.xaml
    /// </summary>
    public partial class MainP : Page
    {
        public MainP()
        {
            InitializeComponent();
            ItemListDG.ItemsSource = App.DB.inventory.Where(a => a.idUser == App.LoggedUser.id).ToList();
        }

        private void BuyBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddP());
        }

        private void DropBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ItemListDG.SelectedItem as inventory;
            if (selectedItem != null)
            {
                App.DB.inventory.Remove(selectedItem);
                App.DB.SaveChanges();
                NavigationService.Navigate(new MainP());
            }
            else MessageBox.Show("Select any item");
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginP());
        }
    }
}
