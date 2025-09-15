using EventVsBindingMauiApp.Models;
using EventVsBindingMauiApp.PageModels;

namespace EventVsBindingMauiApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}