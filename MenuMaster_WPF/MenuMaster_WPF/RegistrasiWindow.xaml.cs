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
            string Username     = Convert.ToString(txt_Username.Text);
            string NamaAwal     = Convert.ToString(txt_NamaAw.Text);
            string NamaAkhir    = Convert.ToString(txt_NamaAk.Text);
            string Email        = Convert.ToString(txt_Email.Text);
            string Pass         = Convert.ToString(txt_Pass.Text);
            string PassConfirm  = Convert.ToString(txt_PassConfirm.Text);

            Regis reg = new Regis();

            reg.Write_JSON(Username, NamaAwal, NamaAkhir, Email, Pass);


        }
        public class Regis
        {
            
            public Account_Json Read_JSON()
            {
                JsonReadWrite RW = new JsonReadWrite();
                return RW.ReadJson();
            }
            public void Write_JSON(TextBox txt_Username,TextBox txt_NamaAw, TextBox txt_NamaAk, TextBox txt_Email, TextBox txt_Pass)
            {

                var Win = new RegistrasiWindow();
                string Username = txt_Username.Text;
                string NamaAwal = txt_NamaAw.Text;
                string NamaAkhir = txt_NamaAk.Text;
                string Email = txt_Email.Text;
                string Pass = txt_Pass.Text;

                Account_Json account = new Account_Json()
                {
                    Username = Username,
                    Nama_Awal = NamaAwal,
                    Nama_Akhir = NamaAkhir,
                    Email = Email,
                    Password = Pass
                };
                JsonReadWrite RW = new JsonReadWrite();
                RW.WriteJson(account);
            }
        }
        
        
    }
}