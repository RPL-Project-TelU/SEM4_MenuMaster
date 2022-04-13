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
using System.Text.RegularExpressions;

namespace MenuMaster_WPF
{
    /// <summary>
    /// Interaction logic for RegistrasiWindow.xaml
    /// </summary>
    public partial class RegistrasiWindow : Window
    {
        public RegistrasiWindow()
        {
            InitializeComponent();
        }

        private void txt_Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_NamaAw_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_NamaAk_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_Pass_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_PassConfirm_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        public void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            txt_Username.Text = txt_Username.Text;
            txt_NamaAw.Text = txt_NamaAw.Text;
            txt_NamaAk.Text = txt_NamaAk.Text;
            txt_Email.Text = txt_Email.Text;
            txt_Pass.Text = txt_Pass.Text;
            txt_PassConfirm.Text = txt_PassConfirm.Text;
           
        }
    }
}
