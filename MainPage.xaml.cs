using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RouletteGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public bool ButtonVisibility { get 
            { 
                return true; 
            } 
        }
        public List<int> PlayerChoice = new List<int>();
        public MainPage()
        {
            this.InitializeComponent();
        }
        //todo add checks if number is already selected to remove from list
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] columnOne = new int[12] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] columnTwo = new int[12] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] columnThree = new int[12] { 3, 5, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            switch ((sender as Button).Content)
            {
                case "0":
                    ResultsBox.Text = "That's the house box! You can't bet here";
                    break;
                case "1":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "2":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "3":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "4":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "5":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "6":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "7":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "8":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "9":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "10":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "11":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "12":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "13":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "14":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "15":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "16":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "17":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "18":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "19":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "20":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "21":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "22":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "23":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "24":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "25":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "26":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "27":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "28":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "29":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "30":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "31":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "32":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "33":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "34":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "35":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "36":
                    UpdatePlayerNumber(int.Parse((sender as Button).Content.ToString()));
                    break;
                case "00":
                    ResultsBox.Text = "That's the house box! You can't bet here";
                    break;
                case "Column One":
                    foreach (int x in columnOne)
                        UpdatePlayerNumber(x);
                    break;
                case "Column Two":
                    foreach (int x in columnTwo)
                        UpdatePlayerNumber(x);
                    break;
                case "Column Three":
                    foreach (int x in columnThree)
                        UpdatePlayerNumber(x);
                    break;
                default:
                    throw new Exception(ResultsBox.Text = "Something went wrong!");

            }

            ExplainItBetter();
        }

        private void FirstTwelve_Click(object sender, RoutedEventArgs e)
        {
            int[] firstTwelve = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] secondTwelve = new int[12] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            int[] thirdTwelve = new int[12] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            switch ((sender as Button).Content)
            {
                case "First Twelve":
                    foreach (int x in firstTwelve)
                    {
                        UpdatePlayerNumber(x);
                    }
                    break;
                case "Second Twelve":
                    foreach (int x in secondTwelve)
                    {
                        UpdatePlayerNumber(x);
                    }
                    break;
                case "Third Twelve":
                    foreach (int x in thirdTwelve)
                    {
                        UpdatePlayerNumber(x);
                    }
                    break;
            }
            ExplainItBetter();

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            int[] oneToEighteen = new int[18] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            int[] odds = new int[18] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
            int[] evens = new int[18] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
            int[] reds = new int[18] { 1, 3, 5, 7, 9, 11, 14, 15, 17, 19, 21, 23, 25, 27, 29, 32, 34, 35 };
            int[] blacks = new int[18] { 2, 4, 6, 8, 10, 12, 13, 16, 18, 20, 22, 24, 26, 28, 30, 31, 33, 36 };
            int[] nineteenToThirtysix = new int[18] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };

            switch ((sender as Button).Content)
            {
                case "1-18":
                    foreach (int x in oneToEighteen)
                    {
                        UpdatePlayerNumber(x);
                    }
                    break;
                case "Odds":
                    foreach (int x in odds)
                    {
                        UpdatePlayerNumber(x);
                    }
                    break;
                case "Evens":
                    foreach (int x in evens)
                    {
                        UpdatePlayerNumber(x);
                    }
                    break;
                case "Red":
                    foreach (int x in reds)
                    {
                        UpdatePlayerNumber(x);
                    }
                    break;
                case "Black":
                    foreach (int x in blacks)
                    {
                        UpdatePlayerNumber(x);
                    }
                    break;
                case "19-36":
                    foreach (int x in nineteenToThirtysix)
                    {
                        UpdatePlayerNumber(x);
                    }
                    break;
            }
            ExplainItBetter();

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }
        private void UpdatePlayerNumber(int buttonPressed) => PlayerChoice.Add(buttonPressed);

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AllDone_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, 38);
            int[] playerArray = PlayerChoice.ToArray();
            int check = 39;
            if (x == 0 || x == 37)
            {
                ResultsBox.Text = "Looks like 0's, House wins this time buddy!";
            }
            else if (x < 0 || x < 37)
            {
                foreach (int y in playerArray)
                {

                    if (x == y)
                    {
                        check = x;
                        break;
                    }

                }
            }
            if (check == 39)
                ResultsBox.Text = $"It rolled {x}, Ohh better luck next time!";
            else
                ResultsBox.Text = $"It rolled {x},Congats you won a bunch of fake money!";
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            PlayerChoice.Clear();
            ResultsBox.Text = "";
            SelectedNumbers.Text = "";
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }
        private void ExplainItBetter()
        {
            foreach(int x in PlayerChoice)
            {
                if(!(SelectedNumbers.Text).Contains(x.ToString()))
                {
                    SelectedNumbers.Text += $"{x}, ";
                }
            }
        }
    }
}
