namespace golfApp;

public partial class RoundSetUp : ContentPage
{
    public RoundSetUp()
    {
        InitializeComponent();
    }

    private void CoursePicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void holePicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnRoundSart_Clicked(object sender, EventArgs e)
    {
        // do data base call to get all course names 
        // for all course names display on screen in a picker
        //CoursePicker.Items.Add

        if (holePicker.SelectedItem != null && CoursePicker.SelectedItem != null)
        {
            if (holePicker.SelectedItem.ToString() == "9 Holes")
            {
                string courseName = CoursePicker.SelectedItem.ToString();
                Navigation.PushAsync(new Scoring(courseName));

            }
            else if (holePicker.SelectedItem.ToString() == "18 Holes")
            {
                string courseName = CoursePicker.SelectedItem.ToString();
                Navigation.PushAsync(new scoring18(courseName));
            }
        }
    }
}