using RPGSimuladorPrototipo.Jogo.Personagem;
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

        public void 

        public void Turno(Personagem personagem, )
        {

           

        }
      
        private void LogBatalha_TextChanged(object sender, TextChangedEventArgs e)
        {
            LogBatalha.IsReadOnly = true;    
        }

        private void BTNPosturaATK_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument objFdoc2 = new FlowDocument();

            Paragraph objParal2 = new Paragraph();
            objParal2.Inlines.Add(new Run("Postura alterada para o modo ofensivo \n "));
            objParal2.Inlines.Add(new Run("Você recebe 25% de bonus em ATK \n"));
            objParal2.Inlines.Add(new Run("Você recebe 30% de chances de acertar um dano critico \n"));
            objParal2.Inlines.Add(new Run("Sua defesa perde -40% \n"));
            objFdoc2.Blocks.Add(objParal2);
            LogBatalha.Document = objFdoc2;
        }

        private void BTNPosturaDF_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BTNPosturaBalanceada_Click(object sender, RoutedEventArgs e)
        {
            
        }


        private void BTNEquipCabeca_Click(object sender, RoutedEventArgs e)
        {
            Window JanelaEquipCabeça = new Window
            {
                Height = 200,
                Width = 500,
                WindowStyle = WindowStyle.SingleBorderWindow,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize,
                Background = new SolidColorBrush(Colors.SlateGray)
                
            };




            //DEPOIS REPROGRAMAR PARA TRAZER AS IMAGENS QUE O USUÁRIO TIVER
            /**foreach(Image img in )
            {

            }**/
            JanelaEquipCabeça.Show();
        }

        private void BTNEquipBDireto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTNEquipCorpo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTNEquipBEsquerdo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTNEquipPerna_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTNEquipPes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTNCombo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTNAtaque_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
