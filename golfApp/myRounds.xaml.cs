namespace golfApp;

public partial class myRounds : ContentPage
{
	private int [] roundScores;
	private string roundDate;
	public myRounds(int[] scores, string date)
	{
		InitializeComponent();

		roundScores = scores;
		roundDate = date;
		
		lblScores.Text = "Scores: " + string.Join(", ", roundScores);
		lblDate.Text = "Date: " + roundDate;

    }
}