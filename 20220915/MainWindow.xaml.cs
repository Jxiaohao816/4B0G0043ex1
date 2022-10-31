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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _20220915
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.All(char.IsDigit))
            {
                TB1.Text= ("");
                int a = int.Parse(textbox1.Text);
                for (int i = 1; i <= a; i++)
                {
                    int c = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            c++;
                        }
                        if (c > 2) break;
                    }
                    if (c == 2)
                    {
                        TB1.Text = (TB1.Text + "\n" + Convert.ToString(i) + "的倍數：");
                        int save = i;
                        do
                        {
                            if ((save + i) > a)
                            {
                                TB1.Text = (TB1.Text + save );
                            }
                            else
                            {
                                TB1.Text = (TB1.Text + save + "、");
                            }
                            
                            save += i;
                        } while (save <= a);
                    }
                }
            }
            else
            {
                MessageBox.Show("請重新輸入");
                textbox1.Text = "";
                TB1.Text = "";
            }
        }
    }
}
