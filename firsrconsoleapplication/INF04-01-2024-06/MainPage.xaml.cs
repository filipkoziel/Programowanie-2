using System.Collections.ObjectModel;

namespace INF04_01_2024_06
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<int> randomNumbers;
        public ObservableCollection<int> RandomNumbers
        {
            get { return randomNumbers; }
            set { randomNumbers = value; OnPropertyChanged(); }
        }

        private int drawResult;
        public int DrawResult
        {
            get { return drawResult; }
            set { drawResult = value; OnPropertyChanged(); }
        }

        private int gameResult;
        public int GameResult
        {
            get { return gameResult; }
            set { gameResult = value; OnPropertyChanged(); }
        }

        private int diceNumber;
        public int DiceNumber
        {
            get { return diceNumber; }
            set { diceNumber = value; OnPropertyChanged(); }
        }

        private Command randomizeDice;
        public Command RandomizeDice
        { 
            get
            {
                if (randomizeDice == null)
                    randomizeDice = new Command(
                        () =>
                        {
                            DrawResult = 0;
                            RandomNumbers = new ObservableCollection<int>();
                            for(int i = 0; i < DiceNumber; i++)
                            {
                                RandomNumbers.Add(randomNumber.Next(1, 7));
                            }
                            foreach(int n in randomNumbers)
                            {
                                DrawResult += n;
                                GameResult += n;
                            }
                        }
                        );
                return randomizeDice;
            }
        }

        private Command resetDice;
        public Command ResetDice
        {
            get
            {
                if (resetDice == null)
                    resetDice = new Command(
                        () =>
                        {
                            drawResult = 0;
                            RandomNumbers = new ObservableCollection<int>();
                            for (int i = 0; i < DiceNumber; i++)
                            {
                                RandomNumbers.Add(0);
                            }
                            DrawResult = 0;
                            GameResult = 0;
                        }
                        );
                return resetDice;
            }
        }

        Random randomNumber = new Random();

        public MainPage()
        {
            randomNumbers = new ObservableCollection<int>();
            for (int i = 0; i < DiceNumber; i++)
            {
                RandomNumbers.Add(0);
            }
            InitializeComponent();
        }
    }
}
