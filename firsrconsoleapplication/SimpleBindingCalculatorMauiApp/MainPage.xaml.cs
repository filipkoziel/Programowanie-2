namespace SimpleBindingCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string StrFirstNumber { get; set; }
        public string StrSecondNumber { get; set; }
        private string returnMessage;
        public string ReturnMessage
        {
            get { return returnMessage; }
            set { returnMessage = value; OnPropertyChanged(); }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!int.TryParse(StrFirstNumber, out int firstNumber)
                || !int.TryParse(StrSecondNumber, out int secondNumber))
            {
                ReturnMessage = "Któraś z podanych liczb nie była liczbą całkowitą lub była pusta";
                return;
            }

            int result = firstNumber + secondNumber;

            ReturnMessage = "wynik to: " + result;
        }
    }
}
