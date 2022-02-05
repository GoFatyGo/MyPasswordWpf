using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        //char[] engChars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        //public char[] ENGChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        //public char[] rusChars = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        //public char[] RUSChars = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
        //public char[] numberChars = "1234567890".ToCharArray();
        //public char[] allChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890$%#@!*".ToCharArray();
        //public char[] special = "$%#@!*".ToCharArray();
        //public  char[] yourSymbols = tex.Text.ToCharArray();

        public MainWindow()
        {
            InitializeComponent();
            textbox1.Text = "Hello world";
            ComboboxCount.SelectedIndex = 1;

        }

        public static string GetLetters(int numberOfCharsToGenerate, char[] arrofchars)
        {
            var random = new Random();
            char[] chars = arrofchars;

            var sb = new StringBuilder();
            for (int i = 0; i < numberOfCharsToGenerate; i++)
            {
                int number = random.Next(0, chars.Length);
                sb.Append(chars[number]);
            }
            return sb.ToString();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox.Text == "yourSymbols")
            {
                textboxYourChars.IsEnabled = false;
            }
            else
            {
                textboxYourChars.IsEnabled = true;
                textboxYourChars.Text = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char[] engChars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] ENGChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] rusChars = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] RUSChars = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            char[] numberChars = "1234567890".ToCharArray();
            char[] allChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890$%#@!*".ToCharArray();
            char[] special = "$%#@!*".ToCharArray();
            char[] yourSymbols = textboxYourChars.Text.ToCharArray();
            if (ComboBox.Text == "eng")
            {
                textbox1.Text = GetLetters(Convert.ToInt32(ComboboxCount.Text), engChars);
            }
            else if (ComboBox.Text == "ENG")
            {
                textbox1.Text = GetLetters(Convert.ToInt32(ComboboxCount.Text), ENGChars);
            }
            else if (ComboBox.Text == "рус")
            {
                textbox1.Text = GetLetters(Convert.ToInt32(ComboboxCount.Text), rusChars);
            }
            else if (ComboBox.Text == "РУС")
            {
                textbox1.Text = GetLetters(Convert.ToInt32(ComboboxCount.Text), RUSChars);
            }
            else if (ComboBox.Text == "123")
            {
                textbox1.Text = GetLetters(Convert.ToInt32(ComboboxCount.Text), numberChars);
            }
            else if (ComboBox.Text == "Special")
            {
                textbox1.Text = GetLetters(Convert.ToInt32(ComboboxCount.Text), special);
            }
            else if (ComboBox.Text == "allChar")
            {
                textbox1.Text = GetLetters(Convert.ToInt32(ComboboxCount.Text), allChars);
            }
            else if (ComboBox.Text == "yourSymbols")
            {
                // textBox1.ReadOnly = false;
                if (textbox1.Text == "") /*comboBox1.Text!= "yourSymbols")*/
                {
                    MessageBox.Show("You did not write your chars", "Need your chars", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // textBox1.ReadOnly = false;
                    //  char[] yourSymbols = textboxYourChars.Text.ToCharArray();
                    textbox1.Text = GetLetters(Convert.ToInt32(ComboboxCount.Text), yourSymbols);
                }

            }
            else
            {
                MessageBox.Show("YOU DON'T GENERATE PASSWORD YET!", "PASSWORD DON`T GENERATED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textboxYourChars_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void butReset_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
        }

        private void butCopy_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "")
            {
                System.Windows.Clipboard.SetText(textbox1.Text);
            }
            else
            {
                MessageBox.Show("Generate password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
