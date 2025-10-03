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

namespace podwyzka
{
    public partial class MainWindow : Window
    {
        private Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTak_MouseEnter(object sender, MouseEventArgs e)
        {
            double maxX = MainCanvas.ActualWidth - BtnTak.Width;
            double maxY = MainCanvas.ActualHeight - BtnTak.Height;

            double newX = rand.NextDouble() * maxX;
            double newY = rand.NextDouble() * maxY;

            Canvas.SetLeft(BtnTak, newX);
            Canvas.SetTop(BtnTak, newY);
        }

        private void BtnNie_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No to trudno 😅");
        }

        private void BtnTak_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Udało ci się, ale tylko tym razem...");
        }
    }
}

