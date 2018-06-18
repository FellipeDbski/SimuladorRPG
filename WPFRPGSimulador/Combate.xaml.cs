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

namespace WPFRPGSimulador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Combate : Window
    {
        public Combate()
        {
            InitializeComponent();
        }

        private void MenuAtacar_Click(object sender, RoutedEventArgs e)
        {
            var MenuItem1 = new MenuItem();
            MenuItem1.Header = "Ataque Básico";
            MenuAtacar.Items.Add(MenuItem1);

            var MenuItem2 = new MenuItem();
            MenuItem2.Header = "Investida";
            MenuAtacar.Items.Add(MenuItem2);
        }

        private void BTNPosturaATK_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void BTNPosturaDF_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
