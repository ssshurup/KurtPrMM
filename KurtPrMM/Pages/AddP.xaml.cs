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
    /// Логика взаимодействия для AddP.xaml
    /// </summary>
    public partial class AddP : Page
    {
        inventory context;
        public AddP()
        {
            InitializeComponent();
            ItemListDG.ItemsSource = App.DB.items.ToList();
            context = new inventory();
        }

       
        private void BuyBT_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ItemListDG.SelectedItem as items;
            if(selectedItem == null)
            {
                MessageBox.Show("Select anything");
                return;
            }
            context.items = selectedItem;
            context.users = App.LoggedUser;
            App.DB.inventory.Add(context);
            App.DB.SaveChanges();
            MessageBox.Show("succes");
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainP());
        }
    }
}
