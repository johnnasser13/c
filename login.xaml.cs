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

namespace DB_II
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

            if (textbox1.Text == "john" && passwordBox.Password == "123")
            {
                Window1 w = new Window1();
                w.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(" Enter Correct Data ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        
    }
}
