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
		lblTotalScore.Text =  scoreHole1.ToString();
    }

    private void entryHole2_Completed(object sender, EventArgs e)
    {
		int scoreHole2 = int.Parse(entryHole2.Text);
        UpdateTotal(scoreHole2);
        
		
    }
	private void UpdateTotal(int holeScore)
	{
        int previousTotal = Convert.ToInt32(lblTotalScore.Text);
        int totalScore = holeScore + previousTotal;
        lblTotalScore.Text = totalScore.ToString();

    }

    private void entryHole3_Completed(object sender, EventArgs e)
    {
        int scoreHole3 = int.Parse(entryHole2.Text);
        UpdateTotal(scoreHole3);
    }

    private void entryHole4_Completed(object sender, EventArgs e)
    {
        int scoreHole4 = int.Parse(entryHole2.Text);
        UpdateTotal(scoreHole4);
    }

    private void entryHole5_Completed(object sender, EventArgs e)
    {
        int scoreHole5 = int.Parse(entryHole2.Text);
        UpdateTotal(scoreHole5);
    }

    private void enrtyHole6_Completed(object sender, EventArgs e)
    {
        int scoreHole6 = int.Parse(entryHole2.Text);
        UpdateTotal(scoreHole6);
    }

    private void entryHole7_Completed(object sender, EventArgs e)
    {

    }

    private void entryHole8_Completed(object sender, EventArgs e)
    {

    }

    private void entryHole9_Completed(object sender, EventArgs e)
    {

    }
}