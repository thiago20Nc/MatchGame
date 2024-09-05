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
using System.Windows.Threading;

namespace MatchGame
{    
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tenthsOfSecondElapsead;
        int matchesFound; 

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            SetUpGame();
        }
        

        private void Timer_Tick(object? sender, EventArgs e)
        {
            tenthsOfSecondElapsead++;
            timeTextBlock.Text = (tenthsOfSecondElapsead / 10F).ToString("0.0s");
            if (matchesFound == 8)
            { 
                timer.Stop();
                timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
            }
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🦁","🦁",
                "🦒","🦒",
                "🦍","🦍",
                "🐘","🐘",
                "🐊","🐊",
                "🐳","🐳",
                "🦑","🦑",
                "🐫","🐫",
            }; 

            Random random = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) 
            { 
                if(textBlock.Name != "timeTextBlock") 
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(animalEmoji.Count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                }
            } 

            timer.Start();
            tenthsOfSecondElapsead = 0;
            matchesFound = 0;

        }

        TextBlock lastTextBlockClicked;
        bool fidingMatch = false;

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            
            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text) 
            { 
                matchesFound++; 
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else 
            { 
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_8(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_9(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_10(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_11(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_12(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_13(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_14(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }
        private void TextBlock_MouseDown_15(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;

            if (fidingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                fidingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                fidingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                fidingMatch = false;
            }
        }

        private void timeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(matchesFound == 8) 
            { 
                SetUpGame();
            }
        }
    }
}