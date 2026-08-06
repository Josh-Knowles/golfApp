namespace golfApp;

public partial class scoring18 : ContentPage
{
    private string courseName;
    public scoring18(string course)
	{
        courseName = course;
        InitializeComponent();
    }
    private void entryHole1_Completed(object sender, EventArgs e)
    {
        TotalScore ();
        ToPar();
    }

    private void entryHole2_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }
    
    public int TotalScore()
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
        
        int scoreHole10 = Convert.ToInt32( entryHole10.Text);
        totalScore += scoreHole10;

        int scoreHole11 = Convert.ToInt32(entryHole11.Text);
        totalScore += scoreHole11;

        int scoreHole12 = Convert.ToInt32(entryHole12.Text);
        totalScore += scoreHole12;

        int scoreHole13 = Convert.ToInt32(entryHole13.Text);
        totalScore += scoreHole13;

        int scoreHole14 = Convert.ToInt32(entryHole14.Text);
        totalScore += scoreHole14;

        int scoreHole15 = Convert.ToInt32(entryHole15.Text);
        totalScore += scoreHole15;

        int scoreHole16 = Convert.ToInt32(entryHole16.Text);
        totalScore += scoreHole16;

        int scoreHole17 = Convert.ToInt32(entryHole17.Text);
        totalScore += scoreHole17;

        int scoreHole18 = Convert.ToInt32(entryHole18.Text);
        totalScore += scoreHole18;

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
        int scoreHole10 = Convert.ToInt32(entryHole10.Text);
        if (scoreHole10 != 0)
        {
            toPar += (scoreHole10 - Convert.ToInt32(lblHole10Par.Text.Replace("Par ", "")));
        }

        int scoreHole11 = Convert.ToInt32(entryHole11.Text);
        if (scoreHole11 != 0)
        {
            toPar += (scoreHole11 - Convert.ToInt32(lblHole11Par.Text.Replace("Par ", "")));
        }

        int scoreHole12 = Convert.ToInt32(entryHole12.Text);
        if (scoreHole12 != 0)
        {
            toPar += (scoreHole12 - Convert.ToInt32(lblHole12Par.Text.Replace("Par ", "")));
        }

        int scoreHole13 = Convert.ToInt32(entryHole13.Text);
        if (scoreHole13 != 0)
        {
            toPar += (scoreHole13 - Convert.ToInt32(lblHole13Par.Text.Replace("Par ", "")));
        }

        int scoreHole14 = Convert.ToInt32(entryHole14.Text);
        if (scoreHole14 != 0)
        {
            toPar += (scoreHole14 - Convert.ToInt32(lblHole14Par.Text.Replace("Par ", "")));
        }

        int scoreHole15 = Convert.ToInt32(entryHole15.Text);
        if (scoreHole15 != 0)
        {
            toPar += (scoreHole15 - Convert.ToInt32(lblHole15Par.Text.Replace("Par ", "")));
        }

        int scoreHole16 = Convert.ToInt32(entryHole16.Text);
        if (scoreHole16 != 0)
        {
            toPar += (scoreHole16 - Convert.ToInt32(lblHole16Par.Text.Replace("Par ", "")));
        }

        int scoreHole17 = Convert.ToInt32(entryHole17.Text);
        if (scoreHole17 != 0)
        {
            toPar += (scoreHole17 - Convert.ToInt32(lblHole17Par.Text.Replace("Par ", "")));
        }

        int scoreHole18 = Convert.ToInt32(entryHole18.Text);
        if (scoreHole18 != 0)
        {
            toPar += (scoreHole18 - Convert.ToInt32(lblHole18Par.Text.Replace("Par ", "")));
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
        ToPar() ;
    }

    private void entryHole9_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole10_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole11_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole12_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole13_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole14_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole15_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole16_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole17_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void entryHole18_Completed(object sender, EventArgs e)
    {
        TotalScore();
        ToPar();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private async void btnFinishRound_Clicked(object sender, EventArgs e)
    {
        int[] roundScores = new int[18];
        roundScores[0] = Convert.ToInt32(entryHole1.Text);
        roundScores[1] = Convert.ToInt32(entryHole2.Text);
        roundScores[2] = Convert.ToInt32(entryHole3.Text);
        roundScores[3] = Convert.ToInt32(entryHole4.Text);
        roundScores[4] = Convert.ToInt32(entryHole5.Text);
        roundScores[5] = Convert.ToInt32(entryHole6.Text);
        roundScores[6] = Convert.ToInt32(entryHole7.Text);
        roundScores[7] = Convert.ToInt32(entryHole8.Text);
        roundScores[8] = Convert.ToInt32(entryHole9.Text);
        roundScores[9] = Convert.ToInt32(entryHole10.Text);
        roundScores[10] = Convert.ToInt32(entryHole11.Text);
        roundScores[11] = Convert.ToInt32(entryHole12.Text);
        roundScores[12] = Convert.ToInt32(entryHole13.Text);
        roundScores[13] = Convert.ToInt32(entryHole14.Text);
        roundScores[14] = Convert.ToInt32(entryHole15.Text);
        roundScores[15] = Convert.ToInt32(entryHole16.Text);
        roundScores[16] = Convert.ToInt32(entryHole17.Text);
        roundScores[17] = Convert.ToInt32(entryHole18.Text);

        TotalScore();
        ToPar();
        String totalScore = lblTotalScore.Text;
        string toPar = lblToPar.Text;
        
        string roundDate = DateTime.Now.ToString("MM/dd/yyyy");
        await Navigation.PushAsync(new myRounds(roundScores, roundDate, totalScore, toPar, courseName));
        
    }
}