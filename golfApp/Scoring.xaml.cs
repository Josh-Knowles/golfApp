namespace golfApp;

public partial class Scoring : ContentPage
{
	public Scoring()
	{
		InitializeComponent();
		
	}

    private void entryHole1_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole2_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }
	private void UpdateTotal()
	{
        int totalScore = 0;

        int scoreHole1 = Convert.ToInt32(entryHole1.Text);
        totalScore += scoreHole1;

        int scoreHole2 = Convert.ToInt32(entryHole2.Text);
        totalScore += scoreHole2;

        int scoreHole3 = Convert.ToInt32(entryHole3.Text);
        totalScore += scoreHole3;

        int scoreHole4 = Convert.ToInt32(entryHole4.Text);
        totalScore += scoreHole4;

        int scoreHole5 = Convert.ToInt32(entryHole5.Text);
        totalScore += scoreHole5;

        int scoreHole6 = Convert.ToInt32(entryHole6.Text);
        totalScore += scoreHole6;

        int scoreHole7 = Convert.ToInt32(entryHole7.Text);
        totalScore += scoreHole7;

        int scoreHole8 = Convert.ToInt32(entryHole8.Text);
        totalScore += scoreHole8;

        int scoreHole9 = Convert.ToInt32(entryHole9.Text);
        totalScore += scoreHole9;

        lblTotalScore.Text = "Total Score: " + totalScore.ToString();

        int toPar = 0;
        if (scoreHole1 != 0)
        { toPar = scoreHole1 - 4; }
        
        if (scoreHole2 != 0) 
        { toPar = scoreHole2 - 4; }

        if (scoreHole3 != 0)
        { toPar = scoreHole3 - 4; }

        if (scoreHole4 != 0)
        {
            toPar = scoreHole4 - 3;
        }
        if (scoreHole5 != 0)
        {
            toPar = scoreHole5 - 4;
        }
        if (scoreHole6 != 0)
        {
            toPar = scoreHole6 - 4;
        }
        if (scoreHole7 != 0)
        {
            toPar = scoreHole7 - 3;
        }
        if (scoreHole8 != 0)
        {
            toPar = scoreHole8 - 5;
        }
        if (scoreHole9 != 0)
        {
            toPar = scoreHole9 - 4;
        }
        if (toPar == 0)
        {
            lblToPar.Text = "To Par: E";
        }
        else
        {
            if (toPar > 0) 
            {
                lblToPar.Text = "To Par: +" + toPar.ToString();
            }
            else
            {
                lblToPar.Text = "To Par: " + toPar.ToString();
            }
        }
        
    }
    

    private void entryHole3_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole4_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole5_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole6_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole7_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole8_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole9_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }
}