using System;
using System.Linq;
using System.Windows;

namespace _25
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

        //button metode
        private void passwordValidator(object sender, RoutedEventArgs e)
        {

            //score ligger en point til for hver gang den matcher med et tegn
            int score = 0;


            if (input.Text.Length > 0)
                score++;
            if (input.Text.Length > 7)
                score++;
            if (input.Text.Length > 11)
                score++;
            //character bliver tjekket en efter en, hvis der er både tal og bogstaver stiger scoren med en 
            if (input.Text.Any(char.IsNumber) == true && input.Text.Any(char.IsLetter) == true)
                score++;
            //linq, tager input text, tjekker med Any inde i text, hvor char tager hver teneste tegn/bogstav 
            //og tjekker med upper(bool) om det er et stort bogstav
            if (input.Text.Any(char.IsUpper) == true && input.Text.Any(char.IsLower) == true)
                score++;
            //Pilen er en lambda operation og
            //den separere parameteret (ch) (input-parameters) => expression(funktionen)
            //Tjekker om tegnene ikke er letter eller digit, hvis der er et match, hvor det okke er letter eller digit
            //stiger scoren med en 
            if (input.Text.Any(ch => !Char.IsLetterOrDigit(ch)) == true)
                score++;



            //tjekker hvad størrelse scoren har
            //Når vi sætter output.Text på denne måde overrider den, den forrige text
            switch (score)
            {
                case 0:
                    output.Text = "Blank";
                    break;
                case 1:
                    output.Text = "Very weak";
                    break;
                case 2:
                    output.Text = "Weak";
                    break;
                case 3:
                    output.Text = "Normal";
                    break;
                case 4:
                    output.Text = "Strong";
                    break;
                case 5:
                    output.Text = "Very strong";
                    break;
                case 6:
                    output.Text = "Super strong";
                    break;

                //den er med hvis der er en score der ikke matcher nogle cases 
                default:
                    break;
            }








        }











    }


}

