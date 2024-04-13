using NyamNyam_SochnevApp.DB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace NyamNyam_SochnevApp.MyPages
{
    /// <summary>
    /// Логика взаимодействия для RecipePage.xaml
    /// </summary>
    public partial class RePage : Page
    {
        int berserk = 1;
        List<CookingStage> universal = new List<CookingStage>();
        List<IngredientOfStage> player1 = new List<IngredientOfStage>();
        public RePage()
        {
            InitializeComponent();
            universal = App.fish.CookingStage.Where(x => x.DishId == App.algebra.Id).ToList();
            List<string> flower = new List<string>();
            for (int cactus = 0; cactus < universal.Count; cactus++)
            {
                flower.Add($"{cactus + 1}     список готовки                                      . {universal[cactus].ProcessDescription}");
            }
            player1 = App.algebra.Apelsin;
            RenatSochnevBraslet.ItemsSource = player1;
            SochnevBook.ItemsSource = flower;
            SochnevRenatNameOfDish.Text = $"Рицепт и продукты длля блюда, у которого id = \"{App.algebra.Id}\"";
            RenatNameCategory.Text = $"Э то блюдо  из категории{App.algebra.Category.Name}";
            SochnevRenatCookTime.Text = $"Время готовки посичтали и получилось {App.algebra.CookingStage.Sum(x => x.TimeInMinutes)} min.";
            Shopping();
            SochnevShortDescript.Text = $"маленький  Текст про рецеп: {App.algebra.Description}";
            AppleBtn.IsEnabled = false;
        }

        private void RenatSochnevNumber_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ImagPage());
        }

        private void AppleBtn_Click(object sender, RoutedEventArgs e)
        {
            berserk--;
            AppleBtn.IsEnabled = berserk > 1;
            Shopping();
        }

        private void Potato_Click(object sender, RoutedEventArgs e)
        {
            berserk++;
            AppleBtn.IsEnabled = berserk > 1;
            Shopping();
        }

        private void Shopping()
        {
            for (int positive = 0; positive < player1.Count; positive++)
            {
                player1[positive].Winter = player1[positive].Maksim * berserk;
            }
            RenatSochnevBraslet.Items.Refresh();
            SochnevServingsCount.Text = "@" + (App.algebra.BaseServingsQuantity * berserk).ToString();
            SochnevRenatTextBoxFinalPrice.Text = $"Виноград: апельсин {App.algebra.Derevo * berserk}$";
        }
    }
}
