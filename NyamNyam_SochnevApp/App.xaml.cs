using NyamNyam_SochnevApp.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NyamNyam_SochnevApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        //база данных дома
        public static NyamNyam_Database_RenatEntities4 fish = new NyamNyam_Database_RenatEntities4();

        //база данных в техникуме
        //public static NyamNyam_Database_RenatEntities3 fish = new NyamNyam_Database_RenatEntities3();

        //выбранное блюдо для просмотра
        public static Dish algebra = new Dish();
    }
}