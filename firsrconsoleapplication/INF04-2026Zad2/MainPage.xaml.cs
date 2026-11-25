using INF04_2026Zad2.Data;
using System.Collections.ObjectModel;
namespace INF04_2026Zad2
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<ObservableCollection<Kosc>> rows;
        public ObservableCollection<ObservableCollection<Kosc>> Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        private ObservableCollection<Kosc> firstRow;
        public ObservableCollection<Kosc> FirstRow
        {
            get { return firstRow; }
            set { firstRow = value; }
        }

        private ObservableCollection<Kosc> secondRow;
        public ObservableCollection<Kosc> SecondRow
        {
            get { return secondRow; }
            set { secondRow = value; }
        }

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
                            foreach (ObservableCollection<Kosc> r in Rows)
                            {
                                foreach (Kosc k in r)
                                {
                                    k.throwDiceIfAvailable();
                                    RollResult += k.numberThrown;
                                }
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

            firstRow = new ObservableCollection<Kosc>();
            for(int i = 0; i < 2; i++)
            {
                firstRow.Add(new Kosc(0));
            }

            secondRow = new ObservableCollection<Kosc>();
            for (int i = 0; i < 3; i++)
            {
                secondRow.Add(new Kosc(0));
            }

            rows = new ObservableCollection<ObservableCollection<Kosc>> { firstRow, secondRow };

            InitializeComponent();
        }
    }
}
