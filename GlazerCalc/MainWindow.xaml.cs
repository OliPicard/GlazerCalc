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

namespace GlazerCalc
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            string woodResult, glassResult;
            widthString = tbWidth.Text;
            heightString = tbHeight.Text;
            if (widthString == "")
            {
                MessageBox.Show("Error: Width is invaild, provide a number.");
            }
            else
            {
                width = double.Parse(widthString);
                height = double.Parse(heightString);
                woodLength = 2 * (width * height) * 3.25;
                woodResult = ("The length of wood is " + woodLength + " feet");
                label.Content = woodResult;
            }
            if (heightString == "")
            {
                MessageBox.Show("Error: Glass is invaild, provide a number.");
            }
            else
            {
                height = double.Parse(heightString);
                width = double.Parse(widthString);
                glassArea = 2 * (width * height);
                glassResult = ("The Area of glass is " + glassArea + " square meters");
                label1.Content = glassResult;
            }
            
            
            
        }
    }
}
