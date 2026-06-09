namespace golfApp;

public partial class Scoring : ContentPage
{
	public Scoring()
	{
		InitializeComponent();
		
	}

    private void entryHole1_Completed(object sender, EventArgs e)
    {
		int scoreHole1 = Convert.ToInt32(entryHole1.Text);
		lblTotalScore.Text = "Total score: " + scoreHole1.ToString();
        UpdateToPar(scoreHole1, Convert.ToInt32(lblHole1Par.Text.Replace("Par ", "")));
    }

    private void entryHole2_Completed(object sender, EventArgs e)
    {
		int scoreHole2 = Convert.ToInt32(entryHole2.Text);
        UpdateTotal(scoreHole2);
        
		
    }
	private void UpdateTotal(int holeScore)
	{
        // gets the the total score from the label and reoves the text saying total score so it can be usd as an int in the calculation
        int previousTotal = Convert.ToInt32(lblTotalScore.Text.Replace("Total score: ", ""));
        int totalScore = holeScore + previousTotal;
        lblTotalScore.Text = "Total score: " + totalScore.ToString();
        holeScore = 0;

    }
    private void UpdateToPar(int holeScore, int holePar)
    {

        int previousToPar = Convert.ToInt32(lblToPar.Text.Replace("To par +-: ", ""));
        
        int scoreDifference = holeScore - holePar;
        int newToPar = previousToPar + scoreDifference;
        lblToPar.Text = "To par +-: " + newToPar.ToString();

    }

    private void entryHole3_Completed(object sender, EventArgs e)
    {
        int scoreHole3 = Convert.ToInt32(entryHole3.Text);
        UpdateTotal(scoreHole3);
    }

    private void entryHole4_Completed(object sender, EventArgs e)
    {
        int scoreHole4 = Convert.ToInt32(entryHole4.Text);
        UpdateTotal(scoreHole4);
    }

    private void entryHole5_Completed(object sender, EventArgs e)
    {
        int scoreHole5 = Convert.ToInt32(entryHole5.Text);
        UpdateTotal(scoreHole5);
    }

    private void entryHole6_Completed(object sender, EventArgs e)
    {
        int scoreHole6 = Convert.ToInt32(entryHole6.Text);
        UpdateTotal(scoreHole6);
    }

    private void entryHole7_Completed(object sender, EventArgs e)
    {
        int scoreHole7 = Convert.ToInt32(entryHole7.Text);
        UpdateTotal(scoreHole7);    
    }

    private void entryHole8_Completed(object sender, EventArgs e)
    {
        int scoreHole8 = Convert.ToInt32(entryHole8.Text);
        UpdateTotal(scoreHole8);
    }

    private void entryHole9_Completed(object sender, EventArgs e)
    {
        int scoreHole9 = Convert.ToInt32(entryHole9.Text);
        UpdateTotal(scoreHole9);
    }
}