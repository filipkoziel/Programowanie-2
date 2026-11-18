using INF04_2026Zad2.Data;
using System.Collections.ObjectModel;
namespace INF04_2026Zad2
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Kosc> dice;
        public ObservableCollection<Kosc> Dice
        {
            get { return dice; }
            set { dice = value; OnPropertyChanged(); }
        }

        private int rollResult;

        public int RollResult
        {
            get { return rollResult; }
            set { rollResult = value; OnPropertyChanged(); }
        }

        private Command throwDice;
        public Command ThrowDice
        {
            get
            {
                if (throwDice == null)
                    throwDice = new Command(
                        () =>
                        {
                            RollResult = 0;
                            foreach (Kosc d in Dice)
                            {
                                if(d.Available)
                                {
                                    d.throwDiceIfAvailable();
                                }
                                RollResult += d.numberThrown;
                            }
                        }
                        );
                return throwDice;
            }
        }

        public MainPage()
        {
            dice = new ObservableCollection<Kosc>();
            for (int i = 0; i < 5; i++)
            {
                dice.Add(new Kosc(0));
            }
            rollResult = 0;

            InitializeComponent();
        }
    }
}
