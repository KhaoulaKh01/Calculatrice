using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace evaluationUA1CalculatriceKhoudali
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double FirstNumber;
        double SecondNumber;
        string Operation;
        double Result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //la méthode DragMove() pour permettre le déplacement de la fenêtre
            this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //la méthode Close() pour fermer la fenêtre 
            this.Close();
        }

        private void FactorialBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Convertir le contenu actuel du TextBox en entier
                int FirstNumber = Convert.ToInt32(tbResult.Text);

                // Vérifier si l'entrée est 0, auquel cas le résultat est 1
                if (FirstNumber == 0)
                {
                    tbResult.Text = "1";
                    return;
                }

                double newValue;

                // Calculer le factoriel pour les nombres positifs et négatifs
                newValue = Factorial(FirstNumber);

                // Mettre à jour le contenu du TextBox avec la nouvelle valeur
                tbResult.Text = newValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        // Fonction pour calculer le factoriel d'un nombre
        private double Factorial(int n)
        {
            // Si n est négatif, calculer le factoriel en valeur absolue et changer de signe
            if (n < 0)
            {
                return -Factorial(Math.Abs(n));
            }
            // Si n est 0, le factoriel est 1
            else if (n == 0)
            {
                return 1;
            }
            // Sinon, calculer le factoriel pour les nombres positifs
            else
            {
                double result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }


        private void InverseBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Convertir le contenu actuel du textbox tbRresult en double
                FirstNumber = Convert.ToDouble(tbResult.Text);

                // multiplier la valeur par elle meme
                double newValue = 1 / FirstNumber;

                // Mettre à jour le contenu du textbox tbRresult avec la nouvelle valeur
                tbResult.Text = newValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }  
        }

        private void SquareBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Convertir le contenu actuel du textbox tbRresult en double
                FirstNumber = Convert.ToDouble(tbResult.Text);

                // multiplier la valeur par elle meme en utilisant power 2
                double newValue = Math.Pow(FirstNumber, 2);

                // Mettre à jour le contenu du textbox tbRresult avec la nouvelle valeur
                tbResult.Text = newValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }   
        }

        private void SquareRootBtn_Click(object sender, RoutedEventArgs e)
        {
             try
            {
                // Convertir le contenu actuel du textbox tbRresult en double
                FirstNumber = Convert.ToDouble(tbResult.Text);

                // Calculer la racine carrée de la valeur
                double newValue = Math.Sqrt(FirstNumber);

                // Mettre à jour le contenu du textbox tbRresult avec la nouvelle valeur
                tbResult.Text = newValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }   
        }

        private void AllClearBtn_Click(object sender, RoutedEventArgs e)
        {
            // Réinitialise le contenu du TextBox à "0"
            tbResult.Text = "0";
        }

        private void SignChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Convertir le contenu actuel du Label result en double
                FirstNumber = Convert.ToDouble(tbResult.Text);

                // Changer le signe de la valeur
                double newValue = -FirstNumber;

                // Mettre à jour le contenu du Label result avec la nouvelle valeur
                tbResult.Text = newValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message);
            }
        }

        private void PercentageBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Convertir le contenu actuel du Label result en double
                FirstNumber = Convert.ToDouble(tbResult.Text);

                // Diviser la valeur par 100
                double newValue = FirstNumber / 100;

                // Mettre à jour le contenu du Label result avec la nouvelle valeur
                tbResult.Text = newValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : "+ex.Message);
            }
           
        }

        private void DivisionBtn_Click(object sender, RoutedEventArgs e)
        {
            // Convertit le contenu actuel du TextBox en double et le stocke dans FirstNumber
            FirstNumber = Convert.ToDouble(tbResult.Text);

            // Réinitialise le contenu du TextBox à "0"
            tbResult.Text = "0";

            // Stocke l'opération de division dans la variable Operation
            Operation = "/";
        }

        private void Number7Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "7"
                tbResult.Text = "7";
            }
            else
            {
                // Sinon, ajouter "7" à la fin du contenu actuel du TextBox
                tbResult.Text += "7";
            }

        }

        private void Number8Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "8"
                tbResult.Text = "8";
            }
            else
            {
                // Sinon, ajouter "8" à la fin du contenu actuel du TextBox
                tbResult.Text += "8";
            }
        }

        private void Number9Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "9"
                tbResult.Text = "9";
            }
            else
            {
                // Sinon, ajouter "9" à la fin du contenu actuel du TextBox
                tbResult.Text += "9";
            }
        }

        private void MultiplicationBtn_Click(object sender, RoutedEventArgs e)
        {
            // Convertit le contenu actuel du TextBox en double et le stocke dans FirstNumber
            FirstNumber = Convert.ToDouble(tbResult.Text);

            // Réinitialise le contenu du TextBox à "0"
            tbResult.Text = "0";

            // Stocke l'opération de multiplication dans la variable Operation
            Operation = "*";
        }

        private void Number4Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "4"
                tbResult.Text = "4";
            }
            else
            {
                // Sinon, ajouter "4" à la fin du contenu actuel du TextBox
                tbResult.Text += "4";
            }
        }

        private void Number5Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "5"
                tbResult.Text = "5";
            }
            else
            {
                // Sinon, ajouter "5" à la fin du contenu actuel du TextBox
                tbResult.Text += "5";
            }
        }

        private void Number6Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "6"
                tbResult.Text = "6";
            }
            else
            {
                // Sinon, ajouter "6" à la fin du contenu actuel du TextBox
                tbResult.Text += "6";
            }
        }

        private void SubtractionBtn_Click(object sender, RoutedEventArgs e)
        {
            // Convertit le contenu actuel du TextBox en double et le stocke dans FirstNumber
            FirstNumber = Convert.ToDouble(tbResult.Text);

            // Réinitialise le contenu du TextBox à "0"
            tbResult.Text = "0";

            // Stocke l'opération de soustraction dans la variable Operation
            Operation = "-";

        }

        private void Number1Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "1"
                tbResult.Text = "1";
            }
            else
            {
                // Sinon, ajouter "1" à la fin du contenu actuel du TextBox
                tbResult.Text += "1";
            }
        }

        private void Number2Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "2"
                tbResult.Text = "2";
            }
            else
            {
                // Sinon, ajouter "2" à la fin du contenu actuel du TextBox
                tbResult.Text += "2";
            }
        }

        private void Number3Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "3"
                tbResult.Text = "3";
            }
            else
            {
                // Sinon, ajouter "3" à la fin du contenu actuel du TextBox
                tbResult.Text += "3";
            }
        }
        
        private void AdditionBtn_Click(object sender, RoutedEventArgs e)
        {
            // Convertit le contenu actuel du TextBox en double et le stocke dans FirstNumber
            FirstNumber = Convert.ToDouble(tbResult.Text);

            // Réinitialise le contenu du TextBox à "0"
            tbResult.Text = "0";

            // Stocke l'opération d'addition dans la variable Operation
            Operation = "+";
        }


        private void Number0Btn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le contenu du TextBox est égal à "0"
            if (tbResult.Text.ToString() == "0")
            {
                // Si c'est le cas, remplacer le contenu du TextBox par "0"
                tbResult.Text = "0";
            }
            else
            {
                // Sinon, ajouter "0" à la fin du contenu actuel du TextBox
                tbResult.Text += "0";
            }
        }

        private void DecimalBtn_Click(object sender, RoutedEventArgs e)
        {
            // Vérifier si le texte du TextBox contient déjà une virgule
            if (!tbResult.Text.Contains(","))
            {
                // Si aucune virgule n'est présente, ajouter une virgule
                tbResult.Text += ",";
            }
        }
        
        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            // Convertit le contenu actuel du TextBox en double et le stocke comme le deuxième nombre de l'opération
            SecondNumber = Convert.ToDouble(tbResult.Text);

            // Vérifie quelle opération doit être effectuée
            if (Operation == "+")
            {
                // Additionne FirstNumber et SecondNumber, stocker le résultat dans Result, l'affiche dans le TextBox, puis met à jour FirstNumber
                Result = (FirstNumber + SecondNumber);
                tbResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "-")
            {
                // Soustraire SecondNumber de FirstNumber, stocker le résultat dans Result, l'affiche dans le TextBox, puis met à jour FirstNumber
                Result = (FirstNumber - SecondNumber);
                tbResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "*")
            {
                // Multiplier FirstNumber par SecondNumber, stocker le résultat dans Result, l'affiche dans le TextBox, puis met à jour FirstNumber
                Result = (FirstNumber * SecondNumber);
                tbResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "/")
            {
                // Vérifier si SecondNumber est nul pour éviter une division par zéro
                if (SecondNumber == 0)
                {
                    // Afficher "ERROR" si SecondNumber est zéro
                    tbResult.Text = "ERROR";
                }
                else
                {
                    // Diviser FirstNumber par SecondNumber, stocker le résultat dans Result, l'affiche dans le TextBox, puis met à jour FirstNumber
                    Result = (FirstNumber / SecondNumber);
                    tbResult.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }
}
