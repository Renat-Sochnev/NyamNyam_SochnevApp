using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyamNyam_SochnevApp.DB
{
    public partial class Ingredient
    {
        public double Police
        {
            get
            {
                return CostInCents * 0.01;
            }
        }
        public bool Valenki
        {
            get
            {
                return AvailableCount > 0;
            }
        }
    }
}
