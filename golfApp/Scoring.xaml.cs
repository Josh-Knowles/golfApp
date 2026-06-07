namespace golfApp;

public partial class Scoring : ContentPage
{
	public Scoring()
	{
		InitializeComponent();
		
	}

    private void entryHole1_Completed(object sender, EventArgs e)
    {
		int scoreHole1 = int.Parse(entryHole1.Text);
		lblTotalScore.Text = "Total Score: " + scoreHole1.ToString();
    }

    private void entryHole2_Completed(object sender, EventArgs e)
    {
		int scoreHole2 = int.Parse(entryHole2.Text);
		
    }
}