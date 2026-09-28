namespace golfApp;

public partial class myRounds : ContentPage
{
	private int [] roundScores;
	private string roundDate;
	private string totalScore;
	private string roundtoPar;
	private string courseName;

    public myRounds()
    {
        InitializeComponent();
        ShowAllRounds();
    }
    public myRounds(int[] scores, string date, string total, string toPar, string course)
    {
        InitializeComponent();
        //Preferences.Clear();
        SaveRound(scores, date, total, toPar, course);
        ShowAllRounds();
    }
    
    private void SaveRound(int[] scores, string date, string total, string toPar, string course)
    {        
        
        string newRound = date + "*"  + course + "*" + toPar+ "*"+ total+ "*"+ string.Join(",", scores);

        string previousRounds = Preferences.Get("SavedGolfRounds", string.Empty);

        if (!string.IsNullOrEmpty(previousRounds))
        {
            previousRounds += "/"; 
        }
        previousRounds += newRound;
        Preferences.Set("SavedGolfRounds", previousRounds);
    }

    private void ShowAllRounds()
    {
            string previousRounds = Preferences.Get("SavedGolfRounds", string.Empty);
    
            lblDate.Text = "";
            lblTotal.Text = "";
            lblPar.Text = "";
            lblScores.Text = "";
            lblCourse.Text = "";
            
            string[] allRounds = previousRounds.Split('/');
            Array.Reverse(allRounds); 


        foreach (string round in allRounds)
            {
                string[] parts = round.Split('*');

                if (parts.Length >= 4)
                {
                    string date = parts[0];
                    
                    string course = parts[1];
                    string toPar = parts[2];
                    string total = parts[3];
                    string scores = parts[4];


                lblCourse.Text += "Date: " + date+ "\n"+"Course: " +course+ "\n" +total + "\n" +toPar + "\n" + "Scores: " + scores + "\n" + "\n";
                    }
            }
    }
}
