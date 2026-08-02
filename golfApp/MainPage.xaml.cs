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
        







        private async void StartRoundButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RoundSetUp());
        }

        private async void btnMyRounds_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new myRounds());
        }
    }
}
