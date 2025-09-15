namespace EventVsBindingMauiApp_
{
    public partial class MainPage : ContentPage
    {
        public string Message { get; set; }
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
            returnMessageLabel.Text = "Ilość to " + Message.Length;
        }
    }
}
