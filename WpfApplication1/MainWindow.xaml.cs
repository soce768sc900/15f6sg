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
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HS_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = Math.Round(HeightSlider.Value, 1);
            HN.Text = value.ToString();
            double v = (value / 200) * 320;
            Canvas.SetLeft(HN, v);

            double h = double.Parse(HN.Text);
            double W = double.Parse(WN.Text);
            double DDD = W / Math.Pow((h / 100), 2);
          
            // MMM.Text = DDD.ToString();
            string[] parts = DDD.ToString().Split('.');
            MMM.Text =  parts[0];
            if (parts.Length > 1)
                HHH.Text = "." + parts[1];
            else
                HHH.Text = ".0";
        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = Math.Round(WeightSlider.Value, 1);
            WN.Text = value.ToString();
            double v = (value / 200) * 320;
            Canvas.SetLeft(WN, v);

            double h = double.Parse(HN.Text);
            double W = double.Parse(WN.Text);
            double DDD = W / Math.Pow((h / 100), 2);

            string[] parts = DDD.ToString().Split('.');
            MMM.Text = parts[0];
            
            if (parts.Length > 1)
                HHH.Text = "." + parts[1];
            else
                HHH.Text = ".0";
        }
    }
}
