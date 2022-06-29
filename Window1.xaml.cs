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
using System.Data.SqlClient;
namespace DB_II
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-95V0MFCD;Initial Catalog=pharmacy;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adap;

        public Window1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textDCode.Text == "" || textDName.Text == "" || textPay.Text == "")
            {
                MessageBox.Show("please enter full details");
            }
            else
            {
               

                    cmd = new SqlCommand("Insert into product values('" + textDCode.Text + "','" + textDName.Text + "','" + textPay.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been Saved succesfully");
                
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            cmd = new SqlCommand("Update product set price='" + textPay.Text + "' where id='" + textDCode.Text + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Record has been Updated succesfully");

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            cmd = new SqlCommand("DELETE product WHERE id = '" + textDCode.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("Record has been Deleted succesfully");
            
        }
    }
}
