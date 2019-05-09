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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            Canvas.SetLeft(Panzer, p.X);
        }

        private void Panzer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            schuss();
        }
        
    }
}
