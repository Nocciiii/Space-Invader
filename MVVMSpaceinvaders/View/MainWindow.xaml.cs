using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace View
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Spieler spieler;

        public MainWindow()
        {
            InitializeComponent();
            erstelleSpieler();
        }

        private void erstelleSpieler()
        {
            this.spieler = new Spieler();
            Image img = new Image();
            double left = spielfeld.ActualWidth/2;
            
            Canvas.SetLeft(img, left);
            Canvas.SetTop(img, 15);
            img.Height = 10;
            img.Width = 25;
            img.Source = new BitmapImage(spieler.Aussehen);
        }
    }
}
