using Maui_Test_App.ViewModel;

namespace Maui_Test_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MonkeysViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

}
