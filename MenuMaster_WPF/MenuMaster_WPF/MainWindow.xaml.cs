using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MenuMaster_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void txtLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string Username = txtLogin.Text;
            string Password = passBox.Password;
            if (Username == "ABC" & Password == "CBA")
            {
                MessageBox.Show("Berhasil login");
            }
        }

        private void btnRegistrasi_Click(object sender, RoutedEventArgs e)
        {
            RegistrasiWindow Registration = new RegistrasiWindow();

            Registration.Show();
            Close();
        }
        private void passBox_TextChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
