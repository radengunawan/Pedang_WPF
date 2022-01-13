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

namespace Pedang_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random ngacak = new Random();
        KerusakanPedang kped = new KerusakanPedang();

        public MainWindow()
        {
            InitializeComponent();
            kped.AturKeajaiban(false);
            kped.AturNyalaApi(false);
            LemparDadu();

        }

        public void LemparDadu()
        {
            kped.Roll = ngacak.Next(1, 7) + ngacak.Next(1, 7) + ngacak.Next(1, 7);
            kped.AturNyalaApi(flaming.IsChecked.Value);
            kped.AturKeajaiban(magic.IsChecked.Value);
            DisplayKerusakan();
        }

        void DisplayKerusakan()
        {
            //damage is variable from Textblock's XAML
            damage.Text = "Rolled " + kped.Roll + " for " + kped.Kerusakan + " HP";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LemparDadu();
        }

        private void Flaming_Checked(object sender, RoutedEventArgs e)
        {
            kped.AturNyalaApi(true);
            DisplayKerusakan();
        }

        private void Flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            kped.AturNyalaApi(false);
            DisplayKerusakan();
        }

        private void Magic_Checked(object sender, RoutedEventArgs e)
        {
            kped.AturKeajaiban(true);
            DisplayKerusakan();
        }

        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            kped.AturKeajaiban(false);
            DisplayKerusakan();
        }
    }
}
