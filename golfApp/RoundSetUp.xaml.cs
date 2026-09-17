namespace golfApp;

public partial class RoundSetUp : ContentPage
{
    public RoundSetUp()
    {
        InitializeComponent();
        LoadCourses();
    }

    private void LoadCourses()
    {
        List<string> courseNames = new List<string>();

        // Open the text file using StreamReader
        using (StreamReader reader = new StreamReader(FileSystem.OpenAppPackageFileAsync("golf.txt").Result))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(',');
                string name = parts[0].Trim();

                // Ignore header row
                if (name == "courseName") continue;

                // Only add course name if it hasn't been added yet
                if (!courseNames.Contains(name))
                {
                    courseNames.Add(name);
                }
            }
        }

        CoursePicker.ItemsSource = courseNames;
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


        // if there is a selected item in each picker go to the page corisponding to the selected item and pass the course name to the next page
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