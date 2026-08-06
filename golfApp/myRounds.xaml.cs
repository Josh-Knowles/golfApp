namespace golfApp;

public partial class myRounds : ContentPage
{
	private int [] roundScores;
	private string roundDate;
	private string totalScore;
	private string roundtoPar;
	private string courseName;
    public myRounds(int[] scores, string date, string total, string toPar, string course)
	{
		InitializeComponent();

		roundScores = scores;
		roundDate = date;
		totalScore = total;
		roundtoPar = toPar;
		courseName = course;

		lblScores.Text = "Scores: " + string.Join(", ", roundScores);
		lblDate.Text = "Date: " + roundDate;
		lblPar.Text =  roundtoPar ;
		lblCourse.Text = "Course: " + courseName;
		lblTotal.Text =   totalScore;

    }
}