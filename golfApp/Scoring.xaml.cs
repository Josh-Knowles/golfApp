namespace golfApp;

public partial class Scoring : ContentPage
{
    private string courseName;
    public Scoring(string course)
	{
		InitializeComponent();
		courseName = course;
	}

    private void entryHole1_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole2_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }
    private int TotalScore()
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
        return totalScore;

    }

    private int ToPar()
    {
        int toPar = 0;
        int scoreHole1 = Convert.ToInt32(entryHole1.Text);
        if (scoreHole1 != 0)
        { toPar += (scoreHole1 - Convert.ToInt32(lblHole1Par.Text.Replace("Par ", ""))); }

        int scoreHole2 = Convert.ToInt32(entryHole2.Text);
        if (scoreHole2 != 0)
        { toPar += (scoreHole2 - Convert.ToInt32(lblHole2Par.Text.Replace("Par ", ""))); }

        int scoreHole3 = Convert.ToInt32(entryHole3.Text);
        if (scoreHole3 != 0)
        { toPar += (scoreHole3 - Convert.ToInt32(lblHole3Par.Text.Replace("Par ", ""))); }

        int scoreHole4 = Convert.ToInt32(entryHole4.Text);
        if (scoreHole4 != 0)
        {
            toPar += (scoreHole4 - Convert.ToInt32(lblHole4Par.Text.Replace("Par ", "")));
        }

        int scoreHole5 = Convert.ToInt32(entryHole5.Text);
        if (scoreHole5 != 0)
        {
            toPar += (scoreHole5 - Convert.ToInt32(lblHole5Par.Text.Replace("Par ", "")));
        }
        int scoreHole6 = Convert.ToInt32(entryHole6.Text);

        if (scoreHole6 != 0)
        {
            toPar += (scoreHole6 - Convert.ToInt32(lblHole6Par.Text.Replace("Par ", "")));
        }

        int scoreHole7 = Convert.ToInt32(entryHole7.Text);
        if (scoreHole7 != 0)
        {
            toPar += (scoreHole7 - Convert.ToInt32(lblHole7Par.Text.Replace("Par ", "")));
        }

        int scoreHole8 = Convert.ToInt32(entryHole8.Text);
        if (scoreHole8 != 0)
        {
            toPar += (scoreHole8 - Convert.ToInt32(lblHole8Par.Text.Replace("Par ", "")));
        }

        int scoreHole9 = Convert.ToInt32(entryHole9.Text);
        if (scoreHole9 != 0)
        {
            toPar += (scoreHole9 - Convert.ToInt32(lblHole9Par.Text.Replace("Par ", "")));
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
        return toPar;
    }


    private void entryHole3_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole4_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole5_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole6_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole7_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole8_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole9_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private async void btnFinishRound_Clicked(object sender, EventArgs e)
    {
        int[] roundScores = new int[9];
        roundScores[0] = Convert.ToInt32(entryHole1.Text);
        roundScores[1] = Convert.ToInt32(entryHole2.Text);
        roundScores[2] = Convert.ToInt32(entryHole3.Text);
        roundScores[3] = Convert.ToInt32(entryHole4.Text);
        roundScores[4] = Convert.ToInt32(entryHole5.Text);
        roundScores[5] = Convert.ToInt32(entryHole6.Text);
        roundScores[6] = Convert.ToInt32(entryHole7.Text);
        roundScores[7] = Convert.ToInt32(entryHole8.Text);
        roundScores[8] = Convert.ToInt32(entryHole9.Text);
       
        TotalScore();
        ToPar();
        String totalScore = lblTotalScore.Text;
        string toPar = lblToPar.Text;

        string roundDate = DateTime.Now.ToString("MM/dd/yyyy");
        await Navigation.PushAsync(new myRounds(roundScores, roundDate, totalScore, toPar, courseName));
    }
}