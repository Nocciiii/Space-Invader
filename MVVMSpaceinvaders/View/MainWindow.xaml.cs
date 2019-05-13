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
    /// </summary>5
    public partial class MainWindow : Window
    {
        private Spieler spieler;
        private Image img;

        public MainWindow()
        {
            InitializeComponent();
            erstelleSpieler();
        }

        private void erstelleSpieler()
        {
            this.spieler = new Spieler();
            this.img = new Image();
            spielfeld.Children.Add(img);
            img.Source = new BitmapImage(spieler.Aussehen);
            double left = spielfeld.ActualWidth/2;
            img.Height = 20;
            img.Width = 35;
            Canvas.SetLeft(img, 50);
            Canvas.SetBottom(img, 15);
            img.Visibility = Visibility.Visible;
        }

       
        private void spielfeld_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            Canvas.SetLeft(img, p.X);
        }
    }
}
