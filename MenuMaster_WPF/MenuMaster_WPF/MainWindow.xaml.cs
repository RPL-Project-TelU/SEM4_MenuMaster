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
            /*
            if(txtLogin.Text.Length == 0)
            {
                //errormessage.Text == "enter an email"
                MessageBox.Show("Enter an email");
                txtLogin.Focus();
            }else if (!Regex.IsMatch(txtLogin.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email");
                txtLogin.Focus();
            }
            else
            {
                string Username = txtLogin.Text;
                string Password = passBox.Password;


            }
            */

            //if (MessageBox.Show("Apakah anda yakin data yang"))

        }

        private void btnRegistrasi_Click(object sender, RoutedEventArgs e)
        {

        }
        private void passBox_TextChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
