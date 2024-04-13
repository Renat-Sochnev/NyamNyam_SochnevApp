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
    /// Логика взаимодействия для IngredientsPage.xaml
    /// </summary>
    public partial class NeponyatnoPage : Page
    {
        public NeponyatnoPage()
        {
            InitializeComponent();
            DriveCar();
        }

        private void DriveCar()
        {
            App.fish.SaveChanges();
            List<Ingredient> samolet = App.fish.Ingredient.ToList();
            Lodka.ItemsSource = samolet;
            SochnevRenatTotalAmount.Text = samolet.Sum(petr => petr.Police * petr.AvailableCount).ToString();
        }

        private void SochnevRenatIngredientCount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text[0]))
            {
                e.Handled = true;
            }
        }

        private void TopButton_Click(object sender, RoutedEventArgs e)
        {
            Ingredient vilka = (sender as Button).DataContext as Ingredient;
            vilka.AvailableCount++;
            DriveCar();
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            Ingredient knife = (sender as Button).DataContext as Ingredient;
            knife.AvailableCount--;
            DriveCar();
        }

        private void SochnevRenatIngredientCount_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox musicText = (TextBox)sender;
            Ingredient moscow = musicText.DataContext as Ingredient;
            double stakan = 0;
            if (!string.IsNullOrWhiteSpace(musicText.Text))
                stakan = double.Parse(musicText.Text);
            moscow.AvailableCount = stakan;
            DriveCar();
        }

        private void PotolokBtn_Click(object sender, RoutedEventArgs e)
        {
            string SochnevRenat = "";
            Ingredient BatonBulochka = (sender as Hyperlink).DataContext as Ingredient;
            List<IngredientOfStage> maslo = BatonBulochka.IngredientOfStage.ToList();
            List<IngredientOfStage> obed = new List<IngredientOfStage>();
            for (int tigr = 0; tigr < maslo.Count; tigr++)
            {
                IngredientOfStage pepsi = obed.Find(sunshine => sunshine.CookingStage.DishId == maslo[tigr].CookingStage.DishId);
                if(pepsi == null)
                {
                    obed.Add(maslo[tigr]);
                    SochnevRenat += $"\n{maslo[tigr].CookingStage.Dish.Name}";
                }
            }
            int globus = obed.Count;
            if (globus > 0)
            {
                MessageBox.Show($" Нельзя удалить потому што используется в рецептах" +
                    $" Кол--во блюд, где используется этот ингердеинет: {globus} \n {SochnevRenat}");
            }
            else
            {
                App.fish.Ingredient.Remove(BatonBulochka);
                DriveCar();
                MessageBox.Show($"Был удален ингердент \"{BatonBulochka.Name}\"");
            }
        }
    }
}
