using System.Diagnostics;

namespace CustomersManagement;

public partial class UpdateScreen : Form
{
    DashboardScreen _parent;
    int _movieId;

    public UpdateScreen(DashboardScreen parent, Movie movie)
    {
        InitializeComponent();
        _parent = parent;
        titleInput.Text = movie.Title;
        genreInput.Text = movie.Genre;
        yearInput.Text = movie.Year.ToString();
        ratingInput.Text = movie.Rating.ToString();
        _movieId = movie.Id;
    }

    private async void saveButton_Click(object sender, EventArgs e)
    {
        // Validare
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
            Movie updatedMovie = new Movie
            {
                Id = _movieId,
                Title = titleInput.Text,
                Genre = genreInput.Text,
                Year = year,
                Rating = rating
            };
            await dbHelper.UpdateMovieAsync(updatedMovie);
            await _parent.LoadDataAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("Update Movie error: {0}", ex.Message);
            MessageBox.Show(this, "An error occured while trying to update a movie.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            this.Hide();
        }
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }
}