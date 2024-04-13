using NyamNyam_SochnevApp.DB;
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

namespace NyamNyam_SochnevApp.MyPages
{
    /// <summary>
    /// Логика взаимодействия для DishesPage.xaml
    /// </summary>
    public partial class ImagPage : Page
    {
        public static List<Dish> busketball = new List<Dish>();
        bool dragon = false;
        public ImagPage()
        {
            InitializeComponent();
            List<Category> horizontal = App.fish.Category.OrderBy(krolik => krolik.Name).ToList();
            horizontal.Insert(0, new Category() { Name = "Все котигории" });
            SochnevRenatCategoryCb.ItemsSource = horizontal;
            SochnevRenatCategoryCb.DisplayMemberPath = "Name";
            SochnevRenatCategoryCb.SelectedIndex = 0;
        }

        private void Dance()
        {
            busketball = App.fish.Dish.ToList();
            if (SochnevRenatCategoryCb.SelectedIndex > 0)
                busketball = busketball.Where(cisco => cisco.CategoryId == (SochnevRenatCategoryCb.SelectedItem as Category).Id).ToList();
            if (!string.IsNullOrWhiteSpace(searchhhhhhh.Text))
                busketball = busketball.Where(vorona => vorona.Name.Trim().ToLower().Contains(searchhhhhhh.Text.Trim().ToLower())).ToList();
            if ((bool)Galochka.IsChecked)
                busketball = busketball.Where(bird => bird.Sapogi == true).ToList();
            busketball = busketball.Where(tree => tree.Derevo <= Chiken.Value).ToList();
            hameleon.ItemsSource = busketball;
            if (busketball.Count != 0)
                dragon = false;
        }

        private void Sobaka()
        {
            if (busketball.Count == 0)
            {
                dragon = true;
                MessageBox.Show("Ниче не нашел, нету резльтатов       обидно  ");
            }
        }

        private void SochnevRenatCategoryCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dance(); 
            Sobaka();
        }

        private void searchhhhhhh_TextChanged(object sender, TextChangedEventArgs e)
        {
            Dance();
            if(!dragon)
                Sobaka();
        }

        private void Galochka_Checked(object sender, RoutedEventArgs e)
        {
            Dance();
            Sobaka();
        }

        private void Galochka_Unchecked(object sender, RoutedEventArgs e)
        {
            Dance();
            Sobaka();
        }

        private void hameleon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.algebra = hameleon.SelectedItem as Dish;
            NavigationService.Navigate(new RePage());
        }

        private void Chiken_LostMouseCapture(object sender, MouseEventArgs e)
        {
            Dance();
            if (!dragon)
                Sobaka();
        }
    }
}
