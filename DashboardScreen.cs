using System.Data;
using System.Diagnostics;

namespace CustomersManagement;

public partial class DashboardScreen : Form
{
    public DashboardScreen()
    {
        InitializeComponent();
    }

    private async void DashboardScreen_Load(object sender, EventArgs e)
    {
        try
        {
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("DashboardScreen load error: ", ex.Message);
            MessageBox.Show(this, "An error occured while loading the data.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public async Task LoadDataAsync()
    {
        try
        {
            DbHelper dbHelper = new DbHelper();
            List<Movie> moviesList = await dbHelper.GetMoviesAsync();

            DataTable moviesTable = new DataTable();
            moviesTable.Columns.Add("Id", typeof(int));
            moviesTable.Columns.Add("Title", typeof(string));
            moviesTable.Columns.Add("Genre", typeof(string));
            moviesTable.Columns.Add("Year", typeof(int));
            moviesTable.Columns.Add("Rating", typeof(double));
            moviesTable.Columns.Add("CreatedAt", typeof(DateTime));

            foreach (var movie in moviesList)
            {
                moviesTable.Rows.Add(movie.Id, movie.Title, movie.Genre, movie.Year, movie.Rating, movie.CreatedAt);
            }

            dataGridView1.DataSource = moviesTable;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        catch (Exception ex)
        {
            Trace.TraceError("LoadDataAsync failed: {0}", ex.Message);
            MessageBox.Show("An error occured while loading the data.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        try
        {
            CreateScreen createScreen = new CreateScreen(this);
            createScreen.ShowDialog();
        }
        catch (Exception ex)
        {
            Trace.TraceError("Add Button Click failed: {0}", ex.Message);
            MessageBox.Show(this, "An error occured while opening the Add Screen",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void deleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Please select a movie row before attempting to delete.",
                    "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(this, "Are you sure you want to delete this movie?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            DbHelper dbHelper = new DbHelper();
            int selectedMovieId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            await dbHelper.DeleteMovieAsync(selectedMovieId);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("Delete Movie error: {0}", ex.Message);
            MessageBox.Show(this, "An error occured while trying to delete a movie.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Please select a movie row before attempting to update.",
                    "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Movie movie = new Movie()
            {
                Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value),
                Title = dataGridView1.SelectedRows[0].Cells["Title"].Value.ToString(),
                Genre = dataGridView1.SelectedRows[0].Cells["Genre"].Value.ToString(),
                Year = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Year"].Value),
                Rating = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells["Rating"].Value),
            };
            UpdateScreen updateScreen = new UpdateScreen(this, movie);
            updateScreen.ShowDialog();
        }
        catch (Exception ex)
        {
            Trace.TraceError("Update Movie error: {0}", ex.Message);
            MessageBox.Show(this, "An error occured while trying to update a movie.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}