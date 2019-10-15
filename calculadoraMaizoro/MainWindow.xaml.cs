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

namespace calculadoraMaizoro
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

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rbSuma.IsChecked)
                suma();
            else
                resta();
			Console.WriteLine("Hola1");
			Console.WriteLine("Hola2");
        }

        public void suma() {
            txRes.Text = ""+ (Convert.ToDouble(txNum1.Text) + Convert.ToDouble(txNum2.Text)); 
        }

        public void resta()
        {
            txRes.Text = "" + (Convert.ToDouble(txNum1.Text) - Convert.ToDouble(txNum2.Text)); 
        }
    }
}
