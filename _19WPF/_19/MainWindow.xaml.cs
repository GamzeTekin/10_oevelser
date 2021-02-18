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

namespace _19
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

        private void print_Click(object sender, RoutedEventArgs e)
        {
            //Deklarere min double og bruger en while til at tjekke at input er gyldigt
            double kg;
            
            if (!double.TryParse(W.Text, out kg))
            {
                result.Text = "Only use integer";
            }

            //Deklarere min double og bruger en while til at tjekke at input er gyldigt
            double cm;
           
            if (!double.TryParse(H.Text, out cm))
            {
                result.Text = "Only use integer";
            }

            //deklarere min double og briger formlen for bmi udregning
            double BMI;
            BMI = (kg / (cm / 100 * cm / 100));

            //if statements til resultatet
            if (BMI < 19)
            {
                result.Text = "Underweight";
            }
            if (BMI >= 19 & BMI <= 24)
            {
                result.Text = "Normal";
            }
            if (BMI > 24)
            {
                result.Text = "Overweight";
            }


        }
    }
}
