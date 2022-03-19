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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string islm;
        int sayi1, sayi2;
        

        public MainWindow()
        {
            InitializeComponent();
           
        }

        
        private void bir_Click(object sender, RoutedEventArgs e)
        {
           

            if (tb.Text == "0")
            {
                tb.Text = "1";
            }

            else 
            {
                tb.Text = tb.Text + "1";
            } 
        }

        private void iki_Click(object sender, RoutedEventArgs e)
        {
            
            if (tb.Text == "0")
            {
                tb.Text = "2";
            }

            else
            {
                tb.Text = tb.Text + "2";
            } 
        }

        private void uc_Click(object sender, RoutedEventArgs e)
        {
            

            if (tb.Text == "0")
            {
                tb.Text = "3";
            }

            else
            {
                tb.Text = tb.Text + "3";
            } 
        }

        private void dort_Click(object sender, RoutedEventArgs e)
        {
            

            if (tb.Text == "0")
            {
                tb.Text = "4";
            }

            else
            {
                tb.Text = tb.Text + "4";
            } 
        }

        private void bes_Click(object sender, RoutedEventArgs e)
        {
            
            if (tb.Text == "0")
            {
                tb.Text = "5";
            }

            else
            {
                tb.Text = tb.Text + "5";
            } 
        }

        private void alti_Click(object sender, RoutedEventArgs e)
        {
            
            if (tb.Text == "0")
            {
                tb.Text = "6";
            }

            else
            {
                tb.Text = tb.Text + "6";
            } 
        }

        private void yedi_Click(object sender, RoutedEventArgs e)
        {
            
            if (tb.Text == "0")
            {
                tb.Text = "7";
            }

            else
            {
                tb.Text = tb.Text + "7";
            } 
        }

        private void sekiz_Click(object sender, RoutedEventArgs e)
        {
            
            if (tb.Text == "0")
            {
                tb.Text = "8";
            }

            else
            {
                tb.Text = tb.Text + "8";
            } 
        }

        private void dokuz_Click(object sender, RoutedEventArgs e)
        {
            
            if (tb.Text == "0")
            {
                tb.Text = "9";
            }

            else
            {
                tb.Text = tb.Text + "9";
            } 
        }

        private void sifir_Click(object sender, RoutedEventArgs e)
        {
            
            if (tb.Text == "0")
            {
                tb.Text = "0";
            }

            else
            {
                tb.Text = tb.Text + "0";
            } 
        }

        private void virgul_Click(object sender, RoutedEventArgs e)
        {
            
            if (tb.Text == "0")
            {
                tb.Text =tb.Text+ ",";
            }

            else
            {
                tb.Text = tb.Text + ",";
            } 
        }

        private void toplama_Click(object sender, RoutedEventArgs e)
        {
            islm="+";
            sayi1 = Convert.ToInt32(tb.Text);
            tb.Text = "";
        }

        private void cikarma_Click(object sender, RoutedEventArgs e)
        {
            islm = "-";
            sayi1 = Convert.ToInt32(tb.Text);
            tb.Text = "";
        }

        private void carpma_Click(object sender, RoutedEventArgs e)
        {
            islm = "*";
            sayi1 = Convert.ToInt32(tb.Text);
            tb.Text = "";
        }

        private void bolme_Click(object sender, RoutedEventArgs e)
        {
            islm = "/";
            sayi1 = Convert.ToInt32(tb.Text);
            tb.Text = "";
        }

        private void ondalik_Click(object sender, RoutedEventArgs e)
        {
            islm = "1/x";
            sayi1 = Convert.ToInt32(tb.Text);
            tb.Text = Convert.ToString(1 / sayi1);
            tb.Text = "";
        }
        
        
           
        private void yuzde_Click(object sender, RoutedEventArgs e)
        {
                islm = "%";
                sayi1 = Convert.ToInt32(tb.Text);
                sayi2 = Convert.ToInt32(tb.Text);
                int carpim = sayi1 * sayi2;
                tb.Text = (carpim / 100).ToString();
           
            
        }

        private void karakok_Click(object sender, RoutedEventArgs e)
        {
                
                islm = "krkk";
                sayi1 = Convert.ToInt32(tb.Text);
                tb.Text = ("√" + sayi1.ToString());
                tb.Text = Convert.ToString(Math.Sqrt(sayi1));
            
        }

        private void fonksiyon_Click(object sender, RoutedEventArgs e)
        {
            islm = "+-";
            if (Convert.ToInt32(tb.Text) < 0)
            {
                tb.Text = Convert.ToString(Math.Abs(Convert.ToInt32(tb.Text)));
            }

            else {  tb.Text = "-" + tb.Text; }
           
     
        }
            
       
        private void esittir_Click(object sender, RoutedEventArgs e)
        {
            

            if (islm == "+")
            {
                sayi2 = Convert.ToInt32(tb.Text);
                tb.Text = Convert.ToString(sayi1 + sayi2);
            }

            else if (islm == "-")
            {
                sayi2 = Convert.ToInt32(tb.Text);
                tb.Text = Convert.ToString(sayi1 - sayi2);
            }

            else if (islm == "*")
            {
                sayi2 = Convert.ToInt32(tb.Text);
                tb.Text = Convert.ToString(sayi1 * sayi2);
            }

            else if (islm == "/")
            {
                sayi2 = Convert.ToInt32(tb.Text);
                tb.Text = Convert.ToString(sayi1 / sayi2);
            }
           
        }

       //Tek tek silme işlemi
        private void teksil_Click(object sender, RoutedEventArgs e)
        {
            string veri = tb.Text;
            tb.Text = "";


            int i;
            for (i = 0; i < veri.Length - 1; i++)
            {
                tb.Text += veri[i].ToString();
            }

        }

        //Bütün girdiyi temizleme
        private void sil_Click_1(object sender, RoutedEventArgs e)
        {
            tb.Text = " ";
        }





















    }
}
