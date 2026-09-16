namespace golfApp;

public partial class RoundSetUp : ContentPage
{
    public RoundSetUp()
    {
        InitializeComponent();
        
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadCoursesFromCsvAsync();
    }

    private async Task LoadCoursesFromCsvAsync()
    {
        try
        {
            // Open file from MAUI Resources/Raw folder
            using var stream = await FileSystem.OpenAppPackageFileAsync("golf.csv");
            using var reader = new StreamReader(stream);

            List<string> courseNames = new List<string>();

            // Skip header line (courseName,hole,holePar)
            string header = await reader.ReadLineAsync();

            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] values = line.Split(',');
                string courseName = values[0].Trim();

                // Add unique course names to list
                if (!courseNames.Contains(courseName))
                {
                    courseNames.Add(courseName);
                }
            }

            // Populate CoursePicker on UI
            CoursePicker.ItemsSource = courseNames;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Could not load CSV: {ex.Message}", "OK");
        }
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