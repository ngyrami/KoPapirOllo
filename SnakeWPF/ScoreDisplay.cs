using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SnakeWPF
{
    public class ScoreDisplay
    {
        private MainWindow mainWindow;  // A fõablak, amelyben a pontszám megjelenik
        private Snake snake;  // A kígyó objektum, amelynek a pontszámát megjelenítjük

        public ScoreDisplay(MainWindow mainWindow)  // Konstruktor a ponszámlálóhoz
        {
            this.mainWindow = mainWindow;
            UpdateScoreDisplay();  // Pontszám megjelenítésének frissítése a konstruktorban
        }

        public void UpdateScoreDisplay()
        {
            // A fõablakban lévõ Score TextBox frissítése a kígyó aktuális pontszámával
            mainWindow.Score.Text ="Pontszám: " + mainWindow.snake.CountSegments().ToString();
        }

    }
}
