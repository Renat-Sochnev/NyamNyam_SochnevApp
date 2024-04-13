using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NyamNyam_SochnevApp.DB
{
    public partial class Dish
    {
        public bool Sapogi
        {
            get
            {
                bool lampochka = true;
                List<IngredientOfStage> qwerty = Apelsin; 
                for (int ocean = 0; ocean < qwerty.Count; ocean++)
                {
                    if (qwerty[ocean].Ingredient.AvailableCount < qwerty[ocean].Maksim)
                    {
                        lampochka = false;
                    }
                }
                return lampochka;
            }
        }
        public PixelFormat Briliant
        {
            get
            {
                return Sapogi ? PixelFormats.Pbgra32 : PixelFormats.Gray8;
            }
        }

        public double Derevo
        {
            get
            {
                List<IngredientOfStage> gamelist = Apelsin;
                return gamelist.Sum(ivan => ivan.Ingredient.Police * ivan.Maksim);
            }
        }

        public List<IngredientOfStage> Apelsin
        {
            get
            {
                List<IngredientOfStage> golova = new List<IngredientOfStage>();
                List<IngredientOfStage> bereza = CookingStage.SelectMany(svetofor => svetofor.IngredientOfStage).ToList();
                for (int super = 0; super < bereza.Count; super++)
                {
                    var cat = golova.Find(teremok => teremok.IngredientId == bereza[super].IngredientId);
                    if (cat == null)
                    {
                        bereza[super].Maksim = bereza[super].Quantity;
                        golova.Add(bereza[super]);
                    }
                    else
                    {
                        cat.Maksim += bereza[super].Quantity;
                    }
                }
                return golova;
            }
        }
    }
}
