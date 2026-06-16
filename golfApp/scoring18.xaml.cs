namespace golfApp;

public partial class scoring18 : ContentPage
{
	public scoring18()
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

        int toPar = 0;
        if (scoreHole1 != 0)
        { toPar += (scoreHole1 - Convert.ToInt32(lblHole1Par.Text.Replace("Par ", ""))); }

        if (scoreHole2 != 0)
        { toPar += (scoreHole2 - Convert.ToInt32(lblHole2Par.Text.Replace("Par ", ""))); }

        if (scoreHole3 != 0)
        { toPar += (scoreHole3 - Convert.ToInt32(lblHole3Par.Text.Replace("Par ", ""))); }

        if (scoreHole4 != 0)
        {
            toPar += (scoreHole4 - Convert.ToInt32(lblHole4Par.Text.Replace("Par ", "")));
        }
        if (scoreHole5 != 0)
        {
            toPar += (scoreHole5 - Convert.ToInt32(lblHole5Par.Text.Replace("Par ", "")));
        }
        if (scoreHole6 != 0)
        {
            toPar += (scoreHole6 - Convert.ToInt32(lblHole6Par.Text.Replace("Par ", "")));
        }
        if (scoreHole7 != 0)
        {
            toPar += (scoreHole7 - Convert.ToInt32(lblHole7Par.Text.Replace("Par ", "")));
        }
        if (scoreHole8 != 0)
        {
            toPar += (scoreHole8 - Convert.ToInt32(lblHole8Par.Text.Replace("Par ", "")));
        }
        if (scoreHole9 != 0)
        {
            toPar += (scoreHole9 - Convert.ToInt32(lblHole9Par.Text.Replace("Par ", "")));
        }
        if (scoreHole10 != 0)
        {
            toPar += (scoreHole10 - Convert.ToInt32(lblHole10Par.Text.Replace("Par ", "")));
        }
        if (scoreHole11 != 0)
        {
            toPar += (scoreHole11 - Convert.ToInt32(lblHole11Par.Text.Replace("Par ", "")));
        }
        if (scoreHole12 != 0)
        {
            toPar += (scoreHole12 - Convert.ToInt32(lblHole12Par.Text.Replace("Par ", "")));
        }
        if (scoreHole13 != 0)
        {
            toPar += (scoreHole13 - Convert.ToInt32(lblHole13Par.Text.Replace("Par ", "")));
        }
        if (scoreHole14 != 0)
        {
            toPar += (scoreHole14 - Convert.ToInt32(lblHole14Par.Text.Replace("Par ", "")));
        }
        if (scoreHole15 != 0)
        {
            toPar += (scoreHole15 - Convert.ToInt32(lblHole15Par.Text.Replace("Par ", "")));
        }
        if (scoreHole16 != 0)
        {
            toPar += (scoreHole16 - Convert.ToInt32(lblHole16Par.Text.Replace("Par ", "")));
        }
        if (scoreHole17 != 0)
        {
            toPar += (scoreHole17 - Convert.ToInt32(lblHole17Par.Text.Replace("Par ", "")));
        }
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

    private void entryHole10_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole11_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole12_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole13_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole14_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole15_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole16_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole17_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }

    private void entryHole18_Completed(object sender, EventArgs e)
    {
        UpdateTotal();
    }
}