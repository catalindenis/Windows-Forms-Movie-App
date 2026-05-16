using System.Diagnostics;

namespace CustomersManagement;

public partial class CreateScreen : Form
{
    DashboardScreen _parent;

    public CreateScreen(DashboardScreen parent)
    {
        _parent = parent;
        InitializeComponent();
    }

    private async void saveButton_Click(object sender, EventArgs e)
    {
        // Validare simpla
        if (string.IsNullOrWhiteSpace(titleInput.Text))
        {
            MessageBox.Show(this, "Title is required.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            titleInput.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(genreInput.Text))
        {
            MessageBox.Show(this, "Genre is required.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            genreInput.Focus();
            return;
        }

        if (!int.TryParse(yearInput.Text, out int year) || year < 1888 || year > 2100)
        {
            MessageBox.Show(this, "Please enter a valid year (e.g. 2023).", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            yearInput.Focus();
            return;
        }

        if (!double.TryParse(ratingInput.Text, out double rating) || rating < 0 || rating > 10)
        {
            MessageBox.Show(this, "Please enter a valid rating between 0 and 10.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ratingInput.Focus();
            return;
        }

        try
        {
            DbHelper dbHelper = new DbHelper();
            Movie newMovie = new Movie
            {
                Title = titleInput.Text,
                Genre = genreInput.Text,
                Year = year,
                Rating = rating
            };
            await dbHelper.CreateMovieAsync(newMovie);
            await _parent.LoadDataAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("Create Movie error: {0}", ex.Message);
            MessageBox.Show(this, "An error occured while trying to create a movie.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            this.Hide();
        }
    }

    private void lastNameInput_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}