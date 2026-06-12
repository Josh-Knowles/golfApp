namespace golfApp
{
    public partial class MainPage : ContentPage
    {

        int holeAmount;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scoring());
            

        }

        private async void EighteenHolesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new scoring18 ());
            
        }
    }
}
