namespace _2024_06_MauiApp
{
    public partial class MainPage : ContentPage
    {
        public List<String> Images { get; set; }
        public MainPage()
        {
            Images = new List<String>()
            {
                "k1.jpg",
                "k2.jpg",
                "k3.jpg",
                "k4.jpg",
                "k5.jpg",
                "k6.jpg",
                "question.jpg"
            };
            InitializeComponent();
        }
    }
}
