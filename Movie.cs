namespace CustomersManagement;

public record Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Genre { get; set; }
    public int Year { get; set; }
    public double Rating { get; set; }
    public DateTime CreatedAt { get; set; }
}