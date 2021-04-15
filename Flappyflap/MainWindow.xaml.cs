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
using System.Windows.Threading;

namespace Flappyflap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer gameTimer = new DispatcherTimer();
        private double score;
        private int gravity = 8;
        private bool gameOver;
        private Rect flapHitBox;

        public MainWindow()
        {
            InitializeComponent();

            gameTimer.Tick += MainEventTimer;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            StartGame();
        }

        private void MainEventTimer(object sender, EventArgs e)
        {
            scoreTxt.Content = "Score: " + score;

            flapHitBox = new Rect(Canvas.GetLeft(flappyBirb), Canvas.GetTop(flappyBirb), flappyBirb.Width,
                flappyBirb.Height);

            Canvas.SetTop(flappyBirb, Canvas.GetTop(flappyBirb) + gravity);

            if (Canvas.GetTop(flappyBirb) < -10 || Canvas.GetTop(flappyBirb) > 458)
            {
                EndGame();
            }

            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                if ((string)x.Tag == "obs1" || (string)x.Tag == "obs2" || (string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);

                    if (Canvas.GetLeft(x) < -100)
                    {
                        Canvas.SetLeft(x, 800);

                        score += .5;
                    }

                    Rect pipeHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width,
                        x.Height);

                    if (flapHitBox.IntersectsWith(pipeHitBox))
                    {
                        EndGame();
                    }
                }

                if ((string) x.Tag == "Cloud")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 2);

                    if (Canvas.GetLeft(x) < -250)
                    {
                        Canvas.SetLeft(x, 550);
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                flappyBirb.RenderTransform = new RotateTransform(-20, flappyBirb.Width / 2, flappyBirb.Height / 2);
                gravity = -8;
            }

            if (e.Key == Key.R && gameOver == true)
            {
                StartGame();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            flappyBirb.RenderTransform = new RotateTransform(5, flappyBirb.Width / 2, flappyBirb.Height / 2);
            gravity = 8;
        }

        private void StartGame()
        {
            MyCanvas.Focus();

            int temp = 300;
            score = 0;
            gameOver = false;
            Canvas.SetTop(flappyBirb, 190);

            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                if ((string) x.Tag == "obs1")
                {
                    Canvas.SetLeft(x, 500);
                }
                if ((string)x.Tag == "obs2")
                {
                    Canvas.SetLeft(x, 800);
                }
                if ((string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, 1100);
                }

                if ((string)x.Tag == "Cloud")
                {
                    Canvas.SetLeft(x, 300 + temp);
                    temp = 800;
                }

            }

            gameTimer.Start();
        }

        private void EndGame()
        {
            gameTimer.Stop();
            gameOver = true;
            scoreTxt.Content += " Game over, Press R to try again";
        }
    }
}
