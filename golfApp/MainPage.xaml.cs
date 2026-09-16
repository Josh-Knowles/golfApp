using SQLite;

namespace golfApp
{
    public partial class MainPage : ContentPage
    {

        int holeAmount;
        SQLiteConnection sqlite_conn;
        public MainPage()
        {
            InitializeComponent();

            

        }

        // takes the user to the round set up page when they click the button
        private async void StartRoundButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RoundSetUp());
        }

        // takes the user to the my rounds page when they click the button
        private async void btnMyRounds_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new myRounds());
        }
    }
}
