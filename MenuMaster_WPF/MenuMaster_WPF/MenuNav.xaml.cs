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
using System.Windows.Shapes;

namespace MenuMaster_WPF
{
    /// <summary>
    /// Interaction logic for MenuNav.xaml
    /// </summary>
    public partial class MenuNav : Window
    {
        public MenuNav()
        {
            InitializeComponent();
        }

        private void Makanan_Click(object sender, RoutedEventArgs e)
        {
            Window_makanan Makanan = new Window_makanan();

            Makanan.Show();
            Close();
        }

        private void Minuman_Click(object sender, RoutedEventArgs e)
        {
            Window_Minum Minuman = new Window_Minum();

            Minuman.Show();
            Close();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            Window_history History = new Window_history();

            History.Show();
            Close();
        }

        private void Favorite_Click(object sender, RoutedEventArgs e)
        {
            Window_favorite Favorite = new Window_favorite();

            Favorite.Show();
            Close();
        }
    }
}
