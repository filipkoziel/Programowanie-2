namespace INF04_2022_06
{
    public partial class MainPage : ContentPage
    {
        private int likeNumber;

        public int LikeNumber
        {
            get { return likeNumber; }
            set { likeNumber = value; OnPropertyChanged(); }
        }

        private Command increaseNumber;
        public Command IncreaseNumber
        {
            get
            {
                increaseNumber = new Command(() => { LikeNumber++; });
                return increaseNumber;
            }
        }

        private Command decreaseNumber;
        public Command DecreaseNumber
        {
            get
            {
                if (decreaseNumber == null)
                { 
                    decreaseNumber = new Command(() => 
                    { 
                        if (likeNumber != 0)
                            LikeNumber--; 
                    });
                }
                return decreaseNumber;
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

    }
}
