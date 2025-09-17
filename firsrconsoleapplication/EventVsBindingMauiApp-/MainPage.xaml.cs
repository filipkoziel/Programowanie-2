namespace EventVsBindingMauiApp_
{
    public partial class MainPage : ContentPage
    {
        public string Message { get; set; }
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

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            RotationLabel.Rotation = RotationSlider.Value;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ReturnMessage = "Ilość to " + Message.Length;
            //OnPropertyChanged(nameof(ReturnMessage));
        }
    }
}
