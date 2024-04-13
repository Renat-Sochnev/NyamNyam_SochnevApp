using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyamNyam_SochnevApp.DB
{
    public partial class IngredientOfStage
    {
        public bool Sword
        {
            get
            {
                return Ingredient.AvailableCount >= Winter;
            }
            set
            {

            }
        }
        public string Rocket
        {
            get
            {
                return Sword ? "YellowGreen" : "Pink";
            }
        }
        public double Maksim { get; set; }
        public double Winter { get; set; }
        public double Poezd
        {
            get
            {
                return Ingredient.Police * Winter;
            }
        }
    }
}
