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

namespace KoPapirOllo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random(); // Véletlenszám-generátor a számítógép választásához
        public MainWindow()
        {
            InitializeComponent();
        }
        // Eseménykezelő a gombokra kattintásra
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // A játékos választása a gomb Tag attribútumából származik
            string playerChoice = (sender as Button).Tag.ToString();
            // A számítógép választása
            string computerChoice = GetComputerChoice();
            // A győztes meghatározása
            string result = DetermineWinner(playerChoice, computerChoice);
            // Az eredmény megjelenítése
            ResultText.Text = $"Te: {playerChoice}\nGép: {computerChoice}\n{result}";
        }
        // A számítógép választásának generálása
        private string GetComputerChoice()
        {
            int choice = random.Next(3);
            if (choice == 0)
                return "Kő";
            else if (choice == 1)
                return "Papír";
            else
                return "Olló";
        }
        // A győztes meghatározása a játék szabályai alapján
        private string DetermineWinner(string playerChoice, string computerChoice)
        {
            if (playerChoice == computerChoice)
                return "Döntetlen!";

            if ((playerChoice == "Kő" && computerChoice == "Olló") ||
                (playerChoice == "Papír" && computerChoice == "Kő") ||
                (playerChoice == "Olló" && computerChoice == "Papír"))
                return "Te nyertél!";
            else
                return "A gép nyert!";
        }
    }
}
