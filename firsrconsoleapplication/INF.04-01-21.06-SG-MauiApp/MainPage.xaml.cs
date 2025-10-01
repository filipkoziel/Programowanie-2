namespace INF._04_01_21._06_SG_MauiApp
{
    public partial class MainPage : ContentPage
    {
        public string Email { get; set; }
        public string Password1String { get; set; }
        public string Password2String { get; set; }
        private string returnMessage;
        public string ReturnMessage
        {
            get { return returnMessage; }
            set { returnMessage = value; OnPropertyChanged(); }
        }

        public MainPage()
        {
            InitializeComponent();
            ReturnMessage = "Autor 01234567890";
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!Email.Contains("@"))
            {
                ReturnMessage = "Nieprawidłowy adres e-mail";
            }
            else if (!(Password1String == Password2String))
            {
                ReturnMessage = "Hasła się różnią";
            }
            else
            {
                ReturnMessage = "Witaj " + Email;
            }   
        }
    }
}
